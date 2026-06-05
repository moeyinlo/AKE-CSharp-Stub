/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

// Image 83: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60106-60143

internal static class SR // TypeDefIndex: 60107
{
	// Methods
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018B98EAF4-0x000000018B98EB50
	internal static string Format(string resourceFormat, object p1, object p2) => default; // 0x000000018B98EA84-0x000000018B98EAF4
}

namespace System.Text
{
	internal static class StringBuilderCache // TypeDefIndex: 60142
	{
		// Fields
		private static StringBuilder t_cachedInstance; // 0x80000000
	
		// Methods
		public static StringBuilder Acquire(int capacity = 16 /* Metadata: 0x0208263E */) => default; // 0x000000018B98EB50-0x000000018B98EC28
		public static void Release(StringBuilder sb) {} // 0x000000018B98EC6C-0x000000018B98ECE4
		public static string GetStringAndRelease(StringBuilder sb) => default; // 0x000000018B98EC28-0x000000018B98EC6C
	}
}

namespace System.Xml.Linq
{
	internal class BaseUriAnnotation // TypeDefIndex: 60108
	{
		// Fields
		internal string baseUri; // 0x10
	
		// Constructors
		public BaseUriAnnotation() {} // Dummy constructor
		public BaseUriAnnotation(string baseUri) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	internal class LineInfoAnnotation // TypeDefIndex: 60109
	{
		// Fields
		internal int lineNumber; // 0x10
		internal int linePosition; // 0x14
	
		// Constructors
		public LineInfoAnnotation() {} // Dummy constructor
		public LineInfoAnnotation(int lineNumber, int linePosition) {} // 0x0000000185FB2190-0x0000000185FB21A0
	}

	internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 60110
	{
		// Constructors
		public LineInfoEndElementAnnotation() {} // Dummy constructor
		public LineInfoEndElementAnnotation(int lineNumber, int linePosition) {} // 0x0000000185FB2190-0x0000000185FB21A0
	}

	public class XAttribute : XObject // TypeDefIndex: 60111
	{
		// Fields
		internal XAttribute next; // 0x20
		internal XName name; // 0x28
		internal string value; // 0x30
	
		// Properties
		public bool IsNamespaceDeclaration { get => default; } // 0x000000018B98F970-0x000000018B98F9F4 
		public XName Name { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000181C6A970-0x0000000181C6A980 
		public string Value { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
	
		// Constructors
		public XAttribute() {} // Dummy constructor
		public XAttribute(XName name, object value) {} // 0x000000018B98F7D8-0x000000018B98F8E4
		public XAttribute(XAttribute other) {} // 0x000000018B98F8E4-0x000000018B98F970
	
		// Methods
		public override string ToString() => default; // 0x000000018B98F184-0x000000018B98F414
		internal string GetPrefixOfNamespace(XNamespace ns) => default; // 0x000000018B98F070-0x000000018B98F184
		private static void ValidateAttribute(XName name, string value) {} // 0x000000018B98F414-0x000000018B98F7D8
	}

	public class XCData : XText // TypeDefIndex: 60112
	{
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000181C44E90-0x0000000181C44EA0 
	
		// Constructors
		public XCData() {} // Dummy constructor
		public XCData(string value) {} // 0x000000018B98FACC-0x000000018B98FAD4
		public XCData(XCData other) {} // 0x000000018B98FAD4-0x000000018B98FADC
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B98FA54-0x000000018B98FACC
		internal override XNode CloneNode() => default; // 0x000000018B98F9F4-0x000000018B98FA54
	}

	public class XComment : XNode // TypeDefIndex: 60113
	{
		// Fields
		internal string value; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public string Value { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public XComment() {} // Dummy constructor
		public XComment(string value) {} // 0x000000018B98FC2C-0x000000018B98FCA0
		public XComment(XComment other) {} // 0x000000018B98FBB4-0x000000018B98FC2C
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B98FB3C-0x000000018B98FBB4
		internal override XNode CloneNode() => default; // 0x000000018B98FADC-0x000000018B98FB3C
	}

	public abstract class XContainer : XNode // TypeDefIndex: 60116
	{
		// Fields
		internal object content; // 0x28
	
		// Properties
		public XNode LastNode { get; } // 0x000000018B990868-0x000000018B99091C 
	
		// Nested types
		private sealed class ContentReader // TypeDefIndex: 60114
		{
			// Fields
			private readonly NamespaceCache _eCache; // 0x10
			private readonly NamespaceCache _aCache; // 0x20
			private readonly IXmlLineInfo _lineInfo; // 0x30
			private XContainer _currentContainer; // 0x38
			private string _baseUri; // 0x40
	
			// Constructors
			public ContentReader() {} // Dummy constructor
			public ContentReader(XContainer rootContainer) {} // 0x0000000185492010-0x0000000185492020
			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o) {} // 0x000000018B991208-0x000000018B99130C
	
			// Methods
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r) => default; // 0x000000018B99130C-0x000000018B991408
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) => default; // 0x000000018B990390-0x000000018B990698
		}
	
