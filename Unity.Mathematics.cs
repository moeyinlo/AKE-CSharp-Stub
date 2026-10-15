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

// Image 62: Unity.Mathematics.dll - Assembly: Unity.Mathematics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 88870-88929

namespace Unity.IL2CPP.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 88871
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Mathematics
{
	[Il2CppEagerStaticClassConstruction]
	public static class math // TypeDefIndex: 88875
	{
		// Nested types
		public enum RotationOrder : byte // TypeDefIndex: 88872
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			Default = 4,
			ZYX = 5
		}
	
		public enum ShuffleComponent : byte // TypeDefIndex: 88873
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
	
		internal struct LongDoubleUnion // TypeDefIndex: 88874
		{
			// Fields
			public long longValue; // 0x00
			public double doubleValue; // 0x00
		}
	
		// Methods
		public static uint hash(bool2 v); // 0x000000018D39E44C-0x000000018D39E494
		public static bool3 bool3(bool x, bool y, bool z); // 0x000000018725CBA0-0x000000018725CBB0
		public static uint hash(bool3 v); // 0x000000018D39DFA4-0x000000018D39DFF0
		public static uint hash(bool4 v); // 0x000000018D39767C-0x000000018D3978E4
		public static uint hash(bool4x4 v); // 0x000000018D3978E4-0x000000018D397C20
		public static uint hash(double2 v); // 0x000000018D3989B8-0x000000018D398A00
		public static uint hash(double3 v); // 0x000000018D39E494-0x000000018D39E524
		public static uint hash(double3x2 v); // 0x000000018D39D5D0-0x000000018D39D6FC
		public static uint hash(double3x3 v); // 0x000000018D39E1D0-0x000000018D39E388
		public static uint hash(double3x4 v); // 0x000000018D39D6FC-0x000000018D39D944
		public static double4 double4(double x, double y, double z, double w); // 0x000000018725CFF0-0x000000018725D010
		public static double4 double4(double v); // 0x000000018725CFE0-0x000000018725CFF0
		public static uint hash(double4 v); // 0x000000018D39DF18-0x000000018D39DFA4
		public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018D3A2D6C-0x000000018D3A2EA0
		internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component); // 0x000000018D3A2B04-0x000000018D3A2C38
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2); // 0x000000018725D010-0x000000018725D050
		public static uint hash(double4x3 v); // 0x000000018D39E524-0x000000018D39E6B4
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3); // 0x000000018725D050-0x000000018725D0A0
		public static double3 transform(double4x4 a, double3 b); // 0x000000018D3A33E0-0x000000018D3A3564
		public static double4x4 inverse(double4x4 m); // 0x000000018D39EC24-0x000000018D39FB38
		public static uint hash(double4x4 v); // 0x000000018D39DD0C-0x000000018D39DF18
		public static float2 float2(float x, float y); // 0x000000018725D0A0-0x000000018725D0B0
		public static uint hash(float2 v); // 0x000000018D39D598-0x000000018D39D5D0
		public static float3 float3(float x, float y, float z); // 0x0000000187250490-0x00000001872504B0
		public static float3 float3(float x, float2 yz); // 0x000000018725D0B0-0x000000018725D0E0
		public static uint hash(float3 v); // 0x00000001885A5A5C-0x00000001885A5AD0
		public static uint hash(float3x2 v); // 0x000000018D39EB44-0x000000018D39EC24
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2); // 0x0000000185B95850-0x0000000185B95950
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22); // 0x0000000188CD4550-0x0000000188CD4A28
		public static float3x3 transpose(float3x3 v); // 0x000000018D3A3660-0x000000018D3A36E4
		public static uint hash(float3x3 v); // 0x000000018D39E924-0x000000018D39EA78
		public static uint hash(float3x4 v); // 0x000000018D39D9B0-0x000000018D39DB7C
		public static float4 float4(float x, float y, float z, float w); // 0x000000018725D0E0-0x000000018725D100
		public static float4 float4(float3 xyz, float w); // 0x000000018725D130-0x000000018725D160
		public static float4 float4(float v); // 0x000000018725D100-0x000000018725D110
		public static float4 float4(int v); // 0x000000018725D110-0x000000018725D130
		public static uint hash(float4 v); // 0x000000018D39E064-0x000000018D39E0D0
		public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w); // 0x000000018D3A2EA0-0x000000018D3A2F88
		internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component); // 0x000000018D3A2C38-0x000000018D3A2D6C
		public static uint hash(float4x2 v); // 0x000000018D39E104-0x000000018D39E1D0
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2); // 0x000000018725D160-0x000000018725D180
		public static uint hash(float4x3 v); // 0x000000018D39E780-0x000000018D39E8B0
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3); // 0x000000018725D180-0x000000018725D1B0
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33); // 0x000000018D39D298-0x000000018D39D3C0
		public static float3 rotate(float4x4 a, float3 b); // 0x000000018D3A27E8-0x000000018D3A28C0
		public static float3 transform(float4x4 a, float3 b); // 0x000000018D3A3564-0x000000018D3A3660
		public static float4x4 inverse(float4x4 m); // 0x00000001859E0200-0x00000001859E0F10
		public static float4x4 fastinverse(float4x4 m); // 0x000000018D39CF60-0x000000018D39D260
		public static float determinant(float4x4 m); // 0x000000018725CD00-0x000000018725CF70
		public static uint hash(float4x4 v); // 0x000000018D39DB7C-0x000000018D39DD0C
		public static uint hash(half2 v); // 0x000000018D39EA78-0x000000018D39EABC
		public static uint hash(half3 v); // 0x000000018D39D518-0x000000018D39D598
		public static uint hash(half4 v); // 0x000000018D39D47C-0x000000018D39D518
		public static uint hash(int2 v); // 0x000000018D39E388-0x000000018D39E3BC
		public static uint hash(int2x3 v); // 0x000000018D39E3BC-0x000000018D39E44C
		public static int3 int3(float3 v); // 0x000000018725D440-0x000000018725D470
		public static uint hash(int3 v); // 0x000000018D39E8B0-0x000000018D39E924
		public static uint hash(int4 v); // 0x000000018D39EABC-0x000000018D39EB28
		public static uint hash(int4x2 v); // 0x000000018D39E6B4-0x000000018D39E780
		public static int asint(float x); // 0x00000001872413F0-0x0000000187241400
		public static uint2 asuint(int2 x); // 0x0000000185BD80B0-0x0000000185BD80C0
		public static uint3 asuint(int3 x); // 0x000000018723AE60-0x000000018723AE80
		public static uint4 asuint(int4 x); // 0x000000018723AC80-0x000000018723AC90
		public static uint asuint(float x); // 0x00000001872413F0-0x0000000187241400
		public static uint2 asuint(float2 x); // 0x000000018725CB80-0x000000018725CB90
		public static uint3 asuint(float3 x); // 0x000000018723AE60-0x000000018723AE80
		public static uint4 asuint(float4 x); // 0x000000018723AC80-0x000000018723AC90
		public static ulong asulong(double x); // 0x0000000187252820-0x0000000187252830
		public static float asfloat(int x); // 0x0000000187241420-0x0000000187241430
		public static float asfloat(uint x); // 0x0000000187241420-0x0000000187241430
		public static float3 asfloat(uint3 x); // 0x000000018723AE60-0x000000018723AE80
		public static float4 asfloat(uint4 x); // 0x000000018723AC80-0x000000018723AC90
		public static int bitmask(bool4 value); // 0x000000018D39C79C-0x000000018D39C7D8
		public static double asdouble(ulong x); // 0x0000000187252830-0x0000000187252840
		public static bool isfinite(float x); // 0x000000018D39FC18-0x000000018D39FC34
		public static bool4 isfinite(float4 x); // 0x000000018D39FBB4-0x000000018D39FC18
		public static bool isinf(float x); // 0x0000000188CF7100-0x0000000188CF71E0
		public static bool isnan(float x); // 0x000000018D39FC94-0x000000018D39FCA8
		public static bool3 isnan(float3 x); // 0x000000018D39FD24-0x000000018D39FD94
		public static bool4 isnan(float4 x); // 0x000000018D39FCA8-0x000000018D39FD24
		public static bool3 isnan(double3 x); // 0x000000018D39FC34-0x000000018D39FC94
		public static int min(int x, int y); // 0x000000018D3A0268-0x000000018D3A0270
		public static int3 min(int3 x, int3 y); // 0x000000018D3A0384-0x000000018D3A03B8
		public static uint min(uint x, uint y); // 0x000000018D3A037C-0x000000018D3A0384
		public static long min(long x, long y); // 0x000000018D3A0370-0x000000018D3A037C
		public static float min(float x, float y); // 0x000000018D3A035C-0x000000018D3A0370
		public static float3 min(float3 x, float3 y); // 0x000000018D3A02DC-0x000000018D3A0344
		public static float4 min(float4 x, float4 y); // 0x00000001889ECAD4-0x00000001889ECB5C
		public static double min(double x, double y); // 0x000000018D3A0344-0x000000018D3A035C
		public static double3 min(double3 x, double3 y); // 0x000000018D3A0270-0x000000018D3A02DC
		public static int max(int x, int y); // 0x000000018D3A01E0-0x000000018D3A01E8
		public static int3 max(int3 x, int3 y); // 0x000000018D3A0110-0x000000018D3A0144
		public static long max(long x, long y); // 0x000000018D3A025C-0x000000018D3A0268
		public static float max(float x, float y); // 0x000000018D3A01B4-0x000000018D3A01C8
		public static float3 max(float3 x, float3 y); // 0x000000018D3A0144-0x000000018D3A01B4
		public static float4 max(float4 x, float4 y); // 0x00000001889ECA44-0x00000001889ECAD4
		public static double max(double x, double y); // 0x000000018D3A01C8-0x000000018D3A01E0
		public static double3 max(double3 x, double3 y); // 0x000000018D3A01E8-0x000000018D3A025C
		public static float lerp(float start, float end, float t); // 0x00000001872368B0-0x00000001872368C0
		public static float2 lerp(float2 start, float2 end, float t); // 0x000000018D39FF58-0x000000018D39FF94
		public static float3 lerp(float3 start, float3 end, float t); // 0x00000001889EC850-0x00000001889EC8FC
		public static float4 lerp(float4 start, float4 end, float t); // 0x000000018D39FF94-0x000000018D3A0010
		public static double lerp(double start, double end, double t); // 0x000000018725D480-0x000000018725D490
		public static double3 lerp(double3 start, double3 end, double t); // 0x000000018D39FE98-0x000000018D39FF58
		public static float unlerp(float start, float end, float x); // 0x000000018D3A3790-0x000000018D3A37A0
		public static float remap(float srcStart, float srcEnd, float dstStart, float dstEnd, float x); // 0x000000018D3A27C4-0x000000018D3A27E8
		public static float mad(float mulA, float mulB, float addC); // 0x000000018725D490-0x000000018725D4A0
		public static int clamp(int valueToClamp, int lowerBound, int upperBound); // 0x000000018D39C984-0x000000018D39C998
		public static float clamp(float valueToClamp, float lowerBound, float upperBound); // 0x000000018D39C998-0x000000018D39C9C0
		public static float3 clamp(float3 valueToClamp, float3 lowerBound, float3 upperBound); // 0x000000018D39C8F8-0x000000018D39C984
		public static float4 clamp(float4 valueToClamp, float4 lowerBound, float4 upperBound); // 0x000000018D39C890-0x000000018D39C8F8
		public static double clamp(double valueToClamp, double lowerBound, double upperBound); // 0x00000001889CA910-0x00000001889CABF8
		public static float saturate(float x); // 0x000000018C35E3AC-0x000000018C35E3BC
		public static float3 saturate(float3 x); // 0x000000018C125280-0x000000018C1252F8
		public static float4 saturate(float4 x); // 0x000000018D3A2988-0x000000018D3A29D4
		public static double saturate(double x); // 0x000000018D3A2978-0x000000018D3A2988
		public static int abs(int x); // 0x000000018D39C4D0-0x000000018D39C4DC
		public static float abs(float x); // 0x000000018725CB50-0x000000018725CB60
		public static float3 abs(float3 x); // 0x00000001852109A0-0x00000001852109E0
		public static float4 abs(float4 x); // 0x000000018D39C49C-0x000000018D39C4D0
		public static double abs(double x); // 0x000000018725CB60-0x000000018725CB80
		public static float dot(float2 x, float2 y); // 0x0000000187238380-0x00000001872383B0
		public static float dot(float3 x, float3 y); // 0x0000000187238500-0x0000000187238530
		public static float dot(float4 x, float4 y); // 0x0000000185B95370-0x0000000185B953B0
		public static double dot(double2 x, double2 y); // 0x000000018725CFC0-0x000000018725CFE0
		public static double dot(double3 x, double3 y); // 0x000000018725CF90-0x000000018725CFC0
		public static float tan(float x); // 0x000000018D3A3388-0x000000018D3A33E0
		public static float atan2(float y, float x); // 0x000000018D39C738-0x000000018D39C79C
		public static float cos(float x); // 0x000000018D39CA58-0x000000018D39CAB0
		public static float3 cos(float3 x); // 0x000000018725CC00-0x000000018725CC50
		public static double cos(double x); // 0x000000018D39CAB0-0x000000018D39CB00
		public static float acos(float x); // 0x000000018D39C52C-0x000000018D39C584
		public static double acos(double x); // 0x000000018D39C4DC-0x000000018D39C52C
		public static float sin(float x); // 0x000000018D3A2FC0-0x000000018D3A3018
		public static float2 sin(float2 x); // 0x000000018725D510-0x000000018725D550
		public static float3 sin(float3 x); // 0x000000018725D4C0-0x000000018725D510
		public static double sin(double x); // 0x000000018D3A3018-0x000000018D3A3068
		public static float asin(float x); // 0x000000018D39C6E0-0x000000018D39C738
		public static double asin(double x); // 0x000000018D39C690-0x000000018D39C6E0
		public static float floor(float x); // 0x000000018D39D3C0-0x000000018D39D418
		public static float2 floor(float2 x); // 0x000000018725D210-0x000000018725D250
		public static float3 floor(float3 x); // 0x000000018655EE60-0x000000018655EEB0
		public static float4 floor(float4 x); // 0x000000018725D1B0-0x000000018725D210
		public static float ceil(float x); // 0x000000018D39C7D8-0x000000018D39C830
		public static float round(float x); // 0x000000018D3A28C0-0x000000018D3A2918
		public static float trunc(float x); // 0x000000018D3A36E4-0x000000018D3A3740
		public static float frac(float x); // 0x00000001872508F0-0x0000000187250920
		public static float3 frac(float3 x); // 0x000000018C1251FC-0x000000018C125280
		public static float4 frac(float4 x); // 0x000000018D39D418-0x000000018D39D47C
		public static float rcp(float x); // 0x000000018D3A27B4-0x000000018D3A27C4
		public static float3 rcp(float3 x); // 0x000000018D3A2774-0x000000018D3A27B4
		public static float sign(float x); // 0x00000001889ECC40-0x00000001889ECC68
		public static float3 sign(float3 x); // 0x000000018D3A2F88-0x000000018D3A2FC0
		public static double sign(double x); // 0x00000001889F853C-0x00000001889F8574
		public static float pow(float x, float y); // 0x000000018D3A26C0-0x000000018D3A2724
		public static float4 pow(float4 x, float4 y); // 0x0000000188A6AEF4-0x0000000188A6AF98
		public static float exp2(float x); // 0x000000018D39CEA4-0x000000018D39CF04
		public static float log(float x); // 0x000000018D3A006C-0x000000018D3A00C4
		public static float log2(float x); // 0x000000018D3A0010-0x000000018D3A006C
		public static float fmod(float x, float y); // 0x0000000187235590-0x00000001872355A0
		public static float4 fmod(float4 x, float4 y); // 0x000000018725D250-0x000000018725D2D0
		public static float sqrt(float x); // 0x000000018D3A3324-0x000000018D3A3374
		public static double sqrt(double x); // 0x000000018D3A32DC-0x000000018D3A3324
		public static float rsqrt(float x); // 0x000000018D3A2918-0x000000018D3A2948
		public static double rsqrt(double x); // 0x000000018D3A2948-0x000000018D3A2978
		public static float3 normalize(float3 x); // 0x000000018D3A2278-0x000000018D3A22EC
		public static float4 normalize(float4 x); // 0x000000018D3A221C-0x000000018D3A2278
		public static double3 normalize(double3 x); // 0x000000018D3A219C-0x000000018D3A221C
		public static float3 normalizesafe(float3 x, float3 defaultvalue = default); // 0x0000000188A5D2C4-0x0000000188A5D41C
		public static double3 normalizesafe(double3 x, double3 defaultvalue = default); // 0x000000018D3A23AC-0x000000018D3A2464
		public static float length(float2 x); // 0x00000001872383F0-0x0000000187238430
		public static float length(float3 x); // 0x000000018D39FD94-0x000000018D39FDCC
		public static double length(double3 x); // 0x000000018D39FDCC-0x000000018D39FE04
		public static float lengthsq(float2 x); // 0x00000001872383D0-0x00000001872383F0
		public static float lengthsq(float3 x); // 0x000000018D39FE3C-0x000000018D39FE70
		public static double lengthsq(double3 x); // 0x000000018D39FE04-0x000000018D39FE3C
		public static float distance(float x, float y); // 0x000000018725CF70-0x000000018725CF90
		public static float distance(float3 x, float3 y); // 0x000000018D39CD74-0x000000018D39CDDC
		public static double distance(double3 x, double3 y); // 0x000000018D39CD00-0x000000018D39CD74
		public static float distancesq(float2 x, float2 y); // 0x000000018D39CDDC-0x000000018D39CE18
		public static float distancesq(float3 x, float3 y); // 0x000000018D39CE18-0x000000018D39CE7C
		public static float3 cross(float3 x, float3 y); // 0x000000018D39CB00-0x000000018D39CBE8
		public static double3 cross(double3 x, double3 y); // 0x000000018D39CBE8-0x000000018D39CD00
		public static float smoothstep(float xMin, float xMax, float x); // 0x000000018D3A3290-0x000000018D3A32DC
		public static bool any(bool3 x); // 0x000000018D39C67C-0x000000018D39C690
		public static bool any(bool4 x); // 0x0000000188A09F34-0x0000000188A0A438
		public static bool all(bool2 x); // 0x000000018D39C584-0x000000018D39C594
		public static bool all(bool3 x); // 0x000000018D39C594-0x000000018D39C5A8
		public static bool all(bool4 x); // 0x0000000188A09F14-0x0000000188A09F34
		public static bool all(int3 x); // 0x00000001889F8524-0x00000001889F853C
		public static bool all(float3 x); // 0x000000018D39C5A8-0x000000018D39C5D4
		public static int select(int falseValue, int trueValue, bool test); // 0x000000018D3A29D4-0x000000018D3A29E0
		public static uint select(uint falseValue, uint trueValue, bool test); // 0x000000018D3A29D4-0x000000018D3A29E0
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test); // 0x000000018D3A2A88-0x000000018D3A2AB8
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool3 test); // 0x000000018D3A29E0-0x000000018D3A2A20
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test); // 0x000000018D397C20-0x000000018D397F94
		public static float select(float falseValue, float trueValue, bool test); // 0x000000018D3A2A20-0x000000018D3A2A2C
		public static float3 select(float3 falseValue, float3 trueValue, bool test); // 0x000000018D3A2AE0-0x000000018D3A2B04
		public static float4 select(float4 falseValue, float4 trueValue, bool test); // 0x000000018D3A2A70-0x000000018D3A2A88
		public static float3 select(float3 falseValue, float3 trueValue, bool3 test); // 0x000000018D3A2A2C-0x000000018D3A2A70
		public static float4 select(float4 falseValue, float4 trueValue, bool4 test); // 0x0000000188CD4A28-0x0000000188CD4B80
		public static double3 select(double3 falseValue, double3 trueValue, bool test); // 0x000000018D3A2AB8-0x000000018D3A2AE0
		public static float step(float threshold, float x); // 0x000000018D3A3374-0x000000018D3A3388
		public static float3 project(float3 a, float3 ontoB); // 0x00000001889ECB5C-0x00000001889ECC40
		public static void sincos(float x, out float s, out float c); // 0x000000018725D550-0x000000018725D590
		public static void sincos(float3 x, out float3 s, out float3 c); // 0x000000018D3A3068-0x000000018D3A30EC
		public static int countbits(int x); // 0x000000018725CC50-0x000000018725CC90
		public static int countbits(uint x); // 0x000000018725CC50-0x000000018725CC90
		public static int lzcnt(int x); // 0x000000018D3A0108-0x000000018D3A0110
		public static int lzcnt(uint x); // 0x000000018D3A00C4-0x000000018D3A0108
		public static int tzcnt(int x); // 0x000000018D3A3788-0x000000018D3A3790
		public static int tzcnt(uint x); // 0x000000018D3A3740-0x000000018D3A3788
		public static int rol(int x, int n); // 0x0000000187235270-0x0000000187235290
		public static uint rol(uint x, int n); // 0x0000000187235270-0x0000000187235290
		public static int ceilpow2(int x); // 0x00000001859352A0-0x00000001859352D0
		public static long ceilpow2(long x); // 0x000000018725CBB0-0x000000018725CC00
		public static float radians(float x); // 0x000000018725D4A0-0x000000018725D4B0
		public static float2 radians(float2 x); // 0x000000018D3A2764-0x000000018D3A2774
		public static float3 radians(float3 x); // 0x0000000187834994-0x00000001878349DC
		public static float degrees(float x); // 0x000000018725CCF0-0x000000018725CD00
		public static float cmax(float2 x); // 0x000000018D39C9F4-0x000000018D39CA18
		public static float cmax(float3 x); // 0x000000018D39C9C0-0x000000018D39C9F4
		public static uint csum(uint2 x); // 0x000000018725CCB0-0x000000018725CCC0
		public static uint csum(uint3 x); // 0x000000018725CCD0-0x000000018725CCE0
		public static uint csum(uint4 x); // 0x00000001872397C0-0x00000001872397D0
		public static float csum(float3 x); // 0x000000018725CCE0-0x000000018725CCF0
		public static float csum(float4 x); // 0x000000018725CC90-0x000000018725CCB0
		public static double csum(double3 x); // 0x000000018725CCC0-0x000000018725CCD0
		public static float f16tof32(uint x); // 0x00000001885A5990-0x00000001885A5A5C
		public static uint f32tof16(float x); // 0x000000018D39CF04-0x000000018D39CF60
		public static float4 chgsign(float4 x, float4 y); // 0x000000018D39C830-0x000000018D39C890
		public static float3 up(); // 0x000000018725D5D0-0x000000018725D5E0
		public static float3 forward(); // 0x000000018725D430-0x000000018725D440
		public static float3 back(); // 0x000000018725CB90-0x000000018725CBA0
		public static float3 left(); // 0x000000018725D470-0x000000018725D480
		public static float3 right(); // 0x000000018725D4B0-0x000000018725D4C0
		public static float3x3 mulScale(float3x3 m, float3 s); // 0x000000018D3A0528-0x000000018D3A05F0
		internal static float4 unpacklo(float4 a, float4 b); // 0x000000018D3A37EC-0x000000018D3A5AF0
		internal static float4 unpackhi(float4 a, float4 b); // 0x000000018D3A37A0-0x000000018D3A37EC
		internal static float4 movelh(float4 a, float4 b); // 0x000000018D3A0470-0x000000018D3A04BC
		internal static double4 movelh(double4 a, double4 b); // 0x000000018D3A04BC-0x000000018D3A0528
		internal static float4 movehl(float4 a, float4 b); // 0x000000018D3A03B8-0x000000018D3A0404
		internal static double4 movehl(double4 a, double4 b); // 0x000000018D3A0404-0x000000018D3A0470
		internal static uint fold_to_uint(double x); // 0x000000018725D410-0x000000018725D430
		internal static uint2 fold_to_uint(double2 x); // 0x000000018725D2D0-0x000000018725D310
		internal static uint3 fold_to_uint(double3 x); // 0x000000018725D3A0-0x000000018725D410
		internal static uint4 fold_to_uint(double4 x); // 0x000000018725D310-0x000000018725D3A0
		public static float3x3 float3x3(quaternion rotation); // 0x000000018D39D260-0x000000018D39D298
		public static float3x3 orthonormalize(float3x3 i); // 0x000000018D3A2464-0x000000018D3A26C0
		public static float3 mul(float3x3 a, float3 b); // 0x000000018D3A0CB0-0x000000018D3A0DA0
		public static float3x3 mul(float3x3 a, float3x3 b); // 0x000000018D3A06E8-0x000000018D3A09C4
		public static float4 mul(float4x4 a, float4 b); // 0x000000018D3A05F0-0x000000018D3A06E8
		public static float4x3 mul(float4x4 a, float4x3 b); // 0x000000018D3A1848-0x000000018D3A1B30
		public static float4x4 mul(float4x4 a, float4x4 b); // 0x000000018D3A1C8C-0x000000018D3A20BC
		public static double4 mul(double4x4 a, double4 b); // 0x000000018D3A09C4-0x000000018D3A0B24
		public static double4x3 mul(double4x4 a, double4x3 b); // 0x000000018D3A13A4-0x000000018D3A1848
		public static double4x4 mul(double4x4 a, double4x4 b); // 0x000000018D3A0DA0-0x000000018D3A13A4
		public static quaternion quaternion(float x, float y, float z, float w); // 0x000000018725D0E0-0x000000018725D100
		public static quaternion quaternion(float4 value); // 0x000000018723AC80-0x000000018723AC90
		public static quaternion quaternion(float3x3 m); // 0x000000018D3A2724-0x000000018D3A2764
		public static quaternion conjugate(quaternion q); // 0x000000018D39CA18-0x000000018D39CA58
		public static quaternion inverse(quaternion q); // 0x000000018D39FB38-0x000000018D39FBB4
		public static float dot(quaternion a, quaternion b); // 0x000000018D39CE7C-0x000000018D39CEA4
		public static float lengthsq(quaternion q); // 0x000000018D39FE70-0x000000018D39FE98
		public static quaternion normalize(quaternion q); // 0x000000018D3A221C-0x000000018D3A2278
		public static quaternion normalizesafe(quaternion q); // 0x000000018D3A22EC-0x000000018D3A23AC
		public static quaternion log(quaternion q); // 0x00000001889EC8FC-0x00000001889ECA44
		public static quaternion mul(quaternion a, quaternion b); // 0x000000018D3A0B24-0x000000018D3A0CB0
		public static float3 mul(quaternion q, float3 v); // 0x000000018D3A1B30-0x000000018D3A1C8C
		public static float3 rotate(quaternion q, float3 v); // 0x000000018D3A1B30-0x000000018D3A1C8C
		public static quaternion nlerp(quaternion q1, quaternion q2, float t); // 0x000000018D3A20BC-0x000000018D3A219C
		public static quaternion slerp(quaternion q1, quaternion q2, float t); // 0x000000018D3A30EC-0x000000018D3A3290
		public static float angle(quaternion q1, quaternion q2); // 0x000000018D39C5D4-0x000000018D39C67C
		public static uint hash(quaternion q); // 0x000000018D39EB28-0x000000018D39EB44
		public static float3 forward(quaternion q); // 0x0000000188A652B8-0x0000000188A65310
		public static uint2 uint2(uint x, uint y); // 0x000000018723ADD0-0x000000018723ADE0
		public static uint hash(uint2 v); // 0x000000018D39E0D0-0x000000018D39E104
		public static uint3 uint3(uint x, uint y, uint z); // 0x000000018725D590-0x000000018725D5A0
		public static uint hash(uint3 v); // 0x000000018D39DFF0-0x000000018D39E064
		public static uint4 uint4(uint x, uint y, uint z, uint w); // 0x000000018725D5A0-0x000000018725D5C0
		public static uint4 uint4(int v); // 0x000000018725D5C0-0x000000018725D5D0
		public static uint hash(uint4 v); // 0x000000018D39D944-0x000000018D39D9B0
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2 : IEquatable<Unity.Mathematics.bool2> // TypeDefIndex: 88877
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88876
		{
		}
	
		// Constructors
		public bool2(bool x, bool y); // 0x00000001844AD090-0x00000001844AD0A0
		public bool2(bool v); // 0x000000018725AEF0-0x000000018725AF00
	
		// Methods
		public static implicit operator bool2(bool v); // 0x000000018725AF00-0x000000018725AF10
		public bool Equals(bool2 rhs); // 0x000000018C9D3D78-0x000000018C9D3D8C
		public override bool Equals(object o); // 0x000000018D397F94-0x000000018D398008
		public override int GetHashCode(); // 0x000000018D398008-0x000000018D398050
		public override string ToString(); // 0x000000018D398050-0x000000018D3980D8
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3 : IEquatable<Unity.Mathematics.bool3> // TypeDefIndex: 88879
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Properties
		public bool this[int index] { get => default; set {} } // 0x000000018519FF70-0x000000018519FF80 0x00000001872414B0-0x00000001872414C0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88878
		{
		}
	
		// Constructors
		public bool3(bool x, bool y, bool z); // 0x000000018724E9E0-0x000000018724E9F0
	
		// Methods
		public static bool3 operator &(bool3 lhs, bool3 rhs); // 0x0000000185776560-0x0000000185776590
		public static bool3 operator |(bool3 lhs, bool3 rhs); // 0x000000018D39827C-0x000000018D3982AC
		public bool Equals(bool3 rhs); // 0x000000018D3980D8-0x000000018D3980F8
		public override bool Equals(object o); // 0x000000018D3980F8-0x000000018D39817C
		public override int GetHashCode(); // 0x000000018D39817C-0x000000018D3981C4
		public override string ToString(); // 0x000000018D3981C4-0x000000018D39827C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4 : IEquatable<Unity.Mathematics.bool4> // TypeDefIndex: 88881
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
		public bool w; // 0x03
	
		// Properties
		public bool this[int index] { set {} } // 0x00000001872414B0-0x00000001872414C0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88880
		{
		}
	
		// Constructors
		public bool4(bool x, bool y, bool z, bool w); // 0x0000000187259100-0x0000000187259120
	
		// Methods
		public bool Equals(bool4 rhs); // 0x000000018D394304-0x000000018D39767C
		public override bool Equals(object o); // 0x000000018D3982AC-0x000000018D39830C
		public override int GetHashCode(); // 0x000000018D39830C-0x000000018D398314
		public override string ToString(); // 0x000000018D398314-0x000000018D398470
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x4 : IEquatable<Unity.Mathematics.bool4x4> // TypeDefIndex: 88882
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
		public bool4 c2; // 0x08
		public bool4 c3; // 0x0C
	
		// Constructors
		public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3); // 0x0000000187235B70-0x0000000187235B90
	
		// Methods
		public bool Equals(bool4x4 rhs); // 0x000000018D3984DC-0x000000018D39852C
		public override bool Equals(object o); // 0x000000018D398470-0x000000018D3984DC
		public override int GetHashCode(); // 0x000000018D39852C-0x000000018D398548
		public override string ToString(); // 0x000000018D398548-0x000000018D398918
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2 : IEquatable<Unity.Mathematics.double2>, IFormattable // TypeDefIndex: 88884
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88883
		{
		}
	
		// Constructors
		public double2(double x, double y); // 0x0000000187235160-0x0000000187235170
		public double2(float2 v); // 0x000000018725AF10-0x000000018725AF40
	
		// Methods
		public static implicit operator double2(float2 v); // 0x000000018725AF40-0x000000018725AF70
		public static double2 operator *(double2 lhs, double rhs); // 0x000000018725AF70-0x000000018725AF90
		public bool Equals(double2 rhs); // 0x000000018D398918-0x000000018D398938
		public override bool Equals(object o); // 0x000000018D398938-0x000000018D3989B8
		public override int GetHashCode(); // 0x000000018D3989B8-0x000000018D398A00
		public override string ToString(); // 0x000000018D398A88-0x000000018D398B18
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D398A00-0x000000018D398A88
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double3 : IEquatable<Unity.Mathematics.double3>, IFormattable // TypeDefIndex: 88886
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public static readonly double3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzx { get; } // 0x000000018725AFF0-0x000000018725B010 
		public double this[int index] { get => default; } // 0x000000018725AFE0-0x000000018725AFF0 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88885
		{
		}
	
		// Constructors
		public double3(double x, double y, double z); // 0x000000018725AFD0-0x000000018725AFE0
		public double3(int v); // 0x000000018725AFB0-0x000000018725AFD0
		public double3(float3 v); // 0x000000018725AF90-0x000000018725AFB0
	
		// Methods
		public static implicit operator double3(int v); // 0x000000018725B070-0x000000018725B0A0
		public static implicit operator double3(float3 v); // 0x00000001865AED00-0x00000001865AED40
		public static double3 operator *(double3 lhs, double3 rhs); // 0x000000018725B0E0-0x000000018725B120
		public static double3 operator *(double3 lhs, double rhs); // 0x000000018725B0C0-0x000000018725B0E0
		public static double3 operator *(double lhs, double3 rhs); // 0x000000018725B0A0-0x000000018725B0C0
		public static double3 operator +(double3 lhs, double3 rhs); // 0x000000018725B030-0x000000018725B070
		public static double3 operator +(double3 lhs, double rhs); // 0x000000018725B010-0x000000018725B030
		public static double3 operator -(double3 lhs, double3 rhs); // 0x000000018725B140-0x000000018725B180
		public static double3 operator -(double3 lhs, double rhs); // 0x000000018725B120-0x000000018725B140
		public static double3 operator /(double3 lhs, double3 rhs); // 0x000000018D398D2C-0x000000018D398D60
		public static double3 operator /(double3 lhs, double rhs); // 0x000000018D398D60-0x000000018D398D80
		public static bool3 operator <=(double3 lhs, double3 rhs); // 0x000000018D398DB4-0x000000018D398DE8
		public static bool3 operator >=(double3 lhs, double3 rhs); // 0x000000018D398D80-0x000000018D398DB4
		public static double3 operator -(double3 val); // 0x000000018725B180-0x000000018725B1B0
		public bool Equals(double3 rhs); // 0x0000000188A2F874-0x0000000188A30B90
		public override bool Equals(object o); // 0x000000018D398B18-0x000000018D398B8C
		public override int GetHashCode(); // 0x000000018D398B8C-0x000000018D398BB4
		public override string ToString(); // 0x000000018D398C68-0x000000018D398D2C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D398BB4-0x000000018D398C68
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x2 : IEquatable<Unity.Mathematics.double3x2>, IFormattable // TypeDefIndex: 88887
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
	
		// Constructors
		public double3x2(double3 c0, double3 c1); // 0x000000018724E950-0x000000018724E980
		public double3x2(int v); // 0x000000018725B1B0-0x000000018725B200
		public double3x2(float3x2 v); // 0x00000001889DC178-0x00000001889DC83C
	
		// Methods
		public static implicit operator double3x2(int v); // 0x000000018D399378-0x000000018D399398
		public static implicit operator double3x2(float3x2 v); // 0x000000018D399398-0x000000018D3993D4
		public static double3x2 operator *(double3x2 lhs, double rhs); // 0x000000018D3993D4-0x000000018D399458
		public static double3x2 operator +(double3x2 lhs, double3x2 rhs); // 0x000000018D399228-0x000000018D3992EC
		public static double3x2 operator -(double3x2 lhs, double3x2 rhs); // 0x000000018D399458-0x000000018D39951C
		public static double3x2 operator /(double3x2 lhs, double rhs); // 0x000000018D3992EC-0x000000018D399378
		public bool Equals(double3x2 rhs); // 0x0000000188A5D708-0x0000000188A5D778
		public override bool Equals(object o); // 0x000000018D398DE8-0x000000018D398E64
		public override int GetHashCode(); // 0x000000018D398E64-0x000000018D398E94
		public override string ToString(); // 0x000000018D399048-0x000000018D399228
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D398E94-0x000000018D399048
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x3 : IEquatable<Unity.Mathematics.double3x3>, IFormattable // TypeDefIndex: 88888
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public static readonly double3x3 identity; // 0x00
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x000000018725B260-0x000000018725B270 
	
		// Constructors
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22); // 0x000000018725B200-0x000000018725B260
		public double3x3(float3x3 v); // 0x0000000188A1D6C8-0x0000000188A1E8F4
		static double3x3(); // 0x000000018702B0F0-0x000000018702B1C0
	
		// Methods
		public bool Equals(double3x3 rhs); // 0x000000018D3995B0-0x000000018D399644
		public override bool Equals(object o); // 0x000000018D39951C-0x000000018D3995B0
		public override int GetHashCode(); // 0x000000018D399644-0x000000018D399688
		public override string ToString(); // 0x000000018D399688-0x000000018D399910
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D399910-0x000000018D399B54
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x4 : IEquatable<Unity.Mathematics.double3x4>, IFormattable // TypeDefIndex: 88889
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public double3 c3; // 0x48
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x000000018725B260-0x000000018725B270 
	
		// Constructors
		public double3x4(int v); // 0x000000018725B270-0x000000018725B2F0
	
		// Methods
		public static implicit operator double3x4(int v); // 0x000000018D39A32C-0x000000018D39A358
		public bool Equals(double3x4 rhs); // 0x000000018D399B54-0x000000018D399C3C
		public override bool Equals(object o); // 0x000000018D399C3C-0x000000018D399CDC
		public override int GetHashCode(); // 0x000000018D399CDC-0x000000018D399D28
		public override string ToString(); // 0x000000018D399FFC-0x000000018D39A32C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D399D28-0x000000018D399FFC
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double4 : IEquatable<Unity.Mathematics.double4>, IFormattable // TypeDefIndex: 88891
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
		public static readonly double4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyz { get; set; } // 0x000000018725B380-0x000000018725B3A0 0x000000018725B500-0x000000018725B520
		public double this[int index] { get => default; set {} } // 0x000000018725AFE0-0x000000018725AFF0 0x000000018725B4F0-0x000000018725B500
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88890
		{
		}
	
		// Constructors
		public double4(double x, double y, double z, double w); // 0x000000018725B2F0-0x000000018725B310
		public double4(double3 xyz, double w); // 0x000000018725B350-0x000000018725B370
		public double4(double v); // 0x000000018725B370-0x000000018725B380
		public double4(int v); // 0x000000018725B310-0x000000018725B340
		public double4(float4 v); // 0x000000018725B340-0x000000018725B350
	
		// Methods
		public static implicit operator double4(int v); // 0x000000018725B3F0-0x000000018725B430
		public static implicit operator double4(float4 v); // 0x000000018D39A73C-0x000000018D39A764
		public static double4 operator *(double4 lhs, double4 rhs); // 0x000000018725B450-0x000000018725B4A0
		public static double4 operator *(double4 lhs, double rhs); // 0x000000018725B430-0x000000018725B450
		public static double4 operator +(double4 lhs, double4 rhs); // 0x000000018725B3A0-0x000000018725B3F0
		public static double4 operator -(double4 lhs, double4 rhs); // 0x000000018725B4A0-0x000000018725B4F0
		public static double4 operator /(double4 lhs, double4 rhs); // 0x000000018D39A6F8-0x000000018D39A73C
		public bool Equals(double4 rhs); // 0x000000018D39A3CC-0x000000018D39A414
		public override bool Equals(object o); // 0x000000018D39A358-0x000000018D39A3CC
		public override int GetHashCode(); // 0x000000018D39A414-0x000000018D39A438
		public override string ToString(); // 0x000000018D39A438-0x000000018D39A5A4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D39A5A4-0x000000018D39A6F8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x3 : IEquatable<Unity.Mathematics.double4x3>, IFormattable // TypeDefIndex: 88892
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
	
		// Constructors
		public double4x3(double4 c0, double4 c1, double4 c2); // 0x000000018725B590-0x000000018725B5D0
		public double4x3(int v); // 0x000000018725B520-0x000000018725B590
		public double4x3(float4x3 v); // 0x000000018D39AED4-0x000000018D39AF64
	
		// Methods
		public static implicit operator double4x3(int v); // 0x000000018D39AF64-0x000000018D39AF90
		public static implicit operator double4x3(float4x3 v); // 0x000000018D39AF90-0x000000018D39AFE0
		public static double4x3 operator *(double4x3 lhs, double4x3 rhs); // 0x000000018D39AFE0-0x000000018D39B0E8
		public bool Equals(double4x3 rhs); // 0x000000018D39A764-0x000000018D39A7E4
		public override bool Equals(object o); // 0x000000018D39A7E4-0x000000018D39A884
		public override int GetHashCode(); // 0x000000018D39A884-0x000000018D39A8D0
		public override string ToString(); // 0x000000018D39ABA4-0x000000018D39AED4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D39A8D0-0x000000018D39ABA4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x4 : IEquatable<Unity.Mathematics.double4x4>, IFormattable // TypeDefIndex: 88893
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
		public double4 c3; // 0x60
		public static readonly double4x4 identity; // 0x00
		public static readonly double4x4 zero; // 0x80
	
		// Constructors
		public double4x4(double4 c0, double4 c1, double4 c2, double4 c3); // 0x000000018725B5D0-0x000000018725B620
		public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33); // 0x0000000186EC2340-0x0000000186EC2540
		public double4x4(float4x4 v); // 0x000000018D39BA44-0x000000018D39BAF8
		static double4x4(); // 0x0000000186EC2210-0x0000000186EC2340
	
		// Methods
		public static implicit operator double4x4(float4x4 v); // 0x000000018D39BAF8-0x000000018D39BB54
		public bool Equals(double4x4 rhs); // 0x000000018D39B0E8-0x000000018D39B18C
		public override bool Equals(object o); // 0x000000018D39B18C-0x000000018D39B244
		public override int GetHashCode(); // 0x000000018D39B244-0x000000018D39B2A0
		public override string ToString(); // 0x000000018D39B634-0x000000018D39BA44
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D39B2A0-0x000000018D39B634
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2 : IEquatable<Unity.Mathematics.float2>, IFormattable // TypeDefIndex: 88895
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public static readonly float2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get; } // 0x000000018725B670-0x000000018725B690 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; } // 0x00000001872358F0-0x0000000187235910 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get; } // 0x000000018725B690-0x000000018725B6B0 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88894
		{
		}
	
		// Constructors
		public float2(float x, float y); // 0x0000000187234A10-0x0000000187234A20
		public float2(float v); // 0x000000018725B620-0x000000018725B630
		public float2(int v); // 0x000000018725B650-0x000000018725B670
		public float2(int2 v); // 0x000000018725B630-0x000000018725B650
	
		// Methods
		public static implicit operator float2(float v); // 0x0000000187238460-0x0000000187238470
		public static implicit operator float2(int v); // 0x000000018725B6D0-0x000000018725B6F0
		public static implicit operator float2(int2 v); // 0x000000018725B6B0-0x000000018725B6D0
		public static float2 operator *(float2 lhs, float2 rhs); // 0x00000001872561A0-0x00000001872561E0
		public static float2 operator *(float2 lhs, float rhs); // 0x0000000187256170-0x00000001872561A0
		public static float2 operator *(float lhs, float2 rhs); // 0x000000018725B740-0x000000018725B770
		public static float2 operator +(float2 lhs, float2 rhs); // 0x0000000187256100-0x0000000187256140
		public static float2 operator +(float2 lhs, float rhs); // 0x0000000187256140-0x0000000187256170
		public static float2 operator -(float2 lhs, float2 rhs); // 0x0000000187256210-0x0000000187256250
		public static float2 operator -(float2 lhs, float rhs); // 0x00000001872561E0-0x0000000187256210
		public static float2 operator /(float2 lhs, float rhs); // 0x000000018CCDF754-0x000000018CCDF778
		public static float2 operator %(float2 lhs, float rhs); // 0x000000018725B6F0-0x000000018725B740
		public static bool2 operator <=(float2 lhs, float2 rhs); // 0x000000018D39BD48-0x000000018D39BD80
		public static bool2 operator >=(float2 lhs, float2 rhs); // 0x000000018D39BD10-0x000000018D39BD48
		public bool Equals(float2 rhs); // 0x000000018CCDF29C-0x000000018CCDF2C4
		public override bool Equals(object o); // 0x000000018D39BB54-0x000000018D39BBC4
		public override int GetHashCode(); // 0x000000018D39BBC4-0x000000018D39BBF8
		public override string ToString(); // 0x000000018D39BC80-0x000000018D39BD10
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D39BBF8-0x000000018D39BC80
		public static implicit operator Vector2(float2 v); // 0x0000000187255C10-0x0000000187255C30
		public static implicit operator float2(Vector2 v); // 0x0000000187255C10-0x0000000187255C30
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float3 : IEquatable<Unity.Mathematics.float3>, IFormattable // TypeDefIndex: 88897
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public static readonly float3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx { get; } // 0x000000018725B920-0x000000018725B940 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy { get; } // 0x000000018725B940-0x000000018725B960 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxz { get; } // 0x000000018725B960-0x000000018725B980 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx { get; } // 0x000000018725B9A0-0x000000018725B9C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy { get; } // 0x000000018725B9C0-0x000000018725B9E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyz { get; } // 0x000000018725B9E0-0x000000018725BA00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzx { get; } // 0x000000018725BA20-0x000000018725BA40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzy { get; } // 0x000000018725BA40-0x000000018725BA60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get; } // 0x000000018725BA60-0x000000018725BA80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx { get; } // 0x000000018725BAA0-0x000000018725BAC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get; } // 0x000000018725B670-0x000000018725B690 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxz { get; } // 0x000000018725BAC0-0x000000018725BAE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx { get; } // 0x000000018725BB00-0x000000018725BB20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy { get; } // 0x000000018725BB20-0x000000018725BB40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyz { get; } // 0x000000018725BB40-0x000000018725BB60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get; } // 0x00000001855D35A0-0x00000001855D35C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzy { get; } // 0x000000018725BB60-0x000000018725BB80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzz { get; } // 0x000000018725BB80-0x000000018725BBA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxx { get; } // 0x000000018725BBC0-0x000000018725BBE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxy { get; } // 0x000000018725BBE0-0x000000018725BC00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get; } // 0x000000018725BC00-0x000000018725BC20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyx { get; } // 0x000000018725BC40-0x000000018725BC60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyy { get; } // 0x000000018725BC60-0x000000018725BC80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyz { get; } // 0x000000018725BC80-0x000000018725BCA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzx { get; } // 0x000000018725BCC0-0x000000018725BCE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzy { get; } // 0x000000018725BCE0-0x000000018725BD00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzz { get; } // 0x000000018725BD00-0x000000018725BD20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx { get; } // 0x000000018725BD40-0x000000018725BD60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy { get; } // 0x000000018725BD60-0x000000018725BD80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxz { get; } // 0x000000018725BD80-0x000000018725BDA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx { get; } // 0x000000018725BDC0-0x000000018725BDE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy { get; } // 0x000000018725BDE0-0x000000018725BE00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyz { get; } // 0x000000018725BE00-0x000000018725BE20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzx { get; } // 0x000000018725BE40-0x000000018725BE60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzy { get; } // 0x000000018725BE60-0x000000018725BE80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzz { get; } // 0x000000018725BE80-0x000000018725BEA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx { get; } // 0x000000018725BEE0-0x000000018725BF00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy { get; } // 0x000000018725BF00-0x000000018725BF20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxz { get; } // 0x000000018725BF20-0x000000018725BF40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx { get; } // 0x000000018725BF50-0x000000018725BF70 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy { get; } // 0x000000018725BF70-0x000000018725BF90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyz { get; } // 0x000000018725BF90-0x000000018725BFB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzx { get; } // 0x000000018725BFD0-0x000000018725BFF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzy { get; } // 0x000000018725BFF0-0x000000018725C010 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzz { get; } // 0x000000018725C010-0x000000018725C030 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxx { get; } // 0x000000018725C050-0x000000018725C070 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get; } // 0x00000001855D35C0-0x00000001855D35E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get; } // 0x00000001855D3600-0x00000001855D3620 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyx { get; } // 0x000000018725C090-0x000000018725C0B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyy { get; } // 0x000000018725C0B0-0x000000018725C0D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyz { get; } // 0x000000018725C0D0-0x000000018725C0F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzx { get; } // 0x000000018725C110-0x000000018725C130 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzy { get; } // 0x000000018725C130-0x000000018725C150 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzz { get; } // 0x000000018725C150-0x000000018725C170 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxx { get; } // 0x000000018725C1B0-0x000000018725C1D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxy { get; } // 0x000000018725C1D0-0x000000018725C1F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxz { get; } // 0x000000018725C1F0-0x000000018725C210 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyx { get; } // 0x000000018725C230-0x000000018725C250 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get; } // 0x000000018725C250-0x000000018725C270 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get; } // 0x00000001855D35E0-0x00000001855D3600 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzx { get; } // 0x000000018725C290-0x000000018725C2B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzy { get; } // 0x000000018725C2B0-0x000000018725C2D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzz { get; } // 0x000000018725C2D0-0x000000018725C2F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxx { get; } // 0x000000018725C330-0x000000018725C350 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxy { get; } // 0x000000018725C350-0x000000018725C370 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxz { get; } // 0x000000018725C370-0x000000018725C390 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyx { get; } // 0x000000018725C3B0-0x000000018725C3D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyy { get; } // 0x000000018725C3D0-0x000000018725C3F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyz { get; } // 0x000000018725C3F0-0x000000018725C410 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzx { get; } // 0x000000018725C430-0x000000018725C450 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzy { get; } // 0x000000018725C450-0x000000018725C470 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzz { get; } // 0x000000018725C470-0x000000018725C490 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxx { get; } // 0x000000018725C4D0-0x000000018725C4F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxy { get; } // 0x000000018725C4F0-0x000000018725C510 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxz { get; } // 0x000000018725C510-0x000000018725C530 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyx { get; } // 0x000000018725C550-0x000000018725C570 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyy { get; } // 0x000000018725C570-0x000000018725C590 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz { get; } // 0x000000018725C590-0x000000018725C5B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzx { get; } // 0x000000018725C5C0-0x000000018725C5E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzy { get; } // 0x000000018725C5E0-0x000000018725C600 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzz { get; } // 0x000000018725C600-0x000000018725C620 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get; } // 0x000000018725B910-0x000000018725B920 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy { get; } // 0x000000018725B980-0x000000018725B9A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxz { get; } // 0x000000018725BA00-0x000000018725BA20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx { get; } // 0x000000018725BA80-0x000000018725BAA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy { get; } // 0x000000018725BAE0-0x000000018725BB00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get; set; } // 0x0000000187235870-0x0000000187235890 0x0000000187235E90-0x0000000187235EB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzx { get; } // 0x000000018725BBA0-0x000000018725BBC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzy { get; set; } // 0x000000018725BC20-0x000000018725BC40 0x000000018725CA30-0x000000018725CA50
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzz { get; } // 0x000000018725BCA0-0x000000018725BCC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx { get; } // 0x000000018725BD20-0x000000018725BD40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy { get; } // 0x000000018725BDA0-0x000000018725BDC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxz { get; set; } // 0x000000018725BE20-0x000000018725BE40 0x000000018725CA70-0x000000018725CA90
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx { get; } // 0x000000018725BEC0-0x000000018725BEE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy { get; } // 0x000000018725BF40-0x000000018725BF50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyz { get; } // 0x000000018725BFB0-0x000000018725BFD0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get; set; } // 0x000000018725C030-0x000000018725C050 0x000000018725CAB0-0x000000018725CAD0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzy { get; } // 0x000000018725C070-0x000000018725C090 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzz { get; } // 0x000000018725C0F0-0x000000018725C110 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxx { get; } // 0x000000018725C190-0x000000018725C1B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxy { get; set; } // 0x000000018725C210-0x000000018725C230 0x000000018725CAF0-0x000000018725CB10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxz { get; } // 0x000000018725C270-0x000000018725C290 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyx { get; set; } // 0x000000018725C310-0x000000018725C330 0x000000018725CB30-0x000000018725CB50
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyy { get; } // 0x000000018725C390-0x000000018725C3B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyz { get; } // 0x000000018725C410-0x000000018725C430 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzx { get; } // 0x000000018725C4B0-0x000000018725C4D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzy { get; } // 0x000000018725C530-0x000000018725C550 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzz { get; } // 0x000000018725C5B0-0x000000018725C5C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get; } // 0x000000018725B900-0x000000018725B910 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; set; } // 0x00000001872358F0-0x0000000187235910 0x000000018725C9F0-0x000000018725CA10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get; set; } // 0x0000000187235940-0x0000000187235960 0x000000018725CA10-0x000000018725CA30
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get; set; } // 0x000000018725B690-0x000000018725B6B0 0x000000018725CA50-0x000000018725CA70
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get; } // 0x000000018725BEA0-0x000000018725BEC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz { get; set; } // 0x00000001872385C0-0x00000001872385E0 0x000000018725CA90-0x000000018725CAB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zx { get; set; } // 0x000000018725C170-0x000000018725C190 0x000000018725CAD0-0x000000018725CAF0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zy { get; set; } // 0x000000018725C2F0-0x000000018725C310 0x000000018725CB10-0x000000018725CB30
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zz { get; } // 0x000000018725C490-0x000000018725C4B0 
		public float this[int index] { get => default; set {} } // 0x000000018723A6B0-0x000000018723A6C0 0x000000018723A6F0-0x000000018723A700
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88896
		{
		}
	
		// Constructors
		public float3(float x, float y, float z); // 0x0000000187235E80-0x0000000187235E90
		public float3(float x, float2 yz); // 0x000000018725B8B0-0x000000018725B8D0
		public float3(float2 xy, float z); // 0x000000018725B7E0-0x000000018725B800
		public float3(float3 xyz); // 0x0000000187235E90-0x0000000187235EB0
		public float3(float v); // 0x000000018725B870-0x000000018725B880
		public float3(bool v); // 0x00000001885A5920-0x00000001885A5954
		public float3(bool3 v); // 0x00000001885A5954-0x00000001885A5990
		public float3(int v); // 0x000000018725B770-0x000000018725B7A0
		public float3(int3 v); // 0x000000018725B880-0x000000018725B8B0
		public float3(uint v); // 0x000000018725B800-0x000000018725B840
		public float3(uint3 v); // 0x000000018725B7A0-0x000000018725B7E0
		public float3(half v); // 0x000000018D39BFCC-0x000000018D39C008
		public float3(half3 v); // 0x000000018D39BF90-0x000000018D39BFCC
		public float3(double v); // 0x000000018725B840-0x000000018725B870
		public float3(double3 v); // 0x000000018725B8D0-0x000000018725B900
	
		// Methods
		public static implicit operator float3(float v); // 0x00000001872385A0-0x00000001872385C0
		public static explicit operator float3(bool v); // 0x000000018D39C12C-0x000000018D39C148
		public static explicit operator float3(bool3 v); // 0x000000018D39C0FC-0x000000018D39C12C
		public static implicit operator float3(int v); // 0x000000018725C700-0x000000018725C730
		public static implicit operator float3(int3 v); // 0x000000018725C730-0x000000018725C780
		public static implicit operator float3(uint v); // 0x000000018725C7E0-0x000000018725C820
		public static implicit operator float3(uint3 v); // 0x000000018725C780-0x000000018725C7E0
		public static implicit operator float3(half v); // 0x000000018D39C250-0x000000018D39C28C
		public static implicit operator float3(half3 v); // 0x000000018D39C28C-0x000000018D39C2D8
		public static explicit operator float3(double v); // 0x000000018725C690-0x000000018725C6C0
		public static explicit operator float3(double3 v); // 0x000000018725C6C0-0x000000018725C700
		public static float3 operator *(float3 lhs, float3 rhs); // 0x00000001872355A0-0x00000001872355E0
		public static float3 operator *(float3 lhs, float rhs); // 0x0000000185777EB0-0x0000000185777EE0
		public static float3 operator *(float lhs, float3 rhs); // 0x000000018725C990-0x000000018725C9C0
		public static float3 operator +(float3 lhs, float3 rhs); // 0x00000001855D3510-0x00000001855D3550
		public static float3 operator +(float3 lhs, float rhs); // 0x0000000186554DC0-0x0000000186554DF0
		public static float3 operator +(float lhs, float3 rhs); // 0x000000018725C620-0x000000018725C650
		public static float3 operator -(float3 lhs, float3 rhs); // 0x00000001855D1430-0x00000001855D1470
		public static float3 operator -(float3 lhs, float rhs); // 0x0000000186554D90-0x0000000186554DC0
		public static float3 operator -(float lhs, float3 rhs); // 0x000000018725C9C0-0x000000018725C9F0
		public static float3 operator /(float3 lhs, float3 rhs); // 0x000000018CCDFE94-0x000000018CCDFEC8
		public static float3 operator /(float3 lhs, float rhs); // 0x000000018CCCFEDC-0x000000018CCCFF08
		public static float3 operator /(float lhs, float3 rhs); // 0x000000018D39C008-0x000000018D39C034
		public static float3 operator %(float3 lhs, float3 rhs); // 0x000000018725C920-0x000000018725C990
		public static float3 operator %(float3 lhs, float rhs); // 0x000000018725C8C0-0x000000018725C920
		public static float3 operator %(float lhs, float3 rhs); // 0x000000018725C860-0x000000018725C8C0
		public static float3 operator ++(float3 val); // 0x000000018725C820-0x000000018725C860
		public static float3 operator --(float3 val); // 0x000000018725C650-0x000000018725C690
		public static bool3 operator <(float3 lhs, float3 rhs); // 0x000000018D39C448-0x000000018D39C47C
		public static bool3 operator <(float3 lhs, float rhs); // 0x000000018D39C47C-0x000000018D39C49C
		public static bool3 operator <(float lhs, float3 rhs); // 0x000000018D39C418-0x000000018D39C448
		public static bool3 operator <=(float3 lhs, float3 rhs); // 0x000000018D39C394-0x000000018D39C3C8
		public static bool3 operator <=(float3 lhs, float rhs); // 0x000000018D39C3F8-0x000000018D39C418
		public static bool3 operator <=(float lhs, float3 rhs); // 0x000000018D39C3C8-0x000000018D39C3F8
		public static bool3 operator >(float3 lhs, float3 rhs); // 0x000000018D39C1CC-0x000000018D39C200
		public static bool3 operator >(float3 lhs, float rhs); // 0x000000018D39C224-0x000000018D39C250
		public static bool3 operator >(float lhs, float3 rhs); // 0x000000018D39C200-0x000000018D39C224
		public static bool3 operator >=(float3 lhs, float3 rhs); // 0x000000018D39C148-0x000000018D39C17C
		public static bool3 operator >=(float3 lhs, float rhs); // 0x000000018D39C17C-0x000000018D39C1A8
		public static bool3 operator >=(float lhs, float3 rhs); // 0x000000018D39C1A8-0x000000018D39C1CC
		public static float3 operator -(float3 val); // 0x0000000185B953B0-0x0000000185B953F0
		public static float3 operator +(float3 val); // 0x0000000187235870-0x0000000187235890
		public static bool3 operator ==(float3 lhs, float3 rhs); // 0x000000018D39C034-0x000000018D39C07C
		public static bool3 operator ==(float3 lhs, float rhs); // 0x000000018D39C07C-0x000000018D39C0C0
		public static bool3 operator ==(float lhs, float3 rhs); // 0x000000018D39C0C0-0x000000018D39C0FC
		public static bool3 operator !=(float3 lhs, float3 rhs); // 0x000000018D39C310-0x000000018D39C354
		public static bool3 operator !=(float3 lhs, float rhs); // 0x000000018D39C354-0x000000018D39C394
		public static bool3 operator !=(float lhs, float3 rhs); // 0x000000018D39C2D8-0x000000018D39C310
		public bool Equals(float3 rhs); // 0x00000001855780F0-0x0000000185578120
		public override bool Equals(object o); // 0x000000018D39BD80-0x000000018D39BDF4
		public override int GetHashCode(); // 0x000000018D39BDF4-0x000000018D39BE18
		public override string ToString(); // 0x000000018D39BE18-0x000000018D39BEDC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D39BEDC-0x000000018D39BF90
		public static implicit operator Vector3(float3 v); // 0x0000000187235870-0x0000000187235890
		public static implicit operator float3(Vector3 v); // 0x0000000187235870-0x0000000187235890
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x2 : IEquatable<Unity.Mathematics.float3x2>, IFormattable // TypeDefIndex: 88898
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
	
		// Constructors
		public float3x2(float3 c0, float3 c1); // 0x0000000187233BB0-0x0000000187233BD0
	
		// Methods
		public static float3x2 operator *(float3x2 lhs, float rhs); // 0x000000018D3A7EAC-0x000000018D3A7F30
		public bool Equals(float3x2 rhs); // 0x000000018D3A7A8C-0x000000018D3A7AF0
		public override bool Equals(object o); // 0x000000018D3A7A18-0x000000018D3A7A8C
		public override int GetHashCode(); // 0x000000018D3A7AF0-0x000000018D3A7B18
		public override string ToString(); // 0x000000018D3A7CCC-0x000000018D3A7EAC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A7B18-0x000000018D3A7CCC
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x3 : IEquatable<Unity.Mathematics.float3x3>, IFormattable // TypeDefIndex: 88899
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public static readonly float3x3 identity; // 0x00
		public static readonly float3x3 zero; // 0x24
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x000000018725D6F0-0x000000018725D700 
	
		// Constructors
		public float3x3(float3 c0, float3 c1, float3 c2); // 0x00000001872393F0-0x0000000187239430
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22); // 0x000000018725D690-0x000000018725D6F0
		public float3x3(int v); // 0x000000018725D620-0x000000018725D690
		public float3x3(float4x4 f4x4); // 0x00000001855D3620-0x00000001855D3830
		public float3x3(quaternion q); // 0x00000001855D3830-0x00000001855D3F70
		static float3x3(); // 0x0000000187085A20-0x0000000187085AD0
	
		// Methods
		public static implicit operator float3x3(int v); // 0x000000018D3A8630-0x000000018D3A8650
		public static float3x3 operator +(float3x3 lhs, float3x3 rhs); // 0x000000018D3A8530-0x000000018D3A8630
		public bool Equals(float3x3 rhs); // 0x000000018D3A7FAC-0x000000018D3A8038
		public override bool Equals(object o); // 0x000000018D3A7F30-0x000000018D3A7FAC
		public override int GetHashCode(); // 0x000000018D3A8038-0x000000018D3A8064
		public override string ToString(); // 0x000000018D3A8064-0x000000018D3A82EC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A82EC-0x000000018D3A8530
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x4 : IEquatable<Unity.Mathematics.float3x4>, IFormattable // TypeDefIndex: 88900
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public float3 c3; // 0x24
		public static readonly float3x4 zero; // 0x00
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x000000018725D6F0-0x000000018725D700 
	
		// Constructors
		public float3x4(int v); // 0x000000018725D700-0x000000018725D790
	
		// Methods
		public static implicit operator float3x4(int v); // 0x000000018D3A8DC4-0x000000018D3A8DE4
		public bool Equals(float3x4 rhs); // 0x000000018D3A86CC-0x000000018D3A8790
		public override bool Equals(object o); // 0x000000018D3A8650-0x000000018D3A86CC
		public override int GetHashCode(); // 0x000000018D3A8790-0x000000018D3A87C0
		public override string ToString(); // 0x000000018D3A8A94-0x000000018D3A8DC4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A87C0-0x000000018D3A8A94
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float4 : IEquatable<Unity.Mathematics.float4>, IFormattable // TypeDefIndex: 88902
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		public static readonly float4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get; } // 0x000000018725BA60-0x000000018725BA80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get; } // 0x00000001855D35A0-0x00000001855D35C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get; } // 0x000000018725BC00-0x000000018725BC20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyww { get; } // 0x000000018725D980-0x000000018725D9A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get; } // 0x00000001855D35C0-0x00000001855D35E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get; } // 0x00000001855D3600-0x00000001855D3620 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get; } // 0x000000018725C250-0x000000018725C270 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get; } // 0x00000001855D35E0-0x00000001855D3600 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxy { get; } // 0x000000018725D9C0-0x000000018725D9E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyx { get; } // 0x000000018725D900-0x000000018725D920 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx { get; } // 0x000000018725D8A0-0x000000018725D8C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww { get; } // 0x000000018725D880-0x000000018725D8A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get; } // 0x000000018725B910-0x000000018725B920 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get; set; } // 0x0000000187235870-0x0000000187235890 0x0000000187235E90-0x0000000187235EB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyw { get; } // 0x000000018725D920-0x000000018725D940 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxw { get; } // 0x000000018725D960-0x000000018725D980 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get; } // 0x000000018725C030-0x000000018725C050 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx { get; } // 0x000000018725D9A0-0x000000018725D9C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy { get; } // 0x000000018725D8E0-0x000000018725D900 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 www { get; } // 0x000000018725D870-0x000000018725D880 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get; } // 0x000000018725B900-0x000000018725B910 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get; set; } // 0x00000001872358F0-0x0000000187235910 0x000000018725C9F0-0x000000018725CA10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get; } // 0x0000000187235940-0x0000000187235960 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get; } // 0x000000018725BEA0-0x000000018725BEC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yw { get; } // 0x000000018725D940-0x000000018725D960 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zw { get; } // 0x000000018724A700-0x000000018724A720 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wz { get; } // 0x000000018725D8C0-0x000000018725D8E0 
		public float this[int index] { get => default; set {} } // 0x000000018723A6B0-0x000000018723A6C0 0x000000018723A6F0-0x000000018723A700
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88901
		{
		}
	
		// Constructors
		public float4(float x, float y, float z, float w); // 0x00000001872359D0-0x00000001872359F0
		public float4(float x, float3 yzw); // 0x000000018725D850-0x000000018725D870
		public float4(float2 xy, float z, float w); // 0x000000018725D800-0x000000018725D830
		public float4(float2 xy, float2 zw); // 0x000000018725D790-0x000000018725D7D0
		public float4(float3 xyz, float w); // 0x000000018725D7E0-0x000000018725D800
		public float4(float v); // 0x000000018725D7D0-0x000000018725D7E0
		public float4(int v); // 0x000000018725D830-0x000000018725D840
		public float4(int4 v); // 0x000000018725D840-0x000000018725D850
		public float4(half4 v); // 0x000000018D3A9110-0x000000018D3A9168
	
		// Methods
		public static implicit operator float4(float v); // 0x000000018725D100-0x000000018725D110
		public static implicit operator float4(int v); // 0x000000018725D110-0x000000018725D130
		public static implicit operator float4(int4 v); // 0x000000018D3A9264-0x000000018D3A92A8
		public static implicit operator float4(half4 v); // 0x000000018D3A9208-0x000000018D3A9264
		public static float4 operator *(float4 lhs, float4 rhs); // 0x00000001855D3F70-0x00000001855D4360
		public static float4 operator *(float4 lhs, float rhs); // 0x00000001855D4360-0x00000001855D4380
		public static float4 operator *(float lhs, float4 rhs); // 0x0000000185B95350-0x0000000185B95370
		public static float4 operator +(float4 lhs, float4 rhs); // 0x00000001855D4380-0x00000001855D4780
		public static float4 operator +(float4 lhs, float rhs); // 0x0000000187256270-0x0000000187256290
		public static float4 operator -(float4 lhs, float4 rhs); // 0x00000001855D3550-0x00000001855D35A0
		public static float4 operator -(float4 lhs, float rhs); // 0x0000000187256290-0x00000001872562B0
		public static float4 operator -(float lhs, float4 rhs); // 0x000000018725D9E0-0x000000018725DA20
		public static float4 operator /(float4 lhs, float4 rhs); // 0x000000018CCE05B4-0x000000018CCE05F8
		public static float4 operator /(float4 lhs, float rhs); // 0x000000018CCE05F8-0x000000018CCE060C
		public static bool4 operator <(float4 lhs, float rhs); // 0x000000018D3A92A8-0x000000018D3A92D0
		public static bool4 operator >(float4 lhs, float4 rhs); // 0x000000018D3A91CC-0x000000018D3A9208
		public static float4 operator -(float4 val); // 0x000000018725DA20-0x000000018725DA40
		public static bool4 operator ==(float4 lhs, float4 rhs); // 0x000000018D3A9168-0x000000018D3A91CC
		public bool Equals(float4 rhs); // 0x00000001862F2760-0x00000001862F27A0
		public override bool Equals(object o); // 0x000000018D3A8DE4-0x000000018D3A8E50
		public override int GetHashCode(); // 0x000000018D39EB28-0x000000018D39EB44
		public override string ToString(); // 0x000000018D3A8E50-0x000000018D3A8FBC
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A8FBC-0x000000018D3A9110
		public static implicit operator float4(Vector4 v); // 0x0000000185483D20-0x0000000185483D40
		public static implicit operator Vector4(float4 v); // 0x0000000185483D20-0x0000000185483D40
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x2 : IEquatable<Unity.Mathematics.float4x2>, IFormattable // TypeDefIndex: 88903
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
	
		// Constructors
		public float4x2(int v); // 0x000000018725DA40-0x000000018725DA60
	
		// Methods
		public static implicit operator float4x2(int v); // 0x000000018D3A9814-0x000000018D3A9830
		public bool Equals(float4x2 rhs); // 0x000000018D3A92D0-0x000000018D3A9318
		public override bool Equals(object o); // 0x000000018D3A9318-0x000000018D3A938C
		public override int GetHashCode(); // 0x000000018D3A938C-0x000000018D3A93B0
		public override string ToString(); // 0x000000018D3A95C4-0x000000018D3A9814
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A93B0-0x000000018D3A95C4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x3 : IEquatable<Unity.Mathematics.float4x3>, IFormattable // TypeDefIndex: 88904
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
	
		// Constructors
		public float4x3(float4 c0, float4 c1, float4 c2); // 0x000000018724E9F0-0x000000018724EA10
		public float4x3(int v); // 0x000000018725DA60-0x000000018725DA90
	
		// Methods
		public static implicit operator float4x3(int v); // 0x000000018D3A9FFC-0x000000018D3AA01C
		public static float4x3 operator *(float4x3 lhs, float4x3 rhs); // 0x000000018D3AA01C-0x000000018D3AA0D8
		public static float4x3 operator *(float4x3 lhs, float rhs); // 0x000000018D3AA0D8-0x000000018D3AA164
		public static float4x3 operator +(float4x3 lhs, float4x3 rhs); // 0x000000018D3A9F40-0x000000018D3A9FFC
		public bool Equals(float4x3 rhs); // 0x000000018D3A98AC-0x000000018D3A990C
		public override bool Equals(object o); // 0x000000018D3A9830-0x000000018D3A98AC
		public override int GetHashCode(); // 0x000000018D3A990C-0x000000018D3A993C
		public override string ToString(); // 0x000000018D3A9C10-0x000000018D3A9F40
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3A993C-0x000000018D3A9C10
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x4 : IEquatable<Unity.Mathematics.float4x4>, IFormattable // TypeDefIndex: 88905
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
		public float4 c3; // 0x30
		public static readonly float4x4 identity; // 0x00
		public static readonly float4x4 zero; // 0x40
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x000000018725DAC0-0x000000018725DAD0 
	
		// Constructors
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3); // 0x000000018725DA90-0x000000018725DAC0
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33); // 0x0000000185812320-0x0000000185812420
		public float4x4(float v); // 0x0000000185D796D0-0x0000000185D797C0
		public float4x4(int v); // 0x0000000185E51830-0x0000000185E51870
		public float4x4(quaternion rotation, float3 translation); // 0x000000018D3AACE4-0x000000018D3AADE8
		static float4x4(); // 0x00000001870BDD70-0x00000001870BDE70
	
		// Methods
		public static implicit operator float4x4(float v); // 0x0000000185D796A0-0x0000000185D796D0
		public static implicit operator float4x4(int v); // 0x000000018D3AAFCC-0x000000018D3AAFF0
		public static float4x4 operator *(float4x4 lhs, float rhs); // 0x000000018D3AAFF0-0x000000018D3AB0A8
		public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs); // 0x000000018D3AADE8-0x000000018D3AAEB4
		public bool Equals(float4x4 rhs); // 0x000000018D3AA164-0x000000018D3AA1E0
		public override bool Equals(object o); // 0x000000018D3AA1E0-0x000000018D3AA264
		public override int GetHashCode(); // 0x000000018D3AA264-0x000000018D3AA29C
		public override string ToString(); // 0x000000018D3AA540-0x000000018D3AA950
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AA950-0x000000018D3AACE4
		public static implicit operator float4x4(Matrix4x4 m); // 0x000000018D3AAEB4-0x000000018D3AAFCC
		public static implicit operator Matrix4x4(float4x4 m); // 0x0000000185812130-0x0000000185812320
		public static float4x4 Ortho(float width, float height, float near, float far); // 0x000000018D3AA29C-0x000000018D3AA388
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale); // 0x000000018D3AA388-0x000000018D3AA540
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct half : IEquatable<Unity.Mathematics.half>, IFormattable // TypeDefIndex: 88906
	{
		// Fields
		public ushort value; // 0x00
		public static readonly half zero; // 0x00
	
		// Constructors
		public half(float v); // 0x000000018D3ABAC4-0x000000018D3ABADC
		public half(double v); // 0x000000018D3ABAA8-0x000000018D3ABAC4
	
		// Methods
		public static explicit operator half(float v); // 0x000000018D3ABAE4-0x000000018D3ABAEC
		public static explicit operator half(double v); // 0x000000018D3ABAEC-0x000000018D3ABAF8
		public static implicit operator float(half d); // 0x000000018D3ABAF8-0x000000018D3ABB00
		public static bool operator ==(half lhs, half rhs); // 0x000000018D3ABADC-0x000000018D3ABAE4
		public bool Equals(half rhs); // 0x000000018625FA70-0x000000018625FA80
		public override bool Equals(object o); // 0x000000018D3AB9F0-0x000000018D3ABA50
		public override int GetHashCode(); // 0x000000018448B780-0x000000018448B790
		public override string ToString(); // 0x000000018D3ABA50-0x000000018D3ABA74
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3ABA74-0x000000018D3ABAA8
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half2 : IEquatable<Unity.Mathematics.half2>, IFormattable // TypeDefIndex: 88908
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88907
		{
		}
	
		// Constructors
		public half2(float2 v); // 0x000000018D3AB288-0x000000018D3AB2B8
	
		// Methods
		public static explicit operator half2(float2 v); // 0x000000018D3AB2B8-0x000000018D3AB2EC
		public bool Equals(half2 rhs); // 0x000000018D3AB11C-0x000000018D3AB130
		public override bool Equals(object o); // 0x000000018D3AB0A8-0x000000018D3AB11C
		public override int GetHashCode(); // 0x000000018D3AB130-0x000000018D3AB178
		public override string ToString(); // 0x000000018D3AB1FC-0x000000018D3AB288
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AB178-0x000000018D3AB1FC
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half3 : IEquatable<Unity.Mathematics.half3>, IFormattable // TypeDefIndex: 88910
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88909
		{
		}
	
		// Constructors
		public half3(float3 v); // 0x000000018D3AB570-0x000000018D3AB5AC
		public half3(double3 v); // 0x000000018D3AB528-0x000000018D3AB570
	
		// Methods
		public static explicit operator half3(float3 v); // 0x000000018D3AB5F8-0x000000018D3AB63C
		public static explicit operator half3(double3 v); // 0x000000018D3AB5AC-0x000000018D3AB5F8
		public bool Equals(half3 rhs); // 0x000000018D3AB2EC-0x000000018D3AB310
		public override bool Equals(object o); // 0x000000018D3AB310-0x000000018D3AB39C
		public override int GetHashCode(); // 0x000000018D3AB39C-0x000000018D3AB3C0
		public override string ToString(); // 0x000000018D3AB46C-0x000000018D3AB528
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AB3C0-0x000000018D3AB46C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half4 : IEquatable<Unity.Mathematics.half4>, IFormattable // TypeDefIndex: 88912
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
		public half w; // 0x06
		public static readonly half4 zero; // 0x00
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88911
		{
		}
	
		// Constructors
		public half4(float4 v); // 0x000000018D3AB950-0x000000018D3AB99C
	
		// Methods
		public static explicit operator half4(float4 v); // 0x000000018D3AB99C-0x000000018D3AB9F0
		public bool Equals(half4 rhs); // 0x000000018D3A5AF0-0x000000018D3A79F0
		public override bool Equals(object o); // 0x000000018D3AB63C-0x000000018D3AB69C
		public override int GetHashCode(); // 0x000000018D3AB69C-0x000000018D3AB6A4
		public override string ToString(); // 0x000000018D3AB6A4-0x000000018D3AB808
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AB808-0x000000018D3AB950
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int2 : IEquatable<Unity.Mathematics.int2>, IFormattable // TypeDefIndex: 88914
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public static readonly int2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get; } // 0x000000018725DB00-0x000000018725DB20 
		public int this[int index] { set {} } // 0x000000018725DB70-0x000000018725DB80
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88913
		{
		}
	
		// Constructors
		public int2(int x, int y); // 0x00000001827241A0-0x00000001827241B0
		public int2(int v); // 0x000000018725DAD0-0x000000018725DAE0
		public int2(float2 v); // 0x000000018725DAE0-0x000000018725DB00
	
		// Methods
		public static implicit operator int2(int v); // 0x000000018725DB60-0x000000018725DB70
		public static explicit operator int2(float2 v); // 0x000000018725DB40-0x000000018725DB60
		public static int2 operator +(int2 lhs, int2 rhs); // 0x0000000187232970-0x0000000187232990
		public static int2 operator +(int2 lhs, int rhs); // 0x000000018725DB20-0x000000018725DB40
		public static int2 operator /(int2 lhs, int rhs); // 0x000000018D3ABCB8-0x000000018D3ABCDC
		public bool Equals(int2 rhs); // 0x00000001887DCEB4-0x00000001887DCEC8
		public override bool Equals(object o); // 0x000000018D3ABB00-0x000000018D3ABB74
		public override int GetHashCode(); // 0x000000018D3ABB74-0x000000018D3ABBA8
		public override string ToString(); // 0x000000018D3ABC30-0x000000018D3ABCB8
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3ABBA8-0x000000018D3ABC30
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x3 : IEquatable<Unity.Mathematics.int2x3>, IFormattable // TypeDefIndex: 88915
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
	
		// Properties
		public ref int2 this[int index] { get => default; } // 0x000000018725DB80-0x000000018725DB90 
	
		// Constructors
		public int2x3(int2 c0, int2 c1, int2 c2); // 0x0000000187238E20-0x0000000187238E30
	
		// Methods
		public bool Equals(int2x3 rhs); // 0x000000018D3ABCDC-0x000000018D3ABD40
		public override bool Equals(object o); // 0x000000018D3ABD40-0x000000018D3ABDB4
		public override int GetHashCode(); // 0x000000018D3ABDB4-0x000000018D3ABDDC
		public override string ToString(); // 0x000000018D3ABDDC-0x000000018D3ABFA4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3ABFA4-0x000000018D3AC158
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int3 : IEquatable<Unity.Mathematics.int3>, IFormattable // TypeDefIndex: 88917
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public static readonly int3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyz { set; } // 0x0000000187235E90-0x0000000187235EB0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzy { get; } // 0x000000018725BC20-0x000000018725BC40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get; set; } // 0x000000018725DB00-0x000000018725DB20 0x000000018725DCB0-0x000000018725DCC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yz { get; } // 0x000000018725DBD0-0x000000018725DBF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zx { get; } // 0x000000018725DBF0-0x000000018725DC10 
		public int this[int index] { get => default; set {} } // 0x000000018725DBC0-0x000000018725DBD0 0x000000018725DB70-0x000000018725DB80
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88916
		{
		}
	
		// Constructors
		public int3(int x, int y, int z); // 0x0000000187232A60-0x0000000187232A70
		public int3(int v); // 0x000000018725DBB0-0x000000018725DBC0
		public int3(float3 v); // 0x000000018725DB90-0x000000018725DBB0
	
		// Methods
		public static implicit operator int3(int v); // 0x000000018725DC60-0x000000018725DC70
		public static explicit operator int3(float3 v); // 0x000000018725D440-0x000000018725D470
		public static int3 operator +(int3 lhs, int3 rhs); // 0x000000018725DC10-0x000000018725DC30
		public static int3 operator +(int3 lhs, int rhs); // 0x000000018725DC30-0x000000018725DC60
		public static int3 operator -(int3 lhs, int3 rhs); // 0x000000018725DC90-0x000000018725DCB0
		public static int3 operator -(int3 lhs, int rhs); // 0x000000018725DC70-0x000000018725DC90
		public static int3 operator /(int3 lhs, int rhs); // 0x000000018D3AC358-0x000000018D3AC380
		public static bool3 operator <=(int3 lhs, int3 rhs); // 0x000000018D3AC3A8-0x000000018D3AC3D0
		public static bool3 operator >=(int3 lhs, int3 rhs); // 0x000000018D3AC380-0x000000018D3AC3A8
		public bool Equals(int3 rhs); // 0x00000001887DD288-0x00000001887DD2A4
		public override bool Equals(object o); // 0x000000018D3AC158-0x000000018D3AC1EC
		public override int GetHashCode(); // 0x000000018920D324-0x000000018920D348
		public override string ToString(); // 0x000000018D3AC2A0-0x000000018D3AC358
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AC1EC-0x000000018D3AC2A0
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int4 : IEquatable<Unity.Mathematics.int4>, IFormattable // TypeDefIndex: 88919
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
		public static readonly int4 zero; // 0x00
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x000000018725DBC0-0x000000018725DBD0 0x000000018725DB70-0x000000018725DB80
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88918
		{
		}
	
		// Constructors
		public int4(int x, int y, int z, int w); // 0x0000000187235B70-0x0000000187235B90
		public int4(int v); // 0x000000018725DCC0-0x000000018725DCD0
	
		// Methods
		public static implicit operator int4(int v); // 0x000000018725D5C0-0x000000018725D5D0
		public static int4 operator +(int4 lhs, int rhs); // 0x000000018725DCD0-0x000000018725DD00
		public bool Equals(int4 rhs); // 0x0000000188BCAFE8-0x0000000188BCB00C
		public override bool Equals(object o); // 0x000000018D3AC3D0-0x000000018D3AC43C
		public override int GetHashCode(); // 0x000000018D3AC43C-0x000000018D3AC458
		public override string ToString(); // 0x000000018D3AC458-0x000000018D3AC5B4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AC5B4-0x000000018D3AC708
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x2 : IEquatable<Unity.Mathematics.int4x2>, IFormattable // TypeDefIndex: 88920
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
	
		// Constructors
		public int4x2(int v); // 0x000000018725DD00-0x000000018725DD40
	
		// Methods
		public static implicit operator int4x2(int v); // 0x000000018D3ACC28-0x000000018D3ACC44
		public bool Equals(int4x2 rhs); // 0x000000018D3AC708-0x000000018D3AC74C
		public override bool Equals(object o); // 0x000000018D3AC74C-0x000000018D3AC7C0
		public override int GetHashCode(); // 0x000000018D3AC7C0-0x000000018D3AC7E4
		public override string ToString(); // 0x000000018D3AC7E4-0x000000018D3ACA14
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3ACA14-0x000000018D3ACC28
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<Unity.Mathematics.quaternion>, IFormattable // TypeDefIndex: 88921
	{
		// Fields
		public float4 value; // 0x00
		public static readonly quaternion identity; // 0x00
	
		// Constructors
		public quaternion(float x, float y, float z, float w); // 0x00000001872359D0-0x00000001872359F0
		public quaternion(float4 value); // 0x000000018723AC90-0x000000018723ACA0
		public quaternion(float3x3 m); // 0x00000001857A1F90-0x00000001857A23F0
		public quaternion(float4x4 m); // 0x000000018D3AEE80-0x000000018D3AF1A0
		static quaternion(); // 0x0000000187213320-0x0000000187213360
	
		// Methods
		public static implicit operator Quaternion(quaternion q); // 0x0000000185483D20-0x0000000185483D40
		public static implicit operator quaternion(Quaternion q); // 0x0000000185483D20-0x0000000185483D40
		public static implicit operator quaternion(float4 v); // 0x000000018723AC80-0x000000018723AC90
		public static quaternion AxisAngle(float3 axis, float angle); // 0x00000001885A5AD0-0x00000001885A5BC0
		public static quaternion EulerXYZ(float3 xyz); // 0x00000001885A5BC0-0x00000001885A5DA0
		public static quaternion EulerXZY(float3 xyz); // 0x00000001885A5DA0-0x00000001885A5F80
		public static quaternion EulerYXZ(float3 xyz); // 0x00000001885A5F80-0x00000001885A6160
		public static quaternion EulerYZX(float3 xyz); // 0x00000001885A6160-0x00000001885A6340
		public static quaternion EulerZXY(float3 xyz); // 0x000000018D3AE3BC-0x000000018D3AE59C
		public static quaternion EulerZYX(float3 xyz); // 0x00000001885A6378-0x00000001885A6558
		public static quaternion EulerXYZ(float x, float y, float z); // 0x000000018D3AE2DC-0x000000018D3AE314
		public static quaternion EulerXZY(float x, float y, float z); // 0x000000018D3AE314-0x000000018D3AE34C
		public static quaternion EulerYXZ(float x, float y, float z); // 0x000000018D3AE34C-0x000000018D3AE384
		public static quaternion EulerYZX(float x, float y, float z); // 0x000000018D3AE384-0x000000018D3AE3BC
		public static quaternion EulerZXY(float x, float y, float z); // 0x00000001885A6340-0x00000001885A6378
		public static quaternion EulerZYX(float x, float y, float z); // 0x000000018D3AE59C-0x000000018D3AE5D4
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x02648824 */); // 0x000000018D3AE5D4-0x000000018D3AE730
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x02648825 */); // 0x00000001885A6558-0x00000001885A6594
		public static quaternion RotateX(float angle); // 0x00000001885A6594-0x00000001885A65F8
		public static quaternion RotateY(float angle); // 0x000000018D3AEB5C-0x000000018D3AEBC0
		public static quaternion RotateZ(float angle); // 0x00000001885A65F8-0x00000001885A67B0
		public static quaternion LookRotation(float3 forward, float3 up); // 0x000000018D3AEA40-0x000000018D3AEB5C
		public static quaternion LookRotationSafe(float3 forward, float3 up); // 0x000000018D3AE730-0x000000018D3AEA40
		public bool Equals(quaternion x); // 0x00000001862F2760-0x00000001862F27A0
		public override bool Equals(object x); // 0x000000018D3AE270-0x000000018D3AE2DC
		public override int GetHashCode(); // 0x000000018D39EB28-0x000000018D39EB44
		public override string ToString(); // 0x000000018D3AEBC0-0x000000018D3AED2C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AED2C-0x000000018D3AEE80
	}

	[Il2CppEagerStaticClassConstruction]
	public static class noise // TypeDefIndex: 88922
	{
		// Methods
		public static float cnoise(float2 P); // 0x000000018D3ACC44-0x000000018D3AD1B8
		public static float pnoise(float2 P, float2 rep); // 0x000000018D3AD558-0x000000018D3ADB08
		private static float2 mod289(float2 x); // 0x000000018D3AD308-0x000000018D3AD358
		private static float3 mod289(float3 x); // 0x000000018D3AD23C-0x000000018D3AD308
		private static float4 mod289(float4 x); // 0x000000018D3AD358-0x000000018D3AD3FC
		private static float3 permute(float3 x); // 0x000000018D3AD494-0x000000018D3AD558
		private static float4 permute(float4 x); // 0x000000018D3AD3FC-0x000000018D3AD494
		private static float4 taylorInvSqrt(float4 r); // 0x000000018D3AE218-0x000000018D3AE270
		private static float2 fade(float2 t); // 0x000000018D3AD1B8-0x000000018D3AD23C
		public static float snoise(float2 v); // 0x000000018D3ADB08-0x000000018D3AE218
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct Random // TypeDefIndex: 88923
	{
		// Fields
		public uint state; // 0x00
	
		// Constructors
		public Random(uint seed); // 0x000000018725D600-0x000000018725D620
	
		// Methods
		public static Random CreateFromIndex(uint index); // 0x000000018D3A79F0-0x000000018D3A7A18
		internal static uint WangHash(uint n); // 0x00000001870A34B0-0x00000001870A34E0
		public float NextFloat(); // 0x00000001858F2FC0-0x00000001858F3000
		public float3 NextFloat3(); // 0x00000001899DC3B4-0x00000001899DC584
		private uint NextState(); // 0x000000018725D5E0-0x000000018725D600
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2 : IEquatable<Unity.Mathematics.uint2>, IFormattable // TypeDefIndex: 88925
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88924
		{
		}
	
		// Constructors
		public uint2(uint x, uint y); // 0x00000001827241A0-0x00000001827241B0
	
		// Methods
		public static uint2 operator *(uint2 lhs, uint2 rhs); // 0x000000018725DD40-0x000000018725DD60
		public static uint2 operator +(uint2 lhs, uint2 rhs); // 0x0000000187232970-0x0000000187232990
		public bool Equals(uint2 rhs); // 0x00000001887DCEB4-0x00000001887DCEC8
		public override bool Equals(object o); // 0x000000018D3AF1A0-0x000000018D3AF214
		public override int GetHashCode(); // 0x000000018D3AF214-0x000000018D3AF248
		public override string ToString(); // 0x000000018D3AF2D0-0x000000018D3AF358
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AF248-0x000000018D3AF2D0
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3 : IEquatable<Unity.Mathematics.uint3>, IFormattable // TypeDefIndex: 88927
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
	
		// Properties
		public uint this[int index] { get => default; set {} } // 0x000000018725DBC0-0x000000018725DBD0 0x000000018725DB70-0x000000018725DB80
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88926
		{
		}
	
		// Constructors
		public uint3(uint x, uint y, uint z); // 0x0000000187232A60-0x0000000187232A70
	
		// Methods
		public static uint3 operator *(uint3 lhs, uint3 rhs); // 0x000000018725DDC0-0x000000018725DDF0
		public static uint3 operator +(uint3 lhs, uint3 rhs); // 0x000000018725DC10-0x000000018725DC30
		public static bool3 operator >(uint3 lhs, uint rhs); // 0x000000018D3AF57C-0x000000018D3AF59C
		public static uint3 operator >>(uint3 x, int n); // 0x000000018725DDF0-0x000000018725DE20
		public static uint3 operator &(uint3 lhs, uint rhs); // 0x000000018725DD60-0x000000018725DD80
		public static uint3 operator |(uint lhs, uint3 rhs); // 0x000000018725DD80-0x000000018725DDA0
		public static uint3 operator ^(uint3 lhs, uint3 rhs); // 0x000000018725DDA0-0x000000018725DDC0
		public bool Equals(uint3 rhs); // 0x00000001887DD288-0x00000001887DD2A4
		public override bool Equals(object o); // 0x000000018D3AF358-0x000000018D3AF3EC
		public override int GetHashCode(); // 0x000000018D3AF3EC-0x000000018D3AF410
		public override string ToString(); // 0x000000018D3AF4C4-0x000000018D3AF57C
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AF410-0x000000018D3AF4C4
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4 : IEquatable<Unity.Mathematics.uint4>, IFormattable // TypeDefIndex: 88929
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
		public uint w; // 0x0C
	
		// Properties
		public uint this[int index] { get => default; set {} } // 0x000000018725DBC0-0x000000018725DBD0 0x000000018725DB70-0x000000018725DB80
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 88928
		{
		}
	
		// Constructors
		public uint4(uint x, uint y, uint z, uint w); // 0x0000000187235B70-0x0000000187235B90
		public uint4(uint v); // 0x000000018725DCC0-0x000000018725DCD0
		public uint4(int v); // 0x000000018725DCC0-0x000000018725DCD0
	
		// Methods
		public static implicit operator uint4(uint v); // 0x000000018725D5C0-0x000000018725D5D0
		public static uint4 operator *(uint4 lhs, uint4 rhs); // 0x000000018725DF10-0x000000018725DF40
		public static uint4 operator +(uint4 lhs, uint4 rhs); // 0x000000018725DE20-0x000000018725DE50
		public static bool4 operator >(uint4 lhs, uint rhs); // 0x000000018D3AF8D4-0x000000018D3AF8F8
		public static uint4 operator ~(uint4 val); // 0x000000018725DF40-0x000000018725DF70
		public static uint4 operator &(uint4 lhs, uint4 rhs); // 0x000000018725DE50-0x000000018725DE80
		public static uint4 operator &(uint4 lhs, uint rhs); // 0x000000018725DE80-0x000000018725DEB0
		public static uint4 operator |(uint4 lhs, uint4 rhs); // 0x000000018725DEB0-0x000000018725DEE0
		public static uint4 operator ^(uint4 lhs, uint4 rhs); // 0x000000018725DEE0-0x000000018725DF10
		public bool Equals(uint4 rhs); // 0x0000000188BCAFE8-0x0000000188BCB00C
		public override bool Equals(object o); // 0x000000018D3AF59C-0x000000018D3AF608
		public override int GetHashCode(); // 0x000000018D3AF608-0x000000018D3AF624
		public override string ToString(); // 0x000000018D3AF778-0x000000018D3AF8D4
		public string ToString(string format, IFormatProvider formatProvider); // 0x000000018D3AF624-0x000000018D3AF778
	}
}
