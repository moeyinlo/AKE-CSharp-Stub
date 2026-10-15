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

// Image 77: clipper_library.dll - Assembly: clipper_library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89742-89767

namespace ClipperLib
{
	public struct DoublePoint // TypeDefIndex: 89743
	{
		// Fields
		public double X; // 0x00
		public double Y; // 0x08
	
		// Constructors
		public DoublePoint(double x = 0 /* Metadata: 0x0264A404 */, double y = 0 /* Metadata: 0x0264A40C */); // 0x0000000187235160-0x0000000187235170
		public DoublePoint(DoublePoint dp); // 0x0000000187235150-0x0000000187235160
	}

	public class PolyNode // TypeDefIndex: 89744
	{
		// Fields
		internal PolyNode m_Parent; // 0x10
		internal List<IntPoint> m_polygon; // 0x18
		internal int m_Index; // 0x20
		internal JoinType m_jointype; // 0x24
		internal EndType m_endtype; // 0x28
		internal List<PolyNode> m_Childs; // 0x30
		[CompilerGenerated]
		private bool _IsOpen_k__BackingField; // 0x38
	
		// Properties
		public int ChildCount { get; } // 0x0000000188AAD658-0x0000000188AAD698 
		public List<PolyNode> Childs { get; } // 0x00000001829600D0-0x00000001829600E0 
	
		// Constructors
		public PolyNode(); // 0x0000000188AAD598-0x0000000188AAD658
	
		// Methods
		internal void AddChild(PolyNode Child); // 0x0000000188AAD510-0x0000000188AAD598
	}

	internal struct Int128 // TypeDefIndex: 89745
	{
		// Fields
		private long hi; // 0x00
		private ulong lo; // 0x08
	
		// Constructors
		public Int128(long _hi, ulong _lo); // 0x0000000187235190-0x00000001872351A0
	
		// Methods
		public static bool operator ==(Int128 val1, Int128 val2); // 0x0000000188AAD320-0x0000000188AAD3B8
		public override bool Equals(object obj); // 0x0000000188AAD1E8-0x0000000188AAD25C
		public override int GetHashCode(); // 0x0000000187235170-0x0000000187235190
		public static Int128 operator -(Int128 val); // 0x0000000188AAD3B8-0x0000000188AAD3E8
		public static Int128 Int128Mul(long lhs, long rhs); // 0x0000000188AAD25C-0x0000000188AAD320
	}

	public struct IntPoint // TypeDefIndex: 89746
	{
		// Fields
		public long X; // 0x00
		public long Y; // 0x08
	
		// Constructors
		public IntPoint(long X, long Y); // 0x0000000187232F10-0x0000000187232F20
		public IntPoint(double x, double y); // 0x00000001872351A0-0x00000001872351C0
		public IntPoint(IntPoint pt); // 0x0000000187235150-0x0000000187235160
	
		// Methods
		public static bool operator ==(IntPoint a, IntPoint b); // 0x0000000188AAD4AC-0x0000000188AAD4C4
		public static bool operator !=(IntPoint a, IntPoint b); // 0x0000000188AAD4C4-0x0000000188AAD4DC
		public override bool Equals(object obj); // 0x0000000188AAD3E8-0x0000000188AAD45C
		public override int GetHashCode(); // 0x0000000188AAD45C-0x0000000188AAD4AC
	}

	public struct IntRect // TypeDefIndex: 89747
	{
		// Fields
		public long left; // 0x00
		public long top; // 0x08
		public long right; // 0x10
		public long bottom; // 0x18
	
		// Constructors
		public IntRect(long l, long t, long r, long b); // 0x0000000187232F20-0x0000000187232F40
	}