		private sealed class _Nodes_d__18 : IEnumerable<XNode>, IEnumerator<XNode> // TypeDefIndex: 60115
		{
			// Fields
			private int __1__state; // 0x10
			private XNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public XContainer __4__this; // 0x28
			private XNode _n_5__2; // 0x30
	
			// Properties
			XNode IEnumerator<System.Xml.Linq.XNode>.Current { get => default; } // 0x000000018B98FCA0-0x000000018B98FF68 
			object IEnumerator.Current { get => default; } // 0x000000018B98FF68-0x000000018B98FFE0 
	
			// Constructors
			public _Nodes_d__18() {} // Dummy constructor
			public _Nodes_d__18(int __1__state) {} // 0x000000018B990CF8-0x000000018B990D68
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018B98FFE0-0x000000018B990058
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator() => default; // 0x000000018B990188-0x000000018B990390
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B990058-0x000000018B990188
		}
	
		// Constructors
		internal XContainer() {} // 0x000000018B990754-0x000000018B990868
		internal XContainer(XContainer other) {} // 0x000000018B990698-0x000000018B990754
	
		// Methods
		public void Add(object content) {} // 0x000000018B99091C-0x000000018B9909D0
		public IEnumerable<XNode> Nodes() => default; // 0x000000018B9909D0-0x000000018B990CF8
		internal virtual void AddAttribute(XAttribute a) {} // 0x000000018B990D68-0x000000018B990E64
		internal virtual void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018B990E64-0x000000018B990F98
		internal void AddContentSkipNotify(object content) {} // 0x000000018B990F98-0x000000018B991124
		internal void AddNode(XNode n) {} // 0x0000000185492010-0x0000000185492020
		internal void AddNodeSkipNotify(XNode n) {} // 0x0000000185492010-0x0000000185492020
		internal void AddString(string s) {} // 0x000000018B991124-0x000000018B991208
		internal void AddStringSkipNotify(string s) {} // 0x0000000185A16440-0x0000000185A16450
		internal void AppendNode(XNode n) {} // 0x000000018B98E010-0x000000018B98E0D0
		internal void AppendNodeSkipNotify(XNode n) {} // 0x000000018B98DA00-0x000000018B98E010
		internal override void AppendText(StringBuilder sb) {} // 0x000000018B98D19C-0x000000018B98DA00
		internal void ConvertTextToNode() {} // 0x0000000184775050-0x0000000184775070
		internal static string GetStringValue(object value) => default; // 0x0000000185492010-0x0000000185492020
		internal void ReadContentFrom(XmlReader r) {} // 0x000000018B98EEE8-0x000000018B98EF90
		internal void ReadContentFrom(XmlReader r, LoadOptions o) {} // 0x0000000181377E40-0x0000000181377E50
		internal void RemoveNode(XNode n) {} // 0x000000018B98F024-0x000000018B98F070
		internal virtual void ValidateNode(XNode node, XNode previous) {} // 0x0000000181377E40-0x0000000181377E50
		internal virtual void ValidateString(string s) {} // 0x000000018B98EF90-0x000000018B98F01C
		internal void WriteContentTo(XmlWriter writer) {} // 0x000000018B98F01C-0x000000018B98F024
	}

