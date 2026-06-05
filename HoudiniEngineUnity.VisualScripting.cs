/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using Unity.VisualScripting;

// Image 145: HoudiniEngineUnity.VisualScripting.dll - Assembly: HoudiniEngineUnity.VisualScripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61222-61228

namespace HoudiniEngineUnity
{
	public class HEU_InstantiateHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 61224
	{
		// Fields
		public HEU_UnitButton triggerButton; // 0x80
		public ValueInput inputPath; // 0x88
		public ValueInput inputAsync; // 0x90
		public ValueInput inputPosition; // 0x98
		public ValueOutput outputHDARoot; // 0xA0
		public ValueOutput outputHDAAsset; // 0xA8
		public ValueOutput outputSuccess; // 0xB0
		private HEU_HoudiniAssetRoot hdaRoot; // 0xB8
		private HEU_HoudiniAsset hdaAsset; // 0xC0
		private bool bSuccess; // 0xC8
	
		// Properties
		protected override string hookName { get => default; } // 0x000000018A904710-0x000000018A90474C 
	
		// Nested types
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 61223
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_InstantiateHDA __4__this; // 0x18
			public Action ContinueFlow; // 0x20
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018A90474C-0x000000018A904778
	
			// Methods
			internal void _TriggerButton_b__0() {} // 0x000000018A904040-0x000000018A90431C
			internal void _TriggerButton_b__1(HEU_ReloadEventData data) {} // 0x000000018A90431C-0x000000018A904710
		}
	
		// Constructors
		public HEU_InstantiateHDA() {} // 0x0000000185FB2DA0-0x0000000185FB2DB0
	
		// Methods
		protected override void Definition() {} // 0x000000018349D710-0x000000018349D720
		public void TriggerButton(GraphReference reference) {} // 0x0000000181B388F0-0x0000000181B38900
		private HEU_HoudiniAssetRoot _Definition_b__12_0(Flow flow) => default; // 0x0000000185492010-0x0000000185492020
		private HEU_HoudiniAsset _Definition_b__12_1(Flow flow) => default; // 0x000000018A904A94-0x000000018A904AE4
		private bool _Definition_b__12_2(Flow flow) => default; // 0x000000018A904AE4-0x000000018A904B1C
	}

	public class HEU_ModifyHDA : ManualEventUnit<EmptyEventArgs> // TypeDefIndex: 61226
	{
		// Fields
		public HEU_UnitButton triggerButton; // 0x80
		public ValueInput inputHDA; // 0x88
		public ValueOutput outputHDAAsset; // 0x90
		private HEU_HoudiniAsset hdaAsset; // 0x98
	
		// Properties
		protected override string hookName { get => default; } // 0x000000018A90488C-0x000000018A904A2C 
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 61225
		{
			// Fields
			public Flow flow; // 0x10
			public HEU_ModifyHDA __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x000000018A904A68-0x000000018A904A94
	
			// Methods
			internal void _TriggerButton_b__0() {} // 0x000000018A904778-0x000000018A90488C
		}
	
		// Constructors
		public HEU_ModifyHDA() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Definition() {} // 0x000000018A904A2C-0x000000018A904A68
		public void TriggerButton(GraphReference reference) {} // 0x0000000181E336C0-0x0000000181E336D0
		private HEU_HoudiniAsset _Definition_b__6_0(Flow flow) => default; // 0x000000018A904B1C-0x000000018A904B6C
	}

	public class HEU_UnitButton // TypeDefIndex: 61227
	{
		// Fields
		public Action action; // 0x10
	
		// Constructors
		public HEU_UnitButton() {} // 0x0000000185492010-0x0000000185492020
	}

	public class HEU_UnitButtonAttribute : Attribute // TypeDefIndex: 61228
	{
		// Fields
		public string functionName; // 0x10
		public string buttonLabel; // 0x18
		public int buttonWidth; // 0x20
	
		// Constructors
		public HEU_UnitButtonAttribute() {} // Dummy constructor
		public HEU_UnitButtonAttribute(string fnName, string btnLabel, int btnWidth) {} // 0x00000001859D9860-0x00000001859D9890
	}
}
