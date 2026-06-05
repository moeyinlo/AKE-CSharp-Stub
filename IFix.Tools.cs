/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using IFix.Core;

// Image 99: IFix.Tools.dll - Assembly: IFix.Tools, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60586-60593

namespace IFix
{
	public class IFixMethodPrinter // TypeDefIndex: 60593
	{
		// Fields
		private System.Reflection.FieldInfo unmanagedCodesField; // 0x10
		private PropertyInfo exceptionHandlersProperty; // 0x18
		private PropertyInfo externMethodsProperty; // 0x20
	
		// Nested types
		private class WrapperArrayCandidate // TypeDefIndex: 60587
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
			public WrapperArrayCandidate() {} // 0x000000018A9B0F30-0x000000018A9B0FB0
	
			// Methods
			public object GetValue(int index) => default; // 0x000000018A9B1700-0x000000018A9B1854
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 60588
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<KeyValuePair<int, string>, int> __9__7_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018A9B0FB0-0x000000018A9B12EC
			public __c() {} // 0x000000018A9AF4D0-0x000000018A9AF524
	
			// Methods
			internal int _GetAllIFixMethodStrs_b__7_0(KeyValuePair<int, string> k) => default; // 0x000000018A9AFA58-0x000000018A9B0EB0
		}
	
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 60589
		{
			// Fields
			public Array arr; // 0x10
	
			// Constructors
			public __c__DisplayClass17_0() {} // 0x000000018A9AEA84-0x000000018A9AEDF0
	
			// Methods
			internal object _TryGetWrapperArrayDirect_b__0(int i) => default; // 0x000000018A9ACD44-0x000000018A9AD0B4
		}
	
		private sealed class __c__DisplayClass26_0 // TypeDefIndex: 60590
		{
			// Fields
			public Array arr; // 0x10
			public IList listValue; // 0x18
	
			// Constructors
			public __c__DisplayClass26_0() {} // 0x000000018A9AF524-0x000000018A9AF7A4
	
			// Methods
			internal object _AddWrapperCandidate_b__0(int i) => default; // 0x000000018A9AC3E0-0x000000018A9AC5BC
			internal object _AddWrapperCandidate_b__1(int i) => default; // 0x000000018A9AD0B4-0x000000018A9AD23C
		}
	
		private sealed class _GetAllFieldsIncludingBase_d__29 : IEnumerable<System.Reflection.FieldInfo>, IEnumerator<System.Reflection.FieldInfo> // TypeDefIndex: 60591
		{
			// Fields
			private int __1__state; // 0x10
			private System.Reflection.FieldInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type type; // 0x28
			public System.Type __3__type; // 0x30
			private System.Reflection.BindingFlags flags; // 0x38
			public System.Reflection.BindingFlags __3__flags; // 0x3C
			private System.Type _t_5__2; // 0x40
			private System.Reflection.FieldInfo[] __7__wrap2; // 0x48
			private int __7__wrap3; // 0x50
	
			// Properties
			System.Reflection.FieldInfo IEnumerator<System.Reflection.FieldInfo>.Current { get => default; } // 0x000000018A9B1D2C-0x000000018A9B1EF8 
			object IEnumerator.Current { get => default; } // 0x000000018A9B2968-0x000000018A9B2E68 
	
			// Constructors
			public _GetAllFieldsIncludingBase_d__29() {} // Dummy constructor
			public _GetAllFieldsIncludingBase_d__29(int __1__state) {} // 0x000000018A9B1854-0x000000018A9B1A10
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A9AD6B8-0x000000018A9AE27C
			private bool MoveNext() => default; // 0x000000018A9AD23C-0x000000018A9AD6B8
			void IEnumerator.Reset() {} // 0x000000018A9B2258-0x000000018A9B25C0
			IEnumerator<System.Reflection.FieldInfo> IEnumerable<FieldInfo>.GetEnumerator() => default; // 0x000000018A9B12EC-0x000000018A9B1700
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A9B1EF8-0x000000018A9B2258
		}
	
		private sealed class _GetAllPropertiesIncludingBase_d__30 : IEnumerable<PropertyInfo>, IEnumerator<PropertyInfo> // TypeDefIndex: 60592
		{
			// Fields
			private int __1__state; // 0x10
			private PropertyInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type type; // 0x28
			public System.Type __3__type; // 0x30
			private System.Reflection.BindingFlags flags; // 0x38
			public System.Reflection.BindingFlags __3__flags; // 0x3C
			private System.Type _t_5__2; // 0x40
			private PropertyInfo[] __7__wrap2; // 0x48
			private int __7__wrap3; // 0x50
	
			// Properties
			PropertyInfo IEnumerator<System.Reflection.PropertyInfo>.Current { get => default; } // 0x000000018A9B1A10-0x000000018A9B1D2C 
			object IEnumerator.Current { get => default; } // 0x000000018A9AEDF0-0x000000018A9AF4D0 
	
