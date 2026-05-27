/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

// Image 9: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 42409-43161
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Xml.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Xml.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../silverlight.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Xml.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("System.Data.SqlXml, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.Xml.Linq, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.ServiceModel.Friend, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("System.ServiceModel.Web, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly: InternalsVisibleTo("System.Xml.Linq, PublicKey=0024000004800000940000000602000000240000525341310004000001000100B5FC90E7027F67871E773A8FDE8938C81DD402BA65B9201D60593E96C492651E889CC13F1415EBB53FAC1131AE0BD333C5EE6021672D9718EA31A8AEBD0DA0072F25D87DBA6FC90FFD598ED4DA35E44C398C454307E8E33B8426143DAEC9F596836F97C8F74750E5975C64E2189F45DEF46B2A2B1247ADC3652BF5C308055DA9", AllInternalsVisible = false)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

internal static class SR // TypeDefIndex: 42410
{
	// Methods
	internal static string GetString(string name, params object[] args) => default; // 0x000000018985DB08-0x000000018985DB64
	internal static string GetString(CultureInfo culture, string name, params object[] args) => default; // 0x0000000189138604-0x000000018913860C
	internal static string Format(string resourceFormat, object p1) => default; // 0x000000018985DAAC-0x000000018985DB08
}

namespace Microsoft.CSharp
{
	internal class CodeDomProvider // TypeDefIndex: 42411
	{
		// Constructors
		public CodeDomProvider() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class CSharpCodeProvider : CodeDomProvider // TypeDefIndex: 42412
	{
		// Constructors
		public CSharpCodeProvider() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace MS.Internal.Xml.Cache
{
	internal abstract class XPathDocumentBaseIterator : XPathNodeIterator // TypeDefIndex: 43130
	{
		// Fields
		protected XPathDocumentNavigator ctxt; // 0x18
		protected int pos; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000181041090-0x00000001810410A0 
		public override int CurrentPosition { get; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Constructors
		protected XPathDocumentBaseIterator() {} // Dummy constructor
		protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt) {} // 0x0000000189925ED4-0x0000000189925F50
		protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter) {} // 0x0000000189925F50-0x0000000189925FE8
	}

	internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 43131
	{
		// Fields
		private string _localName; // 0x28
		private string _namespaceUri; // 0x30
	
		// Constructors
		public XPathDocumentElementChildIterator() {} // Dummy constructor
		public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI) {} // 0x00000001899260E8-0x00000001899261C0
		public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter) {} // 0x0000000189926098-0x00000001899260E8
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x0000000189925FE8-0x0000000189926048
		public override bool MoveNext() => default; // 0x0000000189926048-0x0000000189926098
	}

	internal class XPathDocumentKindChildIterator : XPathDocumentBaseIterator // TypeDefIndex: 43132
	{
		// Fields
		private XPathNodeType _typ; // 0x28
	
		// Constructors
		public XPathDocumentKindChildIterator() {} // Dummy constructor
		public XPathDocumentKindChildIterator(XPathDocumentNavigator parent, XPathNodeType typ) {} // 0x000000018992654C-0x0000000189926574
		public XPathDocumentKindChildIterator(XPathDocumentKindChildIterator iter) {} // 0x0000000189926574-0x00000001899265A8
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x00000001899264A0-0x0000000189926500
		public override bool MoveNext() => default; // 0x0000000189926500-0x000000018992654C
	}

	internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 43133
	{
		// Fields
		private XPathDocumentNavigator _end; // 0x28
		private string _localName; // 0x30
		private string _namespaceUri; // 0x38
		private bool _matchSelf; // 0x40
	
		// Constructors
		public XPathDocumentElementDescendantIterator() {} // Dummy constructor
		public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf) {} // 0x00000001899262D4-0x0000000189926434
		public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter) {} // 0x0000000189926434-0x00000001899264A0
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x00000001899261C0-0x0000000189926220
		public override bool MoveNext() => default; // 0x0000000189926220-0x00000001899262D4
	}

	internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator // TypeDefIndex: 43134
	{
		// Fields
		private XPathDocumentNavigator _end; // 0x28
		private XPathNodeType _typ; // 0x30
		private bool _matchSelf; // 0x34
	
		// Constructors
		public XPathDocumentKindDescendantIterator() {} // Dummy constructor
		public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf) {} // 0x000000018992669C-0x0000000189926760
		public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter) {} // 0x0000000189926760-0x00000001899267B0
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x00000001899265A8-0x0000000189926608
		public override bool MoveNext() => default; // 0x0000000189926608-0x000000018992669C
	}

	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 43135
	{
		// Fields
		private XPathNode[] _pageCurrent; // 0x10
		private XPathNode[] _pageParent; // 0x18
		private int _idxCurrent; // 0x20
		private int _idxParent; // 0x24
		private string _atomizedLocalName; // 0x28
	
		// Properties
		public override string Value { get => default; } // 0x0000000189927E24-0x0000000189927FE4 
		public override XPathNodeType NodeType { get => default; } // 0x0000000189927DB8-0x0000000189927DE4 
		public override string LocalName { get => default; } // 0x0000000189927CF0-0x0000000189927D20 
		public override string NamespaceURI { get => default; } // 0x0000000189927D88-0x0000000189927DB8 
		public override string Name { get => default; } // 0x0000000189927D58-0x0000000189927D88 
		public override string Prefix { get => default; } // 0x0000000189927DE4-0x0000000189927E14 
		public override string BaseURI { get => default; } // 0x0000000189927B58-0x0000000189927C2C 
		public override XmlNameTable NameTable { get => default; } // 0x0000000189927D20-0x0000000189927D58 
		public override object UnderlyingObject { get => default; } // 0x0000000189927E14-0x0000000189927E24 
		public int LineNumber { get => default; } // 0x0000000189927C2C-0x0000000189927C84 
		public int LinePosition { get => default; } // 0x0000000189927C84-0x0000000189927CF0 
	
		// Constructors
		public XPathDocumentNavigator() {} // Dummy constructor
		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) {} // 0x0000000189927A80-0x0000000189927B04
		public XPathDocumentNavigator(XPathDocumentNavigator nav) {} // 0x0000000189927B04-0x0000000189927B58
	
		// Methods
		public override XPathNavigator Clone() => default; // 0x00000001899267B0-0x000000018992684C
		public override bool MoveToFirstAttribute() => default; // 0x0000000189926F28-0x0000000189926F7C
		public override bool MoveToNextAttribute() => default; // 0x000000018992753C-0x000000018992754C
		public override bool MoveToAttribute(string localName, string namespaceURI) => default; // 0x0000000189926D34-0x0000000189926DF0
		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) => default; // 0x0000000189927010-0x00000001899270E8
		public override bool MoveToNextNamespace(XPathNamespaceScope scope) => default; // 0x000000018992754C-0x0000000189927654
		public override bool MoveToNext() => default; // 0x00000001899276DC-0x00000001899276EC
		public override bool MoveToFirstChild() => default; // 0x0000000189926F7C-0x0000000189927010
		public override bool MoveToParent() => default; // 0x0000000189927700-0x0000000189927754
		public override bool MoveTo(XPathNavigator other) => default; // 0x00000001899277B0-0x0000000189927830
		public override bool MoveToId(string id) => default; // 0x00000001899274AC-0x000000018992753C
		public override bool IsSamePosition(XPathNavigator other) => default; // 0x0000000189926CC0-0x0000000189926D34
		public override void MoveToRoot() {} // 0x0000000189927754-0x00000001899277B0
		public override bool MoveToChild(string localName, string namespaceURI) => default; // 0x0000000189926EA0-0x0000000189926F28
		public override bool MoveToNext(string localName, string namespaceURI) => default; // 0x0000000189927654-0x00000001899276DC
		public override bool MoveToChild(XPathNodeType type) => default; // 0x0000000189926DF0-0x0000000189926EA0
		public override bool MoveToNext(XPathNodeType type) => default; // 0x00000001899276EC-0x0000000189927700
		public override bool MoveToFollowing(string localName, string namespaceURI, XPathNavigator end) => default; // 0x00000001899270E8-0x0000000189927224
		public override bool MoveToFollowing(XPathNodeType type, XPathNavigator end) => default; // 0x0000000189927224-0x00000001899274AC
		public override XPathNodeIterator SelectChildren(XPathNodeType type) => default; // 0x00000001899278D0-0x0000000189927940
		public override XPathNodeIterator SelectChildren(string name, string namespaceURI) => default; // 0x0000000189927830-0x00000001899278D0
		public override XPathNodeIterator SelectDescendants(XPathNodeType type, bool matchSelf) => default; // 0x00000001899279FC-0x0000000189927A80
		public override XPathNodeIterator SelectDescendants(string name, string namespaceURI, bool matchSelf) => default; // 0x0000000189927940-0x00000001899279FC
		public override XmlNodeOrder ComparePosition(XPathNavigator other) => default; // 0x000000018992684C-0x0000000189926940
		public override bool IsDescendant(XPathNavigator other) => default; // 0x0000000189926ACC-0x0000000189926B9C
		private int GetPrimaryLocation() => default; // 0x0000000189926A00-0x0000000189926A20
		private int GetSecondaryLocation() => default; // 0x0000000189926A20-0x0000000189926A94
		public bool HasLineInfo() => default; // 0x0000000189926A94-0x0000000189926ACC
		public int GetPositionHashCode() => default; // 0x0000000183D75940-0x0000000183D75950
		public bool IsElementMatch(string localName, string namespaceURI) => default; // 0x0000000189926B9C-0x0000000189926C3C
		public bool IsKindMatch(XPathNodeType typ) => default; // 0x0000000189926C3C-0x0000000189926CC0
		private int GetFollowingEnd(XPathDocumentNavigator end, bool useParentOfVirtual, out XPathNode[] pageEnd) {
			pageEnd = default;
			return default;
		} // 0x0000000189926940-0x0000000189926A00
	}

	internal struct XPathNode // TypeDefIndex: 43136
	{
		// Fields
		private XPathNodeInfoAtom _info; // 0x00
		private ushort _idxSibling; // 0x08
		private ushort _idxParent; // 0x0A
		private ushort _idxSimilar; // 0x0C
		private ushort _posOffset; // 0x0E
		private uint _props; // 0x10
		private string _value; // 0x18
	
		// Properties
		public XPathNodeType NodeType { get => default; } // 0x0000000183D75950-0x0000000183D75960 
		public string Prefix { get => default; } // 0x000000018426FE40-0x000000018426FE60 
		public string LocalName { get => default; } // 0x0000000189138368-0x0000000189138384 
		public string Name { get => default; } // 0x00000001899292AC-0x0000000189929330 
		public string NamespaceUri { get => default; } // 0x0000000189929330-0x000000018992934C 
		public XPathDocument Document { get => default; } // 0x0000000189929144-0x0000000189929160 
		public string BaseUri { get => default; } // 0x000000018992910C-0x0000000189929128 
		public int LineNumber { get => default; } // 0x0000000189929264-0x000000018992928C 
		public int LinePosition { get => default; } // 0x000000018992928C-0x00000001899292AC 
		public int CollapsedLinePosition { get => default; } // 0x0000000189929128-0x0000000189929144 
		public XPathNodePageInfo PageInfo { get => default; } // 0x000000018992934C-0x0000000189929368 
		public bool IsXmlNamespaceNode { get => default; } // 0x00000001899291FC-0x0000000189929264 
		public bool HasSibling { get => default; } // 0x0000000189929188-0x0000000189929194 
		public bool HasCollapsedText { get => default; } // 0x0000000189929160-0x000000018992916C 
		public bool HasAttribute { get => default; } // 0x000000018286E940-0x000000018286E950 
		public bool HasContentChild { get => default; } // 0x000000018992916C-0x0000000189929174 
		public bool HasElementChild { get => default; } // 0x0000000189929174-0x000000018992917C 
		public bool IsAttrNmsp { get => default; } // 0x0000000189929194-0x00000001899291AC 
		public bool IsText { get => default; } // 0x00000001899291AC-0x00000001899291FC 
		public bool HasNamespaceDecls { get => default; } // 0x000000018992917C-0x0000000189929188 
		public string Value { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Methods
		public int GetRoot(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x0000000189929040-0x0000000189929074
		public int GetParent(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x0000000189929010-0x0000000189929040
		public int GetSibling(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x0000000189929074-0x00000001899290A4
		public int GetSimilarElement(out XPathNode[] pageNode) {
			pageNode = default;
			return default;
		} // 0x00000001899290A4-0x00000001899290D4
		public bool NameMatch(string localName, string namespaceName) => default; // 0x00000001899290D4-0x000000018992910C
		public bool ElementMatch(string localName, string namespaceName) => default; // 0x0000000189928FD0-0x0000000189929010
	}

	internal struct XPathNodeRef // TypeDefIndex: 43137
	{
		// Fields
		private XPathNode[] _page; // 0x00
		private int _idx; // 0x08
	
		// Properties
		public XPathNode[] Page { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public int Index { get => default; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Constructors
		public XPathNodeRef(XPathNode[] page, int idx) : this() {
			_page = default;
			_idx = default;
		} // 0x0000000184274600-0x000000018427461C
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189928FC0-0x0000000189928FD0
	}

	internal abstract class XPathNodeHelper // TypeDefIndex: 43138
	{
		// Constructors
		protected XPathNodeHelper() {} // Dummy constructor
	
		// Methods
		public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) {
			pageNmsp = default;
			return default;
		} // 0x0000000189928BE8-0x0000000189928C70
		public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) {
			pageNmsp = default;
			return default;
		} // 0x0000000189928AEC-0x0000000189928BE8
		public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x0000000189928AA0-0x0000000189928AEC
		public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x0000000189928CA8-0x0000000189928D38
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x00000001899282B4-0x0000000189928378
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x00000001899285B0-0x0000000189928644
		public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x0000000189928DF8-0x0000000189928E5C
		public static int GetLocation(XPathNode[] pageNode, int idxNode) => default; // 0x0000000189928C70-0x0000000189928CA8
		public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) => default; // 0x0000000189928644-0x0000000189928720
		public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) => default; // 0x00000001899289D8-0x0000000189928AA0
		public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) => default; // 0x00000001899281AC-0x00000001899282B4
		public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ) => default; // 0x00000001899284B8-0x00000001899285B0
		public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName) => default; // 0x000000018992804C-0x000000018992814C
		public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName) => default; // 0x0000000189928720-0x00000001899289D8
		public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ) => default; // 0x0000000189928378-0x00000001899284B8
		public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) => default; // 0x0000000189928E5C-0x0000000189928FC0
		public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) => default; // 0x0000000189928D38-0x0000000189928DF8
		private static void GetChild(ref XPathNode[] pageNode, ref int idxNode) {} // 0x000000018992814C-0x00000001899281AC
	}

	internal sealed class XPathNodePageInfo // TypeDefIndex: 43139
	{
		// Fields
		private int _pageNum; // 0x10
		private int _nodeCount; // 0x14
		private XPathNode[] _pageNext; // 0x18
	
		// Properties
		public int PageNumber { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public int NodeCount { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public XPathNode[] NextPage { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public XPathNodePageInfo() {} // Dummy constructor
	}

	internal sealed class XPathNodeInfoAtom // TypeDefIndex: 43140
	{
		// Fields
		private string _localName; // 0x10
		private string _namespaceUri; // 0x18
		private string _prefix; // 0x20
		private string _baseUri; // 0x28
		private XPathNode[] _pageParent; // 0x30
		private XPathNode[] _pageSibling; // 0x38
		private XPathNode[] _pageSimilar; // 0x40
		private XPathDocument _doc; // 0x48
		private int _lineNumBase; // 0x50
		private int _linePosBase; // 0x54
		private XPathNodePageInfo _pageInfo; // 0x58
	
		// Properties
		public XPathNodePageInfo PageInfo { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public string LocalName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string NamespaceUri { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public string Prefix { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public string BaseUri { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public XPathNode[] SiblingPage { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public XPathNode[] SimilarElementPage { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public XPathNode[] ParentPage { get => default; } // 0x0000000181003830-0x0000000181003840 
		public XPathDocument Document { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public int LineNumberBase { get => default; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
		public int LinePositionBase { get => default; } // 0x0000000183D4EEC0-0x0000000183D4EED0 
	
		// Constructors
		public XPathNodeInfoAtom() {} // Dummy constructor
	}
}

namespace MS.Internal.Xml.XPath
{
	internal sealed class AbsoluteQuery : ContextQuery // TypeDefIndex: 43054
	{
		// Constructors
		public AbsoluteQuery() {} // 0x0000000183D58F70-0x0000000183D58F80
		private AbsoluteQuery(AbsoluteQuery other) {} // 0x000000018990F6C0-0x000000018990F6C8
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x000000018990F660-0x000000018990F6C0
		public override XPathNodeIterator Clone() => default; // 0x000000018990F600-0x000000018990F660
	}

	internal abstract class AstNode // TypeDefIndex: 43056
	{
		// Properties
		public abstract AstType Type { get; }
		public abstract XPathResultType ReturnType { get; }
	
		// Nested types
		public enum AstType // TypeDefIndex: 43055
		{
			Axis = 0,
			Operator = 1,
			Filter = 2,
			ConstantOperand = 3,
			Function = 4,
			Group = 5,
			Root = 6,
			Variable = 7,
			Error = 8
		}
	
		// Constructors
		protected AstNode() {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class AttributeQuery : BaseAxisQuery // TypeDefIndex: 43057
	{
		// Fields
		private bool _onAttribute; // 0x58
	
		// Constructors
		public AttributeQuery() {} // Dummy constructor
		public AttributeQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type) {} // 0x000000018990F82C-0x000000018990F83C
		private AttributeQuery(AttributeQuery other) {} // 0x000000018990F7F4-0x000000018990F82C
	
		// Methods
		public override void Reset() {} // 0x000000018990F7E8-0x000000018990F7F4
		public override XPathNavigator Advance() => default; // 0x000000018990F6C8-0x000000018990F788
		public override XPathNodeIterator Clone() => default; // 0x000000018990F788-0x000000018990F7E8
	}

	internal class Axis : AstNode // TypeDefIndex: 43059
	{
		// Fields
		private AxisType _axisType; // 0x10
		private AstNode _input; // 0x18
		private string _prefix; // 0x20
		private string _name; // 0x28
		private XPathNodeType _nodeType; // 0x30
		protected bool abbrAxis; // 0x34
		private string _urn; // 0x38
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public AstNode Input { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public string Prefix { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public string Name { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public XPathNodeType NodeType { get => default; } // 0x0000000183D4ED20-0x0000000183D4ED30 
		public AxisType TypeOfAxis { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public bool AbbrAxis { get => default; } // 0x0000000183D4F570-0x0000000183D4F580 
		public string Urn { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
	
		// Nested types
		public enum AxisType // TypeDefIndex: 43058
		{
			Ancestor = 0,
			AncestorOrSelf = 1,
			Attribute = 2,
			Child = 3,
			Descendant = 4,
			DescendantOrSelf = 5,
			Following = 6,
			FollowingSibling = 7,
			Namespace = 8,
			Parent = 9,
			Preceding = 10,
			PrecedingSibling = 11,
			Self = 12,
			None = 13
		}
	
		// Constructors
		public Axis() {} // Dummy constructor
		public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) {} // 0x000000018990F83C-0x000000018990F8E4
		public Axis(AxisType axisType, AstNode input) {} // 0x000000018990F8E4-0x000000018990F960
	}

	internal abstract class BaseAxisQuery : Query // TypeDefIndex: 43060
	{
		// Fields
		internal Query qyInput; // 0x18
		private bool _nameTest; // 0x20
		private string _name; // 0x28
		private string _prefix; // 0x30
		private string _nsUri; // 0x38
		private XPathNodeType _typeTest; // 0x40
		protected XPathNavigator currentNode; // 0x48
		protected int position; // 0x50
	
		// Properties
		protected string Name { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		protected string Namespace { get; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		protected bool NameTest { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		protected XPathNodeType TypeTest { get; } // 0x0000000183D4ED80-0x0000000183D4ED90 
		public override int CurrentPosition { get; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
		public override XPathNavigator Current { get; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		public override XPathResultType StaticType { get; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		protected BaseAxisQuery() {} // Dummy constructor
		protected BaseAxisQuery(Query qyInput) {} // 0x000000018990FAD8-0x000000018990FB7C
		protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) {} // 0x000000018990FB7C-0x000000018990FC54
		protected BaseAxisQuery(BaseAxisQuery other) {} // 0x000000018990FA38-0x000000018990FAD8
	
		// Methods
		public override void Reset() {} // 0x000000018990F9AC-0x000000018990F9E4
		public override void SetXsltContext(XsltContext context) {} // 0x000000018990F9E4-0x000000018990FA38
		public virtual bool matches(XPathNavigator e) => default; // 0x000000018990FC54-0x000000018990FD38
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x000000018990F960-0x000000018990F9AC
	}

	internal sealed class BooleanExpr : ValueQuery // TypeDefIndex: 43061
	{
		// Fields
		private Query _opnd1; // 0x18
		private Query _opnd2; // 0x20
		private bool _isOr; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public BooleanExpr() {} // Dummy constructor
		public BooleanExpr(Operator.Op op, Query opnd1, Query opnd2) {} // 0x000000018990FED8-0x000000018990FFEC
		private BooleanExpr(BooleanExpr other) {} // 0x000000018990FE70-0x000000018990FED8
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x000000018990FE2C-0x000000018990FE70
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x000000018990FD98-0x000000018990FE2C
		public override XPathNodeIterator Clone() => default; // 0x000000018990FD38-0x000000018990FD98
	}

	internal sealed class BooleanFunctions : ValueQuery // TypeDefIndex: 43062
	{
		// Fields
		private Query _arg; // 0x18
		private Function.FunctionType _funcType; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public BooleanFunctions() {} // Dummy constructor
		public BooleanFunctions(Function.FunctionType funcType, Query arg) {} // 0x0000000189910284-0x00000001899102AC
		private BooleanFunctions(BooleanFunctions other) {} // 0x0000000189910234-0x0000000189910284
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x0000000189910220-0x0000000189910234
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x000000018991004C-0x0000000189910104
		internal static bool toBoolean(double number) => default; // 0x00000001899103C8-0x00000001899103E4
		internal static bool toBoolean(string str) => default; // 0x00000001899102AC-0x00000001899102C8
		internal bool toBoolean(XPathNodeIterator nodeIterator) => default; // 0x00000001899102C8-0x00000001899103C8
		private bool Not(XPathNodeIterator nodeIterator) => default; // 0x00000001899101BC-0x0000000189910220
		private bool Lang(XPathNodeIterator nodeIterator) => default; // 0x0000000189910104-0x00000001899101BC
		public override XPathNodeIterator Clone() => default; // 0x000000018990FFEC-0x000000018991004C
	}

	internal abstract class CacheAxisQuery : BaseAxisQuery // TypeDefIndex: 43063
	{
		// Fields
		protected List<XPathNavigator> outputBuffer; // 0x58
	
		// Properties
		public override XPathNavigator Current { get; } // 0x00000001899106B0-0x0000000189910708 
		public override int CurrentPosition { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public override int Count { get; } // 0x0000000189910670-0x00000001899106B0 
		public override QueryProps Properties { get; } // 0x0000000183D56A00-0x0000000183D56A10 
	
		// Constructors
		protected CacheAxisQuery() {} // Dummy constructor
		public CacheAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) {} // 0x00000001899105B8-0x0000000189910670
		protected CacheAxisQuery(CacheAxisQuery other) {} // 0x0000000189910508-0x00000001899105B8
	
		// Methods
		public override void Reset() {} // 0x0000000183D58F70-0x0000000183D58F80
		public override object Evaluate(XPathNodeIterator context) => default; // 0x00000001899104A4-0x0000000189910508
		public override XPathNavigator Advance() => default; // 0x0000000189910434-0x00000001899104A4
	}

	internal sealed class CacheChildrenQuery : ChildrenQuery // TypeDefIndex: 43064
	{
		// Fields
		private XPathNavigator _nextInput; // 0x60
		private ClonableStack<XPathNavigator> _elementStk; // 0x68
		private ClonableStack<int> _positionStk; // 0x70
		private bool _needInput; // 0x78
	
		// Constructors
		public CacheChildrenQuery() {} // Dummy constructor
		public CacheChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) {} // 0x0000000189910B34-0x0000000189910C34
		private CacheChildrenQuery(CacheChildrenQuery other) {} // 0x0000000189910A74-0x0000000189910B34
	
		// Methods
		public override void Reset() {} // 0x00000001899109F4-0x0000000189910A74
		public override XPathNavigator Advance() => default; // 0x0000000189910708-0x0000000189910854
		private bool DecideNextNode() => default; // 0x00000001899108B4-0x000000018991099C
		private XPathNavigator GetNextInput() => default; // 0x000000018991099C-0x00000001899109F4
		public override XPathNodeIterator Clone() => default; // 0x0000000189910854-0x00000001899108B4
	}

	internal abstract class CacheOutputQuery : Query // TypeDefIndex: 43065
	{
		// Fields
		internal Query input; // 0x18
		protected List<XPathNavigator> outputBuffer; // 0x20
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000189910EC0-0x0000000189910F18 
		public override XPathResultType StaticType { get; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override int CurrentPosition { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public override int Count { get; } // 0x0000000189910E80-0x0000000189910EC0 
		public override QueryProps Properties { get; } // 0x0000000183D56A00-0x0000000183D56A10 
	
		// Constructors
		protected CacheOutputQuery() {} // Dummy constructor
		public CacheOutputQuery(Query input) {} // 0x0000000189910DF0-0x0000000189910E80
		protected CacheOutputQuery(CacheOutputQuery other) {} // 0x0000000189910D2C-0x0000000189910DF0
	
		// Methods
		public override void Reset() {} // 0x0000000183D58F70-0x0000000183D58F80
		public override void SetXsltContext(XsltContext context) {} // 0x0000000189910D0C-0x0000000189910D2C
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189910CA4-0x0000000189910D0C
		public override XPathNavigator Advance() => default; // 0x0000000189910C34-0x0000000189910CA4
	}

	internal class ChildrenQuery : BaseAxisQuery // TypeDefIndex: 43066
	{
		// Fields
		private XPathNodeIterator _iterator; // 0x58
	
		// Constructors
		public ChildrenQuery() {} // Dummy constructor
		public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type) {} // 0x00000001899111D8-0x0000000189911274
		protected ChildrenQuery(ChildrenQuery other) {} // 0x0000000189911134-0x00000001899111D8
	
		// Methods
		public override void Reset() {} // 0x00000001899110D4-0x0000000189911134
		public override XPathNavigator Advance() => default; // 0x0000000189910F18-0x0000000189911074
		public override XPathNodeIterator Clone() => default; // 0x0000000189911074-0x00000001899110D4
	}

	internal sealed class ClonableStack<T> : List<T> // TypeDefIndex: 43067
	{
		// Constructors
		public ClonableStack() {}
		private ClonableStack(IEnumerable<T> collection) {}
	
		// Methods
		public void Push(T value) {}
		public T Pop() => default;
		public T Peek() => default;
		public ClonableStack<T> Clone() => default;
	}

	internal class CompiledXpathExpr : XPathExpression // TypeDefIndex: 43069
	{
		// Fields
		private Query _query; // 0x10
		private string _expr; // 0x18
		private bool _needContext; // 0x20
	
		// Properties
		internal Query QueryTree { get => default; } // 0x0000000189911374-0x00000001899113BC 
	
		// Nested types
		private class UndefinedXsltContext : XsltContext // TypeDefIndex: 43068
		{
			// Fields
			private IXmlNamespaceResolver _nsResolver; // 0x50
	
			// Properties
			public override string DefaultNamespace { get => default; } // 0x0000000189918EC0-0x0000000189918EF8 
			public override bool Whitespace { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Constructors
			public UndefinedXsltContext() {} // Dummy constructor
			public UndefinedXsltContext(IXmlNamespaceResolver nsResolver) {} // 0x0000000182C926C0-0x0000000182C926D0
	
			// Methods
			public override string LookupNamespace(string prefix) => default; // 0x0000000189918DA8-0x0000000189918E50
			public override IXsltContextVariable ResolveVariable(string prefix, string name) => default; // 0x0000000189918E88-0x0000000189918EC0
			public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes) => default; // 0x0000000189918E50-0x0000000189918E88
			public override bool PreserveWhitespace(XPathNavigator node) => default; // 0x000000018115F4C0-0x000000018115F530
		}
	
		// Constructors
		public CompiledXpathExpr() {} // Dummy constructor
		internal CompiledXpathExpr(Query query, string expression, bool needContext) {} // 0x0000000183D01130-0x0000000183D01160
	
		// Methods
		public override void SetContext(IXmlNamespaceResolver nsResolver) {} // 0x0000000189911274-0x0000000189911374
	}

	internal class ContextQuery : Query // TypeDefIndex: 43070
	{
		// Fields
		protected XPathNavigator contextNode; // 0x18
	
		// Properties
		public override XPathNavigator Current { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public override XPathResultType StaticType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override int CurrentPosition { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public override int Count { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override QueryProps Properties { get => default; } // 0x0000000183D56A00-0x0000000183D56A10 
	
		// Constructors
		public ContextQuery() {} // 0x0000000183D58F70-0x0000000183D58F80
		protected ContextQuery(ContextQuery other) {} // 0x0000000189496EA4-0x0000000189496ED8
	
		// Methods
		public override void Reset() {} // 0x0000000183D58F70-0x0000000183D58F80
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189911434-0x0000000189911470
		public override XPathNavigator Advance() => default; // 0x00000001899113BC-0x00000001899113D4
		public override XPathNodeIterator Clone() => default; // 0x00000001899113D4-0x0000000189911434
	}

	internal abstract class DescendantBaseQuery : BaseAxisQuery // TypeDefIndex: 43071
	{
		// Fields
		protected bool matchSelf; // 0x58
		protected bool abbrAxis; // 0x59
	
		// Constructors
		protected DescendantBaseQuery() {} // Dummy constructor
		public DescendantBaseQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) {} // 0x0000000189911470-0x00000001899114A8
		public DescendantBaseQuery(DescendantBaseQuery other) {} // 0x00000001899114A8-0x00000001899114E4
	}

	internal class DescendantQuery : DescendantBaseQuery // TypeDefIndex: 43072
	{
		// Fields
		private XPathNodeIterator _nodeIterator; // 0x60
	
		// Constructors
		public DescendantQuery() {} // Dummy constructor
		internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis) {} // 0x00000001899118EC-0x000000018991190C
		public DescendantQuery(DescendantQuery other) {} // 0x000000018991190C-0x0000000189911958
	
		// Methods
		public override void Reset() {} // 0x00000001899118C4-0x00000001899118EC
		public override XPathNavigator Advance() => default; // 0x0000000189911710-0x0000000189911864
		public override XPathNodeIterator Clone() => default; // 0x0000000189911864-0x00000001899118C4
	}

	internal sealed class DescendantOverDescendantQuery : DescendantBaseQuery // TypeDefIndex: 43073
	{
		// Fields
		private int _level; // 0x60
	
		// Constructors
		public DescendantOverDescendantQuery() {} // Dummy constructor
		public DescendantOverDescendantQuery(Query qyParent, bool matchSelf, string name, string prefix, XPathNodeType typeTest, bool abbrAxis) {} // 0x00000001899116E0-0x0000000189911710
		private DescendantOverDescendantQuery(DescendantOverDescendantQuery other) {} // 0x00000001899116AC-0x00000001899116E0
	
		// Methods
		public override void Reset() {} // 0x000000018991169C-0x00000001899116AC
		public override XPathNavigator Advance() => default; // 0x00000001899114E4-0x00000001899115B8
		private bool MoveToFirstChild() => default; // 0x0000000189911618-0x000000018991164C
		private bool MoveUpUntilNext() => default; // 0x000000018991164C-0x000000018991169C
		public override XPathNodeIterator Clone() => default; // 0x00000001899115B8-0x0000000189911618
	}

	internal sealed class DocumentOrderQuery : CacheOutputQuery // TypeDefIndex: 43074
	{
		// Constructors
		public DocumentOrderQuery() {} // Dummy constructor
		public DocumentOrderQuery(Query qyParent) {} // 0x0000000189911A0C-0x0000000189911A14
		private DocumentOrderQuery(DocumentOrderQuery other) {} // 0x0000000189911A04-0x0000000189911A0C
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x00000001899119B8-0x0000000189911A04
		public override XPathNodeIterator Clone() => default; // 0x0000000189911958-0x00000001899119B8
	}

	internal sealed class EmptyQuery : Query // TypeDefIndex: 43075
	{
		// Properties
		public override int CurrentPosition { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int Count { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override QueryProps Properties { get => default; } // 0x0000000183D56A00-0x0000000183D56A10 
		public override XPathResultType StaticType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override XPathNavigator Current { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public EmptyQuery() {} // 0x0000000183D51990-0x0000000183D519A0
	
		// Methods
		public override XPathNavigator Advance() => default; // 0x0000000181002730-0x0000000181002740
		public override XPathNodeIterator Clone() => default; // 0x000000018339AE90-0x000000018339AEA0
		public override object Evaluate(XPathNodeIterator context) => default; // 0x000000018339AE90-0x000000018339AEA0
		public override void Reset() {} // 0x000000018350B670-0x000000018350B680
	}

	internal abstract class ExtensionQuery : Query // TypeDefIndex: 43076
	{
		// Fields
		protected string prefix; // 0x18
		protected string name; // 0x20
		protected XsltContext xsltContext; // 0x28
		private ResetableIterator _queryIterator; // 0x30
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000189911F94-0x0000000189912010 
		public override int CurrentPosition { get; } // 0x0000000189911F74-0x0000000189911F94 
		protected string QName { get; } // 0x0000000189912010-0x0000000189912070 
		public override int Count { get; } // 0x0000000189911F54-0x0000000189911F74 
		public override XPathResultType StaticType { get; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		protected ExtensionQuery() {} // Dummy constructor
		public ExtensionQuery(string prefix, string name) {} // 0x0000000189911E5C-0x0000000189911E8C
		protected ExtensionQuery(ExtensionQuery other) {} // 0x0000000189911E8C-0x0000000189911F54
	
		// Methods
		public override void Reset() {} // 0x0000000189911E40-0x0000000189911E5C
		public override XPathNavigator Advance() => default; // 0x0000000189911A14-0x0000000189911A90
		protected object ProcessResult(object value) => default; // 0x0000000189911A90-0x0000000189911E40
	}

	internal class Filter : AstNode // TypeDefIndex: 43077
	{
		// Fields
		private AstNode _input; // 0x10
		private AstNode _condition; // 0x18
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public AstNode Input { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public AstNode Condition { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public Filter() {} // Dummy constructor
		public Filter(AstNode input, AstNode condition) {} // 0x0000000182676770-0x00000001826767A0
	}

	internal sealed class FilterQuery : BaseAxisQuery // TypeDefIndex: 43078
	{
		// Fields
		private Query _cond; // 0x58
		private bool _noPosition; // 0x60
	
		// Properties
		public Query Condition { get => default; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		public override QueryProps Properties { get => default; } // 0x00000001899123DC-0x0000000189912404 
	
		// Constructors
		public FilterQuery() {} // Dummy constructor
		public FilterQuery(Query qyParent, Query cond, bool noPosition) {} // 0x0000000189912348-0x000000018991238C
		private FilterQuery(FilterQuery other) {} // 0x000000018991238C-0x00000001899123DC
	
		// Methods
		public override void Reset() {} // 0x000000018991225C-0x0000000189912290
		public override void SetXsltContext(XsltContext input) {} // 0x0000000189912290-0x0000000189912348
		public override XPathNavigator Advance() => default; // 0x0000000189912070-0x00000001899120C8
		internal bool EvaluatePredicate() => default; // 0x0000000189912128-0x000000018991225C
		public override XPathNodeIterator Clone() => default; // 0x00000001899120C8-0x0000000189912128
	}

	internal sealed class FollSiblingQuery : BaseAxisQuery // TypeDefIndex: 43079
	{
		// Fields
		private ClonableStack<XPathNavigator> _elementStk; // 0x58
		private List<XPathNavigator> _parentStk; // 0x60
		private XPathNavigator _nextInput; // 0x68
	
		// Constructors
		public FollSiblingQuery() {} // Dummy constructor
		public FollSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType type) {} // 0x00000001899128A8-0x00000001899129A4
		private FollSiblingQuery(FollSiblingQuery other) {} // 0x00000001899127B8-0x00000001899128A8
	
		// Methods
		public override void Reset() {} // 0x0000000189912664-0x00000001899126D8
		private bool Visited(XPathNavigator nav) => default; // 0x00000001899126D8-0x00000001899127B8
		private XPathNavigator FetchInput() => default; // 0x0000000189912608-0x0000000189912664
		public override XPathNavigator Advance() => default; // 0x0000000189912404-0x00000001899125A8
		public override XPathNodeIterator Clone() => default; // 0x00000001899125A8-0x0000000189912608
	}

	internal sealed class FollowingQuery : BaseAxisQuery // TypeDefIndex: 43080
	{
		// Fields
		private XPathNavigator _input; // 0x58
		private XPathNodeIterator _iterator; // 0x60
	
		// Constructors
		public FollowingQuery() {} // Dummy constructor
		public FollowingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) {} // 0x000000018990F82C-0x000000018990F83C
		private FollowingQuery(FollowingQuery other) {} // 0x0000000189912C30-0x0000000189912CA0
	
		// Methods
		public override void Reset() {} // 0x00000001899118C4-0x00000001899118EC
		public override XPathNavigator Advance() => default; // 0x00000001899129A4-0x0000000189912BD0
		public override XPathNodeIterator Clone() => default; // 0x0000000189912BD0-0x0000000189912C30
	}

	internal class ForwardPositionQuery : CacheOutputQuery // TypeDefIndex: 43081
	{
		// Constructors
		public ForwardPositionQuery() {} // Dummy constructor
		public ForwardPositionQuery(Query input) {} // 0x0000000189911A0C-0x0000000189911A14
		protected ForwardPositionQuery(ForwardPositionQuery other) {} // 0x0000000189911A04-0x0000000189911A0C
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189912D00-0x0000000189912D90
		public override XPathNodeIterator Clone() => default; // 0x0000000189912CA0-0x0000000189912D00
	}

	internal class Function : AstNode // TypeDefIndex: 43083
	{
		// Fields
		private FunctionType _functionType; // 0x10
		private List<AstNode> _argumentList; // 0x18
		private string _name; // 0x20
		private string _prefix; // 0x28
		internal static XPathResultType[] ReturnTypes; // 0x00
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
		public override XPathResultType ReturnType { get => default; } // 0x0000000189913884-0x00000001899138EC 
		public FunctionType TypeOfFunction { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public List<AstNode> ArgumentList { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public string Prefix { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public string Name { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public enum FunctionType // TypeDefIndex: 43082
		{
			FuncLast = 0,
			FuncPosition = 1,
			FuncCount = 2,
			FuncID = 3,
			FuncLocalName = 4,
			FuncNameSpaceUri = 5,
			FuncName = 6,
			FuncString = 7,
			FuncBoolean = 8,
			FuncNumber = 9,
			FuncTrue = 10,
			FuncFalse = 11,
			FuncNot = 12,
			FuncConcat = 13,
			FuncStartsWith = 14,
			FuncContains = 15,
			FuncSubstringBefore = 16,
			FuncSubstringAfter = 17,
			FuncSubstring = 18,
			FuncStringLength = 19,
			FuncNormalize = 20,
			FuncTranslate = 21,
			FuncLang = 22,
			FuncSum = 23,
			FuncFloor = 24,
			FuncCeiling = 25,
			FuncRound = 26,
			FuncUserDefined = 27
		}
	
		// Constructors
		public Function() {} // Dummy constructor
		public Function(FunctionType ftype, List<AstNode> argumentList) {} // 0x0000000189913740-0x00000001899137CC
		public Function(string prefix, string name, List<AstNode> argumentList) {} // 0x00000001899137CC-0x0000000189913884
		public Function(FunctionType ftype, AstNode arg) {} // 0x0000000189913694-0x0000000189913740
		static Function() {} // 0x0000000189913608-0x0000000189913694
	}

	internal sealed class FunctionQuery : ExtensionQuery // TypeDefIndex: 43084
	{
		// Fields
		private IList<Query> _args; // 0x38
		private IXsltContextFunction _function; // 0x40
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x00000001899135B0-0x0000000189913608 
	
		// Constructors
		public FunctionQuery() {} // Dummy constructor
		public FunctionQuery(string prefix, string name, List<Query> args) {} // 0x0000000189913454-0x0000000189913484
		private FunctionQuery(FunctionQuery other) {} // 0x0000000189913484-0x00000001899135B0
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x000000018991310C-0x0000000189913454
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189912DF0-0x000000018991310C
		public override XPathNodeIterator Clone() => default; // 0x0000000189912D90-0x0000000189912DF0
	}

	internal class Group : AstNode // TypeDefIndex: 43085
	{
		// Fields
		private AstNode _groupNode; // 0x10
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000183D51100-0x0000000183D51110 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public AstNode GroupNode { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public Group() {} // Dummy constructor
		public Group(AstNode groupNode) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	internal sealed class GroupQuery : BaseAxisQuery // TypeDefIndex: 43086
	{
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x00000001899139C0-0x00000001899139E4 
		public override QueryProps Properties { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public GroupQuery() {} // Dummy constructor
		public GroupQuery(Query qy) {} // 0x00000001899139B0-0x00000001899139B8
		private GroupQuery(GroupQuery other) {} // 0x00000001899139B8-0x00000001899139C0
	
		// Methods
		public override XPathNavigator Advance() => default; // 0x00000001899138EC-0x0000000189913930
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189913990-0x00000001899139B0
		public override XPathNodeIterator Clone() => default; // 0x0000000189913930-0x0000000189913990
	}

	internal sealed class IDQuery : CacheOutputQuery // TypeDefIndex: 43087
	{
		// Constructors
		public IDQuery() {} // Dummy constructor
		public IDQuery(Query arg) {} // 0x0000000189911A0C-0x0000000189911A14
		private IDQuery(IDQuery other) {} // 0x0000000189911A04-0x0000000189911A0C
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189913A44-0x0000000189913C38
		private void ProcessIds(XPathNavigator contextNode, string val) {} // 0x0000000189913C38-0x0000000189913CEC
		public override XPathNodeIterator Clone() => default; // 0x00000001899139E4-0x0000000189913A44
	}

	internal class IteratorFilter : XPathNodeIterator // TypeDefIndex: 43088
	{
		// Fields
		private XPathNodeIterator _innerIterator; // 0x18
		private string _name; // 0x20
		private int _position; // 0x28
	
		// Properties
		public override XPathNavigator Current { get => default; } // 0x0000000189913E1C-0x0000000189913E40 
		public override int CurrentPosition { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
		// Constructors
		public IteratorFilter() {} // Dummy constructor
		internal IteratorFilter(XPathNodeIterator innerIterator, string name) {} // 0x0000000189911E5C-0x0000000189911E8C
		private IteratorFilter(IteratorFilter it) {} // 0x0000000189913DBC-0x0000000189913E1C
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x0000000189913CEC-0x0000000189913D4C
		public override bool MoveNext() => default; // 0x0000000189913D4C-0x0000000189913DBC
	}

	internal sealed class LogicalExpr : ValueQuery // TypeDefIndex: 43091
	{
		// Fields
		private Operator.Op _op; // 0x18
		private Query _opnd1; // 0x20
		private Query _opnd2; // 0x28
		private static readonly cmpXslt[][] s_CompXsltE; // 0x00
		private static readonly cmpXslt[][] s_CompXsltO; // 0x08
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Nested types
		private delegate bool cmpXslt(Operator.Op op, object val1, object val2); // TypeDefIndex: 43089; 0x0000000181035ED0-0x0000000181035EF0
	
		private struct NodeSet // TypeDefIndex: 43090
		{
			// Fields
			private Query _opnd; // 0x00
			private XPathNavigator _current; // 0x08
	
			// Properties
			public string Value { get => default; } // 0x0000000189916790-0x00000001899167B4 
	
			// Constructors
			public NodeSet(object opnd) : this() {
				_opnd = default;
				_current = default;
			} // 0x0000000189916720-0x0000000189916790
	
			// Methods
			public bool MoveNext() => default; // 0x00000001899166C4-0x0000000189916700
			public void Reset() {} // 0x0000000189916700-0x0000000189916720
		}
	
		// Constructors
		public LogicalExpr() {} // Dummy constructor
		public LogicalExpr(Operator.Op op, Query opnd1, Query opnd2) {} // 0x0000000189914B8C-0x0000000189914BBC
		private LogicalExpr(LogicalExpr other) {} // 0x0000000189914BBC-0x0000000189914C24
		static LogicalExpr() {} // 0x00000001899140E0-0x0000000189914B8C
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x000000018991409C-0x00000001899140E0
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189913EA0-0x000000018991403C
		private static bool cmpQueryQueryE(Operator.Op op, object val1, object val2) => default; // 0x0000000189915420-0x00000001899154E0
		private static bool cmpQueryQueryO(Operator.Op op, object val1, object val2) => default; // 0x00000001899154E0-0x0000000189915608
		private static bool cmpQueryNumber(Operator.Op op, object val1, object val2) => default; // 0x0000000189915344-0x0000000189915420
		private static bool cmpQueryStringE(Operator.Op op, object val1, object val2) => default; // 0x0000000189915608-0x00000001899156D0
		private static bool cmpQueryStringO(Operator.Op op, object val1, object val2) => default; // 0x00000001899156D0-0x00000001899157C0
		private static bool cmpRtfQueryE(Operator.Op op, object val1, object val2) => default; // 0x00000001899159A0-0x0000000189915A5C
		private static bool cmpRtfQueryO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915A5C-0x0000000189915B3C
		private static bool cmpQueryBoolE(Operator.Op op, object val1, object val2) => default; // 0x00000001899151C0-0x0000000189915274
		private static bool cmpQueryBoolO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915274-0x0000000189915344
		private static bool cmpBoolBoolE(Operator.Op op, bool n1, bool n2) => default; // 0x0000000189914C24-0x0000000189914C30
		private static bool cmpBoolBoolE(Operator.Op op, object val1, object val2) => default; // 0x0000000189914C30-0x0000000189914CD0
		private static bool cmpBoolBoolO(Operator.Op op, object val1, object val2) => default; // 0x0000000189914CD0-0x0000000189914D84
		private static bool cmpBoolNumberE(Operator.Op op, object val1, object val2) => default; // 0x0000000189914D84-0x0000000189914E3C
		private static bool cmpBoolNumberO(Operator.Op op, object val1, object val2) => default; // 0x0000000189914E3C-0x0000000189914EF4
		private static bool cmpBoolStringE(Operator.Op op, object val1, object val2) => default; // 0x0000000189914EF4-0x0000000189914FB8
		private static bool cmpRtfBoolE(Operator.Op op, object val1, object val2) => default; // 0x00000001899157C0-0x0000000189915860
		private static bool cmpBoolStringO(Operator.Op op, object val1, object val2) => default; // 0x0000000189914FB8-0x0000000189915094
		private static bool cmpRtfBoolO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915860-0x0000000189915904
		private static bool cmpNumberNumber(Operator.Op op, double n1, double n2) => default; // 0x000000018991516C-0x00000001899151C0
		private static bool cmpNumberNumberO(Operator.Op op, double n1, double n2) => default; // 0x0000000189915094-0x00000001899150C8
		private static bool cmpNumberNumber(Operator.Op op, object val1, object val2) => default; // 0x00000001899150C8-0x000000018991516C
		private static bool cmpStringNumber(Operator.Op op, object val1, object val2) => default; // 0x0000000189915DA8-0x0000000189915E7C
		private static bool cmpRtfNumber(Operator.Op op, object val1, object val2) => default; // 0x0000000189915904-0x00000001899159A0
		private static bool cmpStringStringE(Operator.Op op, string n1, string n2) => default; // 0x0000000189915E7C-0x0000000189915EA8
		private static bool cmpStringStringE(Operator.Op op, object val1, object val2) => default; // 0x0000000189915EA8-0x0000000189915F54
		private static bool cmpRtfStringE(Operator.Op op, object val1, object val2) => default; // 0x0000000189915C48-0x0000000189915CE8
		private static bool cmpRtfRtfE(Operator.Op op, object val1, object val2) => default; // 0x0000000189915B3C-0x0000000189915BB4
		private static bool cmpStringStringO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915F54-0x0000000189916034
		private static bool cmpRtfStringO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915CE8-0x0000000189915DA8
		private static bool cmpRtfRtfO(Operator.Op op, object val1, object val2) => default; // 0x0000000189915BB4-0x0000000189915C48
		public override XPathNodeIterator Clone() => default; // 0x0000000189913E40-0x0000000189913EA0
		private static string Rtf(object o) => default; // 0x000000018991403C-0x000000018991409C
	}

	internal sealed class MergeFilterQuery : CacheOutputQuery // TypeDefIndex: 43092
	{
		// Fields
		private Query _child; // 0x28
	
		// Constructors
		public MergeFilterQuery() {} // Dummy constructor
		public MergeFilterQuery(Query input, Query child) {} // 0x0000000189916144-0x0000000189916174
		private MergeFilterQuery(MergeFilterQuery other) {} // 0x0000000189916174-0x00000001899161BC
	
		// Methods
		public override void SetXsltContext(XsltContext xsltContext) {} // 0x0000000189916108-0x0000000189916144
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189916094-0x0000000189916108
		public override XPathNodeIterator Clone() => default; // 0x0000000189916034-0x0000000189916094
	}

	internal sealed class NamespaceQuery : BaseAxisQuery // TypeDefIndex: 43093
	{
		// Fields
		private bool _onNamespace; // 0x58
	
		// Constructors
		public NamespaceQuery() {} // Dummy constructor
		public NamespaceQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type) {} // 0x000000018990F82C-0x000000018990F83C
		private NamespaceQuery(NamespaceQuery other) {} // 0x000000018990F7F4-0x000000018990F82C
	
		// Methods
		public override void Reset() {} // 0x000000018990F7E8-0x000000018990F7F4
		public override XPathNavigator Advance() => default; // 0x00000001899161BC-0x000000018991627C
		public override bool matches(XPathNavigator e) => default; // 0x00000001899162DC-0x000000018991634C
		public override XPathNodeIterator Clone() => default; // 0x000000018991627C-0x00000001899162DC
	}

	internal sealed class NodeFunctions : ValueQuery // TypeDefIndex: 43094
	{
		// Fields
		private Query _arg; // 0x18
		private Function.FunctionType _funcType; // 0x20
		private XsltContext _xsltContext; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x000000018991665C-0x00000001899166C4 
	
		// Constructors
		public NodeFunctions() {} // Dummy constructor
		public NodeFunctions(Function.FunctionType funcType, Query arg) {} // 0x0000000189916644-0x000000018991665C
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x00000001899165E4-0x0000000189916644
		private XPathNavigator EvaluateArg(XPathNodeIterator context) => default; // 0x00000001899163E4-0x000000018991642C
		public override object Evaluate(XPathNodeIterator context) => default; // 0x000000018991642C-0x00000001899165E4
		public override XPathNodeIterator Clone() => default; // 0x000000018991634C-0x00000001899163E4
	}

	internal sealed class NumberFunctions : ValueQuery // TypeDefIndex: 43095
	{
		// Fields
		private Query _arg; // 0x18
		private Function.FunctionType _ftype; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public NumberFunctions() {} // Dummy constructor
		public NumberFunctions(Function.FunctionType ftype, Query arg) {} // 0x0000000189910284-0x00000001899102AC
		private NumberFunctions(NumberFunctions other) {} // 0x0000000189910234-0x0000000189910284
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x0000000189910220-0x0000000189910234
		internal static double Number(bool arg) => default; // 0x00000001899169D0-0x00000001899169E4
		internal static double Number(string arg) => default; // 0x00000001899169E4-0x0000000189916A30
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189916894-0x0000000189916950
		private double Number(XPathNodeIterator nodeIterator) => default; // 0x0000000189916A30-0x0000000189916BEC
		private double Sum(XPathNodeIterator nodeIterator) => default; // 0x0000000189916C5C-0x0000000189916CC8
		private double Floor(XPathNodeIterator nodeIterator) => default; // 0x0000000189916950-0x00000001899169D0
		private double Ceiling(XPathNodeIterator nodeIterator) => default; // 0x00000001899167B4-0x0000000189916834
		private double Round(XPathNodeIterator nodeIterator) => default; // 0x0000000189916BEC-0x0000000189916C5C
		public override XPathNodeIterator Clone() => default; // 0x0000000189916834-0x0000000189916894
	}

	internal sealed class NumericExpr : ValueQuery // TypeDefIndex: 43096
	{
		// Fields
		private Operator.Op _op; // 0x18
		private Query _opnd1; // 0x20
		private Query _opnd2; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public NumericExpr() {} // Dummy constructor
		public NumericExpr(Operator.Op op, Query opnd1, Query opnd2) {} // 0x0000000189916E44-0x0000000189916F50
		private NumericExpr(NumericExpr other) {} // 0x0000000189914BBC-0x0000000189914C24
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x000000018991409C-0x00000001899140E0
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189916D28-0x0000000189916E04
		private static double GetValue(Operator.Op op, double n1, double n2) => default; // 0x0000000189916E04-0x0000000189916E44
		public override XPathNodeIterator Clone() => default; // 0x0000000189916CC8-0x0000000189916D28
	}

	internal class Operand : AstNode // TypeDefIndex: 43097
	{
		// Fields
		private XPathResultType _type; // 0x10
		private object _val; // 0x18
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public object OperandValue { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public Operand() {} // Dummy constructor
		public Operand(string val) {} // 0x0000000189916F70-0x0000000189916F84
		public Operand(double val) {} // 0x0000000189916F84-0x0000000189916FE4
	}

	internal sealed class OperandQuery : ValueQuery // TypeDefIndex: 43098
	{
		// Fields
		internal object val; // 0x18
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000189916F64-0x0000000189916F70 
	
		// Constructors
		public OperandQuery() {} // Dummy constructor
		public OperandQuery(object val) {} // 0x0000000189916F50-0x0000000189916F64
	
		// Methods
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000181041090-0x00000001810410A0
		public override XPathNodeIterator Clone() => default; // 0x000000018339AE90-0x000000018339AEA0
	}

	internal class Operator : AstNode // TypeDefIndex: 43100
	{
		// Fields
		private static Op[] s_invertOp; // 0x00
		private Op _opType; // 0x10
		private AstNode _opnd1; // 0x18
		private AstNode _opnd2; // 0x20
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override XPathResultType ReturnType { get => default; } // 0x00000001899170D4-0x00000001899170F0 
		public Op OperatorType { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public AstNode Operand1 { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public AstNode Operand2 { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		public enum Op // TypeDefIndex: 43099
		{
			INVALID = 0,
			OR = 1,
			AND = 2,
			EQ = 3,
			NE = 4,
			LT = 5,
			LE = 6,
			GT = 7,
			GE = 8,
			PLUS = 9,
			MINUS = 10,
			MUL = 11,
			DIV = 12,
			MOD = 13,
			UNION = 14
		}
	
		// Constructors
		public Operator() {} // Dummy constructor
		public Operator(Op op, AstNode opnd1, AstNode opnd2) {} // 0x0000000182959C60-0x0000000182959C90
		static Operator() {} // 0x0000000189917048-0x00000001899170D4
	
		// Methods
		public static Op InvertOperator(Op op) => default; // 0x0000000189916FE4-0x0000000189917048
	}

	internal sealed class ParentQuery : CacheAxisQuery // TypeDefIndex: 43101
	{
		// Constructors
		public ParentQuery() {} // Dummy constructor
		public ParentQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) {} // 0x00000001899171DC-0x00000001899171EC
		private ParentQuery(ParentQuery other) {} // 0x00000001899171EC-0x00000001899171F4
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189917150-0x00000001899171DC
		public override XPathNodeIterator Clone() => default; // 0x00000001899170F0-0x0000000189917150
	}

	internal class PreSiblingQuery : CacheAxisQuery // TypeDefIndex: 43102
	{
		// Properties
		public override QueryProps Properties { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
	
		// Constructors
		public PreSiblingQuery() {} // Dummy constructor
		public PreSiblingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) {} // 0x00000001899171DC-0x00000001899171EC
		protected PreSiblingQuery(PreSiblingQuery other) {} // 0x00000001899171EC-0x00000001899171F4
	
		// Methods
		private static bool NotVisited(XPathNavigator nav, List<XPathNavigator> parentStk) => default; // 0x0000000189918888-0x0000000189918958
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189918644-0x0000000189918888
		public override XPathNodeIterator Clone() => default; // 0x00000001899185E4-0x0000000189918644
	}

	internal sealed class PrecedingQuery : BaseAxisQuery // TypeDefIndex: 43103
	{
		// Fields
		private XPathNodeIterator _workIterator; // 0x58
		private ClonableStack<XPathNavigator> _ancestorStk; // 0x60
	
		// Properties
		public override QueryProps Properties { get => default; } // 0x0000000183D569B0-0x0000000183D569C0 
	
		// Constructors
		public PrecedingQuery() {} // Dummy constructor
		public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest) {} // 0x0000000189918C64-0x0000000189918D18
		private PrecedingQuery(PrecedingQuery other) {} // 0x0000000189918D18-0x0000000189918DA8
	
		// Methods
		public override void Reset() {} // 0x0000000189918C04-0x0000000189918C64
		public override XPathNavigator Advance() => default; // 0x0000000189918958-0x0000000189918BA4
		public override XPathNodeIterator Clone() => default; // 0x0000000189918BA4-0x0000000189918C04
	}

	internal enum QueryProps // TypeDefIndex: 43104
	{
		None = 0,
		Position = 1,
		Count = 2,
		Cached = 4,
		Reverse = 8,
		Merge = 16
	}

	[DebuggerDisplay("{ToString()}")]
	internal abstract class Query : ResetableIterator // TypeDefIndex: 43105
	{
		// Properties
		public override int Count { get; } // 0x0000000189923904-0x0000000189923990 
		public abstract XPathResultType StaticType { get; }
		public virtual QueryProps Properties { get; } // 0x0000000183D55B10-0x0000000183D55B20 
	
		// Constructors
		public Query() {} // 0x0000000183D51990-0x0000000183D519A0
		protected Query(Query other) {} // 0x00000001899238E0-0x0000000189923904
	
		// Methods
		public override bool MoveNext() => default; // 0x00000001899238C4-0x00000001899238E0
		public virtual void SetXsltContext(XsltContext context) {} // 0x000000018350B670-0x000000018350B680
		public abstract object Evaluate(XPathNodeIterator nodeIterator);
		public abstract XPathNavigator Advance();
		public static Query Clone(Query input) => default; // 0x0000000189923540-0x0000000189923590
		protected static XPathNodeIterator Clone(XPathNodeIterator input) => default; // 0x0000000189923590-0x00000001899235A4
		protected static XPathNavigator Clone(XPathNavigator input) => default; // 0x00000001899235A4-0x00000001899235BC
		public static bool Insert(List<XPathNavigator> buffer, XPathNavigator nav) => default; // 0x0000000189923768-0x00000001899238C4
		private static int GetMedian(int l, int r) => default; // 0x0000000183D75930-0x0000000183D75940
		public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r) => default; // 0x00000001899235BC-0x00000001899236BC
		protected XPathResultType GetXPathType(object value) => default; // 0x00000001899236BC-0x0000000189923768
	}

	internal sealed class QueryBuilder // TypeDefIndex: 43108
	{
		// Fields
		private string _query; // 0x10
		private bool _allowVar; // 0x18
		private bool _allowKey; // 0x19
		private bool _allowCurrent; // 0x1A
		private bool _needContext; // 0x1B
		private BaseAxisQuery _firstInput; // 0x20
		private int _parseDepth; // 0x28
	
		// Nested types
		private enum Flags // TypeDefIndex: 43106
		{
			None = 0,
			SmartDesc = 1,
			PosFilter = 2,
			Filter = 4
		}
	
		private enum Props // TypeDefIndex: 43107
		{
			None = 0,
			PosFilter = 1,
			HasPosition = 2,
			HasLast = 4,
			NonFlat = 8
		}
	
		// Constructors
		public QueryBuilder() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private void Reset() {} // 0x0000000183D75920-0x0000000183D75930
		private Query ProcessAxis(MS.Internal.Xml.XPath.Axis root, Flags flags, out Props props) {
			props = default;
			return default;
		} // 0x0000000189921DC0-0x00000001899224F8
		private static bool CanBeNumber(Query q) => default; // 0x0000000189921C58-0x0000000189921C9C
		private Query ProcessFilter(MS.Internal.Xml.XPath.Filter root, Flags flags, out Props props) {
			props = default;
			return default;
		} // 0x00000001899224F8-0x0000000189922978
		private Query ProcessOperator(Operator root, out Props props) {
			props = default;
			return default;
		} // 0x0000000189923290-0x0000000189923480
		private Query ProcessVariable(Variable root) => default; // 0x0000000189923480-0x0000000189923540
		private Query ProcessFunction(Function root, out Props props) {
			props = default;
			return default;
		} // 0x0000000189922978-0x0000000189922F88
		private List<Query> ProcessArguments(List<AstNode> args, out Props props) {
			props = default;
			return default;
		} // 0x0000000189921C9C-0x0000000189921DC0
		private Query ProcessNode(AstNode root, Flags flags, out Props props) {
			props = default;
			return default;
		} // 0x0000000189922F88-0x0000000189923290
		private Query Build(AstNode root, string query) => default; // 0x0000000189921BDC-0x0000000189921C20
		internal Query Build(string query, bool allowVar, bool allowKey) => default; // 0x0000000189921B58-0x0000000189921BDC
		internal Query Build(string query, out bool needContext) {
			needContext = default;
			return default;
		} // 0x0000000189921C20-0x0000000189921C58
	}

	internal abstract class ResetableIterator : XPathNodeIterator // TypeDefIndex: 43109
	{
		// Properties
		public abstract int CurrentPosition { get; }
	
		// Constructors
		public ResetableIterator() {} // 0x0000000183D51990-0x0000000183D519A0
		protected ResetableIterator(ResetableIterator other) {} // 0x00000001899238E0-0x0000000189923904
	
		// Methods
		protected void ResetCount() {} // 0x0000000183D51990-0x0000000183D519A0
		public abstract void Reset();
	}

	internal sealed class ReversePositionQuery : ForwardPositionQuery // TypeDefIndex: 43110
	{
		// Properties
		public override int CurrentPosition { get => default; } // 0x00000001899239F0-0x0000000189923A34 
		public override QueryProps Properties { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
	
		// Constructors
		public ReversePositionQuery() {} // Dummy constructor
		public ReversePositionQuery(Query input) {} // 0x0000000189911A0C-0x0000000189911A14
		private ReversePositionQuery(ReversePositionQuery other) {} // 0x0000000189911A04-0x0000000189911A0C
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x0000000189923990-0x00000001899239F0
	}

	internal class Root : AstNode // TypeDefIndex: 43111
	{
		// Properties
		public override AstType Type { get => default; } // 0x0000000183D51110-0x0000000183D51120 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public Root() {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class StringFunctions : ValueQuery // TypeDefIndex: 43112
	{
		// Fields
		private Function.FunctionType _funcType; // 0x18
		private IList<Query> _argList; // 0x20
		private static readonly CompareInfo s_compareInfo; // 0x00
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000189924A88-0x0000000189924AAC 
	
		// Constructors
		public StringFunctions() {} // Dummy constructor
		public StringFunctions(Function.FunctionType funcType, IList<Query> argList) {} // 0x0000000189924960-0x0000000189924978
		private StringFunctions(StringFunctions other) {} // 0x0000000189924978-0x0000000189924A88
		static StringFunctions() {} // 0x00000001899248E4-0x0000000189924960
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x0000000189923FD4-0x000000018992406C
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x0000000189923C9C-0x0000000189923E2C
		internal static string toString(double num) => default; // 0x0000000189924D14-0x0000000189924D60
		internal static string toString(bool b) => default; // 0x0000000189924AAC-0x0000000189924AF4
		private string toString(XPathNodeIterator nodeIterator) => default; // 0x0000000189924AF4-0x0000000189924D14
		private string Concat(XPathNodeIterator nodeIterator) => default; // 0x0000000189923A94-0x0000000189923B90
		private bool StartsWith(XPathNodeIterator nodeIterator) => default; // 0x000000018992406C-0x0000000189924168
		private bool Contains(XPathNodeIterator nodeIterator) => default; // 0x0000000189923B90-0x0000000189923C9C
		private string SubstringBefore(XPathNodeIterator nodeIterator) => default; // 0x0000000189924390-0x00000001899244E8
		private string SubstringAfter(XPathNodeIterator nodeIterator) => default; // 0x000000018992422C-0x0000000189924390
		private string Substring(XPathNodeIterator nodeIterator) => default; // 0x00000001899244E8-0x0000000189924718
		private double StringLength(XPathNodeIterator nodeIterator) => default; // 0x0000000189924168-0x000000018992422C
		private string Normalize(XPathNodeIterator nodeIterator) => default; // 0x0000000189923E2C-0x0000000189923FD4
		private string Translate(XPathNodeIterator nodeIterator) => default; // 0x0000000189924718-0x00000001899248E4
		public override XPathNodeIterator Clone() => default; // 0x0000000189923A34-0x0000000189923A94
	}

	internal sealed class UnionExpr : Query // TypeDefIndex: 43113
	{
		// Fields
		internal Query qy1; // 0x18
		internal Query qy2; // 0x20
		private bool _advance1; // 0x28
		private bool _advance2; // 0x29
		private XPathNavigator _currentNode; // 0x30
		private XPathNavigator _nextNode; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override XPathNavigator Current { get => default; } // 0x0000000181003830-0x0000000181003840 
		public override int CurrentPosition { get => default; } // 0x00000001899250D0-0x000000018992511C 
	
		// Constructors
		public UnionExpr() {} // Dummy constructor
		public UnionExpr(Query query1, Query query2) {} // 0x0000000189925098-0x00000001899250D0
		private UnionExpr(UnionExpr other) {} // 0x0000000189924FF8-0x0000000189925098
	
		// Methods
		public override void Reset() {} // 0x0000000189924FA8-0x0000000189924FF8
		public override void SetXsltContext(XsltContext xsltContext) {} // 0x000000018990FE2C-0x000000018990FE70
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189924EB8-0x0000000189924F18
		private XPathNavigator ProcessSamePosition(XPathNavigator result) => default; // 0x0000000189924F80-0x0000000189924FA8
		private XPathNavigator ProcessBeforePosition(XPathNavigator res1, XPathNavigator res2) => default; // 0x0000000189924F4C-0x0000000189924F80
		private XPathNavigator ProcessAfterPosition(XPathNavigator res1, XPathNavigator res2) => default; // 0x0000000189924F18-0x0000000189924F4C
		public override XPathNavigator Advance() => default; // 0x0000000189924D60-0x0000000189924E58
		public override XPathNodeIterator Clone() => default; // 0x0000000189924E58-0x0000000189924EB8
	}

	internal abstract class ValueQuery : Query // TypeDefIndex: 43114
	{
		// Properties
		public sealed override XPathNavigator Current { get; } // 0x00000001899251C4-0x00000001899251FC 
		public sealed override int CurrentPosition { get; } // 0x000000018992518C-0x00000001899251C4 
		public sealed override int Count { get; } // 0x0000000189925154-0x000000018992518C 
	
		// Constructors
		public ValueQuery() {} // 0x0000000183D51990-0x0000000183D519A0
		protected ValueQuery(ValueQuery other) {} // 0x00000001899238E0-0x0000000189923904
	
		// Methods
		public sealed override void Reset() {} // 0x000000018350B670-0x000000018350B680
		public sealed override XPathNavigator Advance() => default; // 0x000000018992511C-0x0000000189925154
	}

	internal class Variable : AstNode // TypeDefIndex: 43115
	{
		// Fields
		private string _localname; // 0x10
		private string _prefix; // 0x18
	
		// Properties
		public override AstType Type { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
		public override XPathResultType ReturnType { get => default; } // 0x0000000183D51100-0x0000000183D51110 
		public string Localname { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string Prefix { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public Variable() {} // Dummy constructor
		public Variable(string name, string prefix) {} // 0x0000000182676770-0x00000001826767A0
	}

	internal sealed class VariableQuery : ExtensionQuery // TypeDefIndex: 43116
	{
		// Fields
		private IXsltContextVariable _variable; // 0x38
	
		// Properties
		public override XPathResultType StaticType { get => default; } // 0x0000000189925448-0x00000001899254A0 
	
		// Constructors
		public VariableQuery() {} // Dummy constructor
		public VariableQuery(string name, string prefix) {} // 0x00000001899253F4-0x0000000189925408
		private VariableQuery(VariableQuery other) {} // 0x0000000189925408-0x0000000189925448
	
		// Methods
		public override void SetXsltContext(XsltContext context) {} // 0x00000001899252E4-0x00000001899253F4
		public override object Evaluate(XPathNodeIterator nodeIterator) => default; // 0x000000018992525C-0x00000001899252E4
		public override XPathNodeIterator Clone() => default; // 0x00000001899251FC-0x000000018992525C
	}

	internal sealed class XPathAncestorQuery : CacheAxisQuery // TypeDefIndex: 43117
	{
		// Fields
		private bool _matchSelf; // 0x60
	
		// Properties
		public override int CurrentPosition { get => default; } // 0x000000018992565C-0x00000001899256A0 
		public override QueryProps Properties { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
	
		// Constructors
		public XPathAncestorQuery() {} // Dummy constructor
		public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf) {} // 0x00000001899255F4-0x0000000189925624
		private XPathAncestorQuery(XPathAncestorQuery other) {} // 0x0000000189925624-0x000000018992565C
	
		// Methods
		public override object Evaluate(XPathNodeIterator context) => default; // 0x0000000189925500-0x00000001899255F4
		public override XPathNodeIterator Clone() => default; // 0x00000001899254A0-0x0000000189925500
	}

	[DebuggerDisplay("Position={CurrentPosition}, Current={debuggerDisplayProxy, nq}")]
	internal class XPathArrayIterator : ResetableIterator // TypeDefIndex: 43118
	{
		// Fields
		protected IList list; // 0x18
		protected int index; // 0x20
	
		// Properties
		public override XPathNavigator Current { get => default; } // 0x00000001899258A8-0x0000000189925984 
		public override int CurrentPosition { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public override int Count { get => default; } // 0x0000000189925888-0x00000001899258A8 
	
		// Constructors
		public XPathArrayIterator() {} // Dummy constructor
		public XPathArrayIterator(XPathArrayIterator it) {} // 0x0000000189925788-0x00000001899257C4
		public XPathArrayIterator(XPathNodeIterator nodeIterator) {} // 0x00000001899257C4-0x0000000189925888
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x00000001899256A0-0x0000000189925700
		public override bool MoveNext() => default; // 0x0000000189925748-0x0000000189925788
		public override void Reset() {} // 0x0000000183D4E2C0-0x0000000183D4E2D0
		public override IEnumerator GetEnumerator() => default; // 0x0000000189925700-0x0000000189925748
	}

	internal abstract class XPathAxisIterator : XPathNodeIterator // TypeDefIndex: 43119
	{
		// Fields
		internal XPathNavigator nav; // 0x18
		internal XPathNodeType type; // 0x20
		internal string name; // 0x28
		internal string uri; // 0x30
		internal int position; // 0x38
		internal bool matchSelf; // 0x3C
		internal bool first; // 0x3D
	
		// Properties
		public override XPathNavigator Current { get; } // 0x0000000181041090-0x00000001810410A0 
		public override int CurrentPosition { get; } // 0x0000000183D4EC30-0x0000000183D4EC40 
		protected virtual bool Matches { get; } // 0x0000000189925B68-0x0000000189925C7C 
	
		// Constructors
		protected XPathAxisIterator() {} // Dummy constructor
		public XPathAxisIterator(XPathNavigator nav, bool matchSelf) {} // 0x0000000189925984-0x00000001899259B0
		public XPathAxisIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf) {} // 0x00000001899259B0-0x00000001899259E0
		public XPathAxisIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) {} // 0x0000000189925A6C-0x0000000189925B68
		public XPathAxisIterator(XPathAxisIterator it) {} // 0x00000001899259E0-0x0000000189925A6C
	}

	internal class XPathChildIterator : XPathAxisIterator // TypeDefIndex: 43120
	{
		// Constructors
		public XPathChildIterator() {} // Dummy constructor
		public XPathChildIterator(XPathNavigator nav, XPathNodeType type) {} // 0x0000000189925D40-0x0000000189925D5C
		public XPathChildIterator(XPathNavigator nav, string name, string namespaceURI) {} // 0x0000000189925D5C-0x0000000189925D78
		public XPathChildIterator(XPathChildIterator it) {} // 0x0000000189925D38-0x0000000189925D40
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x0000000189925C7C-0x0000000189925CDC
		public override bool MoveNext() => default; // 0x0000000189925CDC-0x0000000189925D38
	}

	internal class XPathDescendantIterator : XPathAxisIterator // TypeDefIndex: 43121
	{
		// Fields
		private int _level; // 0x40
	
		// Constructors
		public XPathDescendantIterator() {} // Dummy constructor
		public XPathDescendantIterator(XPathNavigator nav, XPathNodeType type, bool matchSelf) {} // 0x0000000189925EAC-0x0000000189925EBC
		public XPathDescendantIterator(XPathNavigator nav, string name, string namespaceURI, bool matchSelf) {} // 0x0000000189925EBC-0x0000000189925ED4
		public XPathDescendantIterator(XPathDescendantIterator it) {} // 0x0000000189925E78-0x0000000189925EAC
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x0000000189925D78-0x0000000189925DD8
		public override bool MoveNext() => default; // 0x0000000189925DD8-0x0000000189925E78
	}

	internal sealed class XPathEmptyIterator : ResetableIterator // TypeDefIndex: 43122
	{
		// Fields
		public static XPathEmptyIterator Instance; // 0x00
	
		// Properties
		public override XPathNavigator Current { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int CurrentPosition { get => default; } // 0x0000000181002730-0x0000000181002740 
		public override int Count { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		private XPathEmptyIterator() {} // 0x0000000183D51990-0x0000000183D519A0
		static XPathEmptyIterator() {} // 0x0000000189927FE4-0x000000018992804C
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x000000018339AE90-0x000000018339AEA0
		public override bool MoveNext() => default; // 0x000000018115F4C0-0x000000018115F530
		public override void Reset() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class XPathParser // TypeDefIndex: 43124
	{
		// Fields
		private XPathScanner _scanner; // 0x10
		private int _parseDepth; // 0x18
		private static readonly XPathResultType[] s_temparray1; // 0x00
		private static readonly XPathResultType[] s_temparray2; // 0x08
		private static readonly XPathResultType[] s_temparray3; // 0x10
		private static readonly XPathResultType[] s_temparray4; // 0x18
		private static readonly XPathResultType[] s_temparray5; // 0x20
		private static readonly XPathResultType[] s_temparray6; // 0x28
		private static readonly XPathResultType[] s_temparray7; // 0x30
		private static readonly XPathResultType[] s_temparray8; // 0x38
		private static readonly XPathResultType[] s_temparray9; // 0x40
		private static Dictionary<string, ParamInfo> s_functionTable; // 0x48
		private static Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> s_AxesTable; // 0x50
	
		// Nested types
		private class ParamInfo // TypeDefIndex: 43123
		{
			// Fields
			private Function.FunctionType _ftype; // 0x10
			private int _minargs; // 0x14
			private int _maxargs; // 0x18
			private XPathResultType[] _argTypes; // 0x20
	
			// Properties
			public Function.FunctionType FType { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
			public int Minargs { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
			public int Maxargs { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
			public XPathResultType[] ArgTypes { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
			// Constructors
			public ParamInfo() {} // Dummy constructor
			internal ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) {} // 0x0000000189921B38-0x0000000189921B58
		}
	
		// Constructors
		public XPathParser() {} // Dummy constructor
		private XPathParser(XPathScanner scanner) {} // 0x000000018426FEE0-0x000000018426FEF0
		static XPathParser() {} // 0x000000018992BE80-0x000000018992C1E8
	
		// Methods
		public static AstNode ParseXPathExpression(string xpathExpression) => default; // 0x000000018992BD40-0x000000018992BE18
		private AstNode ParseExpression(AstNode qyInput) => default; // 0x000000018992A79C-0x000000018992A7F8
		private AstNode ParseOrExpr(AstNode qyInput) => default; // 0x000000018992B390-0x000000018992B470
		private AstNode ParseAndExpr(AstNode qyInput) => default; // 0x000000018992A5E4-0x000000018992A6C4
		private AstNode ParseEqualityExpr(AstNode qyInput) => default; // 0x000000018992A6C4-0x000000018992A79C
		private AstNode ParseRelationalExpr(AstNode qyInput) => default; // 0x000000018992B814-0x000000018992B910
		private AstNode ParseAdditiveExpr(AstNode qyInput) => default; // 0x000000018992A50C-0x000000018992A5E4
		private AstNode ParseMultiplicativeExpr(AstNode qyInput) => default; // 0x000000018992AF54-0x000000018992B078
		private AstNode ParseUnaryExpr(AstNode qyInput) => default; // 0x000000018992BB44-0x000000018992BC24
		private AstNode ParseUnionExpr(AstNode qyInput) => default; // 0x000000018992BC24-0x000000018992BD40
		private static bool IsNodeType(XPathScanner scaner) => default; // 0x000000018992A380-0x000000018992A44C
		private AstNode ParsePathExpr(AstNode qyInput) => default; // 0x000000018992B470-0x000000018992B564
		private AstNode ParseFilterExpr(AstNode qyInput) => default; // 0x000000018992A7F8-0x000000018992A8A8
		private AstNode ParsePredicate(AstNode qyInput) => default; // 0x000000018992B564-0x000000018992B5D4
		private AstNode ParseLocationPath(AstNode qyInput) => default; // 0x000000018992A8A8-0x000000018992A9D0
		private AstNode ParseRelativeLocationPath(AstNode qyInput) => default; // 0x000000018992B910-0x000000018992B9C4
		private static bool IsStep(XPathScanner.LexKind lexKind) => default; // 0x000000018992A4C8-0x000000018992A4EC
		private AstNode ParseStep(AstNode qyInput) => default; // 0x000000018992B9C4-0x000000018992BB44
		private AstNode ParseNodeTest(AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, XPathNodeType nodeType) => default; // 0x000000018992B078-0x000000018992B390
		private static bool IsPrimaryExpr(XPathScanner scanner) => default; // 0x000000018992A44C-0x000000018992A4C8
		private AstNode ParsePrimaryExpr(AstNode qyInput) => default; // 0x000000018992B5D4-0x000000018992B814
		private AstNode ParseMethod(AstNode qyInput) => default; // 0x000000018992A9D0-0x000000018992AF54
		private void CheckToken(XPathScanner.LexKind t) {} // 0x00000001899293C8-0x0000000189929424
		private void PassToken(XPathScanner.LexKind t) {} // 0x000000018992BE18-0x000000018992BE38
		private void NextLex() {} // 0x000000018992A4EC-0x000000018992A50C
		private bool TestOp(string op) => default; // 0x000000018992BE38-0x000000018992BE80
		private void CheckNodeSet(XPathResultType t) {} // 0x0000000189929368-0x00000001899293C8
		private static Dictionary<string, ParamInfo> CreateFunctionTable() => default; // 0x00000001899296A0-0x000000018992A2B0
		private static Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable() => default; // 0x0000000189929424-0x00000001899296A0
		private MS.Internal.Xml.XPath.Axis.AxisType GetAxis() => default; // 0x000000018992A2B0-0x000000018992A380
	}

	internal sealed class XPathScanner // TypeDefIndex: 43126
	{
		// Fields
		private string _xpathExpr; // 0x10
		private int _xpathExprIndex; // 0x18
		private LexKind _kind; // 0x1C
		private char _currentChar; // 0x20
		private string _name; // 0x28
		private string _prefix; // 0x30
		private string _stringValue; // 0x38
		private double _numberValue; // 0x40
		private bool _canBeFunction; // 0x48
		private XmlCharType _xmlCharType; // 0x50
	
		// Properties
		public string SourceText { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		private char CurrentChar { get => default; } // 0x0000000183D75960-0x0000000183D75970 
		public LexKind Kind { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public string Name { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public string Prefix { get => default; } // 0x0000000181003830-0x0000000181003840 
		public string StringValue { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		public double NumberValue { get => default; } // 0x0000000183D4F200-0x0000000183D4F210 
		public bool CanBeFunction { get => default; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 
	
		// Nested types
		public enum LexKind // TypeDefIndex: 43125
		{
			Bang = 33,
			Quote = 34,
			Dollar = 36,
			Apos = 39,
			LParens = 40,
			RParens = 41,
			Star = 42,
			Plus = 43,
			Comma = 44,
			Minus = 45,
			Dot = 46,
			Slash = 47,
			Lt = 60,
			Eq = 61,
			Gt = 62,
			At = 64,
			And = 65,
			DotDot = 68,
			Eof = 69,
			Ge = 71,
			Le = 76,
			Ne = 78,
			Or = 79,
			SlashSlash = 83,
			LBracket = 91,
			RBracket = 93,
			Axe = 97,
			Number = 100,
			Name = 110,
			String = 115,
			Union = 124
		}
	
		// Constructors
		public XPathScanner() {} // Dummy constructor
		public XPathScanner(string xpathExpr) {} // 0x000000018992C9E0-0x000000018992CA90
	
		// Methods
		private bool NextChar() => default; // 0x000000018992C1E8-0x000000018992C238
		private void SkipSpace() {} // 0x000000018992C9A4-0x000000018992C9E0
		public bool NextLex() => default; // 0x000000018992C238-0x000000018992C738
		private double ScanNumber() => default; // 0x000000018992C844-0x000000018992C8F8
		private double ScanFraction() => default; // 0x000000018992C738-0x000000018992C7D0
		private string ScanString() => default; // 0x000000018992C8F8-0x000000018992C9A4
		private string ScanName() => default; // 0x000000018992C7D0-0x000000018992C844
	}

	internal class XPathSelectionIterator : ResetableIterator // TypeDefIndex: 43127
	{
		// Fields
		private XPathNavigator _nav; // 0x18
		private Query _query; // 0x20
		private int _position; // 0x28
	
		// Properties
		public override int Count { get => default; } // 0x000000018992CC8C-0x000000018992CCB0 
		public override XPathNavigator Current { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public override int CurrentPosition { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
		// Constructors
		public XPathSelectionIterator() {} // Dummy constructor
		internal XPathSelectionIterator(XPathNavigator nav, Query query) {} // 0x000000018992CB88-0x000000018992CBD8
		protected XPathSelectionIterator(XPathSelectionIterator it) {} // 0x000000018992CBD8-0x000000018992CC8C
	
		// Methods
		public override void Reset() {} // 0x000000018992CB64-0x000000018992CB88
		public override bool MoveNext() => default; // 0x000000018992CAF0-0x000000018992CB64
		public override XPathNodeIterator Clone() => default; // 0x000000018992CA90-0x000000018992CAF0
	}

	internal sealed class XPathSelfQuery : BaseAxisQuery // TypeDefIndex: 43128
	{
		// Constructors
		public XPathSelfQuery() {} // Dummy constructor
		public XPathSelfQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type) {} // 0x000000018990F82C-0x000000018990F83C
		private XPathSelfQuery(XPathSelfQuery other) {} // 0x00000001899139B8-0x00000001899139C0
	
		// Methods
		public override XPathNavigator Advance() => default; // 0x000000018992CCB0-0x000000018992CD14
		public override XPathNodeIterator Clone() => default; // 0x000000018992CD14-0x000000018992CD74
	}

	internal class XPathSingletonIterator : ResetableIterator // TypeDefIndex: 43129
	{
		// Fields
		private XPathNavigator _nav; // 0x18
		private int _position; // 0x20
	
		// Properties
		public override XPathNavigator Current { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public override int CurrentPosition { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public override int Count { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public XPathSingletonIterator() {} // Dummy constructor
		public XPathSingletonIterator(XPathNavigator nav) {} // 0x0000000189916F50-0x0000000189916F64
		public XPathSingletonIterator(XPathNavigator nav, bool moved) {} // 0x000000018992CE3C-0x000000018992D2CC
		public XPathSingletonIterator(XPathSingletonIterator it) {} // 0x000000018992CDE8-0x000000018992CE3C
	
		// Methods
		public override XPathNodeIterator Clone() => default; // 0x000000018992CD74-0x000000018992CDD4
		public override bool MoveNext() => default; // 0x000000018992CDD4-0x000000018992CDE8
		public override void Reset() {} // 0x0000000183D4E2C0-0x0000000183D4E2D0
	}
}

namespace System
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true)]
	internal class MonoTODOAttribute : Attribute // TypeDefIndex: 42413
	{
		// Constructors
		public MonoTODOAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class LocalAppContextSwitches // TypeDefIndex: 42414
	{
		// Fields
		public static readonly bool IgnoreEmptyKeySequences; // 0x00
		public static readonly bool DontThrowOnInvalidSurrogatePairs; // 0x01
	}
}
