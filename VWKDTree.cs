/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DataStructures.ViliWonka.Heap;
using UnityEngine;

// Image 113: VWKDTree.dll - Assembly: VWKDTree, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59837-59849
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace DataStructures.ViliWonka.Heap
{
	public abstract class BaseHeap // TypeDefIndex: 59843
	{
		// Fields
		protected int nodesCount; // 0x10
		protected int maxSize; // 0x14
		protected float[] heap; // 0x18
		protected float tempHeap; // 0x20
	
		// Properties
		public int Count { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public float HeadValue { get; } // 0x000000018A2978AC-0x000000018A2978D8 
	
		// Constructors
		protected BaseHeap() {} // Dummy constructor
		protected BaseHeap(int initialSize) {} // 0x000000018A297858-0x000000018A2978AC
	
		// Methods
		public void Clear() {} // 0x0000000183D58F70-0x0000000183D58F80
		protected int Parent(int index) => default; // 0x0000000183D8A1A0-0x0000000183D8A1B0
		protected int Left(int index) => default; // 0x0000000183D8A190-0x0000000183D8A1A0
		protected int Right(int index) => default; // 0x0000000183D8A1B0-0x0000000183D8A1C0
		protected void BubbleDownMax(int index) {} // 0x000000018A297308-0x000000018A297450
		protected void BubbleUpMax(int index) {} // 0x000000018A297598-0x000000018A297604
		protected void BubbleDownMin(int index) {} // 0x000000018A297450-0x000000018A297598
		protected void BubbleUpMin(int index) {} // 0x000000018A297604-0x000000018A297670
		protected virtual void Swap(int A, int B) {} // 0x000000018A297794-0x000000018A297810
		protected virtual void UpsizeHeap() {} // 0x000000018A297810-0x000000018A297858
		public virtual void PushValue(float h) {} // 0x000000018A297748-0x000000018A297794
		public virtual float PopValue() => default; // 0x000000018A2976FC-0x000000018A297748
		public void FlushHeapResult(List<float> heapList) {} // 0x000000018A297670-0x000000018A2976FC
	}

	public class KSmallestHeap : BaseHeap // TypeDefIndex: 59844
	{
		// Properties
		public bool Full { get => default; } // 0x000000018A29A5B0-0x000000018A29A5BC 
	
		// Constructors
		public KSmallestHeap() {} // Dummy constructor
		public KSmallestHeap(int maxEntries) {} // 0x000000018A29A5A8-0x000000018A29A5B0
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018A29A514-0x000000018A29A5A8
		public override float PopValue() => default; // 0x000000018A29A3C0-0x000000018A29A478
		public void Print() {} // 0x000000018A29A478-0x000000018A29A514
		public bool HeapPropertyHolds(int index, int depth = 0 /* Metadata: 0x01FDD302 */) => default; // 0x000000018A29A14C-0x000000018A29A3C0
	}

	public class KSmallestHeap<T> : KSmallestHeap // TypeDefIndex: 59845
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

	public class MaxHeap : BaseHeap // TypeDefIndex: 59846
	{
		// Constructors
		public MaxHeap() {} // Dummy constructor
		public MaxHeap(int initialSize = 2048 /* Metadata: 0x01FDD303 */) {} // 0x000000018A29A5A8-0x000000018A29A5B0
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018A29A674-0x000000018A29A6E0
		public override float PopValue() => default; // 0x000000018A29A5BC-0x000000018A29A674
	}

	public class MaxHeap<T> : MaxHeap // TypeDefIndex: 59847
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

	public class MinHeap : BaseHeap // TypeDefIndex: 59848
	{
		// Constructors
		public MinHeap() {} // Dummy constructor
		public MinHeap(int initialSize = 2048 /* Metadata: 0x01FDD305 */) {} // 0x000000018A29A5A8-0x000000018A29A5B0
	
		// Methods
		public override void PushValue(float h) {} // 0x000000018A29A798-0x000000018A29A998
		public override float PopValue() => default; // 0x000000018A29A6E0-0x000000018A29A798
	}

	public class MinHeap<T> : MinHeap // TypeDefIndex: 59849
	{
		// Fields
		private T[] objs;
		private T tempObjs;
	
		// Properties
		public T HeadHeapObject { get => default; }
	
		// Constructors
		public MinHeap() {} // Dummy constructor
		public MinHeap(int maxNodes = 2048 /* Metadata: 0x01FDD307 */) {}
	
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
	public struct KDBounds // TypeDefIndex: 59838
	{
		// Fields
		public Vector3 min; // 0x00
		public Vector3 max; // 0x0C
	
		// Properties
		public Vector3 size { get => default; } // 0x000000018A297A40-0x000000018A297A98 
		public Bounds Bounds { get => default; } // 0x000000018A297954-0x000000018A297A40 
	
		// Methods
		public Vector3 ClosestPoint(Vector3 point) => default; // 0x000000018A2978D8-0x000000018A297954
	}

	public class KDNode // TypeDefIndex: 59839
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
		public int Count { get => default; } // 0x0000000183D8A1C0-0x0000000183D8A1D0 
		public bool Leaf { get => default; } // 0x0000000187D3D2AC-0x0000000187D3D2B4 
	
		// Constructors
		public KDNode() {} // 0x0000000183D55820-0x0000000183D55830
	}

	public class KDQuery // TypeDefIndex: 59840
	{
		// Fields
		protected KDQueryNode[] queueArray; // 0x10
		protected MinHeap<KDQueryNode> minHeap; // 0x18
		protected int count; // 0x20
		protected int queryIndex; // 0x24
		private SortedList<int, KSmallestHeap<int>> _heaps; // 0x28
	
		// Properties
		protected int LeftToProcess { get => default; } // 0x0000000183D8A1D0-0x0000000183D8A1E0 
	
		// Constructors
		public KDQuery() {} // Dummy constructor
		public KDQuery(int queryNodesContainersInitialSize = 2048 /* Metadata: 0x01FDD2FB */) {} // 0x000000018A298FCC-0x000000018A2990C0
	
		// Methods
		private KDQueryNode PushGetQueue() => default; // 0x000000018A298994-0x000000018A298A8C
		protected void PushToQueue(KDNode node, Vector3 tempClosestPoint) {} // 0x000000018A298B88-0x000000018A298BD8
		protected void PushToHeap(KDNode node, Vector3 tempClosestPoint, Vector3 queryPosition) {} // 0x000000018A298A8C-0x000000018A298B88
		protected KDQueryNode PopFromQueue() => default; // 0x000000018A298960-0x000000018A298994
		protected KDQueryNode PopFromHeap() => default; // 0x000000018A2988CC-0x000000018A298960
		protected void Reset() {} // 0x000000018A298FA8-0x000000018A298FCC
		public void DrawLastQuery() {} // 0x000000018A297E80-0x000000018A297FFC
		public void ClosestPoint(KDTree tree, Vector3 queryPosition, List<int> resultIndices, List<float> resultDistances = null) {} // 0x000000018A297A98-0x000000018A297E80
		public void Interval(KDTree tree, Vector3 min, Vector3 max, List<int> resultIndices) {} // 0x000000018A297FFC-0x000000018A298410
		public void KNearest(KDTree tree, Vector3 queryPosition, int k, List<int> resultIndices, List<float> resultDistances = null) {} // 0x000000018A298410-0x000000018A2988CC
		public void Radius(KDTree tree, Vector3 queryPosition, float queryRadius, List<int> resultIndices) {} // 0x000000018A298BD8-0x000000018A298FA8
	}

	public class KDQueryNode // TypeDefIndex: 59841
	{
		// Fields
		public KDNode node; // 0x10
		public Vector3 tempClosestPoint; // 0x18
		public float distance; // 0x24
	
		// Constructors
		public KDQueryNode() {} // 0x000000018350B670-0x000000018350B680
		public KDQueryNode(KDNode node, Vector3 tempClosestPoint) {} // 0x0000000185574900-0x0000000185574930
	}

	public class KDTree // TypeDefIndex: 59842
	{
		// Fields
		private Vector3[] points; // 0x18
		private int[] permutation; // 0x20
		private int maxPointsPerLeafNode; // 0x2C
		private KDNode[] kdNodesStack; // 0x30
		private int kdNodesCount; // 0x38
	
		// Properties
		public KDNode RootNode { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public Vector3[] Points { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public int[] Permutation { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int Count { get; private set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
	
		// Constructors
		public KDTree() {} // Dummy constructor
		public KDTree(int maxPointsPerLeafNode = 32 /* Metadata: 0x01FDD2FD */) {} // 0x000000018A299FD8-0x000000018A29A088
		public KDTree(Vector3[] points, int maxPointsPerLeafNode = 32 /* Metadata: 0x01FDD2FE */) {} // 0x000000018A29A088-0x000000018A29A14C
	
		// Methods
		public void Build(Vector3[] newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x01FDD2FF */) {} // 0x000000018A29922C-0x000000018A2992D8
		public void Build(List<Vector3> newPoints, int maxPointsPerLeafNode = -1 /* Metadata: 0x01FDD300 */) {} // 0x000000018A29914C-0x000000018A29922C
		public void Rebuild(int maxPointsPerLeafNode = -1 /* Metadata: 0x01FDD301 */) {} // 0x000000018A299CD0-0x000000018A299D1C
		public void SetCount(int newSize) {} // 0x000000018A299D1C-0x000000018A299D9C
		private void BuildTree() {} // 0x000000018A2990C0-0x000000018A29914C
		private KDNode GetKDNode() => default; // 0x000000018A299528-0x000000018A29962C
		private void ResetKDNodeStack() {} // 0x0000000183D8A1E0-0x0000000183D8A1F0
		private KDBounds MakeBounds() => default; // 0x000000018A29962C-0x000000018A299BBC
		private void SplitNode(KDNode parent) {} // 0x000000018A299D9C-0x000000018A299FD8
		private float CalculatePivot(int start, int end, float boundsStart, float boundsEnd, int axis) => default; // 0x000000018A2992D8-0x000000018A299508
		private int Partition(int start, int end, float partitionPivot, int axis) => default; // 0x000000018A299BBC-0x000000018A299CD0
		private bool ContinueSplit(KDNode node) => default; // 0x000000018A299508-0x000000018A299528
	}
}
