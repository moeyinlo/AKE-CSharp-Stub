/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 162: Il2cppExt.dll - Assembly: Il2cppExt, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91451-91454

namespace Unity.IL2CPP.CompilerServices
{
	public enum Il2CppHotPatchOptionMode // TypeDefIndex: 91452
	{
		Default = 0,
		ForcePatch = 1,
		ForceNoPatch = 2
	}

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class Il2CppHotPatchOptionAttribute : Attribute // TypeDefIndex: 91453
	{
		// Fields
		[CompilerGenerated]
		private Il2CppHotPatchOptionMode _Mode_k__BackingField; // 0x10
	
		// Properties
		public Il2CppHotPatchOptionMode Mode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001828BC2B0-0x00000001828BC2C0 0x0000000182234E90-0x0000000182234EA0
	
		// Constructors
		public Il2CppHotPatchOptionAttribute(Il2CppHotPatchOptionMode mode); // 0x0000000182234E90-0x0000000182234EA0
	}
}

namespace Unity.IL2CPP.Runtime
{
	public static class HotPatch // TypeDefIndex: 91454
	{
		// Methods
		public static bool SetPatch(MethodBase method, Delegate handler); // 0x000000018C264798-0x000000018C264F74
		public static void ClearPatch(MethodBase method); // 0x000000018C264764-0x000000018C264798
		public static void ClearAllPatches(); // 0x000000018C264738-0x000000018C264764
	}
}
