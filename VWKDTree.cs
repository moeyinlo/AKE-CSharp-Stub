/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructures.ViliWonka.Heap;
using UnityEngine;

// Image 120: VWKDTree.dll - Assembly: VWKDTree, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 63601-63613
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DataStructures.ViliWonka.Heap
{
	public abstract class BaseHeap // TypeDefIndex: 63607
	{
		// Fields
		protected int nodesCount; // 0x10
		protected int maxSize; // 0x14
		protected float[] heap; // 0x18
		protected float tempHeap; // 0x20
	
		// Properties
		public int Count { get; } // 0x0000000182B2E2D0-0x0000000182B2E2E0 
		public float HeadValue { get; } // 0x000000018B89B3BC-0x000000018B89B3E8 
	
		// Constructors
		protected BaseHeap(int initialSize); // 0x000000018B89B368-0x000000018B89B3BC
	
		// Methods
		public void Clear(); // 0x0000000184D91EC0-0x0000000184D91ED0
		protected int Parent(int index); // 0x0000000184DBF650-0x0000000184DBF660
		protected int Left(int index); // 0x0000000184DBF640-0x0000000184DBF650
		protected int Right(int index); // 0x0000000184DBF660-0x0000000184DBF670
		protected void BubbleDownMax(int index); // 0x000000018B89AE18-0x000000018B89AF60
		protected void BubbleUpMax(int index); // 0x000000018B89B0A8-0x000000018B89B114
		protected void BubbleDownMin(int index); // 0x000000018B89AF60-0x000000018B89B0A8
		protected void BubbleUpMin(int index); // 0x000000018B89B114-0x000000018B89B180
		protected virtual void Swap(int A, int B); // 0x000000018B89B2A4-0x000000018B89B320
		protected virtual void UpsizeHeap(); // 0x000000018B89B320-0x000000018B89B368
		public virtual void PushValue(float h); // 0x000000018B89B258-0x000000018B89B2A4
		public virtual float PopValue(); // 0x000000018B89B20C-0x000000018B89B258
		public void FlushHeapResult(List<float> heapList); // 0x000000018B89B180-0x000000018B89B20C
	}

	public class KSmallestHeap : BaseHeap // TypeDefIndex: 63608
	{
		// Properties
		public bool Full { get; } // 0x000000018B89E0C0-0x000000018B89E0CC 
	
		// Constructors
		public KSmallestHeap(int maxEntries); // 0x000000018B89E0B8-0x000000018B89E0C0
	
		// Methods
		public override void PushValue(float h); // 0x000000018B89E024-0x000000018B89E0B8
		public override float PopValue(); // 0x000000018B89DED0-0x000000018B89DF88
		public void Print(); // 0x000000018B89DF88-0x000000018B89E024
		public bool HeapPropertyHolds(int index, int depth = 0 /* Metadata: 0x023528D6 */); // 0x000000018B89DC5C-0x000000018B89DED0
	}

	public class KSmallestHeap<T> : KSmallestHeap // TypeDefIndex: 63609
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get; }
	
		// Constructors
		public KSmallestHeap(int maxEntries);
	
		// Methods
		protected override void Swap(int A, int B);
		public override void PushValue(float h);
		public void PushObj(T obj, float h);
		public override float PopValue();
		public T PopObj();
		public T PopObj(ref float heapValue);
		public void FlushResult(List<T> resultList, List<float> heapList = null);
	}

	public class MaxHeap : BaseHeap // TypeDefIndex: 63610
	{
		// Constructors
		public MaxHeap(int initialSize = 2048 /* Metadata: 0x023528D7 */); // 0x000000018B89E0B8-0x000000018B89E0C0
	
		// Methods
		public override void PushValue(float h); // 0x000000018B89E184-0x000000018B89E1F0
		public override float PopValue(); // 0x000000018B89E0CC-0x000000018B89E184
	}

	public class MaxHeap<T> : MaxHeap // TypeDefIndex: 63611
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get; }
	
		// Constructors
		public MaxHeap(int maxNodes);
	
		// Methods
		protected override void Swap(int A, int B);
		public override void PushValue(float h);
		public override float PopValue();
		public void PushObj(T obj, float h);
		public T PopObj();
		public T PopObj(ref float heapValue);
		protected override void UpsizeHeap();
		public void FlushResult(List<T> resultList, List<float> heapList = null);
	}

	public class MinHeap : BaseHeap // TypeDefIndex: 63612
	{
		// Constructors
		public MinHeap(int initialSize = 2048 /* Metadata: 0x023528D9 */); // 0x000000018B89E0B8-0x000000018B89E0C0
	
		// Methods
		public override void PushValue(float h); // 0x000000018B89E2A8-0x000000018B89E4A8
		public override float PopValue(); // 0x000000018B89E1F0-0x000000018B89E2A8
	}

	public class MinHeap<T> : MinHeap // TypeDefIndex: 63613
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get; }
	
		// Constructors
		public MinHeap(int maxNodes = 2048 /* Metadata: 0x023528DB */);
	
		// Methods
		protected override void Swap(int A, int B);
		public override void PushValue(float h);
		public override float PopValue();
		public void PushObj(T obj, float h);
		public T PopObj();
		public T PopObj(ref float heapValue);
		protected override void UpsizeHeap();
		public void FlushResult(List<T> resultList, List<float> heapList = null);
	}
}

