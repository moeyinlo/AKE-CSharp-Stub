/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Xml;

// Image 156: System.Configuration.dll - Assembly: System.Configuration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 61301-61310

namespace System.Configuration
{
	public abstract class ConfigurationElement // TypeDefIndex: 61302
	{
		// Properties
		protected internal virtual ConfigurationPropertyCollection Properties { get; } // 0x000000018B7F6FAC-0x000000018B7F6FDC 
	
		// Constructors
		protected ConfigurationElement() {} // Dummy constructor
	
		// Methods
		protected internal virtual bool IsModified() => default; // 0x000000018B7F6F1C-0x000000018B7F6F4C
		protected internal virtual void Reset(ConfigurationElement parentElement) {} // 0x000000018B7F6F7C-0x000000018B7F6FAC
		protected internal virtual void ResetModified() {} // 0x000000018B7F6F4C-0x000000018B7F6F7C
	}

	public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 61303
	{
		// Constructors
		protected ConfigurationSection() {} // Dummy constructor
	
		// Methods
		protected internal virtual void DeserializeSection(XmlReader reader) {} // 0x000000018B7F6FDC-0x000000018B7F700C
		protected internal override bool IsModified() => default; // 0x000000018B7F700C-0x000000018B7F703C
		protected internal override void ResetModified() {} // 0x000000018B7F703C-0x000000018B7F706C
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) => default; // 0x000000018B7F706C-0x000000018B7F709C
	}

	public enum ConfigurationSaveMode // TypeDefIndex: 61304
	{
		Modified = 0,
		Minimal = 1,
		Full = 2
	}

	public class ConfigurationPropertyCollection // TypeDefIndex: 61305
	{
		// Constructors
		public ConfigurationPropertyCollection() {} // Dummy constructor
	}

	public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 61306
	{
		// Constructors
		protected ConfigurationElementCollection() {} // Dummy constructor
	}

	public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 61307
	{
		// Constructors
		public ConfigurationCollectionAttribute() {} // Dummy constructor
		public ConfigurationCollectionAttribute(System.Type itemType) {} // 0x0000000185492010-0x0000000185492020
	}

	public class ConfigurationSectionGroup // TypeDefIndex: 61308
	{
		// Constructors
		public ConfigurationSectionGroup() {} // Dummy constructor
	}

	public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 61309
	{
		// Properties
		protected internal override ConfigurationPropertyCollection Properties { get => default; } // 0x000000018B7F71BC-0x000000018B7F71EC 
	
		// Constructors
		public IgnoreSection() {} // 0x000000018B7F718C-0x000000018B7F71BC
	
		// Methods
		protected internal override void DeserializeSection(XmlReader xmlReader) {} // 0x000000018B7F709C-0x000000018B7F70CC
		protected internal override bool IsModified() => default; // 0x000000018B7F70CC-0x000000018B7F70FC
		protected internal override void Reset(ConfigurationElement parentSection) {} // 0x000000018B7F712C-0x000000018B7F715C
		protected internal override void ResetModified() {} // 0x000000018B7F70FC-0x000000018B7F712C
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) => default; // 0x000000018B7F715C-0x000000018B7F718C
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 61310
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x000000018B7F71EC-0x000000018B7F7238
	}
}