	public enum ClipType // TypeDefIndex: 89748
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3
	}

	public enum PolyType // TypeDefIndex: 89749
	{
		ptSubject = 0,
		ptClip = 1
	}

	public enum PolyFillType // TypeDefIndex: 89750
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3
	}

	public enum JoinType // TypeDefIndex: 89751
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2
	}

	public enum EndType // TypeDefIndex: 89752
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4
	}

	internal enum EdgeSide // TypeDefIndex: 89753
	{
		esLeft = 0,
		esRight = 1
	}

	internal enum Direction // TypeDefIndex: 89754
	{
		dRightToLeft = 0,
		dLeftToRight = 1
	}

	internal class TEdge // TypeDefIndex: 89755
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
		public TEdge(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class IntersectNode // TypeDefIndex: 89756
	{
		// Fields
		internal TEdge Edge1; // 0x10
		internal TEdge Edge2; // 0x18
		internal IntPoint Pt; // 0x20
	
		// Constructors
		public IntersectNode(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class MyIntersectNodeSort : IComparer<ClipperLib.IntersectNode> // TypeDefIndex: 89757
	{
		// Constructors
		public MyIntersectNodeSort(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public int Compare(IntersectNode node1, IntersectNode node2); // 0x0000000188AAD4DC-0x0000000188AAD510
	}

	internal class LocalMinima // TypeDefIndex: 89758
	{
		// Fields
		internal long Y; // 0x10
		internal TEdge LeftBound; // 0x18
		internal TEdge RightBound; // 0x20
		internal LocalMinima Next; // 0x28
	
		// Constructors
		public LocalMinima(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class Scanbeam // TypeDefIndex: 89759
	{
		// Fields
		internal long Y; // 0x10
		internal Scanbeam Next; // 0x18
	
		// Constructors
		public Scanbeam(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class Maxima // TypeDefIndex: 89760
	{
		// Fields
		internal long X; // 0x10
		internal Maxima Next; // 0x18
		internal Maxima Prev; // 0x20
	
		// Constructors
		public Maxima(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class OutRec // TypeDefIndex: 89761
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
		public OutRec(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class OutPt // TypeDefIndex: 89762
	{
		// Fields
		internal int Idx; // 0x10
		internal IntPoint Pt; // 0x18
		internal OutPt Next; // 0x28
		internal OutPt Prev; // 0x30
	
		// Constructors
		public OutPt(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	internal class Join // TypeDefIndex: 89763
	{
		// Fields
		internal OutPt OutPt1; // 0x10
		internal OutPt OutPt2; // 0x18
		internal IntPoint OffPt; // 0x20
	
		// Constructors
		public Join(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ClipperBase // TypeDefIndex: 89764
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
		[CompilerGenerated]
		private bool _PreserveCollinear_k__BackingField; // 0x42
	
		// Properties
		public bool PreserveCollinear { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872338B0-0x00000001872338C0 0x00000001872338C0-0x00000001872338D0
	
		// Constructors
		internal ClipperBase(); // 0x0000000188AA341C-0x0000000188AA34BC
	
		// Methods
		internal static bool near_zero(double val); // 0x0000000188AA34BC-0x0000000188AA34DC
		public void Swap(ref long val1, ref long val2); // 0x00000001872350E0-0x00000001872350F0
		internal static bool IsHorizontal(TEdge e); // 0x0000000188AA2504-0x0000000188AA2520
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange); // 0x0000000188AA2DE8-0x0000000188AA2E98
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange); // 0x0000000188AA2D58-0x0000000188AA2DE8
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange); // 0x0000000188AA2E98-0x0000000188AA2F44
		public virtual void Clear(); // 0x0000000188AA1A74-0x0000000188AA1BAC
		private void DisposeLocalMinimaList(); // 0x0000000188AA1D2C-0x0000000188AA1D88
		private void RangeTest(IntPoint Pt, ref bool useFullRange); // 0x0000000188AA2B04-0x0000000188AA2BD8
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt); // 0x0000000188AA2314-0x0000000188AA235C
		private void InitEdge2(TEdge e, PolyType polyType); // 0x0000000188AA229C-0x0000000188AA2314
		private TEdge FindNextLocMin(TEdge E); // 0x0000000188AA1E18-0x0000000188AA1F40
		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward); // 0x0000000188AA25B0-0x0000000188AA2A2C
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed); // 0x0000000188AA0EBC-0x0000000188AA19AC
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed); // 0x0000000188AA19AC-0x0000000188AA1A74
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3); // 0x0000000188AA2A2C-0x0000000188AA2B04
		private TEdge RemoveEdge(TEdge e); // 0x0000000188AA2BD8-0x0000000188AA2C3C
		private void SetDx(TEdge e); // 0x0000000188AA2D00-0x0000000188AA2D58
		private void InsertLocalMinima(LocalMinima newLm); // 0x0000000188AA235C-0x0000000188AA23E4
		internal bool PopLocalMinima(long Y, out LocalMinima current); // 0x0000000188AA2520-0x0000000188AA2568
		private void ReverseHorizontal(TEdge e); // 0x0000000188AA2CDC-0x0000000188AA2D00
		internal virtual void Reset(); // 0x0000000188AA2C3C-0x0000000188AA2CDC
		public static IntRect GetBounds(List<List<IntPoint>> paths); // 0x0000000188AA1F40-0x0000000188AA229C
		internal void InsertScanbeam(long Y); // 0x0000000188AA23E4-0x0000000188AA2504
		internal bool PopScanbeam(out long Y); // 0x0000000188AA2568-0x0000000188AA25B0
		internal bool LocalMinimaPending(); // 0x0000000185B19DF0-0x0000000185B19E00
		internal OutRec CreateOutRec(); // 0x0000000188AA1BAC-0x0000000188AA1C94
		internal void DisposeOutRec(int index); // 0x0000000188AA1D88-0x0000000188AA1E18
		internal void UpdateEdgeIntoAEL(ref TEdge e); // 0x0000000188AA31EC-0x0000000188AA341C
		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2); // 0x0000000188AA2F44-0x0000000188AA31EC
		internal void DeleteFromAEL(TEdge e); // 0x0000000188AA1C94-0x0000000188AA1D2C
	}

	public class Clipper : ClipperBase // TypeDefIndex: 89765
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
		[CompilerGenerated]
		private bool _ReverseSolution_k__BackingField; // 0x91
		[CompilerGenerated]
		private bool _StrictlySimple_k__BackingField; // 0x92
	
		// Properties
		public bool ReverseSolution { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235110-0x0000000187235120 0x0000000187235130-0x0000000187235140
		public bool StrictlySimple { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235120-0x0000000187235130 0x0000000187235140-0x0000000187235150
	
		// Constructors
		public Clipper(int InitOptions = 0 /* Metadata: 0x0264A42A */); // 0x0000000188AACFE0-0x0000000188AAD1E8
	
		// Methods
		private void InsertMaxima(long X); // 0x0000000188AA9B30-0x0000000188AA9C68
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType); // 0x0000000188AA7EF0-0x0000000188AA8088
		private bool ExecuteInternal(); // 0x0000000188AA79A8-0x0000000188AA7EF0
		private void DisposeAllPolyPts(); // 0x0000000188AA7318-0x0000000188AA7394
		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt); // 0x0000000188AA6424-0x0000000188AA64D8
		private void AddGhostJoin(OutPt Op, IntPoint OffPt); // 0x0000000188AA6388-0x0000000188AA6424
		private void InsertLocalMinimaIntoAEL(long botY); // 0x0000000188AA9634-0x0000000188AA9B30
		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge); // 0x0000000188AA94B0-0x0000000188AA9634
		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2); // 0x0000000188AA78FC-0x0000000188AA7970
		private bool IsEvenOddFillType(TEdge edge); // 0x0000000188AAA56C-0x0000000188AAA594
		private bool IsEvenOddAltFillType(TEdge edge); // 0x0000000188AAA544-0x0000000188AAA56C
		private bool IsContributing(TEdge edge); // 0x0000000188AAA420-0x0000000188AAA544
		private void SetWindingCount(TEdge edge); // 0x0000000188AACA7C-0x0000000188AACC6C
		private void AddEdgeToSEL(TEdge edge); // 0x0000000188AA62DC-0x0000000188AA6388
		internal bool PopEdgeFromSEL(out TEdge e); // 0x0000000188AAB900-0x0000000188AAB994
		private void CopyAELToSEL(); // 0x0000000188AA72BC-0x0000000188AA7318
		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2); // 0x0000000188AACC94-0x0000000188AACF44
		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt); // 0x0000000188AA64D8-0x0000000188AA6584
		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt); // 0x0000000188AA6584-0x0000000188AA67C0
		private OutPt AddOutPt(TEdge e, IntPoint pt); // 0x0000000188AA67C0-0x0000000188AA6A08
		private OutPt GetLastOutPt(TEdge e); // 0x0000000188AA9094-0x0000000188AA9114
		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b); // 0x0000000188AA9478-0x0000000188AA94B0
		private void SetHoleState(TEdge e, OutRec outRec); // 0x0000000188AAC988-0x0000000188AACA7C
		private double GetDx(IntPoint pt1, IntPoint pt2); // 0x0000000188AA900C-0x0000000188AA9044
		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2); // 0x0000000188AA8088-0x0000000188AA83C4
		private OutPt GetBottomPt(OutPt pp); // 0x0000000188AA8F18-0x0000000188AA900C
		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2); // 0x0000000188AA9114-0x0000000188AA91EC
		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2); // 0x0000000188AAB518-0x0000000188AAB540
		private OutRec GetOutRec(int idx); // 0x0000000188AA9314-0x0000000188AA93A0
		private void AppendPolygon(TEdge e1, TEdge e2); // 0x0000000188AA6A08-0x0000000188AA6D48
		private void ReversePolyPtLinks(OutPt pp); // 0x0000000188AAC93C-0x0000000188AAC988
		private static void SwapSides(TEdge edge1, TEdge edge2); // 0x0000000188AACF44-0x0000000188AACF6C
		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2); // 0x0000000188AACC6C-0x0000000188AACC94
		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt); // 0x0000000188AA9C68-0x0000000188AAA170
		private void ProcessHorizontals(); // 0x0000000188AAC684-0x0000000188AAC6D4
		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right); // 0x0000000188AA9044-0x0000000188AA9094
		private void ProcessHorizontal(TEdge horzEdge); // 0x0000000188AABE88-0x0000000188AAC684
		private TEdge GetNextInAEL(TEdge e, Direction Direction); // 0x0000000188AA92E4-0x0000000188AA9314
		private bool IsMaxima(TEdge e, double Y); // 0x0000000188AAA5C8-0x0000000188AAA5F0
		private bool IsIntermediate(TEdge e, double Y); // 0x0000000188AAA594-0x0000000188AAA5C8
		internal TEdge GetMaximaPair(TEdge e); // 0x0000000188AA9234-0x0000000188AA92E4
		internal TEdge GetMaximaPairEx(TEdge e); // 0x0000000188AA91EC-0x0000000188AA9234
		private bool ProcessIntersections(long topY); // 0x0000000188AAC7A4-0x0000000188AAC93C
		private void BuildIntersectList(long topY); // 0x0000000188AA6F00-0x0000000188AA7100
		private bool EdgesAdjacent(IntersectNode inode); // 0x0000000188AA7970-0x0000000188AA79A8
		private bool FixupIntersectionOrder(); // 0x0000000188AA89FC-0x0000000188AA8BFC
		private void ProcessIntersectList(); // 0x0000000188AAC6D4-0x0000000188AAC7A4
		internal static long Round(double value); // 0x0000000188AA61DC-0x0000000188AA6200
		private static long TopX(TEdge edge, long currentY); // 0x0000000188AACF6C-0x0000000188AACFB0
		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip); // 0x0000000188AAA170-0x0000000188AAA420
		private void ProcessEdgesAtTopOfScanbeam(long topY); // 0x0000000188AAB994-0x0000000188AABE88
		private void DoMaxima(TEdge e); // 0x0000000188AA7394-0x0000000188AA7578
		public static bool Orientation(List<IntPoint> poly); // 0x0000000188AAB4FC-0x0000000188AAB518
		private int PointCount(OutPt pts); // 0x0000000188AAB55C-0x0000000188AAB588
		private void BuildResult(List<List<IntPoint>> polyg); // 0x0000000188AA7100-0x0000000188AA72BC
		private void FixupOutPolyline(OutRec outrec); // 0x0000000188AA8E24-0x0000000188AA8F18
		private void FixupOutPolygon(OutRec outRec); // 0x0000000188AA8BFC-0x0000000188AA8E24
		private OutPt DupOutPt(OutPt outPt, bool InsertAfter); // 0x0000000188AA7800-0x0000000188AA78FC
		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right); // 0x0000000188AA93A0-0x0000000188AA9478
		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft); // 0x0000000188AAA99C-0x0000000188AAAD8C
		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2); // 0x0000000188AAAD8C-0x0000000188AAB4FC
		public static int PointInPolygon(IntPoint pt, List<IntPoint> path); // 0x0000000188AAB588-0x0000000188AAB760
		private static int PointInPolygon(IntPoint pt, OutPt op); // 0x0000000188AAB760-0x0000000188AAB89C
		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2); // 0x0000000188AAB89C-0x0000000188AAB900
		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec); // 0x0000000188AA83C4-0x0000000188AA857C
		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec); // 0x0000000188AA857C-0x0000000188AA8870
		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec); // 0x0000000188AA8870-0x0000000188AA89FC
		private static OutRec ParseFirstLeft(OutRec FirstLeft); // 0x0000000188AAB540-0x0000000188AAB55C
		private void JoinCommonEdges(); // 0x0000000188AAA5F0-0x0000000188AAA99C
		private void UpdateOutPtIdxs(OutRec outrec); // 0x0000000188AACFB0-0x0000000188AACFE0
		private void DoSimplePolygons(); // 0x0000000188AA7578-0x0000000188AA7800
		public static double Area(List<IntPoint> poly); // 0x0000000188AA6DCC-0x0000000188AA6F00
		internal double Area(OutRec outRec); // 0x0000000188AA6D48-0x0000000188AA6D68
		internal double Area(OutPt op); // 0x0000000188AA6D68-0x0000000188AA6DCC
	}

	public class ClipperOffset // TypeDefIndex: 89766
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
		[CompilerGenerated]
		private double _ArcTolerance_k__BackingField; // 0x78
		[CompilerGenerated]
		private double _MiterLimit_k__BackingField; // 0x80
		private const double two_pi = 6.283185307179586; // Metadata: 0x0264A43B
		private const double def_arc_tolerance = 0.25; // Metadata: 0x0264A443
	
		// Properties
		public double ArcTolerance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872337B0-0x00000001872337C0 0x0000000187233800-0x0000000187233810
		public double MiterLimit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872350F0-0x0000000187235100 0x0000000187235100-0x0000000187235110
	
		// Constructors
		public ClipperOffset(double miterLimit = 2 /* Metadata: 0x0264A42B */, double arcTolerance = 0.25 /* Metadata: 0x0264A433 */); // 0x0000000188AA6200-0x0000000188AA62DC
	
		// Methods
		public void Clear(); // 0x0000000188AA3A9C-0x0000000188AA3AF4
		internal static long Round(double value); // 0x0000000188AA61DC-0x0000000188AA6200
		public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType); // 0x0000000188AA34DC-0x0000000188AA394C
		public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType); // 0x0000000188AA394C-0x0000000188AA3A9C
		private void FixOrientations(); // 0x0000000188AA58E0-0x0000000188AA5A78
		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2); // 0x0000000188AA5A78-0x0000000188AA5B54
		private void DoOffset(double delta); // 0x0000000188AA3CC4-0x0000000188AA4E64
		public void Execute(ref List<List<IntPoint>> solution, double delta); // 0x0000000188AA55F8-0x0000000188AA58E0
		private void OffsetPoint(int j, ref int k, JoinType jointype); // 0x0000000188AA5B54-0x0000000188AA61DC
		internal void DoSquare(int j, int k); // 0x0000000188AA51F8-0x0000000188AA55F8
		internal void DoMiter(int j, int k, double r); // 0x0000000188AA3AF4-0x0000000188AA3CC4
		internal void DoRound(int j, int k); // 0x0000000188AA4E64-0x0000000188AA51F8
	}

	internal class ClipperException : Exception // TypeDefIndex: 89767
	{
		// Constructors
		public ClipperException(string description); // 0x0000000188AAD698-0x0000000188AADF74
	}
}
