/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 102: Priority Queue.dll - Assembly: PriorityQueue, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59592-59606
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Priority_Queue
{
	public sealed class FastPriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 59594
		where T : FastPriorityQueueNode
	{
		// Fields
		private int _numNodes;
		private T[] _nodes;
	
		// Properties
		public int Count { get => default; }
		public int MaxSize { get => default; }
		public T First { get => default; }
	
		// Constructors
		public FastPriorityQueue() {} // Dummy constructor
		public FastPriorityQueue(int maxNodes) {}
	
		// Methods
		public void Clear() {}
		public bool Contains(T node) => default;
		public void Enqueue(T node, float priority) {}
		private void CascadeUp(T node) {}
		private void CascadeDown(T node) {}
		private bool HasHigherPriority(T higher, T lower) => default;
		private bool HasHigherOrEqualPriority(T higher, T lower) => default;
		public T Dequeue() => default;
		public void Resize(int maxNodes) {}
		public void UpdatePriority(T node, float priority) {}
		private void OnNodeUpdated(T node) {}
		public void Remove(T node) {}
		public void ResetNode(T node) {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__22))]
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class FastPriorityQueueNode // TypeDefIndex: 59595
	{
		// Properties
		public float Priority { get; protected internal set; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 0x0000000183D50CA0-0x0000000183D50CB0
		public int QueueIndex { get; internal set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
	
		// Constructors
		public FastPriorityQueueNode() {} // 0x000000018350B670-0x000000018350B680
	}

	public sealed class GenericPriorityQueue<TItem, TPriority> : IFixedSizePriorityQueue<TItem, TPriority> // TypeDefIndex: 59597
		where TItem : GenericPriorityQueueNode<TPriority>
	{
		// Fields
		private int _numNodes;
		private TItem[] _nodes;
		private long _numNodesEverEnqueued;
		private readonly Comparison<TPriority> _comparer;
	
		// Properties
		public int Count { get => default; }
		public int MaxSize { get => default; }
		public TItem First { get => default; }
	
		// Constructors
		public GenericPriorityQueue() {} // Dummy constructor
		public GenericPriorityQueue(int maxNodes) {}
		public GenericPriorityQueue(int maxNodes, IComparer<TPriority> comparer) {}
		public GenericPriorityQueue(int maxNodes, Comparison<TPriority> comparer) {}
	
		// Methods
		public void Clear() {}
		public bool Contains(TItem node) => default;
		public void Enqueue(TItem node, TPriority priority) {}
		private void CascadeUp(TItem node) {}
		private void CascadeDown(TItem node) {}
		private bool HasHigherPriority(TItem higher, TItem lower) => default;
		public TItem Dequeue() => default;
		public void Resize(int maxNodes) {}
		public void UpdatePriority(TItem node, TPriority priority) {}
		private void OnNodeUpdated(TItem node) {}
		public void Remove(TItem node) {}
		public void ResetNode(TItem node) {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__25))]
		public IEnumerator<TItem> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class GenericPriorityQueueNode<TPriority> // TypeDefIndex: 59598
	{
		// Properties
		public TPriority Priority { get; protected internal set; }
		public int QueueIndex { get; internal set; }
		public long InsertionIndex { get; internal set; }
	
		// Constructors
		public GenericPriorityQueueNode() {}
	}

	internal interface IFixedSizePriorityQueue<TItem, in TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 59599
	{
		// Properties
		int MaxSize { get; }
	
		// Methods
		void Resize(int maxNodes);
		void ResetNode(TItem node);
	}

	public interface IPriorityQueue<TItem, in TPriority> : IEnumerable<TItem> // TypeDefIndex: 59600
	{
		// Properties
		TItem First { get; }
		int Count { get; }
	
		// Methods
		void Enqueue(TItem node, TPriority priority);
		TItem Dequeue();
		void Clear();
		bool Contains(TItem node);
		void Remove(TItem node);
		void UpdatePriority(TItem node, TPriority priority);
	}

	public class SimplePriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 59602
	{
		// Fields
		private const int INITIAL_QUEUE_SIZE = 10; // Metadata: 0x01FDD1F0
		private readonly GenericPriorityQueue<SimpleNode, TPriority> _queue;
		private readonly Dictionary<TItem, IList<SimpleNode>> _itemToNodesCache;
		private readonly IList<SimpleNode> _nullNodesCache;
	
		// Properties
		public int Count { get => default; }
		public TItem First { get => default; }
	
		// Nested types
		private class SimpleNode : GenericPriorityQueueNode<TPriority> // TypeDefIndex: 59601
		{
			// Properties
			public TItem Data { get; private set; }
	
			// Constructors
			public SimpleNode() {} // Dummy constructor
			public SimpleNode(TItem data) {}
		}
	
		// Constructors
		public SimplePriorityQueue() {}
		public SimplePriorityQueue(IComparer<TPriority> priorityComparer) {}
		public SimplePriorityQueue(Comparison<TPriority> priorityComparer) {}
		public SimplePriorityQueue(IEqualityComparer<TItem> itemEquality) {}
		public SimplePriorityQueue(IComparer<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality) {}
		public SimplePriorityQueue(Comparison<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality) {}
	
		// Methods
		private SimpleNode GetExistingNode(TItem item) => default;
		private void AddToNodeCache(SimpleNode node) {}
		private void RemoveFromNodeCache(SimpleNode node) {}
		public void Clear() {}
		public bool Contains(TItem item) => default;
		public TItem Dequeue() => default;
		private SimpleNode EnqueueNoLockOrCache(TItem item, TPriority priority) => default;
		public void Enqueue(TItem item, TPriority priority) {}
		public bool EnqueueWithoutDuplicates(TItem item, TPriority priority) => default;
		public void Remove(TItem item) {}
		public void UpdatePriority(TItem item, TPriority priority) {}
		public TPriority GetPriority(TItem item) => default;
		public bool TryFirst(out ref TItem first) {
			first = default;
			return default;
		}
		public bool TryDequeue(out ref TItem first) {
			first = default;
			return default;
		}
		public bool TryRemove(TItem item) => default;
		public bool TryUpdatePriority(TItem item, TPriority priority) => default;
		public bool TryGetPriority(TItem item, out ref TPriority priority) {
			priority = default;
			return default;
		}
		public IEnumerator<TItem> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class SimplePriorityQueue<TItem> : SimplePriorityQueue<TItem, float> // TypeDefIndex: 59603
	{
		// Constructors
		public SimplePriorityQueue() {}
		public SimplePriorityQueue(IComparer<float> comparer) {}
		public SimplePriorityQueue(Comparison<float> comparer) {}
	}

	public sealed class StablePriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 59605
		where T : StablePriorityQueueNode
	{
		// Fields
		private int _numNodes;
		private T[] _nodes;
		private long _numNodesEverEnqueued;
	
		// Properties
		public int Count { get => default; }
		public int MaxSize { get => default; }
		public T First { get => default; }
	
		// Constructors
		public StablePriorityQueue() {} // Dummy constructor
		public StablePriorityQueue(int maxNodes) {}
	
		// Methods
		public void Clear() {}
		public bool Contains(T node) => default;
		public void Enqueue(T node, float priority) {}
		private void CascadeUp(T node) {}
		private void CascadeDown(T node) {}
		private bool HasHigherPriority(T higher, T lower) => default;
		public T Dequeue() => default;
		public void Resize(int maxNodes) {}
		public void UpdatePriority(T node, float priority) {}
		private void OnNodeUpdated(T node) {}
		public void Remove(T node) {}
		public void ResetNode(T node) {}
		[IteratorStateMachine(typeof(_GetEnumerator_d__22))]
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class StablePriorityQueueNode : FastPriorityQueueNode // TypeDefIndex: 59606
	{
		// Properties
		public long InsertionIndex { get; internal set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
	
		// Constructors
		public StablePriorityQueueNode() {} // 0x000000018350B670-0x000000018350B680
	}
}
