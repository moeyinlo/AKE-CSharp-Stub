/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 157: System.Runtime.Serialization.dll - Assembly: System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 91416-91420

namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute // TypeDefIndex: 91417
	{
		// Fields
		private bool isReference; // 0x10
	
		// Properties
		public bool IsReference { get; } // 0x00000001829D0800-0x00000001829D0810 
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 91418
	{
		// Fields
		private string name; // 0x10
		private int order; // 0x18
		private bool isRequired; // 0x1C
		private bool emitDefaultValue; // 0x1D
	
		// Properties
		public string Name { get; } // 0x00000001829260F0-0x0000000182926100 
		public int Order { get; } // 0x00000001844AF510-0x00000001844AF520 
		public bool IsRequired { get; } // 0x000000018226EB80-0x000000018226EB90 
		public bool EmitDefaultValue { get; } // 0x000000018226ED00-0x000000018226ED10 
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 91419
	{
		// Fields
		private string value; // 0x10
	
		// Properties
		public string Value { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public EnumMemberAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 91420
	{
	}
}
