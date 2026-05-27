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

// Image 83: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 59081-59118
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

internal static class SR // TypeDefIndex: 59082
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x00000001898687C0-0x000000018986881C
	internal static string Format(string resourceFormat, object p1, object p2) => default; // 0x0000000189868750-0x00000001898687C0
}

namespace System.Text
{
	internal static class StringBuilderCache // TypeDefIndex: 59117
	{
		// Fields
		[ThreadStatic]
		private static StringBuilder t_cachedInstance; // 0x80000000
	
		// Methods
		public static StringBuilder Acquire(int capacity = 16 /* Metadata: 0x01FDCD5A */) => default; // 0x000000018986881C-0x00000001898688F4
		public static void Release(StringBuilder sb) {} // 0x0000000189868938-0x00000001898689B0
		public static string GetStringAndRelease(StringBuilder sb) => default; // 0x00000001898688F4-0x0000000189868938
	}
}

namespace System.Xml.Linq
{
	internal class BaseUriAnnotation // TypeDefIndex: 59083
	{
		// Fields
		internal string baseUri; // 0x10
	
		// Constructors
		public BaseUriAnnotation() {} // Dummy constructor
		public BaseUriAnnotation(string baseUri) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	internal class LineInfoAnnotation // TypeDefIndex: 59084
	{
		// Fields
		internal int lineNumber; // 0x10
		internal int linePosition; // 0x14
	
		// Constructors
		public LineInfoAnnotation() {} // Dummy constructor
		public LineInfoAnnotation(int lineNumber, int linePosition) {} // 0x0000000183D50CB0-0x0000000183D50CC0
	}

	internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 59085
	{
		// Constructors
		public LineInfoEndElementAnnotation() {} // Dummy constructor
		public LineInfoEndElementAnnotation(int lineNumber, int linePosition) {} // 0x0000000183D50CB0-0x0000000183D50CC0
	}

	public class XAttribute : XObject // TypeDefIndex: 59086
	{
		// Fields
		internal XAttribute next; // 0x20
		internal XName name; // 0x28
		internal string value; // 0x30
	
		// Properties
		public bool IsNamespaceDeclaration { get => default; } // 0x000000018986963C-0x00000001898696C0 
		public XName Name { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public string Value { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public XAttribute() {} // Dummy constructor
		public XAttribute(XName name, object value) {} // 0x00000001898694A4-0x00000001898695B0
		public XAttribute(XAttribute other) {} // 0x00000001898695B0-0x000000018986963C
	
		// Methods
		public override string ToString() => default; // 0x0000000189868E50-0x00000001898690E0
		internal string GetPrefixOfNamespace(XNamespace ns) => default; // 0x0000000189868D3C-0x0000000189868E50
		private static void ValidateAttribute(XName name, string value) {} // 0x00000001898690E0-0x00000001898694A4
	}

	public class XCData : XText // TypeDefIndex: 59087
	{
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public XCData() {} // Dummy constructor
		public XCData(string value) {} // 0x0000000189869798-0x00000001898697A0
		public XCData(XCData other) {} // 0x00000001898697A0-0x00000001898697A8
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x0000000189869720-0x0000000189869798
		internal override XNode CloneNode() => default; // 0x00000001898696C0-0x0000000189869720
	}

	public class XComment : XNode // TypeDefIndex: 59088
	{
		// Fields
		internal string value; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public string Value { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public XComment() {} // Dummy constructor
		public XComment(string value) {} // 0x00000001898698F8-0x000000018986996C
		public XComment(XComment other) {} // 0x0000000189869880-0x00000001898698F8
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x0000000189869808-0x0000000189869880
		internal override XNode CloneNode() => default; // 0x00000001898697A8-0x0000000189869808
	}

	public abstract class XContainer : XNode // TypeDefIndex: 59091
	{
		// Fields
		internal object content; // 0x28
	
		// Properties
		public XNode LastNode { get; } // 0x000000018986AFD8-0x000000018986B0D4 
	
		// Nested types
		private sealed class ContentReader // TypeDefIndex: 59089
		{
			// Fields
			private readonly NamespaceCache _eCache; // 0x10
			private readonly NamespaceCache _aCache; // 0x20
			private readonly IXmlLineInfo _lineInfo; // 0x30
			private XContainer _currentContainer; // 0x38
			private string _baseUri; // 0x40
	
			// Constructors
			public ContentReader() {} // Dummy constructor
			public ContentReader(XContainer rootContainer) {} // 0x000000018388FF30-0x000000018388FF40
			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o) {} // 0x0000000189867CDC-0x0000000189867D9C
	
			// Methods
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r) => default; // 0x00000001898676CC-0x0000000189867CDC
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) => default; // 0x0000000189866E68-0x00000001898676CC
		}
	
