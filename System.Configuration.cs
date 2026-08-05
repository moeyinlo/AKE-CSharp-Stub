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

// Image 158: System.Configuration.dll - Assembly: System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a - Types 63940-63949
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Configuration.dll")]
[assembly: AssemblyDescription("System.Configuration.dll")]
[assembly: AssemblyFileVersion("4.8.3761.0")]
[assembly: AssemblyInformationalVersion("4.8.3761.0")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Configuration.dll")]
[assembly: CLSCompliant(true)]
[assembly: ComCompatibleVersion(1, 0, 3300, 0)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: DefaultDllImportSearchPaths(DllImportSearchPath.System32 | DllImportSearchPath.AssemblyDirectory | DllImportSearchPath.LegacyBehavior)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

namespace System.Configuration
{
	[DefaultMember("Item")]
	public abstract class ConfigurationElement // TypeDefIndex: 63941
	{
		// Properties
		protected internal virtual ConfigurationPropertyCollection Properties { get; } // 0x000000018ACAF308-0x000000018ACAF338 
	
		// Methods
		protected internal virtual bool IsModified(); // 0x000000018ACAF278-0x000000018ACAF2A8
		protected internal virtual void Reset(ConfigurationElement parentElement); // 0x000000018ACAF2D8-0x000000018ACAF308
		protected internal virtual void ResetModified(); // 0x000000018ACAF2A8-0x000000018ACAF2D8
	}

	public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 63942
	{
		// Methods
		protected internal virtual void DeserializeSection(XmlReader reader); // 0x000000018ACAF338-0x000000018ACAF368
		protected internal override bool IsModified(); // 0x000000018ACAF368-0x000000018ACAF398
		protected internal override void ResetModified(); // 0x000000018ACAF398-0x000000018ACAF3C8
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode); // 0x000000018ACAF3C8-0x000000018ACAF3F8
	}

	public enum ConfigurationSaveMode // TypeDefIndex: 63943
	{
		Modified = 0,
		Minimal = 1,
		Full = 2
	}

	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection // TypeDefIndex: 63944
	{
	}

	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement // TypeDefIndex: 63945
	{
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class ConfigurationCollectionAttribute : Attribute // TypeDefIndex: 63946
	{
		// Constructors
		public ConfigurationCollectionAttribute(System.Type itemType); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ConfigurationSectionGroup // TypeDefIndex: 63947
	{
	}

	public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 63948
	{
		// Properties
		protected internal override ConfigurationPropertyCollection Properties { get; } // 0x000000018ACAF518-0x000000018ACAF548 
	
		// Constructors
		public IgnoreSection(); // 0x000000018ACAF4E8-0x000000018ACAF518
	
		// Methods
		protected internal override void DeserializeSection(XmlReader xmlReader); // 0x000000018ACAF3F8-0x000000018ACAF428
		protected internal override bool IsModified(); // 0x000000018ACAF428-0x000000018ACAF458
		protected internal override void Reset(ConfigurationElement parentSection); // 0x000000018ACAF488-0x000000018ACAF4B8
		protected internal override void ResetModified(); // 0x000000018ACAF458-0x000000018ACAF488
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode); // 0x000000018ACAF4B8-0x000000018ACAF4E8
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 63949
	{
		// Methods
		public static void ThrowNotSupportedException(); // 0x000000018ACAF548-0x000000018ACAF594
	}
}
