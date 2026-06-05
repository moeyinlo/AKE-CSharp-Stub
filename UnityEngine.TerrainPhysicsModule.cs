/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 140: UnityEngine.TerrainPhysicsModule.dll - Assembly: UnityEngine.TerrainPhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61205-61207

namespace UnityEngine
{
	public struct HGTerrainRaycastHit // TypeDefIndex: 61206
	{
		// Fields
		internal Vector3 m_Position; // 0x00
		internal Vector3 m_Normal; // 0x0C
		internal float m_Distance; // 0x18
		internal Vector3 m_Edge01; // 0x1C
		internal Vector3 m_Edge02; // 0x28
	
		// Properties
		public Vector3 position { get => default; } // 0x0000000185FE65B0-0x0000000185FE65D0 
		public Vector3 normal { get => default; } // 0x0000000185FE6590-0x0000000185FE65B0 
		public Vector3 edge01 { get => default; } // 0x0000000185FE6610-0x0000000185FE6630 
		public Vector3 edge02 { get => default; } // 0x0000000185FE65F0-0x0000000185FE6610 
		public float distance { get => default; } // 0x0000000185FE68F0-0x0000000185FE6900 
	}

	public class TerrainCollider : Collider // TypeDefIndex: 61207
	{
		// Properties
		public TerrainData terrainData { set {} } // 0x000000018BF45D2C-0x000000018BF45D70
	
		// Constructors
		public TerrainCollider() {} // Dummy constructor
	
		// Methods
		private HGTerrainRaycastHit HGTerrainRaycast(Ray ray, float maxDistance, bool hitHoles, ref bool hasHit) => default; // 0x000000018BF45C5C-0x000000018BF45CAC
		public bool HGTerrainRaycast(Ray ray, out HGTerrainRaycastHit hitInfo, float maxDistance, bool hitHoles) {
			hitInfo = default;
			return default;
		} // 0x000000018BF45CAC-0x000000018BF45D2C
		private void HGTerrainRaycast_Injected(ref Ray ray, float maxDistance, bool hitHoles, ref bool hasHit, out HGTerrainRaycastHit ret) {
			ret = default;
		} // 0x000000018BF45BF8-0x000000018BF45C5C
	}
}
