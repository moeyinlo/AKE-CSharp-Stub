/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 123: UnityEngine.SharedInternalsModule.dll - Assembly: UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91103-91131

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 91104
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _preferredExtension_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IEnumerable<string> _otherExtensions_k__BackingField; // 0x18
	
		// Constructors
		public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions); // 0x0000000187224CA0-0x0000000187224CD0
	}

	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 91105
	{
		// Constructors
		public ThreadAndSerializationSafeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	[VisibleToOtherModules]
	internal class WritableAttribute : Attribute // TypeDefIndex: 91106
	{
		// Constructors
		public WritableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Assembly)]
	[VisibleToOtherModules]
	internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 91107
	{
		// Constructors
		public UnityEngineModuleAssembly(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	[VisibleToOtherModules]
	internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 91108
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _QualifiedNativeName_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Declaration_k__BackingField; // 0x18
	
		// Properties
		private string QualifiedNativeName { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		private string Declaration { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public NativeClassAttribute(string qualifiedCppName); // 0x0000000186FB70C0-0x0000000186FB7130
		public NativeClassAttribute(string qualifiedCppName, string declaration); // 0x0000000185381AC0-0x0000000185381AF0
	}

	[VisibleToOtherModules]
	internal sealed class UnityString // TypeDefIndex: 91109
	{
		// Methods
		public static string Format(string fmt, params object[] args); // 0x0000000186145F20-0x0000000186145FA0
	}
}

namespace UnityEngine.Bindings
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[VisibleToOtherModules]
	internal class VisibleToOtherModulesAttribute : Attribute // TypeDefIndex: 91110
	{
		// Constructors
		public VisibleToOtherModulesAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public VisibleToOtherModulesAttribute(params string[] modules); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeConditionalAttribute : Attribute // TypeDefIndex: 91111
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Condition_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _StubReturnStatement_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _Enabled_k__BackingField; // 0x20
	
		// Properties
		public string Condition { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		public string StubReturnStatement { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
		public bool Enabled { [CompilerGenerated] set; } // 0x0000000182246E60-0x0000000182246E70
	
		// Constructors
		public NativeConditionalAttribute(string condition); // 0x0000000187112AB0-0x0000000187112AD0
		public NativeConditionalAttribute(string condition, string stubReturnStatement); // 0x000000018D555314-0x000000018D555344
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	[VisibleToOtherModules]
	internal class NativeHeaderAttribute : Attribute // TypeDefIndex: 91112
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Header_k__BackingField; // 0x10
	
		// Properties
		public string Header { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public NativeHeaderAttribute(string header); // 0x000000018696AFF0-0x000000018696B060
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class NativeNameAttribute : Attribute // TypeDefIndex: 91113
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Name_k__BackingField; // 0x10
	
		// Properties
		public string Name { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public NativeNameAttribute(string name); // 0x00000001869A0580-0x00000001869A05F0
	}

	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal sealed class NativeWritableSelfAttribute : Attribute // TypeDefIndex: 91114
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _WritableSelf_k__BackingField; // 0x10
	
		// Properties
		public bool WritableSelf { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public NativeWritableSelfAttribute(); // 0x00000001829D07F0-0x00000001829D0800
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeMethodAttribute : Attribute // TypeDefIndex: 91115
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _IsThreadSafe_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _IsFreeFunction_k__BackingField; // 0x19
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _ThrowsException_k__BackingField; // 0x1A
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _HasExplicitThis_k__BackingField; // 0x1B
	
		// Properties
		public string Name { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		public bool IsThreadSafe { [CompilerGenerated] set; } // 0x000000018225E060-0x000000018225E070
		public bool IsFreeFunction { [CompilerGenerated] set; } // 0x000000018225E020-0x000000018225E030
		public bool ThrowsException { [CompilerGenerated] set; } // 0x000000018226EDD0-0x000000018226EDE0
		public bool HasExplicitThis { [CompilerGenerated] set; } // 0x00000001872364D0-0x00000001872364E0
	
		// Constructors
		public NativeMethodAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public NativeMethodAttribute(string name); // 0x0000000185A7F1D0-0x0000000185A7F220
		public NativeMethodAttribute(string name, bool isFreeFunction); // 0x0000000185A7F1A0-0x0000000185A7F1D0
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe); // 0x0000000186585640-0x0000000186585680
	}

	[VisibleToOtherModules]
	internal enum TargetType // TypeDefIndex: 91116
	{
		Function = 0,
		Field = 1
	}

	[AttributeUsage(AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativePropertyAttribute : NativeMethodAttribute // TypeDefIndex: 91117
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnityEngine.Bindings.TargetType _TargetType_k__BackingField; // 0x20
	
		// Properties
		public UnityEngine.Bindings.TargetType TargetType { [CompilerGenerated] set; } // 0x0000000186036460-0x0000000186036470
	
		// Constructors
		public NativePropertyAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public NativePropertyAttribute(string name); // 0x000000018D555344-0x000000018D55534C
		public NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType); // 0x000000018D55534C-0x000000018D555384
		public NativePropertyAttribute(string name, bool isFree, UnityEngine.Bindings.TargetType targetType, bool isThreadSafe); // 0x000000018D555384-0x000000018D5553B8
	}

	[VisibleToOtherModules]
	internal enum CodegenOptions // TypeDefIndex: 91118
	{
		Auto = 0,
		Custom = 1,
		Force = 2
	}

	[AttributeUsage(AttributeTargets.Class)]
	[VisibleToOtherModules]
	internal class NativeAsStructAttribute : Attribute // TypeDefIndex: 91119
	{
		// Constructors
		public NativeAsStructAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
	[VisibleToOtherModules]
	internal class NativeTypeAttribute : Attribute // TypeDefIndex: 91120
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Header_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _IntermediateScriptingStructName_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private CodegenOptions _CodegenOptions_k__BackingField; // 0x20
	
		// Properties
		public string Header { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		public string IntermediateScriptingStructName { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
		public CodegenOptions CodegenOptions { [CompilerGenerated] set; } // 0x0000000186036460-0x0000000186036470
	
		// Constructors
		public NativeTypeAttribute(); // 0x00000001872327A0-0x00000001872327B0
		public NativeTypeAttribute(CodegenOptions codegenOptions); // 0x0000000186036460-0x0000000186036470
		public NativeTypeAttribute(string header); // 0x0000000187182210-0x0000000187182280
		public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName); // 0x0000000187231380-0x0000000187231390
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	[VisibleToOtherModules]
	internal class NotNullAttribute : Attribute // TypeDefIndex: 91121
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Exception_k__BackingField; // 0x10
	
		// Properties
		public string Exception { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public NotNullAttribute(string exception = "ArgumentNullException" /* Metadata: 0x0264B39B */); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Parameter)]
	[VisibleToOtherModules]
	internal class UnmarshalledAttribute : Attribute // TypeDefIndex: 91122
	{
		// Constructors
		public UnmarshalledAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal class FreeFunctionAttribute : NativeMethodAttribute // TypeDefIndex: 91123
	{
		// Constructors
		public FreeFunctionAttribute(); // 0x00000001872411B0-0x00000001872411C0
		public FreeFunctionAttribute(string name); // 0x0000000185A7F220-0x0000000185A7F240
		public FreeFunctionAttribute(string name, bool isThreadSafe); // 0x0000000186585620-0x0000000186585640
	}

	[AttributeUsage(AttributeTargets.Method)]
	[VisibleToOtherModules]
	internal class ThreadSafeAttribute : NativeMethodAttribute // TypeDefIndex: 91124
	{
		// Constructors
		public ThreadSafeAttribute(); // 0x0000000187233970-0x0000000187233980
	}

	[VisibleToOtherModules]
	internal enum StaticAccessorType // TypeDefIndex: 91125
	{
		Dot = 0,
		Arrow = 1,
		DoubleColon = 2,
		ArrowWithDefaultReturnIfNull = 3
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class StaticAccessorAttribute : Attribute // TypeDefIndex: 91126
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private StaticAccessorType _Type_k__BackingField; // 0x18
	
		// Properties
		public string Name { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		public StaticAccessorType Type { [CompilerGenerated] set; } // 0x000000018442F470-0x000000018442F480
	
		// Constructors
		[VisibleToOtherModules]
		internal StaticAccessorAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
		public StaticAccessorAttribute(string name, StaticAccessorType type); // 0x0000000186A7A360-0x0000000186A7A380
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeThrowsAttribute : Attribute // TypeDefIndex: 91127
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _ThrowsException_k__BackingField; // 0x10
	
		// Properties
		public bool ThrowsException { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public NativeThrowsAttribute(); // 0x00000001829D07F0-0x00000001829D0800
	}

	[AttributeUsage(AttributeTargets.Field)]
	[VisibleToOtherModules]
	internal class IgnoreAttribute : Attribute // TypeDefIndex: 91128
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _DoesNotContributeToSize_k__BackingField; // 0x10
	
		// Properties
		public bool DoesNotContributeToSize { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public IgnoreAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	[VisibleToOtherModules]
	internal class PreventReadOnlyInstanceModificationAttribute : Attribute // TypeDefIndex: 91129
	{
		// Constructors
		public PreventReadOnlyInstanceModificationAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace UnityEngine.Scripting
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	internal class UsedByNativeCodeAttribute : Attribute // TypeDefIndex: 91130
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Name_k__BackingField; // 0x10
	
		// Properties
		public string Name { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public UsedByNativeCodeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public UsedByNativeCodeAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	internal class RequiredByNativeCodeAttribute : Attribute // TypeDefIndex: 91131
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _Name_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _Optional_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _GenerateProxy_k__BackingField; // 0x19
	
		// Properties
		public string Name { [CompilerGenerated] set; } // 0x0000000184FD2410-0x0000000184FD2420
		public bool Optional { [CompilerGenerated] set; } // 0x000000018225E060-0x000000018225E070
		public bool GenerateProxy { [CompilerGenerated] set; } // 0x000000018225E020-0x000000018225E030
	
		// Constructors
		public RequiredByNativeCodeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
		public RequiredByNativeCodeAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}
}
