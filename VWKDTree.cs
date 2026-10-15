/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructures.ViliWonka.Heap;
using UnityEngine;

// Image 120: VWKDTree.dll - Assembly: VWKDTree, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 91045-91057

namespace DataStructures.ViliWonka.Heap
{
	public abstract class BaseHeap // TypeDefIndex: 91051
	{
		// Fields
		protected int nodesCount; // 0x10
		protected int maxSize; // 0x14
		protected float[] heap; // 0x18
		protected float tempHeap; // 0x20
	
		// Properties
		public int Count { get; } // 0x00000001828BC2B0-0x00000001828BC2C0 
		public float HeadValue { get; } // 0x000000018D9C5924-0x000000018D9C5950 
	
		// Constructors
		protected BaseHeap(int initialSize); // 0x000000018D9C58D0-0x000000018D9C5924
	
		// Methods
		public void Clear(); // 0x000000018723C880-0x000000018723C890
		protected int Parent(int index); // 0x0000000187264490-0x00000001872644A0
		protected int Left(int index); // 0x0000000187264480-0x0000000187264490
		protected int Right(int index); // 0x00000001872644A0-0x00000001872644B0
		protected void BubbleDownMax(int index); // 0x000000018D9C5374-0x000000018D9C54BC
		protected void BubbleUpMax(int index); // 0x000000018D9C5604-0x000000018D9C5670
		protected void BubbleDownMin(int index); // 0x000000018D9C54BC-0x000000018D9C5604
		protected void BubbleUpMin(int index); // 0x000000018D9C5670-0x000000018D9C56DC
		protected virtual void Swap(int A, int B); // 0x000000018D9C580C-0x000000018D9C5888
		protected virtual void UpsizeHeap(); // 0x000000018D9C5888-0x000000018D9C58D0
		public virtual void PushValue(float h); // 0x000000018D9C57C0-0x000000018D9C580C
		public virtual float PopValue(); // 0x000000018D9C5774-0x000000018D9C57C0
		public void FlushHeapResult(List<float> heapList); // 0x000000018D9C56DC-0x000000018D9C5774
	}

	public class KSmallestHeap : BaseHeap // TypeDefIndex: 91052
	{
		// Properties
		public bool Full { get; } // 0x000000018D9C86B0-0x000000018D9C86BC 
	
		// Constructors
		public KSmallestHeap(int maxEntries); // 0x000000018D9C86A8-0x000000018D9C86B0
	
		// Methods
		public override void PushValue(float h); // 0x000000018D9C8614-0x000000018D9C86A8
		public override float PopValue(); // 0x000000018D9C84C0-0x000000018D9C8578
		public void Print(); // 0x000000018D9C8578-0x000000018D9C8614
		public bool HeapPropertyHolds(int index, int depth = 0 /* Metadata: 0x0264B25C */); // 0x000000018D9C824C-0x000000018D9C84C0
	}

	public class KSmallestHeap<T> : KSmallestHeap // TypeDefIndex: 91053
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

	public class MaxHeap : BaseHeap // TypeDefIndex: 91054
	{
		// Constructors
		public MaxHeap(int initialSize = 2048 /* Metadata: 0x0264B25D */); // 0x000000018D9C86A8-0x000000018D9C86B0
	
		// Methods
		public override void PushValue(float h); // 0x000000018D9C8774-0x000000018D9C87E0
		public override float PopValue(); // 0x000000018D9C86BC-0x000000018D9C8774
	}

	public class MaxHeap<T> : MaxHeap // TypeDefIndex: 91055
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

	public class MinHeap : BaseHeap // TypeDefIndex: 91056
	{
		// Constructors
		public MinHeap(int initialSize = 2048 /* Metadata: 0x0264B25F */); // 0x000000018D9C86A8-0x000000018D9C86B0
	
		// Methods
		public override void PushValue(float h); // 0x000000018D9C8898-0x000000018D9C8904
		public override float PopValue(); // 0x000000018D9C87E0-0x000000018D9C8898
	}

