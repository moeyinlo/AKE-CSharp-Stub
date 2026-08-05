/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

// Image 86: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 62721-62758
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Xml.Linq.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Xml.Linq.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../winfx.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Xml.Linq.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

internal static class SR // TypeDefIndex: 62722
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018AE476F8-0x000000018AE47754
	internal static string Format(string resourceFormat, object p1, object p2); // 0x000000018AE47688-0x000000018AE476F8
}

namespace System.Text
{
	internal static class StringBuilderCache // TypeDefIndex: 62757
	{
		// Fields
		[ThreadStatic]
		private static StringBuilder t_cachedInstance; // 0x80000000
	
		// Methods
		public static StringBuilder Acquire(int capacity = 16 /* Metadata: 0x0235218E */); // 0x000000018AE47754-0x000000018AE4782C
		public static void Release(StringBuilder sb); // 0x000000018AE47870-0x000000018AE478E8
		public static string GetStringAndRelease(StringBuilder sb); // 0x000000018AE4782C-0x000000018AE47870
	}
}

namespace System.Xml.Linq
{
	internal class BaseUriAnnotation // TypeDefIndex: 62723
	{
		// Fields
		internal string baseUri; // 0x10
	
		// Constructors
		public BaseUriAnnotation(string baseUri); // 0x00000001853908C0-0x00000001853908D0
	}

	internal class LineInfoAnnotation // TypeDefIndex: 62724
	{
		// Fields
		internal int lineNumber; // 0x10
		internal int linePosition; // 0x14
	
		// Constructors
		public LineInfoAnnotation(int lineNumber, int linePosition); // 0x0000000184D88290-0x0000000184D882A0
	}

	internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 62725
	{
		// Constructors
		public LineInfoEndElementAnnotation(int lineNumber, int linePosition); // 0x0000000184D88290-0x0000000184D882A0
	}

	public class XAttribute : XObject // TypeDefIndex: 62726
	{
		// Fields
		internal XAttribute next; // 0x20
		internal XName name; // 0x28
		internal string value; // 0x30
	
		// Properties
		public bool IsNamespaceDeclaration { get; } // 0x000000018AE48574-0x000000018AE485F8 
		public XName Name { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override XmlNodeType NodeType { get; } // 0x0000000182BBE540-0x0000000182BBE550 
		public string Value { get; } // 0x00000001811F36E0-0x00000001811F36F0 
	
		// Constructors
		public XAttribute(XName name, object value); // 0x000000018AE483DC-0x000000018AE484E8
		public XAttribute(XAttribute other); // 0x000000018AE484E8-0x000000018AE48574
	
		// Methods
		public override string ToString(); // 0x000000018AE47D88-0x000000018AE48018
		internal string GetPrefixOfNamespace(XNamespace ns); // 0x000000018AE47C74-0x000000018AE47D88
		private static void ValidateAttribute(XName name, string value); // 0x000000018AE48018-0x000000018AE483DC
	}

	public class XCData : XText // TypeDefIndex: 62727
	{
		// Properties
		public override XmlNodeType NodeType { get; } // 0x0000000184D882B0-0x0000000184D882C0 
	
		// Constructors
		public XCData(string value); // 0x000000018AE486D0-0x000000018AE486D8
		public XCData(XCData other); // 0x000000018AE486D8-0x000000018AE486E0
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE48658-0x000000018AE486D0
		internal override XNode CloneNode(); // 0x000000018AE485F8-0x000000018AE48658
	}

	public class XComment : XNode // TypeDefIndex: 62728
	{
		// Fields
		internal string value; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get; } // 0x0000000184D8D060-0x0000000184D8D070 
		public string Value { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public XComment(string value); // 0x000000018AE48830-0x000000018AE488A4
		public XComment(XComment other); // 0x000000018AE487B8-0x000000018AE48830
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE48740-0x000000018AE487B8
		internal override XNode CloneNode(); // 0x000000018AE486E0-0x000000018AE48740
	}

	public abstract class XContainer : XNode // TypeDefIndex: 62731
	{
		// Fields
		internal object content; // 0x28
	
