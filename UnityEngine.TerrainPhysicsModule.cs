/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 143: UnityEngine.TerrainPhysicsModule.dll - Assembly: UnityEngine.TerrainPhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91313-91315

namespace UnityEngine
{
	[NativeHeader("Modules/TerrainPhysics/TerrainCollider.h")]
	[UsedByNativeCode]
	public struct HGTerrainRaycastHit // TypeDefIndex: 91314
	{
		// Fields
		[NativeName("position")]
		internal Vector3 m_Position; // 0x00
		[NativeName("normal")]
		internal Vector3 m_Normal; // 0x0C
		[NativeName("distance")]
		internal float m_Distance; // 0x18
		[NativeName("edge01")]
		internal Vector3 m_Edge01; // 0x1C
		[NativeName("edge02")]
		internal Vector3 m_Edge02; // 0x28
	
		// Properties
		public Vector3 position { get; } // 0x000000018725FDC0-0x000000018725FDE0 
		public Vector3 normal { get; } // 0x000000018725FDA0-0x000000018725FDC0 
		public Vector3 edge01 { get; } // 0x000000018725FE20-0x000000018725FE40 
		public Vector3 edge02 { get; } // 0x000000018725FE00-0x000000018725FE20 
		public float distance { get; } // 0x0000000184F6C3E0-0x0000000184F6C650 
	}

	[NativeHeader("Modules/TerrainPhysics/TerrainCollider.h")]
	[NativeHeader("Modules/Terrain/Public/TerrainData.h")]
	public class TerrainCollider : Collider // TypeDefIndex: 91315
	{
		// Properties
		public TerrainData terrainData { set; } // 0x000000018D55A8B8-0x000000018D55A8FC
	
		// Methods
		private HGTerrainRaycastHit HGTerrainRaycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit); // 0x000000018D55A7E8-0x000000018D55A838
		public bool HGTerrainRaycast(Ray ray, out HGTerrainRaycastHit hitInfo, float maxDistance, bool hitHoles); // 0x000000018D55A838-0x000000018D55A8B8
		private void HGTerrainRaycast_Injected(ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out HGTerrainRaycastHit ret); // 0x000000018D55A784-0x000000018D55A7E8
	}
}
