/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using DataStructures.ViliWonka.Heap;
using UnityEngine;

// Image 117: VWKDTree.dll - Assembly: VWKDTree, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60958-60970

namespace DataStructures.ViliWonka.Heap
{
	public abstract class BaseHeap // TypeDefIndex: 60964
	{
		// Fields
		protected int nodesCount; // 0x10
		protected int maxSize; // 0x14
		protected float[] heap; // 0x18
		protected float tempHeap; // 0x20
	
		// Properties
		public int Count { get; } // 0x0000000181C0BBD0-0x0000000181C0BBE0 
		public float HeadValue { get; } // 0x000000018C3AF97C-0x000000018C3AF9A8 
	
		// Constructors
		protected BaseHeap() {} // Dummy constructor
		protected BaseHeap(int initialSize) {} // 0x000000018C3AF928-0x000000018C3AF97C
	
		// Methods
		public void Clear() {} // 0x0000000185FBA4D0-0x0000000185FBA4E0
		protected int Parent(int index) => default; // 0x0000000185FEAFE0-0x0000000185FEAFF0
		protected int Left(int index) => default; // 0x0000000185FEAFD0-0x0000000185FEAFE0
		protected int Right(int index) => default; // 0x0000000185FEAFF0-0x0000000185FEB000
		protected void BubbleDownMax(int index) {} // 0x000000018C3AF3D8-0x000000018C3AF520
		protected void BubbleUpMax(int index) {} // 0x000000018C3AF668-0x000000018C3AF6D4
		protected void BubbleDownMin(int index) {} // 0x000000018C3AF520-0x000000018C3AF668
		protected void BubbleUpMin(int index) {} // 0x000000018C3AF6D4-0x000000018C3AF740
		protected virtual void Swap(int A, int B) {} // 0x000000018C3AF864-0x000000018C3AF8E0
		protected virtual void UpsizeHeap() {} // 0x000000018C3AF8E0-0x000000018C3AF928
		public virtual void PushValue(float h) {} // 0x000000018C3AF818-0x000000018C3AF864
		public virtual float PopValue() => default; // 0x000000018C3AF7CC-0x000000018C3AF818
		public void FlushHeapResult(List<float> heapList) {} // 0x000000018C3AF740-0x000000018C3AF7CC
	}

	public class KSmallestHeap : BaseHeap // TypeDefIndex: 60965
	{
		// Properties
		public bool Full { get => default; } // 0x000000018C3B2680-0x000000018C3B268C 
	
		// Constructors
		public KSmallestHeap() {} // Dummy constructor
		public KSmallestHeap(int maxEntries) {} // 0x000000018C3B2678-0x000000018C3B2680
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018C3B25E4-0x000000018C3B2678
		public override float PopValue() => default; // 0x000000018C3B2490-0x000000018C3B2548
		public void Print() {} // 0x000000018C3B2548-0x000000018C3B25E4
		public bool HeapPropertyHolds(int index, int depth = 0 /* Metadata: 0x02082C57 */) => default; // 0x000000018C3B221C-0x000000018C3B2490
	}

