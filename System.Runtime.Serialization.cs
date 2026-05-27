/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 153: System.Runtime.Serialization.dll - Assembly: System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 60215-60219
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Configuration.dll")]
[assembly: AssemblyDescription("System.Configuration.dll")]
[assembly: AssemblyFileVersion("4.8.3761.0")]
[assembly: AssemblyInformationalVersion("4.8.3761.0")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Configuration.dll")]
[assembly: CLSCompliant(true)]
[assembly: ComCompatibleVersion(1, 0, 3300, 0)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32 | DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.LegacyBehavior)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace System.Runtime.Serialization
{
	[DefaultMember("Item")]
	public sealed class DataContractAttribute : Attribute // TypeDefIndex: 60216
	{
		// Fields
		private bool isReference; // 0x10
	
		// Properties
		public bool IsReference { get => default; } // 0x00000001811797F0-0x0000000181179800 
	
		// Constructors
		public DataContractAttribute() {} // Dummy constructor
	}

	public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 60217
	{
		// Fields
		private string name; // 0x10
		private int order; // 0x18
		private bool isRequired; // 0x1C
		private bool emitDefaultValue; // 0x1D
	
		// Properties
		public string Name { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int Order { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public bool IsRequired { get => default; } // 0x0000000183D4E9A0-0x0000000183D4E9B0 
		public bool EmitDefaultValue { get => default; } // 0x0000000183D50D90-0x0000000183D50DA0 
	
		// Constructors
		public DataMemberAttribute() {} // Dummy constructor
	}

	public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 60218
	{
		// Fields
		private string value; // 0x10
	
		// Properties
		public string Value { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public EnumMemberAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[DefaultMember("Item")]
	public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 60219
	{
		// Constructors
		public IgnoreDataMemberAttribute() {} // Dummy constructor
	}
}
