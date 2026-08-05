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

// Image 79: clipper_library.dll - Assembly: clipper_library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62478-62503
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
	public struct DoublePoint // TypeDefIndex: 62479
	{
		// Fields
		public double X; // 0x00
		public double Y; // 0x08
	
		// Constructors
		public DoublePoint(double x = 0 /* Metadata: 0x02351B2F */, double y = 0 /* Metadata: 0x02351B37 */); // 0x0000000184D881B0-0x0000000184D881C0
		public DoublePoint(DoublePoint dp); // 0x0000000184D881A0-0x0000000184D881B0
	}

	public class PolyNode // TypeDefIndex: 62480
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
		public int ChildCount { get; } // 0x00000001867C4EE8-0x00000001867C4F28 
		public List<PolyNode> Childs { get; } // 0x00000001811F36E0-0x00000001811F36F0 
	
		// Constructors
		public PolyNode(); // 0x00000001867C4E28-0x00000001867C4EE8
	
		// Methods
		internal void AddChild(PolyNode Child); // 0x00000001867C4DA0-0x00000001867C4E28
	}

	internal struct Int128 // TypeDefIndex: 62481
	{
		// Fields
		private long hi; // 0x00
		private ulong lo; // 0x08
	
		// Constructors
		public Int128(long _hi, ulong _lo); // 0x0000000184D881E0-0x0000000184D881F0
	
		// Methods
		public static bool operator ==(Int128 val1, Int128 val2); // 0x00000001867C4BB4-0x00000001867C4C4C
		public override bool Equals(object obj); // 0x00000001867C4A84-0x00000001867C4AF8
		public override int GetHashCode(); // 0x0000000184D881C0-0x0000000184D881E0
		public static Int128 operator -(Int128 val); // 0x00000001867C4C4C-0x00000001867C4C78
		public static Int128 Int128Mul(long lhs, long rhs); // 0x00000001867C4AF8-0x00000001867C4BB4
	}

	public struct IntPoint // TypeDefIndex: 62482
	{
		// Fields
		public long X; // 0x00
		public long Y; // 0x08
	
		// Constructors
		public IntPoint(long X, long Y); // 0x0000000184D861B0-0x0000000184D861C0
		public IntPoint(double x, double y); // 0x0000000184D881F0-0x0000000184D88210
		public IntPoint(IntPoint pt); // 0x0000000184D881A0-0x0000000184D881B0
	
		// Methods
		public static bool operator ==(IntPoint a, IntPoint b); // 0x00000001867C4D3C-0x00000001867C4D54
		public static bool operator !=(IntPoint a, IntPoint b); // 0x00000001867C4D54-0x00000001867C4D6C
		public override bool Equals(object obj); // 0x00000001867C4C78-0x00000001867C4CEC
		public override int GetHashCode(); // 0x00000001867C4CEC-0x00000001867C4D3C
	}

	public struct IntRect // TypeDefIndex: 62483
	{
		// Fields
		public long left; // 0x00
		public long top; // 0x08
		public long right; // 0x10
		public long bottom; // 0x18
	
		// Constructors
		public IntRect(long l, long t, long r, long b); // 0x0000000184D861C0-0x0000000184D861E0
	}

	public enum ClipType // TypeDefIndex: 62484
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3
	}

	public enum PolyType // TypeDefIndex: 62485
	{
		ptSubject = 0,
		ptClip = 1
	}

	public enum PolyFillType // TypeDefIndex: 62486
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3
	}

	public enum JoinType // TypeDefIndex: 62487
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2
	}

	public enum EndType // TypeDefIndex: 62488
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4
	}

	internal enum EdgeSide // TypeDefIndex: 62489
	{
		esLeft = 0,
		esRight = 1
	}

	internal enum Direction // TypeDefIndex: 62490
	{
		dRightToLeft = 0,
		dLeftToRight = 1
	}

	internal class TEdge // TypeDefIndex: 62491
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
		public TEdge(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class IntersectNode // TypeDefIndex: 62492
	{
		// Fields
		internal TEdge Edge1; // 0x10
		internal TEdge Edge2; // 0x18
		internal IntPoint Pt; // 0x20
	
		// Constructors
		public IntersectNode(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class MyIntersectNodeSort : IComparer<ClipperLib.IntersectNode> // TypeDefIndex: 62493
	{
		// Constructors
		public MyIntersectNodeSort(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public int Compare(IntersectNode node1, IntersectNode node2); // 0x00000001867C4D6C-0x00000001867C4DA0
	}

	internal class LocalMinima // TypeDefIndex: 62494
	{
		// Fields
		internal long Y; // 0x10
		internal TEdge LeftBound; // 0x18
		internal TEdge RightBound; // 0x20
		internal LocalMinima Next; // 0x28
	
		// Constructors
		public LocalMinima(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class Scanbeam // TypeDefIndex: 62495
	{
		// Fields
		internal long Y; // 0x10
		internal Scanbeam Next; // 0x18
	
		// Constructors
		public Scanbeam(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class Maxima // TypeDefIndex: 62496
	{
		// Fields
		internal long X; // 0x10
		internal Maxima Next; // 0x18
		internal Maxima Prev; // 0x20
	
		// Constructors
		public Maxima(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class OutRec // TypeDefIndex: 62497
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
		public OutRec(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class OutPt // TypeDefIndex: 62498
	{
		// Fields
		internal int Idx; // 0x10
		internal IntPoint Pt; // 0x18
		internal OutPt Next; // 0x28
		internal OutPt Prev; // 0x30
	
		// Constructors
		public OutPt(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal class Join // TypeDefIndex: 62499
	{
		// Fields
		internal OutPt OutPt1; // 0x10
		internal OutPt OutPt2; // 0x18
		internal IntPoint OffPt; // 0x20
	
		// Constructors
		public Join(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ClipperBase // TypeDefIndex: 62500
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
		public bool PreserveCollinear { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86F30-0x0000000184D86F40 0x0000000184D86F50-0x0000000184D86F60
	
		// Constructors
		internal ClipperBase(); // 0x00000001867BADB8-0x00000001867BAE50
	
		// Methods
		internal static bool near_zero(double val); // 0x00000001867BAE50-0x00000001867BAE70
		public void Swap(ref long val1, ref long val2); // 0x0000000184D88130-0x0000000184D88140
		internal static bool IsHorizontal(TEdge e); // 0x00000001867B9E34-0x00000001867B9E50
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange); // 0x00000001867BA764-0x00000001867BA818
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange); // 0x00000001867BA6B0-0x00000001867BA764
		internal static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange); // 0x00000001867BA818-0x00000001867BA8DC
		public virtual void Clear(); // 0x00000001867B93B0-0x00000001867B94FC
		private void DisposeLocalMinimaList(); // 0x00000001867B9668-0x00000001867B96BC
		private void RangeTest(IntPoint Pt, ref bool useFullRange); // 0x00000001867BA468-0x00000001867BA53C
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt); // 0x00000001867B9C44-0x00000001867B9C8C
		private void InitEdge2(TEdge e, PolyType polyType); // 0x00000001867B9BCC-0x00000001867B9C44
		private TEdge FindNextLocMin(TEdge E); // 0x00000001867B9748-0x00000001867B9870
		private TEdge ProcessBound(TEdge E, bool LeftBoundIsForward); // 0x00000001867B9EEC-0x00000001867BA390
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed); // 0x00000001867B8810-0x00000001867B92EC
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed); // 0x00000001867B92EC-0x00000001867B93B0
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3); // 0x00000001867BA390-0x00000001867BA468
		private TEdge RemoveEdge(TEdge e); // 0x00000001867BA53C-0x00000001867BA59C
		private void SetDx(TEdge e); // 0x00000001867BA658-0x00000001867BA6B0
		private void InsertLocalMinima(LocalMinima newLm); // 0x00000001867B9C8C-0x00000001867B9D14
		internal bool PopLocalMinima(long Y, out LocalMinima current); // 0x00000001867B9E5C-0x00000001867B9EA4
		private void ReverseHorizontal(TEdge e); // 0x00000001867BA634-0x00000001867BA658
		internal virtual void Reset(); // 0x00000001867BA59C-0x00000001867BA634
		public static IntRect GetBounds(List<List<IntPoint>> paths); // 0x00000001867B9870-0x00000001867B9BCC
		internal void InsertScanbeam(long Y); // 0x00000001867B9D14-0x00000001867B9E34
		internal bool PopScanbeam(out long Y); // 0x00000001867B9EA4-0x00000001867B9EEC
		internal bool LocalMinimaPending(); // 0x00000001867B9E50-0x00000001867B9E5C
		internal OutRec CreateOutRec(); // 0x00000001867B94FC-0x00000001867B95D0
		internal void DisposeOutRec(int index); // 0x00000001867B96BC-0x00000001867B9748
		internal void UpdateEdgeIntoAEL(ref TEdge e); // 0x00000001867BAB78-0x00000001867BADB8
		internal void SwapPositionsInAEL(TEdge edge1, TEdge edge2); // 0x00000001867BA8DC-0x00000001867BAB78
		internal void DeleteFromAEL(TEdge e); // 0x00000001867B95D0-0x00000001867B9668
	}

	public class Clipper : ClipperBase // TypeDefIndex: 62501
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
		public bool ReverseSolution { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88160-0x0000000184D88170 0x0000000184D88180-0x0000000184D88190
		public bool StrictlySimple { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88170-0x0000000184D88180 0x0000000184D88190-0x0000000184D881A0
	
		// Constructors
		public Clipper(int InitOptions = 0 /* Metadata: 0x02351B55 */); // 0x00000001867C4888-0x00000001867C4A84
	
		// Methods
		private void InsertMaxima(long X); // 0x00000001867C1460-0x00000001867C1590
		public bool Execute(ClipType clipType, List<List<IntPoint>> solution, PolyFillType subjFillType, PolyFillType clipFillType); // 0x00000001867BF844-0x00000001867BF9D8
		private bool ExecuteInternal(); // 0x00000001867BF300-0x00000001867BF844
		private void DisposeAllPolyPts(); // 0x00000001867BEC6C-0x00000001867BECE8
		private void AddJoin(OutPt Op1, OutPt Op2, IntPoint OffPt); // 0x00000001867BDD98-0x00000001867BDE4C
		private void AddGhostJoin(OutPt Op, IntPoint OffPt); // 0x00000001867BDCFC-0x00000001867BDD98
		private void InsertLocalMinimaIntoAEL(long botY); // 0x00000001867C0F6C-0x00000001867C1460
		private void InsertEdgeIntoAEL(TEdge edge, TEdge startEdge); // 0x00000001867C0DF0-0x00000001867C0F6C
		private bool E2InsertsBeforeE1(TEdge e1, TEdge e2); // 0x00000001867BF24C-0x00000001867BF2C0
		private bool IsEvenOddFillType(TEdge edge); // 0x00000001867C1E3C-0x00000001867C1E64
		private bool IsEvenOddAltFillType(TEdge edge); // 0x00000001867C1E14-0x00000001867C1E3C
		private bool IsContributing(TEdge edge); // 0x00000001867C1CF8-0x00000001867C1E14
		private void SetWindingCount(TEdge edge); // 0x00000001867C432C-0x00000001867C4514
		private void AddEdgeToSEL(TEdge edge); // 0x00000001867BDC50-0x00000001867BDCFC
		internal bool PopEdgeFromSEL(out TEdge e); // 0x00000001867C31C8-0x00000001867C3250
		private void CopyAELToSEL(); // 0x00000001867BEC10-0x00000001867BEC6C
		private void SwapPositionsInSEL(TEdge edge1, TEdge edge2); // 0x00000001867C453C-0x00000001867C47EC
		private void AddLocalMaxPoly(TEdge e1, TEdge e2, IntPoint pt); // 0x00000001867BDE4C-0x00000001867BDEF8
		private OutPt AddLocalMinPoly(TEdge e1, TEdge e2, IntPoint pt); // 0x00000001867BDEF8-0x00000001867BE128
		private OutPt AddOutPt(TEdge e, IntPoint pt); // 0x00000001867BE128-0x00000001867BE370
		private OutPt GetLastOutPt(TEdge e); // 0x00000001867C09DC-0x00000001867C0A5C
		private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b); // 0x00000001867C0DB8-0x00000001867C0DF0
		private void SetHoleState(TEdge e, OutRec outRec); // 0x00000001867C423C-0x00000001867C432C
		private double GetDx(IntPoint pt1, IntPoint pt2); // 0x00000001867C0954-0x00000001867C098C
		private bool FirstIsBottomPt(OutPt btmPt1, OutPt btmPt2); // 0x00000001867BF9D8-0x00000001867BFD14
		private OutPt GetBottomPt(OutPt pp); // 0x00000001867C0860-0x00000001867C0954
		private OutRec GetLowermostRec(OutRec outRec1, OutRec outRec2); // 0x00000001867C0A5C-0x00000001867C0B2C
		private bool OutRec1RightOfOutRec2(OutRec outRec1, OutRec outRec2); // 0x00000001867C2DE0-0x00000001867C2E08
		private OutRec GetOutRec(int idx); // 0x00000001867C0C54-0x00000001867C0CE0
		private void AppendPolygon(TEdge e1, TEdge e2); // 0x00000001867BE370-0x00000001867BE6A8
		private void ReversePolyPtLinks(OutPt pp); // 0x00000001867C41F0-0x00000001867C423C
		private static void SwapSides(TEdge edge1, TEdge edge2); // 0x00000001867C47EC-0x00000001867C4814
		private static void SwapPolyIndexes(TEdge edge1, TEdge edge2); // 0x00000001867C4514-0x00000001867C453C
		private void IntersectEdges(TEdge e1, TEdge e2, IntPoint pt); // 0x00000001867C1590-0x00000001867C1A4C
		private void ProcessHorizontals(); // 0x00000001867C3F34-0x00000001867C3F84
		private void GetHorzDirection(TEdge HorzEdge, out Direction Dir, out long Left, out long Right); // 0x00000001867C098C-0x00000001867C09DC
		private void ProcessHorizontal(TEdge horzEdge); // 0x00000001867C3744-0x00000001867C3F34
		private TEdge GetNextInAEL(TEdge e, Direction Direction); // 0x00000001867C0C24-0x00000001867C0C54
		private bool IsMaxima(TEdge e, double Y); // 0x00000001867C1E98-0x00000001867C1EC0
		private bool IsIntermediate(TEdge e, double Y); // 0x00000001867C1E64-0x00000001867C1E98
		internal TEdge GetMaximaPair(TEdge e); // 0x00000001867C0B74-0x00000001867C0C24
		internal TEdge GetMaximaPairEx(TEdge e); // 0x00000001867C0B2C-0x00000001867C0B74
		private bool ProcessIntersections(long topY); // 0x00000001867C4058-0x00000001867C41F0
		private void BuildIntersectList(long topY); // 0x00000001867BE860-0x00000001867BEA54
		private bool EdgesAdjacent(IntersectNode inode); // 0x00000001867BF2C0-0x00000001867BF300
		private bool FixupIntersectionOrder(); // 0x00000001867C0350-0x00000001867C0550
		private void ProcessIntersectList(); // 0x00000001867C3F84-0x00000001867C4058
		internal static long Round(double value); // 0x00000001867BDB50-0x00000001867BDB74
		private static long TopX(TEdge edge, long currentY); // 0x00000001867C4814-0x00000001867C4858
		private void IntersectPoint(TEdge edge1, TEdge edge2, out IntPoint ip); // 0x00000001867C1A4C-0x00000001867C1CF8
		private void ProcessEdgesAtTopOfScanbeam(long topY); // 0x00000001867C3250-0x00000001867C3744
		private void DoMaxima(TEdge e); // 0x00000001867BECE8-0x00000001867BEEC8
		public static bool Orientation(List<IntPoint> poly); // 0x00000001867C2DC4-0x00000001867C2DE0
		private int PointCount(OutPt pts); // 0x00000001867C2E24-0x00000001867C2E50
		private void BuildResult(List<List<IntPoint>> polyg); // 0x00000001867BEA54-0x00000001867BEC10
		private void FixupOutPolyline(OutRec outrec); // 0x00000001867C0770-0x00000001867C0860
		private void FixupOutPolygon(OutRec outRec); // 0x00000001867C0550-0x00000001867C0770
		private OutPt DupOutPt(OutPt outPt, bool InsertAfter); // 0x00000001867BF150-0x00000001867BF24C
		private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right); // 0x00000001867C0CE0-0x00000001867C0DB8
		private bool JoinHorz(OutPt op1, OutPt op1b, OutPt op2, OutPt op2b, IntPoint Pt, bool DiscardLeft); // 0x00000001867C226C-0x00000001867C265C
		private bool JoinPoints(Join j, OutRec outRec1, OutRec outRec2); // 0x00000001867C265C-0x00000001867C2DC4
		public static int PointInPolygon(IntPoint pt, List<IntPoint> path); // 0x00000001867C2E50-0x00000001867C3028
		private static int PointInPolygon(IntPoint pt, OutPt op); // 0x00000001867C3028-0x00000001867C3164
		private static bool Poly2ContainsPoly1(OutPt outPt1, OutPt outPt2); // 0x00000001867C3164-0x00000001867C31C8
		private void FixupFirstLefts1(OutRec OldOutRec, OutRec NewOutRec); // 0x00000001867BFD14-0x00000001867BFED4
		private void FixupFirstLefts2(OutRec innerOutRec, OutRec outerOutRec); // 0x00000001867BFED4-0x00000001867C01B8
		private void FixupFirstLefts3(OutRec OldOutRec, OutRec NewOutRec); // 0x00000001867C01B8-0x00000001867C0350
		private static OutRec ParseFirstLeft(OutRec FirstLeft); // 0x00000001867C2E08-0x00000001867C2E24
		private void JoinCommonEdges(); // 0x00000001867C1EC0-0x00000001867C226C
		private void UpdateOutPtIdxs(OutRec outrec); // 0x00000001867C4858-0x00000001867C4888
		private void DoSimplePolygons(); // 0x00000001867BEEC8-0x00000001867BF150
		public static double Area(List<IntPoint> poly); // 0x00000001867BE72C-0x00000001867BE860
		internal double Area(OutRec outRec); // 0x00000001867BE6A8-0x00000001867BE6C8
		internal double Area(OutPt op); // 0x00000001867BE6C8-0x00000001867BE72C
	}

	public class ClipperOffset // TypeDefIndex: 62502
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
		private const double two_pi = 6.283185307179586; // Metadata: 0x02351B66
		private const double def_arc_tolerance = 0.25; // Metadata: 0x02351B6E
	
		// Properties
		public double ArcTolerance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86E70-0x0000000184D86E80 0x0000000184D86EC0-0x0000000184D86ED0
		public double MiterLimit { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88140-0x0000000184D88150 0x0000000184D88150-0x0000000184D88160
	
		// Constructors
		public ClipperOffset(double miterLimit = 2 /* Metadata: 0x02351B56 */, double arcTolerance = 0.25 /* Metadata: 0x02351B5E */); // 0x00000001867BDB74-0x00000001867BDC50
	
		// Methods
		public void Clear(); // 0x00000001867BB418-0x00000001867BB46C
		internal static long Round(double value); // 0x00000001867BDB50-0x00000001867BDB74
		public void AddPath(List<IntPoint> path, JoinType joinType, EndType endType); // 0x00000001867BAE70-0x00000001867BB2E0
		public void AddPaths(List<List<IntPoint>> paths, JoinType joinType, EndType endType); // 0x00000001867BB2E0-0x00000001867BB418
		private void FixOrientations(); // 0x00000001867BD254-0x00000001867BD3EC
		internal static DoublePoint GetUnitNormal(IntPoint pt1, IntPoint pt2); // 0x00000001867BD3EC-0x00000001867BD4C8
		private void DoOffset(double delta); // 0x00000001867BB63C-0x00000001867BC7D8
		public void Execute(ref List<List<IntPoint>> solution, double delta); // 0x00000001867BCF78-0x00000001867BD254
		private void OffsetPoint(int j, ref int k, JoinType jointype); // 0x00000001867BD4C8-0x00000001867BDB50
		internal void DoSquare(int j, int k); // 0x00000001867BCB78-0x00000001867BCF78
		internal void DoMiter(int j, int k, double r); // 0x00000001867BB46C-0x00000001867BB63C
		internal void DoRound(int j, int k); // 0x00000001867BC7D8-0x00000001867BCB78
	}

	internal class ClipperException : Exception // TypeDefIndex: 62503
	{
		// Constructors
		public ClipperException(string description); // 0x00000001867C4F28-0x00000001867C5514
	}
}
