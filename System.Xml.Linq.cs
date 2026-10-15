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

// Image 86: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 90037-90074

internal static class SR // TypeDefIndex: 90038
{
	// Methods
	internal static string Format(string resourceFormat, object p1); // 0x000000018CFFA724-0x000000018CFFA780
	internal static string Format(string resourceFormat, object p1, object p2); // 0x000000018CFFA6B0-0x000000018CFFA724
}

namespace System.Text
{
	internal static class StringBuilderCache // TypeDefIndex: 90073
	{
		// Fields
		[ThreadStatic]
		private static StringBuilder t_cachedInstance; // 0x80000000
	
		// Methods
		public static StringBuilder Acquire(int capacity = 16 /* Metadata: 0x0264AB16 */); // 0x000000018CFFA780-0x000000018CFFA858
		public static void Release(StringBuilder sb); // 0x000000018CFFA89C-0x000000018CFFA914
		public static string GetStringAndRelease(StringBuilder sb); // 0x000000018CFFA858-0x000000018CFFA89C
	}
}

namespace System.Xml.Linq
{
	internal class BaseUriAnnotation // TypeDefIndex: 90039
	{
		// Fields
		internal string baseUri; // 0x10
	
		// Constructors
		public BaseUriAnnotation(string baseUri); // 0x0000000184FD2410-0x0000000184FD2420
	}

	internal class LineInfoAnnotation // TypeDefIndex: 90040
	{
		// Fields
		internal int lineNumber; // 0x10
		internal int linePosition; // 0x14
	
		// Constructors
		public LineInfoAnnotation(int lineNumber, int linePosition); // 0x0000000187235240-0x0000000187235250
	}

	internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 90041
	{
		// Constructors
		public LineInfoEndElementAnnotation(int lineNumber, int linePosition); // 0x0000000187235240-0x0000000187235250
	}

	public class XAttribute : XObject // TypeDefIndex: 90042
	{
		// Fields
		internal XAttribute next; // 0x20
		internal XName name; // 0x28
		internal string value; // 0x30
	
		// Properties
		public bool IsNamespaceDeclaration { get; } // 0x000000018CFFB5B8-0x000000018CFFB63C 
		public XName Name { get; } // 0x0000000182262130-0x0000000182262140 
		public override XmlNodeType NodeType { get; } // 0x00000001845AFFB0-0x00000001845AFFC0 
		public string Value { get; } // 0x00000001829600D0-0x00000001829600E0 
	
		// Constructors
		public XAttribute(XName name, object value); // 0x000000018CFFB420-0x000000018CFFB52C
		public XAttribute(XAttribute other); // 0x000000018CFFB52C-0x000000018CFFB5B8
	
		// Methods
		public override string ToString(); // 0x000000018CFFADC4-0x000000018CFFB05C
		internal string GetPrefixOfNamespace(XNamespace ns); // 0x000000018CFFACB0-0x000000018CFFADC4
		private static void ValidateAttribute(XName name, string value); // 0x000000018CFFB05C-0x000000018CFFB420
	}

	public class XCData : XText // TypeDefIndex: 90043
	{
		// Properties
		public override XmlNodeType NodeType { get; } // 0x00000001845BA780-0x00000001845BA790 
	
		// Constructors
		public XCData(string value); // 0x000000018CFFB714-0x000000018CFFB71C
		public XCData(XCData other); // 0x000000018CFFB71C-0x000000018CFFB724
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018CFFB69C-0x000000018CFFB714
		internal override XNode CloneNode(); // 0x000000018CFFB63C-0x000000018CFFB69C
	}

	public class XComment : XNode // TypeDefIndex: 90044
	{
		// Fields
		internal string value; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get; } // 0x0000000187239CB0-0x0000000187239CC0 
		public string Value { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public XComment(string value); // 0x000000018CFFB874-0x000000018CFFB8E8
		public XComment(XComment other); // 0x000000018CFFB7FC-0x000000018CFFB874
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018CFFB784-0x000000018CFFB7FC
		internal override XNode CloneNode(); // 0x000000018CFFB724-0x000000018CFFB784
	}

