/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 156: System.Runtime.Serialization.dll - Assembly: System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 63931-63935
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Runtime.Serialization.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Runtime.Serialization.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../silverlight.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Runtime.Serialization.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute // TypeDefIndex: 63932
	{
		// Fields
		private bool isReference; // 0x10
	
		// Properties
		public bool IsReference { get; } // 0x00000001815EFCE0-0x00000001815EFCF0 
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 63933
	{
		// Fields
		private string name; // 0x10
		private int order; // 0x18
		private bool isRequired; // 0x1C
		private bool emitDefaultValue; // 0x1D
	
		// Properties
		public string Name { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public int Order { get; } // 0x00000001811EF5B0-0x00000001811EF5C0 
		public bool IsRequired { get; } // 0x0000000184D86150-0x0000000184D86160 
		public bool EmitDefaultValue { get; } // 0x0000000184D88310-0x0000000184D88320 
	}

	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 63934
	{
		// Fields
		private string value; // 0x10
	
		// Properties
		public string Value { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public EnumMemberAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 63935
	{
	}
}