		// Constructors
		internal XContainer() {} // 0x000000018350B670-0x000000018350B680
		internal XContainer(XContainer other) {} // 0x000000018986AED4-0x000000018986AFD8
	
		// Methods
		public void Add(object content) {} // 0x000000018986A05C-0x000000018986A364
		[IteratorStateMachine(typeof(_Nodes_d__18))]
		public IEnumerable<XNode> Nodes() => default; // 0x000000018986A9C4-0x000000018986AA34
		internal virtual void AddAttribute(XAttribute a) {} // 0x000000018350B670-0x000000018350B680
		internal virtual void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018350B670-0x000000018350B680
		internal void AddContentSkipNotify(object content) {} // 0x000000018986996C-0x0000000189869C34
		internal void AddNode(XNode n) {} // 0x0000000189869CAC-0x0000000189869D24
		internal void AddNodeSkipNotify(XNode n) {} // 0x0000000189869C34-0x0000000189869CAC
		internal void AddString(string s) {} // 0x0000000189869E54-0x000000018986A05C
		internal void AddStringSkipNotify(string s) {} // 0x0000000189869D24-0x0000000189869E54
		internal void AppendNode(XNode n) {} // 0x000000018986A420-0x000000018986A534
		internal void AppendNodeSkipNotify(XNode n) {} // 0x000000018986A364-0x000000018986A420
		internal override void AppendText(StringBuilder sb) {} // 0x000000018986A534-0x000000018986A5E8
		internal void ConvertTextToNode() {} // 0x000000018986A5E8-0x000000018986A69C
		internal static string GetStringValue(object value) => default; // 0x000000018986A69C-0x000000018986A9C4
		internal void ReadContentFrom(XmlReader r) {} // 0x000000018986AA34-0x000000018986AB30
		internal void ReadContentFrom(XmlReader r, LoadOptions o) {} // 0x000000018986AB30-0x000000018986AC64
		internal void RemoveNode(XNode n) {} // 0x000000018986AC64-0x000000018986ADF0
		internal virtual void ValidateNode(XNode node, XNode previous) {} // 0x000000018350B670-0x000000018350B680
		internal virtual void ValidateString(string s) {} // 0x000000018350B670-0x000000018350B680
		internal void WriteContentTo(XmlWriter writer) {} // 0x000000018986ADF0-0x000000018986AED4
	}

	public class XDeclaration // TypeDefIndex: 59092
	{
		// Fields
		private string _version; // 0x10
		private string _encoding; // 0x18
		private string _standalone; // 0x20
	
