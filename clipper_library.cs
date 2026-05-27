/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

// Image 76: clipper_library.dll - Assembly: clipper_library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58838-58863
[assembly: AssemblyCompany("Angus Johnson")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright \u00A9 Angus Johnson 2010-14")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("clipper_library")]
[assembly: AssemblyTitle("clipper_library")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: Guid("51a6bdca-bc4e-4b2c-ae69-36e2497204f2")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: TargetFramework(".NETFramework,Version=v4.0", FrameworkDisplayName = ".NET Framework 4")]

namespace ClipperLib
{
	public struct DoublePoint // TypeDefIndex: 58839
	{
		// Fields
		public double X; // 0x00
		public double Y; // 0x08
	
		// Constructors
		public DoublePoint(double x = 0 /* Metadata: 0x01FDC705 */, double y = 0 /* Metadata: 0x01FDC70D */) {
			X = default;
			Y = default;
		} // 0x0000000183D50BD0-0x0000000183D50BE0
		public DoublePoint(DoublePoint dp) {
			X = default;
			Y = default;
		} // 0x0000000183D50BC0-0x0000000183D50BD0
	}

	public class PolyNode // TypeDefIndex: 58840
	{
		// Fields
		internal PolyNode m_Parent; // 0x10
		internal List<IntPoint> m_polygon; // 0x18
		internal int m_Index; // 0x20
		internal JoinType m_jointype; // 0x24
		internal EndType m_endtype; // 0x28
		internal List<PolyNode> m_Childs; // 0x30
	
		// Properties
		public int ChildCount { get => default; } // 0x0000000185582648-0x0000000185582688 
		public List<PolyNode> Childs { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public PolyNode() {} // 0x0000000185582588-0x0000000185582648
	
		// Methods
		internal void AddChild(PolyNode Child) {} // 0x0000000185582500-0x0000000185582588
	}

	internal struct Int128 // TypeDefIndex: 58841
	{
		// Fields
		private long hi; // 0x00
		private ulong lo; // 0x08
	
		// Constructors
		public Int128(long _hi, ulong _lo) {
			hi = default;
			lo = default;
		} // 0x0000000183D50C00-0x0000000183D50C10
	
		// Methods
		public static bool operator ==(Int128 val1, Int128 val2) => default; // 0x0000000185582314-0x00000001855823AC
		public override bool Equals(object obj) => default; // 0x00000001855821E4-0x0000000185582258
		public override int GetHashCode() => default; // 0x0000000183D50BE0-0x0000000183D50C00
		public static Int128 operator -(Int128 val) => default; // 0x00000001855823AC-0x00000001855823D8
		public static Int128 Int128Mul(long lhs, long rhs) => default; // 0x0000000185582258-0x0000000185582314
	}

	public struct IntPoint // TypeDefIndex: 58842
	{
		// Fields
		public long X; // 0x00
		public long Y; // 0x08
	
		// Constructors
		public IntPoint(long X, long Y) {
			this.X = default;
			this.Y = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public IntPoint(double x, double y) {
			X = default;
			Y = default;
		} // 0x0000000183D50C10-0x0000000183D50C30
		public IntPoint(IntPoint pt) {
			X = default;
			Y = default;
		} // 0x0000000183D50BC0-0x0000000183D50BD0
	
		// Methods
		public static bool operator ==(IntPoint a, IntPoint b) => default; // 0x000000018558249C-0x00000001855824B4
		public static bool operator !=(IntPoint a, IntPoint b) => default; // 0x00000001855824B4-0x00000001855824CC
		public override bool Equals(object obj) => default; // 0x00000001855823D8-0x000000018558244C
		public override int GetHashCode() => default; // 0x000000018558244C-0x000000018558249C
	}

	public struct IntRect // TypeDefIndex: 58843
	{
		// Fields
		public long left; // 0x00
		public long top; // 0x08
		public long right; // 0x10
		public long bottom; // 0x18
	
		// Constructors
		public IntRect(long l, long t, long r, long b) {
			left = default;
			top = default;
			right = default;
			bottom = default;
		} // 0x0000000183D4EA20-0x0000000183D4EA40
	}

	public enum ClipType // TypeDefIndex: 58844
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3
	}

	public enum PolyType // TypeDefIndex: 58845
	{
		ptSubject = 0,
		ptClip = 1
	}

	public enum PolyFillType // TypeDefIndex: 58846
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3
	}

	public enum JoinType // TypeDefIndex: 58847
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2
	}

	public enum EndType // TypeDefIndex: 58848
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4
	}

	internal enum EdgeSide // TypeDefIndex: 58849
	{
		esLeft = 0,
		esRight = 1
	}

	internal enum Direction // TypeDefIndex: 58850
	{
		dRightToLeft = 0,
		dLeftToRight = 1
	}

	internal class TEdge // TypeDefIndex: 58851
	{
		// Fields
		internal IntPoint Bot; // 0x10
		internal IntPoint Curr; // 0x20
		internal IntPoint Top; // 0x30
		internal IntPoint Delta; // 0x40
		internal double Dx; // 0x50
		internal PolyType PolyTyp; // 0x58
		internal EdgeSide Side; // 0x5C
		internal int WindDelta; // 0x60
		internal int WindCnt; // 0x64
		internal int WindCnt2; // 0x68
		internal int OutIdx; // 0x6C
		internal TEdge Next; // 0x70
		internal TEdge Prev; // 0x78
		internal TEdge NextInLML; // 0x80
		internal TEdge NextInAEL; // 0x88
		internal TEdge PrevInAEL; // 0x90
		internal TEdge NextInSEL; // 0x98
		internal TEdge PrevInSEL; // 0xA0
	
		// Constructors
		public TEdge() {} // 0x000000018350B670-0x000000018350B680
	}

	public class IntersectNode // TypeDefIndex: 58852
	{
		// Fields
		internal TEdge Edge1; // 0x10
		internal TEdge Edge2; // 0x18
		internal IntPoint Pt; // 0x20
	
		// Constructors
		public IntersectNode() {} // 0x000000018350B670-0x000000018350B680
	}

	public class MyIntersectNodeSort : IComparer<ClipperLib.IntersectNode> // TypeDefIndex: 58853
	{
		// Constructors
		public MyIntersectNodeSort() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public int Compare(IntersectNode node1, IntersectNode node2) => default; // 0x00000001855824CC-0x0000000185582500
	}

	internal class LocalMinima // TypeDefIndex: 58854
	{
		// Fields
		internal long Y; // 0x10
		internal TEdge LeftBound; // 0x18
		internal TEdge RightBound; // 0x20
		internal LocalMinima Next; // 0x28
	
		// Constructors
		public LocalMinima() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class Scanbeam // TypeDefIndex: 58855
	{
		// Fields
		internal long Y; // 0x10
		internal Scanbeam Next; // 0x18
	
		// Constructors
		public Scanbeam() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class Maxima // TypeDefIndex: 58856
	{
		// Fields
		internal long X; // 0x10
		internal Maxima Next; // 0x18
		internal Maxima Prev; // 0x20
	
		// Constructors
		public Maxima() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class OutRec // TypeDefIndex: 58857
	{
		// Fields
		internal int Idx; // 0x10
		internal bool IsHole; // 0x14
		internal bool IsOpen; // 0x15
		internal OutRec FirstLeft; // 0x18
		internal OutPt Pts; // 0x20
		internal OutPt BottomPt; // 0x28
		internal PolyNode PolyNode; // 0x30
	
		// Constructors
		public OutRec() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class OutPt // TypeDefIndex: 58858
	{
		// Fields
		internal int Idx; // 0x10
		internal IntPoint Pt; // 0x18
		internal OutPt Next; // 0x28
		internal OutPt Prev; // 0x30
	
		// Constructors
		public OutPt() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class Join // TypeDefIndex: 58859
	{
		// Fields
		internal OutPt OutPt1; // 0x10
		internal OutPt OutPt2; // 0x18
		internal IntPoint OffPt; // 0x20
	
		// Constructors
		public Join() {} // 0x000000018350B670-0x000000018350B680
	}

	public class ClipperBase // TypeDefIndex: 58860
	{
		// Fields
		internal LocalMinima m_MinimaList; // 0x10
		internal LocalMinima m_CurrentLM; // 0x18
		internal List<List<TEdge>> m_edges; // 0x20
		internal Scanbeam m_Scanbeam; // 0x28
		internal List<OutRec> m_PolyOuts; // 0x30
		internal TEdge m_ActiveEdges; // 0x38
		internal bool m_UseFullRange; // 0x40
		internal bool m_HasOpenPaths; // 0x41
	
		// Properties
		public bool PreserveCollinear { get; set; } // 0x0000000183D4F7A0-0x0000000183D4F7B0 0x0000000183D4F7C0-0x0000000183D4F7D0
	
		// Constructors
		internal ClipperBase() {} // 0x0000000185578518-0x00000001855785B0
	
		// Methods
		internal static bool near_zero(double val) => default; // 0x00000001855785B0-0x00000001855785D0
		public void Swap(ref long val1, ref long val2) {} // 0x0000000183D50B50-0x0000000183D50B60
		internal static bool IsHorizontal(TEdge e) => default; // 0x00000001855775A0-0x00000001855775BC
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) => default; // 0x0000000185577EC4-0x0000000185577F78
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) => default; // 0x0000000185577E10-0x0000000185577EC4
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange) => default; // 0x0000000185577F78-0x000000018557803C
		public virtual void Clear() {} // 0x0000000185576B1C-0x0000000185576C68
		private void DisposeLocalMinimaList() {} // 0x0000000185576DD4-0x0000000185576E28
		private void RangeTest(IntPoint Pt, ref bool useFullRange) {} // 0x0000000185577BC8-0x0000000185577C9C
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) {} // 0x00000001855773B0-0x00000001855773F8
		private void InitEdge2(TEdge e, PolyType polyType) {} // 0x0000000185577338-0x00000001855773B0
		private TEdge FindNextLocMin(TEdge E) => default; // 0x0000000185576EB4-0x0000000185576FDC
		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward) => default; // 0x000000018557764C-0x0000000185577AF0
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed) => default; // 0x0000000185575F7C-0x0000000185576A58
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed) => default; // 0x0000000185576A58-0x0000000185576B1C
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) => default; // 0x0000000185577AF0-0x0000000185577BC8
		private TEdge RemoveEdge(TEdge e) => default; // 0x0000000185577C9C-0x0000000185577CFC
		private void SetDx(TEdge e) {} // 0x0000000185577DB8-0x0000000185577E10
		private void InsertLocalMinima(LocalMinima newLm) {} // 0x00000001855773F8-0x0000000185577480
		internal bool PopLocalMinima(long Y, out LocalMinima current) {
			current = default;
			return default;
		} // 0x00000001855775BC-0x0000000185577604
		private void ReverseHorizontal(TEdge e) {} // 0x0000000185577D94-0x0000000185577DB8
		internal virtual void Reset() {} // 0x0000000185577CFC-0x0000000185577D94
		public static IntRect GetBounds(List<List<IntPoint>> paths) => default; // 0x0000000185576FDC-0x0000000185577338
		internal void InsertScanbeam(long Y) {} // 0x0000000185577480-0x00000001855775A0
		internal bool PopScanbeam(out long Y) {
			Y = default;
			return default;
		} // 0x0000000185577604-0x000000018557764C
		internal bool LocalMinimaPending() => default; // 0x0000000182702DB0-0x0000000182702DC0
		internal OutRec CreateOutRec() => default; // 0x0000000185576C68-0x0000000185576D3C
		internal void DisposeOutRec(int index) {} // 0x0000000185576E28-0x0000000185576EB4
		internal void UpdateEdgeIntoAEL(ref TEdge e) {} // 0x00000001855782D8-0x0000000185578518
		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2) {} // 0x000000018557803C-0x00000001855782D8
		internal void DeleteFromAEL(TEdge e) {} // 0x0000000185576D3C-0x0000000185576DD4
	}

	public class Clipper : ClipperBase // TypeDefIndex: 58861
	{
		// Fields
		private ClipType m_ClipType; // 0x48
		private Maxima m_Maxima; // 0x50
		private TEdge m_SortedEdges; // 0x58
		private List<IntersectNode> m_IntersectList; // 0x60
		private IComparer<IntersectNode> m_IntersectNodeComparer; // 0x68
		private bool m_ExecuteLocked; // 0x70
		private PolyFillType m_ClipFillType; // 0x74
		private PolyFillType m_SubjFillType; // 0x78
		private List<Join> m_Joins; // 0x80
		private List<Join> m_GhostJoins; // 0x88
		private bool m_UsingPolyTree; // 0x90
	
		// Properties
		public bool ReverseSolution { get; set; } // 0x0000000183D50B80-0x0000000183D50B90 0x0000000183D50BA0-0x0000000183D50BB0
		public bool StrictlySimple { get; set; } // 0x0000000183D50B90-0x0000000183D50BA0 0x0000000183D50BB0-0x0000000183D50BC0
	
		// Constructors
		public Clipper() {} // Dummy constructor
		public Clipper(int InitOptions = 0 /* Metadata: 0x01FDC72B */) {} // 0x0000000185581FE8-0x00000001855821E4
	
		// Methods
		private void InsertMaxima(long X) {} // 0x000000018557EBC0-0x000000018557ECF0
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType) => default; // 0x000000018557CFA4-0x000000018557D138
		private bool ExecuteInternal() => default; // 0x000000018557CA60-0x000000018557CFA4
		private void DisposeAllPolyPts() {} // 0x000000018557C3CC-0x000000018557C448
		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) {} // 0x000000018557B4F8-0x000000018557B5AC
		private void AddGhostJoin(OutPt Op, IntPoint OffPt) {} // 0x000000018557B45C-0x000000018557B4F8
		private void InsertLocalMinimaIntoAEL(long botY) {} // 0x000000018557E6CC-0x000000018557EBC0
		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) {} // 0x000000018557E550-0x000000018557E6CC
		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) => default; // 0x000000018557C9AC-0x000000018557CA20
		private bool IsEvenOddFillType(TEdge edge) => default; // 0x000000018557F59C-0x000000018557F5C4
		private bool IsEvenOddAltFillType(TEdge edge) => default; // 0x000000018557F574-0x000000018557F59C
		private bool IsContributing(TEdge edge) => default; // 0x000000018557F458-0x000000018557F574
		private void SetWindingCount(TEdge edge) {} // 0x0000000185581A8C-0x0000000185581C74
		private void AddEdgeToSEL(TEdge edge) {} // 0x000000018557B3B0-0x000000018557B45C
		internal bool PopEdgeFromSEL(out TEdge e) {
			e = default;
			return default;
		} // 0x0000000185580928-0x00000001855809B0
		private void CopyAELToSEL() {} // 0x000000018557C370-0x000000018557C3CC
		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) {} // 0x0000000185581C9C-0x0000000185581F4C
		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) {} // 0x000000018557B5AC-0x000000018557B658
		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) => default; // 0x000000018557B658-0x000000018557B888
		private OutPt AddOutPt(TEdge e, IntPoint pt) => default; // 0x000000018557B888-0x000000018557BAD0
		private OutPt GetLastOutPt(TEdge e) => default; // 0x000000018557E13C-0x000000018557E1BC
		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b) => default; // 0x000000018557E518-0x000000018557E550
		private void SetHoleState(TEdge e, OutRec outRec) {} // 0x000000018558199C-0x0000000185581A8C
		private double GetDx(IntPoint pt1, IntPoint pt2) => default; // 0x000000018557E0B4-0x000000018557E0EC
		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) => default; // 0x000000018557D138-0x000000018557D474
		private OutPt GetBottomPt(OutPt pp) => default; // 0x000000018557DFC0-0x000000018557E0B4
		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) => default; // 0x000000018557E1BC-0x000000018557E28C
		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2) => default; // 0x0000000185580540-0x0000000185580568
		private OutRec GetOutRec(int idx) => default; // 0x000000018557E3B4-0x000000018557E440
		private void AppendPolygon(TEdge e1, TEdge e2) {} // 0x000000018557BAD0-0x000000018557BE08
		private void ReversePolyPtLinks(OutPt pp) {} // 0x0000000185581950-0x000000018558199C
		private static void SwapSides(TEdge edge1, TEdge edge2) {} // 0x0000000185581F4C-0x0000000185581F74
		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) {} // 0x0000000185581C74-0x0000000185581C9C
		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt) {} // 0x000000018557ECF0-0x000000018557F1AC
		private void ProcessHorizontals() {} // 0x0000000185581694-0x00000001855816E4
		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right) {
			Dir = default;
			Left = default;
			Right = default;
		} // 0x000000018557E0EC-0x000000018557E13C
		private void ProcessHorizontal(TEdge horzEdge) {} // 0x0000000185580EA4-0x0000000185581694
		private TEdge GetNextInAEL(TEdge e, Direction Direction) => default; // 0x000000018557E384-0x000000018557E3B4
		private bool IsMaxima(TEdge e, double Y) => default; // 0x000000018557F5F8-0x000000018557F620
		private bool IsIntermediate(TEdge e, double Y) => default; // 0x000000018557F5C4-0x000000018557F5F8
		internal TEdge GetMaximaPair(TEdge e) => default; // 0x000000018557E2D4-0x000000018557E384
		internal TEdge GetMaximaPairEx(TEdge e) => default; // 0x000000018557E28C-0x000000018557E2D4
		private bool ProcessIntersections(long topY) => default; // 0x00000001855817B8-0x0000000185581950
		private void BuildIntersectList(long topY) {} // 0x000000018557BFC0-0x000000018557C1B4
		private bool EdgesAdjacent(IntersectNode inode) => default; // 0x000000018557CA20-0x000000018557CA60
		private bool FixupIntersectionOrder() => default; // 0x000000018557DAB0-0x000000018557DCB0
		private void ProcessIntersectList() {} // 0x00000001855816E4-0x00000001855817B8
		internal static long Round(double value) => default; // 0x000000018557B2B0-0x000000018557B2D4
		private static long TopX(TEdge edge, long currentY) => default; // 0x0000000185581F74-0x0000000185581FB8
		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) {
			ip = default;
		} // 0x000000018557F1AC-0x000000018557F458
		private void ProcessEdgesAtTopOfScanbeam(long topY) {} // 0x00000001855809B0-0x0000000185580EA4
		private void DoMaxima(TEdge e) {} // 0x000000018557C448-0x000000018557C628
		public static bool Orientation(List<IntPoint> poly) => default; // 0x0000000185580524-0x0000000185580540
		private int PointCount(OutPt pts) => default; // 0x0000000185580584-0x00000001855805B0
		private void BuildResult(List<List<IntPoint>> polyg) {} // 0x000000018557C1B4-0x000000018557C370
		private void FixupOutPolyline(OutRec outrec) {} // 0x000000018557DED0-0x000000018557DFC0
		private void FixupOutPolygon(OutRec outRec) {} // 0x000000018557DCB0-0x000000018557DED0
		private OutPt DupOutPt(OutPt outPt, bool InsertAfter) => default; // 0x000000018557C8B0-0x000000018557C9AC
		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) {
			Left = default;
			Right = default;
			return default;
		} // 0x000000018557E440-0x000000018557E518
		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft) => default; // 0x000000018557F9CC-0x000000018557FDBC
		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2) => default; // 0x000000018557FDBC-0x0000000185580524
		public static int PointInPolygon(IntPoint pt, List<IntPoint> path) => default; // 0x00000001855805B0-0x0000000185580788
		private static int PointInPolygon(IntPoint pt, OutPt op) => default; // 0x0000000185580788-0x00000001855808C4
		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2) => default; // 0x00000001855808C4-0x0000000185580928
		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) {} // 0x000000018557D474-0x000000018557D634
		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec) {} // 0x000000018557D634-0x000000018557D918
		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec) {} // 0x000000018557D918-0x000000018557DAB0
		private static OutRec ParseFirstLeft(OutRec FirstLeft) => default; // 0x0000000185580568-0x0000000185580584
		private void JoinCommonEdges() {} // 0x000000018557F620-0x000000018557F9CC
		private void UpdateOutPtIdxs(OutRec outrec) {} // 0x0000000185581FB8-0x0000000185581FE8
		private void DoSimplePolygons() {} // 0x000000018557C628-0x000000018557C8B0
		public static double Area(List<IntPoint> poly) => default; // 0x000000018557BE8C-0x000000018557BFC0
		internal double Area(OutRec outRec) => default; // 0x000000018557BE08-0x000000018557BE28
		internal double Area(OutPt op) => default; // 0x000000018557BE28-0x000000018557BE8C
	}

	public class ClipperOffset // TypeDefIndex: 58862
	{
		// Fields
		private List<List<IntPoint>> m_destPolys; // 0x10
		private List<IntPoint> m_srcPoly; // 0x18
		private List<IntPoint> m_destPoly; // 0x20
		private List<DoublePoint> m_normals; // 0x28
		private double m_delta; // 0x30
		private double m_sinA; // 0x38
		private double m_sin; // 0x40
		private double m_cos; // 0x48
		private double m_miterLim; // 0x50
		private double m_StepsPerRad; // 0x58
		private IntPoint m_lowest; // 0x60
		private PolyNode m_polyNodes; // 0x70
		private const double two_pi = 6.283185307179586; // Metadata: 0x01FDC73C
		private const double def_arc_tolerance = 0.25; // Metadata: 0x01FDC744
	
		// Properties
		public double ArcTolerance { get; set; } // 0x0000000183D4F6C0-0x0000000183D4F6D0 0x0000000183D4F710-0x0000000183D4F720
		public double MiterLimit { get; set; } // 0x0000000183D50B60-0x0000000183D50B70 0x0000000183D50B70-0x0000000183D50B80
	
		// Constructors
		public ClipperOffset() {} // Dummy constructor
		public ClipperOffset(double miterLimit = 2 /* Metadata: 0x01FDC72C */, double arcTolerance = 0.25 /* Metadata: 0x01FDC734 */) {} // 0x000000018557B2D4-0x000000018557B3B0
	
		// Methods
		public void Clear() {} // 0x0000000185578B78-0x0000000185578BCC
		internal static long Round(double value) => default; // 0x000000018557B2B0-0x000000018557B2D4
		public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType) {} // 0x00000001855785D0-0x0000000185578A40
		public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType) {} // 0x0000000185578A40-0x0000000185578B78
		private void FixOrientations() {} // 0x000000018557A9B4-0x000000018557AB4C
		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) => default; // 0x000000018557AB4C-0x000000018557AC28
		private void DoOffset(double delta) {} // 0x0000000185578D9C-0x0000000185579F38
		public void Execute(ref List<List<IntPoint>> solution, double delta) {} // 0x000000018557A6D8-0x000000018557A9B4
		private void OffsetPoint(int j, ref int k, JoinType jointype) {} // 0x000000018557AC28-0x000000018557B2B0
		internal void DoSquare(int j, int k) {} // 0x000000018557A2D8-0x000000018557A6D8
		internal void DoMiter(int j, int k, double r) {} // 0x0000000185578BCC-0x0000000185578D9C
		internal void DoRound(int j, int k) {} // 0x0000000185579F38-0x000000018557A2D8
	}

	internal class ClipperException : Exception // TypeDefIndex: 58863
	{
		// Constructors
		public ClipperException() {} // Dummy constructor
		public ClipperException(string description) {} // 0x0000000185582688-0x00000001855828C4
	}
}