	public class MinHeap<T> : MinHeap // TypeDefIndex: 91057
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get; }
	
		// Constructors
		public MinHeap(int maxNodes = 2048 /* Metadata: 0x0264B261 */);
	
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
	public struct KDBounds // TypeDefIndex: 91046
	{
		// Fields
		public Vector3 min; // 0x00
		public Vector3 max; // 0x0C
	
		// Properties
		public Vector3 size { get; } // 0x000000018D9C5AB8-0x000000018D9C5B10 
		public Bounds Bounds { get; } // 0x000000018D9C59CC-0x000000018D9C5AB8 
	
		// Methods
		public Vector3 ClosestPoint(Vector3 point); // 0x000000018D9C5950-0x000000018D9C59CC
	}

	public class KDNode // TypeDefIndex: 91047
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
		public int Count { get; } // 0x00000001872644B0-0x00000001872644C0 
		public bool Leaf { get; } // 0x000000018B8638AC-0x000000018B8638B4 
	
		// Constructors
		public KDNode(); // 0x00000001872399B0-0x00000001872399C0
	}

	public class KDQuery // TypeDefIndex: 91048
	{
		// Fields
		protected KDQueryNode[] queueArray; // 0x10
		protected MinHeap<KDQueryNode> minHeap; // 0x18
		protected int count; // 0x20
		protected int queryIndex; // 0x24
		private SortedList<int, KSmallestHeap<int>> _heaps; // 0x28
	
		// Properties
		protected int LeftToProcess { get; } // 0x00000001872644C0-0x00000001872644D0 
	
		// Constructors
		public KDQuery(int queryNodesContainersInitialSize = 2048 /* Metadata: 0x0264B255 */); // 0x000000018D9C7080-0x000000018D9C7174
	
		// Methods
		private KDQueryNode PushGetQueue(); // 0x000000018D9C6A40-0x000000018D9C6B38
		protected void PushToQueue(KDNode node, Vector3 tempClosestPoint); // 0x000000018D9C6C34-0x000000018D9C6C84
		protected void PushToHeap(KDNode node, Vector3 tempClosestPoint, Vector3 queryPosition); // 0x000000018D9C6B38-0x000000018D9C6C34
		protected KDQueryNode PopFromQueue(); // 0x000000018D9C6A0C-0x000000018D9C6A40
		protected KDQueryNode PopFromHeap(); // 0x000000018D9C6978-0x000000018D9C6A0C
		protected void Reset(); // 0x000000018D9C705C-0x000000018D9C7080
		public void DrawLastQuery(); // 0x000000018D9C5EFC-0x000000018D9C6080
		public void ClosestPoint(KDTree tree, Vector3 queryPosition, List<int> resultIndices, List<float> resultDistances = null); // 0x000000018D9C5B10-0x000000018D9C5EFC
		public void Interval(KDTree tree, Vector3 min, Vector3 max, List<int> resultIndices); // 0x000000018D9C6080-0x000000018D9C64A0
		public void KNearest(KDTree tree, Vector3 queryPosition, int k, List<int> resultIndices, List<float> resultDistances = null); // 0x000000018D9C64A0-0x000000018D9C6978
		public void Radius(KDTree tree, Vector3 queryPosition, float queryRadius, List<int> resultIndices); // 0x000000018D9C6C84-0x000000018D9C705C
	}

	public class KDQueryNode // TypeDefIndex: 91049
	{
		// Fields
		public KDNode node; // 0x10
		public Vector3 tempClosestPoint; // 0x18
		public float distance; // 0x24
	
		// Constructors
		public KDQueryNode(); // 0x0000000186805BA0-0x0000000186805BB0
		public KDQueryNode(KDNode node, Vector3 tempClosestPoint); // 0x0000000188A9FC90-0x0000000188A9FCC0
	}

	public class KDTree // TypeDefIndex: 91050
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
		public KDNode RootNode { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public Vector3[] Points { get; } // 0x0000000182234E30-0x0000000182234E40 
		public int[] Permutation { get; } // 0x000000018225E800-0x000000018225E810 
		public int Count { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
	
		// Constructors
		public KDTree(int maxPointsPerLeafNode = 32 /* Metadata: 0x0264B257 */); // 0x000000018D9C80D4-0x000000018D9C8188
		public KDTree(Vector3[] points, int maxPointsPerLeafNode = 32 /* Metadata: 0x0264B258 */); // 0x000000018D9C8188-0x000000018D9C824C
	
		// Methods
		public void Build(Vector3[] newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x0264B259 */); // 0x000000018D9C72E4-0x000000018D9C7390
		public void Build(List<Vector3> newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x0264B25A */); // 0x000000018D9C7204-0x000000018D9C72E4
		public void Rebuild(int maxPointsPerLeafNode = -1 /* Metadata: 0x0264B25B */); // 0x000000018D9C7DC4-0x000000018D9C7E10
		public void SetCount(int newSize); // 0x000000018D9C7E10-0x000000018D9C7E90
		private void BuildTree(); // 0x000000018D9C7174-0x000000018D9C7204
		private KDNode GetKDNode(); // 0x000000018D9C761C-0x000000018D9C7728
		private void ResetKDNodeStack(); // 0x00000001872644D0-0x00000001872644E0
		private KDBounds MakeBounds(); // 0x000000018D9C7728-0x000000018D9C7C88
		private void SplitNode(KDNode parent); // 0x000000018D9C7E90-0x000000018D9C80D4
		private float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis); // 0x000000018D9C7390-0x000000018D9C75FC
		private int Partition(int start, int end, float partitionPivot, int axis); // 0x000000018D9C7C88-0x000000018D9C7DC4
		private bool ContinueSplit(KDNode node); // 0x000000018D9C75FC-0x000000018D9C761C
	}
}