		// Properties
		public string Encoding { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public string Standalone { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public string Version { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public XDeclaration() {} // Dummy constructor
		public XDeclaration(string version, string encoding, string standalone) {} // 0x000000018285BDC0-0x000000018285BE00
		public XDeclaration(XDeclaration other) {} // 0x000000018986B228-0x000000018986B2C8
	
		// Methods
		public override string ToString() => default; // 0x000000018986B0D4-0x000000018986B228
	}

	public class XDocument : XContainer // TypeDefIndex: 59093
	{
		// Fields
		private XDeclaration _declaration; // 0x30
	
		// Properties
		public XDeclaration Declaration { get => default; set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D55810-0x0000000183D55820 
		public XElement Root { get => default; } // 0x000000018986BBA0-0x000000018986BBDC 
	
		// Constructors
		public XDocument() {} // 0x000000018350B670-0x000000018350B680
		public XDocument(XDocument other) {} // 0x000000018986BB0C-0x000000018986BBA0
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018986B9E8-0x000000018986BB0C
		internal override void AddAttribute(XAttribute a) {} // 0x000000018986B560-0x000000018986B5BC
		internal override void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018986B504-0x000000018986B560
		internal override XNode CloneNode() => default; // 0x000000018986B5BC-0x000000018986B61C
		private T GetFirstNode<T>()
			where T : XNode => default;
		internal static bool IsWhitespace(string s) => default; // 0x000000018986B61C-0x000000018986B674
		internal override void ValidateNode(XNode node, XNode previous) {} // 0x000000018986B778-0x000000018986B978
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) {} // 0x000000018986B674-0x000000018986B778
		internal override void ValidateString(string s) {} // 0x000000018986B978-0x000000018986B9E8
	}

	public class XDocumentType : XNode // TypeDefIndex: 59094
	{
		// Fields
		private string _name; // 0x28
		private string _publicId; // 0x30
		private string _systemId; // 0x38
		private string _internalSubset; // 0x40
	
		// Properties
		public string InternalSubset { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public string Name { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D55730-0x0000000183D55740 
		public string PublicId { get => default; } // 0x0000000181003830-0x0000000181003840 
		public string SystemId { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
	
		// Constructors
		public XDocumentType() {} // Dummy constructor
		public XDocumentType(string name, string publicId, string systemId, string internalSubset) {} // 0x000000018986B464-0x000000018986B504
		public XDocumentType(XDocumentType other) {} // 0x000000018986B3B4-0x000000018986B464
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018986B328-0x000000018986B3B4
		internal override XNode CloneNode() => default; // 0x000000018986B2C8-0x000000018986B328
	}

	[XmlSchemaProvider(null, IsAny = true)]
	[XmlTypeConvertor("ConvertForAssignment")]
	public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 59096
	{
		// Fields
		internal XName name; // 0x30
		internal XAttribute lastAttr; // 0x38
	
		// Properties
		public bool HasAttributes { get => default; } // 0x00000001860DAC58-0x00000001860DAC64 
		public bool IsEmpty { get => default; } // 0x000000018986CCA4-0x000000018986CCB0 
		public XName Name { get => default; } // 0x0000000181003830-0x0000000181003840 
		public override XmlNodeType NodeType { get => default; } // 0x0000000181168950-0x0000000181168960 
		public string Value { get => default; } // 0x000000018986CCB0-0x000000018986CD38 
	
		// Constructors
		public XElement() {} // Dummy constructor
		public XElement(XName name) {} // 0x000000018986CC30-0x000000018986CCA4
		public XElement(XElement other) {} // 0x000000018986CAE4-0x000000018986CBA4
		public XElement(XStreamingElement other) {} // 0x000000018986CBA4-0x000000018986CC30
	
		// Methods
		public XAttribute Attribute(XName name) => default; // 0x000000018986BF38-0x000000018986BF6C
		public IEnumerable<XAttribute> Attributes() => default; // 0x000000018986BF6C-0x000000018986BF78
		public string GetPrefixOfNamespace(XNamespace ns) => default; // 0x000000018986C120-0x000000018986C328
		public override void WriteTo(XmlWriter writer) {} // 0x000000018986CA3C-0x000000018986CAE4
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x0000000181002730-0x0000000181002740
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x000000018986C6D4-0x000000018986C8A8
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x000000018986C8A8-0x000000018986C8BC
		internal override void AddAttribute(XAttribute a) {} // 0x000000018986BCC8-0x000000018986BDB4
		internal override void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018986BBDC-0x000000018986BCC8
		internal void AppendAttribute(XAttribute a) {} // 0x000000018986BE24-0x000000018986BF38
		internal void AppendAttributeSkipNotify(XAttribute a) {} // 0x000000018986BDB4-0x000000018986BE24
		internal override XNode CloneNode() => default; // 0x000000018986BF78-0x000000018986BFD8
		[IteratorStateMachine(typeof(_GetAttributes_d__116))]
		private IEnumerable<XAttribute> GetAttributes(XName name) => default; // 0x000000018986BFD8-0x000000018986C060
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) => default; // 0x000000018986C060-0x000000018986C120
		private void ReadElementFrom(XmlReader r, LoadOptions o) {} // 0x000000018986C5EC-0x000000018986C664
		private void ReadElementFromImpl(XmlReader r, LoadOptions o) {} // 0x000000018986C328-0x000000018986C5EC
		internal void SetEndElementLineInfo(int lineNumber, int linePosition) {} // 0x000000018986C664-0x000000018986C6D4
		internal override void ValidateNode(XNode node, XNode previous) {} // 0x000000018986C8BC-0x000000018986CA3C
	}

	internal sealed class XHashtable<TValue> // TypeDefIndex: 59100
	{
		// Fields
		private XHashtableState _state;
	
		// Nested types
		public delegate string ExtractKeyDelegate(TValue value); // TypeDefIndex: 59097; 0x00000000-0x00000000
	
		private sealed class XHashtableState // TypeDefIndex: 59099
		{
			// Fields
			private int[] _buckets;
			private Entry[] _entries;
			private int _numEntries;
			private ExtractKeyDelegate<TValue> _extractKey;
	
			// Nested types
			private struct Entry // TypeDefIndex: 59098
			{
				// Fields
				public TValue Value;
				public int HashCode;
				public int Next;
			}
	
			// Constructors
			public XHashtableState() {} // Dummy constructor
			public XHashtableState(ExtractKeyDelegate<TValue> extractKey, int capacity) {}
	
			// Methods
			public XHashtableState<TValue> Resize() => default;
			public bool TryGetValue(string key, int index, int count, out ref TValue value) {
				value = default;
				return default;
			}
			public bool TryAdd(TValue value, out ref TValue newValue) {
				newValue = default;
				return default;
			}
			private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) => default;
			private static int ComputeHashCode(string key, int index, int count) => default;
		}
	
		// Constructors
		public XHashtable() {} // Dummy constructor
		public XHashtable(ExtractKeyDelegate extractKey, int capacity) {}
	
		// Methods
		public bool TryGetValue(string key, int index, int count, out ref TValue value) {
			value = default;
			return default;
		}
		public TValue Add(TValue value) => default;
	}

	internal struct NamespaceCache // TypeDefIndex: 59101
	{
		// Fields
		private XNamespace _ns; // 0x00
		private string _namespaceName; // 0x08
	
		// Methods
		public XNamespace Get(string namespaceName) => default; // 0x0000000189868400-0x0000000189868444
	}

	internal struct ElementWriter // TypeDefIndex: 59102
	{
		// Fields
		private XmlWriter _writer; // 0x00
		private NamespaceResolver _resolver; // 0x08
	
		// Constructors
		public ElementWriter(XmlWriter writer) {
			_writer = default;
			_resolver = default;
		} // 0x00000001898683DC-0x0000000189868400
	
		// Methods
		public void WriteElement(XElement e) {} // 0x000000018986807C-0x00000001898681E4
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) => default; // 0x0000000189867D9C-0x0000000189867E90
		private void PushAncestors(XElement e) {} // 0x0000000189867E90-0x0000000189867F98
		private void PushElement(XElement e) {} // 0x0000000189867F98-0x000000018986807C
		private void WriteEndElement() {} // 0x00000001898681E4-0x0000000189868218
		private void WriteFullEndElement() {} // 0x0000000189868218-0x000000018986824C
		private void WriteStartElement(XElement e) {} // 0x000000018986824C-0x00000001898683DC
	}

	internal struct NamespaceResolver // TypeDefIndex: 59104
	{
		// Fields
		private int _scope; // 0x00
		private NamespaceDeclaration _declaration; // 0x08
		private NamespaceDeclaration _rover; // 0x10
	
		// Nested types
		private class NamespaceDeclaration // TypeDefIndex: 59103
		{
			// Fields
			public string prefix; // 0x10
			public XNamespace ns; // 0x18
			public int scope; // 0x20
			public NamespaceDeclaration prev; // 0x28
	
			// Constructors
			public NamespaceDeclaration() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Methods
		public void PushScope() {} // 0x0000000183D75730-0x0000000183D75740
		public void PopScope() {} // 0x00000001898686DC-0x0000000189868750
		public void Add(string prefix, XNamespace ns) {} // 0x000000018986851C-0x00000001898685E4
		public void AddFirst(string prefix, XNamespace ns) {} // 0x0000000189868444-0x000000018986851C
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) => default; // 0x00000001898685E4-0x00000001898686DC
	}

	public enum XObjectChange // TypeDefIndex: 59105
	{
		Add = 0,
		Remove = 1,
		Name = 2,
		Value = 3
	}

	[Flags]
	public enum LoadOptions // TypeDefIndex: 59106
	{
		None = 0,
		PreserveWhitespace = 1,
		SetBaseUri = 2,
		SetLineInfo = 4
	}

	[Flags]
	public enum SaveOptions // TypeDefIndex: 59107
	{
		None = 0,
		DisableFormatting = 1,
		OmitDuplicateNamespaces = 2
	}

	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 59108
	{
		// Fields
		private XNamespace _ns; // 0x10
		private string _localName; // 0x18
		private int _hashCode; // 0x20
	
		// Properties
		public string LocalName { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public XNamespace Namespace { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string NamespaceName { get => default; } // 0x0000000184270688-0x00000001842706A4 
	
		// Constructors
		internal XName(XNamespace ns, string localName) {} // 0x000000018986D000-0x000000018986D0A8
		internal XName() {} // 0x000000018986D0A8-0x000000018986D0D8
	
		// Methods
		public override string ToString() => default; // 0x000000018986CF84-0x000000018986D000
		public static XName Get(string expandedName) => default; // 0x000000018986CD38-0x000000018986CF04
		public static XName Get(string localName, string namespaceName) => default; // 0x000000018986CF04-0x000000018986CF38
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName) => default; // 0x000000018986D0D8-0x000000018986D0F4
		public override bool Equals(object obj) => default; // 0x000000018232CE30-0x000000018232CE40
		public override int GetHashCode() => default; // 0x0000000181003B50-0x0000000181003B60
		public static bool operator ==(XName left, XName right) => default; // 0x000000018232CE30-0x000000018232CE40
		bool IEquatable<XName>.Equals(XName other) => default; // 0x000000018232CE30-0x000000018232CE40
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018986CF38-0x000000018986CF84
	}

	public sealed class XNamespace // TypeDefIndex: 59109
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
		public string NamespaceName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public static XNamespace None { get => default; } // 0x000000018986D82C-0x000000018986D888 
		public static XNamespace Xml { get => default; } // 0x000000018986D888-0x000000018986D8DC 
		public static XNamespace Xmlns { get => default; } // 0x000000018986D8DC-0x000000018986D930 
	
		// Constructors
		public XNamespace() {} // Dummy constructor
		internal XNamespace(string namespaceName) {} // 0x000000018986D738-0x000000018986D82C
	
		// Methods
		public XName GetName(string localName) => default; // 0x000000018986D34C-0x000000018986D3C4
		public override string ToString() => default; // 0x00000001820B7B20-0x00000001820B7B30
		public static XNamespace Get(string namespaceName) => default; // 0x000000018986D6C4-0x000000018986D738
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName) => default; // 0x000000018986D930-0x000000018986D94C
		public override bool Equals(object obj) => default; // 0x000000018232CE30-0x000000018232CE40
		public override int GetHashCode() => default; // 0x00000001820D1AC0-0x00000001820D1AD0
		public static bool operator ==(XNamespace left, XNamespace right) => default; // 0x000000018232CE30-0x000000018232CE40
		public static bool operator !=(XNamespace left, XNamespace right) => default; // 0x00000001822E54C0-0x00000001822E54D0
		internal XName GetName(string localName, int index, int count) => default; // 0x000000018986D244-0x000000018986D34C
		internal static XNamespace Get(string namespaceName, int index, int count) => default; // 0x000000018986D3C4-0x000000018986D6C4
		private static string ExtractLocalName(XName n) => default; // 0x00000001842C4004-0x00000001842C401C
		private static string ExtractNamespace(WeakReference r) => default; // 0x000000018986D1E8-0x000000018986D244
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) => default; // 0x000000018986D0F4-0x000000018986D1E8
	}