		// Properties
		public XNode LastNode { get; } // 0x000000018AE49F10-0x000000018AE4A00C 
	
		// Nested types
		private sealed class ContentReader // TypeDefIndex: 62729
		{
			// Fields
			private readonly NamespaceCache _eCache; // 0x10
			private readonly NamespaceCache _aCache; // 0x20
			private readonly IXmlLineInfo _lineInfo; // 0x30
			private XContainer _currentContainer; // 0x38
			private string _baseUri; // 0x40
	
			// Constructors
			public ContentReader(XContainer rootContainer); // 0x00000001846A91B0-0x00000001846A91C0
			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o); // 0x000000018AE46C14-0x000000018AE46CD4
	
			// Methods
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r); // 0x000000018AE46604-0x000000018AE46C14
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o); // 0x000000018AE45DA0-0x000000018AE46604
		}
	
		[CompilerGenerated]
		private sealed class _Nodes_d__18 : IEnumerable<XNode>, IEnumerator<XNode> // TypeDefIndex: 62730
		{
			// Fields
			private int __1__state; // 0x10
			private XNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public XContainer __4__this; // 0x28
			private XNode _n_5__2; // 0x30
	
			// Properties
			XNode IEnumerator<System.Xml.Linq.XNode>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Nodes_d__18(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AE47AEC-0x000000018AE47B94
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AE47C28-0x000000018AE47C74
			[DebuggerHidden]
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator(); // 0x000000018AE47B94-0x000000018AE47C20
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AE47C20-0x000000018AE47C28
		}
	
		// Constructors
		internal XContainer(); // 0x00000001841E1670-0x00000001841E1680
		internal XContainer(XContainer other); // 0x000000018AE49E0C-0x000000018AE49F10
	
		// Methods
		public void Add(object content); // 0x000000018AE48F94-0x000000018AE4929C
		[IteratorStateMachine(typeof(_Nodes_d__18))]
		public IEnumerable<XNode> Nodes(); // 0x000000018AE498FC-0x000000018AE4996C
		internal virtual void AddAttribute(XAttribute a); // 0x00000001841E1670-0x00000001841E1680
		internal virtual void AddAttributeSkipNotify(XAttribute a); // 0x00000001841E1670-0x00000001841E1680
		internal void AddContentSkipNotify(object content); // 0x000000018AE488A4-0x000000018AE48B6C
		internal void AddNode(XNode n); // 0x000000018AE48BE4-0x000000018AE48C5C
		internal void AddNodeSkipNotify(XNode n); // 0x000000018AE48B6C-0x000000018AE48BE4
		internal void AddString(string s); // 0x000000018AE48D8C-0x000000018AE48F94
		internal void AddStringSkipNotify(string s); // 0x000000018AE48C5C-0x000000018AE48D8C
		internal void AppendNode(XNode n); // 0x000000018AE49358-0x000000018AE4946C
		internal void AppendNodeSkipNotify(XNode n); // 0x000000018AE4929C-0x000000018AE49358
		internal override void AppendText(StringBuilder sb); // 0x000000018AE4946C-0x000000018AE49520
		internal void ConvertTextToNode(); // 0x000000018AE49520-0x000000018AE495D4
		internal static string GetStringValue(object value); // 0x000000018AE495D4-0x000000018AE498FC
		internal void ReadContentFrom(XmlReader r); // 0x000000018AE4996C-0x000000018AE49A68
		internal void ReadContentFrom(XmlReader r, LoadOptions o); // 0x000000018AE49A68-0x000000018AE49B9C
		internal void RemoveNode(XNode n); // 0x000000018AE49B9C-0x000000018AE49D28
		internal virtual void ValidateNode(XNode node, XNode previous); // 0x00000001841E1670-0x00000001841E1680
		internal virtual void ValidateString(string s); // 0x00000001841E1670-0x00000001841E1680
		internal void WriteContentTo(XmlWriter writer); // 0x000000018AE49D28-0x000000018AE49E0C
	}

	public class XDeclaration // TypeDefIndex: 62732
	{
		// Fields
		private string _version; // 0x10
		private string _encoding; // 0x18
		private string _standalone; // 0x20
	
		// Properties
		public string Encoding { get; } // 0x000000018385B100-0x000000018385B110 
		public string Standalone { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public string Version { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public XDeclaration(string version, string encoding, string standalone); // 0x00000001831D14F0-0x00000001831D1530
		public XDeclaration(XDeclaration other); // 0x000000018AE4A160-0x000000018AE4A200
	
		// Methods
		public override string ToString(); // 0x000000018AE4A00C-0x000000018AE4A160
	}

	public class XDocument : XContainer // TypeDefIndex: 62733
	{
		// Fields
		private XDeclaration _declaration; // 0x30
	
		// Properties
		public XDeclaration Declaration { get; set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public override XmlNodeType NodeType { get; } // 0x0000000184DA4FC0-0x0000000184DA4FD0 
		public XElement Root { get; } // 0x000000018AE4AAD8-0x000000018AE4AB14 
	
		// Constructors
		public XDocument(); // 0x00000001841E1670-0x00000001841E1680
		public XDocument(XDocument other); // 0x000000018AE4AA44-0x000000018AE4AAD8
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE4A920-0x000000018AE4AA44
		internal override void AddAttribute(XAttribute a); // 0x000000018AE4A498-0x000000018AE4A4F4
		internal override void AddAttributeSkipNotify(XAttribute a); // 0x000000018AE4A43C-0x000000018AE4A498
		internal override XNode CloneNode(); // 0x000000018AE4A4F4-0x000000018AE4A554
		private T GetFirstNode<T>()
			where T : XNode;
		internal static bool IsWhitespace(string s); // 0x000000018AE4A554-0x000000018AE4A5AC
		internal override void ValidateNode(XNode node, XNode previous); // 0x000000018AE4A6B0-0x000000018AE4A8B0
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter); // 0x000000018AE4A5AC-0x000000018AE4A6B0
		internal override void ValidateString(string s); // 0x000000018AE4A8B0-0x000000018AE4A920
	}

	public class XDocumentType : XNode // TypeDefIndex: 62734
	{
		// Fields
		private string _name; // 0x28
		private string _publicId; // 0x30
		private string _systemId; // 0x38
		private string _internalSubset; // 0x40
	
		// Properties
		public string InternalSubset { get; } // 0x0000000184D85A60-0x0000000184D85A70 
		public string Name { get; } // 0x0000000184D86240-0x0000000184D86250 
		public override XmlNodeType NodeType { get; } // 0x0000000184DA5360-0x0000000184DA5370 
		public string PublicId { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public string SystemId { get; } // 0x0000000184D85A50-0x0000000184D85A60 
	
		// Constructors
		public XDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x000000018AE4A39C-0x000000018AE4A43C
		public XDocumentType(XDocumentType other); // 0x000000018AE4A2EC-0x000000018AE4A39C
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE4A260-0x000000018AE4A2EC
		internal override XNode CloneNode(); // 0x000000018AE4A200-0x000000018AE4A260
	}

	[XmlSchemaProvider(null, IsAny = true)]
	[XmlTypeConvertor("ConvertForAssignment")]
	public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 62736
	{
		// Fields
		internal XName name; // 0x30
		internal XAttribute lastAttr; // 0x38
	
		// Properties
		public bool HasAttributes { get; } // 0x0000000189B0008C-0x0000000189B00098 
		public bool IsEmpty { get; } // 0x000000018AE4BBDC-0x000000018AE4BBE8 
		public XName Name { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public override XmlNodeType NodeType { get; } // 0x0000000184D85B80-0x0000000184D85B90 
		public string Value { get; } // 0x000000018AE4BBE8-0x000000018AE4BC70 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAttributes_d__116 : IEnumerable<XAttribute>, IEnumerator<XAttribute> // TypeDefIndex: 62735
		{
			// Fields
			private int __1__state; // 0x10
			private XAttribute __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public XElement __4__this; // 0x28
			private XName name; // 0x30
			public XName __3__name; // 0x38
			private XAttribute _a_5__2; // 0x40
	
			// Properties
			XAttribute IEnumerator<System.Xml.Linq.XAttribute>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _GetAttributes_d__116(int __1__state); // 0x0000000183A11010-0x0000000183A11030
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018AE47934-0x000000018AE479F4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018AE47AA0-0x000000018AE47AEC
			[DebuggerHidden]
			IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator(); // 0x000000018AE479F4-0x000000018AE47A98
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018AE47A98-0x000000018AE47AA0
		}
	
		// Constructors
		public XElement(XName name); // 0x000000018AE4BB68-0x000000018AE4BBDC
		public XElement(XElement other); // 0x000000018AE4BA1C-0x000000018AE4BADC
		public XElement(XStreamingElement other); // 0x000000018AE4BADC-0x000000018AE4BB68
	
		// Methods
		public XAttribute Attribute(XName name); // 0x000000018AE4AE70-0x000000018AE4AEA4
		public IEnumerable<XAttribute> Attributes(); // 0x000000018AE4AEA4-0x000000018AE4AEB0
		public string GetPrefixOfNamespace(XNamespace ns); // 0x000000018AE4B058-0x000000018AE4B260
		public override void WriteTo(XmlWriter writer); // 0x000000018AE4B974-0x000000018AE4BA1C
		XmlSchema IXmlSerializable.GetSchema(); // 0x00000001811EC580-0x00000001811EC590
		void IXmlSerializable.ReadXml(XmlReader reader); // 0x000000018AE4B60C-0x000000018AE4B7E0
		void IXmlSerializable.WriteXml(XmlWriter writer); // 0x000000018AE4B7E0-0x000000018AE4B7F4
		internal override void AddAttribute(XAttribute a); // 0x000000018AE4AC00-0x000000018AE4ACEC
		internal override void AddAttributeSkipNotify(XAttribute a); // 0x000000018AE4AB14-0x000000018AE4AC00
		internal void AppendAttribute(XAttribute a); // 0x000000018AE4AD5C-0x000000018AE4AE70
		internal void AppendAttributeSkipNotify(XAttribute a); // 0x000000018AE4ACEC-0x000000018AE4AD5C
		internal override XNode CloneNode(); // 0x000000018AE4AEB0-0x000000018AE4AF10
		[IteratorStateMachine(typeof(_GetAttributes_d__116))]
		private IEnumerable<XAttribute> GetAttributes(XName name); // 0x000000018AE4AF10-0x000000018AE4AF98
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope); // 0x000000018AE4AF98-0x000000018AE4B058
		private void ReadElementFrom(XmlReader r, LoadOptions o); // 0x000000018AE4B524-0x000000018AE4B59C
		private void ReadElementFromImpl(XmlReader r, LoadOptions o); // 0x000000018AE4B260-0x000000018AE4B524
		internal void SetEndElementLineInfo(int lineNumber, int linePosition); // 0x000000018AE4B59C-0x000000018AE4B60C
		internal override void ValidateNode(XNode node, XNode previous); // 0x000000018AE4B7F4-0x000000018AE4B974
	}

	internal sealed class XHashtable<TValue> // TypeDefIndex: 62740
	{
		// Fields
		private XHashtableState _state;
	
		// Nested types
		public delegate string ExtractKeyDelegate(TValue value); // TypeDefIndex: 62737; 0x00000000-0x00000000
	
		private sealed class XHashtableState // TypeDefIndex: 62739
		{
			// Fields
			private int[] _buckets;
			private Entry[] _entries;
			private int _numEntries;
			private ExtractKeyDelegate<TValue> _extractKey;
	
			// Nested types
			private struct Entry // TypeDefIndex: 62738
			{
				// Fields
				public TValue Value;
				public int HashCode;
				public int Next;
			}
	
			// Constructors
			public XHashtableState(ExtractKeyDelegate<TValue> extractKey, int capacity);
	
			// Methods
			public XHashtableState<TValue> Resize();
			public bool TryGetValue(string key, int index, int count, out ref TValue value);
			public bool TryAdd(TValue value, out ref TValue newValue);
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex);
			private static int ComputeHashCode(string key, int index, int count);
		}
	
		// Constructors
		public XHashtable(ExtractKeyDelegate extractKey, int capacity);
	
		// Methods
		public bool TryGetValue(string key, int index, int count, out ref TValue value);
		public TValue Add(TValue value);
	}

	internal struct NamespaceCache // TypeDefIndex: 62741
	{
		// Fields
		private XNamespace _ns; // 0x00
		private string _namespaceName; // 0x08
	
		// Methods
		public XNamespace Get(string namespaceName); // 0x000000018AE47338-0x000000018AE4737C
	}

	internal struct ElementWriter // TypeDefIndex: 62742
	{
		// Fields
		private XmlWriter _writer; // 0x00
		private NamespaceResolver _resolver; // 0x08
	
		// Constructors
		public ElementWriter(XmlWriter writer); // 0x000000018AE47314-0x000000018AE47338
	
		// Methods
		public void WriteElement(XElement e); // 0x000000018AE46FB4-0x000000018AE4711C
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace); // 0x000000018AE46CD4-0x000000018AE46DC8
		private void PushAncestors(XElement e); // 0x000000018AE46DC8-0x000000018AE46ED0
		private void PushElement(XElement e); // 0x000000018AE46ED0-0x000000018AE46FB4
		private void WriteEndElement(); // 0x000000018AE4711C-0x000000018AE47150
		private void WriteFullEndElement(); // 0x000000018AE47150-0x000000018AE47184
		private void WriteStartElement(XElement e); // 0x000000018AE47184-0x000000018AE47314
	}

	internal struct NamespaceResolver // TypeDefIndex: 62744
	{
		// Fields
		private int _scope; // 0x00
		private NamespaceDeclaration _declaration; // 0x08
		private NamespaceDeclaration _rover; // 0x10
	
		// Nested types
		private class NamespaceDeclaration // TypeDefIndex: 62743
		{
			// Fields
			public string prefix; // 0x10
			public XNamespace ns; // 0x18
			public int scope; // 0x20
			public NamespaceDeclaration prev; // 0x28
	
			// Constructors
			public NamespaceDeclaration(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Methods
		public void PushScope(); // 0x0000000184DAA480-0x0000000184DAA490
		public void PopScope(); // 0x000000018AE47614-0x000000018AE47688
		public void Add(string prefix, XNamespace ns); // 0x000000018AE47454-0x000000018AE4751C
		public void AddFirst(string prefix, XNamespace ns); // 0x000000018AE4737C-0x000000018AE47454
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace); // 0x000000018AE4751C-0x000000018AE47614
	}

	public enum XObjectChange // TypeDefIndex: 62745
	{
		Add = 0,
		Remove = 1,
		Name = 2,
		Value = 3
	}

	[Flags]
	public enum LoadOptions // TypeDefIndex: 62746
	{
		None = 0,
		PreserveWhitespace = 1,
		SetBaseUri = 2,
		SetLineInfo = 4
	}

	[Flags]
	public enum SaveOptions // TypeDefIndex: 62747
	{
		None = 0,
		DisableFormatting = 1,
		OmitDuplicateNamespaces = 2
	}

	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 62748
	{
		// Fields
		private XNamespace _ns; // 0x10
		private string _localName; // 0x18
		private int _hashCode; // 0x20
	
		// Properties
		public string LocalName { get; } // 0x000000018385B100-0x000000018385B110 
		public XNamespace Namespace { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public string NamespaceName { get; } // 0x000000018AE4C010-0x000000018AE4C02C 
	
		// Constructors
		internal XName(XNamespace ns, string localName); // 0x000000018AE4BF38-0x000000018AE4BFE0
		internal XName(); // 0x000000018AE4BFE0-0x000000018AE4C010
	
		// Methods
		public override string ToString(); // 0x000000018AE4BEBC-0x000000018AE4BF38
		public static XName Get(string expandedName); // 0x000000018AE4BC70-0x000000018AE4BE3C
		public static XName Get(string localName, string namespaceName); // 0x000000018AE4BE3C-0x000000018AE4BE70
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName); // 0x000000018AE4C02C-0x000000018AE4C048
		public override bool Equals(object obj); // 0x0000000182FB1840-0x0000000182FB1850
		public override int GetHashCode(); // 0x0000000182B70F90-0x0000000182B70FA0
		public static bool operator ==(XName left, XName right); // 0x0000000182FB1840-0x0000000182FB1850
		bool IEquatable<XName>.Equals(XName other); // 0x0000000182FB1840-0x0000000182FB1850
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018AE4BE70-0x000000018AE4BEBC
	}

	public sealed class XNamespace // TypeDefIndex: 62749
	{
		// Fields
		private static XHashtable<WeakReference> s_namespaces; // 0x00
		private static WeakReference s_refNone; // 0x08
		private static WeakReference s_refXml; // 0x10
		private static WeakReference s_refXmlns; // 0x18
		private string _namespaceName; // 0x10
		private int _hashCode; // 0x18
		private XHashtable<XName> _names; // 0x20
	
		// Properties
		public string NamespaceName { get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
		public static XNamespace None { get; } // 0x000000018AE4C780-0x000000018AE4C7DC 
		public static XNamespace Xml { get; } // 0x000000018AE4C7DC-0x000000018AE4C830 
		public static XNamespace Xmlns { get; } // 0x000000018AE4C830-0x000000018AE4C884 
	
		// Constructors
		internal XNamespace(string namespaceName); // 0x000000018AE4C68C-0x000000018AE4C780
	
		// Methods
		public XName GetName(string localName); // 0x000000018AE4C2A0-0x000000018AE4C318
		public override string ToString(); // 0x0000000182B2ECC0-0x0000000182B2ECD0
		public static XNamespace Get(string namespaceName); // 0x000000018AE4C618-0x000000018AE4C68C
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName); // 0x000000018AE4C884-0x000000018AE4C8A0
		public override bool Equals(object obj); // 0x0000000182FB1840-0x0000000182FB1850
		public override int GetHashCode(); // 0x00000001811EF5B0-0x00000001811EF5C0
		public static bool operator ==(XNamespace left, XNamespace right); // 0x0000000182FB1840-0x0000000182FB1850
		public static bool operator !=(XNamespace left, XNamespace right); // 0x0000000182F019D0-0x0000000182F01A10
		internal XName GetName(string localName, int index, int count); // 0x000000018AE4C198-0x000000018AE4C2A0
		internal static XNamespace Get(string namespaceName, int index, int count); // 0x000000018AE4C318-0x000000018AE4C618
		private static string ExtractLocalName(XName n); // 0x00000001853E4DA0-0x00000001853E4DB8
		private static string ExtractNamespace(WeakReference r); // 0x000000018AE4C13C-0x000000018AE4C198
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName); // 0x000000018AE4C048-0x000000018AE4C13C
	}

	public abstract class XNode : XObject // TypeDefIndex: 62750
	{
		// Fields
		internal XNode next; // 0x20
	
		// Constructors
		internal XNode(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Remove(); // 0x000000018AE4CB40-0x000000018AE4CBB8
		public override string ToString(); // 0x000000018AE4CBB8-0x000000018AE4CBDC
		public abstract void WriteTo(XmlWriter writer);
		internal virtual void AppendText(StringBuilder sb); // 0x00000001841E1670-0x00000001841E1680
		internal abstract XNode CloneNode();
		private string GetXmlString(SaveOptions o); // 0x000000018AE4C8A0-0x000000018AE4CB40
	}

	public abstract class XObject : IXmlLineInfo // TypeDefIndex: 62751
	{
		// Fields
		internal XContainer parent; // 0x10
		internal object annotations; // 0x18
	
		// Properties
		public string BaseUri { get; } // 0x000000018AE4D460-0x000000018AE4D4D4 
		public abstract XmlNodeType NodeType { get; }
		public XElement Parent { get; } // 0x000000018AE4D514-0x000000018AE4D550 
		int IXmlLineInfo.LineNumber { get; } // 0x000000018AE4D3D8-0x000000018AE4D41C 
		int IXmlLineInfo.LinePosition { get; } // 0x000000018AE4D41C-0x000000018AE4D460 
		internal bool HasBaseUri { get; } // 0x000000018AE4D4D4-0x000000018AE4D514 
	
		// Constructors
		internal XObject(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void AddAnnotation(object annotation); // 0x000000018AE4CD90-0x000000018AE4CF80
		private object AnnotationForSealedType(System.Type type); // 0x000000018AE4CF80-0x000000018AE4D07C
		public T Annotation<T>()
			where T : class;
		bool IXmlLineInfo.HasLineInfo(); // 0x000000018AE4D398-0x000000018AE4D3D8
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e); // 0x000000018AE4D120-0x000000018AE4D1BC
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e); // 0x000000018AE4D1BC-0x000000018AE4D258
		internal void SetBaseUri(string baseUri); // 0x000000018AE4D258-0x000000018AE4D2D0
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x000000018AE4D2D0-0x000000018AE4D340
		internal bool SkipNotify(); // 0x000000018AE4D340-0x000000018AE4D398
		internal SaveOptions GetSaveOptionsFromAnnotations(); // 0x000000018AE4D07C-0x000000018AE4D120
	}

	internal class XObjectChangeAnnotation // TypeDefIndex: 62752
	{
		// Fields
		internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
		internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
	}

	public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 62753
	{
		// Fields
		private XObjectChange _objectChange; // 0x10
		public static readonly XObjectChangeEventArgs Add; // 0x00
		public static readonly XObjectChangeEventArgs Remove; // 0x08
		public static readonly XObjectChangeEventArgs Name; // 0x10
		public static readonly XObjectChangeEventArgs Value; // 0x18
	
		// Constructors
		public XObjectChangeEventArgs(XObjectChange objectChange); // 0x000000018AE4CD40-0x000000018AE4CD90
		static XObjectChangeEventArgs(); // 0x000000018AE4CBDC-0x000000018AE4CD40
	}

	public class XProcessingInstruction : XNode // TypeDefIndex: 62754
	{
		// Fields
		internal string target; // 0x28
		internal string data; // 0x30
	
		// Properties
		public string Data { get; } // 0x00000001811F36E0-0x00000001811F36F0 
		public override XmlNodeType NodeType { get; } // 0x0000000184D9BE00-0x0000000184D9BE10 
		public string Target { get; } // 0x0000000184D86240-0x0000000184D86250 
	
		// Constructors
		public XProcessingInstruction(string target, string data); // 0x000000018AE4D704-0x000000018AE4D7A8
		public XProcessingInstruction(XProcessingInstruction other); // 0x000000018AE4D7A8-0x000000018AE4D834
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE4D688-0x000000018AE4D704
		internal override XNode CloneNode(); // 0x000000018AE4D550-0x000000018AE4D5B0
		private static void ValidateName(string name); // 0x000000018AE4D5B0-0x000000018AE4D688
	}

	public class XStreamingElement // TypeDefIndex: 62755
	{
		// Fields
		internal XName name; // 0x10
		internal object content; // 0x18
	}

	public class XText : XNode // TypeDefIndex: 62756
	{
		// Fields
		internal string text; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get; } // 0x0000000184D8C9E0-0x0000000184D8C9F0 
		public string Value { get; set; } // 0x0000000184D86240-0x0000000184D86250 0x000000018AE4DA64-0x000000018AE4DF5C
	
		// Constructors
		public XText(string value); // 0x000000018AE4D978-0x000000018AE4D9EC
		public XText(XText other); // 0x000000018AE4D9EC-0x000000018AE4DA64
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018AE4D8BC-0x000000018AE4D978
		internal override void AppendText(StringBuilder sb); // 0x000000018AE4D834-0x000000018AE4D85C
		internal override XNode CloneNode(); // 0x000000018AE4D85C-0x000000018AE4D8BC
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 62758
	{
		// Methods
		public static void ThrowNotSupportedException(); // 0x000000018AE478E8-0x000000018AE47934
	}
}
