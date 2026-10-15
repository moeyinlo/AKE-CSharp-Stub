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

// Image 159: System.Configuration.dll - Assembly: System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 91423-91432

namespace System.Configuration
{
	[DefaultMember("Item")]
	public abstract class ConfigurationElement // TypeDefIndex: 91424
	{
		// Properties
		protected internal virtual ConfigurationPropertyCollection Properties { get; } // 0x000000018CE853B4-0x000000018CE853E4 
	
		// Methods
		protected internal virtual bool IsModified(); // 0x000000018CE85324-0x000000018CE85354
		protected internal virtual void Reset(ConfigurationElement parentElement); // 0x000000018CE85384-0x000000018CE853B4
		protected internal virtual void ResetModified(); // 0x000000018CE85354-0x000000018CE85384
	}

	public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 91425
	{
		// Methods
		protected internal virtual void DeserializeSection(XmlReader reader); // 0x000000018CE853E4-0x000000018CE85414
		protected internal override bool IsModified(); // 0x000000018CE85414-0x000000018CE85444
		protected internal override void ResetModified(); // 0x000000018CE85444-0x000000018CE85474
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode); // 0x000000018CE85474-0x000000018CE854A4
	}

	public enum ConfigurationSaveMode // TypeDefIndex: 91426
	{
		Modified = 0,
		Minimal = 1,
		Full = 2
	}

	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection // TypeDefIndex: 91427
	{
	}

	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 91428
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 91429
	{
		// Constructors
		public ConfigurationCollectionAttribute(System.Type itemType); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ConfigurationSectionGroup // TypeDefIndex: 91430
	{
	}

	public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 91431
	{
		// Properties
		protected internal override ConfigurationPropertyCollection Properties { get; } // 0x000000018CE855C4-0x000000018CE855F4 
	
		// Constructors
		public IgnoreSection(); // 0x000000018CE85594-0x000000018CE855C4
	
		// Methods
		protected internal override void DeserializeSection(XmlReader xmlReader); // 0x000000018CE854A4-0x000000018CE854D4
		protected internal override bool IsModified(); // 0x000000018CE854D4-0x000000018CE85504
		protected internal override void Reset(ConfigurationElement parentSection); // 0x000000018CE85534-0x000000018CE85564
		protected internal override void ResetModified(); // 0x000000018CE85504-0x000000018CE85534
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode); // 0x000000018CE85564-0x000000018CE85594
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 91432
	{
		// Methods
		public static void ThrowNotSupportedException(); // 0x000000018CE855F4-0x000000018CE85640
	}
}