	public abstract class XNode : XObject // TypeDefIndex: 59110
	{
		// Fields
		internal XNode next; // 0x20
	
		// Constructors
		internal XNode() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Remove() {} // 0x000000018986DBEC-0x000000018986DC64
		public override string ToString() => default; // 0x000000018986DC64-0x000000018986DC88
		public abstract void WriteTo(XmlWriter writer);
		internal virtual void AppendText(StringBuilder sb) {} // 0x000000018350B670-0x000000018350B680
		internal abstract XNode CloneNode();
		private string GetXmlString(SaveOptions o) => default; // 0x000000018986D94C-0x000000018986DBEC
	}

	public abstract class XObject : IXmlLineInfo // TypeDefIndex: 59111
	{
		// Fields
		internal XContainer parent; // 0x10
		internal object annotations; // 0x18
	
		// Properties
		public string BaseUri { get; } // 0x000000018986E50C-0x000000018986E580 
		public abstract XmlNodeType NodeType { get; }
		public XElement Parent { get; } // 0x000000018986E5C0-0x000000018986E5FC 
		int IXmlLineInfo.LineNumber { get; } // 0x000000018986E484-0x000000018986E4C8 
		int IXmlLineInfo.LinePosition { get; } // 0x000000018986E4C8-0x000000018986E50C 
		internal bool HasBaseUri { get; } // 0x000000018986E580-0x000000018986E5C0 
	
