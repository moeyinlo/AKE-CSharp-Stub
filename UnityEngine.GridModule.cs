/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 141: UnityEngine.GridModule.dll - Assembly: UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91308-91310

namespace UnityEngine
{
	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Grid/Public/Grid.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Grid : GridLayout // TypeDefIndex: 91309
	{
		// Properties
		public Vector3 cellSize { [FreeFunction("GridBindings::GetCellSize", HasExplicitThis = true)] get; } // 0x000000018D520F48-0x000000018D520F74 
	
		// Constructors
		public Grid(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void get_cellSize_Injected(out Vector3 ret); // 0x000000018D520F04-0x000000018D520F48
	}

	[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
	[NativeType(Header = "Modules/Grid/Public/Grid.h")]
	[RequireComponent(typeof(Transform))]
	public class GridLayout : Behaviour // TypeDefIndex: 91310
	{
		// Constructors
		public GridLayout(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[FreeFunction("GridLayoutBindings::CellToLocal", HasExplicitThis = true)]
		public Vector3 CellToLocal(Vector3Int cellPosition); // 0x000000018D520ED0-0x000000018D520F04
		[RequiredByNativeCode]
		private void DoNothing(); // 0x0000000186805BA0-0x0000000186805BB0
		private void CellToLocal_Injected(ref Vector3Int cellPosition, out Vector3 ret); // 0x000000018D520E7C-0x000000018D520ED0
	}
}