	public class KSmallestHeap<T> : KSmallestHeap // TypeDefIndex: 60966
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get => default; }
	
		// Constructors
		public KSmallestHeap() {} // Dummy constructor
		public KSmallestHeap(int maxEntries) {}
	
		// Methods
		protected override void Swap(int A, int B) {}
		public override void PushValue(float h) {}
		public void PushObj(T obj, float h) {}
		public override float PopValue() => default;
		public T PopObj() => default;
		public T PopObj(ref float heapValue) => default;
		public void FlushResult(List<T> resultList, List<float> heapList = null) {}
	}

	public class MaxHeap : BaseHeap // TypeDefIndex: 60967
	{
		// Constructors
		public MaxHeap() {} // Dummy constructor
		public MaxHeap(int initialSize = 2048 /* Metadata: 0x02082C58 */) {} // 0x000000018C3B2678-0x000000018C3B2680
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018C3B2744-0x000000018C3B27B0
		public override float PopValue() => default; // 0x000000018C3B268C-0x000000018C3B2744
	}

	public class MaxHeap<T> : MaxHeap // TypeDefIndex: 60968
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get => default; }
	
		// Constructors
		public MaxHeap() {} // Dummy constructor
		public MaxHeap(int maxNodes) {}
	
		// Methods
		protected override void Swap(int A, int B) {}
		public override void PushValue(float h) {}
		public override float PopValue() => default;
		public void PushObj(T obj, float h) {}
		public T PopObj() => default;
		public T PopObj(ref float heapValue) => default;
		protected override void UpsizeHeap() {}
		public void FlushResult(List<T> resultList, List<float> heapList = null) {}
	}

	public class MinHeap : BaseHeap // TypeDefIndex: 60969
	{
		// Constructors
		public MinHeap() {} // Dummy constructor
		public MinHeap(int initialSize = 2048 /* Metadata: 0x02082C5A */) {} // 0x000000018C3B2678-0x000000018C3B2680
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018C3B2868-0x000000018C3B2A68
		public override float PopValue() => default; // 0x000000018C3B27B0-0x000000018C3B2868
	}

	public class MinHeap<T> : MinHeap // TypeDefIndex: 60970
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get => default; }
	
		// Constructors
		public MinHeap() {} // Dummy constructor
		public MinHeap(int maxNodes = 2048 /* Metadata: 0x02082C5C */) {}
	
		// Methods
		protected override void Swap(int A, int B) {}
		public override void PushValue(float h) {}
		public override float PopValue() => default;
		public void PushObj(T obj, float h) {}
		public T PopObj() => default;
		public T PopObj(ref float heapValue) => default;
		protected override void UpsizeHeap() {}
		public void FlushResult(List<T> resultList, List<float> heapList = null) {}
	}
}

namespace DataStructures.ViliWonka.KDTree
{
	public struct KDBounds // TypeDefIndex: 60959
	{
		// Fields
		public Vector3 min; // 0x00
		public Vector3 max; // 0x0C
	
		// Properties
		public Vector3 size { get => default; } // 0x000000018C3AFB10-0x000000018C3AFB68 
		public Bounds Bounds { get => default; } // 0x000000018C3AFA24-0x000000018C3AFB10 
	
		// Methods
		public Vector3 ClosestPoint(Vector3 point) => default; // 0x000000018C3AF9A8-0x000000018C3AFA24
	}

	public class KDNode // TypeDefIndex: 60960
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
		public int Count { get => default; } // 0x0000000185FEB000-0x0000000185FEB010 
		public bool Leaf { get => default; } // 0x0000000189EAD800-0x0000000189EAD808 
	
