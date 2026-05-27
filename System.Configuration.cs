/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;

// Image 155: System.Configuration.dll - Assembly: System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 60224-60233

namespace System.Configuration
{
	[DefaultMember("Item")]
	public abstract class ConfigurationElement // TypeDefIndex: 60225
	{
		// Properties
		protected internal virtual ConfigurationPropertyCollection Properties { get; } // 0x00000001896D0E70-0x00000001896D0EA0 
	
		// Constructors
		protected ConfigurationElement() {} // Dummy constructor
	
		// Methods
		protected internal virtual bool IsModified() => default; // 0x00000001896D0DE0-0x00000001896D0E10
		protected internal virtual void Reset(ConfigurationElement parentElement) {} // 0x00000001896D0E40-0x00000001896D0E70
		protected internal virtual void ResetModified() {} // 0x00000001896D0E10-0x00000001896D0E40
	}

	public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 60226
	{
		// Constructors
		protected ConfigurationSection() {} // Dummy constructor
	
		// Methods
		protected internal virtual void DeserializeSection(XmlReader reader) {} // 0x00000001896D0EA0-0x00000001896D0ED0
		protected internal override bool IsModified() => default; // 0x00000001896D0ED0-0x00000001896D0F00
		protected internal override void ResetModified() {} // 0x00000001896D0F00-0x00000001896D0F30
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) => default; // 0x00000001896D0F30-0x00000001896D0F60
	}

	public enum ConfigurationSaveMode // TypeDefIndex: 60227
	{
		Modified = 0,
		Minimal = 1,
		Full = 2
	}

	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection // TypeDefIndex: 60228
	{
		// Constructors
		public ConfigurationPropertyCollection() {} // Dummy constructor
	}

	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 60229
	{
		// Constructors
		protected ConfigurationElementCollection() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 60230
	{
		// Constructors
		public ConfigurationCollectionAttribute() {} // Dummy constructor
		public ConfigurationCollectionAttribute(System.Type itemType) {} // 0x000000018350B670-0x000000018350B680
	}

	public class ConfigurationSectionGroup // TypeDefIndex: 60231
	{
		// Constructors
		public ConfigurationSectionGroup() {} // Dummy constructor
	}

	public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 60232
	{
		// Properties
		protected internal override ConfigurationPropertyCollection Properties { get => default; } // 0x00000001896D1080-0x00000001896D10B0 
	
		// Constructors
		public IgnoreSection() {} // 0x00000001896D1050-0x00000001896D1080
	
		// Methods
		protected internal override void DeserializeSection(XmlReader xmlReader) {} // 0x00000001896D0F60-0x00000001896D0F90
		protected internal override bool IsModified() => default; // 0x00000001896D0F90-0x00000001896D0FC0
		protected internal override void Reset(ConfigurationElement parentSection) {} // 0x00000001896D0FF0-0x00000001896D1020
		protected internal override void ResetModified() {} // 0x00000001896D0FC0-0x00000001896D0FF0
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) => default; // 0x00000001896D1020-0x00000001896D1050
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 60233
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x00000001896D10B0-0x00000001896D10FC
	}
}