	public abstract class XContainer : XNode // TypeDefIndex: 90047
	{
		// Fields
		internal object content; // 0x28
	
		// Properties
		public XNode LastNode { get; } // 0x000000018CFFCF60-0x000000018CFFD05C 
	
		// Nested types
		private sealed class ContentReader // TypeDefIndex: 90045
		{
			// Fields
			private readonly NamespaceCache _eCache; // 0x10
			private readonly NamespaceCache _aCache; // 0x20
			private readonly IXmlLineInfo _lineInfo; // 0x30
			private XContainer _currentContainer; // 0x38
			private string _baseUri; // 0x40
	
			// Constructors
			public ContentReader(XContainer rootContainer); // 0x0000000186AB5C00-0x0000000186AB5C10
			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o); // 0x000000018CFF9C28-0x000000018CFF9CE8
	
			// Methods
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r); // 0x000000018CFF9614-0x000000018CFF9C28
			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o); // 0x000000018CFF8DB0-0x000000018CFF9614
		}
	
		[CompilerGenerated]
		private sealed class _Nodes_d__18 : IEnumerable<XNode>, IEnumerator<XNode> // TypeDefIndex: 90046
		{
			// Fields
			private int __1__state; // 0x10
			private XNode __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			public XContainer __4__this; // 0x28
			private XNode _n_5__2; // 0x30
	
			// Properties
			XNode IEnumerator<System.Xml.Linq.XNode>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Nodes_d__18(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CFFAB20-0x000000018CFFABCC
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CFFAC64-0x000000018CFFACB0
			[DebuggerHidden]
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator(); // 0x000000018CFFABCC-0x000000018CFFAC5C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CFFAC5C-0x000000018CFFAC64
		}
	
		// Constructors
		internal XContainer(); // 0x0000000186805BA0-0x0000000186805BB0
		internal XContainer(XContainer other); // 0x000000018CFFCE5C-0x000000018CFFCF60
	
		// Methods
		public void Add(object content); // 0x000000018CFFBFDC-0x000000018CFFC2DC
		[IteratorStateMachine(typeof(_Nodes_d__18))]
		public IEnumerable<XNode> Nodes(); // 0x000000018CFFC93C-0x000000018CFFC9AC
		internal virtual void AddAttribute(XAttribute a); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void AddAttributeSkipNotify(XAttribute a); // 0x0000000186805BA0-0x0000000186805BB0
		internal void AddContentSkipNotify(object content); // 0x000000018CFFB8E8-0x000000018CFFBBB4
		internal void AddNode(XNode n); // 0x000000018CFFBC2C-0x000000018CFFBCA4
		internal void AddNodeSkipNotify(XNode n); // 0x000000018CFFBBB4-0x000000018CFFBC2C
		internal void AddString(string s); // 0x000000018CFFBDD4-0x000000018CFFBFDC
		internal void AddStringSkipNotify(string s); // 0x000000018CFFBCA4-0x000000018CFFBDD4
		internal void AppendNode(XNode n); // 0x000000018CFFC398-0x000000018CFFC4AC
		internal void AppendNodeSkipNotify(XNode n); // 0x000000018CFFC2DC-0x000000018CFFC398
		internal override void AppendText(StringBuilder sb); // 0x000000018CFFC4AC-0x000000018CFFC560
		internal void ConvertTextToNode(); // 0x000000018CFFC560-0x000000018CFFC614
		internal static string GetStringValue(object value); // 0x000000018CFFC614-0x000000018CFFC93C
		internal void ReadContentFrom(XmlReader r); // 0x000000018CFFC9AC-0x000000018CFFCAA8
		internal void ReadContentFrom(XmlReader r, LoadOptions o); // 0x000000018CFFCAA8-0x000000018CFFCBE0
		internal void RemoveNode(XNode n); // 0x000000018CFFCBE0-0x000000018CFFCD78
		internal virtual void ValidateNode(XNode node, XNode previous); // 0x0000000186805BA0-0x0000000186805BB0
		internal virtual void ValidateString(string s); // 0x0000000186805BA0-0x0000000186805BB0
		internal void WriteContentTo(XmlWriter writer); // 0x000000018CFFCD78-0x000000018CFFCE5C
	}

	public class XDeclaration // TypeDefIndex: 90048
	{
		// Fields
		private string _version; // 0x10
		private string _encoding; // 0x18
		private string _standalone; // 0x20
	
		// Properties
		public string Encoding { get; } // 0x0000000182234E30-0x0000000182234E40 
		public string Standalone { get; } // 0x000000018225E800-0x000000018225E810 
		public string Version { get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public XDeclaration(string version, string encoding, string standalone); // 0x00000001854F5A50-0x00000001854F5A90
		public XDeclaration(XDeclaration other); // 0x000000018CFFD1B0-0x000000018CFFD250
	
		// Methods
		public override string ToString(); // 0x000000018CFFD05C-0x000000018CFFD1B0
	}

	public class XDocument : XContainer // TypeDefIndex: 90049
	{
		// Fields
		private XDeclaration _declaration; // 0x30
	
		// Properties
		public XDeclaration Declaration { get; set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public override XmlNodeType NodeType { get; } // 0x0000000187239CC0-0x0000000187239CD0 
		public XElement Root { get; } // 0x000000018CFFDB28-0x000000018CFFDB64 
	
		// Constructors
		public XDocument(); // 0x0000000186805BA0-0x0000000186805BB0
		public XDocument(XDocument other); // 0x000000018CFFDA94-0x000000018CFFDB28
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018CFFD970-0x000000018CFFDA94
		internal override void AddAttribute(XAttribute a); // 0x000000018CFFD4E8-0x000000018CFFD544
		internal override void AddAttributeSkipNotify(XAttribute a); // 0x000000018CFFD48C-0x000000018CFFD4E8
		internal override XNode CloneNode(); // 0x000000018CFFD544-0x000000018CFFD5A4
		private T GetFirstNode<T>()
			where T : XNode;
		internal static bool IsWhitespace(string s); // 0x000000018CFFD5A4-0x000000018CFFD5FC
		internal override void ValidateNode(XNode node, XNode previous); // 0x000000018CFFD704-0x000000018CFFD900
		private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter); // 0x000000018CFFD5FC-0x000000018CFFD704
		internal override void ValidateString(string s); // 0x000000018CFFD900-0x000000018CFFD970
	}

	public class XDocumentType : XNode // TypeDefIndex: 90050
	{
		// Fields
		private string _name; // 0x28
		private string _publicId; // 0x30
		private string _systemId; // 0x38
		private string _internalSubset; // 0x40
	
		// Properties
		public string InternalSubset { get; } // 0x000000018226EEA0-0x000000018226EEB0 
		public string Name { get; } // 0x0000000182262130-0x0000000182262140 
		public override XmlNodeType NodeType { get; } // 0x0000000187239CD0-0x0000000187239CE0 
		public string PublicId { get; } // 0x00000001829600D0-0x00000001829600E0 
		public string SystemId { get; } // 0x0000000182986470-0x0000000182986480 
	
		// Constructors
		public XDocumentType(string name, string publicId, string systemId, string internalSubset); // 0x000000018CFFD3EC-0x000000018CFFD48C
		public XDocumentType(XDocumentType other); // 0x000000018CFFD33C-0x000000018CFFD3EC
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018CFFD2B0-0x000000018CFFD33C
		internal override XNode CloneNode(); // 0x000000018CFFD250-0x000000018CFFD2B0
	}

	[XmlSchemaProvider(null, IsAny = true)]
	[XmlTypeConvertor("ConvertForAssignment")]
	public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 90052
	{
		// Fields
		internal XName name; // 0x30
		internal XAttribute lastAttr; // 0x38
	
		// Properties
		public bool HasAttributes { get; } // 0x000000018C1B5D6C-0x000000018C1B5D78 
		public bool IsEmpty { get; } // 0x000000018CFFEC34-0x000000018CFFEC40 
		public XName Name { get; } // 0x00000001829600D0-0x00000001829600E0 
		public override XmlNodeType NodeType { get; } // 0x00000001872328C0-0x00000001872328D0 
		public string Value { get; } // 0x000000018CFFEC40-0x000000018CFFECC8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAttributes_d__116 : IEnumerable<XAttribute>, IEnumerator<XAttribute> // TypeDefIndex: 90051
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
			XAttribute IEnumerator<System.Xml.Linq.XAttribute>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAttributes_d__116(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018CFFA960-0x000000018CFFAA24
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018CFFAAD4-0x000000018CFFAB20
			[DebuggerHidden]
			IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator(); // 0x000000018CFFAA24-0x000000018CFFAACC
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018CFFAACC-0x000000018CFFAAD4
		}
	
		// Constructors
		public XElement(XName name); // 0x000000018CFFEBC0-0x000000018CFFEC34
		public XElement(XElement other); // 0x000000018CFFEA74-0x000000018CFFEB34
		public XElement(XStreamingElement other); // 0x000000018CFFEB34-0x000000018CFFEBC0
	
		// Methods
		public XAttribute Attribute(XName name); // 0x000000018CFFDEC0-0x000000018CFFDEF4
		public IEnumerable<XAttribute> Attributes(); // 0x000000018CFFDEF4-0x000000018CFFDF00
		public string GetPrefixOfNamespace(XNamespace ns); // 0x000000018CFFE0A8-0x000000018CFFE2B0
		public override void WriteTo(XmlWriter writer); // 0x000000018CFFE9C4-0x000000018CFFEA74
		XmlSchema IXmlSerializable.GetSchema(); // 0x0000000185829EC0-0x0000000185829ED0
		void IXmlSerializable.ReadXml(XmlReader reader); // 0x000000018CFFE65C-0x000000018CFFE830
		void IXmlSerializable.WriteXml(XmlWriter writer); // 0x000000018CFFE830-0x000000018CFFE844
		internal override void AddAttribute(XAttribute a); // 0x000000018CFFDC50-0x000000018CFFDD3C
		internal override void AddAttributeSkipNotify(XAttribute a); // 0x000000018CFFDB64-0x000000018CFFDC50
		internal void AppendAttribute(XAttribute a); // 0x000000018CFFDDAC-0x000000018CFFDEC0
		internal void AppendAttributeSkipNotify(XAttribute a); // 0x000000018CFFDD3C-0x000000018CFFDDAC
		internal override XNode CloneNode(); // 0x000000018CFFDF00-0x000000018CFFDF60
		[IteratorStateMachine(typeof(_GetAttributes_d__116))]
		private IEnumerable<XAttribute> GetAttributes(XName name); // 0x000000018CFFDF60-0x000000018CFFDFE8
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope); // 0x000000018CFFDFE8-0x000000018CFFE0A8
		private void ReadElementFrom(XmlReader r, LoadOptions o); // 0x000000018CFFE574-0x000000018CFFE5EC
		private void ReadElementFromImpl(XmlReader r, LoadOptions o); // 0x000000018CFFE2B0-0x000000018CFFE574
		internal void SetEndElementLineInfo(int lineNumber, int linePosition); // 0x000000018CFFE5EC-0x000000018CFFE65C
		internal override void ValidateNode(XNode node, XNode previous); // 0x000000018CFFE844-0x000000018CFFE9C4
	}

	internal sealed class XHashtable<TValue> // TypeDefIndex: 90056
	{
		// Fields
		private XHashtableState _state;
	
		// Nested types
		public delegate string ExtractKeyDelegate(TValue value); // TypeDefIndex: 90053; 0x00000000-0x00000000
	
		private sealed class XHashtableState // TypeDefIndex: 90055
		{
			// Fields
			private int[] _buckets;
			private Entry[] _entries;
			private int _numEntries;
			private ExtractKeyDelegate<TValue> _extractKey;
	
			// Nested types
			private struct Entry // TypeDefIndex: 90054
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

	internal struct NamespaceCache // TypeDefIndex: 90057
	{
		// Fields
		private XNamespace _ns; // 0x00
		private string _namespaceName; // 0x08
	
		// Methods
		public XNamespace Get(string namespaceName); // 0x000000018CFFA350-0x000000018CFFA394
	}

	internal struct ElementWriter // TypeDefIndex: 90058
	{
		// Fields
		private XmlWriter _writer; // 0x00
		private NamespaceResolver _resolver; // 0x08
	
		// Constructors
		public ElementWriter(XmlWriter writer); // 0x000000018CFFA32C-0x000000018CFFA350
	
		// Methods
		public void WriteElement(XElement e); // 0x000000018CFF9FC8-0x000000018CFFA130
		private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace); // 0x000000018CFF9CE8-0x000000018CFF9DDC
		private void PushAncestors(XElement e); // 0x000000018CFF9DDC-0x000000018CFF9EE4
		private void PushElement(XElement e); // 0x000000018CFF9EE4-0x000000018CFF9FC8
		private void WriteEndElement(); // 0x000000018CFFA130-0x000000018CFFA164
		private void WriteFullEndElement(); // 0x000000018CFFA164-0x000000018CFFA198
		private void WriteStartElement(XElement e); // 0x000000018CFFA198-0x000000018CFFA32C
	}

	internal struct NamespaceResolver // TypeDefIndex: 90060
	{
		// Fields
		private int _scope; // 0x00
		private NamespaceDeclaration _declaration; // 0x08
		private NamespaceDeclaration _rover; // 0x10
	
		// Nested types
		private class NamespaceDeclaration // TypeDefIndex: 90059
		{
			// Fields
			public string prefix; // 0x10
			public XNamespace ns; // 0x18
			public int scope; // 0x20
			public NamespaceDeclaration prev; // 0x28
	
			// Constructors
			public NamespaceDeclaration(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Methods
		public void PushScope(); // 0x00000001872583D0-0x00000001872583E0
		public void PopScope(); // 0x000000018CFFA634-0x000000018CFFA6B0
		public void Add(string prefix, XNamespace ns); // 0x000000018CFFA470-0x000000018CFFA53C
		public void AddFirst(string prefix, XNamespace ns); // 0x000000018CFFA394-0x000000018CFFA470
		public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace); // 0x000000018CFFA53C-0x000000018CFFA634
	}

	public enum XObjectChange // TypeDefIndex: 90061
	{
		Add = 0,
		Remove = 1,
		Name = 2,
		Value = 3
	}

	[Flags]
	public enum LoadOptions // TypeDefIndex: 90062
	{
		None = 0,
		PreserveWhitespace = 1,
		SetBaseUri = 2,
		SetLineInfo = 4
	}

	[Flags]
	public enum SaveOptions // TypeDefIndex: 90063
	{
		None = 0,
		DisableFormatting = 1,
		OmitDuplicateNamespaces = 2
	}

	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 90064
	{
		// Fields
		private XNamespace _ns; // 0x10
		private string _localName; // 0x18
		private int _hashCode; // 0x20
	
		// Properties
		public string LocalName { get; } // 0x0000000182234E30-0x0000000182234E40 
		public XNamespace Namespace { get; } // 0x00000001829260F0-0x0000000182926100 
		public string NamespaceName { get; } // 0x000000018CFFF070-0x000000018CFFF08C 
	
		// Constructors
		internal XName(XNamespace ns, string localName); // 0x000000018CFFEF98-0x000000018CFFF040
		internal XName(); // 0x000000018CFFF040-0x000000018CFFF070
	
		// Methods
		public override string ToString(); // 0x000000018CFFEF18-0x000000018CFFEF98
		public static XName Get(string expandedName); // 0x000000018CFFECC8-0x000000018CFFEE98
		public static XName Get(string localName, string namespaceName); // 0x000000018CFFEE98-0x000000018CFFEECC
		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName); // 0x000000018CFFF08C-0x000000018CFFF0A8
		public override bool Equals(object obj); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public override int GetHashCode(); // 0x000000018226A850-0x000000018226A860
		public static bool operator ==(XName left, XName right); // 0x0000000184F9DDF0-0x0000000184F9DE00
		bool IEquatable<XName>.Equals(XName other); // 0x0000000184F9DDF0-0x0000000184F9DE00
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context); // 0x000000018CFFEECC-0x000000018CFFEF18
	}

	public sealed class XNamespace // TypeDefIndex: 90065
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
		public string NamespaceName { get; } // 0x00000001829260F0-0x0000000182926100 
		public static XNamespace None { get; } // 0x000000018CFFF7F0-0x000000018CFFF84C 
		public static XNamespace Xml { get; } // 0x000000018CFFF84C-0x000000018CFFF8A0 
		public static XNamespace Xmlns { get; } // 0x000000018CFFF8A0-0x000000018CFFF8F4 
	
		// Constructors
		internal XNamespace(string namespaceName); // 0x000000018CFFF6FC-0x000000018CFFF7F0
	
		// Methods
		public XName GetName(string localName); // 0x000000018CFFF304-0x000000018CFFF380
		public override string ToString(); // 0x00000001829260F0-0x0000000182926100
		public static XNamespace Get(string namespaceName); // 0x000000018CFFF688-0x000000018CFFF6FC
		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName); // 0x000000018CFFF8F4-0x000000018CFFF910
		public override bool Equals(object obj); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public override int GetHashCode(); // 0x00000001844AF510-0x00000001844AF520
		public static bool operator ==(XNamespace left, XNamespace right); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public static bool operator !=(XNamespace left, XNamespace right); // 0x0000000184F9E9E0-0x0000000184F9E9F0
		internal XName GetName(string localName, int index, int count); // 0x000000018CFFF1F8-0x000000018CFFF304
		internal static XNamespace Get(string namespaceName, int index, int count); // 0x000000018CFFF380-0x000000018CFFF688
		private static string ExtractLocalName(XName n); // 0x000000018788A2DC-0x000000018788A2F4
		private static string ExtractNamespace(WeakReference r); // 0x000000018CFFF19C-0x000000018CFFF1F8
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName); // 0x000000018CFFF0A8-0x000000018CFFF19C
	}

	public abstract class XNode : XObject // TypeDefIndex: 90066
	{
		// Fields
		internal XNode next; // 0x20
	
		// Constructors
		internal XNode(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Remove(); // 0x000000018CFFFBB8-0x000000018CFFFC30
		public override string ToString(); // 0x000000018CFFFC30-0x000000018CFFFC54
		public abstract void WriteTo(XmlWriter writer);
		internal virtual void AppendText(StringBuilder sb); // 0x0000000186805BA0-0x0000000186805BB0
		internal abstract XNode CloneNode();
		private string GetXmlString(SaveOptions o); // 0x000000018CFFF910-0x000000018CFFFBB8
	}

	public abstract class XObject : IXmlLineInfo // TypeDefIndex: 90067
	{
		// Fields
		internal XContainer parent; // 0x10
		internal object annotations; // 0x18
	
		// Properties
		public string BaseUri { get; } // 0x000000018D0004E8-0x000000018D00055C 
		public abstract XmlNodeType NodeType { get; }
		public XElement Parent { get; } // 0x000000018D00059C-0x000000018D0005D8 
		int IXmlLineInfo.LineNumber { get; } // 0x000000018D000460-0x000000018D0004A4 
		int IXmlLineInfo.LinePosition { get; } // 0x000000018D0004A4-0x000000018D0004E8 
		internal bool HasBaseUri { get; } // 0x000000018D00055C-0x000000018D00059C 
	
		// Constructors
		internal XObject(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void AddAnnotation(object annotation); // 0x000000018CFFFE08-0x000000018D000008
		private object AnnotationForSealedType(System.Type type); // 0x000000018D000008-0x000000018D000104
		public T Annotation<T>()
			where T : class;
		bool IXmlLineInfo.HasLineInfo(); // 0x000000018D000420-0x000000018D000460
		internal bool NotifyChanged(object sender, XObjectChangeEventArgs e); // 0x000000018D0001A8-0x000000018D000244
		internal bool NotifyChanging(object sender, XObjectChangeEventArgs e); // 0x000000018D000244-0x000000018D0002E0
		internal void SetBaseUri(string baseUri); // 0x000000018D0002E0-0x000000018D000358
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x000000018D000358-0x000000018D0003C8
		internal bool SkipNotify(); // 0x000000018D0003C8-0x000000018D000420
		internal SaveOptions GetSaveOptionsFromAnnotations(); // 0x000000018D000104-0x000000018D0001A8
	}

	internal class XObjectChangeAnnotation // TypeDefIndex: 90068
	{
		// Fields
		internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
		internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
	}

	public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 90069
	{
		// Fields
		private XObjectChange _objectChange; // 0x10
		public static readonly XObjectChangeEventArgs Add; // 0x00
		public static readonly XObjectChangeEventArgs Remove; // 0x08
		public static readonly XObjectChangeEventArgs Name; // 0x10
		public static readonly XObjectChangeEventArgs Value; // 0x18
	
		// Constructors
		public XObjectChangeEventArgs(XObjectChange objectChange); // 0x000000018CFFFDB8-0x000000018CFFFE08
		static XObjectChangeEventArgs(); // 0x000000018CFFFC54-0x000000018CFFFDB8
	}

	public class XProcessingInstruction : XNode // TypeDefIndex: 90070
	{
		// Fields
		internal string target; // 0x28
		internal string data; // 0x30
	
		// Properties
		public string Data { get; } // 0x00000001829600D0-0x00000001829600E0 
		public override XmlNodeType NodeType { get; } // 0x0000000187239C90-0x0000000187239CA0 
		public string Target { get; } // 0x0000000182262130-0x0000000182262140 
	
		// Constructors
		public XProcessingInstruction(string target, string data); // 0x000000018D00078C-0x000000018D000830
		public XProcessingInstruction(XProcessingInstruction other); // 0x000000018D000830-0x000000018D0008BC
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018D000710-0x000000018D00078C
		internal override XNode CloneNode(); // 0x000000018D0005D8-0x000000018D000638
		private static void ValidateName(string name); // 0x000000018D000638-0x000000018D000710
	}

	public class XStreamingElement // TypeDefIndex: 90071
	{
		// Fields
		internal XName name; // 0x10
		internal object content; // 0x18
	}

	public class XText : XNode // TypeDefIndex: 90072
	{
		// Fields
		internal string text; // 0x28
	
		// Properties
		public override XmlNodeType NodeType { get; } // 0x00000001872396E0-0x00000001872396F0 
		public string Value { get; set; } // 0x0000000182262130-0x0000000182262140 0x000000018D000AEC-0x000000018D000FE8
	
		// Constructors
		public XText(string value); // 0x000000018D000A00-0x000000018D000A74
		public XText(XText other); // 0x000000018D000A74-0x000000018D000AEC
	
		// Methods
		public override void WriteTo(XmlWriter writer); // 0x000000018D000944-0x000000018D000A00
		internal override void AppendText(StringBuilder sb); // 0x000000018D0008BC-0x000000018D0008E4
		internal override XNode CloneNode(); // 0x000000018D0008E4-0x000000018D000944
	}
}

namespace Unity
{
	internal sealed class ThrowStub : ObjectDisposedException // TypeDefIndex: 90074
	{
		// Methods
		public static void ThrowNotSupportedException(); // 0x000000018CFFA914-0x000000018CFFA960
	}
}