	public class XDeclaration // TypeDefIndex: 60117
	{
		// Fields
		private string _version; // 0x10
		private string _encoding; // 0x18
		private string _standalone; // 0x20
	
		// Properties
		public string Encoding { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public string Standalone { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public string Version { get => default; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public XDeclaration() {} // Dummy constructor
		public XDeclaration(string version, string encoding, string standalone) {} // 0x000000018496F6A0-0x000000018496F6E0
		public XDeclaration(XDeclaration other) {} // 0x000000018B99155C-0x000000018B9915FC
	
		// Methods
		public override string ToString() => default; // 0x000000018B991408-0x000000018B99155C
	}

	public class XDocument : XContainer // TypeDefIndex: 60118
	{
		// Fields
		private XDeclaration _declaration; // 0x30
	
		// Properties
		public XDeclaration Declaration { get => default; set {} } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public override XmlNodeType NodeType { get => default; } // 0x0000000183056920-0x0000000183056930 
		public XElement Root { get => default; } // 0x000000018B991ED4-0x000000018B991F10 
	
		// Constructors
		public XDocument() {} // 0x0000000185492010-0x0000000185492020
		public XDocument(XDocument other) {} // 0x000000018B991E40-0x000000018B991ED4
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B991D1C-0x000000018B991E40
		internal override void AddAttribute(XAttribute a) {} // 0x000000018B991894-0x000000018B9918F0
		internal override void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018B991838-0x000000018B991894
		internal override XNode CloneNode() => default; // 0x000000018B9918F0-0x000000018B991950
		private T GetFirstNode<T>()
			where T : XNode => default;
		internal static bool IsWhitespace(string s) => default; // 0x000000018B991950-0x000000018B9919A8
		internal override void ValidateNode(XNode node, XNode previous) {} // 0x000000018B991AAC-0x000000018B991CAC
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) {} // 0x000000018B9919A8-0x000000018B991AAC
		internal override void ValidateString(string s) {} // 0x000000018B991CAC-0x000000018B991D1C
	}

	public class XDocumentType : XNode // TypeDefIndex: 60119
	{
		// Fields
		private string _name; // 0x28
		private string _publicId; // 0x30
		private string _systemId; // 0x38
		private string _internalSubset; // 0x40
	
		// Properties
		public string InternalSubset { get => default; } // 0x00000001813FF010-0x00000001813FF020 
		public string Name { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000185FB6A00-0x0000000185FB6A10 
		public string PublicId { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public string SystemId { get => default; } // 0x00000001813ECBC0-0x00000001813ECBD0 
	
		// Constructors
		public XDocumentType() {} // Dummy constructor
		public XDocumentType(string name, string publicId, string systemId, string internalSubset) {} // 0x000000018B991798-0x000000018B991838
		public XDocumentType(XDocumentType other) {} // 0x000000018B9916E8-0x000000018B991798
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B99165C-0x000000018B9916E8
		internal override XNode CloneNode() => default; // 0x000000018B9915FC-0x000000018B99165C
	}

	public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 60121
	{
		// Fields
		internal XName name; // 0x30
		internal XAttribute lastAttr; // 0x38
	
		// Properties
		public bool HasAttributes { get => default; } // 0x000000018B992D70-0x000000018B992E18 
		public bool IsEmpty { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public XName Name { get => default; } // 0x000000018B992A08-0x000000018B992BDC 
		public override XmlNodeType NodeType { get => default; } // 0x000000018B992BDC-0x000000018B992BF0 
		public string Value { get => default; } // 0x000000018B991FFC-0x000000018B9920E8 
	
		// Nested types
		private sealed class _GetAttributes_d__116 : IEnumerable<XAttribute>, IEnumerator<XAttribute> // TypeDefIndex: 60120
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
			XAttribute IEnumerator<System.Xml.Linq.XAttribute>.Current { get => default; } // 0x0000000188251750-0x000000018825175C 
			object IEnumerator.Current { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
	
			// Constructors
			public _GetAttributes_d__116() {} // Dummy constructor
			public _GetAttributes_d__116(int __1__state) {} // 0x000000018B992F64-0x000000018B992FD8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018B992E18-0x000000018B992ED8
			private bool MoveNext() => default; // 0x000000018B992ED8-0x000000018B992F64
			void IEnumerator.Reset() {} // 0x000000018B992FD8-0x000000018B992FE4
			IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator() => default; // 0x0000000181B87DE0-0x0000000181B87DF0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018B992FE4-0x000000018B99306C
		}
	
		// Constructors
		public XElement() {} // Dummy constructor
		public XElement(XName name) {} // 0x000000018B99226C-0x000000018B9922A0
		public XElement(XElement other) {} // 0x000000018B9922A0-0x000000018B9922AC
		public XElement(XStreamingElement other) {} // 0x000000018B992454-0x000000018B99265C
	
		// Methods
		public XAttribute Attribute(XName name) => default; // 0x000000018B991F10-0x000000018B991FFC
		public IEnumerable<XAttribute> Attributes() => default; // 0x000000018B992158-0x000000018B99226C
		public string GetPrefixOfNamespace(XNamespace ns) => default; // 0x000000018B9920E8-0x000000018B992158
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B9922AC-0x000000018B99230C
		XmlSchema IXmlSerializable.GetSchema() => default; // 0x000000018B99230C-0x000000018B992394
		void IXmlSerializable.ReadXml(XmlReader reader) {} // 0x000000018B992394-0x000000018B992454
		void IXmlSerializable.WriteXml(XmlWriter writer) {} // 0x000000018B992920-0x000000018B992998
		internal override void AddAttribute(XAttribute a) {} // 0x000000018B99265C-0x000000018B992920
		internal override void AddAttributeSkipNotify(XAttribute a) {} // 0x000000018B992998-0x000000018B992A08
		internal void AppendAttribute(XAttribute a) {} // 0x000000018B992BF0-0x000000018B992D70
		internal void AppendAttributeSkipNotify(XAttribute a) {} // 0x0000000184775050-0x0000000184775070
		internal override XNode CloneNode() => default; // 0x0000000185492010-0x0000000185492020
		private IEnumerable<XAttribute> GetAttributes(XName name) => default; // 0x000000018B98ED30-0x000000018B98EDF0
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) => default; // 0x0000000181377E40-0x0000000181377E50
		private void ReadElementFrom(XmlReader r, LoadOptions o) {} // 0x000000018B98EE9C-0x000000018B98EEE8
		private void ReadElementFromImpl(XmlReader r, LoadOptions o) {} // 0x0000000181377E40-0x0000000181377E50
		internal void SetEndElementLineInfo(int lineNumber, int linePosition) {} // 0x000000018B98EDF0-0x000000018B98EE94
		internal override void ValidateNode(XNode node, XNode previous) {} // 0x000000018B98EE94-0x000000018B98EE9C
	}

	internal sealed class XHashtable<TValue> // TypeDefIndex: 60125
	{
		// Fields
		private XHashtableState _state;
	
		// Nested types
		public delegate string ExtractKeyDelegate(TValue value); // TypeDefIndex: 60122; 0x00000000-0x00000000
	
		private sealed class XHashtableState // TypeDefIndex: 60124
		{
			// Fields
			private int[] _buckets;
			private Entry[] _entries;
			private int _numEntries;
			private ExtractKeyDelegate<TValue> _extractKey;
	
			// Nested types
			private struct Entry // TypeDefIndex: 60123
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

	internal struct NamespaceCache // TypeDefIndex: 60126
	{
		// Fields
		private XNamespace _ns; // 0x00
		private string _namespaceName; // 0x08
	
		// Methods
		public XNamespace Get(string namespaceName) => default; // 0x000000018B98E734-0x000000018B98E778
	}

	internal struct ElementWriter // TypeDefIndex: 60127
	{
		// Fields
		private XmlWriter _writer; // 0x00
		private NamespaceResolver _resolver; // 0x08
	
		// Constructors
		public ElementWriter(XmlWriter writer) {
			_writer = default;
			_resolver = default;
		} // 0x000000018B98E710-0x000000018B98E734
	
		// Methods
		public void WriteElement(XElement e) {} // 0x000000018B98E3B0-0x000000018B98E518
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) => default; // 0x000000018B98E0D0-0x000000018B98E1C4
		private void PushAncestors(XElement e) {} // 0x000000018B98E1C4-0x000000018B98E2CC
		private void PushElement(XElement e) {} // 0x000000018B98E2CC-0x000000018B98E3B0
		private void WriteEndElement() {} // 0x000000018B98E518-0x000000018B98E54C
		private void WriteFullEndElement() {} // 0x000000018B98E54C-0x000000018B98E580
		private void WriteStartElement(XElement e) {} // 0x000000018B98E580-0x000000018B98E710
	}

	internal struct NamespaceResolver // TypeDefIndex: 60129
	{
		// Fields
		private int _scope; // 0x00
		private NamespaceDeclaration _declaration; // 0x08
		private NamespaceDeclaration _rover; // 0x10
	
		// Nested types
		private class NamespaceDeclaration // TypeDefIndex: 60128
		{
			// Fields
			public string prefix; // 0x10
			public XNamespace ns; // 0x18
			public int scope; // 0x20
			public NamespaceDeclaration prev; // 0x28
	
			// Constructors
			public NamespaceDeclaration() {} // 0x0000000185FD6390-0x0000000185FD63A0
		}
	
		// Methods
		public void PushScope() {} // 0x000000018B98EA10-0x000000018B98EA84
		public void PopScope() {} // 0x000000018B98E850-0x000000018B98E918
		public void Add(string prefix, XNamespace ns) {} // 0x000000018B98E778-0x000000018B98E850
		public void AddFirst(string prefix, XNamespace ns) {} // 0x000000018B98E918-0x000000018B98EA10
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) => default; // 0x0000000185492010-0x0000000185492020
	}

	public enum XObjectChange // TypeDefIndex: 60130
	{
		Add = 0,
		Remove = 1,
		Name = 2,
		Value = 3
	}

	public enum LoadOptions // TypeDefIndex: 60131
	{
		None = 0,
		PreserveWhitespace = 1,
		SetBaseUri = 2,
		SetLineInfo = 4
	}

	public enum SaveOptions // TypeDefIndex: 60132
	{
		None = 0,
		DisableFormatting = 1,
		OmitDuplicateNamespaces = 2
	}

	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 60133
	{
		// Fields
		private XNamespace _ns; // 0x10
		private string _localName; // 0x18
		private int _hashCode; // 0x20
	
		// Properties
		public string LocalName { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public XNamespace Namespace { get => default; } // 0x000000018346D130-0x000000018346D140 
		public string NamespaceName { get => default; } // 0x000000018646E720-0x000000018646E73C 
	
		// Constructors
		internal XName(XNamespace ns, string localName) {} // 0x000000018B993334-0x000000018B9933DC
		internal XName() {} // 0x000000018B9933DC-0x000000018B99340C
	
		// Methods
		public override string ToString() => default; // 0x000000018B9932B8-0x000000018B993334
		public static XName Get(string expandedName) => default; // 0x000000018B99306C-0x000000018B993238
		public static XName Get(string localName, string namespaceName) => default; // 0x000000018B993238-0x000000018B99326C
		public static implicit operator XName(string expandedName) => default; // 0x000000018B99340C-0x000000018B993428
		public override bool Equals(object obj) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public override int GetHashCode() => default; // 0x00000001813B88B0-0x00000001813B88C0
		public static bool operator ==(XName left, XName right) => default; // 0x000000018406FBE0-0x000000018406FBF0
		bool IEquatable<XName>.Equals(XName other) => default; // 0x000000018406FBE0-0x000000018406FBF0
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) {} // 0x000000018B99326C-0x000000018B9932B8
	}

	public sealed class XNamespace // TypeDefIndex: 60134
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
		public string NamespaceName { get => default; } // 0x000000018346D130-0x000000018346D140 
		public static XNamespace None { get => default; } // 0x000000018B993B60-0x000000018B993BBC 
		public static XNamespace Xml { get => default; } // 0x000000018B993BBC-0x000000018B993C10 
		public static XNamespace Xmlns { get => default; } // 0x000000018B993C10-0x000000018B993C64 
	
		// Constructors
		public XNamespace() {} // Dummy constructor
		internal XNamespace(string namespaceName) {} // 0x000000018B993A6C-0x000000018B993B60
	
		// Methods
		public XName GetName(string localName) => default; // 0x000000018B993680-0x000000018B9936F8
		public override string ToString() => default; // 0x000000018346D130-0x000000018346D140
		public static XNamespace Get(string namespaceName) => default; // 0x000000018B9939F8-0x000000018B993A6C
		public static implicit operator XNamespace(string namespaceName) => default; // 0x000000018B993C64-0x000000018B993C80
		public override bool Equals(object obj) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public override int GetHashCode() => default; // 0x00000001813AE560-0x00000001813AE570
		public static bool operator ==(XNamespace left, XNamespace right) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public static bool operator !=(XNamespace left, XNamespace right) => default; // 0x0000000183FA9580-0x0000000183FA9590
		internal XName GetName(string localName, int index, int count) => default; // 0x000000018B993578-0x000000018B993680
		internal static XNamespace Get(string namespaceName, int index, int count) => default; // 0x000000018B9936F8-0x000000018B9939F8
		private static string ExtractLocalName(XName n) => default; // 0x00000001864C22B8-0x00000001864C22D0
		private static string ExtractNamespace(WeakReference r) => default; // 0x000000018B99351C-0x000000018B993578
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) => default; // 0x000000018B993428-0x000000018B99351C
	}

	public abstract class XNode : XObject // TypeDefIndex: 60135
	{
		// Fields
		internal XNode next; // 0x20
	
		// Constructors
		internal XNode() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Remove() {} // 0x000000018B993F20-0x000000018B993F98
		public override string ToString() => default; // 0x000000018B993F98-0x000000018B993FBC
		public abstract void WriteTo(XmlWriter writer);
		internal virtual void AppendText(StringBuilder sb) {} // 0x0000000185492010-0x0000000185492020
		internal abstract XNode CloneNode();
		private string GetXmlString(SaveOptions o) => default; // 0x000000018B993C80-0x000000018B993F20
	}

	public abstract class XObject : IXmlLineInfo // TypeDefIndex: 60136
	{
		// Fields
		internal XContainer parent; // 0x10
		internal object annotations; // 0x18
	
		// Properties
		public string BaseUri { get; } // 0x000000018B994840-0x000000018B9948B4 
		public abstract XmlNodeType NodeType { get; }
		public XElement Parent { get; } // 0x000000018B9948F4-0x000000018B994930 
		int IXmlLineInfo.LineNumber { get; } // 0x000000018B9947B8-0x000000018B9947FC 
		int IXmlLineInfo.LinePosition { get; } // 0x000000018B9947FC-0x000000018B994840 
		internal bool HasBaseUri { get; } // 0x000000018B9948B4-0x000000018B9948F4 
	
		// Constructors
		internal XObject() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void AddAnnotation(object annotation) {} // 0x000000018B994170-0x000000018B994360
		private object AnnotationForSealedType(System.Type type) => default; // 0x000000018B994360-0x000000018B99445C
		public T Annotation<T>()
			where T : class => default;
		bool IXmlLineInfo.HasLineInfo() => default; // 0x000000018B994778-0x000000018B9947B8
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) => default; // 0x000000018B994500-0x000000018B99459C
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) => default; // 0x000000018B99459C-0x000000018B994638
		internal void SetBaseUri(string baseUri) {} // 0x000000018B994638-0x000000018B9946B0
		internal void SetLineInfo(int lineNumber, int linePosition) {} // 0x000000018B9946B0-0x000000018B994720
		internal bool SkipNotify() => default; // 0x000000018B994720-0x000000018B994778
		internal SaveOptions GetSaveOptionsFromAnnotations() => default; // 0x000000018B99445C-0x000000018B994500
	}

