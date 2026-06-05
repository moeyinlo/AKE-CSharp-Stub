/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;

// Image 105: Priority Queue.dll - Assembly: PriorityQueue, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60696-60710

namespace Priority_Queue
{
	public sealed class FastPriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 60698
		where T : FastPriorityQueueNode
	{
		// Fields
		private int _numNodes;
		private T[] _nodes;
	
		// Properties
		public int Count { get => default; }
		public int MaxSize { get => default; }
		public T First { get => default; }
	
		// Nested types
		private sealed class _GetEnumerator_d__22 : IEnumerator<T> // TypeDefIndex: 60697
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public FastPriorityQueue<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__22() {} // Dummy constructor
			public _GetEnumerator_d__22(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
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
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class FastPriorityQueueNode // TypeDefIndex: 60699
	{
		// Fields
		private float _Priority_k__BackingField; // 0x10
		private int _QueueIndex_k__BackingField; // 0x14
	
		// Properties
		public float Priority { get; protected internal set; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 0x0000000181A6E380-0x0000000181A6E390
		public int QueueIndex { get; internal set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
	
		// Constructors
		public FastPriorityQueueNode() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class GenericPriorityQueue<TItem, TPriority> : IFixedSizePriorityQueue<TItem, TPriority> // TypeDefIndex: 60701
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
	
		// Nested types
		private sealed class _GetEnumerator_d__25 : IEnumerator<TItem> // TypeDefIndex: 60700
		{
			// Fields
			private int __1__state;
			private TItem __2__current;
			public GenericPriorityQueue<TItem, TPriority> __4__this;
			private int _i_5__2;
	
			// Properties
			TItem IEnumerator<TItem>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__25() {} // Dummy constructor
			public _GetEnumerator_d__25(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
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
		public IEnumerator<TItem> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class GenericPriorityQueueNode<TPriority> // TypeDefIndex: 60702
	{
		// Fields
		private TPriority _Priority_k__BackingField;
		private int _QueueIndex_k__BackingField;
		private long _InsertionIndex_k__BackingField;
	
		// Properties
		public TPriority Priority { get; protected internal set; }
		public int QueueIndex { get; internal set; }
		public long InsertionIndex { get; internal set; }
	
		// Constructors
		public GenericPriorityQueueNode() {}
	}

	internal interface IFixedSizePriorityQueue<TItem, in TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 60703
	{
		// Properties
		int MaxSize { get; }
	
		// Methods
		void Resize(int maxNodes);
		void ResetNode(TItem node);
	}

	public interface IPriorityQueue<TItem, in TPriority> : IEnumerable<TItem> // TypeDefIndex: 60704
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

	public class SimplePriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 60706
	{
		// Fields
		private const int INITIAL_QUEUE_SIZE = 10; // Metadata: 0x02082ADC
		private readonly GenericPriorityQueue<SimpleNode, TPriority> _queue;
		private readonly Dictionary<TItem, IList<SimpleNode>> _itemToNodesCache;
		private readonly IList<SimpleNode> _nullNodesCache;
	
		// Properties
		public int Count { get => default; }
		public TItem First { get => default; }
	
		// Nested types
		private class SimpleNode : GenericPriorityQueueNode<TPriority> // TypeDefIndex: 60705
		{
			// Fields
			private TItem _Data_k__BackingField;
	
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

	public class SimplePriorityQueue<TItem> : SimplePriorityQueue<TItem, float> // TypeDefIndex: 60707
	{
		// Constructors
		public SimplePriorityQueue() {}
		public SimplePriorityQueue(IComparer<float> comparer) {}
		public SimplePriorityQueue(Comparison<float> comparer) {}
	}

	public sealed class StablePriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 60709
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
	
		// Nested types
		private sealed class _GetEnumerator_d__22 : IEnumerator<T> // TypeDefIndex: 60708
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public StablePriorityQueue<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _GetEnumerator_d__22() {} // Dummy constructor
			public _GetEnumerator_d__22(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
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
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool IsValidQueue() => default;
	}

	public class StablePriorityQueueNode : FastPriorityQueueNode // TypeDefIndex: 60710
	{
		// Fields
		private long _InsertionIndex_k__BackingField; // 0x18
	
		// Properties
		public long InsertionIndex { get; internal set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000181448AC0-0x0000000181448AD0
	
		// Constructors
		public StablePriorityQueueNode() {} // 0x0000000185492010-0x0000000185492020
	}
}
