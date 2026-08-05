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

// Image 31: Unity.Mathematics.dll - Assembly: Unity.Mathematics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57173-57266
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Mathematics.PerformanceTests")]
[assembly: InternalsVisibleTo("Unity.Mathematics.Tests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Unity.IL2CPP.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 57174
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Mathematics
{
	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct AffineTransform : IEquatable<Unity.Mathematics.AffineTransform>, IFormattable // TypeDefIndex: 57175
	{
		// Fields
		public float3x3 rs; // 0x00
		public float3 t; // 0x24
		public static readonly AffineTransform identity; // 0x00
	
		// Constructors
		public AffineTransform(float3 translation, quaternion rotation); // 0x000000018B27CF08-0x000000018B27CF60
		public AffineTransform(float3 translation, quaternion rotation, float3 scale); // 0x000000018B27CE60-0x000000018B27CF08
		public AffineTransform(float3 translation, float3x3 rotationScale); // 0x0000000184DB21B0-0x0000000184DB21E0
		public AffineTransform(float3x3 rotationScale); // 0x000000018B27CDF8-0x000000018B27CE60
		public AffineTransform(RigidTransform rigid); // 0x000000018B27CDA0-0x000000018B27CDF8
		public AffineTransform(float3x4 m); // 0x0000000185F0065C-0x0000000185F00794
		public AffineTransform(float4x4 m); // 0x0000000185F00794-0x0000000185F00990
		static AffineTransform(); // 0x0000000184CE39A0-0x0000000184CE3A40
	
		// Methods
		public bool Equals(AffineTransform rhs); // 0x000000018B27C704-0x000000018B27C76C
		public override bool Equals(object o); // 0x000000018B27C688-0x000000018B27C704
		public override int GetHashCode(); // 0x000000018B27C76C-0x000000018B27C79C
		public override string ToString(); // 0x000000018B27CA70-0x000000018B27CDA0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B27C79C-0x000000018B27CA70
	}

	[Il2CppEagerStaticClassConstruction]
	public static class math // TypeDefIndex: 57179
	{
		// Fields
		public const double E_DBL = 2.718281828459045; // Metadata: 0x0234AEE2
		public const double LOG2E_DBL = 1.4426950408889634; // Metadata: 0x0234AEEA
		public const double LOG10E_DBL = 0.4342944819032518; // Metadata: 0x0234AEF2
		public const double LN2_DBL = 0.6931471805599453; // Metadata: 0x0234AEFA
		public const double LN10_DBL = 2.302585092994046; // Metadata: 0x0234AF02
		public const double PI_DBL = 3.141592653589793; // Metadata: 0x0234AF0A
		public const double PI2_DBL = 6.283185307179586; // Metadata: 0x0234AF12
		public const double PIHALF_DBL = 1.5707963267948966; // Metadata: 0x0234AF1A
		public const double TAU_DBL = 6.283185307179586; // Metadata: 0x0234AF22
		public const double TODEGREES_DBL = 57.29577951308232; // Metadata: 0x0234AF2A
		public const double TORADIANS_DBL = 0.017453292519943295; // Metadata: 0x0234AF32
		public const double SQRT2_DBL = 1.4142135623730951; // Metadata: 0x0234AF3A
		public const double EPSILON_DBL = 2.220446049250313E-16; // Metadata: 0x0234AF42
		public const double INFINITY_DBL = 1D / 0D; // Metadata: 0x0234AF4A
		public const double NAN_DBL = 0D / 0D; // Metadata: 0x0234AF52
		public const float FLT_MIN_NORMAL = 1.1754944E-38f; // Metadata: 0x0234AF5A
		public const double DBL_MIN_NORMAL = 2.2250738585072014E-308; // Metadata: 0x0234AF5E
		public const float E = 2.7182817f; // Metadata: 0x0234AF66
		public const float LOG2E = 1.442695f; // Metadata: 0x0234AF6A
		public const float LOG10E = 0.4342945f; // Metadata: 0x0234AF6E
		public const float LN2 = 0.6931472f; // Metadata: 0x0234AF72
		public const float LN10 = 2.3025851f; // Metadata: 0x0234AF76
		public const float PI = 3.1415927f; // Metadata: 0x0234AF7A
		public const float PI2 = 6.2831855f; // Metadata: 0x0234AF7E
		public const float PIHALF = 1.5707964f; // Metadata: 0x0234AF82
		public const float TAU = 6.2831855f; // Metadata: 0x0234AF86
		public const float TODEGREES = 57.29578f; // Metadata: 0x0234AF8A
		public const float TORADIANS = 0.017453292f; // Metadata: 0x0234AF8E
		public const float SQRT2 = 1.4142135f; // Metadata: 0x0234AF92
		public const float EPSILON = 1.1920929E-07f; // Metadata: 0x0234AF96
		public const float INFINITY = 1F / 0F; // Metadata: 0x0234AF9A
		public const float NAN = 0F / 0F; // Metadata: 0x0234AF9E
	
		// Nested types
		public enum RotationOrder : byte // TypeDefIndex: 57176
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			Default = 4,
			ZYX = 5
		}
	
		public enum ShuffleComponent : byte // TypeDefIndex: 57177
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
	
		internal struct LongDoubleUnion // TypeDefIndex: 57178
		{
			// Fields
			public long longValue; // 0x00
			public double doubleValue; // 0x00
		}
	
		// Methods
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation); // 0x000000018B24A44C-0x000000018B24A498
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation, float3 scale); // 0x000000018B24A498-0x000000018B24A4FC
		public static AffineTransform AffineTransform(float3 translation, float3x3 rotationScale); // 0x0000000184DACFF0-0x0000000184DAD020
		public static AffineTransform AffineTransform(float3x3 rotationScale); // 0x000000018B24A3BC-0x000000018B24A400
		public static AffineTransform AffineTransform(float4x4 m); // 0x000000018B24A400-0x000000018B24A44C
		public static AffineTransform AffineTransform(float3x4 m); // 0x000000018B24A540-0x000000018B24A584
		public static AffineTransform AffineTransform(RigidTransform rigid); // 0x000000018B24A4FC-0x000000018B24A540
		public static float4x4 float4x4(AffineTransform transform); // 0x000000018B252CF4-0x000000018B252DF0
		public static float3x4 float3x4(AffineTransform transform); // 0x000000018B2523A8-0x000000018B25243C
		public static AffineTransform mul(AffineTransform a, AffineTransform b); // 0x000000018B2685A8-0x000000018B268690
		public static AffineTransform mul(float3x3 a, AffineTransform b); // 0x000000018B2672B8-0x000000018B267394
		public static AffineTransform mul(AffineTransform a, float3x3 b); // 0x000000018B26A504-0x000000018B26A598
		public static float4 mul(AffineTransform a, float4 pos); // 0x000000018B26D034-0x000000018B26D120
		public static float3 rotate(AffineTransform a, float3 dir); // 0x000000018B270778-0x000000018B2707D8
		public static float3 transform(AffineTransform a, float3 pos); // 0x000000018B273EEC-0x000000018B273F90
		public static AffineTransform inverse(AffineTransform a); // 0x000000018B25B258-0x000000018B25B350
		public static void decompose(AffineTransform a, out float3 translation, out quaternion rotation, out float3 scale); // 0x000000018B24E08C-0x000000018B24E19C
		public static uint hash(AffineTransform a); // 0x000000018B253A70-0x000000018B253AC4
		public static uint4 hashwide(AffineTransform a); // 0x000000018B2580C4-0x000000018B2581C0
		public static bool2 bool2(bool x, bool y); // 0x0000000184DAD570-0x0000000184DAD580
		public static bool2 bool2(bool2 xy); // 0x0000000184DAD590-0x0000000184DAD5B0
		public static bool2 bool2(bool v); // 0x0000000184DAD580-0x0000000184DAD590
		public static uint hash(bool2 v); // 0x000000018B2551F0-0x000000018B255238
		public static uint2 hashwide(bool2 v); // 0x000000018B257960-0x000000018B257994
		public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x); // 0x0000000185F33718-0x0000000185F33804
		public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F35030-0x0000000185F3511C
		public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F338F8-0x0000000185F33BD8
		public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F33EC4-0x0000000185F33F44
		internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component); // 0x0000000185F32CE0-0x0000000185F32DD0
		public static bool2x2 bool2x2(bool2 c0, bool2 c1); // 0x0000000184DAD5B0-0x0000000184DAD5C0
		public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11); // 0x0000000185F08B08-0x0000000185F08B38
		public static bool2x2 bool2x2(bool v); // 0x000000018B24C8BC-0x000000018B24C8E0
		public static bool2x2 transpose(bool2x2 v); // 0x000000018B274708-0x000000018B27472C
		public static uint hash(bool2x2 v); // 0x000000018B255014-0x000000018B2550A4
		public static uint2 hashwide(bool2x2 v); // 0x000000018B2595B0-0x000000018B259634
		public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2); // 0x0000000184DAD5C0-0x0000000184DAD5E0
		public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12); // 0x0000000185F08B38-0x0000000185F08BF4
		public static bool2x3 bool2x3(bool v); // 0x000000018B24C8E0-0x000000018B24C8FC
		public static bool3x2 transpose(bool2x3 v); // 0x000000018B274414-0x000000018B27445C
		public static uint hash(bool2x3 v); // 0x000000018B255F90-0x000000018B25605C
		public static uint2 hashwide(bool2x3 v); // 0x000000018B257D68-0x000000018B257E2C
		public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3); // 0x0000000184DAD5E0-0x0000000184DAD610
		public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13); // 0x000000018B24C8FC-0x000000018B24C954
		public static bool2x4 bool2x4(bool v); // 0x000000018B24C954-0x000000018B24C978
		public static bool4x2 transpose(bool2x4 v); // 0x000000018B274D54-0x000000018B274DA8
		public static uint hash(bool2x4 v); // 0x000000018B255460-0x000000018B255578
		public static uint2 hashwide(bool2x4 v); // 0x000000018B25A170-0x000000018B25A27C
		public static bool3 bool3(bool x, bool y, bool z); // 0x0000000184DAD610-0x0000000184DAD620
		public static bool3 bool3(bool x, bool2 yz); // 0x0000000184DAD650-0x0000000184DAD670
		public static bool3 bool3(bool2 xy, bool z); // 0x0000000184DAD630-0x0000000184DAD650
		public static bool3 bool3(bool3 xyz); // 0x0000000184DAD670-0x0000000184DAD690
		public static bool3 bool3(bool v); // 0x0000000184DAD620-0x0000000184DAD630
		public static uint hash(bool3 v); // 0x0000000185F0F4F0-0x0000000185F0F580
		public static uint3 hashwide(bool3 v); // 0x000000018B258B64-0x000000018B258BF0
		public static bool shuffle(bool3 left, bool3 right, ShuffleComponent x); // 0x0000000185F34180-0x0000000185F341B8
		public static bool2 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B272344-0x000000018B2723BC
		public static bool3 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B271EC8-0x000000018B271F84
		public static bool4 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B271710-0x000000018B2717F4
		internal static bool select_shuffle_component(bool3 a, bool3 b, ShuffleComponent component); // 0x0000000185F33128-0x0000000185F3322C
		public static bool3x2 bool3x2(bool3 c0, bool3 c1); // 0x0000000184DAD690-0x0000000184DAD6C0
		public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21); // 0x0000000185F08BF4-0x0000000185F08C2C
		public static bool3x2 bool3x2(bool v); // 0x000000018B24C978-0x000000018B24C994
		public static bool2x3 transpose(bool3x2 v); // 0x000000018B274FE4-0x000000018B27502C
		public static uint hash(bool3x2 v); // 0x0000000185F11430-0x0000000185F1201C
		public static uint3 hashwide(bool3x2 v); // 0x000000018B259804-0x000000018B25992C
		public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2); // 0x0000000184DAD6C0-0x0000000184DAD700
		public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22); // 0x0000000185F08C2C-0x0000000185F08C8C
		public static bool3x3 bool3x3(bool v); // 0x000000018B24C994-0x000000018B24C9B0
		public static bool3x3 transpose(bool3x3 v); // 0x000000018B274CF4-0x000000018B274D54
		public static uint hash(bool3x3 v); // 0x0000000185F12254-0x0000000185F13994
		public static uint3 hashwide(bool3x3 v); // 0x000000018B25992C-0x000000018B259AF0
		public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3); // 0x0000000184DAD700-0x0000000184DAD750
		public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23); // 0x0000000185F08C8C-0x0000000185F08DC4
		public static bool3x4 bool3x4(bool v); // 0x000000018B24C9B0-0x000000018B24C9CC
		public static bool4x3 transpose(bool3x4 v); // 0x000000018B27502C-0x000000018B2750A4
		public static uint hash(bool3x4 v); // 0x0000000185F104F0-0x0000000185F10CE8
		public static uint3 hashwide(bool3x4 v); // 0x000000018B2584C8-0x000000018B25871C
		public static bool4 bool4(bool x, bool y, bool z, bool w); // 0x0000000184DAD790-0x0000000184DAD7B0
		public static bool4 bool4(bool x, bool y, bool2 zw); // 0x0000000184DAD820-0x0000000184DAD840
		public static bool4 bool4(bool x, bool2 yz, bool w); // 0x0000000184DAD770-0x0000000184DAD790
		public static bool4 bool4(bool x, bool3 yzw); // 0x0000000184DAD870-0x0000000184DAD8A0
		public static bool4 bool4(bool2 xy, bool z, bool w); // 0x0000000184DAD750-0x0000000184DAD770
		public static bool4 bool4(bool2 xy, bool2 zw); // 0x0000000184DAD7D0-0x0000000184DAD7F0
		public static bool4 bool4(bool3 xyz, bool w); // 0x0000000184DAD840-0x0000000184DAD870
		public static bool4 bool4(bool4 xyzw); // 0x0000000184DAD7F0-0x0000000184DAD820
		public static bool4 bool4(bool v); // 0x0000000184DAD7B0-0x0000000184DAD7D0
		public static uint hash(bool4 v); // 0x0000000185F10CE8-0x0000000185F10D90
		public static uint4 hashwide(bool4 v); // 0x000000018B259D7C-0x000000018B259E00
		public static bool shuffle(bool4 left, bool4 right, ShuffleComponent x); // 0x0000000185F33710-0x0000000185F33718
		public static bool2 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F353D8-0x0000000185F354C8
		public static bool3 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F34EB0-0x0000000185F34F18
		public static bool4 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F34570-0x0000000185F345E8
		internal static bool select_shuffle_component(bool4 a, bool4 b, ShuffleComponent component); // 0x0000000185F32BB4-0x0000000185F32CE0
		public static bool4x2 bool4x2(bool4 c0, bool4 c1); // 0x0000000184DAD8A0-0x0000000184DAD8B0
		public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31); // 0x000000018B24C9CC-0x000000018B24CA24
		public static bool4x2 bool4x2(bool v); // 0x000000018B24CA24-0x000000018B24CA48
		public static bool2x4 transpose(bool4x2 v); // 0x000000018B2742A0-0x000000018B2742F4
		public static uint hash(bool4x2 v); // 0x0000000185F0FFD4-0x0000000185F104F0
		public static uint4 hashwide(bool4x2 v); // 0x0000000185F15008-0x0000000185F156A4
		public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2); // 0x0000000184DAD8B0-0x0000000184DAD8C0
		public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32); // 0x0000000185F08DC4-0x0000000185F08E40
		public static bool4x3 bool4x3(bool v); // 0x000000018B24CA48-0x000000018B24CA64
		public static bool3x4 transpose(bool4x3 v); // 0x000000018B2750F8-0x000000018B275174
		public static uint hash(bool4x3 v); // 0x0000000185F10D90-0x0000000185F10F48
		public static uint4 hashwide(bool4x3 v); // 0x0000000185F1479C-0x0000000185F14938
		public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3); // 0x0000000184DAD8C0-0x0000000184DAD8E0
		public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33); // 0x0000000185F08E40-0x0000000185F08FF8
		public static bool4x4 bool4x4(bool v); // 0x000000018B24CA64-0x000000018B24CA7C
		public static bool4x4 transpose(bool4x4 v); // 0x000000018B274210-0x000000018B2742A0
		public static uint hash(bool4x4 v); // 0x0000000185F1201C-0x0000000185F12254
		public static uint4 hashwide(bool4x4 v); // 0x0000000185F1628C-0x0000000185F164A8
		public static double2 double2(double x, double y); // 0x0000000184DAEB80-0x0000000184DAEB90
		public static double2 double2(double2 xy); // 0x0000000184DAEC90-0x0000000184DAECB0
		public static double2 double2(double v); // 0x0000000184DAECB0-0x0000000184DAECC0
		public static double2 double2(bool v); // 0x000000018B24E794-0x000000018B24E7B0
		public static double2 double2(bool2 v); // 0x000000018B24E73C-0x000000018B24E754
		public static double2 double2(int v); // 0x0000000184DAEC50-0x0000000184DAEC70
		public static double2 double2(int2 v); // 0x0000000184DAEBF0-0x0000000184DAEC20
		public static double2 double2(uint v); // 0x0000000184DAEB90-0x0000000184DAEBC0
		public static double2 double2(uint2 v); // 0x0000000184DAEC20-0x0000000184DAEC50
		public static double2 double2(half v); // 0x000000018B24E6FC-0x000000018B24E73C
		public static double2 double2(half2 v); // 0x000000018B24E754-0x000000018B24E794
		public static double2 double2(float v); // 0x0000000184DAEC70-0x0000000184DAEC90
		public static double2 double2(float2 v); // 0x0000000184DAEBC0-0x0000000184DAEBF0
		public static uint hash(double2 v); // 0x000000018B254EB0-0x000000018B254EF8
		public static uint2 hashwide(double2 v); // 0x000000018B258E24-0x000000018B258E7C
		public static double shuffle(double2 left, double2 right, ShuffleComponent x); // 0x000000018B272110-0x000000018B272138
		public static double2 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B271B08-0x000000018B271B74
		public static double3 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B272044-0x000000018B272110
		public static double4 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B272210-0x000000018B272308
		internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component); // 0x0000000185F32AC0-0x0000000185F32BB4
		public static double2x2 double2x2(double2 c0, double2 c1); // 0x0000000184DAECC0-0x0000000184DAECF0
		public static double2x2 double2x2(double m00, double m01, double m10, double m11); // 0x0000000185F0AEA4-0x0000000185F0AECC
		public static double2x2 double2x2(double v); // 0x000000018B24E7CC-0x000000018B24E7E8
		public static double2x2 double2x2(bool v); // 0x000000018B24E8BC-0x000000018B24E8D8
		public static double2x2 double2x2(bool2x2 v); // 0x000000018B24E7E8-0x000000018B24E808
		public static double2x2 double2x2(int v); // 0x000000018B24E84C-0x000000018B24E868
		public static double2x2 double2x2(int2x2 v); // 0x000000018B24E868-0x000000018B24E890
		public static double2x2 double2x2(uint v); // 0x000000018B24E808-0x000000018B24E824
		public static double2x2 double2x2(uint2x2 v); // 0x000000018B24E890-0x000000018B24E8BC
		public static double2x2 double2x2(float v); // 0x000000018B24E7B0-0x000000018B24E7CC
		public static double2x2 double2x2(float2x2 v); // 0x000000018B24E824-0x000000018B24E84C
		public static double2x2 transpose(double2x2 v); // 0x000000018B27472C-0x000000018B274770
		public static double2x2 inverse(double2x2 m); // 0x000000018B25B350-0x000000018B25B410
		public static double determinant(double2x2 m); // 0x0000000184DAE9C0-0x0000000184DAE9F0
		public static uint hash(double2x2 v); // 0x000000018B254EF8-0x000000018B254F84
		public static uint2 hashwide(double2x2 v); // 0x000000018B259CE4-0x000000018B259D7C
		public static double2x3 double2x3(double2 c0, double2 c1, double2 c2); // 0x0000000184DAECF0-0x0000000184DAED40
		public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12); // 0x0000000185F0AECC-0x0000000185F0AFB4
		public static double2x3 double2x3(double v); // 0x000000018B24E918-0x000000018B24E938
		public static double2x3 double2x3(bool v); // 0x000000018B24E970-0x000000018B24E990
		public static double2x3 double2x3(bool2x3 v); // 0x000000018B24E9EC-0x000000018B24EA28
		public static double2x3 double2x3(int v); // 0x000000018B24E990-0x000000018B24E9B0
		public static double2x3 double2x3(int2x3 v); // 0x000000018B24EA28-0x000000018B24EA60
		public static double2x3 double2x3(uint v); // 0x000000018B24E8D8-0x000000018B24E8F8
		public static double2x3 double2x3(uint2x3 v); // 0x000000018B24E9B0-0x000000018B24E9EC
		public static double2x3 double2x3(float v); // 0x000000018B24E8F8-0x000000018B24E918
		public static double2x3 double2x3(float2x3 v); // 0x000000018B24E938-0x000000018B24E970
		public static double3x2 transpose(double2x3 v); // 0x000000018B2750A4-0x000000018B2750F8
		public static uint hash(double2x3 v); // 0x000000018B254174-0x000000018B254240
		public static uint2 hashwide(double2x3 v); // 0x000000018B259AF0-0x000000018B259BC8
		public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3); // 0x0000000184DAED40-0x0000000184DAEDA0
		public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13); // 0x0000000185F0AFB4-0x0000000185F0B0C0
		public static double2x4 double2x4(double v); // 0x000000018B24EB24-0x000000018B24EB48
		public static double2x4 double2x4(bool v); // 0x000000018B24EA60-0x000000018B24EA84
		public static double2x4 double2x4(bool2x4 v); // 0x000000018B24EAC0-0x000000018B24EAE8
		public static double2x4 double2x4(int v); // 0x000000018B24EBCC-0x000000018B24EBF0
		public static double2x4 double2x4(int2x4 v); // 0x000000018B24EAE8-0x000000018B24EB24
		public static double2x4 double2x4(uint v); // 0x000000018B24EB6C-0x000000018B24EB90
		public static double2x4 double2x4(uint2x4 v); // 0x000000018B24EA84-0x000000018B24EAC0
		public static double2x4 double2x4(float v); // 0x000000018B24EB48-0x000000018B24EB6C
		public static double2x4 double2x4(float2x4 v); // 0x000000018B24EB90-0x000000018B24EBCC
		public static double4x2 transpose(double2x4 v); // 0x000000018B2744E0-0x000000018B27454C
		public static uint hash(double2x4 v); // 0x000000018B2547F8-0x000000018B254904
		public static uint2 hashwide(double2x4 v); // 0x000000018B25A27C-0x000000018B25A394
		public static double3 double3(double x, double y, double z); // 0x0000000184DAEE50-0x0000000184DAEE70
		public static double3 double3(double x, double2 yz); // 0x0000000184DAEF60-0x0000000184DAEF80
		public static double3 double3(double2 xy, double z); // 0x0000000184DAEE80-0x0000000184DAEEA0
		public static double3 double3(double3 xyz); // 0x0000000184DAEF00-0x0000000184DAEF30
		public static double3 double3(double v); // 0x0000000184DAEE70-0x0000000184DAEE80
		public static double3 double3(bool v); // 0x000000018B24EC88-0x000000018B24ECA8
		public static double3 double3(bool3 v); // 0x000000018B24EC54-0x000000018B24EC88
		public static double3 double3(int v); // 0x0000000184DAEF30-0x0000000184DAEF60
		public static double3 double3(int3 v); // 0x0000000184DAEDD0-0x0000000184DAEE20
		public static double3 double3(uint v); // 0x0000000184DAEE20-0x0000000184DAEE50
		public static double3 double3(uint3 v); // 0x0000000184DAEEA0-0x0000000184DAEF00
		public static double3 double3(half v); // 0x000000018B24ECA8-0x000000018B24ECFC
		public static double3 double3(half3 v); // 0x000000018B24EBF0-0x000000018B24EC54
		public static double3 double3(float v); // 0x0000000184DAEDA0-0x0000000184DAEDD0
		public static double3 double3(float3 v); // 0x000000018415F9A0-0x000000018415F9E0
		public static uint hash(double3 v); // 0x000000018B255238-0x000000018B2552C8
		public static uint3 hashwide(double3 v); // 0x000000018B257F04-0x000000018B257FA8
		public static double shuffle(double3 left, double3 right, ShuffleComponent x); // 0x000000018B2723BC-0x000000018B2723FC
		public static double2 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B2717F4-0x000000018B27189C
		public static double3 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B27245C-0x000000018B272564
		public static double4 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B27199C-0x000000018B271AE0
		internal static double select_shuffle_component(double3 a, double3 b, ShuffleComponent component); // 0x000000018B271410-0x000000018B271530
		public static double3x2 double3x2(double3 c0, double3 c1); // 0x0000000184DAEF80-0x0000000184DAEFB0
		public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21); // 0x0000000185F0B0C0-0x0000000185F0B108
		public static double3x2 double3x2(double v); // 0x000000018B24ED58-0x000000018B24ED78
		public static double3x2 double3x2(bool v); // 0x000000018B24EDB4-0x000000018B24EDD8
		public static double3x2 double3x2(bool3x2 v); // 0x000000018B24EDD8-0x000000018B24EE14
		public static double3x2 double3x2(int v); // 0x000000018B24EE70-0x000000018B24EE90
		public static double3x2 double3x2(int3x2 v); // 0x000000018B24EE14-0x000000018B24EE50
		public static double3x2 double3x2(uint v); // 0x000000018B24ECFC-0x000000018B24ED1C
		public static double3x2 double3x2(uint3x2 v); // 0x000000018B24ED78-0x000000018B24EDB4
		public static double3x2 double3x2(float v); // 0x000000018B24EE50-0x000000018B24EE70
		public static double3x2 double3x2(float3x2 v); // 0x000000018B24ED1C-0x000000018B24ED58
		public static double2x3 transpose(double3x2 v); // 0x000000018B274648-0x000000018B27469C
		public static uint hash(double3x2 v); // 0x000000018B253690-0x000000018B2537BC
		public static uint3 hashwide(double3x2 v); // 0x000000018B256B54-0x000000018B256C94
		public static double3x3 double3x3(double3 c0, double3 c1, double3 c2); // 0x0000000184DAEFB0-0x0000000184DAEFF0
		public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22); // 0x0000000185F0B1A0-0x0000000185F0B338
		public static double3x3 double3x3(double v); // 0x000000018B24F030-0x000000018B24F05C
		public static double3x3 double3x3(bool v); // 0x000000018B24EFB4-0x000000018B24EFE0
		public static double3x3 double3x3(bool3x3 v); // 0x0000000185F0B108-0x0000000185F0B1A0
		public static double3x3 double3x3(int v); // 0x000000018B24EF88-0x000000018B24EFB4
		public static double3x3 double3x3(int3x3 v); // 0x000000018B24EF38-0x000000018B24EF88
		public static double3x3 double3x3(uint v); // 0x000000018B24EF0C-0x000000018B24EF38
		public static double3x3 double3x3(uint3x3 v); // 0x000000018B24EFE0-0x000000018B24F030
		public static double3x3 double3x3(float v); // 0x000000018B24EE90-0x000000018B24EEBC
		public static double3x3 double3x3(float3x3 v); // 0x000000018B24EEBC-0x000000018B24EF0C
		public static double3x3 transpose(double3x3 v); // 0x000000018B2747F4-0x000000018B274868
		public static double3x3 inverse(double3x3 m); // 0x000000018B25C6E4-0x000000018B25CBA4
		public static double determinant(double3x3 m); // 0x0000000184DAE320-0x0000000184DAE3E0
		public static uint hash(double3x3 v); // 0x000000018B254B94-0x000000018B254D4C
		public static uint3 hashwide(double3x3 v); // 0x000000018B259634-0x000000018B259804
		public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3); // 0x0000000184DAEFF0-0x0000000184DAF040
		public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23); // 0x0000000185F0B338-0x0000000185F0B560
		public static double3x4 double3x4(double v); // 0x000000018B24F05C-0x000000018B24F088
		public static double3x4 double3x4(bool v); // 0x000000018B24F1FC-0x000000018B24F22C
		public static double3x4 double3x4(bool3x4 v); // 0x0000000185F0B560-0x0000000185F0B68C
		public static double3x4 double3x4(int v); // 0x000000018B24F088-0x000000018B24F0B4
		public static double3x4 double3x4(int3x4 v); // 0x000000018B24F104-0x000000018B24F154
		public static double3x4 double3x4(uint v); // 0x000000018B24F180-0x000000018B24F1AC
		public static double3x4 double3x4(uint3x4 v); // 0x000000018B24F1AC-0x000000018B24F1FC
		public static double3x4 double3x4(float v); // 0x000000018B24F154-0x000000018B24F180
		public static double3x4 double3x4(float3x4 v); // 0x000000018B24F0B4-0x000000018B24F104
		public static double4x3 transpose(double3x4 v); // 0x000000018B274F08-0x000000018B274F98
		public static double3x4 fastinverse(double3x4 m); // 0x000000018B2516B0-0x000000018B2519E8
		public static uint hash(double3x4 v); // 0x000000018B2537BC-0x000000018B253A04
		public static uint3 hashwide(double3x4 v); // 0x000000018B258E7C-0x000000018B2590D8
		public static double4 double4(double x, double y, double z, double w); // 0x0000000184DAF120-0x0000000184DAF140
		public static double4 double4(double x, double y, double2 zw); // 0x0000000184DAF040-0x0000000184DAF060
		public static double4 double4(double x, double2 yz, double w); // 0x0000000184DAF060-0x0000000184DAF080
		public static double4 double4(double x, double3 yzw); // 0x0000000184DAF170-0x0000000184DAF1A0
		public static double4 double4(double2 xy, double z, double w); // 0x0000000184DAF1D0-0x0000000184DAF1F0
		public static double4 double4(double2 xy, double2 zw); // 0x0000000184DAF140-0x0000000184DAF170
		public static double4 double4(double3 xyz, double w); // 0x0000000184DAF0B0-0x0000000184DAF0E0
		public static double4 double4(double4 xyzw); // 0x000000018B24F26C-0x000000018B24F294
		public static double4 double4(double v); // 0x0000000184DAF080-0x0000000184DAF090
		public static double4 double4(bool v); // 0x000000018B24F2E0-0x000000018B24F2FC
		public static double4 double4(bool4 v); // 0x000000018B24F250-0x000000018B24F26C
		public static double4 double4(int v); // 0x0000000184DAF0E0-0x0000000184DAF120
		public static double4 double4(int4 v); // 0x000000018B24F2FC-0x000000018B24F324
		public static double4 double4(uint v); // 0x0000000184DAF1A0-0x0000000184DAF1D0
		public static double4 double4(uint4 v); // 0x000000018B24F324-0x000000018B24F34C
		public static double4 double4(half v); // 0x000000018B24F294-0x000000018B24F2B8
		public static double4 double4(half4 v); // 0x000000018B24F22C-0x000000018B24F250
		public static double4 double4(float v); // 0x0000000184DAF090-0x0000000184DAF0B0
		public static double4 double4(float4 v); // 0x000000018B24F2B8-0x000000018B24F2E0
		public static uint hash(double4 v); // 0x000000018B25402C-0x000000018B2540B8
		public static uint4 hashwide(double4 v); // 0x000000018B2575B0-0x000000018B257644
		public static double shuffle(double4 left, double4 right, ShuffleComponent x); // 0x000000018B272308-0x000000018B272344
		public static double2 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B271B74-0x000000018B271C14
		public static double3 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B271C14-0x000000018B271D10
		public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F33BD8-0x0000000185F33D78
		internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component); // 0x000000018B2712DC-0x000000018B271410
		public static double4x2 double4x2(double4 c0, double4 c1); // 0x0000000184DAF1F0-0x0000000184DAF220
		public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31); // 0x0000000185F0B68C-0x0000000185F0B788
		public static double4x2 double4x2(double v); // 0x000000018B24F3AC-0x000000018B24F3D0
		public static double4x2 double4x2(bool v); // 0x000000018B24F3F4-0x000000018B24F418
		public static double4x2 double4x2(bool4x2 v); // 0x000000018B24F47C-0x000000018B24F4A4
		public static double4x2 double4x2(int v); // 0x000000018B24F3D0-0x000000018B24F3F4
		public static double4x2 double4x2(int4x2 v); // 0x000000018B24F370-0x000000018B24F3AC
		public static double4x2 double4x2(uint v); // 0x000000018B24F418-0x000000018B24F440
		public static double4x2 double4x2(uint4x2 v); // 0x000000018B24F4A4-0x000000018B24F4E0
		public static double4x2 double4x2(float v); // 0x000000018B24F34C-0x000000018B24F370
		public static double4x2 double4x2(float4x2 v); // 0x000000018B24F440-0x000000018B24F47C
		public static double2x4 transpose(double4x2 v); // 0x000000018B27469C-0x000000018B274708
		public static uint hash(double4x2 v); // 0x000000018B25576C-0x000000018B25587C
		public static uint4 hashwide(double4x2 v); // 0x000000018B257FA8-0x000000018B2580C4
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2); // 0x0000000184DAF220-0x0000000184DAF260
		public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32); // 0x0000000185F0B7D0-0x0000000185F0BAE8
		public static double4x3 double4x3(double v); // 0x000000018B24F530-0x000000018B24F55C
		public static double4x3 double4x3(bool v); // 0x000000018B24F608-0x000000018B24F634
		public static double4x3 double4x3(bool4x3 v); // 0x0000000185F0B788-0x0000000185F0B7D0
		public static double4x3 double4x3(int v); // 0x000000018B24F55C-0x000000018B24F588
		public static double4x3 double4x3(int4x3 v); // 0x000000018B24F5B8-0x000000018B24F608
		public static double4x3 double4x3(uint v); // 0x000000018B24F588-0x000000018B24F5B8
		public static double4x3 double4x3(uint4x3 v); // 0x000000018B24F4E0-0x000000018B24F530
		public static double4x3 double4x3(float v); // 0x000000018B24F634-0x000000018B24F660
		public static double4x3 double4x3(float4x3 v); // 0x000000018B24F660-0x000000018B24F6B0
		public static double3x4 transpose(double4x3 v); // 0x000000018B274C64-0x000000018B274CF4
		public static uint hash(double4x3 v); // 0x000000018B255578-0x000000018B255708
		public static uint4 hashwide(double4x3 v); // 0x000000018B257BCC-0x000000018B257D68
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3); // 0x0000000184DAF260-0x0000000184DAF2B0
		public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33); // 0x0000000185F0BAE8-0x0000000185F0BC14
		public static double4x4 double4x4(double v); // 0x000000018B24F6E8-0x000000018B24F71C
		public static double4x4 double4x4(bool v); // 0x000000018B24F71C-0x000000018B24F750
		public static double4x4 double4x4(bool4x4 v); // 0x000000018B24F898-0x000000018B24F8DC
		public static double4x4 double4x4(int v); // 0x000000018B24F8DC-0x000000018B24F910
		public static double4x4 double4x4(int4x4 v); // 0x000000018B24F750-0x000000018B24F7AC
		public static double4x4 double4x4(uint v); // 0x000000018B24F6B0-0x000000018B24F6E8
		public static double4x4 double4x4(uint4x4 v); // 0x000000018B24F7AC-0x000000018B24F808
		public static double4x4 double4x4(float v); // 0x000000018B24F864-0x000000018B24F898
		public static double4x4 double4x4(float4x4 v); // 0x000000018B24F808-0x000000018B24F864
		public static double3 rotate(double4x4 a, double3 b); // 0x000000018B270628-0x000000018B270778
		public static double3 transform(double4x4 a, double3 b); // 0x000000018B273F90-0x000000018B274114
		public static double4x4 transpose(double4x4 v); // 0x000000018B274940-0x000000018B2749F4
		public static double4x4 inverse(double4x4 m); // 0x000000018B25B7D0-0x000000018B25C6E4
		public static double4x4 fastinverse(double4x4 m); // 0x000000018B251030-0x000000018B2514A4
		public static double determinant(double4x4 m); // 0x0000000184DAE0B0-0x0000000184DAE310
		public static uint hash(double4x4 v); // 0x000000018B253E20-0x000000018B25402C
		public static uint4 hashwide(double4x4 v); // 0x000000018B256C94-0x000000018B256EAC
		public static float2 float2(float x, float y); // 0x0000000184DAF4D0-0x0000000184DAF4E0
		public static float2 float2(float2 xy); // 0x0000000184DA7CB0-0x0000000184DA7CD0
		public static float2 float2(float v); // 0x0000000184D8B720-0x0000000184D8B730
		public static float2 float2(bool v); // 0x000000018B2519E8-0x000000018B251A08
		public static float2 float2(bool2 v); // 0x000000018B251A08-0x000000018B251A2C
		public static float2 float2(int v); // 0x0000000184DAF4E0-0x0000000184DAF500
		public static float2 float2(int2 v); // 0x0000000184DAF500-0x0000000184DAF520
		public static float2 float2(uint v); // 0x0000000184DAF550-0x0000000184DAF580
		public static float2 float2(uint2 v); // 0x0000000184DAF520-0x0000000184DAF550
		public static float2 float2(half v); // 0x000000018B251A58-0x000000018B251A80
		public static float2 float2(half2 v); // 0x000000018B251A2C-0x000000018B251A58
		public static float2 float2(double v); // 0x0000000184DAF580-0x0000000184DAF5A0
		public static float2 float2(double2 v); // 0x0000000184DAF4B0-0x0000000184DAF4D0
		public static uint hash(float2 v); // 0x000000018B253658-0x000000018B253690
		public static uint2 hashwide(float2 v); // 0x000000018B259CA0-0x000000018B259CE4
		public static float shuffle(float2 left, float2 right, ShuffleComponent x); // 0x0000000185F33FD4-0x0000000185F34180
		public static float2 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F3477C-0x0000000185F347E8
		public static float3 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F34970-0x0000000185F34A30
		public static float4 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F341B8-0x0000000185F3429C
		internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component); // 0x0000000185F3322C-0x0000000185F3332C
		public static float2x2 float2x2(float2 c0, float2 c1); // 0x0000000182E515B0-0x0000000182E56440
		public static float2x2 float2x2(float m00, float m01, float m10, float m11); // 0x000000018B251A98-0x000000018B251ABC
		public static float2x2 float2x2(float v); // 0x000000018B251A80-0x000000018B251A98
		public static float2x2 float2x2(bool v); // 0x000000018B251B80-0x000000018B251B98
		public static float2x2 float2x2(bool2x2 v); // 0x000000018B251B98-0x000000018B251BB4
		public static float2x2 float2x2(int v); // 0x000000018B251AE4-0x000000018B251AFC
		public static float2x2 float2x2(int2x2 v); // 0x000000018B251B5C-0x000000018B251B80
		public static float2x2 float2x2(uint v); // 0x000000018B251B2C-0x000000018B251B44
		public static float2x2 float2x2(uint2x2 v); // 0x000000018B251ABC-0x000000018B251AE4
		public static float2x2 float2x2(double v); // 0x000000018B251B44-0x000000018B251B5C
		public static float2x2 float2x2(double2x2 v); // 0x000000018B251AFC-0x000000018B251B2C
		public static float2x2 transpose(float2x2 v); // 0x000000018B2742F4-0x000000018B274334
		public static float2x2 inverse(float2x2 m); // 0x0000000185F16C64-0x0000000185F16FD4
		public static float determinant(float2x2 m); // 0x0000000184DAE9F0-0x0000000184DAEA10
		public static uint hash(float2x2 v); // 0x000000018B255CA8-0x000000018B255D0C
		public static uint2 hashwide(float2x2 v); // 0x000000018B25A05C-0x000000018B25A0D0
		public static float2x3 float2x3(float2 c0, float2 c1, float2 c2); // 0x0000000184DAF5A0-0x0000000184DAF5B0
		public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12); // 0x0000000185F0D588-0x0000000185F0D5CC
		public static float2x3 float2x3(float v); // 0x000000018B251BB4-0x000000018B251BD4
		public static float2x3 float2x3(bool v); // 0x000000018B251C14-0x000000018B251C34
		public static float2x3 float2x3(bool2x3 v); // 0x000000018B251C70-0x000000018B251CA4
		public static float2x3 float2x3(int v); // 0x000000018B251CDC-0x000000018B251CFC
		public static float2x3 float2x3(int2x3 v); // 0x000000018B251CFC-0x000000018B251D34
		public static float2x3 float2x3(uint v); // 0x000000018B251BF4-0x000000018B251C14
		public static float2x3 float2x3(uint2x3 v); // 0x000000018B251CA4-0x000000018B251CDC
		public static float2x3 float2x3(double v); // 0x000000018B251BD4-0x000000018B251BF4
		public static float2x3 float2x3(double2x3 v); // 0x000000018B251C34-0x000000018B251C70
		public static float3x2 transpose(float2x3 v); // 0x000000018B274A98-0x000000018B274AF4
		public static uint hash(float2x3 v); // 0x000000018B25440C-0x000000018B25449C
		public static uint2 hashwide(float2x3 v); // 0x000000018B257364-0x000000018B257404
		public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3); // 0x0000000184DAF5B0-0x0000000184DAF5D0
		public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13); // 0x0000000185F0D5CC-0x0000000185F0D638
		public static float2x4 float2x4(float v); // 0x000000018B251DEC-0x000000018B251E08
		public static float2x4 float2x4(bool v); // 0x000000018B251D34-0x000000018B251D50
		public static float2x4 float2x4(bool2x4 v); // 0x000000018B251D94-0x000000018B251DB4
		public static float2x4 float2x4(int v); // 0x000000018B251DD0-0x000000018B251DEC
		public static float2x4 float2x4(int2x4 v); // 0x000000018B251E58-0x000000018B251E8C
		public static float2x4 float2x4(uint v); // 0x000000018B251DB4-0x000000018B251DD0
		public static float2x4 float2x4(uint2x4 v); // 0x000000018B251E24-0x000000018B251E58
		public static float2x4 float2x4(double v); // 0x000000018B251E08-0x000000018B251E24
		public static float2x4 float2x4(double2x4 v); // 0x000000018B251D50-0x000000018B251D94
		public static float4x2 transpose(float2x4 v); // 0x000000018B274868-0x000000018B2748D4
		public static uint hash(float2x4 v); // 0x000000018B2550A4-0x000000018B255160
		public static uint2 hashwide(float2x4 v); // 0x000000018B2588B8-0x000000018B258984
		public static float3 float3(float x, float y, float z); // 0x0000000184DA2820-0x0000000184DA2840
		public static float3 float3(float x, float2 yz); // 0x0000000184DAF730-0x0000000184DAF760
		public static float3 float3(float2 xy, float z); // 0x0000000184DAF670-0x0000000184DAF6A0
		public static float3 float3(float3 xyz); // 0x0000000184DAF6A0-0x0000000184DAF6D0
		public static float3 float3(float v); // 0x0000000184D8B860-0x0000000184D8B880
		public static float3 float3(bool v); // 0x000000018B251E8C-0x000000018B251EA8
		public static float3 float3(bool3 v); // 0x000000018B251F30-0x000000018B251F60
		public static float3 float3(int v); // 0x0000000184DAF610-0x0000000184DAF640
		public static float3 float3(int3 v); // 0x0000000184DAF7A0-0x0000000184DAF7F0
		public static float3 float3(uint v); // 0x0000000184DAF760-0x0000000184DAF7A0
		public static float3 float3(uint3 v); // 0x0000000184DAF6D0-0x0000000184DAF730
		public static float3 float3(half v); // 0x000000018B251EA8-0x000000018B251EE4
		public static float3 float3(half3 v); // 0x000000018B251EE4-0x000000018B251F30
		public static float3 float3(double v); // 0x0000000184DAF640-0x0000000184DAF670
		public static float3 float3(double3 v); // 0x0000000184DAF5D0-0x0000000184DAF610
		public static uint hash(float3 v); // 0x0000000185F10F48-0x0000000185F11430
		public static uint3 hashwide(float3 v); // 0x0000000185F13994-0x0000000185F1479C
		public static float shuffle(float3 left, float3 right, ShuffleComponent x); // 0x0000000185F34A30-0x0000000185F34A6C
		public static float2 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F3511C-0x0000000185F352B0
		public static float3 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F354C8-0x0000000185F355BC
		public static float4 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F352B0-0x0000000185F353D8
		internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component); // 0x0000000185F329B0-0x0000000185F32AC0
		public static float3x2 float3x2(float3 c0, float3 c1); // 0x0000000184DAF7F0-0x0000000184DAF820
		public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21); // 0x0000000185F0D638-0x0000000185F0D728
		public static float3x2 float3x2(float v); // 0x000000018B2520C8-0x000000018B2520E8
		public static float3x2 float3x2(bool v); // 0x000000018B251FD8-0x000000018B251FF8
		public static float3x2 float3x2(bool3x2 v); // 0x000000018B252090-0x000000018B2520C8
		public static float3x2 float3x2(int v); // 0x000000018B251FF8-0x000000018B252018
		public static float3x2 float3x2(int3x2 v); // 0x000000018B252038-0x000000018B252070
		public static float3x2 float3x2(uint v); // 0x000000018B252070-0x000000018B252090
		public static float3x2 float3x2(uint3x2 v); // 0x000000018B251FA0-0x000000018B251FD8
		public static float3x2 float3x2(double v); // 0x000000018B252018-0x000000018B252038
		public static float3x2 float3x2(double3x2 v); // 0x000000018B251F60-0x000000018B251FA0
		public static float2x3 transpose(float3x2 v); // 0x000000018B274B9C-0x000000018B274BF8
		public static uint hash(float3x2 v); // 0x000000018B25649C-0x000000018B25657C
		public static uint3 hashwide(float3x2 v); // 0x000000018B2577B0-0x000000018B2578A8
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2); // 0x00000001834C99D0-0x00000001834C9A10
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22); // 0x0000000185F0D728-0x0000000185F0D8D8
		public static float3x3 float3x3(float v); // 0x000000018B252108-0x000000018B252128
		public static float3x3 float3x3(bool v); // 0x000000018B2520E8-0x000000018B252108
		public static float3x3 float3x3(bool3x3 v); // 0x000000018B2522EC-0x000000018B25232C
		public static float3x3 float3x3(int v); // 0x000000018B252214-0x000000018B252234
		public static float3x3 float3x3(int3x3 v); // 0x000000018B252180-0x000000018B2521C0
		public static float3x3 float3x3(uint v); // 0x000000018B2522AC-0x000000018B2522CC
		public static float3x3 float3x3(uint3x3 v); // 0x000000018B25226C-0x000000018B2522AC
		public static float3x3 float3x3(double v); // 0x000000018B2522CC-0x000000018B2522EC
		public static float3x3 float3x3(double3x3 v); // 0x000000018B252128-0x000000018B252180
		public static float3x3 transpose(float3x3 v); // 0x000000018B274E84-0x000000018B274F08
		public static float3x3 inverse(float3x3 m); // 0x000000018B25B410-0x000000018B25B7D0
		public static float determinant(float3x3 m); // 0x0000000184DAE870-0x0000000184DAE920
		public static uint hash(float3x3 v); // 0x000000018B25619C-0x000000018B2562F0
		public static uint3 hashwide(float3x3 v); // 0x000000018B257644-0x000000018B2577B0
		public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3); // 0x0000000184DAF820-0x0000000184DAF870
		public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23); // 0x0000000185F0D8D8-0x0000000185F0DA18
		public static float3x4 float3x4(float v); // 0x000000018B2524A0-0x000000018B2524C0
		public static float3x4 float3x4(bool v); // 0x000000018B252388-0x000000018B2523A8
		public static float3x4 float3x4(bool3x4 v); // 0x000000018B25234C-0x000000018B252388
		public static float3x4 float3x4(int v); // 0x000000018B25243C-0x000000018B25245C
		public static float3x4 float3x4(int3x4 v); // 0x000000018B25245C-0x000000018B2524A0
		public static float3x4 float3x4(uint v); // 0x000000018B252564-0x000000018B252584
		public static float3x4 float3x4(uint3x4 v); // 0x000000018B252520-0x000000018B252564
		public static float3x4 float3x4(double v); // 0x000000018B25232C-0x000000018B25234C
		public static float3x4 float3x4(double3x4 v); // 0x000000018B2524C0-0x000000018B252520
		public static float4x3 transpose(float3x4 v); // 0x000000018B2749F4-0x000000018B274A98
		public static float3x4 fastinverse(float3x4 m); // 0x000000018B2514A4-0x000000018B2516B0
		public static uint hash(float3x4 v); // 0x000000018B253AC4-0x000000018B253C90
		public static uint3 hashwide(float3x4 v); // 0x000000018B256FE8-0x000000018B2571C8
		public static float4 float4(float x, float y, float z, float w); // 0x0000000184DAF870-0x0000000184DAF890
		public static float4 float4(float x, float y, float2 zw); // 0x0000000184DAF8A0-0x0000000184DAF8D0
		public static float4 float4(float x, float2 yz, float w); // 0x0000000184DAF940-0x0000000184DAF970
		public static float4 float4(float x, float3 yzw); // 0x0000000184DAF9C0-0x0000000184DAFA00
		public static float4 float4(float2 xy, float z, float w); // 0x0000000184DAF8D0-0x0000000184DAF900
		public static float4 float4(float2 xy, float2 zw); // 0x0000000184D85B30-0x0000000184D85B70
		public static float4 float4(float3 xyz, float w); // 0x00000001830E7A30-0x00000001830E7A60
		public static float4 float4(float4 xyzw); // 0x000000018B2526F4-0x000000018B252720
		public static float4 float4(float v); // 0x0000000184DAF890-0x0000000184DAF8A0
		public static float4 float4(bool v); // 0x000000018B2526B8-0x000000018B2526D0
		public static float4 float4(bool4 v); // 0x000000018B2525B4-0x000000018B2525CC
		public static float4 float4(int v); // 0x0000000184DAF920-0x0000000184DAF940
		public static float4 float4(int4 v); // 0x000000018B252674-0x000000018B2526B8
		public static float4 float4(uint v); // 0x0000000184DAF970-0x0000000184DAF9C0
		public static float4 float4(uint4 v); // 0x000000018B2526D0-0x000000018B2526F4
		public static float4 float4(half v); // 0x000000018B252628-0x000000018B252674
		public static float4 float4(half4 v); // 0x000000018B2525CC-0x000000018B252628
		public static float4 float4(double v); // 0x0000000184DAF900-0x0000000184DAF920
		public static float4 float4(double4 v); // 0x000000018B252584-0x000000018B2525B4
		public static uint hash(float4 v); // 0x000000018B2545F0-0x000000018B25465C
		public static uint4 hashwide(float4 v); // 0x000000018B2574F4-0x000000018B257570
		public static float shuffle(float4 left, float4 right, ShuffleComponent x); // 0x000000018B271974-0x000000018B27199C
		public static float2 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B2723FC-0x000000018B27245C
		public static float3 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B271F84-0x000000018B272044
		public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B271D10-0x000000018B271DF8
		internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component); // 0x000000018B271530-0x000000018B271660
		public static float4x2 float4x2(float4 c0, float4 c1); // 0x0000000184DAFA00-0x0000000184DAFA20
		public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31); // 0x0000000185F0DA18-0x0000000185F0DAE4
		public static float4x2 float4x2(float v); // 0x000000018B252770-0x000000018B25278C
		public static float4x2 float4x2(bool v); // 0x000000018B252840-0x000000018B25285C
		public static float4x2 float4x2(bool4x2 v); // 0x000000018B25285C-0x000000018B252880
		public static float4x2 float4x2(int v); // 0x000000018B252804-0x000000018B252820
		public static float4x2 float4x2(int4x2 v); // 0x000000018B2527D0-0x000000018B252804
		public static float4x2 float4x2(uint v); // 0x000000018B252820-0x000000018B252840
		public static float4x2 float4x2(uint4x2 v); // 0x000000018B25273C-0x000000018B252770
		public static float4x2 float4x2(double v); // 0x000000018B252720-0x000000018B25273C
		public static float4x2 float4x2(double4x2 v); // 0x000000018B25278C-0x000000018B2527D0
		public static float2x4 transpose(float4x2 v); // 0x000000018B274BF8-0x000000018B274C64
		public static uint hash(float4x2 v); // 0x000000018B254AC8-0x000000018B254B94
		public static uint4 hashwide(float4x2 v); // 0x000000018B259BC8-0x000000018B259CA0
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2); // 0x0000000184DAFA20-0x0000000184DAFA40
		public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32); // 0x0000000185F0DAE4-0x0000000185F0E0A0
		public static float4x3 float4x3(float v); // 0x000000018B2529A4-0x000000018B2529C4
		public static float4x3 float4x3(bool v); // 0x000000018B2529C4-0x000000018B2529E4
		public static float4x3 float4x3(bool4x3 v); // 0x000000018B252924-0x000000018B252960
		public static float4x3 float4x3(int v); // 0x000000018B2529E4-0x000000018B252A04
		public static float4x3 float4x3(int4x3 v); // 0x000000018B252A04-0x000000018B252A44
		public static float4x3 float4x3(uint v); // 0x000000018B252900-0x000000018B252924
		public static float4x3 float4x3(uint4x3 v); // 0x000000018B252960-0x000000018B2529A4
		public static float4x3 float4x3(double v); // 0x000000018B2528E0-0x000000018B252900
		public static float4x3 float4x3(double4x3 v); // 0x000000018B252880-0x000000018B2528E0
		public static float3x4 transpose(float4x3 v); // 0x000000018B2745A4-0x000000018B274648
		public static uint hash(float4x3 v); // 0x000000018B255D0C-0x000000018B255E3C
		public static uint4 hashwide(float4x3 v); // 0x000000018B256EAC-0x000000018B256FE8
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3); // 0x0000000184DAFA40-0x0000000184DAFA70
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33); // 0x000000018B252A44-0x000000018B252B6C
		public static float4x4 float4x4(float v); // 0x000000018308AEC0-0x000000018308AEF0
		public static float4x4 float4x4(bool v); // 0x000000018B252EC0-0x000000018B252EE4
		public static float4x4 float4x4(bool4x4 v); // 0x000000018B252F70-0x000000018B252FA8
		public static float4x4 float4x4(int v); // 0x000000018B252EE4-0x000000018B252F08
		public static float4x4 float4x4(int4x4 v); // 0x000000018B252B94-0x000000018B252BF0
		public static float4x4 float4x4(uint v); // 0x000000018B252B6C-0x000000018B252B94
		public static float4x4 float4x4(uint4x4 v); // 0x000000018B252DF0-0x000000018B252E4C
		public static float4x4 float4x4(double v); // 0x000000018B252BF0-0x000000018B252C14
		public static float4x4 float4x4(double4x4 v); // 0x000000018B252C68-0x000000018B252CF4
		public static float3 rotate(float4x4 a, float3 b); // 0x000000018B270550-0x000000018B270628
		public static float3 transform(float4x4 a, float3 b); // 0x000000018B274114-0x000000018B274210
		public static float4x4 transpose(float4x4 v); // 0x000000018B274DA8-0x000000018B274E84
		public static float4x4 inverse(float4x4 m); // 0x00000001830E7AD0-0x00000001830E8750
		public static float4x4 fastinverse(float4x4 m); // 0x000000018B250D30-0x000000018B251030
		public static float determinant(float4x4 m); // 0x0000000184DAE3E0-0x0000000184DAE650
		public static uint hash(float4x4 v); // 0x000000018B253C90-0x000000018B253E20
		public static uint4 hashwide(float4x4 v); // 0x000000018B25871C-0x000000018B2588B8
		public static half half(half x); // 0x0000000184D875C0-0x0000000184D875D0
		public static half half(float v); // 0x000000018B253650-0x000000018B253658
		public static half half(double v); // 0x000000018B253644-0x000000018B253650
		public static uint hash(half v); // 0x0000000184DB0230-0x0000000184DB0240
		public static half2 half2(half x, half y); // 0x0000000184DAD5B0-0x0000000184DAD5C0
		public static half2 half2(half2 xy); // 0x0000000184DAB3F0-0x0000000184DAB410
		public static half2 half2(half v); // 0x0000000184DB0040-0x0000000184DB0050
		public static half2 half2(float v); // 0x000000018B253388-0x000000018B2533B0
		public static half2 half2(float2 v); // 0x000000018B2533B0-0x000000018B2533E4
		public static half2 half2(double v); // 0x000000018B25331C-0x000000018B253350
		public static half2 half2(double2 v); // 0x000000018B253350-0x000000018B253388
		public static uint hash(half2 v); // 0x000000018B2562F0-0x000000018B256334
		public static uint2 hashwide(half2 v); // 0x000000018B259274-0x000000018B2592C8
		public static half3 half3(half x, half y, half z); // 0x0000000184DAD5C0-0x0000000184DAD5E0
		public static half3 half3(half x, half2 yz); // 0x0000000184DB0090-0x0000000184DB00B0
		public static half3 half3(half2 xy, half z); // 0x0000000184DB00B0-0x0000000184DB00D0
		public static half3 half3(half3 xyz); // 0x0000000184DB0050-0x0000000184DB0080
		public static half3 half3(half v); // 0x0000000184DB0080-0x0000000184DB0090
		public static half3 half3(float v); // 0x000000018B2534B8-0x000000018B2534F0
		public static half3 half3(float3 v); // 0x000000018B253474-0x000000018B2534B8
		public static half3 half3(double v); // 0x000000018B2533E4-0x000000018B253428
		public static half3 half3(double3 v); // 0x000000018B253428-0x000000018B253474
		public static uint hash(half3 v); // 0x0000000185F0E860-0x0000000185F0F4F0
		public static uint3 hashwide(half3 v); // 0x0000000185F14938-0x0000000185F15008
		public static half4 half4(half x, half y, half z, half w); // 0x0000000184DAD5E0-0x0000000184DAD610
		public static half4 half4(half x, half y, half2 zw); // 0x0000000184DB01A0-0x0000000184DB01D0
		public static half4 half4(half x, half2 yz, half w); // 0x0000000184DB0120-0x0000000184DB0150
		public static half4 half4(half x, half3 yzw); // 0x0000000184DB0200-0x0000000184DB0230
		public static half4 half4(half2 xy, half z, half w); // 0x0000000184DB00D0-0x0000000184DB0100
		public static half4 half4(half2 xy, half2 zw); // 0x0000000184DB0150-0x0000000184DB0170
		public static half4 half4(half3 xyz, half w); // 0x0000000184DB0170-0x0000000184DB01A0
		public static half4 half4(half4 xyzw); // 0x0000000184DB01D0-0x0000000184DB0200
		public static half4 half4(half v); // 0x0000000184DB0100-0x0000000184DB0120
		public static half4 half4(float v); // 0x000000018B253554-0x000000018B253598
		public static half4 half4(float4 v); // 0x000000018B2535F0-0x000000018B253644
		public static half4 half4(double v); // 0x000000018B253598-0x000000018B2535F0
		public static half4 half4(double4 v); // 0x000000018B2534F0-0x000000018B253554
		public static uint hash(half4 v); // 0x0000000185F0E7C0-0x0000000185F0E860
		public static uint4 hashwide(half4 v); // 0x0000000185F160D0-0x0000000185F1628C
		public static int2 int2(int x, int y); // 0x0000000184DAD8A0-0x0000000184DAD8B0
		public static int2 int2(int2 xy); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static int2 int2(int v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static int2 int2(bool v); // 0x000000018B25A394-0x000000018B25A3AC
		public static int2 int2(bool2 v); // 0x000000018B25A3AC-0x000000018B25A3CC
		public static int2 int2(uint v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static int2 int2(uint2 v); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static int2 int2(float v); // 0x0000000184DB0280-0x0000000184DB02A0
		public static int2 int2(float2 v); // 0x0000000184DB0240-0x0000000184DB0260
		public static int2 int2(double v); // 0x0000000184DB0260-0x0000000184DB0280
		public static int2 int2(double2 v); // 0x0000000184DB02B0-0x0000000184DB02D0
		public static uint hash(int2 v); // 0x000000018B254D4C-0x000000018B254D80
		public static uint2 hashwide(int2 v); // 0x000000018B259434-0x000000018B259474
		public static int shuffle(int2 left, int2 right, ShuffleComponent x); // 0x0000000185F34A6C-0x0000000185F34C80
		public static int2 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F34E64-0x0000000185F34EB0
		public static int3 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F34900-0x0000000185F34970
		public static int4 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F33F44-0x0000000185F33FD4
		internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component); // 0x0000000185F3332C-0x0000000185F33540
		public static int2x2 int2x2(int2 c0, int2 c1); // 0x0000000182E515B0-0x0000000182E56440
		public static int2x2 int2x2(int m00, int m01, int m10, int m11); // 0x000000018B25A428-0x000000018B25A448
		public static int2x2 int2x2(int v); // 0x000000018B25A410-0x000000018B25A428
		public static int2x2 int2x2(bool v); // 0x000000018B25A4CC-0x000000018B25A4E4
		public static int2x2 int2x2(bool2x2 v); // 0x000000018B25A3CC-0x000000018B25A3EC
		public static int2x2 int2x2(uint v); // 0x000000018B25A410-0x000000018B25A428
		public static int2x2 int2x2(uint2x2 v); // 0x000000018B25A490-0x000000018B25A4B4
		public static int2x2 int2x2(float v); // 0x000000018B25A478-0x000000018B25A490
		public static int2x2 int2x2(float2x2 v); // 0x000000018B25A3EC-0x000000018B25A410
		public static int2x2 int2x2(double v); // 0x000000018B25A4B4-0x000000018B25A4CC
		public static int2x2 int2x2(double2x2 v); // 0x000000018B25A448-0x000000018B25A478
		public static int2x2 transpose(int2x2 v); // 0x000000018B274334-0x000000018B274370
		public static int determinant(int2x2 m); // 0x0000000184DAE310-0x0000000184DAE320
		public static uint hash(int2x2 v); // 0x000000018B255708-0x000000018B25576C
		public static uint2 hashwide(int2x2 v); // 0x000000018B2582B8-0x000000018B25832C
		public static int2x3 int2x3(int2 c0, int2 c1, int2 c2); // 0x0000000184DAF5A0-0x0000000184DAF5B0
		public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12); // 0x0000000185F164A8-0x0000000185F164E0
		public static int2x3 int2x3(int v); // 0x000000018B25A53C-0x000000018B25A55C
		public static int2x3 int2x3(bool v); // 0x000000018B25A5F0-0x000000018B25A610
		public static int2x3 int2x3(bool2x3 v); // 0x000000018B25A57C-0x000000018B25A5B4
		public static int2x3 int2x3(uint v); // 0x000000018B25A53C-0x000000018B25A55C
		public static int2x3 int2x3(uint2x3 v); // 0x000000018B25A504-0x000000018B25A53C
		public static int2x3 int2x3(float v); // 0x000000018B25A4E4-0x000000018B25A504
		public static int2x3 int2x3(float2x3 v); // 0x000000018B25A610-0x000000018B25A648
		public static int2x3 int2x3(double v); // 0x000000018B25A55C-0x000000018B25A57C
		public static int2x3 int2x3(double2x3 v); // 0x000000018B25A5B4-0x000000018B25A5F0
		public static int3x2 transpose(int2x3 v); // 0x000000018B274F98-0x000000018B274FE4
		public static uint hash(int2x3 v); // 0x000000018B254F84-0x000000018B255014
		public static uint2 hashwide(int2x3 v); // 0x000000018B2591D4-0x000000018B259274
		public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3); // 0x0000000184DB02D0-0x0000000184DB02F0
		public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13); // 0x0000000185F164E0-0x0000000185F16534
		public static int2x4 int2x4(int v); // 0x000000018B25A66C-0x000000018B25A688
		public static int2x4 int2x4(bool v); // 0x000000018B25A6BC-0x000000018B25A6D8
		public static int2x4 int2x4(bool2x4 v); // 0x000000018B25A648-0x000000018B25A66C
		public static int2x4 int2x4(uint v); // 0x000000018B25A66C-0x000000018B25A688
		public static int2x4 int2x4(uint2x4 v); // 0x000000018B25A688-0x000000018B25A6BC
		public static int2x4 int2x4(float v); // 0x000000018B25A728-0x000000018B25A744
		public static int2x4 int2x4(float2x4 v); // 0x000000018B25A6F4-0x000000018B25A728
		public static int2x4 int2x4(double v); // 0x000000018B25A6D8-0x000000018B25A6F4
		public static int2x4 int2x4(double2x4 v); // 0x000000018B25A744-0x000000018B25A788
		public static int4x2 transpose(int2x4 v); // 0x000000018B27454C-0x000000018B2745A4
		public static uint hash(int2x4 v); // 0x000000018B25473C-0x000000018B2547F8
		public static uint2 hashwide(int2x4 v); // 0x000000018B257B00-0x000000018B257BCC
		public static int3 int3(int x, int y, int z); // 0x0000000184DAD8B0-0x0000000184DAD8C0
		public static int3 int3(int x, int2 yz); // 0x0000000184DB0330-0x0000000184DB0350
		public static int3 int3(int2 xy, int z); // 0x0000000184DB0350-0x0000000184DB0370
		public static int3 int3(int3 xyz); // 0x0000000184DB0370-0x0000000184DB03A0
		public static int3 int3(int v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static int3 int3(bool v); // 0x000000018B25A788-0x000000018B25A7A0
		public static int3 int3(bool3 v); // 0x000000018B25A7A0-0x000000018B25A7D4
		public static int3 int3(uint v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static int3 int3(uint3 v); // 0x0000000184DB0370-0x0000000184DB03A0
		public static int3 int3(float v); // 0x0000000184DB03C0-0x0000000184DB03E0
		public static int3 int3(float3 v); // 0x0000000184DB0300-0x0000000184DB0330
		public static int3 int3(double v); // 0x0000000184DB03A0-0x0000000184DB03C0
		public static int3 int3(double3 v); // 0x0000000184DB03E0-0x0000000184DB0420
		public static uint hash(int3 v); // 0x000000018B256128-0x000000018B25619C
		public static uint3 hashwide(int3 v); // 0x0000000185F15AF0-0x0000000185F160D0
		public static int shuffle(int3 left, int3 right, ShuffleComponent x); // 0x0000000185F33DE8-0x0000000185F33EC4
		public static int2 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F3429C-0x0000000185F343D8
		public static int3 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F34C80-0x0000000185F34DD4
		public static int4 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F343D8-0x0000000185F344F0
		internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component); // 0x0000000185F327BC-0x0000000185F328C0
		public static int3x2 int3x2(int3 c0, int3 c1); // 0x0000000184DAF7F0-0x0000000184DAF820
		public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21); // 0x0000000185F16534-0x0000000185F165C4
		public static int3x2 int3x2(int v); // 0x000000018B25A884-0x000000018B25A8A4
		public static int3x2 int3x2(bool v); // 0x000000018B25A8A4-0x000000018B25A8C4
		public static int3x2 int3x2(bool3x2 v); // 0x000000018B25A8C4-0x000000018B25A8FC
		public static int3x2 int3x2(uint v); // 0x000000018B25A884-0x000000018B25A8A4
		public static int3x2 int3x2(uint3x2 v); // 0x000000018B25A814-0x000000018B25A84C
		public static int3x2 int3x2(float v); // 0x000000018B25A8FC-0x000000018B25A91C
		public static int3x2 int3x2(float3x2 v); // 0x000000018B25A84C-0x000000018B25A884
		public static int3x2 int3x2(double v); // 0x000000018B25A91C-0x000000018B25A93C
		public static int3x2 int3x2(double3x2 v); // 0x000000018B25A7D4-0x000000018B25A814
		public static int2x3 transpose(int3x2 v); // 0x000000018B274370-0x000000018B2743BC
		public static uint hash(int3x2 v); // 0x000000018B256334-0x000000018B256414
		public static uint3 hashwide(int3x2 v); // 0x000000018B2581C0-0x000000018B2582B8
		public static int3x3 int3x3(int3 c0, int3 c1, int3 c2); // 0x00000001834C99D0-0x00000001834C9A10
		public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22); // 0x0000000185F165C4-0x0000000185F16688
		public static int3x3 int3x3(int v); // 0x000000018B25A93C-0x000000018B25A95C
		public static int3x3 int3x3(bool v); // 0x000000018B25AAB4-0x000000018B25AAD4
		public static int3x3 int3x3(bool3x3 v); // 0x000000018B25AA74-0x000000018B25AAB4
		public static int3x3 int3x3(uint v); // 0x000000018B25A93C-0x000000018B25A95C
		public static int3x3 int3x3(uint3x3 v); // 0x000000018B25A97C-0x000000018B25A9BC
		public static int3x3 int3x3(float v); // 0x000000018B25A95C-0x000000018B25A97C
		public static int3x3 int3x3(float3x3 v); // 0x000000018B25AA14-0x000000018B25AA54
		public static int3x3 int3x3(double v); // 0x000000018B25AA54-0x000000018B25AA74
		public static int3x3 int3x3(double3x3 v); // 0x000000018B25A9BC-0x000000018B25AA14
		public static int3x3 transpose(int3x3 v); // 0x000000018B2748D4-0x000000018B274940
		public static int determinant(int3x3 m); // 0x0000000184DAE920-0x0000000184DAE9C0
		public static uint hash(int3x3 v); // 0x000000018B25449C-0x000000018B2545F0
		public static uint3 hashwide(int3x3 v); // 0x000000018B257994-0x000000018B257B00
		public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3); // 0x0000000184DAF820-0x0000000184DAF870
		public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23); // 0x0000000185F16688-0x0000000185F16750
		public static int3x4 int3x4(int v); // 0x000000018B25AB90-0x000000018B25ABB0
		public static int3x4 int3x4(bool v); // 0x000000018B25AAD4-0x000000018B25AAF4
		public static int3x4 int3x4(bool3x4 v); // 0x000000018B25AB54-0x000000018B25AB90
		public static int3x4 int3x4(uint v); // 0x000000018B25AB90-0x000000018B25ABB0
		public static int3x4 int3x4(uint3x4 v); // 0x000000018B25AC34-0x000000018B25AC78
		public static int3x4 int3x4(float v); // 0x000000018B25AC14-0x000000018B25AC34
		public static int3x4 int3x4(float3x4 v); // 0x000000018B25ABB0-0x000000018B25ABF4
		public static int3x4 int3x4(double v); // 0x000000018B25ABF4-0x000000018B25AC14
		public static int3x4 int3x4(double3x4 v); // 0x000000018B25AAF4-0x000000018B25AB54
		public static int4x3 transpose(int3x4 v); // 0x000000018B27445C-0x000000018B2744E0
		public static uint hash(int3x4 v); // 0x000000018B254240-0x000000018B25440C
		public static uint3 hashwide(int3x4 v); // 0x000000018B258984-0x000000018B258B64
		public static int4 int4(int x, int y, int z, int w); // 0x0000000184DAD8C0-0x0000000184DAD8E0
		public static int4 int4(int x, int y, int2 zw); // 0x0000000184DB04B0-0x0000000184DB04D0
		public static int4 int4(int x, int2 yz, int w); // 0x0000000184DB0530-0x0000000184DB0550
		public static int4 int4(int x, int3 yzw); // 0x0000000184DB0430-0x0000000184DB0470
		public static int4 int4(int2 xy, int z, int w); // 0x0000000184DB04D0-0x0000000184DB04F0
		public static int4 int4(int2 xy, int2 zw); // 0x0000000184DAB610-0x0000000184DAB630
		public static int4 int4(int3 xyz, int w); // 0x0000000184DB04F0-0x0000000184DB0530
		public static int4 int4(int4 xyzw); // 0x000000018B25AC78-0x000000018B25ACA4
		public static int4 int4(int v); // 0x0000000184DB0420-0x0000000184DB0430
		public static int4 int4(bool v); // 0x000000018B25ACA4-0x000000018B25ACC4
		public static int4 int4(bool4 v); // 0x000000018B25ACC4-0x000000018B25AD08
		public static int4 int4(uint v); // 0x0000000184DB0420-0x0000000184DB0430
		public static int4 int4(uint4 v); // 0x000000018B25AC78-0x000000018B25ACA4
		public static int4 int4(float v); // 0x0000000184DB0490-0x0000000184DB04B0
		public static int4 int4(float4 v); // 0x000000018B25AD38-0x000000018B25AD6C
		public static int4 int4(double v); // 0x0000000184DB0470-0x0000000184DB0490
		public static int4 int4(double4 v); // 0x000000018B25AD08-0x000000018B25AD38
		public static uint hash(int4 v); // 0x000000018B256414-0x000000018B256480
		public static uint4 hashwide(int4 v); // 0x000000018B259FE0-0x000000018B25A05C
		public static int shuffle(int4 left, int4 right, ShuffleComponent x); // 0x000000018B271EA0-0x000000018B271EC8
		public static int2 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B2716B8-0x000000018B271710
		public static int3 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B272564-0x000000018B27260C
		public static int4 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B27189C-0x000000018B271974
		internal static int select_shuffle_component(int4 a, int4 b, ShuffleComponent component); // 0x0000000185F32DD0-0x0000000185F33024
		public static int4x2 int4x2(int4 c0, int4 c1); // 0x0000000184DAFA00-0x0000000184DAFA20
		public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31); // 0x0000000185F16750-0x0000000185F16804
		public static int4x2 int4x2(int v); // 0x000000018B25ADCC-0x000000018B25ADE8
		public static int4x2 int4x2(bool v); // 0x000000018B25AE38-0x000000018B25AE54
		public static int4x2 int4x2(bool4x2 v); // 0x000000018B25AE88-0x000000018B25AEAC
		public static int4x2 int4x2(uint v); // 0x000000018B25ADCC-0x000000018B25ADE8
		public static int4x2 int4x2(uint4x2 v); // 0x000000018B25ADE8-0x000000018B25AE1C
		public static int4x2 int4x2(float v); // 0x000000018B25AE1C-0x000000018B25AE38
		public static int4x2 int4x2(float4x2 v); // 0x000000018B25AE54-0x000000018B25AE88
		public static int4x2 int4x2(double v); // 0x000000018B25AD6C-0x000000018B25AD88
		public static int4x2 int4x2(double4x2 v); // 0x000000018B25AD88-0x000000018B25ADCC
		public static int2x4 transpose(int4x2 v); // 0x000000018B2743BC-0x000000018B274414
		public static uint hash(int4x2 v); // 0x000000018B25587C-0x000000018B255948
		public static uint4 hashwide(int4x2 v); // 0x000000018B257E2C-0x000000018B257F04
		public static int4x3 int4x3(int4 c0, int4 c1, int4 c2); // 0x0000000184DAFA20-0x0000000184DAFA40
		public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32); // 0x0000000185F16804-0x0000000185F169CC
		public static int4x3 int4x3(int v); // 0x000000018B25AECC-0x000000018B25AEEC
		public static int4x3 int4x3(bool v); // 0x000000018B25AFEC-0x000000018B25B00C
		public static int4x3 int4x3(bool4x3 v); // 0x000000018B25AF6C-0x000000018B25AFA8
		public static int4x3 int4x3(uint v); // 0x000000018B25AECC-0x000000018B25AEEC
		public static int4x3 int4x3(uint4x3 v); // 0x000000018B25AFA8-0x000000018B25AFEC
		public static int4x3 int4x3(float v); // 0x000000018B25AF4C-0x000000018B25AF6C
		public static int4x3 int4x3(float4x3 v); // 0x000000018B25B00C-0x000000018B25B04C
		public static int4x3 int4x3(double v); // 0x000000018B25AEAC-0x000000018B25AECC
		public static int4x3 int4x3(double4x3 v); // 0x000000018B25AEEC-0x000000018B25AF4C
		public static int3x4 transpose(int4x3 v); // 0x000000018B274770-0x000000018B2747F4
		public static uint hash(int4x3 v); // 0x000000018B255948-0x000000018B255A78
		public static uint4 hashwide(int4x3 v); // 0x000000018B259474-0x000000018B2595B0
		public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3); // 0x0000000184DAFA40-0x0000000184DAFA70
		public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33); // 0x0000000185F169CC-0x0000000185F16C64
		public static int4x4 int4x4(int v); // 0x000000018B25B0CC-0x000000018B25B0F0
		public static int4x4 int4x4(bool v); // 0x000000018B25B04C-0x000000018B25B070
		public static int4x4 int4x4(bool4x4 v); // 0x000000018B25B114-0x000000018B25B14C
		public static int4x4 int4x4(uint v); // 0x000000018B25B0CC-0x000000018B25B0F0
		public static int4x4 int4x4(uint4x4 v); // 0x000000018B25B14C-0x000000018B25B1A8
		public static int4x4 int4x4(float v); // 0x000000018B25B0F0-0x000000018B25B114
		public static int4x4 int4x4(float4x4 v); // 0x000000018B25B070-0x000000018B25B0CC
		public static int4x4 int4x4(double v); // 0x000000018B25B234-0x000000018B25B258
		public static int4x4 int4x4(double4x4 v); // 0x000000018B25B1A8-0x000000018B25B234
		public static int4x4 transpose(int4x4 v); // 0x000000018B274AF4-0x000000018B274B9C
		public static int determinant(int4x4 m); // 0x0000000184DAE650-0x0000000184DAE870
		public static uint hash(int4x4 v); // 0x000000018B2552C8-0x000000018B255458
		public static uint4 hashwide(int4x4 v); // 0x000000018B25832C-0x000000018B2584C8
		public static int asint(uint x); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static int2 asint(uint2 x); // 0x000000018464E630-0x000000018464E640
		public static int3 asint(uint3 x); // 0x0000000184D93250-0x0000000184D93270
		public static int4 asint(uint4 x); // 0x0000000182B77630-0x0000000182B77640
		public static int asint(float x); // 0x0000000184D94B90-0x0000000184D94BA0
		public static int2 asint(float2 x); // 0x0000000184DAD550-0x0000000184DAD560
		public static int3 asint(float3 x); // 0x0000000184D93250-0x0000000184D93270
		public static int4 asint(float4 x); // 0x0000000182B77630-0x0000000182B77640
		public static uint asuint(int x); // 0x0000000184D88BE0-0x0000000184D88BF0
		public static uint2 asuint(int2 x); // 0x000000018464E630-0x000000018464E640
		public static uint3 asuint(int3 x); // 0x0000000184D93250-0x0000000184D93270
		public static uint4 asuint(int4 x); // 0x0000000182B77630-0x0000000182B77640
		public static uint asuint(float x); // 0x0000000184D94B90-0x0000000184D94BA0
		public static uint2 asuint(float2 x); // 0x0000000184DAD550-0x0000000184DAD560
		public static uint3 asuint(float3 x); // 0x0000000184D93250-0x0000000184D93270
		public static uint4 asuint(float4 x); // 0x0000000182B77630-0x0000000182B77640
		public static long aslong(ulong x); // 0x000000018464E630-0x000000018464E640
		public static long aslong(double x); // 0x0000000184DA48C0-0x0000000184DA48D0
		public static ulong asulong(long x); // 0x000000018464E630-0x000000018464E640
		public static ulong asulong(double x); // 0x0000000184DA48C0-0x0000000184DA48D0
		public static float asfloat(int x); // 0x0000000184D94BC0-0x0000000184D94BD0
		public static float2 asfloat(int2 x); // 0x0000000184DAD350-0x0000000184DAD370
		public static float3 asfloat(int3 x); // 0x0000000184D93250-0x0000000184D93270
		public static float4 asfloat(int4 x); // 0x0000000182B77630-0x0000000182B77640
		public static float asfloat(uint x); // 0x0000000184D94BC0-0x0000000184D94BD0
		public static float2 asfloat(uint2 x); // 0x0000000184DAD350-0x0000000184DAD370
		public static float3 asfloat(uint3 x); // 0x0000000184D93250-0x0000000184D93270
		public static float4 asfloat(uint4 x); // 0x0000000182B77630-0x0000000182B77640
		public static int bitmask(bool4 value); // 0x000000018B24C880-0x000000018B24C8BC
		public static double asdouble(long x); // 0x0000000184DA48D0-0x0000000184DA48E0
		public static double asdouble(ulong x); // 0x0000000184DA48D0-0x0000000184DA48E0
		public static bool isfinite(float x); // 0x000000018B25CEC0-0x000000018B25CEDC
		public static bool2 isfinite(float2 x); // 0x000000018B25CE48-0x000000018B25CE7C
		public static bool3 isfinite(float3 x); // 0x000000018B25CD08-0x000000018B25CD74
		public static bool4 isfinite(float4 x); // 0x000000018B25CD74-0x000000018B25CDD8
		public static bool isfinite(double x); // 0x000000018B25CCE0-0x000000018B25CD08
		public static bool2 isfinite(double2 x); // 0x000000018B25CE7C-0x000000018B25CEC0
		public static bool3 isfinite(double3 x); // 0x000000018B25CEDC-0x000000018B25CF50
		public static bool4 isfinite(double4 x); // 0x000000018B25CDD8-0x000000018B25CE48
		public static bool isinf(float x); // 0x0000000185F16FD4-0x0000000185F172F4
		public static bool2 isinf(float2 x); // 0x000000018B25D030-0x000000018B25D050
		public static bool3 isinf(float3 x); // 0x000000018B25D0C8-0x000000018B25D130
		public static bool4 isinf(float4 x); // 0x000000018B25D08C-0x000000018B25D0C8
		public static bool isinf(double x); // 0x000000018B25CFB8-0x000000018B25CFE4
		public static bool2 isinf(double2 x); // 0x000000018B25D050-0x000000018B25D08C
		public static bool3 isinf(double3 x); // 0x000000018B25CF50-0x000000018B25CFB8
		public static bool4 isinf(double4 x); // 0x000000018B25CFE4-0x000000018B25D030
		public static bool isnan(float x); // 0x000000018B25D1DC-0x000000018B25D1F0
		public static bool2 isnan(float2 x); // 0x000000018B25D190-0x000000018B25D1DC
		public static bool3 isnan(float3 x); // 0x000000018B25D338-0x000000018B25D3B0
		public static bool4 isnan(float4 x); // 0x000000018B25D2BC-0x000000018B25D338
		public static bool isnan(double x); // 0x000000018B25D258-0x000000018B25D27C
		public static bool2 isnan(double2 x); // 0x000000018B25D27C-0x000000018B25D2BC
		public static bool3 isnan(double3 x); // 0x000000018B25D130-0x000000018B25D190
		public static bool4 isnan(double4 x); // 0x000000018B25D1F0-0x000000018B25D258
		public static bool ispow2(int x); // 0x000000018B25D404-0x000000018B25D414
		public static bool2 ispow2(int2 x); // 0x000000018B25D414-0x000000018B25D448
		public static bool3 ispow2(int3 x); // 0x000000018B25D3B0-0x000000018B25D404
		public static bool4 ispow2(int4 x); // 0x000000018B25D554-0x000000018B25D5CC
		public static bool ispow2(uint x); // 0x000000018B25D4C0-0x000000018B25D4D0
		public static bool2 ispow2(uint2 x); // 0x000000018B25D4D0-0x000000018B25D504
		public static bool3 ispow2(uint3 x); // 0x000000018B25D504-0x000000018B25D554
		public static bool4 ispow2(uint4 x); // 0x000000018B25D448-0x000000018B25D4C0
		public static int min(int x, int y); // 0x000000018B25E778-0x000000018B25E780
		public static int2 min(int2 x, int2 y); // 0x000000018B25EA5C-0x000000018B25EA88
		public static int3 min(int3 x, int3 y); // 0x000000018B25EA9C-0x000000018B25EAD0
		public static int4 min(int4 x, int4 y); // 0x000000018B25E854-0x000000018B25E898
		public static uint min(uint x, uint y); // 0x000000018B25EA94-0x000000018B25EA9C
		public static uint2 min(uint2 x, uint2 y); // 0x000000018B25E940-0x000000018B25E96C
		public static uint3 min(uint3 x, uint3 y); // 0x000000018B25E9D8-0x000000018B25EA0C
		public static uint4 min(uint4 x, uint4 y); // 0x000000018B25EA0C-0x000000018B25EA50
		public static long min(long x, long y); // 0x000000018B25EA50-0x000000018B25EA5C
		public static ulong min(ulong x, ulong y); // 0x000000018B25EA88-0x000000018B25EA94
		public static float min(float x, float y); // 0x000000018B25E96C-0x000000018B25E980
		public static float2 min(float2 x, float2 y); // 0x000000018B25E980-0x000000018B25E9D8
		public static float3 min(float3 x, float3 y); // 0x000000018B25E7EC-0x000000018B25E854
		public static float4 min(float4 x, float4 y); // 0x0000000185F1883C-0x0000000185F189DC
		public static double min(double x, double y); // 0x000000018B25E898-0x000000018B25E8B0
		public static double2 min(double2 x, double2 y); // 0x0000000185F186FC-0x0000000185F1883C
		public static double3 min(double3 x, double3 y); // 0x000000018B25E780-0x000000018B25E7EC
		public static double4 min(double4 x, double4 y); // 0x000000018B25E8B0-0x000000018B25E940
		public static int max(int x, int y); // 0x0000000183347DE0-0x0000000183347DF0
		public static int2 max(int2 x, int2 y); // 0x000000018B25E444-0x000000018B25E470
		public static int3 max(int3 x, int3 y); // 0x000000018B25E410-0x000000018B25E444
		public static int4 max(int4 x, int4 y); // 0x000000018B25E5D0-0x000000018B25E614
		public static uint max(uint x, uint y); // 0x000000018B25E6AC-0x000000018B25E6B4
		public static uint2 max(uint2 x, uint2 y); // 0x000000018B25E6B4-0x000000018B25E6E0
		public static uint3 max(uint3 x, uint3 y); // 0x000000018B25E6EC-0x000000018B25E720
		public static uint4 max(uint4 x, uint4 y); // 0x000000018B25E58C-0x000000018B25E5D0
		public static long max(long x, long y); // 0x000000018B25E6E0-0x000000018B25E6EC
		public static ulong max(ulong x, ulong y); // 0x000000018B25E4F4-0x000000018B25E500
		public static float max(float x, float y); // 0x000000018B25E4E0-0x000000018B25E4F4
		public static float2 max(float2 x, float2 y); // 0x000000018B25E720-0x000000018B25E778
		public static float3 max(float3 x, float3 y); // 0x000000018B25E470-0x000000018B25E4E0
		public static float4 max(float4 x, float4 y); // 0x0000000185F183B4-0x0000000185F18500
		public static double max(double x, double y); // 0x000000018B25E500-0x000000018B25E518
		public static double2 max(double2 x, double2 y); // 0x0000000185F18500-0x0000000185F186FC
		public static double3 max(double3 x, double3 y); // 0x000000018B25E518-0x000000018B25E58C
		public static double4 max(double4 x, double4 y); // 0x000000018B25E614-0x000000018B25E6AC
		public static float lerp(float start, float end, float t); // 0x0000000184D899F0-0x0000000184D89A00
		public static float2 lerp(float2 start, float2 end, float t); // 0x000000018B25DC44-0x000000018B25DC80
		public static float3 lerp(float3 start, float3 end, float t); // 0x0000000185F176FC-0x0000000185F17B10
		public static float4 lerp(float4 start, float4 end, float t); // 0x000000018B25DC80-0x000000018B25DCFC
		public static float2 lerp(float2 start, float2 end, float2 t); // 0x000000018B25D878-0x000000018B25D8B4
		public static float3 lerp(float3 start, float3 end, float3 t); // 0x0000000185F172F4-0x0000000185F176FC
		public static float4 lerp(float4 start, float4 end, float4 t); // 0x000000018B25D7F0-0x000000018B25D878
		public static double lerp(double start, double end, double t); // 0x0000000184DB05D0-0x0000000184DB05E0
		public static double2 lerp(double2 start, double2 end, double t); // 0x000000018B25D774-0x000000018B25D7F0
		public static double3 lerp(double3 start, double3 end, double t); // 0x000000018B25DB84-0x000000018B25DC44
		public static double4 lerp(double4 start, double4 end, double t); // 0x000000018B25DA48-0x000000018B25DAFC
		public static double2 lerp(double2 start, double2 end, double2 t); // 0x000000018B25DAFC-0x000000018B25DB84
		public static double3 lerp(double3 start, double3 end, double3 t); // 0x000000018B25D978-0x000000018B25DA48
		public static double4 lerp(double4 start, double4 end, double4 t); // 0x000000018B25D8B4-0x000000018B25D978
		public static float unlerp(float start, float end, float x); // 0x000000018B2760B4-0x000000018B2760C4
		public static float2 unlerp(float2 start, float2 end, float2 x); // 0x000000018B27617C-0x000000018B2761D8
		public static float3 unlerp(float3 start, float3 end, float3 x); // 0x0000000185F3A004-0x0000000185F3A25C
		public static float4 unlerp(float4 start, float4 end, float4 x); // 0x000000018B2760C4-0x000000018B27617C
		public static double unlerp(double start, double end, double x); // 0x000000018B2762B4-0x000000018B2762C4
		public static double2 unlerp(double2 start, double2 end, double2 x); // 0x000000018B27603C-0x000000018B2760B4
		public static double3 unlerp(double3 start, double3 end, double3 x); // 0x000000018B275F4C-0x000000018B27603C
		public static double4 unlerp(double4 start, double4 end, double4 x); // 0x000000018B2761D8-0x000000018B2762B4
		public static float remap(float srcStart, float srcEnd, float dstStart, float dstEnd, float x); // 0x000000018B26F930-0x000000018B26F954
		public static float2 remap(float2 srcStart, float2 srcEnd, float2 dstStart, float2 dstEnd, float2 x); // 0x000000018B26F8AC-0x000000018B26F930
		public static float3 remap(float3 srcStart, float3 srcEnd, float3 dstStart, float3 dstEnd, float3 x); // 0x0000000185F30DA0-0x0000000185F3111C
		public static float4 remap(float4 srcStart, float4 srcEnd, float4 dstStart, float4 dstEnd, float4 x); // 0x000000018B26F7F8-0x000000018B26F888
		public static double remap(double srcStart, double srcEnd, double dstStart, double dstEnd, double x); // 0x000000018B26F888-0x000000018B26F8AC
		public static double2 remap(double2 srcStart, double2 srcEnd, double2 dstStart, double2 dstEnd, double2 x); // 0x000000018B26FA34-0x000000018B26FAC4
		public static double3 remap(double3 srcStart, double3 srcEnd, double3 dstStart, double3 dstEnd, double3 x); // 0x000000018B26F954-0x000000018B26FA34
		public static double4 remap(double4 srcStart, double4 srcEnd, double4 dstStart, double4 dstEnd, double4 x); // 0x000000018B26FAC4-0x000000018B26FB98
		public static int mad(int mulA, int mulB, int addC); // 0x0000000184DB09D0-0x0000000184DB09E0
		public static int2 mad(int2 mulA, int2 mulB, int2 addC); // 0x000000018B25E1F0-0x000000018B25E208
		public static int3 mad(int3 mulA, int3 mulB, int3 addC); // 0x0000000185F180B4-0x0000000185F1832C
		public static int4 mad(int4 mulA, int4 mulB, int4 addC); // 0x000000018B25E18C-0x000000018B25E1F0
		public static uint mad(uint mulA, uint mulB, uint addC); // 0x0000000184DB09D0-0x0000000184DB09E0
		public static uint2 mad(uint2 mulA, uint2 mulB, uint2 addC); // 0x000000018B25E1F0-0x000000018B25E208
		public static uint3 mad(uint3 mulA, uint3 mulB, uint3 addC); // 0x0000000185F180B4-0x0000000185F1832C
		public static uint4 mad(uint4 mulA, uint4 mulB, uint4 addC); // 0x000000018B25E18C-0x000000018B25E1F0
		public static long mad(long mulA, long mulB, long addC); // 0x0000000184DB09A0-0x0000000184DB09B0
		public static ulong mad(ulong mulA, ulong mulB, ulong addC); // 0x0000000184DB09A0-0x0000000184DB09B0
		public static float mad(float mulA, float mulB, float addC); // 0x0000000184DB09B0-0x0000000184DB09C0
		public static float2 mad(float2 mulA, float2 mulB, float2 addC); // 0x000000018B25E2A0-0x000000018B25E2B8
		public static float3 mad(float3 mulA, float3 mulB, float3 addC); // 0x0000000185F1832C-0x0000000185F183B4
		public static float4 mad(float4 mulA, float4 mulB, float4 addC); // 0x000000018B25E31C-0x000000018B25E380
		public static double mad(double mulA, double mulB, double addC); // 0x0000000184DB09C0-0x0000000184DB09D0
		public static double2 mad(double2 mulA, double2 mulB, double2 addC); // 0x000000018B25E2B8-0x000000018B25E31C
		public static double3 mad(double3 mulA, double3 mulB, double3 addC); // 0x000000018B25E208-0x000000018B25E2A0
		public static double4 mad(double4 mulA, double4 mulB, double4 addC); // 0x000000018B25E380-0x000000018B25E410
		public static int clamp(int valueToClamp, int lowerBound, int upperBound); // 0x000000018B24D4C8-0x000000018B24D4DC
		public static int2 clamp(int2 valueToClamp, int2 lowerBound, int2 upperBound); // 0x000000018B24D518-0x000000018B24D574
		public static int3 clamp(int3 valueToClamp, int3 lowerBound, int3 upperBound); // 0x0000000185F09A58-0x0000000185F09C00
		public static int4 clamp(int4 valueToClamp, int4 lowerBound, int4 upperBound); // 0x000000018B24D404-0x000000018B24D4C8
		public static uint clamp(uint valueToClamp, uint lowerBound, uint upperBound); // 0x000000018B24D3F0-0x000000018B24D404
		public static uint2 clamp(uint2 valueToClamp, uint2 lowerBound, uint2 upperBound); // 0x000000018B24D2CC-0x000000018B24D328
		public static uint3 clamp(uint3 valueToClamp, uint3 lowerBound, uint3 upperBound); // 0x0000000185F09C00-0x0000000185F09DB8
		public static uint4 clamp(uint4 valueToClamp, uint4 lowerBound, uint4 upperBound); // 0x000000018B24D104-0x000000018B24D1C8
		public static long clamp(long valueToClamp, long lowerBound, long upperBound); // 0x000000018B24D350-0x000000018B24D364
		public static ulong clamp(ulong valueToClamp, ulong lowerBound, ulong upperBound); // 0x000000018B24D504-0x000000018B24D518
		public static float clamp(float valueToClamp, float lowerBound, float upperBound); // 0x000000018B24D4DC-0x000000018B24D504
		public static float2 clamp(float2 valueToClamp, float2 lowerBound, float2 upperBound); // 0x000000018B24D328-0x000000018B24D350
		public static float3 clamp(float3 valueToClamp, float3 lowerBound, float3 upperBound); // 0x000000018B24D364-0x000000018B24D3F0
		public static float4 clamp(float4 valueToClamp, float4 lowerBound, float4 upperBound); // 0x000000018B24D1C8-0x000000018B24D230
		public static double clamp(double valueToClamp, double lowerBound, double upperBound); // 0x0000000185F09928-0x0000000185F09A58
		public static double2 clamp(double2 valueToClamp, double2 lowerBound, double2 upperBound); // 0x000000018B24D574-0x000000018B24D5DC
		public static double3 clamp(double3 valueToClamp, double3 lowerBound, double3 upperBound); // 0x000000018B24D230-0x000000018B24D2CC
		public static double4 clamp(double4 valueToClamp, double4 lowerBound, double4 upperBound); // 0x000000018B24D5DC-0x000000018B24D66C
		public static float saturate(float x); // 0x0000000189F3AE20-0x0000000189F3AE30
		public static float2 saturate(float2 x); // 0x000000018B270EE0-0x000000018B270F1C
		public static float3 saturate(float3 x); // 0x0000000185F3215C-0x0000000185F3249C
		public static float4 saturate(float4 x); // 0x000000018B270E94-0x000000018B270EE0
		public static double saturate(double x); // 0x000000018B270E84-0x000000018B270E94
		public static double2 saturate(double2 x); // 0x000000018B270FB8-0x000000018B271008
		public static double3 saturate(double3 x); // 0x000000018B270F1C-0x000000018B270FB8
		public static double4 saturate(double4 x); // 0x000000018B270E18-0x000000018B270E84
		public static int abs(int x); // 0x000000018B24BC98-0x000000018B24BCA4
		public static int2 abs(int2 x); // 0x000000018B24BB9C-0x000000018B24BBE0
		public static int3 abs(int3 x); // 0x0000000185F07C48-0x0000000185F08180
		public static int4 abs(int4 x); // 0x000000018B24BBE0-0x000000018B24BC98
		public static long abs(long x); // 0x000000018B24BB8C-0x000000018B24BB9C
		public static float abs(float x); // 0x0000000184DAD080-0x0000000184DAD090
		public static float2 abs(float2 x); // 0x0000000184DAD140-0x0000000184DAD170
		public static float3 abs(float3 x); // 0x0000000183B0AD90-0x0000000183B0ADE0
		public static float4 abs(float4 x); // 0x000000018B24BB58-0x000000018B24BB8C
		public static double abs(double x); // 0x0000000184DAD120-0x0000000184DAD140
		public static double2 abs(double2 x); // 0x0000000184DAD0F0-0x0000000184DAD120
		public static double3 abs(double3 x); // 0x0000000184DAD040-0x0000000184DAD080
		public static double4 abs(double4 x); // 0x0000000184DAD090-0x0000000184DAD0F0
		public static int dot(int x, int y); // 0x0000000184DAEA70-0x0000000184DAEA80
		public static int dot(int2 x, int2 y); // 0x0000000184DAEB00-0x0000000184DAEB20
		public static int dot(int3 x, int3 y); // 0x0000000184D85D00-0x0000000184D85D20
		public static int dot(int4 x, int4 y); // 0x0000000184DAEAC0-0x0000000184DAEAF0
		public static uint dot(uint x, uint y); // 0x0000000184DAEA70-0x0000000184DAEA80
		public static uint dot(uint2 x, uint2 y); // 0x0000000184DAEB00-0x0000000184DAEB20
		public static uint dot(uint3 x, uint3 y); // 0x0000000184D85D00-0x0000000184D85D20
		public static uint dot(uint4 x, uint4 y); // 0x0000000184DAEAC0-0x0000000184DAEAF0
		public static float dot(float x, float y); // 0x0000000184DAEB20-0x0000000184DAEB30
		public static float dot(float2 x, float2 y); // 0x0000000184D8B640-0x0000000184D8B670
		public static float dot(float3 x, float3 y); // 0x0000000184D8B7C0-0x0000000184D8B7F0
		public static float dot(float4 x, float4 y); // 0x00000001834C9990-0x00000001834C99D0
		public static double dot(double x, double y); // 0x0000000184DAEAF0-0x0000000184DAEB00
		public static double dot(double2 x, double2 y); // 0x0000000184DAEB60-0x0000000184DAEB80
		public static double dot(double3 x, double3 y); // 0x0000000184DAEB30-0x0000000184DAEB60
		public static double dot(double4 x, double4 y); // 0x0000000184DAEA80-0x0000000184DAEAC0
		public static float tan(float x); // 0x000000018B273C40-0x000000018B273C98
		public static float2 tan(float2 x); // 0x000000018B273ACC-0x000000018B273B08
		public static float3 tan(float3 x); // 0x0000000185F36CA4-0x0000000185F36E10
		public static float4 tan(float4 x); // 0x0000000185F36C20-0x0000000185F36CA4
		public static double tan(double x); // 0x000000018B273BF0-0x000000018B273C40
		public static double2 tan(double2 x); // 0x0000000185F36A40-0x0000000185F36C20
		public static double3 tan(double3 x); // 0x000000018B273B8C-0x000000018B273BF0
		public static double4 tan(double4 x); // 0x000000018B273B08-0x000000018B273B8C
		public static float tanh(float x); // 0x000000018B273E0C-0x000000018B273E64
		public static float2 tanh(float2 x); // 0x000000018B273DD0-0x000000018B273E0C
		public static float3 tanh(float3 x); // 0x0000000185F36F24-0x0000000185F36FE0
		public static float4 tanh(float4 x); // 0x0000000185F36E10-0x0000000185F36F24
		public static double tanh(double x); // 0x000000018B273D80-0x000000018B273DD0
		public static double2 tanh(double2 x); // 0x0000000185F36FE0-0x0000000185F39618
		public static double3 tanh(double3 x); // 0x000000018B273C98-0x000000018B273CFC
		public static double4 tanh(double4 x); // 0x000000018B273CFC-0x000000018B273D80
		public static float atan(float x); // 0x000000018B24C738-0x000000018B24C790
		public static float2 atan(float2 x); // 0x000000018B24C844-0x000000018B24C880
		public static float3 atan(float3 x); // 0x0000000185F0886C-0x0000000185F08A30
		public static float4 atan(float4 x); // 0x0000000185F087E8-0x0000000185F0886C
		public static double atan(double x); // 0x000000018B24C7F4-0x000000018B24C844
		public static double2 atan(double2 x); // 0x0000000185F08A30-0x0000000185F08B08
		public static double3 atan(double3 x); // 0x000000018B24C790-0x000000018B24C7F4
		public static double4 atan(double4 x); // 0x000000018B24C6B4-0x000000018B24C738
		public static float atan2(float y, float x); // 0x000000018B24C5AC-0x000000018B24C610
		public static float2 atan2(float2 y, float2 x); // 0x000000018B24C560-0x000000018B24C5AC
		public static float3 atan2(float3 y, float3 x); // 0x0000000185F08570-0x0000000185F08640
		public static float4 atan2(float4 y, float4 x); // 0x0000000185F086A0-0x0000000185F087E8
		public static double atan2(double y, double x); // 0x000000018B24C500-0x000000018B24C560
		public static double2 atan2(double2 y, double2 x); // 0x0000000185F08640-0x0000000185F086A0
		public static double3 atan2(double3 y, double3 x); // 0x000000018B24C480-0x000000018B24C500
		public static double4 atan2(double4 y, double4 x); // 0x000000018B24C610-0x000000018B24C6B4
		public static float cos(float x); // 0x000000018B24D9D8-0x000000018B24DA30
		public static float2 cos(float2 x); // 0x0000000184DADB80-0x0000000184DADBC0
		public static float3 cos(float3 x); // 0x0000000184DADC10-0x0000000184DADC60
		public static float4 cos(float4 x); // 0x0000000184DADD00-0x0000000184DADD60
		public static double cos(double x); // 0x000000018B24DA30-0x000000018B24DA80
		public static double2 cos(double2 x); // 0x0000000184DADC60-0x0000000184DADCA0
		public static double3 cos(double3 x); // 0x0000000184DADBC0-0x0000000184DADC10
		public static double4 cos(double4 x); // 0x0000000184DADCA0-0x0000000184DADD00
		public static float cosh(float x); // 0x000000018B24DA80-0x000000018B24DAD8
		public static float2 cosh(float2 x); // 0x0000000184DADD60-0x0000000184DADDA0
		public static float3 cosh(float3 x); // 0x0000000184DADDF0-0x0000000184DADE40
		public static float4 cosh(float4 x); // 0x0000000184DADEA0-0x0000000184DADF00
		public static double cosh(double x); // 0x000000018B24DAD8-0x000000018B24DB28
		public static double2 cosh(double2 x); // 0x0000000184DADF00-0x0000000184DADF40
		public static double3 cosh(double3 x); // 0x0000000184DADDA0-0x0000000184DADDF0
		public static double4 cosh(double4 x); // 0x0000000184DADE40-0x0000000184DADEA0
		public static float acos(float x); // 0x000000018B24BCF4-0x000000018B24BD4C
		public static float2 acos(float2 x); // 0x0000000184DAD170-0x0000000184DAD1B0
		public static float3 acos(float3 x); // 0x0000000184DAD1B0-0x0000000184DAD200
		public static float4 acos(float4 x); // 0x0000000184DAD260-0x0000000184DAD2C0
		public static double acos(double x); // 0x000000018B24BCA4-0x000000018B24BCF4
		public static double2 acos(double2 x); // 0x0000000184DAD2C0-0x0000000184DAD300
		public static double3 acos(double3 x); // 0x0000000184DAD300-0x0000000184DAD350
		public static double4 acos(double4 x); // 0x0000000184DAD200-0x0000000184DAD260
		public static float sin(float x); // 0x000000018B272850-0x000000018B2728A8
		public static float2 sin(float2 x); // 0x0000000184DB1B20-0x0000000184DB1B60
		public static float3 sin(float3 x); // 0x0000000184DB1A10-0x0000000184DB1A60
		public static float4 sin(float4 x); // 0x0000000184DB1AC0-0x0000000184DB1B20
		public static double sin(double x); // 0x000000018B2728A8-0x000000018B2728F8
		public static double2 sin(double2 x); // 0x0000000184DB1B60-0x0000000184DB1BA0
		public static double3 sin(double3 x); // 0x0000000184DB19C0-0x0000000184DB1A10
		public static double4 sin(double4 x); // 0x0000000184DB1A60-0x0000000184DB1AC0
		public static float sinh(float x); // 0x000000018B272BF0-0x000000018B272C48
		public static float2 sinh(float2 x); // 0x0000000184DB1DC0-0x0000000184DB1E00
		public static float3 sinh(float3 x); // 0x0000000184DB1C60-0x0000000184DB1CB0
		public static float4 sinh(float4 x); // 0x0000000184DB1D60-0x0000000184DB1DC0
		public static double sinh(double x); // 0x000000018B272BA0-0x000000018B272BF0
		public static double2 sinh(double2 x); // 0x0000000184DB1C20-0x0000000184DB1C60
		public static double3 sinh(double3 x); // 0x0000000184DB1D10-0x0000000184DB1D60
		public static double4 sinh(double4 x); // 0x0000000184DB1CB0-0x0000000184DB1D10
		public static float asin(float x); // 0x000000018B24C428-0x000000018B24C480
		public static float2 asin(float2 x); // 0x0000000184DAD370-0x0000000184DAD3B0
		public static float3 asin(float3 x); // 0x0000000184DAD410-0x0000000184DAD460
		public static float4 asin(float4 x); // 0x0000000184DAD4F0-0x0000000184DAD550
		public static double asin(double x); // 0x000000018B24C3D8-0x000000018B24C428
		public static double2 asin(double2 x); // 0x0000000184DAD4B0-0x0000000184DAD4F0
		public static double3 asin(double3 x); // 0x0000000184DAD460-0x0000000184DAD4B0
		public static double4 asin(double4 x); // 0x0000000184DAD3B0-0x0000000184DAD410
		public static float floor(float x); // 0x000000018B252FA8-0x000000018B253000
		public static float2 floor(float2 x); // 0x0000000184DAFBC0-0x0000000184DAFC00
		public static float3 floor(float3 x); // 0x000000018411D130-0x000000018411D180
		public static float4 floor(float4 x); // 0x0000000184DAFA70-0x0000000184DAFAD0
		public static double floor(double x); // 0x000000018B253000-0x000000018B253050
		public static double2 floor(double2 x); // 0x0000000184DAFB80-0x0000000184DAFBC0
		public static double3 floor(double3 x); // 0x0000000184DAFAD0-0x0000000184DAFB20
		public static double4 floor(double4 x); // 0x0000000184DAFB20-0x0000000184DAFB80
		public static float ceil(float x); // 0x000000018B24CA7C-0x000000018B24CAD4
		public static float2 ceil(float2 x); // 0x0000000184DAD930-0x0000000184DAD970
		public static float3 ceil(float3 x); // 0x0000000184DADA70-0x0000000184DADAC0
		public static float4 ceil(float4 x); // 0x0000000184DAD9B0-0x0000000184DADA10
		public static double ceil(double x); // 0x000000018B24CAD4-0x000000018B24CB24
		public static double2 ceil(double2 x); // 0x0000000184DAD970-0x0000000184DAD9B0
		public static double3 ceil(double3 x); // 0x0000000184DAD8E0-0x0000000184DAD930
		public static double4 ceil(double4 x); // 0x0000000184DADA10-0x0000000184DADA70
		public static float round(float x); // 0x000000018B270A54-0x000000018B270AAC
		public static float2 round(float2 x); // 0x000000018B270B94-0x000000018B270BD0
		public static float3 round(float3 x); // 0x0000000185F31D10-0x0000000185F31E7C
		public static float4 round(float4 x); // 0x0000000185F31E7C-0x0000000185F31F40
		public static double round(double x); // 0x000000018B270A04-0x000000018B270A54
		public static double2 round(double2 x); // 0x0000000185F31CC8-0x0000000185F31D10
		public static double3 round(double3 x); // 0x000000018B270AAC-0x000000018B270B10
		public static double4 round(double4 x); // 0x000000018B270B10-0x000000018B270B94
		public static float trunc(float x); // 0x000000018B2752E8-0x000000018B275344
		public static float2 trunc(float2 x); // 0x000000018B2752AC-0x000000018B2752E8
		public static float3 trunc(float3 x); // 0x0000000185F39770-0x0000000185F39858
		public static float4 trunc(float4 x); // 0x0000000185F39618-0x0000000185F39770
		public static double trunc(double x); // 0x000000018B275174-0x000000018B2751C4
		public static double2 trunc(double2 x); // 0x0000000185F39858-0x0000000185F39B9C
		public static double3 trunc(double3 x); // 0x000000018B2751C4-0x000000018B275228
		public static double4 trunc(double4 x); // 0x000000018B275228-0x000000018B2752AC
		public static float frac(float x); // 0x0000000184DA2CA0-0x0000000184DA2CD0
		public static float2 frac(float2 x); // 0x000000018B253168-0x000000018B253198
		public static float3 frac(float3 x); // 0x0000000185F0E4F0-0x0000000185F0E7C0
		public static float4 frac(float4 x); // 0x000000018B253104-0x000000018B253168
		public static double frac(double x); // 0x0000000184DB0010-0x0000000184DB0040
		public static double2 frac(double2 x); // 0x000000018B25322C-0x000000018B253290
		public static double3 frac(double3 x); // 0x000000018B253198-0x000000018B25322C
		public static double4 frac(double4 x); // 0x000000018B253290-0x000000018B25331C
		public static float rcp(float x); // 0x000000018B26EE6C-0x000000018B26EE7C
		public static float2 rcp(float2 x); // 0x000000018B26ED2C-0x000000018B26ED54
		public static float3 rcp(float3 x); // 0x000000018B26ED98-0x000000018B26EDD8
		public static float4 rcp(float4 x); // 0x000000018B26EE00-0x000000018B26EE6C
		public static double rcp(double x); // 0x000000018B26ED1C-0x000000018B26ED2C
		public static double2 rcp(double2 x); // 0x000000018B26EDD8-0x000000018B26EE00
		public static double3 rcp(double3 x); // 0x000000018B26ECE0-0x000000018B26ED1C
		public static double4 rcp(double4 x); // 0x000000018B26ED54-0x000000018B26ED98
		public static int sign(int x); // 0x000000018B27260C-0x000000018B27261C
		public static int2 sign(int2 x); // 0x000000018B272754-0x000000018B272788
		public static int3 sign(int3 x); // 0x000000018B272808-0x000000018B272850
		public static int4 sign(int4 x); // 0x000000018B2726F4-0x000000018B272754
		public static float sign(float x); // 0x0000000185F355F4-0x0000000185F35CBC
		public static float2 sign(float2 x); // 0x000000018B272654-0x000000018B272684
		public static float3 sign(float3 x); // 0x000000018B2727D0-0x000000018B272808
		public static float4 sign(float4 x); // 0x000000018B2726AC-0x000000018B2726F4
		public static double sign(double x); // 0x0000000185F355BC-0x0000000185F355F4
		public static double2 sign(double2 x); // 0x000000018B272684-0x000000018B2726AC
		public static double3 sign(double3 x); // 0x000000018B27261C-0x000000018B272654
		public static double4 sign(double4 x); // 0x000000018B272788-0x000000018B2727D0
		public static float pow(float x, float y); // 0x000000018B26E22C-0x000000018B26E290
		public static float2 pow(float2 x, float2 y); // 0x000000018B26E290-0x000000018B26E2DC
		public static float3 pow(float3 x, float3 y); // 0x0000000185F2F240-0x0000000185F2F4D8
		public static float4 pow(float4 x, float4 y); // 0x0000000185F2F538-0x0000000185F2F67C
		public static double pow(double x, double y); // 0x000000018B26E2DC-0x000000018B26E33C
		public static double2 pow(double2 x, double2 y); // 0x0000000185F2F4D8-0x0000000185F2F538
		public static double3 pow(double3 x, double3 y); // 0x000000018B26E1AC-0x000000018B26E22C
		public static double4 pow(double4 x, double4 y); // 0x000000018B26E33C-0x000000018B26E3E0
		public static float exp(float x); // 0x000000018B24FD18-0x000000018B24FD70
		public static float2 exp(float2 x); // 0x0000000184DAF330-0x0000000184DAF370
		public static float3 exp(float3 x); // 0x0000000184DAF460-0x0000000184DAF4B0
		public static float4 exp(float4 x); // 0x0000000184DAF2D0-0x0000000184DAF330
		public static double exp(double x); // 0x000000018B24FCC8-0x000000018B24FD18
		public static double2 exp(double2 x); // 0x0000000184DAF370-0x0000000184DAF3B0
		public static double3 exp(double3 x); // 0x0000000184DAF3B0-0x0000000184DAF400
		public static double4 exp(double4 x); // 0x0000000184DAF400-0x0000000184DAF460
		public static float exp2(float x); // 0x000000018B24FAEC-0x000000018B24FB4C
		public static float2 exp2(float2 x); // 0x000000018B24FC8C-0x000000018B24FCC8
		public static float3 exp2(float3 x); // 0x0000000185F0BF44-0x0000000185F0C060
		public static float4 exp2(float4 x); // 0x0000000185F0C1F0-0x0000000185F0C274
		public static double exp2(double x); // 0x000000018B24FB4C-0x000000018B24FBA4
		public static double2 exp2(double2 x); // 0x0000000185F0C060-0x0000000185F0C1F0
		public static double3 exp2(double3 x); // 0x000000018B24FBA4-0x000000018B24FC08
		public static double4 exp2(double4 x); // 0x000000018B24FC08-0x000000018B24FC8C
		public static float exp10(float x); // 0x000000018B24FA8C-0x000000018B24FAEC
		public static float2 exp10(float2 x); // 0x000000018B24F910-0x000000018B24F94C
		public static float3 exp10(float3 x); // 0x0000000185F0BC14-0x0000000185F0BCB8
		public static float4 exp10(float4 x); // 0x0000000185F0BD84-0x0000000185F0BF44
		public static double exp10(double x); // 0x000000018B24F9D0-0x000000018B24FA28
		public static double2 exp10(double2 x); // 0x0000000185F0BCB8-0x0000000185F0BD84
		public static double3 exp10(double3 x); // 0x000000018B24FA28-0x000000018B24FA8C
		public static double4 exp10(double4 x); // 0x000000018B24F94C-0x000000018B24F9D0
		public static float log(float x); // 0x000000018B25DFD0-0x000000018B25E028
		public static float2 log(float2 x); // 0x0000000184DB0860-0x0000000184DB08A0
		public static float3 log(float3 x); // 0x0000000184DB08F0-0x0000000184DB0940
		public static float4 log(float4 x); // 0x0000000184DB0800-0x0000000184DB0860
		public static double log(double x); // 0x000000018B25DF80-0x000000018B25DFD0
		public static double2 log(double2 x); // 0x0000000184DB07C0-0x0000000184DB0800
		public static double3 log(double3 x); // 0x0000000184DB08A0-0x0000000184DB08F0
		public static double4 log(double4 x); // 0x0000000184DB0940-0x0000000184DB09A0
		public static float log2(float x); // 0x000000018B25DDA4-0x000000018B25DE00
		public static float2 log2(float2 x); // 0x000000018B25DE00-0x000000018B25DE3C
		public static float3 log2(float3 x); // 0x0000000185F17BB4-0x0000000185F17C18
		public static float4 log2(float4 x); // 0x0000000185F17C18-0x0000000185F17EAC
		public static double log2(double x); // 0x000000018B25DE3C-0x000000018B25DE98
		public static double2 log2(double2 x); // 0x0000000185F17B10-0x0000000185F17BB4
		public static double3 log2(double3 x); // 0x000000018B25DE98-0x000000018B25DEFC
		public static double4 log2(double4 x); // 0x000000018B25DEFC-0x000000018B25DF80
		public static float log10(float x); // 0x000000018B25DCFC-0x000000018B25DD54
		public static float2 log10(float2 x); // 0x0000000184DB0730-0x0000000184DB0770
		public static float3 log10(float3 x); // 0x0000000184DB0770-0x0000000184DB07C0
		public static float4 log10(float4 x); // 0x0000000184DB0680-0x0000000184DB06E0
		public static double log10(double x); // 0x000000018B25DD54-0x000000018B25DDA4
		public static double2 log10(double2 x); // 0x0000000184DB05E0-0x0000000184DB0620
		public static double3 log10(double3 x); // 0x0000000184DB06E0-0x0000000184DB0730
		public static double4 log10(double4 x); // 0x0000000184DB0620-0x0000000184DB0680
		public static float fmod(float x, float y); // 0x0000000184D88690-0x0000000184D886A0
		public static float2 fmod(float2 x, float2 y); // 0x0000000184DAFCE0-0x0000000184DAFD30
		public static float3 fmod(float3 x, float3 y); // 0x0000000184DAFC00-0x0000000184DAFC70
		public static float4 fmod(float4 x, float4 y); // 0x0000000184DAFD30-0x0000000184DAFDB0
		public static double fmod(double x, double y); // 0x0000000184DAFE90-0x0000000184DAFEA0
		public static double2 fmod(double2 x, double2 y); // 0x0000000184DAFE30-0x0000000184DAFE90
		public static double3 fmod(double3 x, double3 y); // 0x0000000184DAFC70-0x0000000184DAFCE0
		public static double4 fmod(double4 x, double4 y); // 0x0000000184DAFDB0-0x0000000184DAFE30
		public static float modf(float x, out float i); // 0x000000018B25ED5C-0x000000018B25ED88
		public static float2 modf(float2 x, out float2 i); // 0x000000018B25EC14-0x000000018B25EC4C
		public static float3 modf(float3 x, out float3 i); // 0x0000000185F189DC-0x0000000185F2ED38
		public static float4 modf(float4 x, out float4 i); // 0x000000018B25EB74-0x000000018B25EBE8
		public static double modf(double x, out double i); // 0x000000018B25EBE8-0x000000018B25EC14
		public static double2 modf(double2 x, out double2 i); // 0x000000018B25ECE8-0x000000018B25ED5C
		public static double3 modf(double3 x, out double3 i); // 0x000000018B25EAD0-0x000000018B25EB74
		public static double4 modf(double4 x, out double4 i); // 0x000000018B25EC4C-0x000000018B25ECE8
		public static float sqrt(float x); // 0x000000018B273550-0x000000018B2735A0
		public static float2 sqrt(float2 x); // 0x0000000184DB1E00-0x0000000184DB1E70
		public static float3 sqrt(float3 x); // 0x0000000184DB20F0-0x0000000184DB2190
		public static float4 sqrt(float4 x); // 0x0000000184DB1E70-0x0000000184DB1F30
		public static double sqrt(double x); // 0x000000018B273508-0x000000018B273550
		public static double2 sqrt(double2 x); // 0x0000000184DB1F30-0x0000000184DB1FA0
		public static double3 sqrt(double3 x); // 0x0000000184DB2060-0x0000000184DB20F0
		public static double4 sqrt(double4 x); // 0x0000000184DB1FA0-0x0000000184DB2060
		public static float rsqrt(float x); // 0x000000018B270CB8-0x000000018B270CE8
		public static float2 rsqrt(float2 x); // 0x000000018B270D6C-0x000000018B270DA0
		public static float3 rsqrt(float3 x); // 0x0000000185F31F40-0x0000000185F3215C
		public static float4 rsqrt(float4 x); // 0x000000018B270CE8-0x000000018B270D6C
		public static double rsqrt(double x); // 0x000000018B270DA0-0x000000018B270DD0
		public static double2 rsqrt(double2 x); // 0x000000018B270DD0-0x000000018B270E18
		public static double3 rsqrt(double3 x); // 0x000000018B270BD0-0x000000018B270C48
		public static double4 rsqrt(double4 x); // 0x000000018B270C48-0x000000018B270CB8
		public static float2 normalize(float2 x); // 0x000000018B26D990-0x000000018B26D9F8
		public static float3 normalize(float3 x); // 0x000000018B26D9F8-0x000000018B26DA6C
		public static float4 normalize(float4 x); // 0x000000018B26D8B8-0x000000018B26D914
		public static double2 normalize(double2 x); // 0x0000000185F2ED38-0x0000000185F2F020
		public static double3 normalize(double3 x); // 0x000000018B26D838-0x000000018B26D8B8
		public static double4 normalize(double4 x); // 0x000000018B26D914-0x000000018B26D990
		public static float2 normalizesafe(float2 x, float2 defaultvalue = default); // 0x000000018B26DB1C-0x000000018B26DBA4
		public static float3 normalizesafe(float3 x, float3 defaultvalue = default); // 0x0000000185F2F020-0x0000000185F2F0C0
		public static float4 normalizesafe(float4 x, float4 defaultvalue = default); // 0x000000018B26DBA4-0x000000018B26DC30
		public static double2 normalizesafe(double2 x, double2 defaultvalue = default); // 0x0000000185F2F0C0-0x0000000185F2F240
		public static double3 normalizesafe(double3 x, double3 defaultvalue = default); // 0x000000018B26DCF0-0x000000018B26DDDC
		public static double4 normalizesafe(double4 x, double4 defaultvalue = default); // 0x000000018B26DA6C-0x000000018B26DB1C
		public static float length(float x); // 0x0000000184DAD080-0x0000000184DAD090
		public static float length(float2 x); // 0x0000000184D8B6B0-0x0000000184D8B6F0
		public static float length(float3 x); // 0x000000018B25D5CC-0x000000018B25D604
		public static float length(float4 x); // 0x000000018B25D670-0x000000018B25D6AC
		public static double length(double x); // 0x0000000184DAD120-0x0000000184DAD140
		public static double length(double2 x); // 0x0000000184DB0560-0x0000000184DB05A0
		public static double length(double3 x); // 0x000000018B25D638-0x000000018B25D670
		public static double length(double4 x); // 0x000000018B25D604-0x000000018B25D638
		public static float lengthsq(float x); // 0x0000000184D886E0-0x0000000184D886F0
		public static float lengthsq(float2 x); // 0x0000000184D8B690-0x0000000184D8B6B0
		public static float lengthsq(float3 x); // 0x000000018B25D70C-0x000000018B25D740
		public static float lengthsq(float4 x); // 0x000000018B25D6AC-0x000000018B25D6D4
		public static double lengthsq(double x); // 0x0000000184DB05C0-0x0000000184DB05D0
		public static double lengthsq(double2 x); // 0x0000000184DB05A0-0x0000000184DB05C0
		public static double lengthsq(double3 x); // 0x000000018B25D6D4-0x000000018B25D70C
		public static double lengthsq(double4 x); // 0x000000018B25D740-0x000000018B25D774
		public static float distance(float x, float y); // 0x0000000184DAEA10-0x0000000184DAEA30
		public static float distance(float2 x, float2 y); // 0x000000018B24E498-0x000000018B24E4D4
		public static float distance(float3 x, float3 y); // 0x000000018B24E324-0x000000018B24E38C
		public static float distance(float4 x, float4 y); // 0x000000018B24E3F8-0x000000018B24E458
		public static double distance(double x, double y); // 0x0000000184DAEA30-0x0000000184DAEA50
		public static double distance(double2 x, double2 y); // 0x000000018B24E458-0x000000018B24E498
		public static double distance(double3 x, double3 y); // 0x000000018B24E2B0-0x000000018B24E324
		public static double distance(double4 x, double4 y); // 0x000000018B24E38C-0x000000018B24E3F8
		public static float distancesq(float x, float y); // 0x0000000184DAEA50-0x0000000184DAEA60
		public static float distancesq(float2 x, float2 y); // 0x000000018B24E4D4-0x000000018B24E50C
		public static float distancesq(float3 x, float3 y); // 0x000000018B24E630-0x000000018B24E694
		public static float distancesq(float4 x, float4 y); // 0x000000018B24E50C-0x000000018B24E558
		public static double distancesq(double x, double y); // 0x0000000184DAEA60-0x0000000184DAEA70
		public static double distancesq(double2 x, double2 y); // 0x000000018B24E694-0x000000018B24E6D4
		public static double distancesq(double3 x, double3 y); // 0x000000018B24E5C0-0x000000018B24E630
		public static double distancesq(double4 x, double4 y); // 0x000000018B24E558-0x000000018B24E5C0
		public static float3 cross(float3 x, float3 y); // 0x000000018B24DE8C-0x000000018B24DF74
		public static double3 cross(double3 x, double3 y); // 0x000000018B24DF74-0x000000018B24E08C
		public static float smoothstep(float xMin, float xMax, float x); // 0x000000018B273258-0x000000018B2732A4
		public static float2 smoothstep(float2 xMin, float2 xMax, float2 x); // 0x000000018B2732A4-0x000000018B273374
		public static float3 smoothstep(float3 xMin, float3 xMax, float3 x); // 0x0000000185F35CBC-0x0000000185F36644
		public static float4 smoothstep(float4 xMin, float4 xMax, float4 x); // 0x000000018B2733C0-0x000000018B273508
		public static double smoothstep(double xMin, double xMax, double x); // 0x000000018B273374-0x000000018B2733C0
		public static double2 smoothstep(double2 xMin, double2 xMax, double2 x); // 0x000000018B272DE8-0x000000018B272EF8
		public static double3 smoothstep(double3 xMin, double3 xMax, double3 x); // 0x000000018B273098-0x000000018B273258
		public static double4 smoothstep(double4 xMin, double4 xMax, double4 x); // 0x000000018B272EF8-0x000000018B273098
		public static bool any(bool2 x); // 0x000000018B24C25C-0x000000018B24C26C
		public static bool any(bool3 x); // 0x000000018B24C318-0x000000018B24C32C
		public static bool any(bool4 x); // 0x0000000185F08324-0x0000000185F08570
		public static bool any(int2 x); // 0x000000018B24C248-0x000000018B24C25C
		public static bool any(int3 x); // 0x000000018B24C26C-0x000000018B24C284
		public static bool any(int4 x); // 0x000000018B24C22C-0x000000018B24C248
		public static bool any(uint2 x); // 0x000000018B24C248-0x000000018B24C25C
		public static bool any(uint3 x); // 0x000000018B24C26C-0x000000018B24C284
		public static bool any(uint4 x); // 0x000000018B24C22C-0x000000018B24C248
		public static bool any(float2 x); // 0x000000018B24C32C-0x000000018B24C354
		public static bool any(float3 x); // 0x000000018B24C2A8-0x000000018B24C2D4
		public static bool any(float4 x); // 0x000000018B24C354-0x000000018B24C38C
		public static bool any(double2 x); // 0x000000018B24C284-0x000000018B24C2A8
		public static bool any(double3 x); // 0x000000018B24C38C-0x000000018B24C3D8
		public static bool any(double4 x); // 0x000000018B24C2D4-0x000000018B24C318
		public static bool all(bool2 x); // 0x000000018B24C01C-0x000000018B24C02C
		public static bool all(bool3 x); // 0x000000018B24C14C-0x000000018B24C160
		public static bool all(bool4 x); // 0x0000000185F08180-0x0000000185F081A0
		public static bool all(int2 x); // 0x000000018B24C02C-0x000000018B24C040
		public static bool all(int3 x); // 0x0000000185F081A0-0x0000000185F081B8
		public static bool all(int4 x); // 0x000000018B24C0D0-0x000000018B24C0EC
		public static bool all(uint2 x); // 0x000000018B24C02C-0x000000018B24C040
		public static bool all(uint3 x); // 0x0000000185F081A0-0x0000000185F081B8
		public static bool all(uint4 x); // 0x000000018B24C0D0-0x000000018B24C0EC
		public static bool all(float2 x); // 0x000000018B24C0EC-0x000000018B24C114
		public static bool all(float3 x); // 0x0000000185F081B8-0x0000000185F08324
		public static bool all(float4 x); // 0x000000018B24C114-0x000000018B24C14C
		public static bool all(double2 x); // 0x000000018B24C160-0x000000018B24C184
		public static bool all(double3 x); // 0x000000018B24C084-0x000000018B24C0D0
		public static bool all(double4 x); // 0x000000018B24C040-0x000000018B24C084
		public static int select(int falseValue, int trueValue, bool test); // 0x000000018B27110C-0x000000018B271118
		public static int2 select(int2 falseValue, int2 trueValue, bool test); // 0x000000018B271124-0x000000018B271130
		public static int3 select(int3 falseValue, int3 trueValue, bool test); // 0x000000018B271148-0x000000018B27116C
		public static int4 select(int4 falseValue, int4 trueValue, bool test); // 0x000000018B271130-0x000000018B271148
		public static int2 select(int2 falseValue, int2 trueValue, bool2 test); // 0x000000018B27116C-0x000000018B27119C
		public static int3 select(int3 falseValue, int3 trueValue, bool3 test); // 0x0000000185F324D0-0x0000000185F32510
		public static int4 select(int4 falseValue, int4 trueValue, bool4 test); // 0x0000000185F32634-0x0000000185F327BC
		public static uint select(uint falseValue, uint trueValue, bool test); // 0x000000018B27110C-0x000000018B271118
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool test); // 0x000000018B271124-0x000000018B271130
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool test); // 0x000000018B271148-0x000000018B27116C
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool test); // 0x000000018B271130-0x000000018B271148
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test); // 0x000000018B27116C-0x000000018B27119C
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool3 test); // 0x0000000185F324D0-0x0000000185F32510
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test); // 0x0000000185F32634-0x0000000185F327BC
		public static long select(long falseValue, long trueValue, bool test); // 0x000000018B271100-0x000000018B27110C
		public static ulong select(ulong falseValue, ulong trueValue, bool test); // 0x000000018B271100-0x000000018B27110C
		public static float select(float falseValue, float trueValue, bool test); // 0x000000018B271118-0x000000018B271124
		public static float2 select(float2 falseValue, float2 trueValue, bool test); // 0x000000018B271124-0x000000018B271130
		public static float3 select(float3 falseValue, float3 trueValue, bool test); // 0x000000018B271148-0x000000018B27116C
		public static float4 select(float4 falseValue, float4 trueValue, bool test); // 0x000000018B271130-0x000000018B271148
		public static float2 select(float2 falseValue, float2 trueValue, bool2 test); // 0x0000000185F32510-0x0000000185F32554
		public static float3 select(float3 falseValue, float3 trueValue, bool3 test); // 0x0000000185F32554-0x0000000185F325C8
		public static float4 select(float4 falseValue, float4 trueValue, bool4 test); // 0x0000000185F325C8-0x0000000185F32634
		public static double select(double falseValue, double trueValue, bool test); // 0x000000018B271118-0x000000018B271124
		public static double2 select(double2 falseValue, double2 trueValue, bool test); // 0x000000018B271130-0x000000018B271148
		public static double3 select(double3 falseValue, double3 trueValue, bool test); // 0x000000018B271290-0x000000018B2712B8
		public static double4 select(double4 falseValue, double4 trueValue, bool test); // 0x000000018B2712B8-0x000000018B2712DC
		public static double2 select(double2 falseValue, double2 trueValue, bool2 test); // 0x0000000185F3249C-0x0000000185F324D0
		public static double3 select(double3 falseValue, double3 trueValue, bool3 test); // 0x000000018B271210-0x000000018B271290
		public static double4 select(double4 falseValue, double4 trueValue, bool4 test); // 0x000000018B27119C-0x000000018B271210
		public static float step(float threshold, float x); // 0x000000018B273700-0x000000018B273714
		public static float2 step(float2 threshold, float2 x); // 0x000000018B273A6C-0x000000018B273ACC
		public static float3 step(float3 threshold, float3 x); // 0x000000018B27391C-0x000000018B2739C8
		public static float4 step(float4 threshold, float4 x); // 0x000000018B273728-0x000000018B2737E4
		public static double step(double threshold, double x); // 0x000000018B273714-0x000000018B273728
		public static double2 step(double2 threshold, double2 x); // 0x000000018B2738A8-0x000000018B27391C
		public static double3 step(double3 threshold, double3 x); // 0x000000018B2737E4-0x000000018B2738A8
		public static double4 step(double4 threshold, double4 x); // 0x000000018B2739C8-0x000000018B273A6C
		public static float2 reflect(float2 i, float2 n); // 0x000000018B26EE7C-0x000000018B26EED4
		public static float3 reflect(float3 i, float3 n); // 0x0000000185F301DC-0x0000000185F306B0
		public static float4 reflect(float4 i, float4 n); // 0x000000018B26F128-0x000000018B26F1BC
		public static double2 reflect(double2 i, double2 n); // 0x000000018B26F090-0x000000018B26F128
		public static double3 reflect(double3 i, double3 n); // 0x000000018B26EFAC-0x000000018B26F090
		public static double4 reflect(double4 i, double4 n); // 0x000000018B26EED4-0x000000018B26EFAC
		public static float2 refract(float2 i, float2 n, float indexOfRefraction); // 0x000000018B26F314-0x000000018B26F418
		public static float3 refract(float3 i, float3 n, float indexOfRefraction); // 0x0000000185F306B0-0x0000000185F30DA0
		public static float4 refract(float4 i, float4 n, float indexOfRefraction); // 0x000000018B26F6DC-0x000000018B26F7F8
		public static double2 refract(double2 i, double2 n, double indexOfRefraction); // 0x000000018B26F418-0x000000018B26F52C
		public static double3 refract(double3 i, double3 n, double indexOfRefraction); // 0x000000018B26F52C-0x000000018B26F6DC
		public static double4 refract(double4 i, double4 n, double indexOfRefraction); // 0x000000018B26F1BC-0x000000018B26F314
		public static float2 project(float2 a, float2 ontoB); // 0x000000018B26E3E0-0x000000018B26E42C
		public static float3 project(float3 a, float3 ontoB); // 0x0000000185F2F6F0-0x0000000185F2F9B0
		public static float4 project(float4 a, float4 ontoB); // 0x000000018B26E578-0x000000018B26E5E8
		public static float2 projectsafe(float2 a, float2 ontoB, float2 defaultValue = default); // 0x000000018B26E650-0x000000018B26E6F0
		public static float3 projectsafe(float3 a, float3 ontoB, float3 defaultValue = default); // 0x0000000185F2F9B0-0x0000000185F301DC
		public static float4 projectsafe(float4 a, float4 ontoB, float4 defaultValue = default); // 0x000000018B26E5E8-0x000000018B26E650
		public static double2 project(double2 a, double2 ontoB); // 0x0000000185F2F67C-0x0000000185F2F6F0
		public static double3 project(double3 a, double3 ontoB); // 0x000000018B26E4CC-0x000000018B26E578
		public static double4 project(double4 a, double4 ontoB); // 0x000000018B26E42C-0x000000018B26E4CC
		public static double2 projectsafe(double2 a, double2 ontoB, double2 defaultValue = default); // 0x000000018B26E78C-0x000000018B26E7F0
		public static double3 projectsafe(double3 a, double3 ontoB, double3 defaultValue = default); // 0x000000018B26E7F0-0x000000018B26E8D4
		public static double4 projectsafe(double4 a, double4 ontoB, double4 defaultValue = default); // 0x000000018B26E6F0-0x000000018B26E78C
		public static float2 faceforward(float2 n, float2 i, float2 ng); // 0x000000018B250B80-0x000000018B250BD8
		public static float3 faceforward(float3 n, float3 i, float3 ng); // 0x0000000185F0D468-0x0000000185F0D588
		public static float4 faceforward(float4 n, float4 i, float4 ng); // 0x000000018B250AA4-0x000000018B250B0C
		public static double2 faceforward(double2 n, double2 i, double2 ng); // 0x000000018B250B0C-0x000000018B250B80
		public static double3 faceforward(double3 n, double3 i, double3 ng); // 0x000000018B250BD8-0x000000018B250C9C
		public static double4 faceforward(double4 n, double4 i, double4 ng); // 0x000000018B250C9C-0x000000018B250D30
		public static void sincos(float x, out float s, out float c); // 0x0000000184DB1BE0-0x0000000184DB1C20
		public static void sincos(float2 x, out float2 s, out float2 c); // 0x000000018B272B5C-0x000000018B272BA0
		public static void sincos(float3 x, out float3 s, out float3 c); // 0x000000018B27297C-0x000000018B272A00
		public static void sincos(float4 x, out float4 s, out float4 c); // 0x000000018B272A00-0x000000018B272A68
		public static void sincos(double x, out double s, out double c); // 0x0000000184DB1BA0-0x0000000184DB1BE0
		public static void sincos(double2 x, out double2 s, out double2 c); // 0x000000018B272A68-0x000000018B272AD0
		public static void sincos(double3 x, out double3 s, out double3 c); // 0x000000018B272AD0-0x000000018B272B5C
		public static void sincos(double4 x, out double4 s, out double4 c); // 0x000000018B2728F8-0x000000018B27297C
		public static int countbits(int x); // 0x0000000184DADFA0-0x0000000184DADFE0
		public static int2 countbits(int2 x); // 0x000000018B24DB28-0x000000018B24DB40
		public static int3 countbits(int3 x); // 0x000000018B24DE2C-0x000000018B24DE8C
		public static int4 countbits(int4 x); // 0x000000018B24DDCC-0x000000018B24DE2C
		public static int countbits(uint x); // 0x0000000184DADFA0-0x0000000184DADFE0
		public static int2 countbits(uint2 x); // 0x000000018B24DB40-0x000000018B24DC3C
		public static int3 countbits(uint3 x); // 0x0000000185F0A204-0x0000000185F0A954
		public static int4 countbits(uint4 x); // 0x000000018B24DC3C-0x000000018B24DDCC
		public static int countbits(ulong x); // 0x0000000184DADF40-0x0000000184DADFA0
		public static int countbits(long x); // 0x0000000184DADF40-0x0000000184DADFA0
		public static int lzcnt(int x); // 0x000000018B25E12C-0x000000018B25E134
		public static int2 lzcnt(int2 x); // 0x000000018B25E0F8-0x000000018B25E124
		public static int3 lzcnt(int3 x); // 0x000000018B25E028-0x000000018B25E068
		public static int4 lzcnt(int4 x); // 0x000000018B25E0AC-0x000000018B25E0F8
		public static int lzcnt(uint x); // 0x000000018B25E068-0x000000018B25E0AC
		public static int2 lzcnt(uint2 x); // 0x000000018B25E0F8-0x000000018B25E124
		public static int3 lzcnt(uint3 x); // 0x000000018B25E028-0x000000018B25E068
		public static int4 lzcnt(uint4 x); // 0x000000018B25E0AC-0x000000018B25E0F8
		public static int lzcnt(long x); // 0x000000018B25E124-0x000000018B25E12C
		public static int lzcnt(ulong x); // 0x000000018B25E134-0x000000018B25E18C
		public static int tzcnt(int x); // 0x000000018B275450-0x000000018B275458
		public static int2 tzcnt(int2 x); // 0x000000018B2753D0-0x000000018B2753FC
		public static int3 tzcnt(int3 x); // 0x000000018B27538C-0x000000018B2753D0
		public static int4 tzcnt(int4 x); // 0x000000018B2753FC-0x000000018B275450
		public static int tzcnt(uint x); // 0x000000018B275344-0x000000018B27538C
		public static int2 tzcnt(uint2 x); // 0x000000018B2753D0-0x000000018B2753FC
		public static int3 tzcnt(uint3 x); // 0x000000018B27538C-0x000000018B2753D0
		public static int4 tzcnt(uint4 x); // 0x000000018B2753FC-0x000000018B275450
		public static int tzcnt(long x); // 0x000000018B275458-0x000000018B275460
		public static int tzcnt(ulong x); // 0x000000018B275460-0x000000018B2754C4
		public static int reversebits(int x); // 0x000000018B270078-0x000000018B270080
		public static int2 reversebits(int2 x); // 0x000000018B270080-0x000000018B2700B0
		public static int3 reversebits(int3 x); // 0x000000018B2700B0-0x000000018B270130
		public static int4 reversebits(int4 x); // 0x000000018B26FE50-0x000000018B26FEC4
		public static uint reversebits(uint x); // 0x0000000184DB1910-0x0000000184DB1950
		public static uint2 reversebits(uint2 x); // 0x000000018B26FEC4-0x000000018B270070
		public static uint3 reversebits(uint3 x); // 0x0000000185F3111C-0x0000000185F316C8
		public static uint4 reversebits(uint4 x); // 0x000000018B26FB98-0x000000018B26FE50
		public static long reversebits(long x); // 0x000000018B270070-0x000000018B270078
		public static ulong reversebits(ulong x); // 0x0000000184DB1950-0x0000000184DB19B0
		public static int rol(int x, int n); // 0x0000000184D882E0-0x0000000184D88300
		public static int2 rol(int2 x, int n); // 0x000000018B2702D0-0x000000018B270340
		public static int3 rol(int3 x, int n); // 0x000000018B270164-0x000000018B2701E4
		public static int4 rol(int4 x, int n); // 0x000000018B2701E4-0x000000018B270258
		public static uint rol(uint x, int n); // 0x0000000184D882E0-0x0000000184D88300
		public static uint2 rol(uint2 x, int n); // 0x000000018B270130-0x000000018B270164
		public static uint3 rol(uint3 x, int n); // 0x0000000185F316C8-0x0000000185F3175C
		public static uint4 rol(uint4 x, int n); // 0x000000018B270258-0x000000018B2702D0
		public static long rol(long x, int n); // 0x0000000184DAB5C0-0x0000000184DAB5E0
		public static ulong rol(ulong x, int n); // 0x0000000184DAB5C0-0x0000000184DAB5E0
		public static int ror(int x, int n); // 0x0000000184DA4210-0x0000000184DA4230
		public static int2 ror(int2 x, int n); // 0x000000018B2703E8-0x000000018B270458
		public static int3 ror(int3 x, int n); // 0x000000018B270458-0x000000018B2704D8
		public static int4 ror(int4 x, int n); // 0x000000018B270374-0x000000018B2703E8
		public static uint ror(uint x, int n); // 0x0000000184DA4210-0x0000000184DA4230
		public static uint2 ror(uint2 x, int n); // 0x000000018B270340-0x000000018B270374
		public static uint3 ror(uint3 x, int n); // 0x0000000185F3175C-0x0000000185F31CC8
		public static uint4 ror(uint4 x, int n); // 0x000000018B2704D8-0x000000018B270550
		public static long ror(long x, int n); // 0x0000000184DA4260-0x0000000184DA4280
		public static ulong ror(ulong x, int n); // 0x0000000184DA4260-0x0000000184DA4280
		public static int ceilpow2(int x); // 0x00000001837F6550-0x00000001837F6580
		public static int2 ceilpow2(int2 x); // 0x000000018B24CBD0-0x000000018B24CC88
		public static int3 ceilpow2(int3 x); // 0x0000000185F09228-0x0000000185F0975C
		public static int4 ceilpow2(int4 x); // 0x000000018B24CED0-0x000000018B24D060
		public static uint ceilpow2(uint x); // 0x0000000184D89420-0x0000000184D89450
		public static uint2 ceilpow2(uint2 x); // 0x000000018B24CE18-0x000000018B24CED0
		public static uint3 ceilpow2(uint3 x); // 0x0000000185F09014-0x0000000185F09228
		public static uint4 ceilpow2(uint4 x); // 0x000000018B24CC88-0x000000018B24CE18
		public static long ceilpow2(long x); // 0x0000000184DADB10-0x0000000184DADB60
		public static ulong ceilpow2(ulong x); // 0x0000000184DADAC0-0x0000000184DADB10
		public static int ceillog2(int x); // 0x0000000185F08FF8-0x0000000185F09014
		public static int2 ceillog2(int2 x); // 0x000000018B24CBA4-0x000000018B24CBD0
		public static int3 ceillog2(int3 x); // 0x000000018B24CB24-0x000000018B24CB5C
		public static int4 ceillog2(int4 x); // 0x000000018B24CB5C-0x000000018B24CBA4
		public static int ceillog2(uint x); // 0x0000000185F08FF8-0x0000000185F09014
		public static int2 ceillog2(uint2 x); // 0x000000018B24CBA4-0x000000018B24CBD0
		public static int3 ceillog2(uint3 x); // 0x000000018B24CB24-0x000000018B24CB5C
		public static int4 ceillog2(uint4 x); // 0x000000018B24CB5C-0x000000018B24CBA4
		public static int floorlog2(int x); // 0x0000000185F0E0A0-0x0000000185F0E4F0
		public static int2 floorlog2(int2 x); // 0x000000018B2530D0-0x000000018B253104
		public static int3 floorlog2(int3 x); // 0x000000018B253098-0x000000018B2530D0
		public static int4 floorlog2(int4 x); // 0x000000018B253050-0x000000018B253098
		public static int floorlog2(uint x); // 0x0000000185F0E0A0-0x0000000185F0E4F0
		public static int2 floorlog2(uint2 x); // 0x000000018B2530D0-0x000000018B253104
		public static int3 floorlog2(uint3 x); // 0x000000018B253098-0x000000018B2530D0
		public static int4 floorlog2(uint4 x); // 0x000000018B253050-0x000000018B253098
		public static float radians(float x); // 0x0000000184DB18F0-0x0000000184DB1900
		public static float2 radians(float2 x); // 0x000000018B26EC04-0x000000018B26EC14
		public static float3 radians(float3 x); // 0x0000000185390E8C-0x0000000185390ED4
		public static float4 radians(float4 x); // 0x000000018B26EBCC-0x000000018B26EC04
		public static double radians(double x); // 0x0000000184DB1900-0x0000000184DB1910
		public static double2 radians(double2 x); // 0x000000018B26EC14-0x000000018B26EC4C
		public static double3 radians(double3 x); // 0x000000018B26EC4C-0x000000018B26EC98
		public static double4 radians(double4 x); // 0x000000018B26EC98-0x000000018B26ECE0
		public static float degrees(float x); // 0x0000000184DAE090-0x0000000184DAE0A0
		public static float2 degrees(float2 x); // 0x000000018B24E230-0x000000018B24E240
		public static float3 degrees(float3 x); // 0x0000000185F0A954-0x0000000185F0AEA4
		public static float4 degrees(float4 x); // 0x000000018B24E240-0x000000018B24E278
		public static double degrees(double x); // 0x0000000184DAE0A0-0x0000000184DAE0B0
		public static double2 degrees(double2 x); // 0x000000018B24E278-0x000000018B24E2B0
		public static double3 degrees(double3 x); // 0x000000018B24E19C-0x000000018B24E1E8
		public static double4 degrees(double4 x); // 0x000000018B24E1E8-0x000000018B24E230
		public static int cmin(int2 x); // 0x000000018B24D91C-0x000000018B24D930
		public static int cmin(int3 x); // 0x000000018B24D7F4-0x000000018B24D808
		public static int cmin(int4 x); // 0x000000018B24D874-0x000000018B24D890
		public static uint cmin(uint2 x); // 0x000000018B24D8B0-0x000000018B24D8C4
		public static uint cmin(uint3 x); // 0x000000018B24D968-0x000000018B24D97C
		public static uint cmin(uint4 x); // 0x000000018B24D808-0x000000018B24D824
		public static float cmin(float2 x); // 0x000000018B24D8F8-0x000000018B24D91C
		public static float cmin(float3 x); // 0x000000018B24D8C4-0x000000018B24D8F8
		public static float cmin(float4 x); // 0x0000000185F09F28-0x0000000185F0A204
		public static double cmin(double2 x); // 0x000000018B24D890-0x000000018B24D8B0
		public static double cmin(double3 x); // 0x000000018B24D930-0x000000018B24D968
		public static double cmin(double4 x); // 0x000000018B24D824-0x000000018B24D874
		public static int cmax(int2 x); // 0x000000018B24D774-0x000000018B24D788
		public static int cmax(int3 x); // 0x000000018B24D7A8-0x000000018B24D7BC
		public static int cmax(int4 x); // 0x000000018B24D6D8-0x000000018B24D6F4
		public static uint cmax(uint2 x); // 0x000000018B24D6A0-0x000000018B24D6B4
		public static uint cmax(uint3 x); // 0x000000018B24D760-0x000000018B24D774
		public static uint cmax(uint4 x); // 0x000000018B24D6F4-0x000000018B24D710
		public static float cmax(float2 x); // 0x000000018B24D6B4-0x000000018B24D6D8
		public static float cmax(float3 x); // 0x000000018B24D66C-0x000000018B24D6A0
		public static float cmax(float4 x); // 0x0000000185F09DB8-0x0000000185F09F28
		public static double cmax(double2 x); // 0x000000018B24D788-0x000000018B24D7A8
		public static double cmax(double3 x); // 0x000000018B24D7BC-0x000000018B24D7F4
		public static double cmax(double4 x); // 0x000000018B24D710-0x000000018B24D760
		public static int csum(int2 x); // 0x0000000184DAE000-0x0000000184DAE010
		public static int csum(int3 x); // 0x0000000184DAE050-0x0000000184DAE060
		public static int csum(int4 x); // 0x0000000184D8CAC0-0x0000000184D8CAD0
		public static uint csum(uint2 x); // 0x0000000184DAE000-0x0000000184DAE010
		public static uint csum(uint3 x); // 0x0000000184DAE050-0x0000000184DAE060
		public static uint csum(uint4 x); // 0x0000000184D8CAC0-0x0000000184D8CAD0
		public static float csum(float2 x); // 0x0000000184DAE060-0x0000000184DAE080
		public static float csum(float3 x); // 0x0000000184DAE080-0x0000000184DAE090
		public static float csum(float4 x); // 0x0000000184DADFE0-0x0000000184DAE000
		public static double csum(double2 x); // 0x0000000184DAE020-0x0000000184DAE030
		public static double csum(double3 x); // 0x0000000184DAE010-0x0000000184DAE020
		public static double csum(double4 x); // 0x0000000184DAE030-0x0000000184DAE050
		public static float square(float x); // 0x0000000184D886E0-0x0000000184D886F0
		public static float2 square(float2 x); // 0x000000018B2736F8-0x000000018B273700
		public static float3 square(float3 x); // 0x0000000185F36644-0x0000000185F36694
		public static float4 square(float4 x); // 0x000000018B273628-0x000000018B273660
		public static double square(double x); // 0x0000000184DB05C0-0x0000000184DB05D0
		public static double2 square(double2 x); // 0x000000018B2735F0-0x000000018B273628
		public static double3 square(double3 x); // 0x000000018B273668-0x000000018B2736C0
		public static double4 square(double4 x); // 0x000000018B2735A0-0x000000018B2735F0
		public static int square(int x); // 0x0000000184DB2190-0x0000000184DB21A0
		public static int2 square(int2 x); // 0x000000018B273660-0x000000018B273668
		public static int3 square(int3 x); // 0x0000000185F36694-0x0000000185F36A40
		public static int4 square(int4 x); // 0x000000018B2736C0-0x000000018B2736F8
		public static uint square(uint x); // 0x0000000184DB2190-0x0000000184DB21A0
		public static uint2 square(uint2 x); // 0x000000018B273660-0x000000018B273668
		public static uint3 square(uint3 x); // 0x0000000185F36694-0x0000000185F36A40
		public static uint4 square(uint4 x); // 0x000000018B2736C0-0x000000018B2736F8
		public static unsafe int compress(int* output, int index, int4 val, bool4 mask); // 0x000000018B24A118-0x000000018B24A2B8
		public static unsafe int compress(uint* output, int index, uint4 val, bool4 mask); // 0x000000018B24D97C-0x000000018B24D998
		public static unsafe int compress(float* output, int index, float4 val, bool4 mask); // 0x000000018B24D97C-0x000000018B24D998
		public static float f16tof32(uint x); // 0x0000000185F0C4C4-0x0000000185F0CFFC
		public static float2 f16tof32(uint2 x); // 0x000000018B250034-0x000000018B250188
		public static float3 f16tof32(uint3 x); // 0x000000018B24FD70-0x000000018B250034
		public static float4 f16tof32(uint4 x); // 0x000000018B250188-0x000000018B2503B4
		public static uint f32tof16(float x); // 0x0000000185F0CFFC-0x0000000185F0D468
		public static uint2 f32tof16(float2 x); // 0x000000018B2503B4-0x000000018B250540
		public static uint3 f32tof16(float3 x); // 0x000000018B250540-0x000000018B250838
		public static uint4 f32tof16(float4 x); // 0x000000018B250838-0x000000018B250AA4
		public static void orthonormal_basis(float3 normal, out float3 basis1, out float3 basis2); // 0x000000018B26DDDC-0x000000018B26DE80
		public static void orthonormal_basis(double3 normal, out double3 basis1, out double3 basis2); // 0x000000018B26DE80-0x000000018B26DF54
		public static float chgsign(float x, float y); // 0x0000000184DADB60-0x0000000184DADB80
		public static float2 chgsign(float2 x, float2 y); // 0x000000018B24D060-0x000000018B24D0A4
		public static float3 chgsign(float3 x, float3 y); // 0x0000000185F0975C-0x0000000185F09928
		public static float4 chgsign(float4 x, float4 y); // 0x000000018B24D0A4-0x000000018B24D104
		private static unsafe uint read32_little_endian(void* pBuffer); // 0x0000000184DA43B0-0x0000000184DA43D0
		private static unsafe uint hash_with_unaligned_loads(void* pBuffer, int numBytes, uint seed); // 0x000000018B2565C0-0x000000018B2567DC
		private static unsafe uint hash_without_unaligned_loads(void* pBuffer, int numBytes, uint seed); // 0x000000018B2567DC-0x000000018B256A7C
		public static unsafe uint hash(void* pBuffer, int numBytes, uint seed = 0 /* Metadata: 0x0234AEDC */); // 0x000000018B255458-0x000000018B255460
		public static float3 up(); // 0x0000000184DB21A0-0x0000000184DB21B0
		public static float3 down(); // 0x0000000184DAF2B0-0x0000000184DAF2D0
		public static float3 forward(); // 0x0000000184DB0000-0x0000000184DB0010
		public static float3 back(); // 0x0000000184DAD560-0x0000000184DAD570
		public static float3 left(); // 0x0000000184DB0550-0x0000000184DB0560
		public static float3 right(); // 0x0000000184DB19B0-0x0000000184DB19C0
		public static float3 EulerXYZ(quaternion q); // 0x000000018B24A584-0x000000018B24A908
		public static float3 EulerXZY(quaternion q); // 0x000000018B24A908-0x000000018B24AC60
		public static float3 EulerYXZ(quaternion q); // 0x000000018B24AC60-0x000000018B24AFB4
		public static float3 EulerYZX(quaternion q); // 0x000000018B24AFB4-0x000000018B24B2F0
		public static float3 EulerZXY(quaternion q); // 0x000000018B24B2F0-0x000000018B24B628
		public static float3 EulerZYX(quaternion q); // 0x000000018B24B628-0x000000018B24B980
		public static float3 Euler(quaternion q, RotationOrder order = RotationOrder.ZXY /* Metadata: 0x0234AEDD */); // 0x000000018B24B980-0x000000018B24BAAC
		public static float3x3 mulScale(float3x3 m, float3 s); // 0x000000018B25EEF8-0x000000018B25EFC0
		public static float3x3 scaleMul(float3 s, float3x3 m); // 0x000000018B271008-0x000000018B271100
		internal static float4 unpacklo(float4 a, float4 b); // 0x000000018B276330-0x000000018B27637C
		internal static double4 unpacklo(double4 a, double4 b); // 0x000000018B27637C-0x000000018B276A58
		internal static float4 unpackhi(float4 a, float4 b); // 0x000000018B24A2B8-0x000000018B24A3BC
		internal static double4 unpackhi(double4 a, double4 b); // 0x000000018B2762C4-0x000000018B276330
		internal static float4 movelh(float4 a, float4 b); // 0x000000018B25EE40-0x000000018B25EE8C
		internal static double4 movelh(double4 a, double4 b); // 0x000000018B25EE8C-0x000000018B25EEF8
		internal static float4 movehl(float4 a, float4 b); // 0x000000018B25ED88-0x000000018B25EDD4
		internal static double4 movehl(double4 a, double4 b); // 0x000000018B25EDD4-0x000000018B25EE40
		internal static uint fold_to_uint(double x); // 0x0000000184DAFFE0-0x0000000184DB0000
		internal static uint2 fold_to_uint(double2 x); // 0x0000000184DAFEA0-0x0000000184DAFEE0
		internal static uint3 fold_to_uint(double3 x); // 0x0000000184DAFF70-0x0000000184DAFFE0
		internal static uint4 fold_to_uint(double4 x); // 0x0000000184DAFEE0-0x0000000184DAFF70
		public static float3x3 float3x3(float4x4 f4x4); // 0x000000018B2521C0-0x000000018B252214
		public static float3x3 float3x3(quaternion rotation); // 0x000000018B252234-0x000000018B25226C
		public static float4x4 float4x4(float3x3 rotation, float3 translation); // 0x000000018B252E4C-0x000000018B252EC0
		public static float4x4 float4x4(quaternion rotation, float3 translation); // 0x000000018B252F08-0x000000018B252F70
		public static float4x4 float4x4(RigidTransform transform); // 0x000000018B252C14-0x000000018B252C68
		public static float3x3 orthonormalize(float3x3 i); // 0x000000018B26DF54-0x000000018B26E1AC
		public static float3x3 pseudoinverse(float3x3 m); // 0x000000018B26E8D4-0x000000018B26EB44
		public static float mul(float a, float b); // 0x0000000184DAEB20-0x0000000184DAEB30
		public static float mul(float2 a, float2 b); // 0x0000000184D8B640-0x0000000184D8B670
		public static float2 mul(float2 a, float2x2 b); // 0x0000000184DB0E40-0x0000000184DB0E80
		public static float3 mul(float2 a, float2x3 b); // 0x0000000184DB1540-0x0000000184DB15A0
		public static float4 mul(float2 a, float2x4 b); // 0x0000000184DB15E0-0x0000000184DB1670
		public static float mul(float3 a, float3 b); // 0x0000000184D8B7C0-0x0000000184D8B7F0
		public static float2 mul(float3 a, float3x2 b); // 0x0000000184DB0FD0-0x0000000184DB1030
		public static float3 mul(float3 a, float3x3 b); // 0x0000000184DB0F40-0x0000000184DB0FD0
		public static float4 mul(float3 a, float3x4 b); // 0x0000000184DB1370-0x0000000184DB1440
		public static float mul(float4 a, float4 b); // 0x00000001834C9990-0x00000001834C99D0
		public static float2 mul(float4 a, float4x2 b); // 0x0000000184DB14D0-0x0000000184DB1540
		public static float3 mul(float4 a, float4x3 b); // 0x0000000184DB0AA0-0x0000000184DB0B60
		public static float4 mul(float4 a, float4x4 b); // 0x0000000184DB16F0-0x0000000184DB1800
		public static float2 mul(float2x2 a, float2 b); // 0x000000018B2605A4-0x000000018B2605F4
		public static float2x2 mul(float2x2 a, float2x2 b); // 0x000000018B269AAC-0x000000018B269B80
		public static float2x3 mul(float2x2 a, float2x3 b); // 0x000000018B26A8B8-0x000000018B26A9E4
		public static float2x4 mul(float2x2 a, float2x4 b); // 0x000000018B25EFC0-0x000000018B25F144
		public static float2 mul(float2x3 a, float3 b); // 0x000000018B261160-0x000000018B2611DC
		public static float2x2 mul(float2x3 a, float3x2 b); // 0x000000018B2617FC-0x000000018B261930
		public static float2x3 mul(float2x3 a, float3x3 b); // 0x000000018B267D9C-0x000000018B267F58
		public static float2x4 mul(float2x3 a, float3x4 b); // 0x000000018B260184-0x000000018B2603CC
		public static float2 mul(float2x4 a, float4 b); // 0x000000018B2692E4-0x000000018B269390
		public static float2x2 mul(float2x4 a, float4x2 b); // 0x000000018B25F144-0x000000018B25F2DC
		public static float2x3 mul(float2x4 a, float4x3 b); // 0x000000018B267A68-0x000000018B267CB8
		public static float2x4 mul(float2x4 a, float4x4 b); // 0x000000018B26829C-0x000000018B2685A8
		public static float3 mul(float3x2 a, float2 b); // 0x000000018B262A84-0x000000018B262B20
		public static float3x2 mul(float3x2 a, float2x2 b); // 0x000000018B26970C-0x000000018B269858
		public static float3x3 mul(float3x2 a, float2x3 b); // 0x000000018B26CA28-0x000000018B26CC04
		public static float3x4 mul(float3x2 a, float2x4 b); // 0x000000018B25F2DC-0x000000018B25F54C
		public static float3 mul(float3x3 a, float3 b); // 0x000000018B26353C-0x000000018B26362C
		public static float3x2 mul(float3x3 a, float3x2 b); // 0x000000018B26B3DC-0x000000018B26B5D8
		public static float3x3 mul(float3x3 a, float3x3 b); // 0x000000018B25F918-0x000000018B25FBF4
		public static float3x4 mul(float3x3 a, float3x4 b); // 0x000000018B2662EC-0x000000018B2666B0
		public static float3 mul(float3x4 a, float4 b); // 0x000000018B265A9C-0x000000018B265BE4
		public static float3x2 mul(float3x4 a, float4x2 b); // 0x000000018B26C60C-0x000000018B26C8B0
		public static float3x3 mul(float3x4 a, float4x3 b); // 0x000000018B2653E0-0x000000018B2657B8
		public static float3x4 mul(float3x4 a, float4x4 b); // 0x000000018B260808-0x000000018B260D94
		public static float4 mul(float4x2 a, float2 b); // 0x000000018B2670B0-0x000000018B267130
		public static float4x2 mul(float4x2 a, float2x2 b); // 0x000000018B267CB8-0x000000018B267D9C
		public static float4x3 mul(float4x2 a, float2x3 b); // 0x000000018B264868-0x000000018B2649DC
		public static float4x4 mul(float4x2 a, float2x4 b); // 0x000000018B266814-0x000000018B2669FC
		public static float4 mul(float4x3 a, float3 b); // 0x000000018B269F60-0x000000018B26A018
		public static float4x2 mul(float4x3 a, float3x2 b); // 0x000000018B26A0CC-0x000000018B26A234
		public static float4x3 mul(float4x3 a, float3x3 b); // 0x000000018B268DCC-0x000000018B268FFC
		public static float4x4 mul(float4x3 a, float3x4 b); // 0x000000018B26A598-0x000000018B26A8B8
		public static float4 mul(float4x4 a, float4 b); // 0x000000018B25F54C-0x000000018B25F644
		public static float4x2 mul(float4x4 a, float4x2 b); // 0x000000018B261FF4-0x000000018B2621D8
		public static float4x3 mul(float4x4 a, float4x3 b); // 0x000000018B268FFC-0x000000018B2692E4
		public static float4x4 mul(float4x4 a, float4x4 b); // 0x000000018B26CC04-0x000000018B26D034
		public static double mul(double a, double b); // 0x0000000184DAEAF0-0x0000000184DAEB00
		public static double mul(double2 a, double2 b); // 0x0000000184DAEB60-0x0000000184DAEB80
		public static double2 mul(double2 a, double2x2 b); // 0x0000000184DB15A0-0x0000000184DB15E0
		public static double3 mul(double2 a, double2x3 b); // 0x0000000184DB1030-0x0000000184DB10A0
		public static double4 mul(double2 a, double2x4 b); // 0x0000000184DB1100-0x0000000184DB1180
		public static double mul(double3 a, double3 b); // 0x0000000184DAEB30-0x0000000184DAEB60
		public static double2 mul(double3 a, double3x2 b); // 0x0000000184DB10A0-0x0000000184DB1100
		public static double3 mul(double3 a, double3x3 b); // 0x0000000184DB1180-0x0000000184DB1210
		public static double4 mul(double3 a, double3x4 b); // 0x0000000184DB0E80-0x0000000184DB0F40
		public static double mul(double4 a, double4 b); // 0x0000000184DAEA80-0x0000000184DAEAC0
		public static double2 mul(double4 a, double4x2 b); // 0x0000000184DB1210-0x0000000184DB1290
		public static double3 mul(double4 a, double4x3 b); // 0x0000000184DB0C00-0x0000000184DB0CC0
		public static double4 mul(double4 a, double4x4 b); // 0x0000000184DB1800-0x0000000184DB18F0
		public static double2 mul(double2x2 a, double2 b); // 0x000000018B267240-0x000000018B2672B8
		public static double2x2 mul(double2x2 a, double2x2 b); // 0x000000018B265BE4-0x000000018B265CC0
		public static double2x3 mul(double2x2 a, double2x3 b); // 0x000000018B267F58-0x000000018B2680CC
		public static double2x4 mul(double2x2 a, double2x4 b); // 0x000000018B267664-0x000000018B26784C
		public static double2 mul(double2x3 a, double3 b); // 0x000000018B25F644-0x000000018B25F6FC
		public static double2x2 mul(double2x3 a, double3x2 b); // 0x000000018B2666B0-0x000000018B266814
		public static double2x3 mul(double2x3 a, double3x3 b); // 0x000000018B26ADF4-0x000000018B26B024
		public static double2x4 mul(double2x3 a, double3x4 b); // 0x000000018B268828-0x000000018B268B48
		public static double2 mul(double2x4 a, double4 b); // 0x000000018B26BD6C-0x000000018B26BE64
		public static double2x2 mul(double2x4 a, double4x2 b); // 0x000000018B260F80-0x000000018B261160
		public static double2x3 mul(double2x4 a, double4x3 b); // 0x000000018B26B0F4-0x000000018B26B3DC
		public static double2x4 mul(double2x4 a, double4x4 b); // 0x000000018B2613CC-0x000000018B2617FC
		public static double3 mul(double3x2 a, double2 b); // 0x000000018B266068-0x000000018B26611C
		public static double3x2 mul(double3x2 a, double2x2 b); // 0x000000018B26C8B0-0x000000018B26CA28
		public static double3x3 mul(double3x2 a, double2x3 b); // 0x000000018B26268C-0x000000018B2628F8
		public static double3x4 mul(double3x2 a, double2x4 b); // 0x000000018B26D120-0x000000018B26D448
		public static double3 mul(double3x3 a, double3 b); // 0x000000018B269E4C-0x000000018B269F60
		public static double3x2 mul(double3x3 a, double3x2 b); // 0x000000018B262B20-0x000000018B262D58
		public static double3x3 mul(double3x3 a, double3x3 b); // 0x000000018B265CC0-0x000000018B266068
		public static double3x4 mul(double3x3 a, double3x4 b); // 0x000000018B2621D8-0x000000018B26268C
		public static double3 mul(double3x4 a, double4 b); // 0x000000018B26407C-0x000000018B2641F0
		public static double3x2 mul(double3x4 a, double4x2 b); // 0x000000018B2669FC-0x000000018B266CF0
		public static double3x3 mul(double3x4 a, double4x3 b); // 0x000000018B26B744-0x000000018B26BC24
		public static double3x4 mul(double3x4 a, double4x4 b); // 0x000000018B26BFC0-0x000000018B26C60C
		public static double4 mul(double4x2 a, double2 b); // 0x000000018B268780-0x000000018B268828
		public static double4x2 mul(double4x2 a, double2x2 b); // 0x000000018B26B5D8-0x000000018B26B744
		public static double4x3 mul(double4x2 a, double2x3 b); // 0x000000018B269858-0x000000018B269AAC
		public static double4x4 mul(double4x2 a, double2x4 b); // 0x000000018B26D448-0x000000018B26D758
		public static double4 mul(double4x3 a, double3 b); // 0x000000018B2657B8-0x000000018B2658BC
		public static double4x2 mul(double4x3 a, double3x2 b); // 0x000000018B26784C-0x000000018B267A68
		public static double4x3 mul(double4x3 a, double3x3 b); // 0x000000018B269390-0x000000018B26970C
		public static double4x4 mul(double4x3 a, double3x4 b); // 0x000000018B263020-0x000000018B2634A4
		public static double4 mul(double4x4 a, double4 b); // 0x000000018B2603CC-0x000000018B26052C
		public static double4x2 mul(double4x4 a, double4x2 b); // 0x000000018B267394-0x000000018B267664
		public static double4x3 mul(double4x4 a, double4x3 b); // 0x000000018B2641F0-0x000000018B264694
		public static double4x4 mul(double4x4 a, double4x4 b); // 0x000000018B263970-0x000000018B263F74
		public static int mul(int a, int b); // 0x0000000184DAEA70-0x0000000184DAEA80
		public static int mul(int2 a, int2 b); // 0x0000000184DAEB00-0x0000000184DAEB20
		public static int2 mul(int2 a, int2x2 b); // 0x0000000184DB1440-0x0000000184DB1480
		public static int3 mul(int2 a, int2x3 b); // 0x0000000184DB0DE0-0x0000000184DB0E40
		public static int4 mul(int2 a, int2x4 b); // 0x0000000184DB1290-0x0000000184DB1310
		public static int mul(int3 a, int3 b); // 0x0000000184D85D00-0x0000000184D85D20
		public static int2 mul(int3 a, int3x2 b); // 0x0000000184DB1480-0x0000000184DB14D0
		public static int3 mul(int3 a, int3x3 b); // 0x0000000184DB0CC0-0x0000000184DB0D40
		public static int4 mul(int3 a, int3x4 b); // 0x0000000184DB0D40-0x0000000184DB0DE0
		public static int mul(int4 a, int4 b); // 0x0000000184DAEAC0-0x0000000184DAEAF0
		public static int2 mul(int4 a, int4x2 b); // 0x0000000184DB1310-0x0000000184DB1370
		public static int3 mul(int4 a, int4x3 b); // 0x0000000184DB0B60-0x0000000184DB0C00
		public static int4 mul(int4 a, int4x4 b); // 0x0000000184DB09E0-0x0000000184DB0AA0
		public static int2 mul(int2x2 a, int2 b); // 0x000000018B26362C-0x000000018B263674
		public static int2x2 mul(int2x2 a, int2x2 b); // 0x000000018B26A018-0x000000018B26A0CC
		public static int2x3 mul(int2x2 a, int2x3 b); // 0x000000018B263F74-0x000000018B26407C
		public static int2x4 mul(int2x2 a, int2x4 b); // 0x000000018B25FBF4-0x000000018B25FD60
		public static int2 mul(int2x3 a, int3 b); // 0x000000018B2658BC-0x000000018B265938
		public static int2x2 mul(int2x3 a, int3x2 b); // 0x000000018B267130-0x000000018B267240
		public static int2x3 mul(int2x3 a, int3x3 b); // 0x000000018B263674-0x000000018B26380C
		public static int2x4 mul(int2x3 a, int3x4 b); // 0x000000018B260D94-0x000000018B260F80
		public static int2 mul(int2x4 a, int4 b); // 0x000000018B262D58-0x000000018B262E00
		public static int2x2 mul(int2x4 a, int4x2 b); // 0x000000018B26380C-0x000000018B263970
		public static int2x3 mul(int2x4 a, int4x3 b); // 0x000000018B2605F4-0x000000018B260808
		public static int2x4 mul(int2x4 a, int4x4 b); // 0x000000018B268B48-0x000000018B268DCC
		public static int3 mul(int3x2 a, int2 b); // 0x000000018B2634A4-0x000000018B26353C
		public static int3x2 mul(int3x2 a, int2x2 b); // 0x000000018B26BC24-0x000000018B26BD6C
		public static int3x3 mul(int3x2 a, int2x3 b); // 0x000000018B264694-0x000000018B264868
		public static int3x4 mul(int3x2 a, int2x4 b); // 0x000000018B26517C-0x000000018B2653E0
		public static int3 mul(int3x3 a, int3 b); // 0x000000018B265090-0x000000018B26517C
		public static int3x2 mul(int3x3 a, int3x2 b); // 0x000000018B2611DC-0x000000018B2613CC
		public static int3x3 mul(int3x3 a, int3x3 b); // 0x000000018B269B80-0x000000018B269E4C
		public static int3x4 mul(int3x3 a, int3x4 b); // 0x000000018B264CE4-0x000000018B265090
		public static int3 mul(int3x4 a, int4 b); // 0x000000018B262E00-0x000000018B262F40
		public static int3x2 mul(int3x4 a, int4x2 b); // 0x000000018B25FD60-0x000000018B25FFF4
		public static int3x3 mul(int3x4 a, int4x3 b); // 0x000000018B266CF0-0x000000018B2670B0
		public static int3x4 mul(int3x4 a, int4x4 b); // 0x000000018B261A88-0x000000018B261FF4
		public static int4 mul(int4x2 a, int2 b); // 0x000000018B26052C-0x000000018B2605A4
		public static int4x2 mul(int4x2 a, int2x2 b); // 0x000000018B262F40-0x000000018B263020
		public static int4x3 mul(int4x2 a, int2x3 b); // 0x000000018B265938-0x000000018B265A9C
		public static int4x4 mul(int4x2 a, int2x4 b); // 0x000000018B2680CC-0x000000018B26829C
		public static int4 mul(int4x3 a, int3 b); // 0x000000018B2600D0-0x000000018B260184
		public static int4x2 mul(int4x3 a, int3x2 b); // 0x000000018B261930-0x000000018B261A88
		public static int4x3 mul(int4x3 a, int3x3 b); // 0x000000018B25F6FC-0x000000018B25F918
		public static int4x4 mul(int4x3 a, int3x4 b); // 0x000000018B2649DC-0x000000018B264CE4
		public static int4 mul(int4x4 a, int4 b); // 0x000000018B268690-0x000000018B268780
		public static int4x2 mul(int4x4 a, int4x2 b); // 0x000000018B26611C-0x000000018B2662EC
		public static int4x3 mul(int4x4 a, int4x3 b); // 0x000000018B26A234-0x000000018B26A504
		public static int4x4 mul(int4x4 a, int4x4 b); // 0x000000018B26A9E4-0x000000018B26ADF4
		public static uint mul(uint a, uint b); // 0x0000000184DAEA70-0x0000000184DAEA80
		public static uint mul(uint2 a, uint2 b); // 0x0000000184DAEB00-0x0000000184DAEB20
		public static uint2 mul(uint2 a, uint2x2 b); // 0x0000000184DB1440-0x0000000184DB1480
		public static uint3 mul(uint2 a, uint2x3 b); // 0x0000000184DB0DE0-0x0000000184DB0E40
		public static uint4 mul(uint2 a, uint2x4 b); // 0x0000000184DB1670-0x0000000184DB16F0
		public static uint mul(uint3 a, uint3 b); // 0x0000000184D85D00-0x0000000184D85D20
		public static uint2 mul(uint3 a, uint3x2 b); // 0x0000000184DB1480-0x0000000184DB14D0
		public static uint3 mul(uint3 a, uint3x3 b); // 0x0000000184DB0CC0-0x0000000184DB0D40
		public static uint4 mul(uint3 a, uint3x4 b); // 0x0000000184DB0D40-0x0000000184DB0DE0
		public static uint mul(uint4 a, uint4 b); // 0x0000000184DAEAC0-0x0000000184DAEAF0
		public static uint2 mul(uint4 a, uint4x2 b); // 0x0000000184DB1310-0x0000000184DB1370
		public static uint3 mul(uint4 a, uint4x3 b); // 0x0000000184DB0B60-0x0000000184DB0C00
		public static uint4 mul(uint4 a, uint4x4 b); // 0x0000000184DB09E0-0x0000000184DB0AA0
		public static uint2 mul(uint2x2 a, uint2 b); // 0x000000018B26362C-0x000000018B263674
		public static uint2x2 mul(uint2x2 a, uint2x2 b); // 0x000000018B26A018-0x000000018B26A0CC
		public static uint2x3 mul(uint2x2 a, uint2x3 b); // 0x000000018B263F74-0x000000018B26407C
		public static uint2x4 mul(uint2x2 a, uint2x4 b); // 0x000000018B25FBF4-0x000000018B25FD60
		public static uint2 mul(uint2x3 a, uint3 b); // 0x000000018B2658BC-0x000000018B265938
		public static uint2x2 mul(uint2x3 a, uint3x2 b); // 0x000000018B267130-0x000000018B267240
		public static uint2x3 mul(uint2x3 a, uint3x3 b); // 0x000000018B263674-0x000000018B26380C
		public static uint2x4 mul(uint2x3 a, uint3x4 b); // 0x000000018B260D94-0x000000018B260F80
		public static uint2 mul(uint2x4 a, uint4 b); // 0x000000018B262D58-0x000000018B262E00
		public static uint2x2 mul(uint2x4 a, uint4x2 b); // 0x000000018B26380C-0x000000018B263970
		public static uint2x3 mul(uint2x4 a, uint4x3 b); // 0x000000018B2605F4-0x000000018B260808
		public static uint2x4 mul(uint2x4 a, uint4x4 b); // 0x000000018B268B48-0x000000018B268DCC
		public static uint3 mul(uint3x2 a, uint2 b); // 0x000000018B2634A4-0x000000018B26353C
		public static uint3x2 mul(uint3x2 a, uint2x2 b); // 0x000000018B26BC24-0x000000018B26BD6C
		public static uint3x3 mul(uint3x2 a, uint2x3 b); // 0x000000018B264694-0x000000018B264868
		public static uint3x4 mul(uint3x2 a, uint2x4 b); // 0x000000018B26517C-0x000000018B2653E0
		public static uint3 mul(uint3x3 a, uint3 b); // 0x000000018B265090-0x000000018B26517C
		public static uint3x2 mul(uint3x3 a, uint3x2 b); // 0x000000018B2611DC-0x000000018B2613CC
		public static uint3x3 mul(uint3x3 a, uint3x3 b); // 0x000000018B269B80-0x000000018B269E4C
		public static uint3x4 mul(uint3x3 a, uint3x4 b); // 0x000000018B264CE4-0x000000018B265090
		public static uint3 mul(uint3x4 a, uint4 b); // 0x000000018B262E00-0x000000018B262F40
		public static uint3x2 mul(uint3x4 a, uint4x2 b); // 0x000000018B25FD60-0x000000018B25FFF4
		public static uint3x3 mul(uint3x4 a, uint4x3 b); // 0x000000018B266CF0-0x000000018B2670B0
		public static uint3x4 mul(uint3x4 a, uint4x4 b); // 0x000000018B261A88-0x000000018B261FF4
		public static uint4 mul(uint4x2 a, uint2 b); // 0x000000018B26052C-0x000000018B2605A4
		public static uint4x2 mul(uint4x2 a, uint2x2 b); // 0x000000018B262F40-0x000000018B263020
		public static uint4x3 mul(uint4x2 a, uint2x3 b); // 0x000000018B265938-0x000000018B265A9C
		public static uint4x4 mul(uint4x2 a, uint2x4 b); // 0x000000018B2680CC-0x000000018B26829C
		public static uint4 mul(uint4x3 a, uint3 b); // 0x000000018B2600D0-0x000000018B260184
		public static uint4x2 mul(uint4x3 a, uint3x2 b); // 0x000000018B261930-0x000000018B261A88
		public static uint4x3 mul(uint4x3 a, uint3x3 b); // 0x000000018B25F6FC-0x000000018B25F918
		public static uint4x4 mul(uint4x3 a, uint3x4 b); // 0x000000018B2649DC-0x000000018B264CE4
		public static uint4 mul(uint4x4 a, uint4 b); // 0x000000018B268690-0x000000018B268780
		public static uint4x2 mul(uint4x4 a, uint4x2 b); // 0x000000018B26611C-0x000000018B2662EC
		public static uint4x3 mul(uint4x4 a, uint4x3 b); // 0x000000018B26A234-0x000000018B26A504
		public static uint4x4 mul(uint4x4 a, uint4x4 b); // 0x000000018B26A9E4-0x000000018B26ADF4
		public static quaternion quaternion(float x, float y, float z, float w); // 0x0000000184DAF870-0x0000000184DAF890
		public static quaternion quaternion(float4 value); // 0x0000000182B77630-0x0000000182B77640
		public static quaternion quaternion(float3x3 m); // 0x000000018B26EB8C-0x000000018B26EBCC
		public static quaternion quaternion(float4x4 m); // 0x000000018B26EB44-0x000000018B26EB8C
		public static quaternion conjugate(quaternion q); // 0x000000018B24D998-0x000000018B24D9D8
		public static quaternion inverse(quaternion q); // 0x000000018B25CBA4-0x000000018B25CC20
		public static float dot(quaternion a, quaternion b); // 0x000000018B24E6D4-0x000000018B24E6FC
		public static float length(quaternion q); // 0x000000018B25D670-0x000000018B25D6AC
		public static float lengthsq(quaternion q); // 0x000000018B25D6AC-0x000000018B25D6D4
		public static quaternion normalize(quaternion q); // 0x000000018B26D8B8-0x000000018B26D914
		public static quaternion normalizesafe(quaternion q); // 0x000000018B26DC30-0x000000018B26DCF0
		public static quaternion normalizesafe(quaternion q, quaternion defaultvalue); // 0x000000018B26DBA4-0x000000018B26DC30
		public static quaternion unitexp(quaternion q); // 0x0000000185F39B9C-0x0000000185F39CC0
		public static quaternion exp(quaternion q); // 0x0000000185F0C274-0x0000000185F0C4C4
		public static quaternion unitlog(quaternion q); // 0x0000000185F39CC0-0x0000000185F3A004
		public static quaternion log(quaternion q); // 0x0000000185F17EAC-0x0000000185F180B4
		public static quaternion mul(quaternion a, quaternion b); // 0x000000018B2628F8-0x000000018B262A84
		public static float3 mul(quaternion q, float3 v); // 0x000000018B26BE64-0x000000018B26BFC0
		public static float3 rotate(quaternion q, float3 v); // 0x000000018B26BE64-0x000000018B26BFC0
		public static quaternion nlerp(quaternion q1, quaternion q2, float t); // 0x000000018B26D758-0x000000018B26D838
		public static quaternion slerp(quaternion q1, quaternion q2, float t); // 0x000000018B272C48-0x000000018B272DE8
		public static float angle(quaternion q1, quaternion q2); // 0x000000018B24C184-0x000000018B24C22C
		public static quaternion rotation(float3x3 m); // 0x000000018B2707D8-0x000000018B270A04
		private static float3x3 adj(float3x3 m, out float det); // 0x000000018B24BE4C-0x000000018B24C01C
		private static bool adjInverse(float3x3 m, out float3x3 i, float epsilon = 1E-30f /* Metadata: 0x0234AEDE */); // 0x000000018B24BD4C-0x000000018B24BE4C
		public static uint hash(quaternion q); // 0x000000018B256480-0x000000018B25649C
		public static uint4 hashwide(quaternion q); // 0x000000018B2590D8-0x000000018B259108
		public static float3 forward(quaternion q); // 0x00000001866B1564-0x00000001866B15BC
		public static RigidTransform RigidTransform(quaternion rot, float3 pos); // 0x0000000184DAD020-0x0000000184DAD040
		public static RigidTransform RigidTransform(float3x3 rotation, float3 translation); // 0x000000018B24BAAC-0x000000018B24BB08
		public static RigidTransform RigidTransform(float4x4 transform); // 0x000000018B24BB08-0x000000018B24BB58
		public static RigidTransform inverse(RigidTransform t); // 0x000000018B25CC20-0x000000018B25CCE0
		public static RigidTransform mul(RigidTransform a, RigidTransform b); // 0x000000018B26B024-0x000000018B26B0F4
		public static float4 mul(RigidTransform a, float4 pos); // 0x000000018B25FFF4-0x000000018B2600D0
		public static float3 rotate(RigidTransform a, float3 dir); // 0x00000001866B2E2C-0x00000001866B2E7C
		public static float3 transform(RigidTransform a, float3 pos); // 0x000000018B273E64-0x000000018B273EEC
		public static uint hash(RigidTransform t); // 0x000000018B25657C-0x000000018B2565C0
		public static uint4 hashwide(RigidTransform t); // 0x000000018B2578A8-0x000000018B257960
		public static uint2 uint2(uint x, uint y); // 0x0000000184DAD8A0-0x0000000184DAD8B0
		public static uint2 uint2(uint2 xy); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static uint2 uint2(uint v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static uint2 uint2(bool v); // 0x000000018B25A394-0x000000018B25A3AC
		public static uint2 uint2(bool2 v); // 0x000000018B25A3AC-0x000000018B25A3CC
		public static uint2 uint2(int v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static uint2 uint2(int2 v); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static uint2 uint2(float v); // 0x000000018B275514-0x000000018B275538
		public static uint2 uint2(float2 v); // 0x000000018B275538-0x000000018B27555C
		public static uint2 uint2(double v); // 0x000000018B2754F4-0x000000018B275514
		public static uint2 uint2(double2 v); // 0x000000018B2754C4-0x000000018B2754F4
		public static uint hash(uint2 v); // 0x000000018B254904-0x000000018B254938
		public static uint2 hashwide(uint2 v); // 0x000000018B257570-0x000000018B2575B0
		public static uint shuffle(uint2 left, uint2 right, ShuffleComponent x); // 0x0000000185F345E8-0x0000000185F3477C
		public static uint2 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F33804-0x0000000185F338F8
		public static uint3 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F33D78-0x0000000185F33DE8
		public static uint4 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F34DD4-0x0000000185F34E64
		internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component); // 0x0000000185F328C0-0x0000000185F329B0
		public static uint2x2 uint2x2(uint2 c0, uint2 c1); // 0x0000000182E515B0-0x0000000182E56440
		public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11); // 0x000000018B25A428-0x000000018B25A448
		public static uint2x2 uint2x2(uint v); // 0x000000018B25A410-0x000000018B25A428
		public static uint2x2 uint2x2(bool v); // 0x000000018B25A4CC-0x000000018B25A4E4
		public static uint2x2 uint2x2(bool2x2 v); // 0x000000018B25A3CC-0x000000018B25A3EC
		public static uint2x2 uint2x2(int v); // 0x000000018B25A410-0x000000018B25A428
		public static uint2x2 uint2x2(int2x2 v); // 0x000000018B25A490-0x000000018B25A4B4
		public static uint2x2 uint2x2(float v); // 0x000000018B27555C-0x000000018B275578
		public static uint2x2 uint2x2(float2x2 v); // 0x000000018B275618-0x000000018B275640
		public static uint2x2 uint2x2(double v); // 0x000000018B275578-0x000000018B2755BC
		public static uint2x2 uint2x2(double2x2 v); // 0x000000018B2755BC-0x000000018B275618
		public static uint2x2 transpose(uint2x2 v); // 0x000000018B274334-0x000000018B274370
		public static uint hash(uint2x2 v); // 0x000000018B255C44-0x000000018B255CA8
		public static uint2 hashwide(uint2x2 v); // 0x000000018B257480-0x000000018B2574F4
		public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2); // 0x0000000184DAF5A0-0x0000000184DAF5B0
		public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12); // 0x0000000185F164A8-0x0000000185F164E0
		public static uint2x3 uint2x3(uint v); // 0x000000018B25A53C-0x000000018B25A55C
		public static uint2x3 uint2x3(bool v); // 0x000000018B25A5F0-0x000000018B25A610
		public static uint2x3 uint2x3(bool2x3 v); // 0x000000018B25A57C-0x000000018B25A5B4
		public static uint2x3 uint2x3(int v); // 0x000000018B25A53C-0x000000018B25A55C
		public static uint2x3 uint2x3(int2x3 v); // 0x000000018B25A504-0x000000018B25A53C
		public static uint2x3 uint2x3(float v); // 0x000000018B275698-0x000000018B2756B8
		public static uint2x3 uint2x3(float2x3 v); // 0x000000018B275660-0x000000018B275698
		public static uint2x3 uint2x3(double v); // 0x000000018B275640-0x000000018B275660
		public static uint2x3 uint2x3(double2x3 v); // 0x000000018B2756B8-0x000000018B2756F4
		public static uint3x2 transpose(uint2x3 v); // 0x000000018B274F98-0x000000018B274FE4
		public static uint hash(uint2x3 v); // 0x000000018B255160-0x000000018B2551F0
		public static uint2 hashwide(uint2x3 v); // 0x000000018B25A0D0-0x000000018B25A170
		public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3); // 0x0000000184DB02D0-0x0000000184DB02F0
		public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13); // 0x0000000185F164E0-0x0000000185F16534
		public static uint2x4 uint2x4(uint v); // 0x000000018B25A66C-0x000000018B25A688
		public static uint2x4 uint2x4(bool v); // 0x000000018B25A6BC-0x000000018B25A6D8
		public static uint2x4 uint2x4(bool2x4 v); // 0x000000018B25A648-0x000000018B25A66C
		public static uint2x4 uint2x4(int v); // 0x000000018B25A66C-0x000000018B25A688
		public static uint2x4 uint2x4(int2x4 v); // 0x000000018B25A688-0x000000018B25A6BC
		public static uint2x4 uint2x4(float v); // 0x000000018B275728-0x000000018B275748
		public static uint2x4 uint2x4(float2x4 v); // 0x000000018B2756F4-0x000000018B275728
		public static uint2x4 uint2x4(double v); // 0x000000018B275748-0x000000018B275764
		public static uint2x4 uint2x4(double2x4 v); // 0x000000018B275764-0x000000018B2757A8
		public static uint4x2 transpose(uint2x4 v); // 0x000000018B27454C-0x000000018B2745A4
		public static uint hash(uint2x4 v); // 0x000000018B2540B8-0x000000018B254174
		public static uint2 hashwide(uint2x4 v); // 0x000000018B259108-0x000000018B2591D4
		public static uint3 uint3(uint x, uint y, uint z); // 0x0000000184DAD8B0-0x0000000184DAD8C0
		public static uint3 uint3(uint x, uint2 yz); // 0x0000000184DB0330-0x0000000184DB0350
		public static uint3 uint3(uint2 xy, uint z); // 0x0000000184DB0350-0x0000000184DB0370
		public static uint3 uint3(uint3 xyz); // 0x0000000184DB0370-0x0000000184DB03A0
		public static uint3 uint3(uint v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static uint3 uint3(bool v); // 0x000000018B25A788-0x000000018B25A7A0
		public static uint3 uint3(bool3 v); // 0x000000018B25A7A0-0x000000018B25A7D4
		public static uint3 uint3(int v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static uint3 uint3(int3 v); // 0x0000000184DB0370-0x0000000184DB03A0
		public static uint3 uint3(float v); // 0x000000018B275808-0x000000018B275824
		public static uint3 uint3(float3 v); // 0x0000000185F3B330-0x0000000185F3B37C
		public static uint3 uint3(double v); // 0x000000018B2757E0-0x000000018B275808
		public static uint3 uint3(double3 v); // 0x000000018B2757A8-0x000000018B2757E0
		public static uint hash(uint3 v); // 0x0000000185F0F580-0x0000000185F0FFD4
		public static uint3 hashwide(uint3 v); // 0x0000000185F156A4-0x0000000185F15AF0
		public static uint shuffle(uint3 left, uint3 right, ShuffleComponent x); // 0x0000000185F34FF4-0x0000000185F35030
		public static uint2 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y); // 0x0000000185F344F0-0x0000000185F34570
		public static uint3 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x0000000185F34F18-0x0000000185F34FF4
		public static uint4 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x0000000185F347E8-0x0000000185F34900
		internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component); // 0x0000000185F33024-0x0000000185F33128
		public static uint3x2 uint3x2(uint3 c0, uint3 c1); // 0x0000000184DAF7F0-0x0000000184DAF820
		public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21); // 0x0000000185F16534-0x0000000185F165C4
		public static uint3x2 uint3x2(uint v); // 0x000000018B25A884-0x000000018B25A8A4
		public static uint3x2 uint3x2(bool v); // 0x000000018B25A8A4-0x000000018B25A8C4
		public static uint3x2 uint3x2(bool3x2 v); // 0x000000018B25A8C4-0x000000018B25A8FC
		public static uint3x2 uint3x2(int v); // 0x000000018B25A884-0x000000018B25A8A4
		public static uint3x2 uint3x2(int3x2 v); // 0x000000018B25A814-0x000000018B25A84C
		public static uint3x2 uint3x2(float v); // 0x000000018B2758F8-0x000000018B275918
		public static uint3x2 uint3x2(float3x2 v); // 0x000000018B2758C0-0x000000018B2758F8
		public static uint3x2 uint3x2(double v); // 0x000000018B275824-0x000000018B275884
		public static uint3x2 uint3x2(double3x2 v); // 0x000000018B275884-0x000000018B2758C0
		public static uint2x3 transpose(uint3x2 v); // 0x000000018B274370-0x000000018B2743BC
		public static uint hash(uint3x2 v); // 0x000000018B25465C-0x000000018B25473C
		public static uint3 hashwide(uint3x2 v); // 0x000000018B258BF0-0x000000018B258CE8
		public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2); // 0x00000001834C99D0-0x00000001834C9A10
		public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22); // 0x0000000185F165C4-0x0000000185F16688
		public static uint3x3 uint3x3(uint v); // 0x000000018B25A93C-0x000000018B25A95C
		public static uint3x3 uint3x3(bool v); // 0x000000018B25AAB4-0x000000018B25AAD4
		public static uint3x3 uint3x3(bool3x3 v); // 0x000000018B25AA74-0x000000018B25AAB4
		public static uint3x3 uint3x3(int v); // 0x000000018B25A93C-0x000000018B25A95C
		public static uint3x3 uint3x3(int3x3 v); // 0x000000018B25A97C-0x000000018B25A9BC
		public static uint3x3 uint3x3(float v); // 0x000000018B275978-0x000000018B27599C
		public static uint3x3 uint3x3(float3x3 v); // 0x000000018B275938-0x000000018B275978
		public static uint3x3 uint3x3(double v); // 0x000000018B275918-0x000000018B275938
		public static uint3x3 uint3x3(double3x3 v); // 0x000000018B27599C-0x000000018B2759F0
		public static uint3x3 transpose(uint3x3 v); // 0x000000018B2748D4-0x000000018B274940
		public static uint hash(uint3x3 v); // 0x000000018B255E3C-0x000000018B255F90
		public static uint3 hashwide(uint3x3 v); // 0x000000018B2592C8-0x000000018B259434
		public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3); // 0x0000000184DAF820-0x0000000184DAF870
		public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23); // 0x0000000185F16688-0x0000000185F16750
		public static uint3x4 uint3x4(uint v); // 0x000000018B25AB90-0x000000018B25ABB0
		public static uint3x4 uint3x4(bool v); // 0x000000018B25AAD4-0x000000018B25AAF4
		public static uint3x4 uint3x4(bool3x4 v); // 0x000000018B25AB54-0x000000018B25AB90
		public static uint3x4 uint3x4(int v); // 0x000000018B25AB90-0x000000018B25ABB0
		public static uint3x4 uint3x4(int3x4 v); // 0x000000018B25AC34-0x000000018B25AC78
		public static uint3x4 uint3x4(float v); // 0x000000018B275AB0-0x000000018B275AD4
		public static uint3x4 uint3x4(float3x4 v); // 0x000000018B275A6C-0x000000018B275AB0
		public static uint3x4 uint3x4(double v); // 0x000000018B2759F0-0x000000018B275A10
		public static uint3x4 uint3x4(double3x4 v); // 0x000000018B275A10-0x000000018B275A6C
		public static uint4x3 transpose(uint3x4 v); // 0x000000018B27445C-0x000000018B2744E0
		public static uint hash(uint3x4 v); // 0x000000018B255A78-0x000000018B255C44
		public static uint3 hashwide(uint3x4 v); // 0x000000018B259E00-0x000000018B259FE0
		public static uint4 uint4(uint x, uint y, uint z, uint w); // 0x0000000184DAD8C0-0x0000000184DAD8E0
		public static uint4 uint4(uint x, uint y, uint2 zw); // 0x0000000184DB04B0-0x0000000184DB04D0
		public static uint4 uint4(uint x, uint2 yz, uint w); // 0x0000000184DB0530-0x0000000184DB0550
		public static uint4 uint4(uint x, uint3 yzw); // 0x0000000184DB0430-0x0000000184DB0470
		public static uint4 uint4(uint2 xy, uint z, uint w); // 0x0000000184DB04D0-0x0000000184DB04F0
		public static uint4 uint4(uint2 xy, uint2 zw); // 0x0000000184DAB610-0x0000000184DAB630
		public static uint4 uint4(uint3 xyz, uint w); // 0x0000000184DB04F0-0x0000000184DB0530
		public static uint4 uint4(uint4 xyzw); // 0x000000018B25AC78-0x000000018B25ACA4
		public static uint4 uint4(uint v); // 0x0000000184DB0420-0x0000000184DB0430
		public static uint4 uint4(bool v); // 0x000000018B25ACA4-0x000000018B25ACC4
		public static uint4 uint4(bool4 v); // 0x000000018B25ACC4-0x000000018B25AD08
		public static uint4 uint4(int v); // 0x0000000184DB0420-0x0000000184DB0430
		public static uint4 uint4(int4 v); // 0x000000018B25AC78-0x000000018B25ACA4
		public static uint4 uint4(float v); // 0x000000018B275B1C-0x000000018B275B34
		public static uint4 uint4(float4 v); // 0x000000018B275B64-0x000000018B275B88
		public static uint4 uint4(double v); // 0x000000018B275B34-0x000000018B275B64
		public static uint4 uint4(double4 v); // 0x000000018B275AD4-0x000000018B275B1C
		public static uint hash(uint4 v); // 0x000000018B253A04-0x000000018B253A70
		public static uint4 hashwide(uint4 v); // 0x000000018B257404-0x000000018B257480
		public static uint shuffle(uint4 left, uint4 right, ShuffleComponent x); // 0x000000018B271AE0-0x000000018B271B08
		public static uint2 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y); // 0x000000018B271660-0x000000018B2716B8
		public static uint3 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z); // 0x000000018B271DF8-0x000000018B271EA0
		public static uint4 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018B272138-0x000000018B272210
		internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component); // 0x0000000185F33540-0x0000000185F33710
		public static uint4x2 uint4x2(uint4 c0, uint4 c1); // 0x0000000184DAFA00-0x0000000184DAFA20
		public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31); // 0x0000000185F16750-0x0000000185F16804
		public static uint4x2 uint4x2(uint v); // 0x000000018B25ADCC-0x000000018B25ADE8
		public static uint4x2 uint4x2(bool v); // 0x000000018B275BAC-0x000000018B275BC8
		public static uint4x2 uint4x2(bool4x2 v); // 0x000000018B275B88-0x000000018B275BAC
		public static uint4x2 uint4x2(int v); // 0x000000018B25ADCC-0x000000018B25ADE8
		public static uint4x2 uint4x2(int4x2 v); // 0x000000018B25ADE8-0x000000018B25AE1C
		public static uint4x2 uint4x2(float v); // 0x000000018B275BC8-0x000000018B275BE8
		public static uint4x2 uint4x2(float4x2 v); // 0x000000018B275C2C-0x000000018B275C60
		public static uint4x2 uint4x2(double v); // 0x000000018B275C60-0x000000018B275C7C
		public static uint4x2 uint4x2(double4x2 v); // 0x000000018B275BE8-0x000000018B275C2C
		public static uint2x4 transpose(uint4x2 v); // 0x000000018B2743BC-0x000000018B274414
		public static uint hash(uint4x2 v); // 0x000000018B25605C-0x000000018B256128
		public static uint4 hashwide(uint4x2 v); // 0x000000018B256A7C-0x000000018B256B54
		public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2); // 0x0000000184DAFA20-0x0000000184DAFA40
		public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32); // 0x0000000185F16804-0x0000000185F169CC
		public static uint4x3 uint4x3(uint v); // 0x000000018B25AECC-0x000000018B25AEEC
		public static uint4x3 uint4x3(bool v); // 0x000000018B275D9C-0x000000018B275DBC
		public static uint4x3 uint4x3(bool4x3 v); // 0x000000018B275D60-0x000000018B275D9C
		public static uint4x3 uint4x3(int v); // 0x000000018B25AECC-0x000000018B25AEEC
		public static uint4x3 uint4x3(int4x3 v); // 0x000000018B25AFA8-0x000000018B25AFEC
		public static uint4x3 uint4x3(float v); // 0x000000018B275D1C-0x000000018B275D40
		public static uint4x3 uint4x3(float4x3 v); // 0x000000018B275C7C-0x000000018B275CC0
		public static uint4x3 uint4x3(double v); // 0x000000018B275D40-0x000000018B275D60
		public static uint4x3 uint4x3(double4x3 v); // 0x000000018B275CC0-0x000000018B275D1C
		public static uint3x4 transpose(uint4x3 v); // 0x000000018B274770-0x000000018B2747F4
		public static uint hash(uint4x3 v); // 0x000000018B254D80-0x000000018B254EB0
		public static uint4 hashwide(uint4x3 v); // 0x000000018B258CE8-0x000000018B258E24
		public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3); // 0x0000000184DAFA40-0x0000000184DAFA70
		public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33); // 0x0000000185F169CC-0x0000000185F16C64
		public static uint4x4 uint4x4(uint v); // 0x000000018B25B0CC-0x000000018B25B0F0
		public static uint4x4 uint4x4(bool v); // 0x000000018B275DBC-0x000000018B275DE0
		public static uint4x4 uint4x4(bool4x4 v); // 0x000000018B275E3C-0x000000018B275E74
		public static uint4x4 uint4x4(int v); // 0x000000018B25B0CC-0x000000018B25B0F0
		public static uint4x4 uint4x4(int4x4 v); // 0x000000018B25B14C-0x000000018B25B1A8
		public static uint4x4 uint4x4(float v); // 0x000000018B275F00-0x000000018B275F28
		public static uint4x4 uint4x4(float4x4 v); // 0x000000018B275DE0-0x000000018B275E3C
		public static uint4x4 uint4x4(double v); // 0x000000018B275F28-0x000000018B275F4C
		public static uint4x4 uint4x4(double4x4 v); // 0x000000018B275E74-0x000000018B275F00
		public static uint4x4 transpose(uint4x4 v); // 0x000000018B274AF4-0x000000018B274B9C
		public static uint hash(uint4x4 v); // 0x000000018B254938-0x000000018B254AC8
		public static uint4 hashwide(uint4x4 v); // 0x000000018B2571C8-0x000000018B257364
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2 : IEquatable<Unity.Mathematics.bool2> // TypeDefIndex: 57181
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57180
		{
		}
	
		// Constructors
		public bool2(bool x, bool y); // 0x0000000182BBF3D0-0x0000000182BBF3E0
		public bool2(bool2 xy); // 0x0000000184DB21E0-0x0000000184DB21F0
		public bool2(bool v); // 0x0000000184DB21F0-0x0000000184DB2200
	
		// Methods
		public static implicit operator bool2(bool v); // 0x0000000184DAD580-0x0000000184DAD590
		public bool Equals(bool2 rhs); // 0x000000018B27CF60-0x000000018B27CF74
		public override bool Equals(object o); // 0x000000018B27CF74-0x000000018B27CFE8
		public override int GetHashCode(); // 0x000000018B27CFE8-0x000000018B27D030
		public override string ToString(); // 0x000000018B27D030-0x000000018B27D0B8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x2 : IEquatable<Unity.Mathematics.bool2x2> // TypeDefIndex: 57182
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
	
		// Constructors
		public bool2x2(bool2 c0, bool2 c1); // 0x0000000184DA4480-0x0000000184DA4490
		public bool2x2(bool m00, bool m01, bool m10, bool m11); // 0x0000000184DB2230-0x0000000184DB2260
		public bool2x2(bool v); // 0x0000000184DB2200-0x0000000184DB2230
	
		// Methods
		public bool Equals(bool2x2 rhs); // 0x000000018B276A58-0x000000018B276BE0
		public override bool Equals(object o); // 0x000000018B27D0B8-0x000000018B27D118
		public override int GetHashCode(); // 0x000000018B27D118-0x000000018B27D120
		public override string ToString(); // 0x000000018B27D120-0x000000018B27D27C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x3 : IEquatable<Unity.Mathematics.bool2x3> // TypeDefIndex: 57183
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
		public bool2 c2; // 0x04
	
		// Constructors
		public bool2x3(bool2 c0, bool2 c1, bool2 c2); // 0x0000000184DB22F0-0x0000000184DB2300
		public bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12); // 0x0000000184DB2260-0x0000000184DB22B0
		public bool2x3(bool v); // 0x0000000184DB22B0-0x0000000184DB22F0
	
		// Methods
		public bool Equals(bool2x3 rhs); // 0x000000018B276BE0-0x000000018B276DE8
		public override bool Equals(object o); // 0x000000018B27D27C-0x000000018B27D2EC
		public override int GetHashCode(); // 0x000000018B27D2EC-0x000000018B27D310
		public override string ToString(); // 0x000000018B27D310-0x000000018B27D4D8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x4 : IEquatable<Unity.Mathematics.bool2x4> // TypeDefIndex: 57184
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
		public bool2 c2; // 0x04
		public bool2 c3; // 0x06
	
		// Constructors
		public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3); // 0x0000000184DB23B0-0x0000000184DB23D0
		public bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13); // 0x0000000184DB2300-0x0000000184DB2360
		public bool2x4(bool v); // 0x0000000184DB2360-0x0000000184DB23B0
	
		// Methods
		public bool Equals(bool2x4 rhs); // 0x000000018B276DE8-0x000000018B277070
		public override bool Equals(object o); // 0x000000018B27D4D8-0x000000018B27D538
		public override int GetHashCode(); // 0x000000018B27D538-0x000000018B27D540
		public override string ToString(); // 0x000000018B27D540-0x000000018B27D770
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3 : IEquatable<Unity.Mathematics.bool3> // TypeDefIndex: 57186
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Properties
		public bool this[int index] { get => default; set {} } // 0x0000000183966740-0x0000000183966750 0x0000000184D93080-0x0000000184D93090
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57185
		{
		}
	
		// Constructors
		public bool3(bool x, bool y, bool z); // 0x0000000184DA0780-0x0000000184DA0790
		public bool3(bool x, bool2 yz); // 0x0000000184DB23E0-0x0000000184DB23F0
		public bool3(bool2 xy, bool z); // 0x0000000184DB23F0-0x0000000184DB2400
		public bool3(bool3 xyz); // 0x0000000184DB2400-0x0000000184DB2420
		public bool3(bool v); // 0x0000000184DB23D0-0x0000000184DB23E0
	
		// Methods
		public static implicit operator bool3(bool v); // 0x0000000184DAD620-0x0000000184DAD630
		public static bool3 operator &(bool3 lhs, bool3 rhs); // 0x0000000183B885B0-0x0000000183B885E0
		public static bool3 operator |(bool3 lhs, bool3 rhs); // 0x000000018B27D8B8-0x000000018B27D8E8
		public bool Equals(bool3 rhs); // 0x000000018B277070-0x000000018B2779E4
		public override bool Equals(object o); // 0x000000018B27D770-0x000000018B27D7E0
		public override int GetHashCode(); // 0x000000018B27D7E0-0x000000018B27D804
		public override string ToString(); // 0x000000018B27D804-0x000000018B27D8B8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x2 : IEquatable<Unity.Mathematics.bool3x2> // TypeDefIndex: 57187
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
	
		// Constructors
		public bool3x2(bool3 c0, bool3 c1); // 0x0000000184DB2490-0x0000000184DB24B0
		public bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21); // 0x0000000184DB2420-0x0000000184DB2460
		public bool3x2(bool v); // 0x0000000184DB2460-0x0000000184DB2490
	
		// Methods
		public bool Equals(bool3x2 rhs); // 0x000000018B27D958-0x000000018B27D9A4
		public override bool Equals(object o); // 0x000000018B27D8E8-0x000000018B27D958
		public override int GetHashCode(); // 0x000000018B27D9A4-0x000000018B27D9C8
		public override string ToString(); // 0x000000018B27D9C8-0x000000018B27DB90
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x3 : IEquatable<Unity.Mathematics.bool3x3> // TypeDefIndex: 57188
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
		public bool3 c2; // 0x06
	
		// Constructors
		public bool3x3(bool3 c0, bool3 c1, bool3 c2); // 0x0000000184DB2560-0x0000000184DB2590
		public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22); // 0x0000000184DB24F0-0x0000000184DB2560
		public bool3x3(bool v); // 0x0000000184DB24B0-0x0000000184DB24F0
	
		// Methods
		public bool Equals(bool3x3 rhs); // 0x000000018B27DC04-0x000000018B27DC78
		public override bool Equals(object o); // 0x000000018B27DB90-0x000000018B27DC04
		public override int GetHashCode(); // 0x000000018B27DC78-0x000000018B27DCA0
		public override string ToString(); // 0x000000018B27DCA0-0x000000018B27DF04
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x4 : IEquatable<Unity.Mathematics.bool3x4> // TypeDefIndex: 57189
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
		public bool3 c2; // 0x06
		public bool3 c3; // 0x09
	
		// Constructors
		public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3); // 0x0000000184DB2670-0x0000000184DB26C0
		public bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23); // 0x0000000184DB25E0-0x0000000184DB2670
		public bool3x4(bool v); // 0x0000000184DB2590-0x0000000184DB25E0
	
		// Methods
		public bool Equals(bool3x4 rhs); // 0x000000018B27DF04-0x000000018B27DF98
		public override bool Equals(object o); // 0x000000018B27DF98-0x000000018B27E00C
		public override int GetHashCode(); // 0x000000018B27E00C-0x000000018B27E030
		public override string ToString(); // 0x000000018B27E030-0x000000018B27E330
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4 : IEquatable<Unity.Mathematics.bool4> // TypeDefIndex: 57191
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
		public bool w; // 0x03
	
		// Properties
		public bool this[int index] { set {} } // 0x0000000184D93080-0x0000000184D93090
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57190
		{
		}
	
		// Constructors
		public bool4(bool x, bool y, bool z, bool w); // 0x0000000184DAB240-0x0000000184DAB260
		public bool4(bool x, bool y, bool2 zw); // 0x0000000184DB2790-0x0000000184DB27B0
		public bool4(bool x, bool2 yz, bool w); // 0x0000000184DB26F0-0x0000000184DB2710
		public bool4(bool x, bool3 yzw); // 0x0000000184DB2710-0x0000000184DB2730
		public bool4(bool2 xy, bool z, bool w); // 0x0000000184DB2730-0x0000000184DB2750
		public bool4(bool2 xy, bool2 zw); // 0x0000000184DB2750-0x0000000184DB2770
		public bool4(bool3 xyz, bool w); // 0x0000000184DB2770-0x0000000184DB2790
		public bool4(bool4 xyzw); // 0x0000000184DB26C0-0x0000000184DB26E0
		public bool4(bool v); // 0x0000000184DB26E0-0x0000000184DB26F0
	
		// Methods
		public static implicit operator bool4(bool v); // 0x0000000184DAD7B0-0x0000000184DAD7D0
		public bool Equals(bool4 rhs); // 0x000000018B2779E4-0x000000018B277B6C
		public override bool Equals(object o); // 0x000000018B27E330-0x000000018B27E390
		public override int GetHashCode(); // 0x000000018B27E390-0x000000018B27E398
		public override string ToString(); // 0x000000018B27E398-0x000000018B27E4F4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x2 : IEquatable<Unity.Mathematics.bool4x2> // TypeDefIndex: 57192
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
	
		// Constructors
		public bool4x2(bool4 c0, bool4 c1); // 0x0000000184D85C40-0x0000000184D85C50
		public bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31); // 0x0000000184DB27E0-0x0000000184DB2830
		public bool4x2(bool v); // 0x0000000184DB27B0-0x0000000184DB27E0
	
		// Methods
		public bool Equals(bool4x2 rhs); // 0x000000018B277B6C-0x000000018B278530
		public override bool Equals(object o); // 0x000000018B27E4F4-0x000000018B27E554
		public override int GetHashCode(); // 0x000000018B27E554-0x000000018B27E55C
		public override string ToString(); // 0x000000018B27E55C-0x000000018B27E78C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x3 : IEquatable<Unity.Mathematics.bool4x3> // TypeDefIndex: 57193
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
		public bool4 c2; // 0x08
	
		// Constructors
		public bool4x3(bool4 c0, bool4 c1, bool4 c2); // 0x0000000184D85D60-0x0000000184D85D70
		public bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32); // 0x0000000184DB2830-0x0000000184DB28B0
		public bool4x3(bool v); // 0x0000000184DB28B0-0x0000000184DB2900
	
		// Methods
		public bool Equals(bool4x3 rhs); // 0x000000018B27E800-0x000000018B27E840
		public override bool Equals(object o); // 0x000000018B27E78C-0x000000018B27E800
		public override int GetHashCode(); // 0x000000018B27E840-0x000000018B27E864
		public override string ToString(); // 0x000000018B27E864-0x000000018B27EB64
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x4 : IEquatable<Unity.Mathematics.bool4x4> // TypeDefIndex: 57194
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
		public bool4 c2; // 0x08
		public bool4 c3; // 0x0C
	
		// Constructors
		public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3); // 0x0000000184D88C10-0x0000000184D88C30
		public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33); // 0x0000000184DB2900-0x0000000184DB29B0
		public bool4x4(bool v); // 0x0000000184DB29B0-0x0000000184DB2A10
	
		// Methods
		public bool Equals(bool4x4 rhs); // 0x000000018B27EBD0-0x000000018B27EC20
		public override bool Equals(object o); // 0x000000018B27EB64-0x000000018B27EBD0
		public override int GetHashCode(); // 0x000000018B27EC20-0x000000018B27EC3C
		public override string ToString(); // 0x000000018B27EC3C-0x000000018B27F00C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2 : IEquatable<Unity.Mathematics.double2>, IFormattable // TypeDefIndex: 57196
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57195
		{
		}
	
		// Constructors
		public double2(double x, double y); // 0x0000000184D881B0-0x0000000184D881C0
		public double2(double2 xy); // 0x0000000184D881A0-0x0000000184D881B0
		public double2(double v); // 0x0000000184DB2A60-0x0000000184DB2A70
		public double2(bool v); // 0x000000018B27F20C-0x000000018B27F220
		public double2(bool2 v); // 0x0000000185F00990-0x0000000185F009F8
		public double2(int v); // 0x0000000184DB2A90-0x0000000184DB2AB0
		public double2(int2 v); // 0x0000000184DB2A40-0x0000000184DB2A60
		public double2(uint v); // 0x0000000184DB2A70-0x0000000184DB2A90
		public double2(uint2 v); // 0x0000000184DB2AB0-0x0000000184DB2AD0
		public double2(half v); // 0x000000018B27F1D0-0x000000018B27F20C
		public double2(half2 v); // 0x000000018B27F190-0x000000018B27F1D0
		public double2(float v); // 0x0000000184DB2AD0-0x0000000184DB2AE0
		public double2(float2 v); // 0x0000000184DB2A10-0x0000000184DB2A40
	
		// Methods
		public static implicit operator double2(double v); // 0x0000000184DAECB0-0x0000000184DAECC0
		public static implicit operator double2(int v); // 0x0000000184DAEC50-0x0000000184DAEC70
		public static implicit operator double2(int2 v); // 0x0000000184DAEBF0-0x0000000184DAEC20
		public static implicit operator double2(uint v); // 0x0000000184DAEB90-0x0000000184DAEBC0
		public static implicit operator double2(uint2 v); // 0x0000000184DAEC20-0x0000000184DAEC50
		public static implicit operator double2(float v); // 0x0000000184DAEC70-0x0000000184DAEC90
		public static implicit operator double2(float2 v); // 0x0000000184DAEBC0-0x0000000184DAEBF0
		public static double2 operator *(double2 lhs, double2 rhs); // 0x0000000184DB2B10-0x0000000184DB2B40
		public static double2 operator *(double2 lhs, double rhs); // 0x0000000184DB2B60-0x0000000184DB2B80
		public static double2 operator *(double lhs, double2 rhs); // 0x0000000184DB2B40-0x0000000184DB2B60
		public static double2 operator +(double2 lhs, double2 rhs); // 0x0000000184DB2AE0-0x0000000184DB2B10
		public static double2 operator -(double2 lhs, double2 rhs); // 0x0000000184DB2BA0-0x0000000184DB2BD0
		public static double2 operator -(double lhs, double2 rhs); // 0x0000000184DB2B80-0x0000000184DB2BA0
		public static double2 operator /(double2 lhs, double2 rhs); // 0x000000018B27F23C-0x000000018B27F260
		public static double2 operator /(double lhs, double2 rhs); // 0x000000018B27F220-0x000000018B27F23C
		public static bool2 operator <(double2 lhs, double rhs); // 0x000000018B27F2B8-0x000000018B27F2D4
		public static bool2 operator >=(double2 lhs, double2 rhs); // 0x000000018B27F294-0x000000018B27F2B8
		public static double2 operator -(double2 val); // 0x0000000184DB2BD0-0x0000000184DB2BF0
		public static bool2 operator ==(double2 lhs, double rhs); // 0x000000018B27F260-0x000000018B27F294
		public bool Equals(double2 rhs); // 0x000000018B278530-0x000000018B27C688
		public override bool Equals(object o); // 0x000000018B27F00C-0x000000018B27F078
		public override int GetHashCode(); // 0x000000018B254EB0-0x000000018B254EF8
		public override string ToString(); // 0x000000018B27F100-0x000000018B27F190
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B27F078-0x000000018B27F100
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x2 : IEquatable<Unity.Mathematics.double2x2>, IFormattable // TypeDefIndex: 57197
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public static readonly double2x2 identity; // 0x00
	
		// Constructors
		public double2x2(double2 c0, double2 c1); // 0x0000000184D8C810-0x0000000184D8C820
		public double2x2(double m00, double m01, double m10, double m11); // 0x0000000184DB2C40-0x0000000184DB2C60
		public double2x2(double v); // 0x0000000184DB2C20-0x0000000184DB2C40
		public double2x2(bool v); // 0x0000000185F00A78-0x0000000185F00B04
		public double2x2(bool2x2 v); // 0x0000000185F009F8-0x0000000185F00A78
		public double2x2(int v); // 0x0000000184DB2BF0-0x0000000184DB2C20
		public double2x2(int2x2 v); // 0x0000000184DB2D60-0x0000000184DB2DB0
		public double2x2(uint v); // 0x0000000184DB2C60-0x0000000184DB2CA0
		public double2x2(uint2x2 v); // 0x0000000184DB2CE0-0x0000000184DB2D30
		public double2x2(float v); // 0x0000000184DB2D30-0x0000000184DB2D60
		public double2x2(float2x2 v); // 0x0000000184DB2CA0-0x0000000184DB2CE0
		static double2x2(); // 0x0000000184D19290-0x0000000184D19300
	
		// Methods
		public static double2x2 operator *(double2x2 lhs, double rhs); // 0x000000018B27F674-0x000000018B27F6D0
		public bool Equals(double2x2 rhs); // 0x000000018B27F2D4-0x000000018B27F31C
		public override bool Equals(object o); // 0x000000018B27F31C-0x000000018B27F390
		public override int GetHashCode(); // 0x000000018B27F390-0x000000018B27F3B4
		public override string ToString(); // 0x000000018B27F3B4-0x000000018B27F520
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B27F520-0x000000018B27F674
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x3 : IEquatable<Unity.Mathematics.double2x3>, IFormattable // TypeDefIndex: 57198
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public double2 c2; // 0x20
	
		// Constructors
		public double2x3(double2 c0, double2 c1, double2 c2); // 0x0000000184DA0760-0x0000000184DA0780
		public double2x3(double m00, double m01, double m02, double m10, double m11, double m12); // 0x0000000184DB2F10-0x0000000184DB2F40
		public double2x3(double v); // 0x0000000184DB2EA0-0x0000000184DB2EC0
		public double2x3(bool v); // 0x0000000185F00B04-0x0000000185F00B38
		public double2x3(bool2x3 v); // 0x0000000185F00B38-0x0000000185F00BE8
		public double2x3(int v); // 0x0000000184DB3000-0x0000000184DB3050
		public double2x3(int2x3 v); // 0x0000000184DB2DB0-0x0000000184DB2E20
		public double2x3(uint v); // 0x0000000184DB2FA0-0x0000000184DB3000
		public double2x3(uint2x3 v); // 0x0000000184DB2E20-0x0000000184DB2EA0
		public double2x3(float v); // 0x0000000184DB2EC0-0x0000000184DB2F10
		public double2x3(float2x3 v); // 0x0000000184DB2F40-0x0000000184DB2FA0
	
		// Methods
		public bool Equals(double2x3 rhs); // 0x000000018B27F6D0-0x000000018B27F730
		public override bool Equals(object o); // 0x000000018B27F730-0x000000018B27F7AC
		public override int GetHashCode(); // 0x000000018B27F7AC-0x000000018B27F7DC
		public override string ToString(); // 0x000000018B27F990-0x000000018B27FB70
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B27F7DC-0x000000018B27F990
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x4 : IEquatable<Unity.Mathematics.double2x4>, IFormattable // TypeDefIndex: 57199
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public double2 c2; // 0x20
		public double2 c3; // 0x30
	
		// Constructors
		public double2x4(double2 c0, double2 c1, double2 c2, double2 c3); // 0x0000000184DB3220-0x0000000184DB3250
		public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13); // 0x0000000184DB3250-0x0000000184DB32A0
		public double2x4(double v); // 0x0000000184DB32A0-0x0000000184DB32C0
		public double2x4(bool v); // 0x0000000185F00CC8-0x0000000185F00D0C
		public double2x4(bool2x4 v); // 0x0000000185F00BE8-0x0000000185F00CC8
		public double2x4(int v); // 0x0000000184DB3150-0x0000000184DB31B0
		public double2x4(int2x4 v); // 0x0000000184DB3340-0x0000000184DB33D0
		public double2x4(uint v); // 0x0000000184DB32C0-0x0000000184DB3340
		public double2x4(uint2x4 v); // 0x0000000184DB30B0-0x0000000184DB3150
		public double2x4(float v); // 0x0000000184DB3050-0x0000000184DB30B0
		public double2x4(float2x4 v); // 0x0000000184DB31B0-0x0000000184DB3220
	
		// Methods
		public bool Equals(double2x4 rhs); // 0x000000018B27FB70-0x000000018B27FBEC
		public override bool Equals(object o); // 0x000000018B27FBEC-0x000000018B27FC70
		public override int GetHashCode(); // 0x000000018B27FC70-0x000000018B27FCA8
		public override string ToString(); // 0x000000018B27FEBC-0x000000018B28010C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B27FCA8-0x000000018B27FEBC
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double3 : IEquatable<Unity.Mathematics.double3>, IFormattable // TypeDefIndex: 57201
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public static readonly double3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzx { get; } // 0x0000000184DB3540-0x0000000184DB3560 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxy { get; } // 0x0000000184DB3560-0x0000000184DB3580 
		public double this[int index] { get => default; } // 0x0000000184DB3530-0x0000000184DB3540 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57200
		{
		}
	
		// Constructors
		public double3(double x, double y, double z); // 0x0000000184DB3520-0x0000000184DB3530
		public double3(double x, double2 yz); // 0x0000000184DB3450-0x0000000184DB3470
		public double3(double2 xy, double z); // 0x0000000184DB3410-0x0000000184DB3430
		public double3(double3 xyz); // 0x0000000184DB3490-0x0000000184DB34B0
		public double3(double v); // 0x0000000184DB34B0-0x0000000184DB34C0
		public double3(bool v); // 0x0000000185F00D48-0x0000000185F00FEC
		public double3(bool3 v); // 0x0000000185F00D0C-0x0000000185F00D48
		public double3(int v); // 0x0000000184DB3470-0x0000000184DB3490
		public double3(int3 v); // 0x0000000184DB3430-0x0000000184DB3450
		public double3(uint v); // 0x0000000184DB34C0-0x0000000184DB34F0
		public double3(uint3 v); // 0x0000000184DB34F0-0x0000000184DB3520
		public double3(half v); // 0x000000018B280318-0x000000018B280368
		public double3(half3 v); // 0x000000018B280368-0x000000018B2803BC
		public double3(float v); // 0x0000000184DB33F0-0x0000000184DB3410
		public double3(float3 v); // 0x0000000184DB33D0-0x0000000184DB33F0
	
		// Methods
		public static implicit operator double3(double v); // 0x0000000184DAEE70-0x0000000184DAEE80
		public static implicit operator double3(int v); // 0x0000000184DAEF30-0x0000000184DAEF60
		public static implicit operator double3(int3 v); // 0x0000000184DAEDD0-0x0000000184DAEE20
		public static implicit operator double3(uint v); // 0x0000000184DAEE20-0x0000000184DAEE50
		public static implicit operator double3(uint3 v); // 0x0000000184DAEEA0-0x0000000184DAEF00
		public static implicit operator double3(float v); // 0x0000000184DAEDA0-0x0000000184DAEDD0
		public static implicit operator double3(float3 v); // 0x000000018415F9A0-0x000000018415F9E0
		public static double3 operator *(double3 lhs, double3 rhs); // 0x0000000184DB3620-0x0000000184DB3660
		public static double3 operator *(double3 lhs, double rhs); // 0x0000000184DB3600-0x0000000184DB3620
		public static double3 operator *(double lhs, double3 rhs); // 0x0000000184DB35E0-0x0000000184DB3600
		public static double3 operator +(double3 lhs, double3 rhs); // 0x0000000184DB35A0-0x0000000184DB35E0
		public static double3 operator +(double3 lhs, double rhs); // 0x0000000184DB3580-0x0000000184DB35A0
		public static double3 operator -(double3 lhs, double3 rhs); // 0x0000000184DB3680-0x0000000184DB36C0
		public static double3 operator -(double3 lhs, double rhs); // 0x0000000184DB3660-0x0000000184DB3680
		public static double3 operator -(double lhs, double3 rhs); // 0x0000000184DB36C0-0x0000000184DB36F0
		public static double3 operator /(double3 lhs, double3 rhs); // 0x000000018B2803BC-0x000000018B2803F0
		public static double3 operator /(double3 lhs, double rhs); // 0x000000018B2803F0-0x000000018B280410
		public static double3 operator /(double lhs, double3 rhs); // 0x000000018B280410-0x000000018B28043C
		public static bool3 operator <(double3 lhs, double rhs); // 0x000000018B2804F8-0x000000018B28051C
		public static bool3 operator <=(double3 lhs, double3 rhs); // 0x000000018B2804BC-0x000000018B2804F8
		public static bool3 operator >=(double3 lhs, double3 rhs); // 0x000000018B280484-0x000000018B2804BC
		public static double3 operator -(double3 val); // 0x0000000184DB36F0-0x0000000184DB3720
		public static bool3 operator ==(double3 lhs, double rhs); // 0x000000018B28043C-0x000000018B280484
		public bool Equals(double3 rhs); // 0x00000001866A8DA0-0x00000001866A8F30
		public override bool Equals(object o); // 0x000000018B28010C-0x000000018B280180
		public override int GetHashCode(); // 0x000000018B280180-0x000000018B2801A8
		public override string ToString(); // 0x000000018B280258-0x000000018B280318
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B2801A8-0x000000018B280258
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x2 : IEquatable<Unity.Mathematics.double3x2>, IFormattable // TypeDefIndex: 57202
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
	
		// Constructors
		public double3x2(double3 c0, double3 c1); // 0x0000000184DA06E0-0x0000000184DA0710
		public double3x2(double m00, double m01, double m10, double m11, double m20, double m21); // 0x0000000184DB3760-0x0000000184DB37A0
		public double3x2(double v); // 0x0000000184DB3800-0x0000000184DB3830
		public double3x2(bool v); // 0x0000000185F011E4-0x0000000185F012B8
		public double3x2(bool3x2 v); // 0x000000018B28095C-0x000000018B280A60
		public double3x2(int v); // 0x0000000184DB3830-0x0000000184DB3880
		public double3x2(int3x2 v); // 0x0000000185F012B8-0x0000000185F01330
		public double3x2(uint v); // 0x0000000184DB37A0-0x0000000184DB3800
		public double3x2(uint3x2 v); // 0x0000000185F00FEC-0x0000000185F01064
		public double3x2(float v); // 0x0000000184DB3720-0x0000000184DB3760
		public double3x2(float3x2 v); // 0x0000000185F01064-0x0000000185F011E4
	
		// Methods
		public static implicit operator double3x2(int v); // 0x000000018B24EE70-0x000000018B24EE90
		public static implicit operator double3x2(float3x2 v); // 0x000000018B24ED1C-0x000000018B24ED58
		public static double3x2 operator *(double3x2 lhs, double rhs); // 0x000000018B280BB8-0x000000018B280C3C
		public static double3x2 operator +(double3x2 lhs, double3x2 rhs); // 0x000000018B280A60-0x000000018B280B24
		public static double3x2 operator -(double3x2 lhs, double3x2 rhs); // 0x000000018B280C3C-0x000000018B280D00
		public static double3x2 operator /(double3x2 lhs, double rhs); // 0x000000018B280B24-0x000000018B280BB8
		public bool Equals(double3x2 rhs); // 0x00000001866A921C-0x00000001866A928C
		public override bool Equals(object o); // 0x000000018B28051C-0x000000018B280598
		public override int GetHashCode(); // 0x000000018B280598-0x000000018B2805C8
		public override string ToString(); // 0x000000018B28077C-0x000000018B28095C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B2805C8-0x000000018B28077C
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x3 : IEquatable<Unity.Mathematics.double3x3>, IFormattable // TypeDefIndex: 57203
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public static readonly double3x3 identity; // 0x00
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000184DB3AC0-0x0000000184DB3AD0 
	
		// Constructors
		public double3x3(double3 c0, double3 c1, double3 c2); // 0x0000000184DB38E0-0x0000000184DB3920
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22); // 0x0000000184DB3A60-0x0000000184DB3AC0
		public double3x3(double v); // 0x0000000184DB3920-0x0000000184DB3960
		public double3x3(bool v); // 0x0000000185F01698-0x0000000185F0199C
		public double3x3(bool3x3 v); // 0x000000018B281338-0x000000018B2814A4
		public double3x3(int v); // 0x0000000184DB39F0-0x0000000184DB3A60
		public double3x3(int3x3 v); // 0x0000000185F015F0-0x0000000185F01698
		public double3x3(uint v); // 0x0000000184DB3960-0x0000000184DB39F0
		public double3x3(uint3x3 v); // 0x0000000185F01548-0x0000000185F015F0
		public double3x3(float v); // 0x0000000184DB3880-0x0000000184DB38E0
		public double3x3(float3x3 v); // 0x0000000185F01330-0x0000000185F01548
		static double3x3(); // 0x0000000184B6B1D0-0x0000000184B6B2A0
	
		// Methods
		public static double3x3 operator *(double3x3 lhs, double rhs); // 0x000000018B2814A4-0x000000018B281568
		public bool Equals(double3x3 rhs); // 0x000000018B280D94-0x000000018B280E28
		public override bool Equals(object o); // 0x000000018B280D00-0x000000018B280D94
		public override int GetHashCode(); // 0x000000018B280E28-0x000000018B280E6C
		public override string ToString(); // 0x000000018B280E6C-0x000000018B2810F4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B2810F4-0x000000018B281338
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x4 : IEquatable<Unity.Mathematics.double3x4>, IFormattable // TypeDefIndex: 57204
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public double3 c3; // 0x48
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000184DB3AC0-0x0000000184DB3AD0 
	
		// Constructors
		public double3x4(double3 c0, double3 c1, double3 c2, double3 c3); // 0x0000000184DB3AD0-0x0000000184DB3B20
		public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23); // 0x0000000184DB3B20-0x0000000184DB3BA0
		public double3x4(double v); // 0x0000000184DB3CE0-0x0000000184DB3D30
		public double3x4(bool v); // 0x0000000185F01B54-0x0000000185F01CD0
		public double3x4(bool3x4 v); // 0x000000018B281D40-0x000000018B281F18
		public double3x4(int v); // 0x0000000184DB3BA0-0x0000000184DB3C20
		public double3x4(int3x4 v); // 0x0000000185F01A78-0x0000000185F01B54
		public double3x4(uint v); // 0x0000000184DB3C20-0x0000000184DB3CE0
		public double3x4(uint3x4 v); // 0x0000000185F0199C-0x0000000185F01A78
		public double3x4(float v); // 0x0000000184DB3D30-0x0000000184DB3DB0
		public double3x4(float3x4 v); // 0x0000000185F01CD0-0x0000000185F01DAC
	
		// Methods
		public static implicit operator double3x4(int v); // 0x000000018B24F088-0x000000018B24F0B4
		public bool Equals(double3x4 rhs); // 0x000000018B281568-0x000000018B281650
		public override bool Equals(object o); // 0x000000018B281650-0x000000018B2816F0
		public override int GetHashCode(); // 0x000000018B2816F0-0x000000018B28173C
		public override string ToString(); // 0x000000018B281A10-0x000000018B281D40
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28173C-0x000000018B281A10
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double4 : IEquatable<Unity.Mathematics.double4>, IFormattable // TypeDefIndex: 57206
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
		public static readonly double4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyz { get; set; } // 0x0000000184DB3FB0-0x0000000184DB3FD0 0x0000000184DB3490-0x0000000184DB34B0
		public double this[int index] { get => default; set {} } // 0x0000000184DB3530-0x0000000184DB3540 0x0000000184DB4160-0x0000000184DB4170
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57205
		{
		}
	
		// Constructors
		public double4(double x, double y, double z, double w); // 0x0000000184DB3E70-0x0000000184DB3E90
		public double4(double x, double y, double2 zw); // 0x0000000184DB3DF0-0x0000000184DB3E10
		public double4(double x, double2 yz, double w); // 0x0000000184DB3E10-0x0000000184DB3E30
		public double4(double x, double3 yzw); // 0x0000000184DB3E50-0x0000000184DB3E70
		public double4(double2 xy, double z, double w); // 0x0000000184DB3F50-0x0000000184DB3F70
		public double4(double2 xy, double2 zw); // 0x0000000184DB3E30-0x0000000184DB3E50
		public double4(double3 xyz, double w); // 0x0000000184DB3F30-0x0000000184DB3F50
		public double4(double4 xyzw); // 0x0000000184DB3DD0-0x0000000184DB3DF0
		public double4(double v); // 0x0000000184DB3F70-0x0000000184DB3F80
		public double4(bool v); // 0x0000000185F01E20-0x0000000185F01E64
		public double4(bool4 v); // 0x0000000185F01EC8-0x0000000185F02278
		public double4(int v); // 0x0000000184DB3E90-0x0000000184DB3EC0
		public double4(int4 v); // 0x0000000184DB3F10-0x0000000184DB3F30
		public double4(uint v); // 0x0000000184DB3F80-0x0000000184DB3FB0
		public double4(uint4 v); // 0x0000000184DB3EC0-0x0000000184DB3F00
		public double4(half v); // 0x0000000185F01E64-0x0000000185F01EC8
		public double4(half4 v); // 0x0000000185F01DAC-0x0000000185F01E20
		public double4(float v); // 0x0000000184DB3DB0-0x0000000184DB3DD0
		public double4(float4 v); // 0x0000000184DB3F00-0x0000000184DB3F10
	
		// Methods
		public static implicit operator double4(double v); // 0x0000000184DAF080-0x0000000184DAF090
		public static implicit operator double4(int v); // 0x0000000184DAF0E0-0x0000000184DAF120
		public static implicit operator double4(int4 v); // 0x000000018B24F2FC-0x000000018B24F324
		public static implicit operator double4(uint v); // 0x0000000184DAF1A0-0x0000000184DAF1D0
		public static implicit operator double4(uint4 v); // 0x000000018B24F324-0x000000018B24F34C
		public static implicit operator double4(float v); // 0x0000000184DAF090-0x0000000184DAF0B0
		public static implicit operator double4(float4 v); // 0x000000018B24F2B8-0x000000018B24F2E0
		public static double4 operator *(double4 lhs, double4 rhs); // 0x0000000184DB4040-0x0000000184DB4090
		public static double4 operator *(double4 lhs, double rhs); // 0x0000000184DB4020-0x0000000184DB4040
		public static double4 operator *(double lhs, double4 rhs); // 0x0000000184DB4090-0x0000000184DB40B0
		public static double4 operator +(double4 lhs, double4 rhs); // 0x0000000184DB3FD0-0x0000000184DB4020
		public static double4 operator -(double4 lhs, double4 rhs); // 0x0000000184DB40F0-0x0000000184DB4140
		public static double4 operator -(double lhs, double4 rhs); // 0x0000000184DB40B0-0x0000000184DB40F0
		public static double4 operator /(double4 lhs, double4 rhs); // 0x000000018B2822B8-0x000000018B2822FC
		public static double4 operator /(double lhs, double4 rhs); // 0x000000018B2822FC-0x000000018B282334
		public static bool4 operator <(double4 lhs, double rhs); // 0x000000018B2823E0-0x000000018B28240C
		public static bool4 operator >=(double4 lhs, double4 rhs); // 0x000000018B282398-0x000000018B2823E0
		public static double4 operator -(double4 val); // 0x0000000184DB4140-0x0000000184DB4160
		public static bool4 operator ==(double4 lhs, double rhs); // 0x000000018B282334-0x000000018B282398
		public bool Equals(double4 rhs); // 0x000000018B281F8C-0x000000018B281FD4
		public override bool Equals(object o); // 0x000000018B281F18-0x000000018B281F8C
		public override int GetHashCode(); // 0x000000018B281FD4-0x000000018B281FF8
		public override string ToString(); // 0x000000018B281FF8-0x000000018B282164
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B282164-0x000000018B2822B8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x2 : IEquatable<Unity.Mathematics.double4x2>, IFormattable // TypeDefIndex: 57207
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
	
		// Constructors
		public double4x2(double4 c0, double4 c1); // 0x0000000184DB4230-0x0000000184DB4250
		public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31); // 0x0000000184DB4170-0x0000000184DB41C0
		public double4x2(double v); // 0x0000000184DB41C0-0x0000000184DB41F0
		public double4x2(bool v); // 0x0000000185F023C4-0x0000000185F02674
		public double4x2(bool4x2 v); // 0x0000000185F02320-0x0000000185F023C4
		public double4x2(int v); // 0x0000000184DB4250-0x0000000184DB42A0
		public double4x2(int4x2 v); // 0x000000018B282990-0x000000018B2829F4
		public double4x2(uint v); // 0x0000000185F02278-0x0000000185F02320
		public double4x2(uint4x2 v); // 0x000000018B2829F4-0x000000018B282A58
		public double4x2(float v); // 0x0000000184DB41F0-0x0000000184DB4230
		public double4x2(float4x2 v); // 0x000000018B282A58-0x000000018B282ABC
	
		// Methods
		public bool Equals(double4x2 rhs); // 0x000000018B282490-0x000000018B2824F4
		public override bool Equals(object o); // 0x000000018B28240C-0x000000018B282490
		public override int GetHashCode(); // 0x000000018B2824F4-0x000000018B28252C
		public override string ToString(); // 0x000000018B282740-0x000000018B282990
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28252C-0x000000018B282740
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x3 : IEquatable<Unity.Mathematics.double4x3>, IFormattable // TypeDefIndex: 57208
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
	
		// Constructors
		public double4x3(double4 c0, double4 c1, double4 c2); // 0x0000000184DB4450-0x0000000184DB4490
		public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32); // 0x0000000184DB4350-0x0000000184DB43E0
		public double4x3(double v); // 0x0000000184DB42A0-0x0000000184DB42F0
		public double4x3(bool v); // 0x0000000185F027A8-0x0000000185F02960
		public double4x3(bool4x3 v); // 0x0000000185F026D0-0x0000000185F027A8
		public double4x3(int v); // 0x0000000184DB43E0-0x0000000184DB4450
		public double4x3(int4x3 v); // 0x000000018B2832BC-0x000000018B28334C
		public double4x3(uint v); // 0x0000000185F02674-0x0000000185F026D0
		public double4x3(uint4x3 v); // 0x000000018B28334C-0x000000018B2833DC
		public double4x3(float v); // 0x0000000184DB42F0-0x0000000184DB4350
		public double4x3(float4x3 v); // 0x000000018B28322C-0x000000018B2832BC
	
		// Methods
		public static implicit operator double4x3(int v); // 0x000000018B24F55C-0x000000018B24F588
		public static implicit operator double4x3(float4x3 v); // 0x000000018B24F660-0x000000018B24F6B0
		public static double4x3 operator *(double4x3 lhs, double4x3 rhs); // 0x000000018B2833DC-0x000000018B2834E4
		public bool Equals(double4x3 rhs); // 0x000000018B282ABC-0x000000018B282B3C
		public override bool Equals(object o); // 0x000000018B282B3C-0x000000018B282BDC
		public override int GetHashCode(); // 0x000000018B282BDC-0x000000018B282C28
		public override string ToString(); // 0x000000018B282EFC-0x000000018B28322C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B282C28-0x000000018B282EFC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x4 : IEquatable<Unity.Mathematics.double4x4>, IFormattable // TypeDefIndex: 57209
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
		public double4 c3; // 0x60
		public static readonly double4x4 identity; // 0x00
		public static readonly double4x4 zero; // 0x80
	
		// Constructors
		public double4x4(double4 c0, double4 c1, double4 c2, double4 c3); // 0x0000000184DB4560-0x0000000184DB45B0
		public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33); // 0x0000000184A30010-0x0000000184A30210
		public double4x4(double v); // 0x0000000184DB4500-0x0000000184DB4560
		public double4x4(bool v); // 0x0000000185F02960-0x0000000185F029C8
		public double4x4(bool4x4 v); // 0x0000000185F02A40-0x0000000185F02C08
		public double4x4(int v); // 0x0000000184DB45B0-0x0000000184DB4640
		public double4x4(int4x4 v); // 0x000000018B283FA8-0x000000018B28405C
		public double4x4(uint v); // 0x0000000185F029C8-0x0000000185F02A40
		public double4x4(uint4x4 v); // 0x000000018B283EF4-0x000000018B283FA8
		public double4x4(float v); // 0x0000000184DB4490-0x0000000184DB4500
		public double4x4(float4x4 v); // 0x000000018B283E40-0x000000018B283EF4
		static double4x4(); // 0x0000000184A2FEE0-0x0000000184A30010
	
		// Methods
		public static implicit operator double4x4(float4x4 v); // 0x000000018B24F808-0x000000018B24F864
		public bool Equals(double4x4 rhs); // 0x000000018B2834E4-0x000000018B283588
		public override bool Equals(object o); // 0x000000018B283588-0x000000018B283640
		public override int GetHashCode(); // 0x000000018B283640-0x000000018B28369C
		public override string ToString(); // 0x000000018B283A30-0x000000018B283E40
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28369C-0x000000018B283A30
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2 : IEquatable<Unity.Mathematics.float2>, IFormattable // TypeDefIndex: 57211
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public static readonly float2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get; } // 0x0000000184DB4750-0x0000000184DB4770 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; } // 0x0000000184D889F0-0x0000000184D88A10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get; } // 0x0000000184DB4770-0x0000000184DB4790 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57210
		{
		}
	
		// Constructors
		public float2(float x, float y); // 0x0000000184D87A10-0x0000000184D87A20
		public float2(float2 xy); // 0x0000000184DB4680-0x0000000184DB46A0
		public float2(float v); // 0x0000000184DB4640-0x0000000184DB4650
		public float2(bool v); // 0x000000018B284218-0x000000018B284234
		public float2(bool2 v); // 0x0000000185F02C08-0x0000000185F02CC0
		public float2(int v); // 0x0000000184DB46F0-0x0000000184DB4710
		public float2(int2 v); // 0x0000000184DB46D0-0x0000000184DB46F0
		public float2(uint v); // 0x0000000184DB46A0-0x0000000184DB46D0
		public float2(uint2 v); // 0x0000000184DB4650-0x0000000184DB4680
		public float2(half v); // 0x000000018B284234-0x000000018B284260
		public float2(half2 v); // 0x000000018B284260-0x000000018B284290
		public float2(double v); // 0x0000000184DB4710-0x0000000184DB4730
		public float2(double2 v); // 0x0000000184DB4730-0x0000000184DB4750
	
		// Methods
		public static implicit operator float2(float v); // 0x0000000184D8B720-0x0000000184D8B730
		public static implicit operator float2(int v); // 0x0000000184DAF4E0-0x0000000184DAF500
		public static implicit operator float2(int2 v); // 0x0000000184DAF500-0x0000000184DAF520
		public static implicit operator float2(uint v); // 0x0000000184DAF550-0x0000000184DAF580
		public static implicit operator float2(uint2 v); // 0x0000000184DAF520-0x0000000184DAF550
		public static explicit operator float2(double v); // 0x0000000184DAF580-0x0000000184DAF5A0
		public static explicit operator float2(double2 v); // 0x0000000184DAF4B0-0x0000000184DAF4D0
		public static float2 operator *(float2 lhs, float2 rhs); // 0x0000000184DA8070-0x0000000184DA80B0
		public static float2 operator *(float2 lhs, float rhs); // 0x0000000184DA8040-0x0000000184DA8070
		public static float2 operator *(float lhs, float2 rhs); // 0x0000000184DB47E0-0x0000000184DB4810
		public static float2 operator +(float2 lhs, float2 rhs); // 0x0000000184DA7FD0-0x0000000184DA8010
		public static float2 operator +(float2 lhs, float rhs); // 0x0000000184DA8010-0x0000000184DA8040
		public static float2 operator -(float2 lhs, float2 rhs); // 0x0000000184DA80E0-0x0000000184DA8120
		public static float2 operator -(float2 lhs, float rhs); // 0x0000000184DA80B0-0x0000000184DA80E0
		public static float2 operator -(float lhs, float2 rhs); // 0x0000000184DB4810-0x0000000184DB4830
		public static float2 operator /(float2 lhs, float2 rhs); // 0x000000018AAEC45C-0x000000018AAEC490
		public static float2 operator /(float2 lhs, float rhs); // 0x000000018AAEC948-0x000000018AAEC96C
		public static float2 operator /(float lhs, float2 rhs); // 0x000000018B284290-0x000000018B2842B0
		public static float2 operator %(float2 lhs, float rhs); // 0x0000000184DB4790-0x0000000184DB47E0
		public static bool2 operator <(float2 lhs, float rhs); // 0x000000018B284358-0x000000018B28437C
		public static bool2 operator <=(float2 lhs, float2 rhs); // 0x000000018B284320-0x000000018B284358
		public static bool2 operator >=(float2 lhs, float2 rhs); // 0x000000018B2842E8-0x000000018B284320
		public static float2 operator -(float2 val); // 0x0000000184DB4830-0x0000000184DB4860
		public static bool2 operator ==(float2 lhs, float rhs); // 0x000000018B2842B0-0x000000018B2842E8
		public bool Equals(float2 rhs); // 0x000000018AAEC490-0x000000018AAEC4B8
		public override bool Equals(object o); // 0x000000018B28405C-0x000000018B2840CC
		public override int GetHashCode(); // 0x000000018B2840CC-0x000000018B284100
		public override string ToString(); // 0x000000018B284188-0x000000018B284218
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B284100-0x000000018B284188
		public static implicit operator Vector2(float2 v); // 0x0000000184DA7CB0-0x0000000184DA7CD0
		public static implicit operator float2(Vector2 v); // 0x0000000184DA7CB0-0x0000000184DA7CD0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x2 : IEquatable<Unity.Mathematics.float2x2>, IFormattable // TypeDefIndex: 57212
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public static readonly float2x2 identity; // 0x00
	
		// Constructors
		public float2x2(float2 c0, float2 c1); // 0x0000000184D861B0-0x0000000184D861C0
		public float2x2(float m00, float m01, float m10, float m11); // 0x0000000184DB4940-0x0000000184DB4960
		public float2x2(float v); // 0x0000000184DB48F0-0x0000000184DB4910
		public float2x2(bool v); // 0x0000000185F02CC0-0x0000000185F02E7C
		public float2x2(bool2x2 v); // 0x000000018B284700-0x000000018B28477C
		public float2x2(int v); // 0x0000000184DB4910-0x0000000184DB4940
		public float2x2(int2x2 v); // 0x0000000184DB49A0-0x0000000184DB49E0
		public float2x2(uint v); // 0x0000000184DB49E0-0x0000000184DB4A30
		public float2x2(uint2x2 v); // 0x0000000184DB4860-0x0000000184DB48C0
		public float2x2(double v); // 0x0000000184DB48C0-0x0000000184DB48F0
		public float2x2(double2x2 v); // 0x0000000184DB4960-0x0000000184DB49A0
		static float2x2(); // 0x0000000184D27400-0x0000000184D27470
	
		// Methods
		public static float2x2 operator *(float2x2 lhs, float rhs); // 0x000000018B28477C-0x000000018B2847E8
		public bool Equals(float2x2 rhs); // 0x000000018B28437C-0x000000018B2843B8
		public override bool Equals(object o); // 0x000000018B2843B8-0x000000018B284424
		public override int GetHashCode(); // 0x000000018B284424-0x000000018B284440
		public override string ToString(); // 0x000000018B284594-0x000000018B284700
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B284440-0x000000018B284594
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x3 : IEquatable<Unity.Mathematics.float2x3>, IFormattable // TypeDefIndex: 57213
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public float2 c2; // 0x10
	
		// Constructors
		public float2x3(float2 c0, float2 c1, float2 c2); // 0x0000000184D8C0D0-0x0000000184D8C0E0
		public float2x3(float m00, float m01, float m02, float m10, float m11, float m12); // 0x0000000184DB4B80-0x0000000184DB4BB0
		public float2x3(float v); // 0x0000000184DB4C00-0x0000000184DB4C20
		public float2x3(bool v); // 0x0000000185F02E7C-0x0000000185F02FFC
		public float2x3(bool2x3 v); // 0x000000018B284C94-0x000000018B284D4C
		public float2x3(int v); // 0x0000000184DB4C90-0x0000000184DB4CE0
		public float2x3(int2x3 v); // 0x0000000184DB4B20-0x0000000184DB4B80
		public float2x3(uint v); // 0x0000000184DB4C20-0x0000000184DB4C90
		public float2x3(uint2x3 v); // 0x0000000184DB4A90-0x0000000184DB4B20
		public float2x3(double v); // 0x0000000184DB4BB0-0x0000000184DB4C00
		public float2x3(double2x3 v); // 0x0000000184DB4A30-0x0000000184DB4A90
	
		// Methods
		public bool Equals(float2x3 rhs); // 0x000000018B28485C-0x000000018B2848D8
		public override bool Equals(object o); // 0x000000018B2847E8-0x000000018B28485C
		public override int GetHashCode(); // 0x000000018B2848D8-0x000000018B284900
		public override string ToString(); // 0x000000018B284900-0x000000018B284AE0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B284AE0-0x000000018B284C94
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x4 : IEquatable<Unity.Mathematics.float2x4>, IFormattable // TypeDefIndex: 57214
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public float2 c2; // 0x10
		public float2 c3; // 0x18
	
		// Constructors
		public float2x4(float2 c0, float2 c1, float2 c2, float2 c3); // 0x0000000184D8BCB0-0x0000000184D8BCD0
		public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13); // 0x0000000184DB4CE0-0x0000000184DB4D30
		public float2x4(float v); // 0x0000000184DB4DA0-0x0000000184DB4DC0
		public float2x4(bool v); // 0x0000000185F02FFC-0x0000000185F0316C
		public float2x4(bool2x4 v); // 0x000000018B2852D0-0x000000018B2853CC
		public float2x4(int v); // 0x0000000184DB5010-0x0000000184DB5070
		public float2x4(int2x4 v); // 0x0000000184DB4DC0-0x0000000184DB4E40
		public float2x4(uint v); // 0x0000000184DB4F70-0x0000000184DB5010
		public float2x4(uint2x4 v); // 0x0000000184DB4E40-0x0000000184DB4F00
		public float2x4(double v); // 0x0000000184DB4F00-0x0000000184DB4F70
		public float2x4(double2x4 v); // 0x0000000184DB4D30-0x0000000184DB4DA0
	
		// Methods
		public bool Equals(float2x4 rhs); // 0x000000018B284D4C-0x000000018B284DD4
		public override bool Equals(object o); // 0x000000018B284DD4-0x000000018B284E48
		public override int GetHashCode(); // 0x000000018B284E48-0x000000018B284E6C
		public override string ToString(); // 0x000000018B285080-0x000000018B2852D0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B284E6C-0x000000018B285080
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float3 : IEquatable<Unity.Mathematics.float3>, IFormattable // TypeDefIndex: 57216
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public static readonly float3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx { get; } // 0x0000000184DB5230-0x0000000184DB5250 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy { get; } // 0x0000000184DB5250-0x0000000184DB5270 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxz { get; } // 0x0000000184DB5270-0x0000000184DB5290 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx { get; } // 0x0000000184DB52B0-0x0000000184DB52D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy { get; } // 0x0000000184DB52D0-0x0000000184DB52F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyz { get; } // 0x0000000184DB52F0-0x0000000184DB5310 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzx { get; } // 0x0000000184DB5330-0x0000000184DB5350 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzy { get; } // 0x0000000184DB5350-0x0000000184DB5370 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get; } // 0x0000000184DB5370-0x0000000184DB5390 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx { get; } // 0x0000000184DB53B0-0x0000000184DB53D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get; } // 0x0000000184DB4750-0x0000000184DB4770 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxz { get; } // 0x0000000184DB53D0-0x0000000184DB53F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx { get; } // 0x0000000184DB5410-0x0000000184DB5430 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy { get; } // 0x0000000184DB5430-0x0000000184DB5450 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyz { get; } // 0x0000000184DB5450-0x0000000184DB5470 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get; } // 0x0000000184064E30-0x0000000184064E50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzy { get; } // 0x0000000184DB5470-0x0000000184DB5490 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzz { get; } // 0x0000000184DB5490-0x0000000184DB54B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxx { get; } // 0x0000000184DB54D0-0x0000000184DB54F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxy { get; } // 0x0000000184DB54F0-0x0000000184DB5510 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get; } // 0x0000000184DB5510-0x0000000184DB5530 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyx { get; } // 0x0000000184DB5550-0x0000000184DB5570 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyy { get; } // 0x0000000184DB5570-0x0000000184DB5590 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyz { get; } // 0x0000000184DB5590-0x0000000184DB55B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzx { get; } // 0x0000000184DB55D0-0x0000000184DB55F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzy { get; } // 0x0000000184DB55F0-0x0000000184DB5610 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzz { get; } // 0x0000000184DB5610-0x0000000184DB5630 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx { get; } // 0x0000000184DB5650-0x0000000184DB5670 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy { get; } // 0x0000000184DB5670-0x0000000184DB5690 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxz { get; } // 0x0000000184DB5690-0x0000000184DB56B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx { get; } // 0x0000000184DB56D0-0x0000000184DB56F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy { get; } // 0x0000000184DB56F0-0x0000000184DB5710 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyz { get; } // 0x0000000184DB5710-0x0000000184DB5730 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzx { get; } // 0x0000000184DB5750-0x0000000184DB5770 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzy { get; } // 0x0000000184DB5770-0x0000000184DB5790 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzz { get; } // 0x0000000184DB5790-0x0000000184DB57B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx { get; } // 0x0000000184DB57F0-0x0000000184DB5810 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy { get; } // 0x0000000184DB5810-0x0000000184DB5830 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxz { get; } // 0x0000000184DB5830-0x0000000184DB5850 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx { get; } // 0x0000000184DB5860-0x0000000184DB5880 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy { get; } // 0x0000000184DB5880-0x0000000184DB58A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyz { get; } // 0x0000000184DB58A0-0x0000000184DB58C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzx { get; } // 0x0000000184DB58E0-0x0000000184DB5900 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzy { get; } // 0x0000000184DB5900-0x0000000184DB5920 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzz { get; } // 0x0000000184DB5920-0x0000000184DB5940 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxx { get; } // 0x0000000184DB5960-0x0000000184DB5980 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get; } // 0x0000000184064E10-0x0000000184064E30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get; } // 0x0000000184064DF0-0x0000000184064E10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyx { get; } // 0x0000000184DB59A0-0x0000000184DB59C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyy { get; } // 0x0000000184DB59C0-0x0000000184DB59E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyz { get; } // 0x0000000184DB59E0-0x0000000184DB5A00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzx { get; } // 0x0000000184DB5A20-0x0000000184DB5A40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzy { get; } // 0x0000000184DB5A40-0x0000000184DB5A60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzz { get; } // 0x0000000184DB5A60-0x0000000184DB5A80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxx { get; } // 0x0000000184DB5AC0-0x0000000184DB5AE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxy { get; } // 0x0000000184DB5AE0-0x0000000184DB5B00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxz { get; } // 0x0000000184DB5B00-0x0000000184DB5B20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyx { get; } // 0x0000000184DB5B40-0x0000000184DB5B60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get; } // 0x00000001840B34F0-0x00000001840B3510 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get; } // 0x0000000184064DD0-0x0000000184064DF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzx { get; } // 0x0000000184DB5B80-0x0000000184DB5BA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzy { get; } // 0x0000000184DB5BA0-0x0000000184DB5BC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzz { get; } // 0x0000000184DB5BC0-0x0000000184DB5BE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxx { get; } // 0x0000000184DB5C20-0x0000000184DB5C40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxy { get; } // 0x0000000184DB5C40-0x0000000184DB5C60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxz { get; } // 0x0000000184DB5C60-0x0000000184DB5C80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyx { get; } // 0x0000000184DB5CA0-0x0000000184DB5CC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyy { get; } // 0x0000000184DB5CC0-0x0000000184DB5CE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyz { get; } // 0x0000000184DB5CE0-0x0000000184DB5D00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzx { get; } // 0x0000000184DB5D20-0x0000000184DB5D40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzy { get; } // 0x0000000184DB5D40-0x0000000184DB5D60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzz { get; } // 0x0000000184DB5D60-0x0000000184DB5D80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxx { get; } // 0x0000000184DB5DC0-0x0000000184DB5DE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxy { get; } // 0x0000000184DB5DE0-0x0000000184DB5E00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxz { get; } // 0x0000000184DB5E00-0x0000000184DB5E20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyx { get; } // 0x0000000184DB5E40-0x0000000184DB5E60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyy { get; } // 0x0000000184DB5E60-0x0000000184DB5E80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz { get; } // 0x0000000184DB5E80-0x0000000184DB5EA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzx { get; } // 0x0000000184DB5EB0-0x0000000184DB5ED0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzy { get; } // 0x0000000184DB5ED0-0x0000000184DB5EF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzz { get; } // 0x0000000184DB5EF0-0x0000000184DB5F10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get; } // 0x0000000184DB5220-0x0000000184DB5230 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy { get; } // 0x0000000184DB5290-0x0000000184DB52B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxz { get; } // 0x0000000184DB5310-0x0000000184DB5330 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx { get; } // 0x0000000184DB5390-0x0000000184DB53B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy { get; } // 0x0000000184DB53F0-0x0000000184DB5410 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get; set; } // 0x0000000184D88970-0x0000000184D88990 0x0000000184D88F40-0x0000000184D88F60
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzx { get; } // 0x0000000184DB54B0-0x0000000184DB54D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzy { get; set; } // 0x0000000184DB5530-0x0000000184DB5550 0x0000000184DB60E0-0x0000000184DB6100
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzz { get; } // 0x0000000184DB55B0-0x0000000184DB55D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx { get; } // 0x0000000184DB5630-0x0000000184DB5650 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy { get; } // 0x0000000184DB56B0-0x0000000184DB56D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxz { get; set; } // 0x0000000184DB5730-0x0000000184DB5750 0x0000000184DB6120-0x0000000184DB6140
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx { get; } // 0x0000000184DB57D0-0x0000000184DB57F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy { get; } // 0x0000000184DB5850-0x0000000184DB5860 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyz { get; } // 0x0000000184DB58C0-0x0000000184DB58E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get; set; } // 0x0000000184DB5940-0x0000000184DB5960 0x0000000184DB6160-0x0000000184DB6180
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzy { get; } // 0x0000000184DB5980-0x0000000184DB59A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzz { get; } // 0x0000000184DB5A00-0x0000000184DB5A20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxx { get; } // 0x0000000184DB5AA0-0x0000000184DB5AC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxy { get; set; } // 0x0000000184DB5B20-0x0000000184DB5B40 0x0000000184DB61A0-0x0000000184DB61C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxz { get; } // 0x0000000184DB5B60-0x0000000184DB5B80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyx { get; set; } // 0x0000000184DB5C00-0x0000000184DB5C20 0x0000000184DB61E0-0x0000000184DB6200
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyy { get; } // 0x0000000184DB5C80-0x0000000184DB5CA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyz { get; } // 0x0000000184DB5D00-0x0000000184DB5D20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzx { get; } // 0x0000000184DB5DA0-0x0000000184DB5DC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzy { get; } // 0x0000000184DB5E20-0x0000000184DB5E40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzz { get; } // 0x0000000184DB5EA0-0x0000000184DB5EB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get; } // 0x0000000184DB5210-0x0000000184DB5220 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; set; } // 0x0000000184D889F0-0x0000000184D88A10 0x0000000184DB4680-0x0000000184DB46A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get; set; } // 0x0000000184D88A40-0x0000000184D88A60 0x0000000184DB60C0-0x0000000184DB60E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get; set; } // 0x0000000184DB4770-0x0000000184DB4790 0x0000000184DB6100-0x0000000184DB6120
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get; } // 0x0000000184DB57B0-0x0000000184DB57D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz { get; set; } // 0x0000000184D8B880-0x0000000184D8B8A0 0x0000000184DB6140-0x0000000184DB6160
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zx { get; set; } // 0x0000000184DB5A80-0x0000000184DB5AA0 0x0000000184DB6180-0x0000000184DB61A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zy { get; set; } // 0x0000000184DB5BE0-0x0000000184DB5C00 0x0000000184DB61C0-0x0000000184DB61E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zz { get; } // 0x0000000184DB5D80-0x0000000184DB5DA0 
		public float this[int index] { get => default; set {} } // 0x0000000184DB5200-0x0000000184DB5210 0x0000000184DB60B0-0x0000000184DB60C0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57215
		{
		}
	
		// Constructors
		public float3(float x, float y, float z); // 0x0000000184D88F30-0x0000000184D88F40
		public float3(float x, float2 yz); // 0x0000000184DB51B0-0x0000000184DB51D0
		public float3(float2 xy, float z); // 0x0000000184DB50E0-0x0000000184DB5100
		public float3(float3 xyz); // 0x0000000184D88F40-0x0000000184D88F60
		public float3(float v); // 0x0000000184DB5170-0x0000000184DB5180
		public float3(bool v); // 0x0000000185F0316C-0x0000000185F031A0
		public float3(bool3 v); // 0x0000000185F031A0-0x0000000185F031DC
		public float3(int v); // 0x0000000184DB5070-0x0000000184DB50A0
		public float3(int3 v); // 0x0000000184DB5180-0x0000000184DB51B0
		public float3(uint v); // 0x0000000184DB5100-0x0000000184DB5140
		public float3(uint3 v); // 0x0000000184DB50A0-0x0000000184DB50E0
		public float3(half v); // 0x000000018B285610-0x000000018B28564C
		public float3(half3 v); // 0x000000018B2855D4-0x000000018B285610
		public float3(double v); // 0x0000000184DB5140-0x0000000184DB5170
		public float3(double3 v); // 0x0000000184DB51D0-0x0000000184DB5200
	
		// Methods
		public static implicit operator float3(float v); // 0x0000000184D8B860-0x0000000184D8B880
		public static explicit operator float3(bool v); // 0x000000018B251E8C-0x000000018B251EA8
		public static explicit operator float3(bool3 v); // 0x000000018B251F30-0x000000018B251F60
		public static implicit operator float3(int v); // 0x0000000184DAF610-0x0000000184DAF640
		public static implicit operator float3(int3 v); // 0x0000000184DAF7A0-0x0000000184DAF7F0
		public static implicit operator float3(uint v); // 0x0000000184DAF760-0x0000000184DAF7A0
		public static implicit operator float3(uint3 v); // 0x0000000184DAF6D0-0x0000000184DAF730
		public static implicit operator float3(half v); // 0x000000018B251EA8-0x000000018B251EE4
		public static implicit operator float3(half3 v); // 0x000000018B251EE4-0x000000018B251F30
		public static explicit operator float3(double v); // 0x0000000184DAF640-0x0000000184DAF670
		public static explicit operator float3(double3 v); // 0x0000000184DAF5D0-0x0000000184DAF610
		public static float3 operator *(float3 lhs, float3 rhs); // 0x0000000184D886A0-0x0000000184D886E0
		public static float3 operator *(float3 lhs, float rhs); // 0x00000001830E7A60-0x00000001830E7AD0
		public static float3 operator *(float lhs, float3 rhs); // 0x00000001830E9530-0x00000001830E9560
		public static float3 operator +(float3 lhs, float3 rhs); // 0x00000001830E9EA0-0x00000001830E9EE0
		public static float3 operator +(float3 lhs, float rhs); // 0x0000000184118DE0-0x0000000184118E10
		public static float3 operator +(float lhs, float3 rhs); // 0x0000000184DB5F10-0x0000000184DB5F40
		public static float3 operator -(float3 lhs, float3 rhs); // 0x00000001830E9560-0x00000001830E95A0
		public static float3 operator -(float3 lhs, float rhs); // 0x0000000184118E10-0x0000000184118E40
		public static float3 operator -(float lhs, float3 rhs); // 0x0000000184DB6080-0x0000000184DB60B0
		public static float3 operator /(float3 lhs, float3 rhs); // 0x000000018AAED088-0x000000018AAED0BC
		public static float3 operator /(float3 lhs, float rhs); // 0x000000018AADD2FC-0x000000018AADD328
		public static float3 operator /(float lhs, float3 rhs); // 0x000000018B28564C-0x000000018B285678
		public static float3 operator %(float3 lhs, float3 rhs); // 0x0000000184DAFC00-0x0000000184DAFC70
		public static float3 operator %(float3 lhs, float rhs); // 0x0000000184DB6020-0x0000000184DB6080
		public static float3 operator %(float lhs, float3 rhs); // 0x0000000184DB5FC0-0x0000000184DB6020
		public static float3 operator ++(float3 val); // 0x0000000184DB5F80-0x0000000184DB5FC0
		public static float3 operator --(float3 val); // 0x0000000184DB5F40-0x0000000184DB5F80
		public static bool3 operator <(float3 lhs, float3 rhs); // 0x000000018B28598C-0x000000018B2859C0
		public static bool3 operator <(float3 lhs, float rhs); // 0x000000018B2859C0-0x000000018B287BE0
		public static bool3 operator <(float lhs, float3 rhs); // 0x000000018B28595C-0x000000018B28598C
		public static bool3 operator <=(float3 lhs, float3 rhs); // 0x000000018B2858C8-0x000000018B285900
		public static bool3 operator <=(float3 lhs, float rhs); // 0x000000018B285934-0x000000018B28595C
		public static bool3 operator <=(float lhs, float3 rhs); // 0x000000018B285900-0x000000018B285934
		public static bool3 operator >(float3 lhs, float3 rhs); // 0x000000018B285788-0x000000018B2857BC
		public static bool3 operator >(float3 lhs, float rhs); // 0x000000018B2857E0-0x000000018B28580C
		public static bool3 operator >(float lhs, float3 rhs); // 0x000000018B2857BC-0x000000018B2857E0
		public static bool3 operator >=(float3 lhs, float3 rhs); // 0x000000018B2856FC-0x000000018B285730
		public static bool3 operator >=(float3 lhs, float rhs); // 0x000000018B285730-0x000000018B285760
		public static bool3 operator >=(float lhs, float3 rhs); // 0x000000018B285760-0x000000018B285788
		public static float3 operator -(float3 val); // 0x0000000183F48480-0x0000000183F484C0
		public static float3 operator +(float3 val); // 0x0000000184D88970-0x0000000184D88990
		public static bool3 operator ==(float3 lhs, float3 rhs); // 0x000000018B285678-0x000000018B2856C0
		public static bool3 operator ==(float3 lhs, float rhs); // 0x0000000185F031DC-0x0000000185F032D0
		public static bool3 operator ==(float lhs, float3 rhs); // 0x000000018B2856C0-0x000000018B2856FC
		public static bool3 operator !=(float3 lhs, float3 rhs); // 0x000000018B285844-0x000000018B285888
		public static bool3 operator !=(float3 lhs, float rhs); // 0x000000018B285888-0x000000018B2858C8
		public static bool3 operator !=(float lhs, float3 rhs); // 0x000000018B28580C-0x000000018B285844
		public bool Equals(float3 rhs); // 0x00000001830F9620-0x00000001830F9650
		public override bool Equals(object o); // 0x000000018B2853CC-0x000000018B285440
		public override int GetHashCode(); // 0x000000018B285440-0x000000018B285464
		public override string ToString(); // 0x000000018B285464-0x000000018B285524
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B285524-0x000000018B2855D4
		public static implicit operator Vector3(float3 v); // 0x0000000184D88970-0x0000000184D88990
		public static implicit operator float3(Vector3 v); // 0x0000000184D88970-0x0000000184D88990
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x2 : IEquatable<Unity.Mathematics.float3x2>, IFormattable // TypeDefIndex: 57217
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
	
		// Constructors
		public float3x2(float3 c0, float3 c1); // 0x0000000184D871E0-0x0000000184D87200
		public float3x2(float m00, float m01, float m10, float m11, float m20, float m21); // 0x0000000184DB6270-0x0000000184DB62A0
		public float3x2(float v); // 0x0000000184DB6250-0x0000000184DB6270
		public float3x2(bool v); // 0x0000000185F032D0-0x0000000185F033FC
		public float3x2(bool3x2 v); // 0x000000018B28B60C-0x000000018B28B6DC
		public float3x2(int v); // 0x0000000184DB6200-0x0000000184DB6250
		public float3x2(int3x2 v); // 0x0000000185F03470-0x0000000185F034E4
		public float3x2(uint v); // 0x0000000184DB62A0-0x0000000184DB6310
		public float3x2(uint3x2 v); // 0x0000000185F033FC-0x0000000185F03470
		public float3x2(double v); // 0x0000000184DB6310-0x0000000184DB6360
		public float3x2(double3x2 v); // 0x000000018B28B594-0x000000018B28B60C
	
		// Methods
		public static float3x2 operator *(float3x2 lhs, float rhs); // 0x000000018B28B6DC-0x000000018B28B760
		public bool Equals(float3x2 rhs); // 0x000000018B28B174-0x000000018B28B1D8
		public override bool Equals(object o); // 0x000000018B28B100-0x000000018B28B174
		public override int GetHashCode(); // 0x000000018B28B1D8-0x000000018B28B200
		public override string ToString(); // 0x000000018B28B3B4-0x000000018B28B594
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28B200-0x000000018B28B3B4
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x3 : IEquatable<Unity.Mathematics.float3x3>, IFormattable // TypeDefIndex: 57218
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public static readonly float3x3 identity; // 0x00
		public static readonly float3x3 zero; // 0x24
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000184DB6580-0x0000000184DB6590 
	
		// Constructors
		public float3x3(float3 c0, float3 c1, float3 c2); // 0x0000000184D8C690-0x0000000184D8C6D0
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22); // 0x0000000184DB63D0-0x0000000184DB6430
		public float3x3(float v); // 0x0000000184DB64E0-0x0000000184DB6510
		public float3x3(bool v); // 0x0000000185F03630-0x0000000185F036AC
		public float3x3(bool3x3 v); // 0x000000018B28BE08-0x000000018B28BF2C
		public float3x3(int v); // 0x0000000184DB6360-0x0000000184DB63D0
		public float3x3(int3x3 v); // 0x0000000185F034E4-0x0000000185F03630
		public float3x3(uint v); // 0x0000000184DB6430-0x0000000184DB64E0
		public float3x3(uint3x3 v); // 0x0000000185F036AC-0x0000000185F03878
		public float3x3(double v); // 0x0000000184DB6510-0x0000000184DB6580
		public float3x3(double3x3 v); // 0x000000018B28BD60-0x000000018B28BE08
		public float3x3(float4x4 f4x4); // 0x00000001834C93C0-0x00000001834C9420
		public float3x3(quaternion q); // 0x00000001830E9010-0x00000001830E9510
		static float3x3(); // 0x0000000184CA6B90-0x0000000184CA6C40
	
		// Methods
		public static implicit operator float3x3(int v); // 0x000000018B252214-0x000000018B252234
		public static float3x3 operator *(float3x3 lhs, float rhs); // 0x000000018B28C02C-0x000000018B28C0E4
		public static float3x3 operator +(float3x3 lhs, float3x3 rhs); // 0x000000018B28BF2C-0x000000018B28C02C
		public bool Equals(float3x3 rhs); // 0x000000018B28B7DC-0x000000018B28B868
		public override bool Equals(object o); // 0x000000018B28B760-0x000000018B28B7DC
		public override int GetHashCode(); // 0x000000018B28B868-0x000000018B28B894
		public override string ToString(); // 0x000000018B28B894-0x000000018B28BB1C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28BB1C-0x000000018B28BD60
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x4 : IEquatable<Unity.Mathematics.float3x4>, IFormattable // TypeDefIndex: 57219
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public float3 c3; // 0x24
		public static readonly float3x4 zero; // 0x00
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000184DB6580-0x0000000184DB6590 
	
		// Constructors
		public float3x4(float3 c0, float3 c1, float3 c2, float3 c3); // 0x0000000184DB65D0-0x0000000184DB6620
		public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23); // 0x0000000184DB6820-0x0000000184DB68A0
		public float3x4(float v); // 0x0000000184DB6590-0x0000000184DB65D0
		public float3x4(bool v); // 0x0000000185F0394C-0x0000000185F039EC
		public float3x4(bool3x4 v); // 0x000000018B28C934-0x000000018B28CAAC
		public float3x4(int v); // 0x0000000184DB6790-0x0000000184DB6820
		public float3x4(int3x4 v); // 0x0000000185F03878-0x0000000185F0394C
		public float3x4(uint v); // 0x0000000184DB66B0-0x0000000184DB6790
		public float3x4(uint3x4 v); // 0x0000000185F039EC-0x0000000185F03D18
		public float3x4(double v); // 0x0000000184DB6620-0x0000000184DB66B0
		public float3x4(double3x4 v); // 0x000000018B28C858-0x000000018B28C934
	
		// Methods
		public static implicit operator float3x4(int v); // 0x000000018B25243C-0x000000018B25245C
		public bool Equals(float3x4 rhs); // 0x000000018B28C160-0x000000018B28C224
		public override bool Equals(object o); // 0x000000018B28C0E4-0x000000018B28C160
		public override int GetHashCode(); // 0x000000018B28C224-0x000000018B28C254
		public override string ToString(); // 0x000000018B28C528-0x000000018B28C858
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28C254-0x000000018B28C528
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float4 : IEquatable<Unity.Mathematics.float4>, IFormattable // TypeDefIndex: 57221
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		public static readonly float4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get; } // 0x0000000184DB5370-0x0000000184DB5390 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get; } // 0x0000000184064E30-0x0000000184064E50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get; } // 0x0000000184DB5510-0x0000000184DB5530 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyww { get; } // 0x0000000184DB6BD0-0x0000000184DB6BF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get; } // 0x0000000184064E10-0x0000000184064E30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get; } // 0x0000000184064DF0-0x0000000184064E10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxw { get; } // 0x0000000184DB6BF0-0x0000000184DB6C10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get; } // 0x00000001840B34F0-0x00000001840B3510 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get; } // 0x0000000184064DD0-0x0000000184064DF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxy { get; } // 0x00000001834C98E0-0x00000001834C9970 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyx { get; } // 0x00000001834C98C0-0x00000001834C98E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx { get; } // 0x0000000184DB6B10-0x0000000184DB6B30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww { get; } // 0x0000000184DB6AF0-0x0000000184DB6B10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get; } // 0x0000000184DB5220-0x0000000184DB5230 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get; set; } // 0x0000000184D88970-0x0000000184D88990 0x0000000184D88F40-0x0000000184D88F60
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyw { get; } // 0x0000000184DB6B70-0x0000000184DB6B90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxw { get; } // 0x0000000184DB6BB0-0x0000000184DB6BD0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get; } // 0x0000000184DB5940-0x0000000184DB5960 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx { get; } // 0x0000000184DB6C10-0x0000000184DB6C30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy { get; } // 0x0000000184DB6B50-0x0000000184DB6B70 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 www { get; } // 0x0000000184DB6AE0-0x0000000184DB6AF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get; } // 0x0000000184DB5210-0x0000000184DB5220 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; set; } // 0x0000000184D889F0-0x0000000184D88A10 0x0000000184DB4680-0x0000000184DB46A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get; } // 0x0000000184D88A40-0x0000000184D88A60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get; } // 0x0000000184DB57B0-0x0000000184DB57D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yw { get; } // 0x0000000184DB6B90-0x0000000184DB6BB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zw { get; } // 0x0000000184D9C5E0-0x0000000184D9C600 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wz { get; } // 0x0000000184DB6B30-0x0000000184DB6B50 
		public float this[int index] { get => default; set {} } // 0x0000000184DB5200-0x0000000184DB5210 0x0000000184DB60B0-0x0000000184DB60C0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57220
		{
		}
	
		// Constructors
		public float4(float x, float y, float z, float w); // 0x0000000184D88AD0-0x0000000184D88AF0
		public float4(float x, float y, float2 zw); // 0x0000000184DB69F0-0x0000000184DB6A20
		public float4(float x, float2 yz, float w); // 0x0000000184DB6A90-0x0000000184DB6AC0
		public float4(float x, float3 yzw); // 0x0000000184DB6AC0-0x0000000184DB6AE0
		public float4(float2 xy, float z, float w); // 0x0000000184DB69A0-0x0000000184DB69D0
		public float4(float2 xy, float2 zw); // 0x0000000184DB68A0-0x0000000184DB68E0
		public float4(float3 xyz, float w); // 0x0000000184DB6980-0x0000000184DB69A0
		public float4(float4 xyzw); // 0x0000000184D92B90-0x0000000184D92BB0
		public float4(float v); // 0x0000000184DB6930-0x0000000184DB6940
		public float4(bool v); // 0x0000000185F03D18-0x0000000185F03D5C
		public float4(bool4 v); // 0x0000000185F03D5C-0x0000000185F03DB0
		public float4(int v); // 0x0000000184DB6A20-0x0000000184DB6A30
		public float4(int4 v); // 0x0000000184DB6A80-0x0000000184DB6A90
		public float4(uint v); // 0x0000000184DB68E0-0x0000000184DB6930
		public float4(uint4 v); // 0x0000000184DB6A30-0x0000000184DB6A80
		public float4(half v); // 0x000000018B28CE30-0x000000018B28CE78
		public float4(half4 v); // 0x000000018B28CDD8-0x000000018B28CE30
		public float4(double v); // 0x0000000184DB69D0-0x0000000184DB69F0
		public float4(double4 v); // 0x0000000184DB6940-0x0000000184DB6980
	
		// Methods
		public static implicit operator float4(float v); // 0x0000000184DAF890-0x0000000184DAF8A0
		public static implicit operator float4(int v); // 0x0000000184DAF920-0x0000000184DAF940
		public static implicit operator float4(int4 v); // 0x000000018B252674-0x000000018B2526B8
		public static implicit operator float4(uint v); // 0x0000000184DAF970-0x0000000184DAF9C0
		public static implicit operator float4(uint4 v); // 0x000000018B2526D0-0x000000018B2526F4
		public static implicit operator float4(half4 v); // 0x000000018B2525CC-0x000000018B252628
		public static explicit operator float4(double v); // 0x0000000184DAF900-0x0000000184DAF920
		public static explicit operator float4(double4 v); // 0x000000018B252584-0x000000018B2525B4
		public static float4 operator *(float4 lhs, float4 rhs); // 0x00000001830E8750-0x00000001830E87A0
		public static float4 operator *(float4 lhs, float rhs); // 0x000000018308B480-0x000000018308B4A0
		public static float4 operator *(float lhs, float4 rhs); // 0x00000001834C9970-0x00000001834C9990
		public static float4 operator +(float4 lhs, float4 rhs); // 0x00000001830E87A0-0x00000001830E87F0
		public static float4 operator +(float4 lhs, float rhs); // 0x0000000184DA8140-0x0000000184DA8160
		public static float4 operator -(float4 lhs, float4 rhs); // 0x0000000183F5AF20-0x0000000183F5AFF0
		public static float4 operator -(float4 lhs, float rhs); // 0x0000000184DA8160-0x0000000184DA8180
		public static float4 operator -(float lhs, float4 rhs); // 0x0000000184DB6C30-0x0000000184DB6C70
		public static float4 operator /(float4 lhs, float4 rhs); // 0x000000018AAED7A8-0x000000018AAED7EC
		public static float4 operator /(float4 lhs, float rhs); // 0x000000018AAED7EC-0x000000018AAED800
		public static float4 operator /(float lhs, float4 rhs); // 0x000000018B28CE78-0x000000018B28CEB0
		public static bool4 operator <(float4 lhs, float rhs); // 0x000000018B28CF94-0x000000018B28CFBC
		public static bool4 operator >(float4 lhs, float4 rhs); // 0x000000018B28CF58-0x000000018B28CF94
		public static bool4 operator >=(float4 lhs, float4 rhs); // 0x000000018B28CF14-0x000000018B28CF58
		public static float4 operator -(float4 val); // 0x0000000184DB6C70-0x0000000184DB6C90
		public static bool4 operator ==(float4 lhs, float4 rhs); // 0x000000018B28CEB0-0x000000018B28CF14
		public static bool4 operator ==(float4 lhs, float rhs); // 0x0000000185F03DB0-0x0000000185F03EBC
		public bool Equals(float4 rhs); // 0x000000018415FC30-0x000000018415FC70
		public override bool Equals(object o); // 0x000000018B28CAAC-0x000000018B28CB18
		public override int GetHashCode(); // 0x000000018B256480-0x000000018B25649C
		public override string ToString(); // 0x000000018B28CB18-0x000000018B28CC84
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28CC84-0x000000018B28CDD8
		public static implicit operator float4(Vector4 v); // 0x000000018328FB00-0x000000018328FB20
		public static implicit operator Vector4(float4 v); // 0x000000018328FB00-0x000000018328FB20
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x2 : IEquatable<Unity.Mathematics.float4x2>, IFormattable // TypeDefIndex: 57222
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
	
		// Constructors
		public float4x2(float4 c0, float4 c1); // 0x0000000184D8C810-0x0000000184D8C820
		public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31); // 0x0000000184DB6D40-0x0000000184DB6DB0
		public float4x2(float v); // 0x0000000184DB6D20-0x0000000184DB6D40
		public float4x2(bool v); // 0x0000000185F04084-0x0000000185F040A8
		public float4x2(bool4x2 v); // 0x0000000185F03EBC-0x0000000185F04054
		public float4x2(int v); // 0x0000000183BACC20-0x0000000183BACC40
		public float4x2(int4x2 v); // 0x000000018B28D554-0x000000018B28D5F8
		public float4x2(uint v); // 0x0000000185F04054-0x0000000185F04084
		public float4x2(uint4x2 v); // 0x000000018B28D500-0x000000018B28D554
		public float4x2(double v); // 0x0000000184DB6C90-0x0000000184DB6D20
		public float4x2(double4x2 v); // 0x000000018B28D5F8-0x000000018B28D65C
	
		// Methods
		public static implicit operator float4x2(int v); // 0x000000018B252804-0x000000018B252820
		public bool Equals(float4x2 rhs); // 0x000000018B28CFBC-0x000000018B28D004
		public override bool Equals(object o); // 0x000000018B28D004-0x000000018B28D078
		public override int GetHashCode(); // 0x000000018B28D078-0x000000018B28D09C
		public override string ToString(); // 0x000000018B28D2B0-0x000000018B28D500
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28D09C-0x000000018B28D2B0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x3 : IEquatable<Unity.Mathematics.float4x3>, IFormattable // TypeDefIndex: 57223
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
	
		// Constructors
		public float4x3(float4 c0, float4 c1, float4 c2); // 0x0000000184DA0760-0x0000000184DA0780
		public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32); // 0x0000000184DB6ED0-0x0000000184DB6F90
		public float4x3(float v); // 0x0000000184DB6E70-0x0000000184DB6EA0
		public float4x3(bool v); // 0x0000000185F04158-0x0000000185F04394
		public float4x3(bool4x3 v); // 0x0000000185F040A8-0x0000000185F04158
		public float4x3(int v); // 0x0000000184DB6EA0-0x0000000184DB6ED0
		public float4x3(int4x3 v); // 0x000000018B28DD6C-0x000000018B28DE5C
		public float4x3(uint v); // 0x0000000185F04394-0x0000000185F043D8
		public float4x3(uint4x3 v); // 0x000000018B28DE5C-0x000000018B28DED4
		public float4x3(double v); // 0x0000000184DB6DB0-0x0000000184DB6E70
		public float4x3(double4x3 v); // 0x000000018B28DED4-0x000000018B28DF60
	
		// Methods
		public static implicit operator float4x3(int v); // 0x000000018B2529E4-0x000000018B252A04
		public static float4x3 operator *(float4x3 lhs, float4x3 rhs); // 0x000000018B28E01C-0x000000018B28E0D8
		public static float4x3 operator *(float4x3 lhs, float rhs); // 0x000000018B28E0D8-0x000000018B28E164
		public static float4x3 operator +(float4x3 lhs, float4x3 rhs); // 0x000000018B28DF60-0x000000018B28E01C
		public bool Equals(float4x3 rhs); // 0x000000018B28D6D8-0x000000018B28D738
		public override bool Equals(object o); // 0x000000018B28D65C-0x000000018B28D6D8
		public override int GetHashCode(); // 0x000000018B28D738-0x000000018B28D768
		public override string ToString(); // 0x000000018B28DA3C-0x000000018B28DD6C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28D768-0x000000018B28DA3C
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x4 : IEquatable<Unity.Mathematics.float4x4>, IFormattable // TypeDefIndex: 57224
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
		public float4 c3; // 0x30
		public static readonly float4x4 identity; // 0x00
		public static readonly float4x4 zero; // 0x40
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x0000000184DB7090-0x0000000184DB70A0 
	
		// Constructors
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3); // 0x0000000184DB3220-0x0000000184DB3250
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33); // 0x00000001833A3ED0-0x00000001833A3FD0
		public float4x4(float v); // 0x000000018308AEF0-0x000000018308B480
		public float4x4(bool v); // 0x0000000185F044B8-0x0000000185F045B4
		public float4x4(bool4x4 v); // 0x0000000185F043D8-0x0000000185F044B8
		public float4x4(int v); // 0x000000018308BCF0-0x000000018308BD30
		public float4x4(int4x4 v); // 0x000000018B28F11C-0x000000018B28F254
		public float4x4(uint v); // 0x0000000185F045B4-0x0000000185F051A0
		public float4x4(uint4x4 v); // 0x000000018B28F084-0x000000018B28F11C
		public float4x4(double v); // 0x0000000184DB6F90-0x0000000184DB7090
		public float4x4(double4x4 v); // 0x000000018B28EFCC-0x000000018B28F084
		public float4x4(float3x3 rotation, float3 translation); // 0x000000018B28ECE4-0x000000018B28EDA4
		public float4x4(quaternion rotation, float3 translation); // 0x000000018B28EDA4-0x000000018B28EEA8
		public float4x4(RigidTransform transform); // 0x000000018B28EEA8-0x000000018B28EFCC
		static float4x4(); // 0x0000000184CC6270-0x0000000184CC6370
	
		// Methods
		public static implicit operator float4x4(float v); // 0x000000018308AEC0-0x000000018308AEF0
		public static implicit operator float4x4(int v); // 0x000000018B252EE4-0x000000018B252F08
		public static float4x4 operator *(float4x4 lhs, float rhs); // 0x000000018B28F440-0x000000018B28F4F8
		public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs); // 0x000000018B28F254-0x000000018B28F328
		public bool Equals(float4x4 rhs); // 0x000000018B28E164-0x000000018B28E1E0
		public override bool Equals(object o); // 0x000000018B28E1E0-0x000000018B28E264
		public override int GetHashCode(); // 0x000000018B28E264-0x000000018B28E29C
		public override string ToString(); // 0x000000018B28E540-0x000000018B28E950
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28E950-0x000000018B28ECE4
		public static implicit operator float4x4(Matrix4x4 m); // 0x000000018B28F328-0x000000018B28F440
		public static implicit operator Matrix4x4(float4x4 m); // 0x000000018334D940-0x000000018334DB30
		public static float4x4 Ortho(float width, float height, float near, float far); // 0x000000018B28E29C-0x000000018B28E388
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale); // 0x000000018B28E388-0x000000018B28E540
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct half : IEquatable<Unity.Mathematics.half>, IFormattable // TypeDefIndex: 57225
	{
		// Fields
		public ushort value; // 0x00
		public static readonly half zero; // 0x00
	
		// Constructors
		public half(half x); // 0x0000000184D87160-0x0000000184D87170
		public half(float v); // 0x000000018B28FFF0-0x000000018B290008
		public half(double v); // 0x000000018B28FFD4-0x000000018B28FFF0
	
		// Methods
		public static explicit operator half(float v); // 0x000000018B253650-0x000000018B253658
		public static explicit operator half(double v); // 0x000000018B253644-0x000000018B253650
		public static implicit operator float(half d); // 0x000000018B290028-0x000000018B290030
		public static implicit operator double(half d); // 0x000000018B290010-0x000000018B290028
		public static bool operator ==(half lhs, half rhs); // 0x000000018B290008-0x000000018B290010
		public bool Equals(half rhs); // 0x0000000183F4C8B0-0x0000000183F4C8C0
		public override bool Equals(object o); // 0x000000018B28FF1C-0x000000018B28FF7C
		public override int GetHashCode(); // 0x0000000184D87110-0x0000000184D87120
		public override string ToString(); // 0x000000018B28FF7C-0x000000018B28FFA0
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28FFA0-0x000000018B28FFD4
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half2 : IEquatable<Unity.Mathematics.half2>, IFormattable // TypeDefIndex: 57227
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57226
		{
		}
	
		// Constructors
		public half2(half x, half y); // 0x0000000184DA4480-0x0000000184DA4490
		public half2(half2 xy); // 0x0000000184DB70B0-0x0000000184DB70C0
		public half2(half v); // 0x0000000184DB70A0-0x0000000184DB70B0
		public half2(float v); // 0x000000018B28F708-0x000000018B28F730
		public half2(float2 v); // 0x000000018B28F730-0x000000018B28F760
		public half2(double v); // 0x000000018B28F6D8-0x000000018B28F708
		public half2(double2 v); // 0x000000018B28F760-0x000000018B28F794
	
		// Methods
		public static explicit operator half2(float2 v); // 0x000000018B2533B0-0x000000018B2533E4
		public bool Equals(half2 rhs); // 0x000000018B28F56C-0x000000018B28F580
		public override bool Equals(object o); // 0x000000018B28F4F8-0x000000018B28F56C
		public override int GetHashCode(); // 0x000000018B28F580-0x000000018B28F5C8
		public override string ToString(); // 0x000000018B28F64C-0x000000018B28F6D8
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28F5C8-0x000000018B28F64C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half3 : IEquatable<Unity.Mathematics.half3>, IFormattable // TypeDefIndex: 57229
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57228
		{
		}
	
		// Constructors
		public half3(half x, half y, half z); // 0x0000000184DB22F0-0x0000000184DB2300
		public half3(half x, half2 yz); // 0x0000000184DB70C0-0x0000000184DB70E0
		public half3(half2 xy, half z); // 0x0000000184DB70E0-0x0000000184DB70F0
		public half3(half3 xyz); // 0x0000000184DB70F0-0x0000000184DB7110
		public half3(half v); // 0x0000000184DB7110-0x0000000184DB7120
		public half3(float v); // 0x000000018B28FA54-0x000000018B28FA8C
		public half3(float3 v); // 0x000000018B28FA8C-0x000000018B28FAC8
		public half3(double v); // 0x000000018B28F9C8-0x000000018B28FA0C
		public half3(double3 v); // 0x000000018B28FA0C-0x000000018B28FA54
	
		// Methods
		public static explicit operator half3(float3 v); // 0x000000018B253474-0x000000018B2534B8
		public static explicit operator half3(double3 v); // 0x000000018B253428-0x000000018B253474
		public bool Equals(half3 rhs); // 0x000000018B28F794-0x000000018B28F7B8
		public override bool Equals(object o); // 0x000000018B28F7B8-0x000000018B28F844
		public override int GetHashCode(); // 0x000000018B28F844-0x000000018B28F868
		public override string ToString(); // 0x000000018B28F910-0x000000018B28F9C8
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28F868-0x000000018B28F910
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half4 : IEquatable<Unity.Mathematics.half4>, IFormattable // TypeDefIndex: 57231
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
		public half w; // 0x06
		public static readonly half4 zero; // 0x00
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57230
		{
		}
	
		// Constructors
		public half4(half x, half y, half z, half w); // 0x0000000184DB23B0-0x0000000184DB23D0
		public half4(half x, half y, half2 zw); // 0x0000000184DB7190-0x0000000184DB71B0
		public half4(half x, half2 yz, half w); // 0x0000000184DB71B0-0x0000000184DB71D0
		public half4(half x, half3 yzw); // 0x0000000184DB7200-0x0000000184DB7220
		public half4(half2 xy, half z, half w); // 0x0000000184DB7120-0x0000000184DB7140
		public half4(half2 xy, half2 zw); // 0x0000000184DB7140-0x0000000184DB7160
		public half4(half3 xyz, half w); // 0x0000000184DB71E0-0x0000000184DB7200
		public half4(half4 xyzw); // 0x0000000184DB7160-0x0000000184DB7190
		public half4(half v); // 0x0000000184DB71D0-0x0000000184DB71E0
		public half4(float v); // 0x000000018B28FED8-0x000000018B28FF1C
		public half4(float4 v); // 0x000000018B28FDDC-0x000000018B28FE28
		public half4(double v); // 0x000000018B28FE84-0x000000018B28FED8
		public half4(double4 v); // 0x000000018B28FE28-0x000000018B28FE84
	
		// Methods
		public static explicit operator half4(float4 v); // 0x000000018B2535F0-0x000000018B253644
		public bool Equals(half4 rhs); // 0x000000018B287BE0-0x000000018B287F80
		public override bool Equals(object o); // 0x000000018B28FAC8-0x000000018B28FB28
		public override int GetHashCode(); // 0x000000018B28FB28-0x000000018B28FB30
		public override string ToString(); // 0x000000018B28FB30-0x000000018B28FC94
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B28FC94-0x000000018B28FDDC
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int2 : IEquatable<Unity.Mathematics.int2>, IFormattable // TypeDefIndex: 57233
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public static readonly int2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get; } // 0x0000000184DB7290-0x0000000184DB72B0 
		public int this[int index] { set {} } // 0x0000000184DB73A0-0x0000000184DB73B0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57232
		{
		}
	
		// Constructors
		public int2(int x, int y); // 0x0000000184D85C40-0x0000000184D85C50
		public int2(int2 xy); // 0x0000000184DB7280-0x0000000184DB7290
		public int2(int v); // 0x0000000184DB7220-0x0000000184DB7230
		public int2(bool v); // 0x000000018B2901E8-0x000000018B2901F8
		public int2(bool2 v); // 0x000000018B2901F8-0x000000018B290214
		public int2(uint v); // 0x0000000184DB7220-0x0000000184DB7230
		public int2(uint2 v); // 0x0000000184DB7280-0x0000000184DB7290
		public int2(float v); // 0x0000000184DB7270-0x0000000184DB7280
		public int2(float2 v); // 0x0000000184DB7240-0x0000000184DB7260
		public int2(double v); // 0x0000000184DB7260-0x0000000184DB7270
		public int2(double2 v); // 0x0000000184DB7230-0x0000000184DB7240
	
		// Methods
		public static implicit operator int2(int v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static explicit operator int2(uint v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static explicit operator int2(uint2 v); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static explicit operator int2(float v); // 0x0000000184DB0280-0x0000000184DB02A0
		public static explicit operator int2(float2 v); // 0x0000000184DB0240-0x0000000184DB0260
		public static explicit operator int2(double v); // 0x0000000184DB0260-0x0000000184DB0280
		public static explicit operator int2(double2 v); // 0x0000000184DB02B0-0x0000000184DB02D0
		public static int2 operator *(int2 lhs, int2 rhs); // 0x0000000184DB7310-0x0000000184DB7330
		public static int2 operator *(int2 lhs, int rhs); // 0x0000000184DB72F0-0x0000000184DB7310
		public static int2 operator +(int2 lhs, int2 rhs); // 0x0000000184D85C70-0x0000000184D85C90
		public static int2 operator +(int2 lhs, int rhs); // 0x0000000184DB72B0-0x0000000184DB72D0
		public static int2 operator -(int2 lhs, int rhs); // 0x0000000184DB7360-0x0000000184DB7380
		public static int2 operator /(int2 lhs, int rhs); // 0x000000018B290214-0x000000018B290238
		public static bool2 operator >(int2 lhs, int rhs); // 0x000000018B290258-0x000000018B290270
		public static bool2 operator >=(int2 lhs, int rhs); // 0x000000018B290238-0x000000018B290258
		public static int2 operator -(int2 val); // 0x0000000184DB7380-0x0000000184DB73A0
		public static int2 operator >>(int2 x, int n); // 0x0000000184DB7330-0x0000000184DB7360
		public static int2 operator |(int2 lhs, int2 rhs); // 0x0000000184DB72D0-0x0000000184DB72F0
		public bool Equals(int2 rhs); // 0x00000001863516B4-0x00000001863516C8
		public override bool Equals(object o); // 0x000000018B290030-0x000000018B2900A4
		public override int GetHashCode(); // 0x000000018B2900A4-0x000000018B2900D8
		public override string ToString(); // 0x000000018B290160-0x000000018B2901E8
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B2900D8-0x000000018B290160
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x2 : IEquatable<Unity.Mathematics.int2x2>, IFormattable // TypeDefIndex: 57234
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public static readonly int2x2 identity; // 0x00
	
		// Constructors
		public int2x2(int2 c0, int2 c1); // 0x0000000184D861B0-0x0000000184D861C0
		public int2x2(int m00, int m01, int m10, int m11); // 0x0000000184DB74F0-0x0000000184DB7520
		public int2x2(int v); // 0x0000000184DB7430-0x0000000184DB7460
		public int2x2(bool v); // 0x000000018B290618-0x000000018B290660
		public int2x2(bool2x2 v); // 0x000000018B2905A8-0x000000018B290618
		public int2x2(uint v); // 0x0000000184DB7430-0x0000000184DB7460
		public int2x2(uint2x2 v); // 0x0000000184DB7520-0x0000000184DB7560
		public int2x2(float v); // 0x0000000184DB73B0-0x0000000184DB73F0
		public int2x2(float2x2 v); // 0x0000000184DB74A0-0x0000000184DB74F0
		public int2x2(double v); // 0x0000000184DB7460-0x0000000184DB74A0
		public int2x2(double2x2 v); // 0x0000000184DB73F0-0x0000000184DB7430
		static int2x2(); // 0x0000000184CEAE50-0x0000000184CEAEB0
	
		// Methods
		public bool Equals(int2x2 rhs); // 0x000000018B287F80-0x000000018B28B100
		public override bool Equals(object o); // 0x000000018B290270-0x000000018B2902DC
		public override int GetHashCode(); // 0x000000018B2902DC-0x000000018B2902F8
		public override string ToString(); // 0x000000018B2902F8-0x000000018B290454
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B290454-0x000000018B2905A8
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x3 : IEquatable<Unity.Mathematics.int2x3>, IFormattable // TypeDefIndex: 57235
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
	
		// Properties
		public ref int2 this[int index] { get => default; } // 0x0000000184DB77A0-0x0000000184DB77B0 
	
		// Constructors
		public int2x3(int2 c0, int2 c1, int2 c2); // 0x0000000184D8C0D0-0x0000000184D8C0E0
		public int2x3(int m00, int m01, int m02, int m10, int m11, int m12); // 0x0000000184DB7750-0x0000000184DB77A0
		public int2x3(int v); // 0x0000000184DB76C0-0x0000000184DB7700
		public int2x3(bool v); // 0x000000018B290B74-0x000000018B290BD8
		public int2x3(bool2x3 v); // 0x000000018B290ADC-0x000000018B290B74
		public int2x3(uint v); // 0x0000000184DB76C0-0x0000000184DB7700
		public int2x3(uint2x3 v); // 0x0000000184DB7700-0x0000000184DB7750
		public int2x3(float v); // 0x0000000184DB7610-0x0000000184DB7660
		public int2x3(float2x3 v); // 0x0000000184DB7660-0x0000000184DB76C0
		public int2x3(double v); // 0x0000000184DB7560-0x0000000184DB75B0
		public int2x3(double2x3 v); // 0x0000000184DB75B0-0x0000000184DB7610
	
		// Methods
		public bool Equals(int2x3 rhs); // 0x000000018B290660-0x000000018B2906C4
		public override bool Equals(object o); // 0x000000018B2906C4-0x000000018B290738
		public override int GetHashCode(); // 0x000000018B290738-0x000000018B290760
		public override string ToString(); // 0x000000018B290760-0x000000018B290928
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B290928-0x000000018B290ADC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x4 : IEquatable<Unity.Mathematics.int2x4>, IFormattable // TypeDefIndex: 57236
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
		public int2 c3; // 0x18
	
		// Constructors
		public int2x4(int2 c0, int2 c1, int2 c2, int2 c3); // 0x0000000184D861C0-0x0000000184D861E0
		public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13); // 0x0000000184DB78A0-0x0000000184DB7900
		public int2x4(int v); // 0x0000000184DB7980-0x0000000184DB79D0
		public int2x4(bool v); // 0x000000018B2911F4-0x000000018B291278
		public int2x4(bool2x4 v); // 0x000000018B291128-0x000000018B2911F4
		public int2x4(uint v); // 0x0000000184DB7980-0x0000000184DB79D0
		public int2x4(uint2x4 v); // 0x0000000184DB7830-0x0000000184DB78A0
		public int2x4(float v); // 0x0000000184DB79D0-0x0000000184DB7A40
		public int2x4(float2x4 v); // 0x0000000184DB77B0-0x0000000184DB7830
		public int2x4(double v); // 0x0000000184DB7A40-0x0000000184DB7AB0
		public int2x4(double2x4 v); // 0x0000000184DB7900-0x0000000184DB7980
	
		// Methods
		public bool Equals(int2x4 rhs); // 0x000000018B290C4C-0x000000018B290CC0
		public override bool Equals(object o); // 0x000000018B290BD8-0x000000018B290C4C
		public override int GetHashCode(); // 0x000000018B290CC0-0x000000018B290CE4
		public override string ToString(); // 0x000000018B290EF8-0x000000018B291128
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B290CE4-0x000000018B290EF8
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int3 : IEquatable<Unity.Mathematics.int3>, IFormattable // TypeDefIndex: 57238
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public static readonly int3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyz { set; } // 0x0000000184D88F40-0x0000000184D88F60
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzy { get; } // 0x0000000184DB5530-0x0000000184DB5550 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get; set; } // 0x0000000184DB7290-0x0000000184DB72B0 0x0000000184DB7280-0x0000000184DB7290
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yz { get; } // 0x0000000184DB7B70-0x0000000184DB7B90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zx { get; } // 0x0000000184DB7B90-0x0000000184DB7BB0 
		public int this[int index] { get => default; set {} } // 0x0000000184DB7B60-0x0000000184DB7B70 0x0000000184DB73A0-0x0000000184DB73B0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57237
		{
		}
	
		// Constructors
		public int3(int x, int y, int z); // 0x0000000184D85D60-0x0000000184D85D70
		public int3(int x, int2 yz); // 0x0000000184DB7AB0-0x0000000184DB7AC0
		public int3(int2 xy, int z); // 0x0000000184DB7B50-0x0000000184DB7B60
		public int3(int3 xyz); // 0x0000000184D88F40-0x0000000184D88F60
		public int3(int v); // 0x0000000184DB7B20-0x0000000184DB7B30
		public int3(bool v); // 0x000000018B29149C-0x000000018B2914B0
		public int3(bool3 v); // 0x000000018B291470-0x000000018B29149C
		public int3(uint v); // 0x0000000184DB7B20-0x0000000184DB7B30
		public int3(uint3 v); // 0x0000000184D88F40-0x0000000184D88F60
		public int3(float v); // 0x0000000184DB7AE0-0x0000000184DB7B00
		public int3(float3 v); // 0x0000000184DB7AC0-0x0000000184DB7AE0
		public int3(double v); // 0x0000000184DB7B00-0x0000000184DB7B20
		public int3(double3 v); // 0x0000000184DB7B30-0x0000000184DB7B50
	
		// Methods
		public static implicit operator int3(int v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static explicit operator int3(uint v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static explicit operator int3(uint3 v); // 0x0000000184DB0370-0x0000000184DB03A0
		public static explicit operator int3(float v); // 0x0000000184DB03C0-0x0000000184DB03E0
		public static explicit operator int3(float3 v); // 0x0000000184DB0300-0x0000000184DB0330
		public static explicit operator int3(double v); // 0x0000000184DB03A0-0x0000000184DB03C0
		public static explicit operator int3(double3 v); // 0x0000000184DB03E0-0x0000000184DB0420
		public static int3 operator *(int3 lhs, int3 rhs); // 0x0000000183C87E40-0x0000000183C87E70
		public static int3 operator *(int3 lhs, int rhs); // 0x0000000184DB7C00-0x0000000184DB7C20
		public static int3 operator +(int3 lhs, int3 rhs); // 0x000000018338E380-0x000000018338E3A0
		public static int3 operator +(int3 lhs, int rhs); // 0x0000000184DB7BB0-0x0000000184DB7BE0
		public static int3 operator -(int3 lhs, int3 rhs); // 0x0000000184DB7C70-0x0000000184DB7C90
		public static int3 operator -(int3 lhs, int rhs); // 0x0000000184DB7C50-0x0000000184DB7C70
		public static int3 operator /(int3 lhs, int rhs); // 0x000000018B2914B0-0x000000018B2914D8
		public static bool3 operator <=(int3 lhs, int3 rhs); // 0x000000018B291544-0x000000018B291570
		public static bool3 operator >(int3 lhs, int rhs); // 0x000000018B291524-0x000000018B291544
		public static bool3 operator >=(int3 lhs, int3 rhs); // 0x000000018B2914D8-0x000000018B291504
		public static bool3 operator >=(int3 lhs, int rhs); // 0x000000018B291504-0x000000018B291524
		public static int3 operator -(int3 val); // 0x0000000184DB7C90-0x0000000184DB7CB0
		public static int3 operator >>(int3 x, int n); // 0x0000000184DB7C20-0x0000000184DB7C50
		public static int3 operator |(int3 lhs, int3 rhs); // 0x0000000184DB7BE0-0x0000000184DB7C00
		public bool Equals(int3 rhs); // 0x0000000186351A88-0x0000000186351AA4
		public override bool Equals(object o); // 0x000000018B291278-0x000000018B29130C
		public override int GetHashCode(); // 0x0000000187042C24-0x0000000187042C48
		public override string ToString(); // 0x000000018B2913BC-0x000000018B291470
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29130C-0x000000018B2913BC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x2 : IEquatable<Unity.Mathematics.int3x2>, IFormattable // TypeDefIndex: 57239
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
	
		// Constructors
		public int3x2(int3 c0, int3 c1); // 0x0000000184D871E0-0x0000000184D87200
		public int3x2(int m00, int m01, int m10, int m11, int m20, int m21); // 0x0000000184DB7CB0-0x0000000184DB7CF0
		public int3x2(int v); // 0x0000000184DB7D40-0x0000000184DB7D70
		public int3x2(bool v); // 0x0000000185F051A0-0x0000000185F05370
		public int3x2(bool3x2 v); // 0x000000018B291A00-0x000000018B291AEC
		public int3x2(uint v); // 0x0000000184DB7D40-0x0000000184DB7D70
		public int3x2(uint3x2 v); // 0x0000000185F05370-0x0000000185F053E4
		public int3x2(float v); // 0x0000000184DB7CF0-0x0000000184DB7D40
		public int3x2(float3x2 v); // 0x0000000185F053E4-0x0000000185F055A4
		public int3x2(double v); // 0x0000000184DB7D70-0x0000000184DB7DC0
		public int3x2(double3x2 v); // 0x000000018B291988-0x000000018B291A00
	
		// Methods
		public bool Equals(int3x2 rhs); // 0x00000001866ACFB0-0x00000001866AD020
		public override bool Equals(object o); // 0x000000018B291570-0x000000018B2915E4
		public override int GetHashCode(); // 0x000000018B2915E4-0x000000018B29160C
		public override string ToString(); // 0x000000018B2917C0-0x000000018B291988
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29160C-0x000000018B2917C0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x3 : IEquatable<Unity.Mathematics.int3x3>, IFormattable // TypeDefIndex: 57240
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
		public int3 c2; // 0x18
		public static readonly int3x3 identity; // 0x00
	
		// Constructors
		public int3x3(int3 c0, int3 c1, int3 c2); // 0x0000000184D8C690-0x0000000184D8C6D0
		public int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22); // 0x0000000184B832D0-0x0000000184B83330
		public int3x3(int v); // 0x0000000184DB7DC0-0x0000000184DB7E10
		public int3x3(bool v); // 0x0000000185F05648-0x0000000185F056D8
		public int3x3(bool3x3 v); // 0x000000018B2920DC-0x000000018B292224
		public int3x3(uint v); // 0x0000000184DB7DC0-0x0000000184DB7E10
		public int3x3(uint3x3 v); // 0x0000000185F056D8-0x0000000185F05824
		public int3x3(float v); // 0x0000000184DB7E80-0x0000000184DB7EF0
		public int3x3(float3x3 v); // 0x0000000185F055A4-0x0000000185F05648
		public int3x3(double v); // 0x0000000184DB7E10-0x0000000184DB7E80
		public int3x3(double3x3 v); // 0x000000018B292224-0x000000018B2922CC
		static int3x3(); // 0x0000000184B83330-0x0000000184B833D0
	
		// Methods
		public bool Equals(int3x3 rhs); // 0x000000018B291B68-0x000000018B291C08
		public override bool Equals(object o); // 0x000000018B291AEC-0x000000018B291B68
		public override int GetHashCode(); // 0x000000018B291C08-0x000000018B291C34
		public override string ToString(); // 0x000000018B291E78-0x000000018B2920DC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B291C34-0x000000018B291E78
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x4 : IEquatable<Unity.Mathematics.int3x4>, IFormattable // TypeDefIndex: 57241
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
		public int3 c2; // 0x18
		public int3 c3; // 0x24
	
		// Constructors
		public int3x4(int3 c0, int3 c1, int3 c2, int3 c3); // 0x0000000184DB65D0-0x0000000184DB6620
		public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23); // 0x0000000184DB8070-0x0000000184DB8100
		public int3x4(int v); // 0x0000000184DB7F80-0x0000000184DB7FE0
		public int3x4(bool v); // 0x0000000185F059CC-0x0000000185F05D4C
		public int3x4(bool3x4 v); // 0x000000018B292A08-0x000000018B292B9C
		public int3x4(uint v); // 0x0000000184DB7F80-0x0000000184DB7FE0
		public int3x4(uint3x4 v); // 0x0000000185F05824-0x0000000185F058F8
		public int3x4(float v); // 0x0000000184DB7EF0-0x0000000184DB7F80
		public int3x4(float3x4 v); // 0x0000000185F058F8-0x0000000185F059CC
		public int3x4(double v); // 0x0000000184DB7FE0-0x0000000184DB8070
		public int3x4(double3x4 v); // 0x000000018B292B9C-0x000000018B292C78
	
		// Methods
		public bool Equals(int3x4 rhs); // 0x000000018B292348-0x000000018B292404
		public override bool Equals(object o); // 0x000000018B2922CC-0x000000018B292348
		public override int GetHashCode(); // 0x000000018B292404-0x000000018B292434
		public override string ToString(); // 0x000000018B292434-0x000000018B292734
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B292734-0x000000018B292A08
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int4 : IEquatable<Unity.Mathematics.int4>, IFormattable // TypeDefIndex: 57243
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
		public static readonly int4 zero; // 0x00
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x0000000184DB7B60-0x0000000184DB7B70 0x0000000184DB73A0-0x0000000184DB73B0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57242
		{
		}
	
		// Constructors
		public int4(int x, int y, int z, int w); // 0x0000000184D88C10-0x0000000184D88C30
		public int4(int x, int y, int2 zw); // 0x0000000184DB8100-0x0000000184DB8120
		public int4(int x, int2 yz, int w); // 0x0000000184DB8200-0x0000000184DB8220
		public int4(int x, int3 yzw); // 0x0000000184DB81D0-0x0000000184DB81F0
		public int4(int2 xy, int z, int w); // 0x0000000184DB8220-0x0000000184DB8240
		public int4(int2 xy, int2 zw); // 0x0000000184DB8120-0x0000000184DB8140
		public int4(int3 xyz, int w); // 0x0000000184DB81B0-0x0000000184DB81D0
		public int4(int4 xyzw); // 0x0000000184D92B90-0x0000000184D92BB0
		public int4(int v); // 0x0000000184DB8160-0x0000000184DB8170
		public int4(bool v); // 0x000000018B292FB0-0x000000018B292FCC
		public int4(bool4 v); // 0x000000018B292FCC-0x000000018B293010
		public int4(uint v); // 0x0000000184DB8160-0x0000000184DB8170
		public int4(uint4 v); // 0x0000000184D92B90-0x0000000184D92BB0
		public int4(float v); // 0x0000000184DB8140-0x0000000184DB8160
		public int4(float4 v); // 0x0000000184DB81F0-0x0000000184DB8200
		public int4(double v); // 0x0000000184DB8170-0x0000000184DB8190
		public int4(double4 v); // 0x0000000184DB8190-0x0000000184DB81B0
	
		// Methods
		public static implicit operator int4(int v); // 0x0000000184DB0420-0x0000000184DB0430
		public static explicit operator int4(uint v); // 0x0000000184DB0420-0x0000000184DB0430
		public static explicit operator int4(uint4 v); // 0x000000018B25AC78-0x000000018B25ACA4
		public static explicit operator int4(float v); // 0x0000000184DB0490-0x0000000184DB04B0
		public static explicit operator int4(float4 v); // 0x000000018B25AD38-0x000000018B25AD6C
		public static explicit operator int4(double v); // 0x0000000184DB0470-0x0000000184DB0490
		public static explicit operator int4(double4 v); // 0x000000018B25AD08-0x000000018B25AD38
		public static int4 operator *(int4 lhs, int4 rhs); // 0x0000000184DB82A0-0x0000000184DB82D0
		public static int4 operator *(int4 lhs, int rhs); // 0x0000000184DB82D0-0x0000000184DB8300
		public static int4 operator +(int4 lhs, int4 rhs); // 0x0000000184DB8270-0x0000000184DB82A0
		public static int4 operator +(int4 lhs, int rhs); // 0x0000000184DB8240-0x0000000184DB8270
		public static int4 operator -(int4 lhs, int rhs); // 0x0000000184DB8330-0x0000000184DB8360
		public static bool4 operator >(int4 lhs, int rhs); // 0x000000018B293034-0x000000018B293058
		public static bool4 operator >=(int4 lhs, int rhs); // 0x000000018B293010-0x000000018B293034
		public static int4 operator -(int4 val); // 0x0000000184DB8360-0x0000000184DB8390
		public static int4 operator >>(int4 x, int n); // 0x0000000184DB8300-0x0000000184DB8330
		public static int4 operator |(int4 lhs, int4 rhs); // 0x00000001834C9890-0x00000001834C98C0
		public bool Equals(int4 rhs); // 0x00000001868AFB90-0x00000001868AFBB4
		public override bool Equals(object o); // 0x000000018B292C78-0x000000018B292CE4
		public override int GetHashCode(); // 0x000000018B292CE4-0x000000018B292D00
		public override string ToString(); // 0x000000018B292D00-0x000000018B292E5C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B292E5C-0x000000018B292FB0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x2 : IEquatable<Unity.Mathematics.int4x2>, IFormattable // TypeDefIndex: 57244
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
	
		// Constructors
		public int4x2(int4 c0, int4 c1); // 0x0000000184D8C810-0x0000000184D8C820
		public int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31); // 0x0000000184DB83B0-0x0000000184DB8400
		public int4x2(int v); // 0x0000000183BACBE0-0x0000000183BACC20
		public int4x2(bool v); // 0x0000000185F05DC8-0x0000000185F05EB8
		public int4x2(bool4x2 v); // 0x0000000185F05D4C-0x0000000185F05DC8
		public int4x2(uint v); // 0x0000000183BACBE0-0x0000000183BACC20
		public int4x2(uint4x2 v); // 0x000000018B2935DC-0x000000018B293644
		public int4x2(float v); // 0x0000000184DB8390-0x0000000184DB83B0
		public int4x2(float4x2 v); // 0x0000000185F05EB8-0x0000000185F05F40
		public int4x2(double v); // 0x0000000184DB8400-0x0000000184DB8460
		public int4x2(double4x2 v); // 0x000000018B293578-0x000000018B2935DC
	
		// Methods
		public static implicit operator int4x2(int v); // 0x000000018B25ADCC-0x000000018B25ADE8
		public bool Equals(int4x2 rhs); // 0x000000018B293058-0x000000018B29309C
		public override bool Equals(object o); // 0x000000018B29309C-0x000000018B293110
		public override int GetHashCode(); // 0x000000018B293110-0x000000018B293134
		public override string ToString(); // 0x000000018B293134-0x000000018B293364
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B293364-0x000000018B293578
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x3 : IEquatable<Unity.Mathematics.int4x3>, IFormattable // TypeDefIndex: 57245
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
		public int4 c2; // 0x20
	
		// Constructors
		public int4x3(int4 c0, int4 c1, int4 c2); // 0x0000000184DA0760-0x0000000184DA0780
		public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32); // 0x0000000184DB84E0-0x0000000184DB8560
		public int4x3(int v); // 0x0000000184DB8560-0x0000000184DB85B0
		public int4x3(bool v); // 0x0000000185F05FF8-0x0000000185F060B4
		public int4x3(bool4x3 v); // 0x0000000185F05F40-0x0000000185F05FF8
		public int4x3(uint v); // 0x0000000184DB8560-0x0000000184DB85B0
		public int4x3(uint4x3 v); // 0x000000018B293D24-0x000000018B293DAC
		public int4x3(float v); // 0x0000000184DB85B0-0x0000000184DB85E0
		public int4x3(float4x3 v); // 0x0000000185F060B4-0x0000000185F06204
		public int4x3(double v); // 0x0000000184DB8460-0x0000000184DB84E0
		public int4x3(double4x3 v); // 0x000000018B293DAC-0x000000018B293E38
	
		// Methods
		public bool Equals(int4x3 rhs); // 0x000000018B2936C0-0x000000018B293720
		public override bool Equals(object o); // 0x000000018B293644-0x000000018B2936C0
		public override int GetHashCode(); // 0x000000018B293720-0x000000018B293750
		public override string ToString(); // 0x000000018B293A24-0x000000018B293D24
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B293750-0x000000018B293A24
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x4 : IEquatable<Unity.Mathematics.int4x4>, IFormattable // TypeDefIndex: 57246
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
		public int4 c2; // 0x20
		public int4 c3; // 0x30
		public static readonly int4x4 identity; // 0x00
	
		// Constructors
		public int4x4(int4 c0, int4 c1, int4 c2, int4 c3); // 0x0000000184DB3220-0x0000000184DB3250
		public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33); // 0x0000000184A3ADB0-0x0000000184A3AE60
		public int4x4(int v); // 0x0000000184DB8690-0x0000000184DB86F0
		public int4x4(bool v); // 0x0000000185F06204-0x0000000185F062F4
		public int4x4(bool4x4 v); // 0x0000000185F062F4-0x0000000185F06490
		public int4x4(uint v); // 0x0000000184DB8690-0x0000000184DB86F0
		public int4x4(uint4x4 v); // 0x000000018B2946D4-0x000000018B294780
		public int4x4(float v); // 0x0000000184DB86F0-0x0000000184DB8730
		public int4x4(float4x4 v); // 0x0000000185F06490-0x0000000185F07C48
		public int4x4(double v); // 0x0000000184DB85E0-0x0000000184DB8690
		public int4x4(double4x4 v); // 0x000000018B294780-0x000000018B2979F0
		static int4x4(); // 0x0000000184A3AE60-0x0000000184A3AF50
	
		// Methods
		public bool Equals(int4x4 rhs); // 0x000000018B293EBC-0x000000018B293F38
		public override bool Equals(object o); // 0x000000018B293E38-0x000000018B293EBC
		public override int GetHashCode(); // 0x000000018B293F38-0x000000018B293F70
		public override string ToString(); // 0x000000018B294304-0x000000018B2946D4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B293F70-0x000000018B294304
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<Unity.Mathematics.quaternion>, IFormattable // TypeDefIndex: 57247
	{
		// Fields
		public float4 value; // 0x00
		public static readonly quaternion identity; // 0x00
	
		// Constructors
		public quaternion(float x, float y, float z, float w); // 0x0000000184D88AD0-0x0000000184D88AF0
		public quaternion(float4 value); // 0x0000000184D8D270-0x0000000184D8D280
		public quaternion(float3x3 m); // 0x00000001834C9420-0x00000001834C9800
		public quaternion(float4x4 m); // 0x000000018B299FC0-0x000000018B29A2E0
		static quaternion(); // 0x0000000184D6E6C0-0x0000000184D6E700
	
		// Methods
		public static implicit operator Quaternion(quaternion q); // 0x000000018328FB00-0x000000018328FB20
		public static implicit operator quaternion(Quaternion q); // 0x000000018328FB00-0x000000018328FB20
		public static implicit operator quaternion(float4 v); // 0x0000000182B77630-0x0000000182B77640
		public static quaternion AxisAngle(float3 axis, float angle); // 0x00000001862E2884-0x00000001862E2990
		public static quaternion EulerXYZ(float3 xyz); // 0x00000001862E2990-0x00000001862E2B70
		public static quaternion EulerXZY(float3 xyz); // 0x00000001862E2B70-0x00000001862E2D50
		public static quaternion EulerYXZ(float3 xyz); // 0x00000001862E2D50-0x00000001862E2F30
		public static quaternion EulerYZX(float3 xyz); // 0x00000001862E2F30-0x00000001862E3110
		public static quaternion EulerZXY(float3 xyz); // 0x000000018B299560-0x000000018B299740
		public static quaternion EulerZYX(float3 xyz); // 0x00000001862E3148-0x00000001862E3328
		public static quaternion EulerXYZ(float x, float y, float z); // 0x000000018B299480-0x000000018B2994B8
		public static quaternion EulerXZY(float x, float y, float z); // 0x000000018B2994B8-0x000000018B2994F0
		public static quaternion EulerYXZ(float x, float y, float z); // 0x000000018B2994F0-0x000000018B299528
		public static quaternion EulerYZX(float x, float y, float z); // 0x000000018B299528-0x000000018B299560
		public static quaternion EulerZXY(float x, float y, float z); // 0x00000001862E3110-0x00000001862E3148
		public static quaternion EulerZYX(float x, float y, float z); // 0x000000018B299740-0x000000018B299778
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x0234AFB1 */); // 0x000000018B299778-0x000000018B2998D4
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x0234AFB2 */); // 0x00000001862E3328-0x00000001862E3364
		public static quaternion RotateX(float angle); // 0x00000001862E3364-0x00000001862E33C8
		public static quaternion RotateY(float angle); // 0x00000001862E33C8-0x00000001862E342C
		public static quaternion RotateZ(float angle); // 0x00000001862E342C-0x00000001862E35E4
		public static quaternion LookRotation(float3 forward, float3 up); // 0x000000018B299BE4-0x000000018B299D00
		public static quaternion LookRotationSafe(float3 forward, float3 up); // 0x000000018B2998D4-0x000000018B299BE4
		public bool Equals(quaternion x); // 0x000000018415FC30-0x000000018415FC70
		public override bool Equals(object x); // 0x000000018B299414-0x000000018B299480
		public override int GetHashCode(); // 0x000000018B256480-0x000000018B25649C
		public override string ToString(); // 0x000000018B299D00-0x000000018B299E6C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B299E6C-0x000000018B299FC0
	}

	[Il2CppEagerStaticClassConstruction]
	public static class noise // TypeDefIndex: 57248
	{
		// Methods
		public static float cnoise(float2 P); // 0x000000018B297E28-0x000000018B298380
		public static float pnoise(float2 P, float2 rep); // 0x000000018B298718-0x000000018B298CAC
		private static float2 mod289(float2 x); // 0x000000018B2984C8-0x000000018B298518
		private static float3 mod289(float3 x); // 0x000000018B2983FC-0x000000018B2984C8
		private static float4 mod289(float4 x); // 0x000000018B298518-0x000000018B2985BC
		private static float3 permute(float3 x); // 0x000000018B298654-0x000000018B298718
		private static float4 permute(float4 x); // 0x000000018B2985BC-0x000000018B298654
		private static float4 taylorInvSqrt(float4 r); // 0x000000018B2993BC-0x000000018B299414
		private static float2 fade(float2 t); // 0x000000018B298380-0x000000018B2983FC
		public static float snoise(float2 v); // 0x000000018B298CAC-0x000000018B2993BC
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct Random // TypeDefIndex: 57249
	{
		// Fields
		public uint state; // 0x00
	
		// Constructors
		public Random(uint seed); // 0x0000000184DB8760-0x0000000184DB8780
	
		// Methods
		public static Random CreateFromIndex(uint index); // 0x000000018B2979F0-0x000000018B297A18
		internal static uint WangHash(uint n); // 0x0000000184CAFC90-0x0000000184CAFCC0
		public float NextFloat(); // 0x0000000184558F50-0x0000000184558F90
		public float3 NextFloat3(); // 0x0000000186AF4ED4-0x0000000186AF4FEC
		private uint NextState(); // 0x0000000184DB8730-0x0000000184DB8760
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct RigidTransform // TypeDefIndex: 57250
	{
		// Fields
		public quaternion rot; // 0x00
		public float3 pos; // 0x10
		public static readonly RigidTransform identity; // 0x00
	
		// Constructors
		public RigidTransform(quaternion rotation, float3 translation); // 0x0000000184DB8780-0x0000000184DB87A0
		public RigidTransform(float3x3 rotation, float3 translation); // 0x000000018B297D48-0x000000018B297DAC
		public RigidTransform(float4x4 transform); // 0x000000018B297DAC-0x000000018B297E28
		static RigidTransform(); // 0x0000000184D538A0-0x0000000184D53900
	
		// Methods
		public bool Equals(RigidTransform x); // 0x000000018B297A94-0x000000018B297AE4
		public override bool Equals(object x); // 0x000000018B297A18-0x000000018B297A94
		public override int GetHashCode(); // 0x000000018B297AE4-0x000000018B297B30
		public override string ToString(); // 0x000000018B297B30-0x000000018B297D48
	}

	[Il2CppEagerStaticClassConstruction]
	public static class svd // TypeDefIndex: 57251
	{
		// Methods
		private static void condSwap(bool c, ref float x, ref float y); // 0x0000000185F3A2D0-0x0000000185F3ADA8
		private static void condNegSwap(bool c, ref float3 x, ref float3 y); // 0x0000000185F3A25C-0x0000000185F3A2D0
		private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask); // 0x000000018B29A384-0x000000018B29A440
		private static void sortSingularValues(ref float3x3 b, ref quaternion v); // 0x000000018B29AF50-0x000000018B29B0F8
		private static quaternion approxGivensQuat(float3 pq, float4 mask); // 0x000000018B29A2E0-0x000000018B29A384
		private static quaternion qrGivensQuat(float2 pq, float4 mask); // 0x000000018B29AB58-0x000000018B29AC54
		private static quaternion givensQRFactorization(float3x3 b, out float3x3 r); // 0x000000018B29A440-0x000000018B29A6E8
		private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5 /* Metadata: 0x0234AFB3 */); // 0x000000018B29A6E8-0x000000018B29AB58
		private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v); // 0x000000018B29AD64-0x000000018B29AF50
		private static float3 rcpsafe(float3 x, float epsilon = 1E-09f /* Metadata: 0x0234AFB4 */); // 0x000000018B29AC54-0x000000018B29AD64
		public static float3x3 svdInverse(float3x3 a); // 0x000000018B29B0F8-0x000000018B29B2C0
		public static quaternion svdRotation(float3x3 a); // 0x000000018B29B2C0-0x000000018B29B360
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2 : IEquatable<Unity.Mathematics.uint2>, IFormattable // TypeDefIndex: 57253
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57252
		{
		}
	
		// Constructors
		public uint2(uint x, uint y); // 0x0000000184D85C40-0x0000000184D85C50
		public uint2(uint2 xy); // 0x0000000184DB7280-0x0000000184DB7290
		public uint2(uint v); // 0x0000000184DB7220-0x0000000184DB7230
		public uint2(bool v); // 0x000000018B2901E8-0x000000018B2901F8
		public uint2(bool2 v); // 0x000000018B2901F8-0x000000018B290214
		public uint2(int v); // 0x0000000184DB7220-0x0000000184DB7230
		public uint2(int2 v); // 0x0000000184DB7280-0x0000000184DB7290
		public uint2(float v); // 0x0000000185F3ADA8-0x0000000185F3AF08
		public uint2(float2 v); // 0x000000018B29B534-0x000000018B29B570
		public uint2(double v); // 0x000000018B29B518-0x000000018B29B534
		public uint2(double2 v); // 0x000000018B29B570-0x000000018B29B594
	
		// Methods
		public static implicit operator uint2(uint v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static explicit operator uint2(int v); // 0x0000000184DB02A0-0x0000000184DB02B0
		public static explicit operator uint2(int2 v); // 0x0000000184DAB5F0-0x0000000184DAB610
		public static explicit operator uint2(float v); // 0x000000018B275514-0x000000018B275538
		public static explicit operator uint2(float2 v); // 0x000000018B275538-0x000000018B27555C
		public static explicit operator uint2(double v); // 0x000000018B2754F4-0x000000018B275514
		public static explicit operator uint2(double2 v); // 0x000000018B2754C4-0x000000018B2754F4
		public static uint2 operator *(uint2 lhs, uint2 rhs); // 0x0000000184DB7310-0x0000000184DB7330
		public static uint2 operator *(uint2 lhs, uint rhs); // 0x0000000184DB72F0-0x0000000184DB7310
		public static uint2 operator +(uint2 lhs, uint2 rhs); // 0x0000000184D85C70-0x0000000184D85C90
		public static uint2 operator +(uint2 lhs, uint rhs); // 0x0000000184DB72B0-0x0000000184DB72D0
		public static uint2 operator -(uint2 lhs, uint2 rhs); // 0x0000000184D85C90-0x0000000184D85CB0
		public static uint2 operator -(uint2 lhs, uint rhs); // 0x0000000184DB7360-0x0000000184DB7380
		public static bool2 operator >(uint2 lhs, uint rhs); // 0x000000018B29B5AC-0x000000018B29B5C4
		public static uint2 operator <<(uint2 x, int n); // 0x0000000184DB87E0-0x0000000184DB8810
		public static uint2 operator >>(uint2 x, int n); // 0x0000000184DB8810-0x0000000184DB8840
		public static bool2 operator ==(uint2 lhs, uint rhs); // 0x000000018B29B594-0x000000018B29B5AC
		public static uint2 operator &(uint2 lhs, uint rhs); // 0x0000000184DB87A0-0x0000000184DB87C0
		public static uint2 operator |(uint2 lhs, uint2 rhs); // 0x0000000184DB72D0-0x0000000184DB72F0
		public static uint2 operator ^(uint2 lhs, uint2 rhs); // 0x0000000184DB87C0-0x0000000184DB87E0
		public bool Equals(uint2 rhs); // 0x00000001863516B4-0x00000001863516C8
		public override bool Equals(object o); // 0x000000018B29B360-0x000000018B29B3D4
		public override int GetHashCode(); // 0x000000018B29B3D4-0x000000018B29B408
		public override string ToString(); // 0x000000018B29B490-0x000000018B29B518
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29B408-0x000000018B29B490
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x2 : IEquatable<Unity.Mathematics.uint2x2>, IFormattable // TypeDefIndex: 57254
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public static readonly uint2x2 identity; // 0x00
	
		// Constructors
		public uint2x2(uint2 c0, uint2 c1); // 0x0000000184D861B0-0x0000000184D861C0
		public uint2x2(uint m00, uint m01, uint m10, uint m11); // 0x0000000184DB74F0-0x0000000184DB7520
		public uint2x2(uint v); // 0x0000000184DB7430-0x0000000184DB7460
		public uint2x2(bool v); // 0x000000018B290618-0x000000018B290660
		public uint2x2(bool2x2 v); // 0x000000018B2905A8-0x000000018B290618
		public uint2x2(int v); // 0x0000000184DB7430-0x0000000184DB7460
		public uint2x2(int2x2 v); // 0x0000000184DB7520-0x0000000184DB7560
		public uint2x2(float v); // 0x0000000185F3AF40-0x0000000185F3AF68
		public uint2x2(float2x2 v); // 0x0000000185F3AF08-0x0000000185F3AF40
		public uint2x2(double v); // 0x000000018B29B954-0x000000018B29B998
		public uint2x2(double2x2 v); // 0x000000018B29B8FC-0x000000018B29B954
		static uint2x2(); // 0x0000000184CEADF0-0x0000000184CEAE50
	
		// Methods
		public bool Equals(uint2x2 rhs); // 0x000000018B287F80-0x000000018B28B100
		public override bool Equals(object o); // 0x000000018B29B5C4-0x000000018B29B630
		public override int GetHashCode(); // 0x000000018B29B630-0x000000018B29B64C
		public override string ToString(); // 0x000000018B29B7A0-0x000000018B29B8FC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29B64C-0x000000018B29B7A0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x3 : IEquatable<Unity.Mathematics.uint2x3>, IFormattable // TypeDefIndex: 57255
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public uint2 c2; // 0x10
	
		// Constructors
		public uint2x3(uint2 c0, uint2 c1, uint2 c2); // 0x0000000184D8C0D0-0x0000000184D8C0E0
		public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12); // 0x0000000184DB7750-0x0000000184DB77A0
		public uint2x3(uint v); // 0x0000000184DB76C0-0x0000000184DB7700
		public uint2x3(bool v); // 0x000000018B290B74-0x000000018B290BD8
		public uint2x3(bool2x3 v); // 0x000000018B290ADC-0x000000018B290B74
		public uint2x3(int v); // 0x0000000184DB76C0-0x0000000184DB7700
		public uint2x3(int2x3 v); // 0x0000000184DB7700-0x0000000184DB7750
		public uint2x3(float v); // 0x0000000185F3B020-0x0000000185F3B1F8
		public uint2x3(float2x3 v); // 0x0000000185F3AF68-0x0000000185F3B020
		public uint2x3(double v); // 0x000000018B29BDB0-0x000000018B29BE0C
		public uint2x3(double2x3 v); // 0x000000018B29BE0C-0x000000018B29BE88
	
		// Methods
		public bool Equals(uint2x3 rhs); // 0x000000018B290660-0x000000018B2906C4
		public override bool Equals(object o); // 0x000000018B29B998-0x000000018B29BA0C
		public override int GetHashCode(); // 0x000000018B29BA0C-0x000000018B29BA34
		public override string ToString(); // 0x000000018B29BA34-0x000000018B29BBFC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29BBFC-0x000000018B29BDB0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x4 : IEquatable<Unity.Mathematics.uint2x4>, IFormattable // TypeDefIndex: 57256
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public uint2 c2; // 0x10
		public uint2 c3; // 0x18
	
		// Constructors
		public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3); // 0x0000000184D861C0-0x0000000184D861E0
		public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13); // 0x0000000184DB78A0-0x0000000184DB7900
		public uint2x4(uint v); // 0x0000000184DB7980-0x0000000184DB79D0
		public uint2x4(bool v); // 0x000000018B2911F4-0x000000018B291278
		public uint2x4(bool2x4 v); // 0x000000018B291128-0x000000018B2911F4
		public uint2x4(int v); // 0x0000000184DB7980-0x0000000184DB79D0
		public uint2x4(int2x4 v); // 0x0000000184DB7830-0x0000000184DB78A0
		public uint2x4(float v); // 0x0000000185F3B1F8-0x0000000185F3B238
		public uint2x4(float2x4 v); // 0x0000000185F3B238-0x0000000185F3B2AC
		public uint2x4(double v); // 0x000000018B29C404-0x000000018B29C47C
		public uint2x4(double2x4 v); // 0x000000018B29C364-0x000000018B29C404
	
		// Methods
		public bool Equals(uint2x4 rhs); // 0x000000018B290C4C-0x000000018B290CC0
		public override bool Equals(object o); // 0x000000018B29BE88-0x000000018B29BEFC
		public override int GetHashCode(); // 0x000000018B29BEFC-0x000000018B29BF20
		public override string ToString(); // 0x000000018B29BF20-0x000000018B29C150
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29C150-0x000000018B29C364
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3 : IEquatable<Unity.Mathematics.uint3>, IFormattable // TypeDefIndex: 57258
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzz { get; } // 0x0000000184DB5490-0x0000000184DB54B0 
		public uint this[int index] { get => default; set {} } // 0x0000000184DB7B60-0x0000000184DB7B70 0x0000000184DB73A0-0x0000000184DB73B0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57257
		{
		}
	
		// Constructors
		public uint3(uint x, uint y, uint z); // 0x0000000184D85D60-0x0000000184D85D70
		public uint3(uint x, uint2 yz); // 0x0000000184DB7AB0-0x0000000184DB7AC0
		public uint3(uint2 xy, uint z); // 0x0000000184DB7B50-0x0000000184DB7B60
		public uint3(uint3 xyz); // 0x0000000184D88F40-0x0000000184D88F60
		public uint3(uint v); // 0x0000000184DB7B20-0x0000000184DB7B30
		public uint3(bool v); // 0x000000018B29149C-0x000000018B2914B0
		public uint3(bool3 v); // 0x000000018B291470-0x000000018B29149C
		public uint3(int v); // 0x0000000184DB7B20-0x0000000184DB7B30
		public uint3(int3 v); // 0x0000000184D88F40-0x0000000184D88F60
		public uint3(float v); // 0x0000000185F3B2F8-0x0000000185F3B330
		public uint3(float3 v); // 0x0000000185F3B2AC-0x0000000185F3B2F8
		public uint3(double v); // 0x000000018B29C6C8-0x000000018B29C6EC
		public uint3(double3 v); // 0x000000018B29C698-0x000000018B29C6C8
	
		// Methods
		public static implicit operator uint3(uint v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static explicit operator uint3(int v); // 0x0000000184DB02F0-0x0000000184DB0300
		public static explicit operator uint3(int3 v); // 0x0000000184DB0370-0x0000000184DB03A0
		public static explicit operator uint3(float v); // 0x000000018B275808-0x000000018B275824
		public static explicit operator uint3(float3 v); // 0x0000000185F3B330-0x0000000185F3B37C
		public static explicit operator uint3(double v); // 0x000000018B2757E0-0x000000018B275808
		public static explicit operator uint3(double3 v); // 0x000000018B2757A8-0x000000018B2757E0
		public static uint3 operator *(uint3 lhs, uint3 rhs); // 0x0000000183C87E40-0x0000000183C87E70
		public static uint3 operator *(uint3 lhs, uint rhs); // 0x0000000184DB7C00-0x0000000184DB7C20
		public static uint3 operator +(uint3 lhs, uint3 rhs); // 0x000000018338E380-0x000000018338E3A0
		public static uint3 operator +(uint3 lhs, uint rhs); // 0x0000000184DB7BB0-0x0000000184DB7BE0
		public static uint3 operator -(uint3 lhs, uint3 rhs); // 0x0000000184DB7C70-0x0000000184DB7C90
		public static uint3 operator -(uint3 lhs, uint rhs); // 0x0000000184DB7C50-0x0000000184DB7C70
		public static bool3 operator >(uint3 lhs, uint rhs); // 0x000000018B29C70C-0x000000018B29C72C
		public static uint3 operator <<(uint3 x, int n); // 0x0000000184DB8880-0x0000000184DB88B0
		public static uint3 operator >>(uint3 x, int n); // 0x0000000184DB88B0-0x0000000184DB88F0
		public static bool3 operator ==(uint3 lhs, uint rhs); // 0x000000018B29C6EC-0x000000018B29C70C
		public static uint3 operator &(uint3 lhs, uint rhs); // 0x0000000184DB8840-0x0000000184DB8860
		public static uint3 operator |(uint3 lhs, uint3 rhs); // 0x0000000184DB7BE0-0x0000000184DB7C00
		public static uint3 operator |(uint lhs, uint3 rhs); // 0x0000000184DB8860-0x0000000184DB8880
		public static uint3 operator ^(uint3 lhs, uint3 rhs); // 0x00000001830E9510-0x00000001830E9530
		public bool Equals(uint3 rhs); // 0x0000000186351A88-0x0000000186351AA4
		public override bool Equals(object o); // 0x000000018B29C47C-0x000000018B29C510
		public override int GetHashCode(); // 0x000000018B29C510-0x000000018B29C534
		public override string ToString(); // 0x000000018B29C5E4-0x000000018B29C698
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29C534-0x000000018B29C5E4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x2 : IEquatable<Unity.Mathematics.uint3x2>, IFormattable // TypeDefIndex: 57259
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
	
		// Constructors
		public uint3x2(uint3 c0, uint3 c1); // 0x0000000184D871E0-0x0000000184D87200
		public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21); // 0x0000000184DB7CB0-0x0000000184DB7CF0
		public uint3x2(uint v); // 0x0000000184DB7D40-0x0000000184DB7D70
		public uint3x2(bool v); // 0x0000000185F051A0-0x0000000185F05370
		public uint3x2(bool3x2 v); // 0x000000018B291A00-0x000000018B291AEC
		public uint3x2(int v); // 0x0000000184DB7D40-0x0000000184DB7D70
		public uint3x2(int3x2 v); // 0x0000000185F05370-0x0000000185F053E4
		public uint3x2(float v); // 0x0000000185F3B37C-0x0000000185F3B3D8
		public uint3x2(float3x2 v); // 0x0000000185F3B3D8-0x0000000185F3B4DC
		public uint3x2(double v); // 0x000000018B29CB44-0x000000018B29CBA0
		public uint3x2(double3x2 v); // 0x000000018B29CBA0-0x000000018B29CC30
	
		// Methods
		public bool Equals(uint3x2 rhs); // 0x00000001866ACFB0-0x00000001866AD020
		public override bool Equals(object o); // 0x000000018B29C72C-0x000000018B29C7A0
		public override int GetHashCode(); // 0x000000018B29C7A0-0x000000018B29C7C8
		public override string ToString(); // 0x000000018B29C97C-0x000000018B29CB44
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29C7C8-0x000000018B29C97C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x3 : IEquatable<Unity.Mathematics.uint3x3>, IFormattable // TypeDefIndex: 57260
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
		public uint3 c2; // 0x18
		public static readonly uint3x3 identity; // 0x00
	
		// Constructors
		public uint3x3(uint3 c0, uint3 c1, uint3 c2); // 0x0000000184D8C690-0x0000000184D8C6D0
		public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22); // 0x0000000184B832D0-0x0000000184B83330
		public uint3x3(uint v); // 0x0000000184DB7DC0-0x0000000184DB7E10
		public uint3x3(bool v); // 0x0000000185F05648-0x0000000185F056D8
		public uint3x3(bool3x3 v); // 0x000000018B2920DC-0x000000018B292224
		public uint3x3(int v); // 0x0000000184DB7DC0-0x0000000184DB7E10
		public uint3x3(int3x3 v); // 0x0000000185F056D8-0x0000000185F05824
		public uint3x3(float v); // 0x0000000185F3B560-0x0000000185F3B6A4
		public uint3x3(float3x3 v); // 0x0000000185F3B6A4-0x0000000185F3B854
		public uint3x3(double v); // 0x0000000185F3B4DC-0x0000000185F3B560
		public uint3x3(double3x3 v); // 0x000000018B29D180-0x000000018B29D24C
		static uint3x3(); // 0x0000000184B83230-0x0000000184B832D0
	
		// Methods
		public bool Equals(uint3x3 rhs); // 0x000000018B291B68-0x000000018B291C08
		public override bool Equals(object o); // 0x000000018B29CC30-0x000000018B29CCAC
		public override int GetHashCode(); // 0x000000018B29CCAC-0x000000018B29CCD8
		public override string ToString(); // 0x000000018B29CCD8-0x000000018B29CF3C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29CF3C-0x000000018B29D180
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x4 : IEquatable<Unity.Mathematics.uint3x4>, IFormattable // TypeDefIndex: 57261
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
		public uint3 c2; // 0x18
		public uint3 c3; // 0x24
	
		// Constructors
		public uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3); // 0x0000000184DB65D0-0x0000000184DB6620
		public uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23); // 0x0000000184DB8070-0x0000000184DB8100
		public uint3x4(uint v); // 0x0000000184DB7F80-0x0000000184DB7FE0
		public uint3x4(bool v); // 0x0000000185F059CC-0x0000000185F05D4C
		public uint3x4(bool3x4 v); // 0x000000018B292A08-0x000000018B292B9C
		public uint3x4(int v); // 0x0000000184DB7F80-0x0000000184DB7FE0
		public uint3x4(int3x4 v); // 0x0000000185F05824-0x0000000185F058F8
		public uint3x4(float v); // 0x0000000185F3B854-0x0000000185F3B8F0
		public uint3x4(float3x4 v); // 0x0000000185F3B998-0x0000000185F3BA6C
		public uint3x4(double v); // 0x0000000185F3B8F0-0x0000000185F3B998
		public uint3x4(double3x4 v); // 0x000000018B29D8CC-0x000000018B29D9D8
	
		// Methods
		public bool Equals(uint3x4 rhs); // 0x000000018B292348-0x000000018B292404
		public override bool Equals(object o); // 0x000000018B29D24C-0x000000018B29D2C8
		public override int GetHashCode(); // 0x000000018B29D2C8-0x000000018B29D2F8
		public override string ToString(); // 0x000000018B29D5CC-0x000000018B29D8CC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29D2F8-0x000000018B29D5CC
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4 : IEquatable<Unity.Mathematics.uint4>, IFormattable // TypeDefIndex: 57263
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
		public uint w; // 0x0C
	
		// Properties
		public uint this[int index] { get => default; set {} } // 0x0000000184DB7B60-0x0000000184DB7B70 0x0000000184DB73A0-0x0000000184DB73B0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 57262
		{
		}
	
		// Constructors
		public uint4(uint x, uint y, uint z, uint w); // 0x0000000184D88C10-0x0000000184D88C30
		public uint4(uint x, uint y, uint2 zw); // 0x0000000184DB8100-0x0000000184DB8120
		public uint4(uint x, uint2 yz, uint w); // 0x0000000184DB8200-0x0000000184DB8220
		public uint4(uint x, uint3 yzw); // 0x0000000184DB81D0-0x0000000184DB81F0
		public uint4(uint2 xy, uint z, uint w); // 0x0000000184DB8220-0x0000000184DB8240
		public uint4(uint2 xy, uint2 zw); // 0x0000000184DB8120-0x0000000184DB8140
		public uint4(uint3 xyz, uint w); // 0x0000000184DB81B0-0x0000000184DB81D0
		public uint4(uint4 xyzw); // 0x0000000184D92B90-0x0000000184D92BB0
		public uint4(uint v); // 0x0000000184DB8160-0x0000000184DB8170
		public uint4(bool v); // 0x000000018B292FB0-0x000000018B292FCC
		public uint4(bool4 v); // 0x000000018B292FCC-0x000000018B293010
		public uint4(int v); // 0x0000000184DB8160-0x0000000184DB8170
		public uint4(int4 v); // 0x0000000184D92B90-0x0000000184D92BB0
		public uint4(float v); // 0x0000000185F3BAD0-0x0000000185F3BC08
		public uint4(float4 v); // 0x0000000185F3BA6C-0x0000000185F3BAD0
		public uint4(double v); // 0x000000018B29DD10-0x000000018B29DD3C
		public uint4(double4 v); // 0x000000018B29DD3C-0x000000018B29DD78
	
		// Methods
		public static implicit operator uint4(uint v); // 0x0000000184DB0420-0x0000000184DB0430
		public static explicit operator uint4(int v); // 0x0000000184DB0420-0x0000000184DB0430
		public static explicit operator uint4(int4 v); // 0x000000018B25AC78-0x000000018B25ACA4
		public static explicit operator uint4(float v); // 0x000000018B275B1C-0x000000018B275B34
		public static explicit operator uint4(float4 v); // 0x000000018B275B64-0x000000018B275B88
		public static explicit operator uint4(double v); // 0x000000018B275B34-0x000000018B275B64
		public static explicit operator uint4(double4 v); // 0x000000018B275AD4-0x000000018B275B1C
		public static uint4 operator *(uint4 lhs, uint4 rhs); // 0x0000000184DB82A0-0x0000000184DB82D0
		public static uint4 operator *(uint4 lhs, uint rhs); // 0x0000000184DB82D0-0x0000000184DB8300
		public static uint4 operator *(uint lhs, uint4 rhs); // 0x0000000184DB8950-0x0000000184DB8980
		public static uint4 operator +(uint4 lhs, uint4 rhs); // 0x0000000184DB8270-0x0000000184DB82A0
		public static uint4 operator +(uint4 lhs, uint rhs); // 0x0000000184DB8240-0x0000000184DB8270
		public static uint4 operator -(uint4 lhs, uint4 rhs); // 0x0000000184DB89D0-0x0000000184DB8A00
		public static uint4 operator -(uint4 lhs, uint rhs); // 0x0000000184DB8330-0x0000000184DB8360
		public static bool4 operator >(uint4 lhs, uint rhs); // 0x000000018B29DD9C-0x000000018B29DDC0
		public static uint4 operator <<(uint4 x, int n); // 0x0000000184DB8920-0x0000000184DB8950
		public static uint4 operator >>(uint4 x, int n); // 0x0000000184DB8980-0x0000000184DB89D0
		public static bool4 operator ==(uint4 lhs, uint rhs); // 0x000000018B29DD78-0x000000018B29DD9C
		public static uint4 operator ~(uint4 val); // 0x00000001834C9860-0x00000001834C9890
		public static uint4 operator &(uint4 lhs, uint4 rhs); // 0x00000001834C9800-0x00000001834C9830
		public static uint4 operator &(uint4 lhs, uint rhs); // 0x0000000184DB88F0-0x0000000184DB8920
		public static uint4 operator |(uint4 lhs, uint4 rhs); // 0x00000001834C9890-0x00000001834C98C0
		public static uint4 operator ^(uint4 lhs, uint4 rhs); // 0x00000001834C9830-0x00000001834C9860
		public bool Equals(uint4 rhs); // 0x00000001868AFB90-0x00000001868AFBB4
		public override bool Equals(object o); // 0x000000018B29D9D8-0x000000018B29DA44
		public override int GetHashCode(); // 0x000000018B29DA44-0x000000018B29DA60
		public override string ToString(); // 0x000000018B29DBB4-0x000000018B29DD10
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29DA60-0x000000018B29DBB4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x2 : IEquatable<Unity.Mathematics.uint4x2>, IFormattable // TypeDefIndex: 57264
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
	
		// Constructors
		public uint4x2(uint4 c0, uint4 c1); // 0x0000000184D8C810-0x0000000184D8C820
		public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31); // 0x0000000184DB83B0-0x0000000184DB8400
		public uint4x2(uint v); // 0x0000000183BACBE0-0x0000000183BACC20
		public uint4x2(bool v); // 0x0000000185F3BC08-0x0000000185F3BC7C
		public uint4x2(bool4x2 v); // 0x0000000185F3BD80-0x0000000185F3BEC0
		public uint4x2(int v); // 0x0000000183BACBE0-0x0000000183BACC20
		public uint4x2(int4x2 v); // 0x000000018B2935DC-0x000000018B293644
		public uint4x2(float v); // 0x0000000185F3BCE8-0x0000000185F3BD80
		public uint4x2(float4x2 v); // 0x000000018B29E338-0x000000018B29E38C
		public uint4x2(double v); // 0x0000000185F3BC7C-0x0000000185F3BCE8
		public uint4x2(double4x2 v); // 0x000000018B29E29C-0x000000018B29E338
	
		// Methods
		public bool Equals(uint4x2 rhs); // 0x000000018B293058-0x000000018B29309C
		public override bool Equals(object o); // 0x000000018B29DDC0-0x000000018B29DE34
		public override int GetHashCode(); // 0x000000018B29DE34-0x000000018B29DE58
		public override string ToString(); // 0x000000018B29DE58-0x000000018B29E088
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29E088-0x000000018B29E29C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x3 : IEquatable<Unity.Mathematics.uint4x3>, IFormattable // TypeDefIndex: 57265
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
		public uint4 c2; // 0x20
	
		// Constructors
		public uint4x3(uint4 c0, uint4 c1, uint4 c2); // 0x0000000184DA0760-0x0000000184DA0780
		public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32); // 0x0000000184DB84E0-0x0000000184DB8560
		public uint4x3(uint v); // 0x0000000184DB8560-0x0000000184DB85B0
		public uint4x3(bool v); // 0x0000000185F3C1BC-0x0000000185F3C260
		public uint4x3(bool4x3 v); // 0x0000000185F3BF60-0x0000000185F3C06C
		public uint4x3(int v); // 0x0000000184DB8560-0x0000000184DB85B0
		public uint4x3(int4x3 v); // 0x000000018B293D24-0x000000018B293DAC
		public uint4x3(float v); // 0x0000000185F3C06C-0x0000000185F3C1BC
		public uint4x3(float4x3 v); // 0x000000018B29EA0C-0x000000018B29EA84
		public uint4x3(double v); // 0x0000000185F3BEC0-0x0000000185F3BF60
		public uint4x3(double4x3 v); // 0x000000018B29EA84-0x000000018B29EB6C
	
		// Methods
		public bool Equals(uint4x3 rhs); // 0x000000018B2936C0-0x000000018B293720
		public override bool Equals(object o); // 0x000000018B29E38C-0x000000018B29E408
		public override int GetHashCode(); // 0x000000018B29E408-0x000000018B29E438
		public override string ToString(); // 0x000000018B29E438-0x000000018B29E738
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29E738-0x000000018B29EA0C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x4 : IEquatable<Unity.Mathematics.uint4x4>, IFormattable // TypeDefIndex: 57266
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
		public uint4 c2; // 0x20
		public uint4 c3; // 0x30
		public static readonly uint4x4 identity; // 0x00
	
		// Constructors
		public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3); // 0x0000000184DB3220-0x0000000184DB3250
		public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33); // 0x0000000184A3ADB0-0x0000000184A3AE60
		public uint4x4(uint v); // 0x0000000184DB8690-0x0000000184DB86F0
		public uint4x4(bool v); // 0x0000000185F3C260-0x0000000185F3C334
		public uint4x4(bool4x4 v); // 0x0000000185F3C5B4-0x0000000185F3C794
		public uint4x4(int v); // 0x0000000184DB8690-0x0000000184DB86F0
		public uint4x4(int4x4 v); // 0x000000018B2946D4-0x000000018B294780
		public uint4x4(float v); // 0x0000000185F3C404-0x0000000185F3C5B4
		public uint4x4(float4x4 v); // 0x000000018B29F4BC-0x000000018B29F550
		public uint4x4(double v); // 0x0000000185F3C334-0x0000000185F3C404
		public uint4x4(double4x4 v); // 0x000000018B29F38C-0x000000018B29F4BC
		static uint4x4(); // 0x0000000184A3ACC0-0x0000000184A3ADB0
	
		// Methods
		public bool Equals(uint4x4 rhs); // 0x000000018B293EBC-0x000000018B293F38
		public override bool Equals(object o); // 0x000000018B29EB6C-0x000000018B29EBF0
		public override int GetHashCode(); // 0x000000018B29EBF0-0x000000018B29EC28
		public override string ToString(); // 0x000000018B29EC28-0x000000018B29EFF8
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018B29EFF8-0x000000018B29F38C
	}
}
