/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 135: UnityEngine.GridModule.dll - Assembly: UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60091-60093

namespace UnityEngine
{
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Grid/Public/Grid.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Grid : GridLayout // TypeDefIndex: 60092
	{
		// Properties
		public Vector3 cellSize { [FreeFunction("GridBindings::GetCellSize", HasExplicitThis = true)] get => default; } // 0x0000000189DF4660-0x0000000189DF468C 
	
		// Constructors
		public Grid() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void get_cellSize_Injected(out Vector3 ret) {
			ret = default;
		} // 0x0000000189DF461C-0x0000000189DF4660
	}

	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Grid/Public/Grid.h")]
	[RequireComponent(typeof(Transform))]
	public class GridLayout : UnityEngine.Behaviour // TypeDefIndex: 60093
	{
		// Constructors
		public GridLayout() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		[FreeFunction("GridLayoutBindings::CellToLocal", HasExplicitThis = true)]
		public Vector3 CellToLocal(Vector3Int cellPosition) => default; // 0x0000000189DF45E8-0x0000000189DF461C
		[RequiredByNativeCode]
		private void DoNothing() {} // 0x000000018350B670-0x000000018350B680
		private void CellToLocal_Injected(ref Vector3Int cellPosition, out Vector3 ret) {
			ret = default;
		} // 0x0000000189DF4594-0x0000000189DF45E8
	}
}