namespace DataStructures.ViliWonka.KDTree
{
	public struct KDBounds // TypeDefIndex: 63602
	{
		// Fields
		public Vector3 min; // 0x00
		public Vector3 max; // 0x0C
	
		// Properties
		public Vector3 size { get; } // 0x000000018B89B550-0x000000018B89B5A8 
		public Bounds Bounds { get; } // 0x000000018B89B464-0x000000018B89B550 
	
		// Methods
		public Vector3 ClosestPoint(Vector3 point); // 0x000000018B89B3E8-0x000000018B89B464
	}

	public class KDNode // TypeDefIndex: 63603
	{
		// Fields
		public float partitionCoordinate; // 0x10
		public int partitionAxis; // 0x14
		public KDNode negativeChild; // 0x18
		public KDNode positiveChild; // 0x20
		public int start; // 0x28
		public int end; // 0x2C
		public KDBounds bounds; // 0x30
	
		// Properties
		public int Count { get; } // 0x0000000184DBF670-0x0000000184DBF680 
		public bool Leaf { get; } // 0x0000000189300170-0x0000000189300178 
	
		// Constructors
		public KDNode(); // 0x0000000184D8CCE0-0x0000000184D8CCF0
	}

	public class KDQuery // TypeDefIndex: 63604
	{
		// Fields
		protected KDQueryNode[] queueArray; // 0x10
		protected MinHeap<KDQueryNode> minHeap; // 0x18
		protected int count; // 0x20
		protected int queryIndex; // 0x24
		private SortedList<int, KSmallestHeap<int>> _heaps; // 0x28
	
		// Properties
		protected int LeftToProcess { get; } // 0x0000000184DBF680-0x0000000184DBF690 
	
		// Constructors
		public KDQuery(int queryNodesContainersInitialSize = 2048 /* Metadata: 0x023528CF */); // 0x000000018B89CADC-0x000000018B89CBD0
	
