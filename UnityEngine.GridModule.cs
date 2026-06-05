/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 138: UnityEngine.GridModule.dll - Assembly: UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61200-61202

namespace UnityEngine
{
	public sealed class Grid : GridLayout // TypeDefIndex: 61201
	{
		// Properties
		public Vector3 cellSize { get => default; } // 0x000000018BF0C410-0x000000018BF0C43C 
	
		// Constructors
		public Grid() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void get_cellSize_Injected(out Vector3 ret) {
			ret = default;
		} // 0x000000018BF0C3CC-0x000000018BF0C410
	}

	public class GridLayout : Behaviour // TypeDefIndex: 61202
	{
		// Constructors
		public GridLayout() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public Vector3 CellToLocal(Vector3Int cellPosition) => default; // 0x000000018BF0C398-0x000000018BF0C3CC
		private void DoNothing() {} // 0x0000000185492010-0x0000000185492020
		private void CellToLocal_Injected(ref Vector3Int cellPosition, out Vector3 ret) {
			ret = default;
		} // 0x000000018BF0C344-0x000000018BF0C398
	}
}