		// Constructors
		internal XObject() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void AddAnnotation(object annotation) {} // 0x000000018986DE3C-0x000000018986E02C
		private object AnnotationForSealedType(System.Type type) => default; // 0x000000018986E02C-0x000000018986E128
		public T Annotation<T>()
			where T : class => default;
		bool IXmlLineInfo.HasLineInfo() => default; // 0x000000018986E444-0x000000018986E484
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) => default; // 0x000000018986E1CC-0x000000018986E268
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) => default; // 0x000000018986E268-0x000000018986E304
		internal void SetBaseUri(string baseUri) {} // 0x000000018986E304-0x000000018986E37C
		internal void SetLineInfo(int lineNumber, int linePosition) {} // 0x000000018986E37C-0x000000018986E3EC
		internal bool SkipNotify() => default; // 0x000000018986E3EC-0x000000018986E444
		internal SaveOptions GetSaveOptionsFromAnnotations() => default; // 0x000000018986E128-0x000000018986E1CC
	}

	internal class XObjectChangeAnnotation // TypeDefIndex: 59112
	{
		// Fields
		internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
		internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
	
		// Constructors
		public XObjectChangeAnnotation() {} // Dummy constructor
	}

	public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 59113
	{
		// Fields
		private XObjectChange _objectChange; // 0x10
		public static readonly XObjectChangeEventArgs Add; // 0x00
		public static readonly XObjectChangeEventArgs Remove; // 0x08
		public static readonly XObjectChangeEventArgs Name; // 0x10
		public static readonly XObjectChangeEventArgs Value; // 0x18
	
		// Constructors
		public XObjectChangeEventArgs() {} // Dummy constructor
		public XObjectChangeEventArgs(XObjectChange objectChange) {} // 0x000000018986DDEC-0x000000018986DE3C
		static XObjectChangeEventArgs() {} // 0x000000018986DC88-0x000000018986DDEC
	}

