/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

// Image 143: HoudiniEngineUnity.VisualScripting.dll - Assembly: HoudiniEngineUnity.VisualScripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60137-60143
[assembly: CompilationRelaxations(8)]
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace HoudiniEngineUnity
{
	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Instantiate HDA")]
	[UnitTitle("Houdini Engine Instantiate HDA")]
	public class HEU_InstantiateHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 60139
	{
		// Fields
		[HEU_UnitButton("TriggerButton", "Instantiate HDA", 100)]
		[UnitHeaderInspectable]
		public HEU_UnitButton triggerButton; // 0x80
		[DoNotSerialize]
		public ValueInput inputPath; // 0x88
		[DoNotSerialize]
		public ValueInput inputAsync; // 0x90
		[DoNotSerialize]
		public ValueInput inputPosition; // 0x98
		[DoNotSerialize]
		public ValueOutput outputHDARoot; // 0xA0
		[DoNotSerialize]
		public ValueOutput outputHDAAsset; // 0xA8
		[DoNotSerialize]
		public ValueOutput outputSuccess; // 0xB0
		private HEU_HoudiniAssetRoot hdaRoot; // 0xB8
		private HEU_HoudiniAsset hdaAsset; // 0xC0
		private bool bSuccess; // 0xC8
	
		// Properties
		protected override string hookName { get => default; } // 0x00000001887F0BC4-0x00000001887F0BF0 
	
		// Constructors
		public HEU_InstantiateHDA() {} // 0x00000001887F0B88-0x00000001887F0BC4
	
		// Methods
		protected override void Definition() {} // 0x00000001887F04B8-0x00000001887F0794
		public void TriggerButton(GraphReference reference) {} // 0x00000001887F0794-0x00000001887F0B88
	}

	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Modify HDA")]
	[UnitTitle("Houdini Engine Modify HDA")]
	public class HEU_ModifyHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 60141
	{
		// Fields
		[HEU_UnitButton("TriggerButton", "Modify HDA", 50)]
		[UnitHeaderInspectable]
		public HEU_UnitButton triggerButton; // 0x80
		[DoNotSerialize]
		public ValueInput inputHDA; // 0x88
		[DoNotSerialize]
		public ValueOutput outputHDAAsset; // 0x90
		private HEU_HoudiniAsset hdaAsset; // 0x98
	
		// Properties
		protected override string hookName { get => default; } // 0x00000001887F0EE0-0x00000001887F0F0C 
	
		// Constructors
		public HEU_ModifyHDA() {} // 0x00000001887F0EA4-0x00000001887F0EE0
	
		// Methods
		protected override void Definition() {} // 0x00000001887F0BF0-0x00000001887F0D04
		public void TriggerButton(GraphReference reference) {} // 0x00000001887F0D04-0x00000001887F0EA4
	}

	[Inspectable]
	public class HEU_UnitButton // TypeDefIndex: 60142
	{
		// Fields
		public Action action; // 0x10
	
		// Constructors
		public HEU_UnitButton() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class HEU_UnitButtonAttribute : Attribute // TypeDefIndex: 60143
	{
		// Fields
		public string functionName; // 0x10
		public string buttonLabel; // 0x18
		public int buttonWidth; // 0x20
	
		// Constructors
		public HEU_UnitButtonAttribute() {} // Dummy constructor
		public HEU_UnitButtonAttribute(string fnName, string btnLabel, int btnWidth) {} // 0x0000000183864580-0x00000001838645B0
	}
}