		// Methods
		private KDQueryNode PushGetQueue(); // 0x000000018B89C4A4-0x000000018B89C59C
		protected void PushToQueue(KDNode node, Vector3 tempClosestPoint); // 0x000000018B89C698-0x000000018B89C6E8
		protected void PushToHeap(KDNode node, Vector3 tempClosestPoint, Vector3 queryPosition); // 0x000000018B89C59C-0x000000018B89C698
		protected KDQueryNode PopFromQueue(); // 0x000000018B89C470-0x000000018B89C4A4
		protected KDQueryNode PopFromHeap(); // 0x000000018B89C3DC-0x000000018B89C470
		protected void Reset(); // 0x000000018B89CAB8-0x000000018B89CADC
		public void DrawLastQuery(); // 0x000000018B89B990-0x000000018B89BB0C
		public void ClosestPoint(KDTree tree, Vector3 queryPosition, List<int> resultIndices, List<float> resultDistances = null); // 0x000000018B89B5A8-0x000000018B89B990
		public void Interval(KDTree tree, Vector3 min, Vector3 max, List<int> resultIndices); // 0x000000018B89BB0C-0x000000018B89BF20
		public void KNearest(KDTree tree, Vector3 queryPosition, int k, List<int> resultIndices, List<float> resultDistances = null); // 0x000000018B89BF20-0x000000018B89C3DC
		public void Radius(KDTree tree, Vector3 queryPosition, float queryRadius, List<int> resultIndices); // 0x000000018B89C6E8-0x000000018B89CAB8
	}

	public class KDQueryNode // TypeDefIndex: 63605
	{
		// Fields
		public KDNode node; // 0x10
		public Vector3 tempClosestPoint; // 0x18
		public float distance; // 0x24
	
		// Constructors
		public KDQueryNode(); // 0x00000001841E1670-0x00000001841E1680
		public KDQueryNode(KDNode node, Vector3 tempClosestPoint); // 0x00000001867B70A8-0x00000001867B70D8
	}

	public class KDTree // TypeDefIndex: 63606
	{
		// Fields
		[CompilerGenerated]
		private KDNode _RootNode_k__BackingField; // 0x10
		private Vector3[] points; // 0x18
		private int[] permutation; // 0x20
		[CompilerGenerated]
		private int _Count_k__BackingField; // 0x28
		private int maxPointsPerLeafNode; // 0x2C
		private KDNode[] kdNodesStack; // 0x30
		private int kdNodesCount; // 0x38
	
		// Properties
		public KDNode RootNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public Vector3[] Points { get; } // 0x000000018385B100-0x000000018385B110 
		public int[] Permutation { get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public int Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
	
		// Constructors
		public KDTree(int maxPointsPerLeafNode = 32 /* Metadata: 0x023528D1 */); // 0x000000018B89DAE8-0x000000018B89DB98
		public KDTree(Vector3[] points, int maxPointsPerLeafNode = 32 /* Metadata: 0x023528D2 */); // 0x000000018B89DB98-0x000000018B89DC5C
	
		// Methods
		public void Build(Vector3[] newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x023528D3 */); // 0x000000018B89CD3C-0x000000018B89CDE8
		public void Build(List<Vector3> newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x023528D4 */); // 0x000000018B89CC5C-0x000000018B89CD3C
		public void Rebuild(int maxPointsPerLeafNode = -1 /* Metadata: 0x023528D5 */); // 0x000000018B89D7E0-0x000000018B89D82C
		public void SetCount(int newSize); // 0x000000018B89D82C-0x000000018B89D8AC
		private void BuildTree(); // 0x000000018B89CBD0-0x000000018B89CC5C
		private KDNode GetKDNode(); // 0x000000018B89D038-0x000000018B89D13C
		private void ResetKDNodeStack(); // 0x0000000184DBF690-0x0000000184DBF6A0
		private KDBounds MakeBounds(); // 0x000000018B89D13C-0x000000018B89D6CC
		private void SplitNode(KDNode parent); // 0x000000018B89D8AC-0x000000018B89DAE8
		private float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis); // 0x000000018B89CDE8-0x000000018B89D018
		private int Partition(int start, int end, float partitionPivot, int axis); // 0x000000018B89D6CC-0x000000018B89D7E0
		private bool ContinueSplit(KDNode node); // 0x000000018B89D018-0x000000018B89D038
	}
}