	public class XProcessingInstruction : XNode // TypeDefIndex: 59114
	{
		// Fields
		internal string target; // 0x28
		internal string data; // 0x30
	
		// Properties
		public string Data { get => default; } // 0x0000000181003830-0x0000000181003840 
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
		public string Target { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public XProcessingInstruction() {} // Dummy constructor
		public XProcessingInstruction(string target, string data) {} // 0x000000018986E7B0-0x000000018986E854
		public XProcessingInstruction(XProcessingInstruction other) {} // 0x000000018986E854-0x000000018986E8E0
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018986E734-0x000000018986E7B0
		internal override XNode CloneNode() => default; // 0x000000018986E5FC-0x000000018986E65C
		private static void ValidateName(string name) {} // 0x000000018986E65C-0x000000018986E734
	}

	public class XStreamingElement // TypeDefIndex: 59115
	{
		// Fields
		internal XName name; // 0x10
		internal object content; // 0x18
	
		// Constructors
		public XStreamingElement() {} // Dummy constructor
	}

	public class XText : XNode // TypeDefIndex: 59116
	{
		// Fields
		internal string text; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public string Value { get => default; set {} } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x000000018986EB10-0x000000018986F254
	
		// Constructors
		public XText() {} // Dummy constructor
		public XText(string value) {} // 0x000000018986EA24-0x000000018986EA98
		public XText(XText other) {} // 0x000000018986EA98-0x000000018986EB10
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018986E968-0x000000018986EA24
		internal override void AppendText(StringBuilder sb) {} // 0x000000018986E8E0-0x000000018986E908
		internal override XNode CloneNode() => default; // 0x000000018986E908-0x000000018986E968
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 59118
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x00000001898689B0-0x00000001898689FC
	}
}
