/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;

// Image 76: clipper_library.dll - Assembly: clipper_library, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59863-59888

namespace ClipperLib
{
	public struct DoublePoint // TypeDefIndex: 59864
	{
		// Fields
		public double X; // 0x00
		public double Y; // 0x08
	
		// Constructors
		public DoublePoint(double x = 0 /* Metadata: 0x02081FE9 */, double y = 0 /* Metadata: 0x02081FF1 */) {
			X = default;
			Y = default;
		} // 0x0000000185FB20C0-0x0000000185FB20D0
		public DoublePoint(DoublePoint dp) {
			X = default;
			Y = default;
		} // 0x0000000185FB20B0-0x0000000185FB20C0
	}

	public class PolyNode // TypeDefIndex: 59865
	{
		// Fields
		internal PolyNode m_Parent; // 0x10
		internal List<IntPoint> m_polygon; // 0x18
		internal int m_Index; // 0x20
		internal JoinType m_jointype; // 0x24
		internal EndType m_endtype; // 0x28
		internal List<PolyNode> m_Childs; // 0x30
		private bool _IsOpen_k__BackingField; // 0x38
	
		// Properties
		public int ChildCount { get => default; } // 0x0000000187783BFC-0x0000000187783C3C 
		public List<PolyNode> Childs { get => default; } // 0x00000001813B51D0-0x00000001813B51E0 
	
		// Constructors
		public PolyNode() {} // 0x0000000187783B3C-0x0000000187783BFC
	
		// Methods
		internal void AddChild(PolyNode Child) {} // 0x0000000187783AB4-0x0000000187783B3C
	}

	internal struct Int128 // TypeDefIndex: 59866
	{
		// Fields
		private long hi; // 0x00
		private ulong lo; // 0x08
	
		// Constructors
		public Int128(long _hi, ulong _lo) {
			hi = default;
			lo = default;
		} // 0x0000000185FB20F0-0x0000000185FB2100
	
		// Methods
		public static bool operator ==(Int128 val1, Int128 val2) => default; // 0x00000001877838C8-0x0000000187783960
		public override bool Equals(object obj) => default; // 0x0000000187783798-0x000000018778380C
		public override int GetHashCode() => default; // 0x0000000185FB20D0-0x0000000185FB20F0
		public static Int128 operator -(Int128 val) => default; // 0x0000000187783960-0x000000018778398C
		public static Int128 Int128Mul(long lhs, long rhs) => default; // 0x000000018778380C-0x00000001877838C8
	}

	public struct IntPoint // TypeDefIndex: 59867
	{
		// Fields
		public long X; // 0x00
		public long Y; // 0x08
	
		// Constructors
		public IntPoint(long X, long Y) {
			this.X = default;
			this.Y = default;
		} // 0x0000000183680100-0x0000000183680110
		public IntPoint(double x, double y) {
			X = default;
			Y = default;
		} // 0x0000000185FB2100-0x0000000185FB2120
		public IntPoint(IntPoint pt) {
			X = default;
			Y = default;
		} // 0x0000000185FB20B0-0x0000000185FB20C0
	
		// Methods
		public static bool operator ==(IntPoint a, IntPoint b) => default; // 0x0000000187783A50-0x0000000187783A68
		public static bool operator !=(IntPoint a, IntPoint b) => default; // 0x0000000187783A68-0x0000000187783A80
		public override bool Equals(object obj) => default; // 0x000000018778398C-0x0000000187783A00
		public override int GetHashCode() => default; // 0x0000000187783A00-0x0000000187783A50
	}

