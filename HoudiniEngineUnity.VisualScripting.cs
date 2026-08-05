/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

// Image 147: HoudiniEngineUnity.VisualScripting.dll - Assembly: HoudiniEngineUnity.VisualScripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63861-63867
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace HoudiniEngineUnity
{
	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Instantiate HDA")]
	[UnitTitle("Houdini Engine Instantiate HDA")]
	public class HEU_InstantiateHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 63863
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
		protected override string hookName { get; } // 0x0000000189D551A0-0x0000000189D551CC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 63862
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_InstantiateHDA __4__this; // 0x18
			public Action ContinueFlow; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _TriggerButton_b__0(); // 0x0000000189D554E8-0x0000000189D55538
			internal void _TriggerButton_b__1(HEU_ReloadEventData data); // 0x0000000189D55538-0x0000000189D55570
		}
	
		// Constructors
		public HEU_InstantiateHDA(); // 0x0000000189D55164-0x0000000189D551A0
	
		// Methods
		protected override void Definition(); // 0x0000000189D54A94-0x0000000189D54D70
		public void TriggerButton(GraphReference reference); // 0x0000000189D54D70-0x0000000189D55164
		[CompilerGenerated]
		private HEU_HoudiniAssetRoot _Definition_b__12_0(Flow flow); // 0x0000000184D85EF0-0x0000000184D85F00
		[CompilerGenerated]
		private HEU_HoudiniAsset _Definition_b__12_1(Flow flow); // 0x0000000184D892F0-0x0000000184D89300
		[CompilerGenerated]
		private bool _Definition_b__12_2(Flow flow); // 0x0000000184D8E270-0x0000000184D8E280
	}

	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Modify HDA")]
	[UnitTitle("Houdini Engine Modify HDA")]
	public class HEU_ModifyHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 63865
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
		protected override string hookName { get; } // 0x0000000189D554BC-0x0000000189D554E8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 63864
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_ModifyHDA __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _TriggerButton_b__0(); // 0x0000000189D55570-0x0000000189D555C0
		}
	
		// Constructors
		public HEU_ModifyHDA(); // 0x0000000189D55480-0x0000000189D554BC
	
		// Methods
		protected override void Definition(); // 0x0000000189D551CC-0x0000000189D552E0
		public void TriggerButton(GraphReference reference); // 0x0000000189D552E0-0x0000000189D55480
		[CompilerGenerated]
		private HEU_HoudiniAsset _Definition_b__6_0(Flow flow); // 0x0000000184D85EE0-0x0000000184D85EF0
	}

	[Inspectable]
	public class HEU_UnitButton // TypeDefIndex: 63866
	{
		// Fields
		public Action action; // 0x10
	
		// Constructors
		public HEU_UnitButton(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class HEU_UnitButtonAttribute : Attribute // TypeDefIndex: 63867
	{
		// Fields
		public string functionName; // 0x10
		public string buttonLabel; // 0x18
		public int buttonWidth; // 0x20
	
		// Constructors
		public HEU_UnitButtonAttribute(string fnName, string btnLabel, int btnWidth); // 0x00000001847E1B40-0x00000001847E1B70
	}
}
