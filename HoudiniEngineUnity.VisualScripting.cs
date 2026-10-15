/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;

// Image 150: HoudiniEngineUnity.VisualScripting.dll - Assembly: HoudiniEngineUnity.VisualScripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91352-91358

namespace HoudiniEngineUnity
{
	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Instantiate HDA")]
	[UnitTitle("Houdini Engine Instantiate HDA")]
	public class HEU_InstantiateHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 91354
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
		protected override string hookName { get; } // 0x000000018C19B9B8-0x000000018C19B9E4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 91353
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_InstantiateHDA __4__this; // 0x18
			public Action ContinueFlow; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _TriggerButton_b__0(); // 0x000000018C19BD30-0x000000018C19BD80
			internal void _TriggerButton_b__1(HEU_ReloadEventData data); // 0x000000018C19BD80-0x000000018C19BDB8
		}
	
		// Constructors
		public HEU_InstantiateHDA(); // 0x000000018C19B97C-0x000000018C19B9B8
	
		// Methods
		protected override void Definition(); // 0x000000018C19B2AC-0x000000018C19B588
		public void TriggerButton(GraphReference reference); // 0x000000018C19B588-0x000000018C19B97C
		[CompilerGenerated]
		private HEU_HoudiniAssetRoot _Definition_b__12_0(Flow flow); // 0x0000000187232C80-0x0000000187232C90
		[CompilerGenerated]
		private HEU_HoudiniAsset _Definition_b__12_1(Flow flow); // 0x0000000187236200-0x0000000187236210
		[CompilerGenerated]
		private bool _Definition_b__12_2(Flow flow); // 0x000000018723B680-0x000000018723B690
	}

	[UnitCategory("Events/Editor/Houdini Engine")]
	[UnitShortTitle("Modify HDA")]
	[UnitTitle("Houdini Engine Modify HDA")]
	public class HEU_ModifyHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 91356
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
		protected override string hookName { get; } // 0x000000018C19BCD4-0x000000018C19BD00 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 91355
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_ModifyHDA __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _TriggerButton_b__0(); // 0x000000018C19BDB8-0x000000018C19BE08
		}
	
		// Constructors
		public HEU_ModifyHDA(); // 0x000000018C19BC98-0x000000018C19BCD4
	
		// Methods
		protected override void Definition(); // 0x000000018C19B9E4-0x000000018C19BAF8
		public void TriggerButton(GraphReference reference); // 0x000000018C19BAF8-0x000000018C19BC98
		[CompilerGenerated]
		private HEU_HoudiniAsset _Definition_b__6_0(Flow flow); // 0x0000000187232C70-0x0000000187232C80
	}

	[Inspectable]
	public class HEU_UnitButton // TypeDefIndex: 91357
	{
		// Fields
		public Action action; // 0x10
	
		// Constructors
		public HEU_UnitButton(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class HEU_UnitButtonAttribute : Attribute // TypeDefIndex: 91358
	{
		// Fields
		public string functionName; // 0x10
		public string buttonLabel; // 0x18
		public int buttonWidth; // 0x20
	
		// Constructors
		public HEU_UnitButtonAttribute(string fnName, string btnLabel, int btnWidth); // 0x000000018C19BD00-0x000000018C19BD30
	}
}