	public struct IntRect // TypeDefIndex: 59868
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
		} // 0x0000000185FB04D0-0x0000000185FB04F0
	}

	public enum ClipType // TypeDefIndex: 59869
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3
	}

	public enum PolyType // TypeDefIndex: 59870
	{
		ptSubject = 0,
		ptClip = 1
	}

	public enum PolyFillType // TypeDefIndex: 59871
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3
	}

	public enum JoinType // TypeDefIndex: 59872
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2
	}

	public enum EndType // TypeDefIndex: 59873
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4
	}

	internal enum EdgeSide // TypeDefIndex: 59874
	{
		esLeft = 0,
		esRight = 1
	}

	internal enum Direction // TypeDefIndex: 59875
	{
		dRightToLeft = 0,
		dLeftToRight = 1
	}

	internal class TEdge // TypeDefIndex: 59876
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
		public TEdge() {} // 0x0000000185492010-0x0000000185492020
	}

	public class IntersectNode // TypeDefIndex: 59877
	{
		// Fields
		internal TEdge Edge1; // 0x10
		internal TEdge Edge2; // 0x18
		internal IntPoint Pt; // 0x20
	
		// Constructors
		public IntersectNode() {} // 0x0000000185492010-0x0000000185492020
	}

	public class MyIntersectNodeSort : IComparer<ClipperLib.IntersectNode> // TypeDefIndex: 59878
	{
		// Constructors
		public MyIntersectNodeSort() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public int Compare(IntersectNode node1, IntersectNode node2) => default; // 0x0000000187783A80-0x0000000187783AB4
	}

	internal class LocalMinima // TypeDefIndex: 59879
	{
		// Fields
		internal long Y; // 0x10
		internal TEdge LeftBound; // 0x18
		internal TEdge RightBound; // 0x20
		internal LocalMinima Next; // 0x28
	
		// Constructors
		public LocalMinima() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class Scanbeam // TypeDefIndex: 59880
	{
		// Fields
		internal long Y; // 0x10
		internal Scanbeam Next; // 0x18
	
		// Constructors
		public Scanbeam() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class Maxima // TypeDefIndex: 59881
	{
		// Fields
		internal long X; // 0x10
		internal Maxima Next; // 0x18
		internal Maxima Prev; // 0x20
	
		// Constructors
		public Maxima() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class OutRec // TypeDefIndex: 59882
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
		public OutRec() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class OutPt // TypeDefIndex: 59883
	{
		// Fields
		internal int Idx; // 0x10
		internal IntPoint Pt; // 0x18
		internal OutPt Next; // 0x28
		internal OutPt Prev; // 0x30
	
		// Constructors
		public OutPt() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class Join // TypeDefIndex: 59884
	{
		// Fields
		internal OutPt OutPt1; // 0x10
		internal OutPt OutPt2; // 0x18
		internal IntPoint OffPt; // 0x20
	
		// Constructors
		public Join() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ClipperBase // TypeDefIndex: 59885
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
		private bool _PreserveCollinear_k__BackingField; // 0x42
	
		// Properties
		public bool PreserveCollinear { get; set; } // 0x0000000185FB0D60-0x0000000185FB0D70 0x0000000185FB0D80-0x0000000185FB0D90
	
		// Constructors
		internal ClipperBase() {} // 0x0000000187779ACC-0x0000000187779B64
	
		// Methods
		internal static bool near_zero(double val) => default; // 0x0000000187779B64-0x0000000187779B84
		public void Swap(ref long val1, ref long val2) {} // 0x0000000185FB2040-0x0000000185FB2050
		internal static bool IsHorizontal(TEdge e) => default; // 0x0000000187778B54-0x0000000187778B70
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) => default; // 0x0000000187779478-0x000000018777952C
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) => default; // 0x00000001877793C4-0x0000000187779478
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange) => default; // 0x000000018777952C-0x00000001877795F0
		public virtual void Clear() {} // 0x00000001877780D0-0x000000018777821C
		private void DisposeLocalMinimaList() {} // 0x0000000187778388-0x00000001877783DC
		private void RangeTest(IntPoint Pt, ref bool useFullRange) {} // 0x000000018777917C-0x0000000187779250
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) {} // 0x0000000187778964-0x00000001877789AC
		private void InitEdge2(TEdge e, PolyType polyType) {} // 0x00000001877788EC-0x0000000187778964
		private TEdge FindNextLocMin(TEdge E) => default; // 0x0000000187778468-0x0000000187778590
		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward) => default; // 0x0000000187778C00-0x00000001877790A4
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed) => default; // 0x0000000187777530-0x000000018777800C
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed) => default; // 0x000000018777800C-0x00000001877780D0
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) => default; // 0x00000001877790A4-0x000000018777917C
		private TEdge RemoveEdge(TEdge e) => default; // 0x0000000187779250-0x00000001877792B0
		private void SetDx(TEdge e) {} // 0x000000018777936C-0x00000001877793C4
		private void InsertLocalMinima(LocalMinima newLm) {} // 0x00000001877789AC-0x0000000187778A34
		internal bool PopLocalMinima(long Y, out LocalMinima current) {
			current = default;
			return default;
		} // 0x0000000187778B70-0x0000000187778BB8
		private void ReverseHorizontal(TEdge e) {} // 0x0000000187779348-0x000000018777936C
		internal virtual void Reset() {} // 0x00000001877792B0-0x0000000187779348
		public static IntRect GetBounds(List<List<IntPoint>> paths) => default; // 0x0000000187778590-0x00000001877788EC
		internal void InsertScanbeam(long Y) {} // 0x0000000187778A34-0x0000000187778B54
		internal bool PopScanbeam(out long Y) {
			Y = default;
			return default;
		} // 0x0000000187778BB8-0x0000000187778C00
		internal bool LocalMinimaPending() => default; // 0x00000001847EB9E0-0x00000001847EB9F0
		internal OutRec CreateOutRec() => default; // 0x000000018777821C-0x00000001877782F0
		internal void DisposeOutRec(int index) {} // 0x00000001877783DC-0x0000000187778468
		internal void UpdateEdgeIntoAEL(ref TEdge e) {} // 0x000000018777988C-0x0000000187779ACC
		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2) {} // 0x00000001877795F0-0x000000018777988C
		internal void DeleteFromAEL(TEdge e) {} // 0x00000001877782F0-0x0000000187778388
	}

	public class Clipper : ClipperBase // TypeDefIndex: 59886
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
		private bool _ReverseSolution_k__BackingField; // 0x91
		private bool _StrictlySimple_k__BackingField; // 0x92
	
		// Properties
		public bool ReverseSolution { get; set; } // 0x0000000185FB2070-0x0000000185FB2080 0x0000000185FB2090-0x0000000185FB20A0
		public bool StrictlySimple { get; set; } // 0x0000000185FB2080-0x0000000185FB2090 0x0000000185FB20A0-0x0000000185FB20B0
	
		// Constructors
		public Clipper() {} // Dummy constructor
		public Clipper(int InitOptions = 0 /* Metadata: 0x0208200F */) {} // 0x000000018778359C-0x0000000187783798
	
		// Methods
		private void InsertMaxima(long X) {} // 0x0000000187780174-0x00000001877802A4
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType) => default; // 0x000000018777E558-0x000000018777E6EC
		private bool ExecuteInternal() => default; // 0x000000018777E014-0x000000018777E558
		private void DisposeAllPolyPts() {} // 0x000000018777D980-0x000000018777D9FC
		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt) {} // 0x000000018777CAAC-0x000000018777CB60
		private void AddGhostJoin(OutPt Op, IntPoint OffPt) {} // 0x000000018777CA10-0x000000018777CAAC
		private void InsertLocalMinimaIntoAEL(long botY) {} // 0x000000018777FC80-0x0000000187780174
		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge) {} // 0x000000018777FB04-0x000000018777FC80
		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2) => default; // 0x000000018777DF60-0x000000018777DFD4
		private bool IsEvenOddFillType(TEdge edge) => default; // 0x0000000187780B50-0x0000000187780B78
		private bool IsEvenOddAltFillType(TEdge edge) => default; // 0x0000000187780B28-0x0000000187780B50
		private bool IsContributing(TEdge edge) => default; // 0x0000000187780A0C-0x0000000187780B28
		private void SetWindingCount(TEdge edge) {} // 0x0000000187783040-0x0000000187783228
		private void AddEdgeToSEL(TEdge edge) {} // 0x000000018777C964-0x000000018777CA10
		internal bool PopEdgeFromSEL(out TEdge e) {
			e = default;
			return default;
		} // 0x0000000187781EDC-0x0000000187781F64
		private void CopyAELToSEL() {} // 0x000000018777D924-0x000000018777D980
		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2) {} // 0x0000000187783250-0x0000000187783500
		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt) {} // 0x000000018777CB60-0x000000018777CC0C
		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt) => default; // 0x000000018777CC0C-0x000000018777CE3C
		private OutPt AddOutPt(TEdge e, IntPoint pt) => default; // 0x000000018777CE3C-0x000000018777D084
		private OutPt GetLastOutPt(TEdge e) => default; // 0x000000018777F6F0-0x000000018777F770
		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b) => default; // 0x000000018777FACC-0x000000018777FB04
		private void SetHoleState(TEdge e, OutRec outRec) {} // 0x0000000187782F50-0x0000000187783040
		private double GetDx(IntPoint pt1, IntPoint pt2) => default; // 0x000000018777F668-0x000000018777F6A0
		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2) => default; // 0x000000018777E6EC-0x000000018777EA28
		private OutPt GetBottomPt(OutPt pp) => default; // 0x000000018777F574-0x000000018777F668
		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2) => default; // 0x000000018777F770-0x000000018777F840
		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2) => default; // 0x0000000187781AF4-0x0000000187781B1C
		private OutRec GetOutRec(int idx) => default; // 0x000000018777F968-0x000000018777F9F4
		private void AppendPolygon(TEdge e1, TEdge e2) {} // 0x000000018777D084-0x000000018777D3BC
		private void ReversePolyPtLinks(OutPt pp) {} // 0x0000000187782F04-0x0000000187782F50
		private static void SwapSides(TEdge edge1, TEdge edge2) {} // 0x0000000187783500-0x0000000187783528
		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2) {} // 0x0000000187783228-0x0000000187783250
		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt) {} // 0x00000001877802A4-0x0000000187780760
		private void ProcessHorizontals() {} // 0x0000000187782C48-0x0000000187782C98
		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right) {
			Dir = default;
			Left = default;
			Right = default;
		} // 0x000000018777F6A0-0x000000018777F6F0
		private void ProcessHorizontal(TEdge horzEdge) {} // 0x0000000187782458-0x0000000187782C48
		private TEdge GetNextInAEL(TEdge e, Direction Direction) => default; // 0x000000018777F938-0x000000018777F968
		private bool IsMaxima(TEdge e, double Y) => default; // 0x0000000187780BAC-0x0000000187780BD4
		private bool IsIntermediate(TEdge e, double Y) => default; // 0x0000000187780B78-0x0000000187780BAC
		internal TEdge GetMaximaPair(TEdge e) => default; // 0x000000018777F888-0x000000018777F938
		internal TEdge GetMaximaPairEx(TEdge e) => default; // 0x000000018777F840-0x000000018777F888
		private bool ProcessIntersections(long topY) => default; // 0x0000000187782D6C-0x0000000187782F04
		private void BuildIntersectList(long topY) {} // 0x000000018777D574-0x000000018777D768
		private bool EdgesAdjacent(IntersectNode inode) => default; // 0x000000018777DFD4-0x000000018777E014
		private bool FixupIntersectionOrder() => default; // 0x000000018777F064-0x000000018777F264
		private void ProcessIntersectList() {} // 0x0000000187782C98-0x0000000187782D6C
		internal static long Round(double value) => default; // 0x000000018777C864-0x000000018777C888
		private static long TopX(TEdge edge, long currentY) => default; // 0x0000000187783528-0x000000018778356C
		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip) {
			ip = default;
		} // 0x0000000187780760-0x0000000187780A0C
		private void ProcessEdgesAtTopOfScanbeam(long topY) {} // 0x0000000187781F64-0x0000000187782458
		private void DoMaxima(TEdge e) {} // 0x000000018777D9FC-0x000000018777DBDC
		public static bool Orientation(List<IntPoint> poly) => default; // 0x0000000187781AD8-0x0000000187781AF4
		private int PointCount(OutPt pts) => default; // 0x0000000187781B38-0x0000000187781B64
		private void BuildResult(List<List<IntPoint>> polyg) {} // 0x000000018777D768-0x000000018777D924
		private void FixupOutPolyline(OutRec outrec) {} // 0x000000018777F484-0x000000018777F574
		private void FixupOutPolygon(OutRec outRec) {} // 0x000000018777F264-0x000000018777F484
		private OutPt DupOutPt(OutPt outPt, bool InsertAfter) => default; // 0x000000018777DE64-0x000000018777DF60
		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right) {
			Left = default;
			Right = default;
			return default;
		} // 0x000000018777F9F4-0x000000018777FACC
		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft) => default; // 0x0000000187780F80-0x0000000187781370
		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2) => default; // 0x0000000187781370-0x0000000187781AD8
		public static int PointInPolygon(IntPoint pt, List<IntPoint> path) => default; // 0x0000000187781B64-0x0000000187781D3C
		private static int PointInPolygon(IntPoint pt, OutPt op) => default; // 0x0000000187781D3C-0x0000000187781E78
		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2) => default; // 0x0000000187781E78-0x0000000187781EDC
		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec) {} // 0x000000018777EA28-0x000000018777EBE8
		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec) {} // 0x000000018777EBE8-0x000000018777EECC
		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec) {} // 0x000000018777EECC-0x000000018777F064
		private static OutRec ParseFirstLeft(OutRec FirstLeft) => default; // 0x0000000187781B1C-0x0000000187781B38
		private void JoinCommonEdges() {} // 0x0000000187780BD4-0x0000000187780F80
		private void UpdateOutPtIdxs(OutRec outrec) {} // 0x000000018778356C-0x000000018778359C
		private void DoSimplePolygons() {} // 0x000000018777DBDC-0x000000018777DE64
		public static double Area(List<IntPoint> poly) => default; // 0x000000018777D440-0x000000018777D574
		internal double Area(OutRec outRec) => default; // 0x000000018777D3BC-0x000000018777D3DC
		internal double Area(OutPt op) => default; // 0x000000018777D3DC-0x000000018777D440
	}

	public class ClipperOffset // TypeDefIndex: 59887
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
		private double _ArcTolerance_k__BackingField; // 0x78
		private double _MiterLimit_k__BackingField; // 0x80
		private const double two_pi = 6.283185307179586; // Metadata: 0x02082020
		private const double def_arc_tolerance = 0.25; // Metadata: 0x02082028
	
		// Properties
		public double ArcTolerance { get; set; } // 0x0000000185FB0CB0-0x0000000185FB0CC0 0x0000000185FB0D00-0x0000000185FB0D10
		public double MiterLimit { get; set; } // 0x0000000185FB2050-0x0000000185FB2060 0x0000000185FB2060-0x0000000185FB2070
	
		// Constructors
		public ClipperOffset() {} // Dummy constructor
		public ClipperOffset(double miterLimit = 2 /* Metadata: 0x02082010 */, double arcTolerance = 0.25 /* Metadata: 0x02082018 */) {} // 0x000000018777C888-0x000000018777C964
	
		// Methods
		public void Clear() {} // 0x000000018777A12C-0x000000018777A180
		internal static long Round(double value) => default; // 0x000000018777C864-0x000000018777C888
		public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType) {} // 0x0000000187779B84-0x0000000187779FF4
		public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType) {} // 0x0000000187779FF4-0x000000018777A12C
		private void FixOrientations() {} // 0x000000018777BF68-0x000000018777C100
		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2) => default; // 0x000000018777C100-0x000000018777C1DC
		private void DoOffset(double delta) {} // 0x000000018777A350-0x000000018777B4EC
		public void Execute(ref List<List<IntPoint>> solution, double delta) {} // 0x000000018777BC8C-0x000000018777BF68
		private void OffsetPoint(int j, ref int k, JoinType jointype) {} // 0x000000018777C1DC-0x000000018777C864
		internal void DoSquare(int j, int k) {} // 0x000000018777B88C-0x000000018777BC8C
		internal void DoMiter(int j, int k, double r) {} // 0x000000018777A180-0x000000018777A350
		internal void DoRound(int j, int k) {} // 0x000000018777B4EC-0x000000018777B88C
	}

	internal class ClipperException : Exception // TypeDefIndex: 59888
	{
		// Constructors
		public ClipperException() {} // Dummy constructor
		public ClipperException(string description) {} // 0x0000000187783C3C-0x00000001877843E0
	}
}
