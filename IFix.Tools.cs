/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 96: IFix.Tools.dll - Assembly: IFix.Tools, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59482-59489
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace IFix
{
	public class IFixMethodPrinter // TypeDefIndex: 59489
	{
		// Fields
		private System.Reflection.FieldInfo unmanagedCodesField; // 0x10
		private PropertyInfo exceptionHandlersProperty; // 0x18
		private PropertyInfo externMethodsProperty; // 0x20
	
		// Nested types
		private class WrapperArrayCandidate // TypeDefIndex: 59483
		{
			// Fields
			public string Source; // 0x10
			public string OwnerTypeName; // 0x18
			public string FieldName; // 0x20
			public string ElementTypeName; // 0x28
			public int Length; // 0x30
			public int NonNullCount; // 0x34
			public Func<int, object> Getter; // 0x38
	
			// Constructors
			public WrapperArrayCandidate() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public object GetValue(int index) => default; // 0x00000001888A1484-0x00000001888A1FC4
		}
	
		// Constructors
		public IFixMethodPrinter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void InitializeReflection() {} // 0x000000018889F804-0x000000018889F958
		private int GetMethodCount(VirtualMachine vm) => default; // 0x000000018889F034-0x000000018889F0B4
		private IFix.Core.Instruction[] GetMethodInstructions(VirtualMachine vm, int methodIndex) => default; // 0x000000018889F0B4-0x000000018889F3F0
		private unsafe int EstimateInstructionCount(IFix.Core.Instruction* codePtr) => default; // 0x000000018889D5D4-0x000000018889D628
		public string GetAllIFixMethodStrs(VirtualMachine vm) => default; // 0x000000018889DB5C-0x000000018889EFB4
		private void DumpRedirectToMappings(StringBuilder sb, WrappersManager wrappersManager) {} // 0x000000018889CB88-0x000000018889CEF4
		private Dictionary<int, string> BuildIdMap(Assembly preferredAssembly) => default; // 0x000000018889AE48-0x000000018889B1B8
		private void ForceLoadIdMapTypes(Dictionary<int, string> result) {} // 0x000000018889D628-0x000000018889D8A8
		private void AddIdMapFields(Dictionary<int, string> result, System.Type idMapType) {} // 0x000000018889A4E4-0x000000018889A6C0
		private string BuildMethodLabelFromIdMapField(System.Reflection.FieldInfo field) => default; // 0x000000018889B1B8-0x000000018889B340
		private bool IsNumericField(System.Type type) => default; // 0x000000018889F958-0x000000018889FB14
		private List<WrapperArrayCandidate> CollectWrapperArrays(WrappersManager wrappersManager) => default; // 0x000000018889B7BC-0x000000018889C380
		private List<WrapperArrayCandidate> CollectWrapperArraysFromAssembly(Assembly asm) => default; // 0x000000018889B340-0x000000018889B7BC
		private WrapperArrayCandidate SelectBestWrapperArray(List<WrapperArrayCandidate> candidates, Dictionary<int, string> idMap) => default; // 0x000000018889FE30-0x000000018889FFFC
		private WrapperArrayCandidate TryGetWrapperArrayDirect(Assembly asm) => default; // 0x00000001888A035C-0x00000001888A06C4
		private string TryResolveWrapperTarget(object wrapperObj) => default; // 0x00000001888A0A6C-0x00000001888A0F6C
		private string GetWrapperDebugInfo(object wrapperObj) => default; // 0x000000018889F3F0-0x000000018889F804
		private string SummarizeValue(object val) => default; // 0x000000018889FFFC-0x00000001888A035C
		private int? TryGetWrapperMethodId(object wrapperObj) => default; // 0x00000001888A06C4-0x00000001888A0A6C
		private void AppendILSummary(StringBuilder sb, VirtualMachine vm, int methodId, MethodBase[] externMethods) {} // 0x000000018889AA9C-0x000000018889AE48
		private string FormatOperand(VirtualMachine vm, IFix.Core.Instruction inst, MethodBase[] externMethods) => default; // 0x000000018889D8A8-0x000000018889DADC
		private int ScoreWrapperCandidate(WrapperArrayCandidate candidate, int minLen) => default; // 0x000000018889FB14-0x000000018889FE30
		private void AddWrapperCandidate(List<WrapperArrayCandidate> list, string source, string ownerTypeName, string name, System.Type valueType, object value) {} // 0x000000018889A6C0-0x000000018889AA9C
		private void DumpWrappersManagerMembers(StringBuilder sb, WrappersManager wrappersManager) {} // 0x000000018889CEF4-0x000000018889D5D4
		private void DumpAssemblyPotentialStores(StringBuilder sb, Assembly asm) {} // 0x000000018889C4CC-0x000000018889CB88
		[IteratorStateMachine(typeof(_GetAllFieldsIncludingBase_d__29))]
		private IEnumerable<System.Reflection.FieldInfo> GetAllFieldsIncludingBase(System.Type type, System.Reflection.BindingFlags flags) => default; // 0x000000018889DADC-0x000000018889DB5C
		[IteratorStateMachine(typeof(_GetAllPropertiesIncludingBase_d__30))]
		private IEnumerable<PropertyInfo> GetAllPropertiesIncludingBase(System.Type type, System.Reflection.BindingFlags flags) => default; // 0x000000018889EFB4-0x000000018889F034
		private string DescribeValue(object value) => default; // 0x000000018889C380-0x000000018889C4CC
	}
}
