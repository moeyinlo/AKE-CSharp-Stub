/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.SubsystemsImplementation;

// Image 131: UnityEngine.SubsystemsModule.dll - Assembly: UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91212-91225

namespace UnityEngine
{
	[NativeHeader("Modules/Subsystems/Subsystem.h")]
	[UsedByNativeCode]
	public class IntegratedSubsystem // TypeDefIndex: 91213
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18
	
		// Constructors
		public IntegratedSubsystem(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		internal void SetHandle(IntegratedSubsystem subsystem); // 0x000000018D5553C4-0x000000018D555408
	}

	[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
	public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 91214
		where TSubsystemDescriptor : ISubsystemDescriptor
	{
		// Constructors
		public IntegratedSubsystem();
	}

	[UsedByNativeCode("SubsystemDescriptorBase")]
	public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 91215
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public string id { get; } // 0x000000018D5553B8-0x000000018D5553C4 
	
		// Constructors
		protected IntegratedSubsystemDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
	[UsedByNativeCode("SubsystemDescriptor")]
	public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 91216
		where TSubsystem : IntegratedSubsystem
	{
		// Constructors
		public IntegratedSubsystemDescriptor();
	}

	internal static class SubsystemDescriptorBindings // TypeDefIndex: 91217
	{
		// Methods
		public static string GetId(IntPtr descriptorPtr); // 0x000000018D555454-0x000000018D555488
	}

	public interface ISubsystemDescriptor // TypeDefIndex: 91218
	{
		// Properties
		string id { get; }
	}

	public abstract class Subsystem // TypeDefIndex: 91219
	{
		// Constructors
		protected Subsystem(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 91220
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _id_k__BackingField; // 0x10
	
		// Properties
		public string id { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		protected SubsystemDescriptor(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal static class Internal_SubsystemDescriptors // TypeDefIndex: 91221
	{
		// Methods
		[RequiredByNativeCode]
		internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor); // 0x000000018D555408-0x000000018D555454
	}

	[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemManager // TypeDefIndex: 91222
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action beforeReloadSubsystems; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action afterReloadSubsystems; // 0x08
		private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
		private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
		private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action reloadSubsytemsStarted; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action reloadSubsytemsCompleted; // 0x30
	
		// Constructors
		static SubsystemManager(); // 0x000000018D555DE8-0x000000018D555F50
	
		// Methods
		[RequiredByNativeCode]
		private static void ReloadSubsystemsStarted(); // 0x000000018D555D0C-0x000000018D555DBC
		[RequiredByNativeCode]
		private static void ReloadSubsystemsCompleted(); // 0x000000018D555C5C-0x000000018D555D0C
		[RequiredByNativeCode]
		private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem); // 0x000000018D555BC8-0x000000018D555C5C
		[RequiredByNativeCode]
		private static void ClearSubsystems(); // 0x000000018D555888-0x000000018D555A78
		private static void StaticConstructScriptingClassMap(); // 0x000000018D555DBC-0x000000018D555DE8
		internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr); // 0x000000018D555A78-0x000000018D555BC8
	}
}

namespace UnityEngine.SubsystemsImplementation
{
	[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemDescriptorStore // TypeDefIndex: 91223
	{
		// Fields
		private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x00
		private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x08
		private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10
	
		// Constructors
		static SubsystemDescriptorStore(); // 0x000000018D55572C-0x000000018D555888
	
		// Methods
		[RequiredByNativeCode]
		internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc); // 0x000000018D555610-0x000000018D555694
		[RequiredByNativeCode]
		internal static void ClearManagedDescriptors(); // 0x000000018D555488-0x000000018D555610
		private static void ReportSingleSubsystemAnalytics(string id); // 0x000000018D5556F8-0x000000018D55572C
		internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList)
			where TDescriptor : TBaseTypeInList
			where TBaseTypeInList : ISubsystemDescriptor;
		internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor); // 0x000000018D555694-0x000000018D5556F8
	}

	public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 91224
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _id_k__BackingField; // 0x10
	
		// Properties
		public string id { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		protected SubsystemDescriptorWithProvider(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class SubsystemWithProvider // TypeDefIndex: 91225
	{
		// Constructors
		protected SubsystemWithProvider(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
