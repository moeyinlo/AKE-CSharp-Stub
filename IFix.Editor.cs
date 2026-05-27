/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 156: IFix.Editor.dll - Assembly: IFix.Editor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60234-60240
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60236
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60237
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 60238
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 60239
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60240
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60235
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}