			// Constructors
			public _GetAllPropertiesIncludingBase_d__30() {} // Dummy constructor
			public _GetAllPropertiesIncludingBase_d__30(int __1__state) {} // 0x000000018A9B25C0-0x000000018A9B2968
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018A9AC998-0x000000018A9ACD44
			private bool MoveNext() => default; // 0x000000018A9AF7A4-0x000000018A9AF9D8
			void IEnumerator.Reset() {} // 0x000000018A9AC5BC-0x000000018A9AC998
			IEnumerator<PropertyInfo> IEnumerable<PropertyInfo>.GetEnumerator() => default; // 0x000000018A9AE3C8-0x000000018A9AEA84
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018A9AF9D8-0x000000018A9AFA58
		}
	
		// Constructors
		public IFixMethodPrinter() {} // 0x000000018A9B3254-0x000000018A9B325C
	
		// Methods
		private void InitializeReflection() {} // 0x000000018A9B0EB0-0x000000018A9B0F30
		private int GetMethodCount(VirtualMachine vm) => default; // 0x000000018A9AE27C-0x000000018A9AE3C8
		private IFix.Core.Instruction[] GetMethodInstructions(VirtualMachine vm, int methodIndex) => default; // 0x0000000185492010-0x0000000185492020
		private unsafe int EstimateInstructionCount(IFix.Core.Instruction* codePtr) => default; // 0x000000018A9B3380-0x000000018A9B3EC0
		public string GetAllIFixMethodStrs(VirtualMachine vm) => default; // 0x0000000185492010-0x0000000185492020
		private void DumpRedirectToMappings(StringBuilder sb, WrappersManager wrappersManager) {} // 0x000000018A9B331C-0x000000018A9B3380
		private Dictionary<int, string> BuildIdMap(Assembly preferredAssembly) => default; // 0x0000000185492010-0x0000000185492020
		private void ForceLoadIdMapTypes(Dictionary<int, string> result) {} // 0x000000018A9B32A8-0x000000018A9B32DC
		private void AddIdMapFields(Dictionary<int, string> result, System.Type idMapType) {} // 0x0000000185492010-0x0000000185492020
		private string BuildMethodLabelFromIdMapField(System.Reflection.FieldInfo field) => default; // 0x000000018A9B32DC-0x000000018A9B32FC
		private bool IsNumericField(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		private List<WrapperArrayCandidate> CollectWrapperArrays(WrappersManager wrappersManager) => default; // 0x000000018A9B32DC-0x000000018A9B32FC
		private List<WrapperArrayCandidate> CollectWrapperArraysFromAssembly(Assembly asm) => default; // 0x000000018A9B32FC-0x000000018A9B331C
		private WrapperArrayCandidate SelectBestWrapperArray(List<WrapperArrayCandidate> candidates, Dictionary<int, string> idMap) => default; // 0x0000000184775050-0x0000000184775070
		private WrapperArrayCandidate TryGetWrapperArrayDirect(Assembly asm) => default; // 0x0000000185492010-0x0000000185492020
		private string TryResolveWrapperTarget(object wrapperObj) => default; // 0x000000018A9B2E68-0x000000018A9B2F98
		private string GetWrapperDebugInfo(object wrapperObj) => default; // 0x0000000181377E40-0x0000000181377E50
		private string SummarizeValue(object val) => default; // 0x000000018A9B303C-0x000000018A9B3088
		private int? TryGetWrapperMethodId(object wrapperObj) => default; // 0x0000000181377E40-0x0000000181377E50
		private void AppendILSummary(StringBuilder sb, VirtualMachine vm, int methodId, MethodBase[] externMethods) {} // 0x000000018A9B2F98-0x000000018A9B3034
		private string FormatOperand(VirtualMachine vm, IFix.Core.Instruction inst, MethodBase[] externMethods) => default; // 0x000000018A9B3034-0x000000018A9B303C
		private int ScoreWrapperCandidate(WrapperArrayCandidate candidate, int minLen) => default; // 0x0000000184775050-0x0000000184775070
		private void AddWrapperCandidate(List<WrapperArrayCandidate> list, string source, string ownerTypeName, string name, System.Type valueType, object value) {} // 0x0000000185492010-0x0000000185492020
		private void DumpWrappersManagerMembers(StringBuilder sb, WrappersManager wrappersManager) {} // 0x000000018A9B3088-0x000000018A9B31B8
		private void DumpAssemblyPotentialStores(StringBuilder sb, Assembly asm) {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerable<System.Reflection.FieldInfo> GetAllFieldsIncludingBase(System.Type type, System.Reflection.BindingFlags flags) => default; // 0x000000018A9B325C-0x000000018A9B32A8
		private IEnumerable<PropertyInfo> GetAllPropertiesIncludingBase(System.Type type, System.Reflection.BindingFlags flags) => default; // 0x0000000181377E40-0x0000000181377E50
		private string DescribeValue(object value) => default; // 0x000000018A9B31B8-0x000000018A9B3254
	}
}