		// Constructors
		public KDNode() {} // 0x0000000185FB6AA0-0x0000000185FB6AB0
	}

	public class KDQuery // TypeDefIndex: 60961
	{
		// Fields
		protected KDQueryNode[] queueArray; // 0x10
		protected MinHeap<KDQueryNode> minHeap; // 0x18
		protected int count; // 0x20
		protected int queryIndex; // 0x24
		private SortedList<int, KSmallestHeap<int>> _heaps; // 0x28
	
		// Properties
		protected int LeftToProcess { get => default; } // 0x0000000185FEB010-0x0000000185FEB020 
	
		// Constructors
		public KDQuery() {} // Dummy constructor
		public KDQuery(int queryNodesContainersInitialSize = 2048 /* Metadata: 0x02082C50 */) {} // 0x000000018C3B109C-0x000000018C3B1190
	
		// Methods
		private KDQueryNode PushGetQueue() => default; // 0x000000018C3B0A64-0x000000018C3B0B5C
		protected void PushToQueue(KDNode node, Vector3 tempClosestPoint) {} // 0x000000018C3B0C58-0x000000018C3B0CA8
		protected void PushToHeap(KDNode node, Vector3 tempClosestPoint, Vector3 queryPosition) {} // 0x000000018C3B0B5C-0x000000018C3B0C58
		protected KDQueryNode PopFromQueue() => default; // 0x000000018C3B0A30-0x000000018C3B0A64
		protected KDQueryNode PopFromHeap() => default; // 0x000000018C3B099C-0x000000018C3B0A30
		protected void Reset() {} // 0x000000018C3B1078-0x000000018C3B109C
		public void DrawLastQuery() {} // 0x000000018C3AFF50-0x000000018C3B00CC
		public void ClosestPoint(KDTree tree, Vector3 queryPosition, List<int> resultIndices, List<float> resultDistances = null) {} // 0x000000018C3AFB68-0x000000018C3AFF50
		public void Interval(KDTree tree, Vector3 min, Vector3 max, List<int> resultIndices) {} // 0x000000018C3B00CC-0x000000018C3B04E0
		public void KNearest(KDTree tree, Vector3 queryPosition, int k, List<int> resultIndices, List<float> resultDistances = null) {} // 0x000000018C3B04E0-0x000000018C3B099C
		public void Radius(KDTree tree, Vector3 queryPosition, float queryRadius, List<int> resultIndices) {} // 0x000000018C3B0CA8-0x000000018C3B1078
	}

	public class KDQueryNode // TypeDefIndex: 60962
	{
		// Fields
		public KDNode node; // 0x10
		public Vector3 tempClosestPoint; // 0x18
		public float distance; // 0x24
	
		// Constructors
		public KDQueryNode() {} // 0x0000000185492010-0x0000000185492020
		public KDQueryNode(KDNode node, Vector3 tempClosestPoint) {} // 0x0000000187775EB4-0x0000000187775EE4
	}

	public class KDTree // TypeDefIndex: 60963
	{
		// Fields
		private KDNode _RootNode_k__BackingField; // 0x10
		private Vector3[] points; // 0x18
		private int[] permutation; // 0x20
		private int _Count_k__BackingField; // 0x28
		private int maxPointsPerLeafNode; // 0x2C
		private KDNode[] kdNodesStack; // 0x30
		private int kdNodesCount; // 0x38
	
		// Properties
		public KDNode RootNode { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public Vector3[] Points { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public int[] Permutation { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public int Count { get; private set; } // 0x0000000181C9AC80-0x0000000181C9AC90 0x0000000181C9A5C0-0x0000000181C9A5D0
	
		// Constructors
		public KDTree() {} // Dummy constructor
		public KDTree(int maxPointsPerLeafNode = 32 /* Metadata: 0x02082C52 */) {} // 0x000000018C3B20A8-0x000000018C3B2158
		public KDTree(Vector3[] points, int maxPointsPerLeafNode = 32 /* Metadata: 0x02082C53 */) {} // 0x000000018C3B2158-0x000000018C3B221C
	
		// Methods
		public void Build(Vector3[] newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x02082C54 */) {} // 0x000000018C3B12FC-0x000000018C3B13A8
		public void Build(List<Vector3> newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x02082C55 */) {} // 0x000000018C3B121C-0x000000018C3B12FC
		public void Rebuild(int maxPointsPerLeafNode = -1 /* Metadata: 0x02082C56 */) {} // 0x000000018C3B1DA0-0x000000018C3B1DEC
		public void SetCount(int newSize) {} // 0x000000018C3B1DEC-0x000000018C3B1E6C
		private void BuildTree() {} // 0x000000018C3B1190-0x000000018C3B121C
		private KDNode GetKDNode() => default; // 0x000000018C3B15F8-0x000000018C3B16FC
		private void ResetKDNodeStack() {} // 0x0000000185FEB020-0x0000000185FEB030
		private KDBounds MakeBounds() => default; // 0x000000018C3B16FC-0x000000018C3B1C8C
		private void SplitNode(KDNode parent) {} // 0x000000018C3B1E6C-0x000000018C3B20A8
		private float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis) => default; // 0x000000018C3B13A8-0x000000018C3B15D8
		private int Partition(int start, int end, float partitionPivot, int axis) => default; // 0x000000018C3B1C8C-0x000000018C3B1DA0
		private bool ContinueSplit(KDNode node) => default; // 0x000000018C3B15D8-0x000000018C3B15F8
	}
}
