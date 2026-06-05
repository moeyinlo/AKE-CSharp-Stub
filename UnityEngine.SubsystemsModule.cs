/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SubsystemsImplementation;

// Image 129: UnityEngine.SubsystemsModule.dll - Assembly: UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61119-61132

namespace UnityEngine
{
	public class IntegratedSubsystem // TypeDefIndex: 61120
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18
	
		// Constructors
		public IntegratedSubsystem() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal void SetHandle(IntegratedSubsystem subsystem) {} // 0x000000018BF40AC8-0x000000018BF40B0C
	}

	public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 61121
		where TSubsystemDescriptor : ISubsystemDescriptor
	{
		// Constructors
		public IntegratedSubsystem() {}
	}

	public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 61122
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
	
		// Properties
		public string id { get; } // 0x000000018BF40ABC-0x000000018BF40AC8 
	
		// Constructors
		protected IntegratedSubsystemDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 61123
		where TSubsystem : IntegratedSubsystem
	{
		// Constructors
		public IntegratedSubsystemDescriptor() {}
	}

	internal static class SubsystemDescriptorBindings // TypeDefIndex: 61124
	{
		// Methods
		public static string GetId(IntPtr descriptorPtr) => default; // 0x000000018BF40B58-0x000000018BF40B8C
	}

	public interface ISubsystemDescriptor // TypeDefIndex: 61125
	{
		// Properties
		string id { get; }
	}

	public abstract class Subsystem // TypeDefIndex: 61126
	{
		// Constructors
		protected Subsystem() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class SubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 61127
	{
		// Fields
		private string _id_k__BackingField; // 0x10
	
		// Properties
		public string id { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		protected SubsystemDescriptor() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class Internal_SubsystemDescriptors // TypeDefIndex: 61128
	{
		// Methods
		internal static void Internal_AddDescriptor(SubsystemDescriptor descriptor) {} // 0x000000018BF40B0C-0x000000018BF40B58
	}

	public static class SubsystemManager // TypeDefIndex: 61129
	{
		// Fields
		private static Action beforeReloadSubsystems; // 0x00
		private static Action afterReloadSubsystems; // 0x08
		private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
		private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
		private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
		private static Action reloadSubsytemsStarted; // 0x28
		private static Action reloadSubsytemsCompleted; // 0x30
	
		// Constructors
		static SubsystemManager() {} // 0x000000018BF414B4-0x000000018BF4161C
	
		// Methods
		private static void ReloadSubsystemsStarted() {} // 0x000000018BF413D8-0x000000018BF41488
		private static void ReloadSubsystemsCompleted() {} // 0x000000018BF41328-0x000000018BF413D8
		private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) {} // 0x000000018BF41294-0x000000018BF41328
		private static void ClearSubsystems() {} // 0x000000018BF40F78-0x000000018BF41154
		private static void StaticConstructScriptingClassMap() {} // 0x000000018BF41488-0x000000018BF414B4
		internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) => default; // 0x000000018BF41154-0x000000018BF41294
	}
}

namespace UnityEngine.SubsystemsImplementation
{
	public static class SubsystemDescriptorStore // TypeDefIndex: 61130
	{
		// Fields
		private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x00
		private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x08
		private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10
	
		// Constructors
		static SubsystemDescriptorStore() {} // 0x000000018BF40E1C-0x000000018BF40F78
	
		// Methods
		internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) {} // 0x000000018BF40D00-0x000000018BF40D84
		internal static void ClearManagedDescriptors() {} // 0x000000018BF40B8C-0x000000018BF40D00
		private static void ReportSingleSubsystemAnalytics(string id) {} // 0x000000018BF40DE8-0x000000018BF40E1C
		internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList)
			where TDescriptor : TBaseTypeInList
			where TBaseTypeInList : ISubsystemDescriptor {}
		internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) {} // 0x000000018BF40D84-0x000000018BF40DE8
	}

	public abstract class SubsystemDescriptorWithProvider : ISubsystemDescriptor // TypeDefIndex: 61131
	{
		// Fields
		private string _id_k__BackingField; // 0x10
	
		// Properties
		public string id { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		protected SubsystemDescriptorWithProvider() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class SubsystemWithProvider // TypeDefIndex: 61132
	{
		// Constructors
		protected SubsystemWithProvider() {} // 0x0000000185492010-0x0000000185492020
	}
}
