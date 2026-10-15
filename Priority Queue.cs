/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 107: Priority Queue.dll - Assembly: PriorityQueue, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90756-90770

namespace Priority_Queue
{
	public sealed class FastPriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 90758
		where T : FastPriorityQueueNode
	{
		// Fields
		private int _numNodes;
		private T[] _nodes;
	
		// Properties
		public int Count { get; }
		public int MaxSize { get; }
		public T First { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__22 : IEnumerator<T> // TypeDefIndex: 90757
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public FastPriorityQueue<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FastPriorityQueue(int maxNodes);
	
		// Methods
		public void Clear();
		public bool Contains(T node);
		public void Enqueue(T node, float priority);
		private void CascadeUp(T node);
		private void CascadeDown(T node);
		private bool HasHigherPriority(T higher, T lower);
		private bool HasHigherOrEqualPriority(T higher, T lower);
		public T Dequeue();
		public void Resize(int maxNodes);
		public void UpdatePriority(T node, float priority);
		private void OnNodeUpdated(T node);
		public void Remove(T node);
		public void ResetNode(T node);
		[IteratorStateMachine(typeof(_GetEnumerator_d__22))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool IsValidQueue();
	}

	public class FastPriorityQueueNode // TypeDefIndex: 90759
	{
		// Fields
		[CompilerGenerated]
		private float _Priority_k__BackingField; // 0x10
		[CompilerGenerated]
		private int _QueueIndex_k__BackingField; // 0x14
	
		// Properties
		public float Priority { [CompilerGenerated] get; [CompilerGenerated] protected internal set; } // 0x0000000187232D00-0x0000000187232D10 0x0000000187235230-0x0000000187235240
		public int QueueIndex { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
	
		// Constructors
		public FastPriorityQueueNode(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public sealed class GenericPriorityQueue<TItem, TPriority> : IFixedSizePriorityQueue<TItem, TPriority> // TypeDefIndex: 90761
		where TItem : GenericPriorityQueueNode<TPriority>
	{
		// Fields
		private int _numNodes;
		private TItem[] _nodes;
		private long _numNodesEverEnqueued;
		private readonly Comparison<TPriority> _comparer;
	
		// Properties
		public int Count { get; }
		public int MaxSize { get; }
		public TItem First { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__25 : IEnumerator<TItem> // TypeDefIndex: 90760
		{
			// Fields
			private int __1__state;
			private TItem __2__current;
			public GenericPriorityQueue<TItem, TPriority> __4__this;
			private int _i_5__2;
	
			// Properties
			TItem IEnumerator<TItem>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GenericPriorityQueue(int maxNodes);
		public GenericPriorityQueue(int maxNodes, IComparer<TPriority> comparer);
		public GenericPriorityQueue(int maxNodes, Comparison<TPriority> comparer);
	
		// Methods
		public void Clear();
		public bool Contains(TItem node);
		public void Enqueue(TItem node, TPriority priority);
		private void CascadeUp(TItem node);
		private void CascadeDown(TItem node);
		private bool HasHigherPriority(TItem higher, TItem lower);
		public TItem Dequeue();
		public void Resize(int maxNodes);
		public void UpdatePriority(TItem node, TPriority priority);
		private void OnNodeUpdated(TItem node);
		public void Remove(TItem node);
		public void ResetNode(TItem node);
		[IteratorStateMachine(typeof(_GetEnumerator_d__25))]
		public IEnumerator<TItem> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool IsValidQueue();
	}

	public class GenericPriorityQueueNode<TPriority> // TypeDefIndex: 90762
	{
		// Fields
		[CompilerGenerated]
		private TPriority _Priority_k__BackingField;
		[CompilerGenerated]
		private int _QueueIndex_k__BackingField;
		[CompilerGenerated]
		private long _InsertionIndex_k__BackingField;
	
		// Properties
		public TPriority Priority { [CompilerGenerated] get; [CompilerGenerated] protected internal set; }
		public int QueueIndex { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public long InsertionIndex { [CompilerGenerated] get; [CompilerGenerated] internal set; }
	
		// Constructors
		public GenericPriorityQueueNode();
	}

	internal interface IFixedSizePriorityQueue<TItem, in TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 90763
	{
		// Properties
		int MaxSize { get; }
	
		// Methods
		void Resize(int maxNodes);
		void ResetNode(TItem node);
	}

	public interface IPriorityQueue<TItem, in TPriority> : IEnumerable<TItem> // TypeDefIndex: 90764
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

	public class SimplePriorityQueue<TItem, TPriority> : IPriorityQueue<TItem, TPriority> // TypeDefIndex: 90766
	{
		// Fields
		private const int INITIAL_QUEUE_SIZE = 10; // Metadata: 0x0264B12C
		private readonly GenericPriorityQueue<SimpleNode, TPriority> _queue;
		private readonly Dictionary<TItem, IList<SimpleNode>> _itemToNodesCache;
		private readonly IList<SimpleNode> _nullNodesCache;
	
		// Properties
		public int Count { get; }
		public TItem First { get; }
	
		// Nested types
		private class SimpleNode : GenericPriorityQueueNode<TPriority> // TypeDefIndex: 90765
		{
			// Fields
			[CompilerGenerated]
			private TItem _Data_k__BackingField;
	
			// Properties
			public TItem Data { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public SimpleNode(TItem data);
		}
	
		// Constructors
		public SimplePriorityQueue();
		public SimplePriorityQueue(IComparer<TPriority> priorityComparer);
		public SimplePriorityQueue(Comparison<TPriority> priorityComparer);
		public SimplePriorityQueue(IEqualityComparer<TItem> itemEquality);
		public SimplePriorityQueue(IComparer<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality);
		public SimplePriorityQueue(Comparison<TPriority> priorityComparer, IEqualityComparer<TItem> itemEquality);
	
		// Methods
		private SimpleNode GetExistingNode(TItem item);
		private void AddToNodeCache(SimpleNode node);
		private void RemoveFromNodeCache(SimpleNode node);
		public void Clear();
		public bool Contains(TItem item);
		public TItem Dequeue();
		private SimpleNode EnqueueNoLockOrCache(TItem item, TPriority priority);
		public void Enqueue(TItem item, TPriority priority);
		public bool EnqueueWithoutDuplicates(TItem item, TPriority priority);
		public void Remove(TItem item);
		public void UpdatePriority(TItem item, TPriority priority);
		public TPriority GetPriority(TItem item);
		public bool TryFirst(out ref TItem first);
		public bool TryDequeue(out ref TItem first);
		public bool TryRemove(TItem item);
		public bool TryUpdatePriority(TItem item, TPriority priority);
		public bool TryGetPriority(TItem item, out ref TPriority priority);
		public IEnumerator<TItem> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool IsValidQueue();
	}

	public class SimplePriorityQueue<TItem> : SimplePriorityQueue<TItem, float> // TypeDefIndex: 90767
	{
		// Constructors
		public SimplePriorityQueue();
		public SimplePriorityQueue(IComparer<float> comparer);
		public SimplePriorityQueue(Comparison<float> comparer);
	}

	public sealed class StablePriorityQueue<T> : IFixedSizePriorityQueue<T, float> // TypeDefIndex: 90769
		where T : StablePriorityQueueNode
	{
		// Fields
		private int _numNodes;
		private T[] _nodes;
		private long _numNodesEverEnqueued;
	
		// Properties
		public int Count { get; }
		public int MaxSize { get; }
		public T First { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetEnumerator_d__22 : IEnumerator<T> // TypeDefIndex: 90768
		{
			// Fields
			private int __1__state;
			private T __2__current;
			public StablePriorityQueue<T> __4__this;
			private int _i_5__2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GetEnumerator_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StablePriorityQueue(int maxNodes);
	
		// Methods
		public void Clear();
		public bool Contains(T node);
		public void Enqueue(T node, float priority);
		private void CascadeUp(T node);
		private void CascadeDown(T node);
		private bool HasHigherPriority(T higher, T lower);
		public T Dequeue();
		public void Resize(int maxNodes);
		public void UpdatePriority(T node, float priority);
		private void OnNodeUpdated(T node);
		public void Remove(T node);
		public void ResetNode(T node);
		[IteratorStateMachine(typeof(_GetEnumerator_d__22))]
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public bool IsValidQueue();
	}

	public class StablePriorityQueueNode : FastPriorityQueueNode // TypeDefIndex: 90770
	{
		// Fields
		[CompilerGenerated]
		private long _InsertionIndex_k__BackingField; // 0x18
	
		// Properties
		public long InsertionIndex { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x0000000182234E30-0x0000000182234E40 0x000000018561CBD0-0x000000018561CBE0
	
		// Constructors
		public StablePriorityQueueNode(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}
