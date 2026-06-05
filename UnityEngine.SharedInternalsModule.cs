/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 121: UnityEngine.SharedInternalsModule.dll - Assembly: UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61021-61049

namespace UnityEngine
{
	internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 61022
	{
		// Fields
		private readonly string _preferredExtension_k__BackingField; // 0x10
		private readonly IEnumerable<string> _otherExtensions_k__BackingField; // 0x18
	
		// Constructors
		public AssetFileNameExtensionAttribute() {} // Dummy constructor
		public AssetFileNameExtensionAttribute(string preferredExtension, string[] otherExtensions) {} // 0x0000000185FA9420-0x0000000185FA9450
	}

	internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 61023
	{
		// Constructors
		public ThreadAndSerializationSafeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class WritableAttribute : Attribute // TypeDefIndex: 61024
	{
		// Constructors
		public WritableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 61025
	{
		// Constructors
		public UnityEngineModuleAssembly() {} // 0x0000000185492010-0x0000000185492020
	}

	internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 61026
	{
		// Fields
		private string _QualifiedNativeName_k__BackingField; // 0x10
		private string _Declaration_k__BackingField; // 0x18
	
		// Properties
		private string QualifiedNativeName { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		private string Declaration { get; set; } // 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public NativeClassAttribute() {} // Dummy constructor
		public NativeClassAttribute(string qualifiedCppName) {} // 0x0000000185C65C60-0x0000000185C65CD0
		public NativeClassAttribute(string qualifiedCppName, string declaration) {} // 0x00000001841BC230-0x00000001841BC260
	}

	internal sealed class UnityString // TypeDefIndex: 61027
	{
		// Constructors
		public UnityString() {} // Dummy constructor
	
		// Methods
		public static string Format(string fmt, object[] args) => default; // 0x0000000184D07130-0x0000000184D071B0
	}
}

namespace UnityEngine.Bindings
{
	internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 61028
	{
		// Constructors
		public VisibleToOtherModulesAttribute() {} // 0x0000000185492010-0x0000000185492020
		public VisibleToOtherModulesAttribute(string[] modules) {} // 0x0000000185492010-0x0000000185492020
	}

	internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 61029
	{
		// Fields
		private string _Condition_k__BackingField; // 0x10
		private string _StubReturnStatement_k__BackingField; // 0x18
		private bool _Enabled_k__BackingField; // 0x20
	
		// Properties
		public string Condition { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public string StubReturnStatement { get; set; } // 0x0000000184088E70-0x0000000184088E80
		public bool Enabled { get; set; } // 0x00000001813EE9B0-0x00000001813EE9C0
	
		// Constructors
		public NativeConditionalAttribute() {} // Dummy constructor
		public NativeConditionalAttribute(string condition) {} // 0x0000000185FADB50-0x0000000185FADB70
		public NativeConditionalAttribute(string condition, string stubReturnStatement) {} // 0x000000018BF4089C-0x000000018BF408CC
	}

	internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 61030
	{
		// Fields
		private string _Header_k__BackingField; // 0x10
	
		// Properties
		public string Header { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public NativeHeaderAttribute() {} // Dummy constructor
		public NativeHeaderAttribute(string header) {} // 0x00000001856C66D0-0x00000001856C6740
	}

	internal class NativeNameAttribute : Attribute // TypeDefIndex: 61031
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
	
		// Properties
		public string Name { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public NativeNameAttribute() {} // Dummy constructor
		public NativeNameAttribute(string name) {} // 0x0000000185F52E10-0x0000000185F52E80
	}

	internal sealed class NativeWritableSelfAttribute : Attribute // TypeDefIndex: 61032
	{
		// Fields
		private bool _WritableSelf_k__BackingField; // 0x10
	
		// Properties
		public bool WritableSelf { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public NativeWritableSelfAttribute() {} // 0x0000000181B9A230-0x0000000181B9A240
	}

	internal class NativeMethodAttribute : Attribute // TypeDefIndex: 61033
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private bool _IsThreadSafe_k__BackingField; // 0x18
		private bool _IsFreeFunction_k__BackingField; // 0x19
		private bool _ThrowsException_k__BackingField; // 0x1A
		private bool _HasExplicitThis_k__BackingField; // 0x1B
	
		// Properties
		public string Name { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public bool IsThreadSafe { get; set; } // 0x00000001813C0520-0x00000001813C0530
		public bool IsFreeFunction { get; set; } // 0x0000000181A73EB0-0x0000000181A73EC0
		public bool ThrowsException { get; set; } // 0x0000000185FB0740-0x0000000185FB0750
		public bool HasExplicitThis { get; set; } // 0x0000000185FB35C0-0x0000000185FB35D0
	
		// Constructors
		public NativeMethodAttribute() {} // 0x0000000185492010-0x0000000185492020
		public NativeMethodAttribute(string name) {} // 0x000000018BF40908-0x000000018BF40A20
		public NativeMethodAttribute(string name, bool isFreeFunction) {} // 0x000000018BF40A20-0x000000018BF40A48
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe) {} // 0x000000018BF408CC-0x000000018BF40908
	}

	internal enum TargetType // TypeDefIndex: 61034
	{
		Function = 0,
		Field = 1
	}

	internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 61035
	{
		// Fields
		private TargetType _TargetType_k__BackingField; // 0x20
	
		// Properties
		public TargetType TargetType { get; set; } // 0x00000001813B9430-0x00000001813B9440
	
		// Constructors
		public NativePropertyAttribute() {} // 0x0000000185492010-0x0000000185492020
		public NativePropertyAttribute(string name) {} // 0x000000018BF40A48-0x000000018BF40A50
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType) {} // 0x000000018BF40A50-0x000000018BF40A88
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe) {} // 0x000000018BF40A88-0x000000018BF40ABC
	}

	internal enum CodegenOptions // TypeDefIndex: 61036
	{
		Auto = 0,
		Custom = 1,
		Force = 2
	}

	internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 61037
	{
		// Constructors
		public NativeAsStructAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class NativeTypeAttribute : Attribute // TypeDefIndex: 61038
	{
		// Fields
		private string _Header_k__BackingField; // 0x10
		private string _IntermediateScriptingStructName_k__BackingField; // 0x18
		private CodegenOptions _CodegenOptions_k__BackingField; // 0x20
	
		// Properties
		public string Header { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public string IntermediateScriptingStructName { get; set; } // 0x0000000184088E70-0x0000000184088E80
		public CodegenOptions CodegenOptions { get; set; } // 0x00000001813B9430-0x00000001813B9440
	
		// Constructors
		public NativeTypeAttribute() {} // 0x0000000185FAFE40-0x0000000185FAFE50
		public NativeTypeAttribute(CodegenOptions codegenOptions) {} // 0x00000001813B9430-0x00000001813B9440
		public NativeTypeAttribute(string header) {} // 0x0000000185F4FB70-0x0000000185F4FBE0
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName) {} // 0x0000000185FAEBE0-0x0000000185FAEBF0
	}

	internal class NotNullAttribute : Attribute // TypeDefIndex: 61039
	{
		// Fields
		private string _Exception_k__BackingField; // 0x10
	
		// Properties
		public string Exception { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public NotNullAttribute() {} // Dummy constructor
		public NotNullAttribute(string exception = "ArgumentNullException" /* Metadata: 0x02082D97 */) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 61040
	{
		// Constructors
		public UnmarshalledAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 61041
	{
		// Constructors
		public FreeFunctionAttribute() {} // 0x0000000185FB8080-0x0000000185FB8090
		public FreeFunctionAttribute(string name) {} // 0x000000018BF40860-0x000000018BF4087C
		public FreeFunctionAttribute(string name, bool isThreadSafe) {} // 0x000000018BF4087C-0x000000018BF4089C
	}

	internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 61042
	{
		// Constructors
		public ThreadSafeAttribute() {} // 0x0000000181B75280-0x0000000181B75290
	}

	internal enum StaticAccessorType // TypeDefIndex: 61043
	{
		Dot = 0,
		Arrow = 1,
		DoubleColon = 2,
		ArrowWithDefaultReturnIfNull = 3
	}

	internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 61044
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private StaticAccessorType _Type_k__BackingField; // 0x18
	
		// Properties
		public string Name { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public StaticAccessorType Type { get; set; } // 0x00000001813AE9C0-0x00000001813AE9D0
	
		// Constructors
		public StaticAccessorAttribute() {} // Dummy constructor
		internal StaticAccessorAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
		public StaticAccessorAttribute(string name, StaticAccessorType type) {} // 0x00000001845D7850-0x00000001845D7870
	}

	internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 61045
	{
		// Fields
		private bool _ThrowsException_k__BackingField; // 0x10
	
		// Properties
		public bool ThrowsException { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public NativeThrowsAttribute() {} // 0x0000000181B9A230-0x0000000181B9A240
	}

	internal class IgnoreAttribute : Attribute // TypeDefIndex: 61046
	{
		// Fields
		private bool _DoesNotContributeToSize_k__BackingField; // 0x10
	
		// Properties
		public bool DoesNotContributeToSize { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public IgnoreAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 61047
	{
		// Constructors
		public PreventReadOnlyInstanceModificationAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace UnityEngine.Scripting
{
	internal class UsedByNativeCodeAttribute : Attribute // TypeDefIndex: 61048
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
	
		// Properties
		public string Name { get; set; } // 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public UsedByNativeCodeAttribute() {} // 0x0000000185492010-0x0000000185492020
		public UsedByNativeCodeAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class RequiredByNativeCodeAttribute : Attribute // TypeDefIndex: 61049
	{
		// Fields
		private string _Name_k__BackingField; // 0x10
		private bool _Optional_k__BackingField; // 0x18
		private bool _GenerateProxy_k__BackingField; // 0x19
	
		// Properties
		public string Name { get; set; } // 0x0000000184096E30-0x0000000184096EF0
		public bool Optional { get; set; } // 0x00000001813C0520-0x00000001813C0530
		public bool GenerateProxy { get; set; } // 0x0000000181A73EB0-0x0000000181A73EC0
	
		// Constructors
		public RequiredByNativeCodeAttribute() {} // 0x0000000185492010-0x0000000185492020
		public RequiredByNativeCodeAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}
}