	internal class XObjectChangeAnnotation // TypeDefIndex: 60137
	{
		// Fields
		internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
		internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
	
		// Constructors
		public XObjectChangeAnnotation() {} // Dummy constructor
	}

	public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 60138
	{
		// Fields
		private XObjectChange _objectChange; // 0x10
		public static readonly XObjectChangeEventArgs Add; // 0x00
		public static readonly XObjectChangeEventArgs Remove; // 0x08
		public static readonly XObjectChangeEventArgs Name; // 0x10
		public static readonly XObjectChangeEventArgs Value; // 0x18
	
		// Constructors
		public XObjectChangeEventArgs() {} // Dummy constructor
		public XObjectChangeEventArgs(XObjectChange objectChange) {} // 0x000000018B994120-0x000000018B994170
		static XObjectChangeEventArgs() {} // 0x000000018B993FBC-0x000000018B994120
	}

	public class XProcessingInstruction : XNode // TypeDefIndex: 60139
	{
		// Fields
		internal string target; // 0x28
		internal string data; // 0x30
	
		// Properties
		public string Data { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
		public override XmlNodeType NodeType { get => default; } // 0x0000000181B9FE80-0x0000000181B9FE90 
		public string Target { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public XProcessingInstruction() {} // Dummy constructor
		public XProcessingInstruction(string target, string data) {} // 0x000000018B994AE4-0x000000018B994B88
		public XProcessingInstruction(XProcessingInstruction other) {} // 0x000000018B994B88-0x000000018B994C14
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B994A68-0x000000018B994AE4
		internal override XNode CloneNode() => default; // 0x000000018B994930-0x000000018B994990
		private static void ValidateName(string name) {} // 0x000000018B994990-0x000000018B994A68
	}

	public class XStreamingElement // TypeDefIndex: 60140
	{
		// Fields
		internal XName name; // 0x10
		internal object content; // 0x18
	
		// Constructors
		public XStreamingElement() {} // Dummy constructor
	}

	public class XText : XNode // TypeDefIndex: 60141
	{
		// Fields
		internal string text; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get => default; } // 0x0000000181D1CE70-0x0000000181D1CE80 
		public string Value { get => default; set {} } // 0x00000001813B8590-0x00000001813B85A0 0x000000018B994E44-0x000000018B995588
	
		// Constructors
		public XText() {} // Dummy constructor
		public XText(string value) {} // 0x000000018B994D58-0x000000018B994DCC
		public XText(XText other) {} // 0x000000018B994DCC-0x000000018B994E44
	
		// Methods
		public override void WriteTo(XmlWriter writer) {} // 0x000000018B994C9C-0x000000018B994D58
		internal override void AppendText(StringBuilder sb) {} // 0x000000018B994C14-0x000000018B994C3C
		internal override XNode CloneNode() => default; // 0x000000018B994C3C-0x000000018B994C9C
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 60143
	{
		// Constructors
		public ThrowStub() {} // Dummy constructor
	
		// Methods
		public static void ThrowNotSupportedException() {} // 0x000000018B98ECE4-0x000000018B98ED30
	}
}
