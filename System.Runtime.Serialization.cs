/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;

// Image 154: System.Runtime.Serialization.dll - Assembly: System.Runtime.Serialization, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61292-61296

namespace System.Runtime.Serialization
{
	public sealed class DataContractAttribute : Attribute // TypeDefIndex: 61293
	{
		// Fields
		private bool isReference; // 0x10
	
		// Properties
		public bool IsReference { get => default; } // 0x0000000181C2FD60-0x0000000181C2FD70 
	
		// Constructors
		public DataContractAttribute() {} // Dummy constructor
	}

	public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 61294
	{
		// Fields
		private string name; // 0x10
		private int order; // 0x18
		private bool isRequired; // 0x1C
		private bool emitDefaultValue; // 0x1D
	
		// Properties
		public string Name { get => default; } // 0x000000018346D130-0x000000018346D140 
		public int Order { get => default; } // 0x00000001813AE560-0x00000001813AE570 
		public bool IsRequired { get => default; } // 0x00000001814088D0-0x00000001814088E0 
		public bool EmitDefaultValue { get => default; } // 0x0000000185FB2240-0x0000000185FB2250 
	
		// Constructors
		public DataMemberAttribute() {} // Dummy constructor
	}

	public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 61295
	{
		// Fields
		private string value; // 0x10
	
		// Properties
		public string Value { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public EnumMemberAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 61296
	{
		// Constructors
		public IgnoreDataMemberAttribute() {} // Dummy constructor
	}
}
