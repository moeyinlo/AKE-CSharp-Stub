/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Dynamic.Utils;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Cryptography;

// Image 21: System.Core.dll - Assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 50613-51285
[assembly: AssemblyCompany("Mono development team")]
[assembly: AssemblyCopyright("(c) Various Mono authors")]
[assembly: AssemblyDefaultAlias("System.Core.dll")]
[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyDescription("System.Core.dll")]
[assembly: AssemblyFileVersion("4.0.30319.17020")]
[assembly: AssemblyInformationalVersion("4.0.30319.17020")]
[assembly: AssemblyKeyFile("../silverlight.pub")]
[assembly: AssemblyProduct("Mono Common Language Infrastructure")]
[assembly: AssemblyTitle("System.Core.dll")]
[assembly: CLSCompliant(true)]
[assembly: CompilationRelaxations(8)]
[assembly: ComVisible(false)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SatelliteContractVersion("4.0.0.0")]

internal static class SR // TypeDefIndex: 50614
{
	// Methods
	internal static string GetString(string name) => default; // 0x000000018339AE90-0x000000018339AEA0
	internal static string Format(string resourceFormat, params object[] args) => default; // 0x00000001896ECA14-0x00000001896ECA7C
	internal static string Format(string resourceFormat, object p1) => default; // 0x00000001896EC938-0x00000001896EC994
	internal static string Format(string resourceFormat, object p1, object p2) => default; // 0x00000001896EC8C8-0x00000001896EC938
	internal static string Format(string resourceFormat, object p1, object p2, object p3) => default; // 0x00000001896EC994-0x00000001896ECA14
}

namespace Microsoft.Win32.SafeHandles
{
	public sealed class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 50615
	{
		// Constructors
		public SafeMemoryMappedFileHandle() {} // Dummy constructor
		public SafeMemoryMappedFileHandle(IntPtr preexistingHandle, bool ownsHandle) {} // 0x0000000182C9C390-0x0000000182C9C3C0
	
		// Methods
		protected override bool ReleaseHandle() => default; // 0x0000000183D234F0-0x0000000183D23520
	}

	public sealed class SafeMemoryMappedViewHandle : SafeBuffer // TypeDefIndex: 50616
	{
		// Fields
		private IntPtr mmap_handle; // 0x28
	
		// Constructors
		public SafeMemoryMappedViewHandle() {} // Dummy constructor
		internal SafeMemoryMappedViewHandle(IntPtr mmap_handle, IntPtr base_address, long size) {} // 0x0000000182CFF240-0x0000000182CFF2D0
	
		// Methods
		internal void Flush() {} // 0x00000001896ECA7C-0x00000001896ECA8C
		protected override bool ReleaseHandle() => default; // 0x0000000183CE18D0-0x0000000183CE18F0
	}
}

namespace System
{
	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 50617; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 50618; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11); // TypeDefIndex: 50619; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12); // TypeDefIndex: 50620; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13); // TypeDefIndex: 50621; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14); // TypeDefIndex: 50622; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15); // TypeDefIndex: 50623; 0x00000000-0x00000000

	public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16); // TypeDefIndex: 50624; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9); // TypeDefIndex: 50625; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10); // TypeDefIndex: 50626; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11); // TypeDefIndex: 50627; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12); // TypeDefIndex: 50628; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13); // TypeDefIndex: 50629; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14); // TypeDefIndex: 50630; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15); // TypeDefIndex: 50631; 0x00000000-0x00000000

	public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13, in T14, in T15, in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16); // TypeDefIndex: 50632; 0x00000000-0x00000000

	internal static class MonoUtil // TypeDefIndex: 50633
	{
		// Fields
		public static readonly bool IsUnix; // 0x00
	
		// Constructors
		static MonoUtil() {} // 0x0000000183CE5F60-0x0000000183CE5FD0
	}
}

namespace System.Collections.Generic
{
	[DefaultMember("Item")]
	internal struct ArrayBuilder<T> // TypeDefIndex: 51270
	{
		// Fields
		private T[] _array;
		private int _count;
	
		// Constructors
		public ArrayBuilder(int capacity) {
			_array = default;
			_count = default;
		}
	
		// Methods
		public T[] ToArray() => default;
		public void UncheckedAdd(T item) {}
	}

	internal sealed class BitHelper // TypeDefIndex: 51271
	{
		// Fields
		private readonly int _length; // 0x10
		private readonly unsafe int* _arrayPtr; // 0x18
		private readonly int[] _array; // 0x20
		private readonly bool _useStackAlloc; // 0x28
	
		// Constructors
		public BitHelper() {} // Dummy constructor
		internal unsafe BitHelper(int* bitArrayPtr, int length) {} // 0x0000000183D75330-0x0000000183D75340
		internal BitHelper(int[] bitArray, int length) {} // 0x00000001897380F8-0x0000000189738118
	
		// Methods
		internal void MarkBit(int bitPosition) {} // 0x0000000189738084-0x00000001897380E0
		internal bool IsMarked(int bitPosition) => default; // 0x000000018973801C-0x0000000189738084
		internal static int ToIntArrayLength(int n) => default; // 0x00000001897380E0-0x00000001897380F8
	}

	[Serializable]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
	public class HashSet<T> : ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 51275
	{
		// Fields
		private const int Lower31BitMask = 2147483647; // Metadata: 0x01FCEADC
		private const int StackAllocThreshold = 100; // Metadata: 0x01FCEADD
		private const int ShrinkThreshold = 3; // Metadata: 0x01FCEADF
		private const string CapacityName = "Capacity"; // Metadata: 0x01FCEAE0
		private const string ElementsName = "Elements"; // Metadata: 0x01FCEAE9
		private const string ComparerName = "Comparer"; // Metadata: 0x01FCEAF2
		private const string VersionName = "Version"; // Metadata: 0x01FCEAFB
		private int[] _buckets;
		private Slot[] _slots;
		private int _count;
		private int _lastIndex;
		private int _freeList;
		private IEqualityComparer<T> _comparer;
		private int _version;
		private SerializationInfo _siInfo;
	
		// Properties
		public int Count { get => default; }
		bool ICollection<T>.IsReadOnly { get => default; }
		public IEqualityComparer<T> Comparer { get => default; }
	
		// Nested types
		internal struct ElementCount // TypeDefIndex: 51272
		{
			// Fields
			internal int uniqueCount;
			internal int unfoundCount;
		}
	
		internal struct Slot // TypeDefIndex: 51273
		{
			// Fields
			internal int hashCode;
			internal int next;
			internal T value;
		}
	
		[Serializable]
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 51274
		{
			// Fields
			private HashSet<T> _set;
			private int _index;
			private int _version;
			private T _current;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(HashSet<T> set) : this() {
				_set = default;
				_index = default;
				_version = default;
				_current = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public HashSet() {}
		public HashSet(IEqualityComparer<T> comparer) {}
		public HashSet(int capacity) {}
		public HashSet(IEnumerable<T> collection) {}
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer) {}
		protected HashSet(SerializationInfo info, StreamingContext context) {}
		public HashSet(int capacity, IEqualityComparer<T> comparer) {}
	
		// Methods
		private void CopyFrom(HashSet<T> source) {}
		void ICollection<T>.Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) {}
		public virtual void OnDeserialization(object sender) {}
		public bool Add(T item) => default;
		public bool TryGetValue(T equalValue, out ref T actualValue) {
			actualValue = default;
			return default;
		}
		public void UnionWith(IEnumerable<T> other) {}
		public void IntersectWith(IEnumerable<T> other) {}
		public void ExceptWith(IEnumerable<T> other) {}
		public void SymmetricExceptWith(IEnumerable<T> other) {}
		public bool IsSubsetOf(IEnumerable<T> other) => default;
		public bool IsProperSubsetOf(IEnumerable<T> other) => default;
		public bool IsSupersetOf(IEnumerable<T> other) => default;
		public bool IsProperSupersetOf(IEnumerable<T> other) => default;
		public bool Overlaps(IEnumerable<T> other) => default;
		public bool SetEquals(IEnumerable<T> other) => default;
		public void CopyTo(T[] array) {}
		public void CopyTo(T[] array, int arrayIndex, int count) {}
		public int RemoveWhere(Predicate<T> match) => default;
		public int EnsureCapacity(int capacity) => default;
		public void TrimExcess() {}
		public static IEqualityComparer<HashSet<T>> CreateSetComparer() => default;
		private int Initialize(int capacity) => default;
		private void IncreaseCapacity() {}
		private void SetCapacity(int newSize) {}
		private bool AddIfNotPresent(T value) => default;
		private void AddValue(int index, int hashCode, T value) {}
		private bool ContainsAllElements(IEnumerable<T> other) => default;
		private bool IsSubsetOfHashSetWithSameEC(HashSet<T> other) => default;
		private void IntersectWithHashSetWithSameEC(HashSet<T> other) {}
		private void IntersectWithEnumerable(IEnumerable<T> other) {}
		private int InternalIndexOf(T item) => default;
		private void SymmetricExceptWithUniqueHashSet(HashSet<T> other) {}
		private void SymmetricExceptWithEnumerable(IEnumerable<T> other) {}
		private bool AddOrGetLocation(T value, out int location) {
			location = default;
			return default;
		}
		private ElementCount CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) => default;
		internal static bool HashSetEquals(HashSet<T> set1, HashSet<T> set2, IEqualityComparer<T> comparer) => default;
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) => default;
		private int InternalGetHashCode(T item) => default;
	}

	[Serializable]
	internal sealed class HashSetEqualityComparer<T> : IEqualityComparer<HashSet<T>> // TypeDefIndex: 51276
	{
		// Fields
		private readonly IEqualityComparer<T> _comparer;
	
		// Constructors
		public HashSetEqualityComparer() {}
	
		// Methods
		public bool Equals(HashSet<T> x, HashSet<T> y) => default;
		public int GetHashCode(HashSet<T> obj) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	internal sealed class ICollectionDebugView<T> // TypeDefIndex: 51277
	{
		// Constructors
		public ICollectionDebugView() {} // Dummy constructor
	}
}

namespace System.Dynamic
{
	public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 51217
	{
		// Properties
		public ExpressionType Operation { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Constructors
		protected BinaryOperationBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) => default; // 0x000000018971FBDC-0x000000018971FBFC
		public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018971FA4C-0x000000018971FBDC
	}

	[DebuggerDisplay("{DebugView}")]
	[DebuggerTypeProxy(typeof(BindingRestrictionsProxy))]
	public abstract class BindingRestrictions // TypeDefIndex: 51225
	{
		// Fields
		public static readonly BindingRestrictions Empty; // 0x00
	
		// Nested types
		private sealed class TestBuilder // TypeDefIndex: 51219
		{
			// Fields
			private readonly HashSet<BindingRestrictions> _unique; // 0x10
			private readonly Stack<AndNode> _tests; // 0x18
	
			// Nested types
			private struct AndNode // TypeDefIndex: 51218
			{
				// Fields
				internal int Depth; // 0x00
				internal Expression Node; // 0x08
			}
	
			// Constructors
			public TestBuilder() {} // 0x0000000189736660-0x0000000189736720
	
			// Methods
			internal void Append(BindingRestrictions restrictions) {} // 0x00000001897363D8-0x0000000189736454
			internal Expression ToExpression() => default; // 0x0000000189736594-0x0000000189736660
			private void Push(Expression node, int depth) {} // 0x0000000189736454-0x0000000189736594
		}
	
		private sealed class MergedRestriction : BindingRestrictions // TypeDefIndex: 51220
		{
			// Fields
			internal readonly BindingRestrictions Left; // 0x10
			internal readonly BindingRestrictions Right; // 0x18
	
			// Constructors
			public MergedRestriction() {} // Dummy constructor
			internal MergedRestriction(BindingRestrictions left, BindingRestrictions right) {} // 0x000000018972B944-0x000000018972B9B0
	
			// Methods
			internal override Expression GetExpression() => default; // 0x000000018972B818-0x000000018972B944
		}
	
		private sealed class CustomRestriction : BindingRestrictions // TypeDefIndex: 51221
		{
			// Fields
			private readonly Expression _expression; // 0x10
	
			// Constructors
			public CustomRestriction() {} // Dummy constructor
			internal CustomRestriction(Expression expression) {} // 0x00000001897226CC-0x0000000189722724
	
			// Methods
			public override bool Equals(object obj) => default; // 0x0000000189722644-0x00000001897226A4
			public override int GetHashCode() => default; // 0x00000001897226A4-0x00000001897226CC
			internal override Expression GetExpression() => default; // 0x00000001820B7B20-0x00000001820B7B30
		}
	
		private sealed class TypeRestriction : BindingRestrictions // TypeDefIndex: 51222
		{
			// Fields
			private readonly Expression _expression; // 0x10
			private readonly System.Type _type; // 0x18
	
			// Constructors
			public TypeRestriction() {} // Dummy constructor
			internal TypeRestriction(Expression parameter, System.Type type) {} // 0x0000000189736E50-0x0000000189736EBC
	
			// Methods
			public override bool Equals(object obj) => default; // 0x0000000189736D10-0x0000000189736DA8
			public override int GetHashCode() => default; // 0x0000000189736E00-0x0000000189736E50
			internal override Expression GetExpression() => default; // 0x0000000189736DA8-0x0000000189736E00
		}
	
		private sealed class InstanceRestriction : BindingRestrictions // TypeDefIndex: 51223
		{
			// Fields
			private readonly Expression _expression; // 0x10
			private readonly object _instance; // 0x18
	
			// Constructors
			public InstanceRestriction() {} // Dummy constructor
			internal InstanceRestriction(Expression parameter, object instance) {} // 0x0000000189728A78-0x0000000189728AE4
	
			// Methods
			public override bool Equals(object obj) => default; // 0x00000001897286DC-0x0000000189728750
			public override int GetHashCode() => default; // 0x0000000189728A3C-0x0000000189728A78
			internal override Expression GetExpression() => default; // 0x0000000189728750-0x0000000189728A3C
		}
	
		private sealed class BindingRestrictionsProxy // TypeDefIndex: 51224
		{
			// Constructors
			public BindingRestrictionsProxy() {} // Dummy constructor
		}
	
		// Constructors
		private BindingRestrictions() {} // 0x000000018350B670-0x000000018350B680
		static BindingRestrictions() {} // 0x000000018971FFC0-0x000000018972006C
	
		// Methods
		internal abstract Expression GetExpression();
		public BindingRestrictions Merge(BindingRestrictions restrictions) => default; // 0x000000018971FE98-0x000000018971FFB0
		public static BindingRestrictions GetTypeRestriction(Expression expression, System.Type type) => default; // 0x000000018971FD70-0x000000018971FE98
		internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) => default; // 0x000000018971FCC8-0x000000018971FD70
		public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) => default; // 0x000000018971FBFC-0x000000018971FCC8
		public Expression ToExpression() => default; // 0x000000018971FFB0-0x000000018971FFC0
	}

	public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 51226
	{
		// Properties
		public System.Type Type { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		protected ConvertBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackConvert(DynamicMetaObject target) => default; // 0x00000001897223A0-0x00000001897223B0
		public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897222B0-0x00000001897223A0
	}

	public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 51227
	{
		// Constructors
		protected CreateInstanceBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018972261C-0x0000000189722644
		public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x0000000189722530-0x000000018972261C
	}

	public abstract class DeleteIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 51228
	{
		// Constructors
		protected DeleteIndexBinder() {} // Dummy constructor
	
		// Methods
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897238FC-0x00000001897239E8
		public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) => default; // 0x000000018972261C-0x0000000189722644
		public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}

	public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 51229
	{
		// Properties
		public string Name { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool IgnoreCase { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		protected DeleteMemberBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) => default; // 0x00000001897223A0-0x00000001897223B0
		public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897239E8-0x0000000189723AD8
	}

	public class DynamicMetaObject // TypeDefIndex: 51230
	{
		// Fields
		public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x00
		private static readonly object s_noValueSentinel; // 0x08
		private readonly object _value; // 0x10
	
		// Properties
		public Expression Expression { get; } // 0x0000000181041090-0x00000001810410A0 
		public BindingRestrictions Restrictions { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public object Value { get => default; } // 0x0000000189725100-0x0000000189725124 
		public bool HasValue { get => default; } // 0x0000000189725000-0x0000000189725050 
		public System.Type RuntimeType { get => default; } // 0x000000018972508C-0x0000000189725100 
		public System.Type LimitType { get => default; } // 0x0000000189725050-0x000000018972508C 
	
		// Constructors
		public DynamicMetaObject() {} // Dummy constructor
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions) {} // 0x0000000189724EBC-0x0000000189725000
		public DynamicMetaObject(Expression expression, BindingRestrictions restrictions, object value) {} // 0x0000000189724E8C-0x0000000189724EBC
		static DynamicMetaObject() {} // 0x0000000189724DDC-0x0000000189724E8C
	
		// Methods
		public virtual DynamicMetaObject BindConvert(ConvertBinder binder) => default; // 0x0000000189724514-0x00000001897245AC
		public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) => default; // 0x000000018972483C-0x00000001897248D4
		public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) => default; // 0x0000000189724AE0-0x0000000189724B88
		public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) => default; // 0x00000001897246FC-0x0000000189724794
		public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) => default; // 0x0000000189724794-0x000000018972483C
		public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) => default; // 0x0000000189724A24-0x0000000189724AE0
		public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) => default; // 0x0000000189724654-0x00000001897246FC
		public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) => default; // 0x00000001897248D4-0x000000018972497C
		public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) => default; // 0x000000018972497C-0x0000000189724A24
		public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) => default; // 0x00000001897245AC-0x0000000189724654
		public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) => default; // 0x0000000189724B88-0x0000000189724C20
		public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) => default; // 0x000000018972446C-0x0000000189724514
		public virtual IEnumerable<string> GetDynamicMemberNames() => default; // 0x0000000189724DAC-0x0000000189724DDC
		public static DynamicMetaObject Create(object value, Expression expression) => default; // 0x0000000189724C20-0x0000000189724DAC
	}

	public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 51231
	{
		// Properties
		public virtual System.Type ReturnType { get; } // 0x000000018972441C-0x000000018972446C 
		internal virtual bool IsStandardBinder { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		protected DynamicMetaObjectBinder() {} // 0x00000001897243DC-0x000000018972441C
	
		// Methods
		public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) => default; // 0x0000000189723B90-0x0000000189724240
		private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) => default; // 0x0000000189724240-0x000000018972436C
		public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);
		public Expression GetUpdateExpression(System.Type type) => default; // 0x000000018972436C-0x00000001897243DC
	}

	internal class ExpandoClass // TypeDefIndex: 51232
	{
		// Fields
		private readonly string[] _keys; // 0x10
		private readonly int _hashCode; // 0x18
		private Dictionary<int, List<WeakReference>> _transitions; // 0x20
		internal static readonly ExpandoClass Empty; // 0x00
	
		// Properties
		internal string[] Keys { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		internal ExpandoClass() {} // 0x0000000189725A58-0x0000000189725AA4
		internal ExpandoClass(string[] keys, int hashCode) {} // 0x0000000189725A44-0x0000000189725A58
		static ExpandoClass() {} // 0x00000001897259D4-0x0000000189725A44
	
		// Methods
		internal ExpandoClass FindNewClass(string newKey) => default; // 0x00000001897251F4-0x0000000189725690
		private List<WeakReference> GetTransitionList(int hashCode) => default; // 0x0000000189725690-0x00000001897257C0
		internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) => default; // 0x00000001897259A8-0x00000001897259D4
		internal int GetValueIndexCaseSensitive(string name) => default; // 0x000000018972593C-0x00000001897259A8
		private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) => default; // 0x00000001897257C0-0x000000018972593C
	}

	public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<string, object>, INotifyPropertyChanged // TypeDefIndex: 51244
	{
		// Fields
		private static readonly MethodInfo s_expandoTryGetValue; // 0x00
		private static readonly MethodInfo s_expandoTrySetValue; // 0x08
		private static readonly MethodInfo s_expandoTryDeleteValue; // 0x10
		private static readonly MethodInfo s_expandoPromoteClass; // 0x18
		private static readonly MethodInfo s_expandoCheckVersion; // 0x20
		internal readonly object LockObject; // 0x10
		private ExpandoData _data; // 0x18
		private int _count; // 0x20
		internal static readonly object Uninitialized; // 0x28
		private PropertyChangedEventHandler _propertyChanged; // 0x28
	
		// Properties
		internal ExpandoClass Class { get => default; } // 0x00000001892E734C-0x00000001892E7368 
		ICollection<string> System.Collections.Generic.IDictionary<System.String,System.Object>.Keys { get => default; } // 0x0000000189726748-0x00000001897267A8 
		ICollection<object> System.Collections.Generic.IDictionary<System.String,System.Object>.Values { get => default; } // 0x00000001897267A8-0x0000000189726808 
		object System.Collections.Generic.IDictionary<System.String,System.Object>.this[string key] { get => default; set {} } // 0x00000001897266F8-0x0000000189726748 0x0000000189726808-0x00000001897268C8
		int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Count { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Events
		event PropertyChangedEventHandler System_ComponentModel_INotifyPropertyChanged_PropertyChanged;
	
		// Nested types
		private sealed class KeyCollectionDebugView // TypeDefIndex: 51233
		{
			// Constructors
			public KeyCollectionDebugView() {} // Dummy constructor
		}
	
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(KeyCollectionDebugView))]
		private class KeyCollection : ICollection<string> // TypeDefIndex: 51235
		{
			// Fields
			private readonly ExpandoObject _expando; // 0x10
			private readonly int _expandoVersion; // 0x18
			private readonly int _expandoCount; // 0x1C
			private readonly ExpandoData _expandoData; // 0x20
	
			// Properties
			public int Count { get => default; } // 0x0000000189729148-0x0000000189729164 
			public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
			// Constructors
			public KeyCollection() {} // Dummy constructor
			internal KeyCollection(ExpandoObject expando) {} // 0x0000000189728FCC-0x0000000189729148
	
			// Methods
			private void CheckVersion() {} // 0x0000000189728B0C-0x0000000189728B6C
			public void Add(string item) {} // 0x0000000189728AE4-0x0000000189728B0C
			public void Clear() {} // 0x0000000189728B6C-0x0000000189728B94
			public bool Contains(string item) => default; // 0x0000000189728B94-0x0000000189728CA0
			public void CopyTo(string[] array, int arrayIndex) {} // 0x0000000189728CA0-0x0000000189728F40
			public bool Remove(string item) => default; // 0x0000000189728F9C-0x0000000189728FC4
			[IteratorStateMachine(typeof(_GetEnumerator_d__15))]
			public IEnumerator<string> GetEnumerator() => default; // 0x0000000189728F40-0x0000000189728F9C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189728FC4-0x0000000189728FCC
		}
	
		private sealed class ValueCollectionDebugView // TypeDefIndex: 51236
		{
			// Constructors
			public ValueCollectionDebugView() {} // Dummy constructor
		}
	
		[DebuggerDisplay("Count = {Count}")]
		[DebuggerTypeProxy(typeof(ValueCollectionDebugView))]
		private class ValueCollection : ICollection<object> // TypeDefIndex: 51238
		{
			// Fields
			private readonly ExpandoObject _expando; // 0x10
			private readonly int _expandoVersion; // 0x18
			private readonly int _expandoCount; // 0x1C
			private readonly ExpandoData _expandoData; // 0x20
	
			// Properties
			public int Count { get => default; } // 0x000000018973FA40-0x000000018973FB14 
			public bool IsReadOnly { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
			// Constructors
			public ValueCollection() {} // Dummy constructor
			internal ValueCollection(ExpandoObject expando) {} // 0x0000000189728FCC-0x0000000189729148
	
			// Methods
			private void CheckVersion() {} // 0x000000018973F528-0x000000018973F588
			public void Add(object item) {} // 0x000000018973F500-0x000000018973F528
			public void Clear() {} // 0x000000018973F588-0x000000018973F5B0
			public bool Contains(object item) => default; // 0x000000018973F5B0-0x000000018973F72C
			public void CopyTo(object[] array, int arrayIndex) {} // 0x000000018973F72C-0x000000018973F9B4
			public bool Remove(object item) => default; // 0x000000018973FA10-0x000000018973FA38
			[IteratorStateMachine(typeof(_GetEnumerator_d__15))]
			public IEnumerator<object> GetEnumerator() => default; // 0x000000018973F9B4-0x000000018973FA10
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018973FA38-0x000000018973FA40
		}
	
		private class MetaExpando : DynamicMetaObject // TypeDefIndex: 51241
		{
			// Properties
			public new ExpandoObject Value { get => default; } // 0x000000018973B194-0x000000018973B1E4 
	
			// Constructors
			public MetaExpando() {} // Dummy constructor
			public MetaExpando(Expression expression, ExpandoObject value) {} // 0x000000018973B0F8-0x000000018973B194
	
			// Methods
			private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, System.Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) => default; // 0x000000018973A458-0x000000018973A958
			public override DynamicMetaObject BindGetMember(GetMemberBinder binder) => default; // 0x000000018973A380-0x000000018973A458
			public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) => default; // 0x000000018973A958-0x000000018973AAE0
			public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) => default; // 0x000000018973AAE0-0x000000018973AEA8
			public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) => default; // 0x000000018973A0BC-0x000000018973A380
			[IteratorStateMachine(typeof(_GetDynamicMemberNames_d__6))]
			public override IEnumerable<string> GetDynamicMemberNames() => default; // 0x000000018973AF78-0x000000018973AFE8
			private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) => default; // 0x0000000189739E40-0x000000018973A0BC
			private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) {
				klass = default;
				index = default;
				return default;
			} // 0x000000018973AEA8-0x000000018973AF78
			private Expression GetLimitedSelf() => default; // 0x000000018973AFE8-0x000000018973B0AC
			private BindingRestrictions GetRestrictions() => default; // 0x000000018973B0AC-0x000000018973B0F8
		}
	
		private class ExpandoData // TypeDefIndex: 51242
		{
			// Fields
			internal static ExpandoData Empty; // 0x00
			internal readonly ExpandoClass Class; // 0x10
			private readonly object[] _dataArray; // 0x18
			private int _version; // 0x20
	
			// Properties
			internal object this[int index] { get => default; set {} } // 0x00000001891B29D0-0x00000001891B29FC 0x00000001897385B8-0x0000000189738608
			internal int Version { get => default; } // 0x0000000181003B50-0x0000000181003B60 
			internal int Length { get => default; } // 0x00000001842709E0-0x00000001842709FC 
	
			// Constructors
			private ExpandoData() {} // 0x000000018973853C-0x00000001897385B8
			internal ExpandoData(ExpandoClass klass, object[] data, int version) {} // 0x0000000183864580-0x00000001838645B0
			static ExpandoData() {} // 0x00000001897384CC-0x000000018973853C
	
			// Methods
			internal ExpandoData UpdateClass(ExpandoClass newClass) => default; // 0x0000000189738300-0x00000001897384CC
			private static int GetAlignedSize(int len) => default; // 0x0000000183D56690-0x0000000183D566A0
		}
	
		// Constructors
		public ExpandoObject() {} // 0x0000000189727808-0x000000018972788C
		static ExpandoObject() {} // 0x00000001897275A0-0x0000000189727808
	
		// Methods
		internal bool TryGetValue(object indexClass, int index, string name, bool ignoreCase, out object value) {
			value = default;
			return default;
		} // 0x0000000189726FA4-0x00000001897270CC
		internal void TrySetValue(object indexClass, int index, object value, string name, bool ignoreCase, bool add) {} // 0x00000001897270CC-0x00000001897275A0
		internal bool TryDeleteValue(object indexClass, int index, string name, bool ignoreCase, object deleteValue) => default; // 0x0000000189726B34-0x0000000189726F78
		internal bool IsDeletedMember(int index) => default; // 0x0000000189725B58-0x0000000189725BE4
		private ExpandoData PromoteClassCore(ExpandoClass oldClass, ExpandoClass newClass) => default; // 0x0000000189725BE4-0x0000000189725C2C
		internal void PromoteClass(object oldClass, object newClass) {} // 0x0000000189725C2C-0x0000000189725D38
		DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => default; // 0x0000000189726A04-0x0000000189726A74
		private void TryAddMember(string key, object value) {} // 0x0000000189726A74-0x0000000189726B34
		private bool TryGetValueForKey(string key, out object value) {
			value = default;
			return default;
		} // 0x0000000189726F78-0x0000000189726FA4
		private bool ExpandoContainsKey(string key) => default; // 0x0000000189725AA4-0x0000000189725AD4
		void IDictionary<string, object>.Add(string key, object value) {} // 0x000000018972651C-0x0000000189726524
		bool IDictionary<string, object>.ContainsKey(string key) => default; // 0x0000000189726524-0x0000000189726618
		bool IDictionary<string, object>.Remove(string key) => default; // 0x0000000189726618-0x00000001897266F0
		bool IDictionary<string, object>.TryGetValue(string key, out object value) {
			value = default;
			return default;
		} // 0x00000001897266F0-0x00000001897266F8
		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item) {} // 0x0000000189725D38-0x0000000189725D8C
		void ICollection<KeyValuePair<string, object>>.Clear() {} // 0x0000000189725D8C-0x00000001897260FC
		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item) => default; // 0x00000001897260FC-0x0000000189726194
		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) {} // 0x0000000189726194-0x00000001897264B4
		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item) => default; // 0x00000001897264B4-0x000000018972651C
		IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator() => default; // 0x00000001897268C8-0x00000001897268EC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001897268C8-0x00000001897268EC
		[IteratorStateMachine(typeof(_GetExpandoEnumerator_d__51))]
		private IEnumerator<KeyValuePair<string, object>> GetExpandoEnumerator(ExpandoData data, int version) => default; // 0x0000000189725AD4-0x0000000189725B58
	}

	public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 51245
	{
		// Constructors
		protected GetIndexBinder() {} // Dummy constructor
	
		// Methods
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897392C4-0x00000001897393B0
		public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) => default; // 0x000000018972261C-0x0000000189722644
		public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
	}

	public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 51246
	{
		// Properties
		public sealed override System.Type ReturnType { get; } // 0x0000000189739554-0x00000001897395A4 
		public string Name { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool IgnoreCase { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		internal sealed override bool IsStandardBinder { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		protected GetMemberBinder() {} // Dummy constructor
		protected GetMemberBinder(string name, bool ignoreCase) {} // 0x00000001897394A0-0x0000000189739554
	
		// Methods
		public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) => default; // 0x00000001897223A0-0x00000001897223B0
		public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897393B0-0x00000001897394A0
	}

	public interface IDynamicMetaObjectProvider // TypeDefIndex: 51247
	{
		// Methods
		DynamicMetaObject GetMetaObject(Expression parameter);
	}

	public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 51248
	{
		// Constructors
		protected InvokeBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018972261C-0x0000000189722644
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x00000001897395A4-0x0000000189739690
	}

	public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 51249
	{
		// Properties
		public string Name { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool IgnoreCase { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		protected InvokeMemberBinder() {} // Dummy constructor
	
		// Methods
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x0000000189739690-0x000000018973977C
		public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018972261C-0x0000000189722644
		public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
	}

	public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 51250
	{
		// Constructors
		protected SetIndexBinder() {} // Dummy constructor
	
		// Methods
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018973BA08-0x000000018973BBF4
		public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) => default; // 0x000000018973BBF4-0x000000018973BC1C
		public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}

	public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 51251
	{
		// Properties
		public sealed override System.Type ReturnType { get; } // 0x000000018973BE60-0x000000018973BEB0 
		public string Name { get; } // 0x0000000181041090-0x00000001810410A0 
		public bool IgnoreCase { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		internal sealed override bool IsStandardBinder { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		protected SetMemberBinder() {} // Dummy constructor
		protected SetMemberBinder(string name, bool ignoreCase) {} // 0x000000018973BDAC-0x000000018973BE60
	
		// Methods
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018973BC1C-0x000000018973BDAC
		public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) => default; // 0x000000018971FBDC-0x000000018971FBFC
		public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
	}

	public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 51252
	{
		// Constructors
		protected UnaryOperationBinder() {} // Dummy constructor
	
		// Methods
		public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) => default; // 0x00000001897223A0-0x00000001897223B0
		public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) => default; // 0x000000018973F410-0x000000018973F500
	}
}

namespace System.Dynamic.Utils
{
	internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 51254
	{
		// Fields
		private readonly int _mask;
		private readonly Entry[] _entries;
	
		// Properties
		internal TValue this[TKey key] { set {} }
	
		// Nested types
		private sealed class Entry // TypeDefIndex: 51253
		{
			// Fields
			internal readonly int _hash;
			internal readonly TKey _key;
			internal readonly TValue _value;
	
			// Constructors
			public Entry() {} // Dummy constructor
			internal Entry(int hash, TKey key, TValue value) {}
		}
	
		// Constructors
		public CacheDict() {} // Dummy constructor
		internal CacheDict(int size) {}
	
		// Methods
		private static int AlignSize(int size) => default;
		internal bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		internal void Add(TKey key, TValue value) {}
	}

	internal static class CollectionExtensions // TypeDefIndex: 51255
	{
		// Extension methods
		public static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item) => default;
		public static T[] AddLast<T>(this T[] array, T item) => default;
		public static T[] RemoveFirst<T>(this T[] array) => default;
		public static T[] RemoveLast<T>(this T[] array) => default;
		public static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable) => default;
	}

	internal static class ContractUtils // TypeDefIndex: 51256
	{
		// Properties
		[ExcludeFromCodeCoverage]
		public static Exception Unreachable { get; } // 0x000000018973829C-0x0000000189738300 
	
		// Methods
		public static void Requires(bool precondition, string paramName) {} // 0x000000018973825C-0x000000018973829C
		public static void RequiresNotNull(object value, string paramName) {} // 0x0000000189738200-0x000000018973825C
		public static void RequiresNotNull(object value, string paramName, int index) {} // 0x0000000189738190-0x0000000189738200
		public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) {}
		private static string GetParamName(string paramName, int index) => default; // 0x0000000189738118-0x0000000189738190
		public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) {}
	}

	internal static class EmptyReadOnlyCollection<T> // TypeDefIndex: 51257
	{
		// Fields
		public static readonly ReadOnlyCollection<T> Instance;
	
		// Constructors
		static EmptyReadOnlyCollection() {}
	}

	internal static class ExpressionUtils // TypeDefIndex: 51258
	{
		// Methods
		public static ReadOnlyCollection<T> ReturnReadOnly<T>(ref IReadOnlyList<T> collection) => default;
		public static T ReturnObject<T>(object collectionOrT)
			where T : class => default;
		public static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) {} // 0x0000000189738A68-0x0000000189738CD8
		public static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) {} // 0x0000000189738990-0x0000000189738A68
		public static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arguments, ParameterInfo pi, string methodParamName, string argumentParamName, int index = -1 /* Metadata: 0x01FCEACE */) => default; // 0x0000000189738CD8-0x0000000189738F10
		public static void RequiresCanRead(Expression expression, string paramName) {} // 0x0000000189738674-0x0000000189738684
		public static void RequiresCanRead(Expression expression, string paramName, int idx) {} // 0x0000000189738684-0x000000018973885C
		public static bool TryQuote(System.Type parameterType, ref Expression argument) => default; // 0x000000018973885C-0x0000000189738948
		internal static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) => default; // 0x0000000189738608-0x0000000189738674
		internal static bool SameElements<T>(ref IEnumerable<T> replacement, IReadOnlyList<T> current)
			where T : class => default;
		private static bool SameElementsInCollection<T>(ICollection<T> replacement, IReadOnlyList<T> current)
			where T : class => default;
	
		// Extension methods
		public static void ValidateArgumentCount(this LambdaExpression lambda) {} // 0x0000000189738948-0x0000000189738990
	}

	internal static class ExpressionVisitorUtils // TypeDefIndex: 51259
	{
		// Methods
		public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) => default; // 0x000000018973903C-0x0000000189739178
		public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) => default; // 0x0000000189739178-0x00000001897392C4
		public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) => default; // 0x0000000189738F10-0x000000018973903C
	}

	internal static class TypeExtensions // TypeDefIndex: 51260
	{
		// Fields
		private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x00
	
		// Constructors
		static TypeExtensions() {} // 0x000000018973C244-0x000000018973C2D8
	
		// Extension methods
		public static MethodInfo GetAnyStaticMethodValidated(this System.Type type, string name, System.Type[] types) => default; // 0x000000018973BF00-0x000000018973BF98
		private static bool MatchesArgumentTypes(this MethodInfo mi, System.Type[] argTypes) => default; // 0x000000018973C150-0x000000018973C244
		public static System.Type GetReturnType(this MethodBase mi) => default; // 0x000000018973C084-0x000000018973C104
		public static TypeCode GetTypeCode(this System.Type type) => default; // 0x000000018973C104-0x000000018973C150
		internal static ParameterInfo[] GetParametersCached(this MethodBase method) => default; // 0x000000018973BF98-0x000000018973C084
	}

	internal static class TypeUtils // TypeDefIndex: 51262
	{
		// Fields
		private static readonly System.Type[] s_arrayAssignableInterfaces; // 0x00
	
		// Constructors
		static TypeUtils() {} // 0x000000018973EA2C-0x000000018973EBFC
	
		// Methods
		public static bool IsValidInstanceType(MemberInfo member, System.Type instanceType) => default; // 0x000000018973E24C-0x000000018973E57C
		private static bool HasArrayToInterfaceConversion(System.Type source, System.Type dest) => default; // 0x000000018973CCDC-0x000000018973CE58
		private static bool HasInterfaceToArrayConversion(System.Type source, System.Type dest) => default; // 0x000000018973D1C8-0x000000018973D344
		private static bool IsCovariant(System.Type t) => default; // 0x000000018973D778-0x000000018973D79C
		private static bool IsContravariant(System.Type t) => default; // 0x000000018973D6C0-0x000000018973D6E8
		private static bool IsInvariant(System.Type t) => default; // 0x000000018973DCB0-0x000000018973DCD8
		private static bool IsDelegate(System.Type t) => default; // 0x000000018973D79C-0x000000018973D814
		public static bool IsLegalExplicitVariantDelegateConversion(System.Type source, System.Type dest) => default; // 0x000000018973DCD8-0x000000018973DF48
		public static bool HasReferenceEquality(System.Type left, System.Type right) => default; // 0x000000018973D4E4-0x000000018973D5A8
		public static bool HasBuiltInEqualityOperator(System.Type left, System.Type right) => default; // 0x000000018973CE58-0x000000018973CFF8
		public static MethodInfo GetUserDefinedCoercionMethod(System.Type convertFrom, System.Type convertToType) => default; // 0x000000018973CAEC-0x000000018973CCDC
		private static MethodInfo FindConversionOperator(MethodInfo[] methods, System.Type typeFrom, System.Type typeTo) => default; // 0x000000018973C3D0-0x000000018973C550
		private static bool IsImplicitNumericConversion(System.Type source, System.Type destination) => default; // 0x000000018973D994-0x000000018973DA98
		private static bool IsImplicitReferenceConversion(System.Type source, System.Type destination) => default; // 0x000000018973DA98-0x000000018973DAB8
		private static bool IsImplicitBoxingConversion(System.Type source, System.Type destination) => default; // 0x000000018973D814-0x000000018973D910
		private static bool IsImplicitNullableConversion(System.Type source, System.Type destination) => default; // 0x000000018973D910-0x000000018973D994
		public static System.Type FindGenericType(System.Type definition, System.Type type) => default; // 0x000000018973C550-0x000000018973C7C4
		public static MethodInfo GetBooleanOperator(System.Type type, string name) => default; // 0x000000018973C7C4-0x000000018973C8E0
		public static bool AreEquivalent(System.Type t1, System.Type t2) => default; // 0x000000018973C2D8-0x000000018973C334
		public static bool AreReferenceAssignable(System.Type dest, System.Type src) => default; // 0x000000018973C334-0x000000018973C3D0
		public static bool IsSameOrSubclass(System.Type type, System.Type subType) => default; // 0x000000018973E134-0x000000018973E1A8
		public static void ValidateType(System.Type type, string paramName) {} // 0x000000018973E8EC-0x000000018973E948
		public static void ValidateType(System.Type type, string paramName, bool allowByRef, bool allowPointer) {} // 0x000000018973E7F4-0x000000018973E8EC
		public static bool ValidateType(System.Type type, string paramName, int index) => default; // 0x000000018973E948-0x000000018973EA2C
	
		// Extension methods
		public static System.Type GetNonNullableType(this System.Type type) => default; // 0x000000018973C930-0x000000018973C9A8
		public static System.Type GetNullableType(this System.Type type) => default; // 0x000000018973C9E8-0x000000018973CAEC
		public static bool IsNullableType(this System.Type type) => default; // 0x000000018973DFAC-0x000000018973E040
		public static bool IsNullableOrReferenceType(this System.Type type) => default; // 0x000000018973DF48-0x000000018973DFAC
		public static bool IsBool(this System.Type type) => default; // 0x000000018973D638-0x000000018973D6C0
		public static bool IsNumeric(this System.Type type) => default; // 0x000000018973E0A4-0x000000018973E134
		public static bool IsInteger(this System.Type type) => default; // 0x000000018973DC20-0x000000018973DCB0
		public static bool IsArithmetic(this System.Type type) => default; // 0x000000018973D5A8-0x000000018973D638
		public static bool IsUnsignedInt(this System.Type type) => default; // 0x000000018973E1A8-0x000000018973E24C
		public static bool IsIntegerOrBool(this System.Type type) => default; // 0x000000018973DB88-0x000000018973DC20
		public static bool IsNumericOrBool(this System.Type type) => default; // 0x000000018973E040-0x000000018973E0A4
		public static bool HasIdentityPrimitiveOrNullableConversionTo(this System.Type source, System.Type dest) => default; // 0x000000018973CFF8-0x000000018973D1C8
		public static bool HasReferenceConversionTo(this System.Type source, System.Type dest) => default; // 0x000000018973D344-0x000000018973D4E4
		private static bool StrictHasReferenceConversionTo(this System.Type source, System.Type dest, bool skipNonArray) => default; // 0x000000018973E57C-0x000000018973E7F4
		public static bool IsConvertible(this System.Type type) => default; // 0x000000018973D6E8-0x000000018973D778
		public static bool IsImplicitlyConvertibleTo(this System.Type source, System.Type destination) => default; // 0x000000018973DAB8-0x000000018973DB88
		public static System.Type GetNonRefType(this System.Type type) => default; // 0x000000018973C9A8-0x000000018973C9E8
		public static MethodInfo GetInvokeMethod(this System.Type delegateType) => default; // 0x000000018973C8E0-0x000000018973C930
	}
}

namespace System.IO
{
	[Serializable]
	public enum HandleInheritability // TypeDefIndex: 51263
	{
		None = 0,
		Inheritable = 1
	}
}

namespace System.IO.MemoryMappedFiles
{
	[Serializable]
	public enum MemoryMappedFileAccess // TypeDefIndex: 51264
	{
		ReadWrite = 0,
		Read = 1,
		Write = 2,
		CopyOnWrite = 3,
		ReadExecute = 4,
		ReadWriteExecute = 5
	}

	[Serializable]
	[Flags]
	public enum MemoryMappedFileOptions // TypeDefIndex: 51265
	{
		None = 0,
		DelayAllocatePages = 67108864
	}

	public sealed class MemoryMappedViewAccessor : UnmanagedMemoryAccessor // TypeDefIndex: 51266
	{
		// Fields
		private MemoryMappedView m_view; // 0x30
	
		// Properties
		public SafeMemoryMappedViewHandle SafeMemoryMappedViewHandle { get => default; } // 0x0000000182CFEF70-0x0000000182CFEF90 
	
		// Constructors
		public MemoryMappedViewAccessor() {} // Dummy constructor
		internal MemoryMappedViewAccessor(MemoryMappedView view) {} // 0x0000000182CFF1B0-0x0000000182CFF220
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x000000018398D5E0-0x000000018398D670
		public void Flush() {} // 0x0000000189739D80-0x0000000189739E18
	}

	internal static class MemoryMapImpl // TypeDefIndex: 51267
	{
		// Methods
		private static unsafe IntPtr OpenFileInternal(char* path, int path_length, FileMode mode, char* mapName, int mapName_length, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, out int error) {
			capacity = default;
			error = default;
			return default;
		} // 0x0000000184276788-0x0000000184276790
		private static unsafe IntPtr OpenHandleInternal(IntPtr handle, char* mapName, int mapName_length, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options, out int error) {
			capacity = default;
			error = default;
			return default;
		} // 0x000000018427677C-0x0000000184276788
		internal static void CloseMapping(IntPtr handle) {} // 0x0000000184277198-0x00000001842771A0
		internal static void Flush(IntPtr file_handle) {} // 0x0000000189739AD0-0x0000000189739ADC
		internal static void ConfigureHandleInheritability(IntPtr handle, HandleInheritability inheritability) {} // 0x0000000184276790-0x0000000184276798
		internal static bool Unmap(IntPtr mmap_handle) => default; // 0x0000000184277064-0x000000018427706C
		private static int MapInternal(IntPtr handle, long offset, ref long size, MemoryMappedFileAccess access, out IntPtr mmap_handle, out IntPtr base_address) {
			mmap_handle = default;
			base_address = default;
			return default;
		} // 0x0000000184273218-0x0000000184273220
		internal static void Map(IntPtr handle, long offset, ref long size, MemoryMappedFileAccess access, out IntPtr mmap_handle, out IntPtr base_address) {
			mmap_handle = default;
			base_address = default;
		} // 0x0000000182CFF180-0x0000000182CFF1B0
		private static Exception CreateException(int error, string path) => default; // 0x000000018973977C-0x0000000189739AD0
		private static int StringLength(string a) => default; // 0x00000001835FA1C0-0x00000001835FA1D0
		private static void CheckString(string name, string value) {} // 0x00000001835FA1D0-0x00000001835FA210
		internal static IntPtr OpenFile(string path, FileMode mode, string mapName, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options) {
			capacity = default;
			return default;
		} // 0x00000001835FA0C0-0x00000001835FA1C0
		internal static IntPtr OpenHandle(IntPtr handle, string mapName, out long capacity, MemoryMappedFileAccess access, MemoryMappedFileOptions options) {
			capacity = default;
			return default;
		} // 0x00000001835F9DF0-0x00000001835F9EA0
	}

	public class MemoryMappedFile : IDisposable // TypeDefIndex: 51268
	{
		// Fields
		private FileStream stream; // 0x10
		private bool keepOpen; // 0x18
		private SafeMemoryMappedFileHandle handle; // 0x20
	
		// Constructors
		private MemoryMappedFile() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode) => default; // 0x00000001835F9FD0-0x00000001835FA0C0
		public static MemoryMappedFile CreateFromFile(string path, FileMode mode, string mapName, long capacity, MemoryMappedFileAccess access) => default; // 0x0000000189739ADC-0x0000000189739D80
		public static MemoryMappedFile CreateFromFile(FileStream fileStream, string mapName, long capacity, MemoryMappedFileAccess access, HandleInheritability inheritability, bool leaveOpen) => default; // 0x00000001835F9C30-0x00000001835F9DC0
		public MemoryMappedViewAccessor CreateViewAccessor(long offset, long size, MemoryMappedFileAccess access) => default; // 0x0000000182CFEF90-0x0000000182CFF040
		public void Dispose() {} // 0x00000001842720D0-0x00000001842720DC
		protected virtual void Dispose(bool disposing) {} // 0x0000000182959A40-0x0000000182959AB0
		internal static FileAccess GetFileAccess(MemoryMappedFileAccess access) => default; // 0x0000000182CFF220-0x0000000182CFF240
	}

	internal class MemoryMappedView : IDisposable // TypeDefIndex: 51269
	{
		// Fields
		private SafeMemoryMappedViewHandle m_viewHandle; // 0x10
		private long m_pointerOffset; // 0x18
		private long m_size; // 0x20
		private MemoryMappedFileAccess m_access; // 0x28
	
		// Properties
		internal SafeMemoryMappedViewHandle ViewHandle { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		internal long PointerOffset { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal long Size { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		internal MemoryMappedFileAccess Access { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
		internal bool IsClosed { get => default; } // 0x000000018398D670-0x000000018398D690 
	
		// Constructors
		public MemoryMappedView() {} // Dummy constructor
		private MemoryMappedView(SafeMemoryMappedViewHandle viewHandle, long pointerOffset, long size, MemoryMappedFileAccess access) {} // 0x0000000182CFF150-0x0000000182CFF180
	
		// Methods
		internal static MemoryMappedView Create(IntPtr handle, long offset, long size, MemoryMappedFileAccess access) => default; // 0x0000000182CFF040-0x0000000182CFF150
		public void Flush(IntPtr capacity) {} // 0x0000000189739E18-0x0000000189739E40
		protected virtual void Dispose(bool disposing) {} // 0x0000000183A627E0-0x0000000183A62810
		public void Dispose() {} // 0x0000000183A62780-0x0000000183A627E0
	}
}

namespace System.Linq
{
	internal static class Error // TypeDefIndex: 50639
	{
		// Methods
		internal static Exception ArgumentNull(string s) => default; // 0x00000001896D67AC-0x00000001896D680C
		internal static Exception ArgumentOutOfRange(string s) => default; // 0x00000001896D680C-0x00000001896D686C
		internal static Exception MoreThanOneElement() => default; // 0x00000001896D686C-0x00000001896D68D0
		internal static Exception MoreThanOneMatch() => default; // 0x00000001896D68D0-0x00000001896D6934
		internal static Exception NoElements() => default; // 0x00000001896D6934-0x00000001896D6998
		internal static Exception NoMatch() => default; // 0x00000001896D6998-0x00000001896D69FC
		internal static Exception NotSupported() => default; // 0x00000001896D69FC-0x00000001896D6A4C
	}

	public static class Enumerable // TypeDefIndex: 50663
	{
		// Nested types
		private abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerator<TSource> // TypeDefIndex: 50640
		{
			// Fields
			private int threadId;
			internal int state;
			internal TSource current;
	
			// Properties
			public TSource Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Iterator() {}
	
			// Methods
			public abstract Iterator<TSource> Clone();
			public virtual void Dispose() {}
			public IEnumerator<TSource> GetEnumerator() => default;
			public abstract bool MoveNext();
			public abstract IEnumerable<TResult> Select<TResult>(System.Func<TSource, TResult> selector);
			public abstract IEnumerable<TSource> Where(System.Func<TSource, bool> predicate);
			IEnumerator IEnumerable.GetEnumerator() => default;
			void IEnumerator.Reset() {}
		}
	
		private class WhereEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 50641
		{
			// Fields
			private IEnumerable<TSource> source;
			private System.Func<TSource, bool> predicate;
			private IEnumerator<TSource> enumerator;
	
			// Constructors
			public WhereEnumerableIterator() {} // Dummy constructor
			public WhereEnumerableIterator(IEnumerable<TSource> source, System.Func<TSource, bool> predicate) {}
	
			// Methods
			public override Iterator<TSource> Clone() => default;
			public override void Dispose() {}
			public override bool MoveNext() => default;
			public override IEnumerable<TResult> Select<TResult>(System.Func<TSource, TResult> selector) => default;
			public override IEnumerable<TSource> Where(System.Func<TSource, bool> predicate) => default;
		}
	
		private class WhereArrayIterator<TSource> : Iterator<TSource> // TypeDefIndex: 50642
		{
			// Fields
			private TSource[] source;
			private System.Func<TSource, bool> predicate;
			private int index;
	
			// Constructors
			public WhereArrayIterator() {} // Dummy constructor
			public WhereArrayIterator(TSource[] source, System.Func<TSource, bool> predicate) {}
	
			// Methods
			public override Iterator<TSource> Clone() => default;
			public override bool MoveNext() => default;
			public override IEnumerable<TResult> Select<TResult>(System.Func<TSource, TResult> selector) => default;
			public override IEnumerable<TSource> Where(System.Func<TSource, bool> predicate) => default;
		}
	
		private class WhereListIterator<TSource> : Iterator<TSource> // TypeDefIndex: 50643
		{
			// Fields
			private List<TSource> source;
			private System.Func<TSource, bool> predicate;
			private List<TSource> enumerator;
	
			// Constructors
			public WhereListIterator() {} // Dummy constructor
			public WhereListIterator(List<TSource> source, System.Func<TSource, bool> predicate) {}
	
			// Methods
			public override Iterator<TSource> Clone() => default;
			public override bool MoveNext() => default;
			public override IEnumerable<TResult> Select<TResult>(System.Func<TSource, TResult> selector) => default;
			public override IEnumerable<TSource> Where(System.Func<TSource, bool> predicate) => default;
		}
	
		private class WhereSelectEnumerableIterator<TSource, TResult> : Iterator<TResult> // TypeDefIndex: 50644
		{
			// Fields
			private IEnumerable<TSource> source;
			private System.Func<TSource, bool> predicate;
			private System.Func<TSource, TResult> selector;
			private IEnumerator<TSource> enumerator;
	
			// Constructors
			public WhereSelectEnumerableIterator() {} // Dummy constructor
			public WhereSelectEnumerableIterator(IEnumerable<TSource> source, System.Func<TSource, bool> predicate, System.Func<TSource, TResult> selector) {}
	
			// Methods
			public override Iterator<TResult> Clone() => default;
			public override void Dispose() {}
			public override bool MoveNext() => default;
			public override IEnumerable<TResult2> Select<TResult2>(System.Func<TResult, TResult2> selector) => default;
			public override IEnumerable<TResult> Where(System.Func<TResult, bool> predicate) => default;
		}
	
		private class WhereSelectArrayIterator<TSource, TResult> : Iterator<TResult> // TypeDefIndex: 50645
		{
			// Fields
			private TSource[] source;
			private System.Func<TSource, bool> predicate;
			private System.Func<TSource, TResult> selector;
			private int index;
	
			// Constructors
			public WhereSelectArrayIterator() {} // Dummy constructor
			public WhereSelectArrayIterator(TSource[] source, System.Func<TSource, bool> predicate, System.Func<TSource, TResult> selector) {}
	
			// Methods
			public override Iterator<TResult> Clone() => default;
			public override bool MoveNext() => default;
			public override IEnumerable<TResult2> Select<TResult2>(System.Func<TResult, TResult2> selector) => default;
			public override IEnumerable<TResult> Where(System.Func<TResult, bool> predicate) => default;
		}
	
		private class WhereSelectListIterator<TSource, TResult> : Iterator<TResult> // TypeDefIndex: 50646
		{
			// Fields
			private List<TSource> source;
			private System.Func<TSource, bool> predicate;
			private System.Func<TSource, TResult> selector;
			private List<TSource> enumerator;
	
			// Constructors
			public WhereSelectListIterator() {} // Dummy constructor
			public WhereSelectListIterator(List<TSource> source, System.Func<TSource, bool> predicate, System.Func<TSource, TResult> selector) {}
	
			// Methods
			public override Iterator<TResult> Clone() => default;
			public override bool MoveNext() => default;
			public override IEnumerable<TResult2> Select<TResult2>(System.Func<TResult, TResult2> selector) => default;
			public override IEnumerable<TResult> Where(System.Func<TResult, bool> predicate) => default;
		}
	
		// Methods
		private static System.Func<TSource, bool> CombinePredicates<TSource>(System.Func<TSource, bool> predicate1, System.Func<TSource, bool> predicate2) => default;
		private static System.Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(System.Func<TSource, TMiddle> selector1, System.Func<TMiddle, TResult> selector2) => default;
		[IteratorStateMachine(typeof(_SelectManyIterator_d__17<TSource, TResult>))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, System.Func<TSource, IEnumerable<TResult>> selector) => default;
		[IteratorStateMachine(typeof(_SelectManyIterator_d__23<TSource, TCollection, TResult>))]
		private static IEnumerable<TResult> SelectManyIterator<TSource, TCollection, TResult>(IEnumerable<TSource> source, System.Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) => default;
		[IteratorStateMachine(typeof(_SkipIterator_d__31<TSource>))]
		private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) => default;
		[IteratorStateMachine(typeof(_JoinIterator_d__38<TOuter, TInner, TKey, TResult>))]
		private static IEnumerable<TResult> JoinIterator<TOuter, TInner, TKey, TResult>(IEnumerable<TOuter> outer, IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer) => default;
		[IteratorStateMachine(typeof(_ConcatIterator_d__59<TSource>))]
		private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) => default;
		[IteratorStateMachine(typeof(_PrependIterator_d__63<TSource>))]
		private static IEnumerable<TSource> PrependIterator<TSource>(IEnumerable<TSource> source, TSource element) => default;
		[IteratorStateMachine(typeof(_DistinctIterator_d__68<TSource>))]
		private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) => default;
		[IteratorStateMachine(typeof(_UnionIterator_d__71<TSource>))]
		private static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) => default;
		[IteratorStateMachine(typeof(_IntersectIterator_d__74<TSource>))]
		private static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) => default;
		[IteratorStateMachine(typeof(_ReverseIterator_d__79<TSource>))]
		private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) => default;
		[IteratorStateMachine(typeof(_OfTypeIterator_d__97<TResult>))]
		private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) => default;
		[IteratorStateMachine(typeof(_CastIterator_d__99<TResult>))]
		private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) => default;
		public static IEnumerable<int> Range(int start, int count) => default; // 0x0000000182E7BEE0-0x0000000182E7BF20
		[IteratorStateMachine(typeof(_RangeIterator_d__115))]
		private static IEnumerable<int> RangeIterator(int start, int count) => default; // 0x0000000182E7BE60-0x0000000182E7BEE0
		public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) => default;
		[IteratorStateMachine(typeof(_RepeatIterator_d__117<TResult>))]
		private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count) => default;
		public static IEnumerable<TResult> Empty<TResult>() => default;
	
		// Extension methods
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, System.Func<TSource, TResult> selector) => default;
		public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, System.Func<TSource, IEnumerable<TResult>> selector) => default;
		public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, System.Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector) => default;
		public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count) => default;
		public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, System.Func<TOuter, TKey> outerKeySelector, System.Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector) => default;
		public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) => default;
		public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) => default;
		public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) => default;
		public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) => default;
		public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) => default;
		public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) => default;
		public static IEnumerable<TSource> Prepend<TSource>(this IEnumerable<TSource> source, TSource element) => default;
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source) => default;
		public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) => default;
		public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) => default;
		public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) => default;
		public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source) => default;
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) => default;
		public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) => default;
		public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source) => default;
		public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source) => default;
		public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector) => default;
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector) => default;
		public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) => default;
		public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source) => default;
		public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source) => default;
		public static TSource First<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource First<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static TSource Last<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static TSource Single<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource Single<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source) => default;
		public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index) => default;
		public static bool Any<TSource>(this IEnumerable<TSource> source) => default;
		public static bool Any<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static bool All<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static int Count<TSource>(this IEnumerable<TSource> source) => default;
		public static int Count<TSource>(this IEnumerable<TSource> source, System.Func<TSource, bool> predicate) => default;
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value) => default;
		public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) => default;
		public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func) => default;
		public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func) => default;
		public static int Min(this IEnumerable<int> source) => default; // 0x00000001896D6604-0x00000001896D67AC
		public static int Max(this IEnumerable<int> source) => default; // 0x00000001896D645C-0x00000001896D6604
		public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source) => default;
		public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) => default;
	}

	internal class EmptyEnumerable<TElement> // TypeDefIndex: 50664
	{
		// Fields
		public static readonly TElement[] Instance;
	
		// Constructors
		public EmptyEnumerable() {} // Dummy constructor
		static EmptyEnumerable() {}
	}

	internal class IdentityFunction<TElement> // TypeDefIndex: 50666
	{
		// Properties
		public static System.Func<TElement, TElement> Instance { get => default; }
	
		// Constructors
		public IdentityFunction() {} // Dummy constructor
	}

	public interface IOrderedEnumerable<TElement> : IEnumerable<TElement> // TypeDefIndex: 50667
	{
		// Methods
		IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(System.Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	}

	public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement> // TypeDefIndex: 50668
	{
		// Properties
		TKey Key { get; }
	}

	[DefaultMember("Item")]
	public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>> // TypeDefIndex: 50669
	{
	}

	[DefaultMember("Item")]
	public class Lookup<TKey, TElement> : ILookup<TKey, TElement> // TypeDefIndex: 50673
	{
		// Fields
		private IEqualityComparer<TKey> comparer;
		private Grouping[] groupings;
		private Grouping lastGrouping;
		private int count;
	
		// Nested types
		internal class Grouping : IGrouping<TKey, TElement>, IList<TElement> // TypeDefIndex: 50671
		{
			// Fields
			internal TKey key;
			internal int hashCode;
			internal TElement[] elements;
			internal int count;
			internal Grouping<TKey, TElement> hashNext;
			internal Grouping<TKey, TElement> next;
	
			// Properties
			public TKey Key { get => default; }
			int ICollection<TElement>.Count { get => default; }
			bool ICollection<TElement>.IsReadOnly { get => default; }
			TElement IList<TElement>.this[int index] { get => default; set {} }
	
			// Constructors
			public Grouping() {}
	
			// Methods
			internal void Add(TElement element) {}
			[IteratorStateMachine(typeof(_GetEnumerator_d__7))]
			public IEnumerator<TElement> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
			void ICollection<TElement>.Add(TElement item) {}
			void ICollection<TElement>.Clear() {}
			bool ICollection<TElement>.Contains(TElement item) => default;
			void ICollection<TElement>.CopyTo(TElement[] array, int arrayIndex) {}
			bool ICollection<TElement>.Remove(TElement item) => default;
			int IList<TElement>.IndexOf(TElement item) => default;
			void IList<TElement>.Insert(int index, TElement item) {}
			void IList<TElement>.RemoveAt(int index) {}
		}
	
		// Constructors
		public Lookup() {} // Dummy constructor
		private Lookup(IEqualityComparer<TKey> comparer) {}
	
		// Methods
		internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) => default;
		internal static Lookup<TKey, TElement> CreateForJoin(IEnumerable<TElement> source, System.Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer) => default;
		[IteratorStateMachine(typeof(_GetEnumerator_d__12))]
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		internal int InternalGetHashCode(TKey key) => default;
		internal Grouping GetGrouping(TKey key, bool create) => default;
		private void Resize() {}
	}

	internal class Set<TElement> // TypeDefIndex: 50675
	{
		// Fields
		private int[] buckets;
		private Slot[] slots;
		private int count;
		private int freeList;
		private IEqualityComparer<TElement> comparer;
	
		// Nested types
		internal struct Slot // TypeDefIndex: 50674
		{
			// Fields
			internal int hashCode;
			internal TElement value;
			internal int next;
		}
	
		// Constructors
		public Set() {} // Dummy constructor
		public Set(IEqualityComparer<TElement> comparer) {}
	
		// Methods
		public bool Add(TElement value) => default;
		public bool Remove(TElement value) => default;
		private bool Find(TElement value, bool add) => default;
		private void Resize() {}
		internal int InternalGetHashCode(TElement value) => default;
	}

	internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>> // TypeDefIndex: 50676
	{
		// Fields
		private IEnumerable<TSource> source;
		private System.Func<TSource, TKey> keySelector;
		private System.Func<TSource, TElement> elementSelector;
		private IEqualityComparer<TKey> comparer;
	
		// Constructors
		public GroupedEnumerable() {} // Dummy constructor
		public GroupedEnumerable(IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector, System.Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) {}
	
		// Methods
		public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement> // TypeDefIndex: 50678
	{
		// Fields
		internal IEnumerable<TElement> source;
	
		// Constructors
		protected OrderedEnumerable() {}
	
		// Methods
		[IteratorStateMachine(typeof(_GetEnumerator_d__1))]
		public IEnumerator<TElement> GetEnumerator() => default;
		internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
		IEnumerator IEnumerable.GetEnumerator() => default;
		IOrderedEnumerable<TElement> IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(System.Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) => default;
	}

	internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 50679
	{
		// Fields
		internal OrderedEnumerable<TElement> parent;
		internal System.Func<TElement, TKey> keySelector;
		internal IComparer<TKey> comparer;
		internal bool descending;
	
		// Constructors
		public OrderedEnumerable() {} // Dummy constructor
		internal OrderedEnumerable(IEnumerable<TElement> source, System.Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) {}
	
		// Methods
		internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) => default;
	}

	internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 50680
	{
		// Constructors
		protected EnumerableSorter() {}
	
		// Methods
		internal abstract void ComputeKeys(TElement[] elements, int count);
		internal abstract int CompareKeys(int index1, int index2);
		internal int[] Sort(TElement[] elements, int count) => default;
		private void QuickSort(int[] map, int left, int right) {}
	}

	internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement> // TypeDefIndex: 50681
	{
		// Fields
		internal System.Func<TElement, TKey> keySelector;
		internal IComparer<TKey> comparer;
		internal bool descending;
		internal EnumerableSorter<TElement> next;
		internal TKey[] keys;
	
		// Constructors
		public EnumerableSorter() {} // Dummy constructor
		internal EnumerableSorter(System.Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) {}
	
		// Methods
		internal override void ComputeKeys(TElement[] elements, int count) {}
		internal override int CompareKeys(int index1, int index2) => default;
	}

	internal struct Buffer<TElement> // TypeDefIndex: 50682
	{
		// Fields
		internal TElement[] items;
		internal int count;
	
		// Constructors
		internal Buffer(IEnumerable<TElement> source) {
			items = default;
			count = default;
		}
	
		// Methods
		internal TElement[] ToArray() => default;
	}
}

namespace System.Linq.Expressions
{
	internal static class CachedReflectionInfo // TypeDefIndex: 50683
	{
		// Fields
		private static MethodInfo s_CallSiteOps_SetNotMatched; // 0x00
		private static MethodInfo s_CallSiteOps_CreateMatchmaker; // 0x08
		private static MethodInfo s_CallSiteOps_GetMatch; // 0x10
		private static MethodInfo s_CallSiteOps_ClearMatch; // 0x18
		private static MethodInfo s_CallSiteOps_UpdateRules; // 0x20
		private static MethodInfo s_CallSiteOps_GetRules; // 0x28
		private static MethodInfo s_CallSiteOps_GetRuleCache; // 0x30
		private static MethodInfo s_CallSiteOps_GetCachedRules; // 0x38
		private static MethodInfo s_CallSiteOps_AddRule; // 0x40
		private static MethodInfo s_CallSiteOps_MoveRule; // 0x48
		private static MethodInfo s_CallSiteOps_Bind; // 0x50
		private static MethodInfo s_String_op_Equality_String_String; // 0x58
		private static MethodInfo s_Math_Pow_Double_Double; // 0x60
	
		// Properties
		public static MethodInfo CallSiteOps_SetNotMatched { get; } // 0x00000001896D5F98-0x00000001896D6060 
		public static MethodInfo CallSiteOps_CreateMatchmaker { get; } // 0x00000001896D5AD0-0x00000001896D5B9C 
		public static MethodInfo CallSiteOps_GetMatch { get; } // 0x00000001896D5C68-0x00000001896D5D34 
		public static MethodInfo CallSiteOps_ClearMatch { get; } // 0x00000001896D5A04-0x00000001896D5AD0 
		public static MethodInfo CallSiteOps_UpdateRules { get; } // 0x00000001896D6060-0x00000001896D612C 
		public static MethodInfo CallSiteOps_GetRules { get; } // 0x00000001896D5E00-0x00000001896D5ECC 
		public static MethodInfo CallSiteOps_GetRuleCache { get; } // 0x00000001896D5D34-0x00000001896D5E00 
		public static MethodInfo CallSiteOps_GetCachedRules { get; } // 0x00000001896D5B9C-0x00000001896D5C68 
		public static MethodInfo CallSiteOps_AddRule { get; } // 0x00000001896D586C-0x00000001896D5938 
		public static MethodInfo CallSiteOps_MoveRule { get; } // 0x00000001896D5ECC-0x00000001896D5F98 
		public static MethodInfo CallSiteOps_Bind { get; } // 0x00000001896D5938-0x00000001896D5A04 
		public static MethodInfo String_op_Equality_String_String { get; } // 0x00000001896D62A0-0x00000001896D6408 
		public static MethodInfo Math_Pow_Double_Double { get; } // 0x00000001896D612C-0x00000001896D62A0 
	}

	[DebuggerTypeProxy(typeof(BinaryExpressionProxy))]
	public class BinaryExpression : Expression // TypeDefIndex: 50684
	{
		// Properties
		public override bool CanReduce { get => default; } // 0x00000001896D54B4-0x00000001896D54D4 
		public Expression Right { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Expression Left { get; } // 0x0000000181041090-0x00000001810410A0 
		public MethodInfo Method { get => default; } // 0x00000001896D585C-0x00000001896D586C 
		public LambdaExpression Conversion { get => default; } // 0x00000001896D54D4-0x00000001896D54DC 
		public bool IsLifted { get => default; } // 0x00000001896D5670-0x00000001896D57A4 
		public bool IsLiftedToNull { get => default; } // 0x00000001896D560C-0x00000001896D5670 
		internal bool IsLiftedLogical { get => default; } // 0x00000001896D54DC-0x00000001896D560C 
		internal bool IsReferenceComparison { get => default; } // 0x00000001896D57A4-0x00000001896D585C 
	
		// Constructors
		public BinaryExpression() {} // Dummy constructor
		internal BinaryExpression(Expression left, Expression right) {} // 0x00000001896D5448-0x00000001896D54B4
	
		// Methods
		private static bool IsOpAssignment(ExpressionType op) => default; // 0x00000001896D44F0-0x00000001896D44FC
		internal virtual MethodInfo GetMethod() => default; // 0x0000000181002730-0x0000000181002740
		public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) => default; // 0x00000001896D5330-0x00000001896D5448
		public override Expression Reduce() => default; // 0x00000001896D52C0-0x00000001896D5330
		private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) => default; // 0x00000001896D4410-0x00000001896D44F0
		private Expression ReduceVariable() => default; // 0x00000001896D51CC-0x00000001896D52C0
		private Expression ReduceMember() => default; // 0x00000001896D490C-0x00000001896D4C84
		private Expression ReduceIndex() => default; // 0x00000001896D44FC-0x00000001896D490C
		internal virtual LambdaExpression GetConversion() => default; // 0x0000000181002730-0x0000000181002740
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896D43C8-0x00000001896D4410
		internal Expression ReduceUserdefinedLifted() => default; // 0x00000001896D4C84-0x00000001896D51CC
	}

	internal sealed class LogicalBinaryExpression : BinaryExpression // TypeDefIndex: 50685
	{
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001896EC530-0x00000001896EC580 
		public sealed override ExpressionType NodeType { get; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Constructors
		public LogicalBinaryExpression() {} // Dummy constructor
		internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right) {} // 0x00000001896EC4FC-0x00000001896EC530
	}

	internal class AssignBinaryExpression : BinaryExpression // TypeDefIndex: 50686
	{
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001896D43A4-0x00000001896D43C8 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D56140-0x0000000183D56150 
	
		// Constructors
		public AssignBinaryExpression() {} // Dummy constructor
		internal AssignBinaryExpression(Expression left, Expression right) {} // 0x00000001896D439C-0x00000001896D43A4
	}

	internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 50687
	{
		// Fields
		private readonly LambdaExpression _conversion; // 0x20
	
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55AA0-0x0000000183D55AB0 
		public sealed override System.Type Type { get => default; } // 0x00000001896D6438-0x00000001896D645C 
	
		// Constructors
		public CoalesceConversionBinaryExpression() {} // Dummy constructor
		internal CoalesceConversionBinaryExpression(Expression left, Expression right, LambdaExpression conversion) {} // 0x00000001896D6408-0x00000001896D6438
	
		// Methods
		internal override LambdaExpression GetConversion() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
	}

	internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression // TypeDefIndex: 50688
	{
		// Fields
		private readonly LambdaExpression _conversion; // 0x38
	
		// Constructors
		public OpAssignMethodConversionBinaryExpression() {} // Dummy constructor
		internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, System.Type type, MethodInfo method, LambdaExpression conversion) {} // 0x00000001896EC5B8-0x00000001896EC600
	
		// Methods
		internal override LambdaExpression GetConversion() => default; // 0x0000000183D4E2A0-0x0000000183D4E2B0
	}

	internal class SimpleBinaryExpression : BinaryExpression // TypeDefIndex: 50689
	{
		// Properties
		public sealed override ExpressionType NodeType { get; } // 0x0000000181003B50-0x0000000181003B60 
		public sealed override System.Type Type { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public SimpleBinaryExpression() {} // Dummy constructor
		internal SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, System.Type type) {} // 0x00000001896ECA8C-0x00000001896ECAD0
	}

	internal class MethodBinaryExpression : SimpleBinaryExpression // TypeDefIndex: 50690
	{
		// Fields
		private readonly MethodInfo _method; // 0x30
	
		// Constructors
		public MethodBinaryExpression() {} // Dummy constructor
		internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, System.Type type, MethodInfo method) {} // 0x00000001896EC580-0x00000001896EC5B8
	
		// Methods
		internal override MethodInfo GetMethod() => default; // 0x0000000181003830-0x0000000181003840
	}

	public abstract class Expression // TypeDefIndex: 50718
	{
		// Fields
		private static readonly CacheDict<System.Type, MethodInfo> s_lambdaDelegateCache; // 0x00
		private static CacheDict<System.Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>> s_lambdaFactories; // 0x08
		private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable; // 0x10
	
		// Properties
		public virtual ExpressionType NodeType { get; } // 0x00000001896EC34C-0x00000001896EC424 
		public virtual System.Type Type { get; } // 0x00000001896EC424-0x00000001896EC4FC 
		public virtual bool CanReduce { get; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Nested types
		internal class BinaryExpressionProxy // TypeDefIndex: 50691
		{
			// Constructors
			public BinaryExpressionProxy() {} // Dummy constructor
		}
	
		internal class BlockExpressionProxy // TypeDefIndex: 50692
		{
			// Constructors
			public BlockExpressionProxy() {} // Dummy constructor
		}
	
		internal class CatchBlockProxy // TypeDefIndex: 50693
		{
			// Constructors
			public CatchBlockProxy() {} // Dummy constructor
		}
	
		internal class ConditionalExpressionProxy // TypeDefIndex: 50694
		{
			// Constructors
			public ConditionalExpressionProxy() {} // Dummy constructor
		}
	
		internal class ConstantExpressionProxy // TypeDefIndex: 50695
		{
			// Constructors
			public ConstantExpressionProxy() {} // Dummy constructor
		}
	
		internal class DebugInfoExpressionProxy // TypeDefIndex: 50696
		{
			// Constructors
			public DebugInfoExpressionProxy() {} // Dummy constructor
		}
	
		internal class DefaultExpressionProxy // TypeDefIndex: 50697
		{
			// Constructors
			public DefaultExpressionProxy() {} // Dummy constructor
		}
	
		internal class GotoExpressionProxy // TypeDefIndex: 50698
		{
			// Constructors
			public GotoExpressionProxy() {} // Dummy constructor
		}
	
		internal class IndexExpressionProxy // TypeDefIndex: 50699
		{
			// Constructors
			public IndexExpressionProxy() {} // Dummy constructor
		}
	
		internal class InvocationExpressionProxy // TypeDefIndex: 50700
		{
			// Constructors
			public InvocationExpressionProxy() {} // Dummy constructor
		}
	
		internal class LabelExpressionProxy // TypeDefIndex: 50701
		{
			// Constructors
			public LabelExpressionProxy() {} // Dummy constructor
		}
	
		internal class LambdaExpressionProxy // TypeDefIndex: 50702
		{
			// Constructors
			public LambdaExpressionProxy() {} // Dummy constructor
		}
	
		internal class ListInitExpressionProxy // TypeDefIndex: 50703
		{
			// Constructors
			public ListInitExpressionProxy() {} // Dummy constructor
		}
	
		internal class LoopExpressionProxy // TypeDefIndex: 50704
		{
			// Constructors
			public LoopExpressionProxy() {} // Dummy constructor
		}
	
		internal class MemberExpressionProxy // TypeDefIndex: 50705
		{
			// Constructors
			public MemberExpressionProxy() {} // Dummy constructor
		}
	
		internal class MemberInitExpressionProxy // TypeDefIndex: 50706
		{
			// Constructors
			public MemberInitExpressionProxy() {} // Dummy constructor
		}
	
		internal class MethodCallExpressionProxy // TypeDefIndex: 50707
		{
			// Constructors
			public MethodCallExpressionProxy() {} // Dummy constructor
		}
	
		internal class NewArrayExpressionProxy // TypeDefIndex: 50708
		{
			// Constructors
			public NewArrayExpressionProxy() {} // Dummy constructor
		}
	
		internal class NewExpressionProxy // TypeDefIndex: 50709
		{
			// Constructors
			public NewExpressionProxy() {} // Dummy constructor
		}
	
		internal class ParameterExpressionProxy // TypeDefIndex: 50710
		{
			// Constructors
			public ParameterExpressionProxy() {} // Dummy constructor
		}
	
		internal class RuntimeVariablesExpressionProxy // TypeDefIndex: 50711
		{
			// Constructors
			public RuntimeVariablesExpressionProxy() {} // Dummy constructor
		}
	
		internal class SwitchCaseProxy // TypeDefIndex: 50712
		{
			// Constructors
			public SwitchCaseProxy() {} // Dummy constructor
		}
	
		internal class SwitchExpressionProxy // TypeDefIndex: 50713
		{
			// Constructors
			public SwitchExpressionProxy() {} // Dummy constructor
		}
	
		internal class TryExpressionProxy // TypeDefIndex: 50714
		{
			// Constructors
			public TryExpressionProxy() {} // Dummy constructor
		}
	
		internal class TypeBinaryExpressionProxy // TypeDefIndex: 50715
		{
			// Constructors
			public TypeBinaryExpressionProxy() {} // Dummy constructor
		}
	
		internal class UnaryExpressionProxy // TypeDefIndex: 50716
		{
			// Constructors
			public UnaryExpressionProxy() {} // Dummy constructor
		}
	
		private class ExtensionInfo // TypeDefIndex: 50717
		{
			// Fields
			internal readonly ExpressionType NodeType; // 0x10
			internal readonly System.Type Type; // 0x18
	
			// Constructors
			public ExtensionInfo() {} // Dummy constructor
		}
	
		// Constructors
		protected Expression() {} // 0x000000018350B670-0x000000018350B680
		static Expression() {} // 0x00000001896EC2B8-0x00000001896EC34C
	
		// Methods
		public static BinaryExpression Assign(Expression left, Expression right) => default; // 0x00000001896D8508-0x00000001896D86C4
		private static BinaryExpression GetUserDefinedBinaryOperator(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) => default; // 0x00000001896DFC50-0x00000001896DFFA8
		private static BinaryExpression GetMethodBasedBinaryOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, bool liftToNull) => default; // 0x00000001896DE52C-0x00000001896DEA64
		private static BinaryExpression GetMethodBasedAssignOperator(ExpressionType binaryType, Expression left, Expression right, MethodInfo method, LambdaExpression conversion, bool liftToNull) => default; // 0x00000001896DE2E0-0x00000001896DE52C
		private static BinaryExpression GetUserDefinedBinaryOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, bool liftToNull) => default; // 0x00000001896DFA5C-0x00000001896DFC50
		private static BinaryExpression GetUserDefinedAssignOperatorOrThrow(ExpressionType binaryType, string name, Expression left, Expression right, LambdaExpression conversion, bool liftToNull) => default; // 0x00000001896DF810-0x00000001896DFA5C
		private static MethodInfo GetUserDefinedBinaryOperator(ExpressionType binaryType, System.Type leftType, System.Type rightType, string name) => default; // 0x00000001896DFFA8-0x00000001896E0158
		private static bool IsLiftingConditionalLogicalOperator(System.Type left, System.Type right, MethodInfo method, ExpressionType binaryType) => default; // 0x00000001896E1DE4-0x00000001896E1E84
		internal static bool ParameterIsAssignable(ParameterInfo pi, System.Type argType) => default; // 0x00000001896E68D0-0x00000001896E6954
		private static void ValidateParamswithOperandsOrThrow(System.Type paramType, System.Type operandType, ExpressionType exprType, string name) {} // 0x00000001896EAFF4-0x00000001896EB0C0
		private static void ValidateOperator(MethodInfo method) {} // 0x00000001896EAEBC-0x00000001896EAFF4
		private static void ValidateMethodInfo(MethodInfo method, string paramName) {} // 0x00000001896EABBC-0x00000001896EAC34
		private static bool IsNullComparison(Expression left, Expression right) => default; // 0x00000001896E1E84-0x00000001896E1F50
		private static bool IsNullConstant(Expression e) => default; // 0x00000001896E1F50-0x00000001896E1F9C
		private static void ValidateUserDefinedConditionalLogicOperator(ExpressionType nodeType, System.Type left, System.Type right, MethodInfo method) {} // 0x00000001896EB6DC-0x00000001896EBD30
		private static void VerifyOpTrueFalse(ExpressionType nodeType, System.Type left, MethodInfo opTrue, string paramName) {} // 0x00000001896EC090-0x00000001896EC248
		private static bool IsValidLiftedConditionalLogicalOperator(System.Type left, System.Type right, ParameterInfo[] pms) => default; // 0x00000001896E2190-0x00000001896E2258
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E36C4-0x00000001896E3748
		public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right, bool liftToNull, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E2DC0-0x00000001896E36C4
		public static BinaryExpression Equal(Expression left, Expression right) => default; // 0x00000001896DD0CC-0x00000001896DD128
		public static BinaryExpression Equal(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896DD128-0x00000001896DD204
		public static BinaryExpression ReferenceEqual(Expression left, Expression right) => default; // 0x00000001896E78EC-0x00000001896E7A4C
		public static BinaryExpression NotEqual(Expression left, Expression right) => default; // 0x00000001896E5BFC-0x00000001896E5C58
		public static BinaryExpression NotEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E5C58-0x00000001896E5D34
		public static BinaryExpression ReferenceNotEqual(Expression left, Expression right) => default; // 0x00000001896E7A4C-0x00000001896E7BAC
		private static BinaryExpression GetEqualityComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) => default; // 0x00000001896DDDB0-0x00000001896DE140
		public static BinaryExpression GreaterThan(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E0878-0x00000001896E0954
		public static BinaryExpression LessThan(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E2BC4-0x00000001896E2CA0
		public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E079C-0x00000001896E0878
		public static BinaryExpression LessThanOrEqual(Expression left, Expression right, bool liftToNull, MethodInfo method) => default; // 0x00000001896E2AE8-0x00000001896E2BC4
		private static BinaryExpression GetComparisonOperator(ExpressionType binaryType, string opName, Expression left, Expression right, bool liftToNull) => default; // 0x00000001896DDBC4-0x00000001896DDDB0
		public static BinaryExpression AndAlso(Expression left, Expression right) => default; // 0x00000001896D7720-0x00000001896D7774
		public static BinaryExpression AndAlso(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896D72B8-0x00000001896D7720
		public static BinaryExpression OrElse(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E628C-0x00000001896E66F4
		public static BinaryExpression Coalesce(Expression left, Expression right, LambdaExpression conversion) => default; // 0x00000001896DB664-0x00000001896DBAF8
		private static System.Type ValidateCoalesceArgTypes(System.Type left, System.Type right) => default; // 0x00000001896E9B70-0x00000001896E9CC4
		public static BinaryExpression Add(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896D70E8-0x00000001896D72B8
		public static BinaryExpression AddAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896D6CD0-0x00000001896D6F0C
		private static void ValidateOpAssignConversionLambda(LambdaExpression conversion, Expression left, MethodInfo method, ExpressionType nodeType) {} // 0x00000001896EAC68-0x00000001896EAEBC
		public static BinaryExpression AddAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896D6A94-0x00000001896D6CD0
		public static BinaryExpression AddChecked(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896D6F0C-0x00000001896D70E8
		public static BinaryExpression Subtract(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E89A8-0x00000001896E8B84
		public static BinaryExpression SubtractAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E8590-0x00000001896E87CC
		public static BinaryExpression SubtractAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E8354-0x00000001896E8590
		public static BinaryExpression SubtractChecked(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E87CC-0x00000001896E89A8
		public static BinaryExpression Divide(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896DCE5C-0x00000001896DD038
		public static BinaryExpression DivideAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896DCC20-0x00000001896DCE5C
		public static BinaryExpression Modulo(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E47D4-0x00000001896E49B0
		public static BinaryExpression ModuloAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E4598-0x00000001896E47D4
		public static BinaryExpression Multiply(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E5004-0x00000001896E51E0
		public static BinaryExpression MultiplyAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E4BEC-0x00000001896E4E28
		public static BinaryExpression MultiplyAssignChecked(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E49B0-0x00000001896E4BEC
		public static BinaryExpression MultiplyChecked(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E4E28-0x00000001896E5004
		private static bool IsSimpleShift(System.Type left, System.Type right) => default; // 0x00000001896E1F9C-0x00000001896E2044
		private static System.Type GetResultTypeOfShift(System.Type left, System.Type right) => default; // 0x00000001896DF704-0x00000001896DF810
		public static BinaryExpression LeftShift(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E2914-0x00000001896E2AE8
		public static BinaryExpression LeftShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E26E8-0x00000001896E2914
		public static BinaryExpression RightShift(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E8180-0x00000001896E8354
		public static BinaryExpression RightShiftAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E7F54-0x00000001896E8180
		public static BinaryExpression And(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896D79B0-0x00000001896D7B8C
		public static BinaryExpression AndAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896D7774-0x00000001896D79B0
		public static BinaryExpression Or(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E66F4-0x00000001896E68D0
		public static BinaryExpression OrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E6050-0x00000001896E628C
		public static BinaryExpression ExclusiveOr(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896DD440-0x00000001896DD61C
		public static BinaryExpression ExclusiveOrAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896DD204-0x00000001896DD440
		public static BinaryExpression Power(Expression left, Expression right, MethodInfo method) => default; // 0x00000001896E6C50-0x00000001896E6F74
		public static BinaryExpression PowerAssign(Expression left, Expression right, MethodInfo method, LambdaExpression conversion) => default; // 0x00000001896E6AE0-0x00000001896E6C50
		public static BinaryExpression ArrayIndex(Expression array, Expression index) => default; // 0x00000001896D8130-0x00000001896D8328
		public static BlockExpression Block(Expression arg0, Expression arg1) => default; // 0x00000001896D8E78-0x00000001896D8F24
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2) => default; // 0x00000001896D90BC-0x00000001896D9198
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3) => default; // 0x00000001896D8D68-0x00000001896D8E78
		public static BlockExpression Block(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) => default; // 0x00000001896D8F84-0x00000001896D90BC
		public static BlockExpression Block(IEnumerable<Expression> expressions) => default; // 0x00000001896D9324-0x00000001896D939C
		public static BlockExpression Block(System.Type type, params Expression[] expressions) => default; // 0x00000001896D8CB8-0x00000001896D8D68
		public static BlockExpression Block(System.Type type, IEnumerable<Expression> expressions) => default; // 0x00000001896D8C30-0x00000001896D8CB8
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, params Expression[] expressions) => default; // 0x00000001896D939C-0x00000001896D93F8
		public static BlockExpression Block(System.Type type, IEnumerable<ParameterExpression> variables, params Expression[] expressions) => default; // 0x00000001896D8F24-0x00000001896D8F84
		public static BlockExpression Block(IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) => default; // 0x00000001896D9198-0x00000001896D9324
		public static BlockExpression Block(System.Type type, IEnumerable<ParameterExpression> variables, IEnumerable<Expression> expressions) => default; // 0x00000001896D89D8-0x00000001896D8C30
		private static BlockExpression BlockCore(System.Type type, ReadOnlyCollection<ParameterExpression> variables, ReadOnlyCollection<Expression> expressions) => default; // 0x00000001896D86C4-0x00000001896D89D8
		internal static void ValidateVariables(ReadOnlyCollection<ParameterExpression> varList, string collectionName) {} // 0x00000001896EBD30-0x00000001896EBF08
		private static BlockExpression GetOptimizedBlockExpression(IReadOnlyList<Expression> expressions) => default; // 0x00000001896DF108-0x00000001896DF528
		public static CatchBlock MakeCatchBlock(System.Type type, ParameterExpression variable, Expression body, Expression filter) => default; // 0x00000001896E3748-0x00000001896E39C4
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse) => default; // 0x00000001896DBD70-0x00000001896DBF48
		public static ConditionalExpression Condition(Expression test, Expression ifTrue, Expression ifFalse, System.Type type) => default; // 0x00000001896DBAF8-0x00000001896DBD70
		public static ConditionalExpression IfThen(Expression test, Expression ifTrue) => default; // 0x00000001896E0954-0x00000001896E0A04
		public static ConstantExpression Constant(object value) => default; // 0x00000001896DC178-0x00000001896DC1D8
		public static ConstantExpression Constant(object value, System.Type type) => default; // 0x00000001896DBF48-0x00000001896DC178
		public static DefaultExpression Empty() => default; // 0x00000001896DD038-0x00000001896DD0CC
		public static DefaultExpression Default(System.Type type) => default; // 0x00000001896DCB3C-0x00000001896DCC20
		public virtual Expression Reduce() => default; // 0x00000001896E78A4-0x00000001896E78EC
		protected internal virtual Expression VisitChildren(ExpressionVisitor visitor) => default; // 0x00000001896EC248-0x00000001896EC2B8
		protected internal virtual Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896D6A4C-0x00000001896D6A94
		public Expression ReduceAndCheck() => default; // 0x00000001896E7790-0x00000001896E78A4
		public override string ToString() => default; // 0x00000001896E8D00-0x00000001896E8D08
		private static void RequiresCanRead(IReadOnlyList<Expression> items, string paramName) {} // 0x00000001896E7BAC-0x00000001896E7C50
		private static void RequiresCanWrite(Expression expression, string paramName) {} // 0x00000001896E7C50-0x00000001896E7E24
		public static GotoExpression Break(LabelTarget target) => default; // 0x00000001896D93F8-0x00000001896D9488
		public static GotoExpression Return(LabelTarget target) => default; // 0x00000001896E7E24-0x00000001896E7EB4
		public static GotoExpression Return(LabelTarget target, Expression value) => default; // 0x00000001896E7EB4-0x00000001896E7F54
		public static GotoExpression Goto(LabelTarget target, System.Type type) => default; // 0x00000001896E0740-0x00000001896E079C
		public static GotoExpression Goto(LabelTarget target, Expression value) => default; // 0x00000001896E06A4-0x00000001896E0740
		public static GotoExpression MakeGoto(GotoExpressionKind kind, LabelTarget target, Expression value, System.Type type) => default; // 0x00000001896E39C4-0x00000001896E3AA8
		private static void ValidateGoto(LabelTarget target, ref Expression value, string targetParameter, string valueParameter, System.Type type) {} // 0x00000001896E9DF8-0x00000001896E9F78
		private static void ValidateGotoType(System.Type expectedType, ref Expression value, string paramName) {} // 0x00000001896E9CC4-0x00000001896E9DF8
		public static IndexExpression MakeIndex(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) => default; // 0x00000001896E3B64-0x00000001896E3BEC
		public static IndexExpression ArrayAccess(Expression array, params Expression[] indexes) => default; // 0x00000001896D7C1C-0x00000001896D7C78
		public static IndexExpression ArrayAccess(Expression array, IEnumerable<Expression> indexes) => default; // 0x00000001896D7C78-0x00000001896D8130
		public static IndexExpression Property(Expression instance, PropertyInfo indexer, IEnumerable<Expression> arguments) => default; // 0x00000001896E7524-0x00000001896E75BC
		private static IndexExpression MakeIndexProperty(Expression instance, PropertyInfo indexer, string paramName, ReadOnlyCollection<Expression> argList) => default; // 0x00000001896E3AA8-0x00000001896E3B64
		private static void ValidateIndexedProperty(Expression instance, PropertyInfo indexer, string paramName, ref ReadOnlyCollection<Expression> argList) {} // 0x00000001896E9F78-0x00000001896EA4DC
		private static void ValidateAccessor(Expression instance, MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) {} // 0x00000001896E98B0-0x00000001896E9AB4
		private static void ValidateAccessorArgumentTypes(MethodInfo method, ParameterInfo[] indexes, ref ReadOnlyCollection<Expression> arguments, string paramName) {} // 0x00000001896E94B0-0x00000001896E98B0
		internal static InvocationExpression Invoke(Expression expression) => default; // 0x00000001896E0F48-0x00000001896E1034
		internal static InvocationExpression Invoke(Expression expression, Expression arg0) => default; // 0x00000001896E16BC-0x00000001896E1818
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1) => default; // 0x00000001896E1034-0x00000001896E11EC
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2) => default; // 0x00000001896E11EC-0x00000001896E1400
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3) => default; // 0x00000001896E1818-0x00000001896E1A7C
		internal static InvocationExpression Invoke(Expression expression, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) => default; // 0x00000001896E1400-0x00000001896E16BC
		public static InvocationExpression Invoke(Expression expression, IEnumerable<Expression> arguments) => default; // 0x00000001896E0B50-0x00000001896E0F48
		internal static MethodInfo GetInvokeMethod(Expression expression) => default; // 0x00000001896DE140-0x00000001896DE2E0
		public static LabelExpression Label(LabelTarget target) => default; // 0x00000001896E23B0-0x00000001896E23FC
		public static LabelExpression Label(LabelTarget target, Expression defaultValue) => default; // 0x00000001896E22E0-0x00000001896E23B0
		public static LabelTarget Label() => default; // 0x00000001896E23FC-0x00000001896E2474
		public static LabelTarget Label(string name) => default; // 0x00000001896E2258-0x00000001896E22E0
		public static LabelTarget Label(System.Type type) => default; // 0x00000001896E2568-0x00000001896E25B4
		public static LabelTarget Label(System.Type type, string name) => default; // 0x00000001896E2474-0x00000001896E2568
		internal static LambdaExpression CreateLambda(System.Type delegateType, Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) => default; // 0x00000001896DC620-0x00000001896DC9F0
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, params ParameterExpression[] parameters) => default;
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, IEnumerable<ParameterExpression> parameters) => default;
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters) => default;
		public static Expression<TDelegate> Lambda<TDelegate>(Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) => default;
		public static LambdaExpression Lambda(System.Type delegateType, Expression body, params ParameterExpression[] parameters) => default; // 0x00000001896E25B4-0x00000001896E2620
		public static LambdaExpression Lambda(System.Type delegateType, Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters) => default; // 0x00000001896E2620-0x00000001896E26E8
		private static void ValidateLambdaArgs(System.Type delegateType, ref Expression body, ReadOnlyCollection<ParameterExpression> parameters, string paramName) {} // 0x00000001896EA4DC-0x00000001896EAB3C
		public static LoopExpression Loop(Expression body, LabelTarget @break, LabelTarget @continue) => default; // 0x00000001896E2CA0-0x00000001896E2DC0
		public static MemberExpression Field(Expression expression, System.Reflection.FieldInfo field) => default; // 0x00000001896DD7A0-0x00000001896DD994
		public static MemberExpression Field(Expression expression, string fieldName) => default; // 0x00000001896DD61C-0x00000001896DD7A0
		public static MemberExpression Property(Expression expression, string propertyName) => default; // 0x00000001896E738C-0x00000001896E7524
		public static MemberExpression Property(Expression expression, PropertyInfo property) => default; // 0x00000001896E7070-0x00000001896E738C
		public static MemberExpression Property(Expression expression, MethodInfo propertyAccessor) => default; // 0x00000001896E75BC-0x00000001896E7694
		private static PropertyInfo GetProperty(MethodInfo mi, string paramName, int index = -1 /* Metadata: 0x01FCEA48 */) => default; // 0x00000001896DF530-0x00000001896DF704
		private static bool CheckMethod(MethodInfo method, MethodInfo propertyMethod) => default; // 0x00000001896DB580-0x00000001896DB664
		public static MemberExpression MakeMemberAccess(Expression expression, MemberInfo member) => default; // 0x00000001896E3BEC-0x00000001896E3D58
		internal static MethodCallExpression Call(MethodInfo method) => default; // 0x00000001896DA80C-0x00000001896DA904
		public static MethodCallExpression Call(MethodInfo method, Expression arg0) => default; // 0x00000001896DACD4-0x00000001896DAE88
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1) => default; // 0x00000001896DAE88-0x00000001896DB0F0
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) => default; // 0x00000001896D9918-0x00000001896D9C30
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) => default; // 0x00000001896DA904-0x00000001896DACD4
		public static MethodCallExpression Call(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) => default; // 0x00000001896D9EEC-0x00000001896DA354
		public static MethodCallExpression Call(MethodInfo method, params Expression[] arguments) => default; // 0x00000001896DB0F0-0x00000001896DB144
		public static MethodCallExpression Call(MethodInfo method, IEnumerable<Expression> arguments) => default; // 0x00000001896DB52C-0x00000001896DB580
		public static MethodCallExpression Call(Expression instance, MethodInfo method) => default; // 0x00000001896DA6CC-0x00000001896DA80C
		public static MethodCallExpression Call(Expression instance, MethodInfo method, params Expression[] arguments) => default; // 0x00000001896DB144-0x00000001896DB1A4
		internal static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0) => default; // 0x00000001896DB1A4-0x00000001896DB3A8
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1) => default; // 0x00000001896D9C30-0x00000001896D9EEC
		public static MethodCallExpression Call(Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2) => default; // 0x00000001896DA354-0x00000001896DA6CC
		public static MethodCallExpression Call(Expression instance, string methodName, System.Type[] typeArguments, params Expression[] arguments) => default; // 0x00000001896DB3A8-0x00000001896DB52C
		public static MethodCallExpression Call(Expression instance, MethodInfo method, IEnumerable<Expression> arguments) => default; // 0x00000001896D9488-0x00000001896D9918
		private static ParameterInfo[] ValidateMethodAndGetParameters(Expression instance, MethodInfo method) => default; // 0x00000001896EAB3C-0x00000001896EABBC
		private static void ValidateStaticOrInstanceMethod(Expression instance, MethodInfo method) {} // 0x00000001896EB0C0-0x00000001896EB1A8
		private static void ValidateCallInstanceType(System.Type instanceType, MethodInfo method) {} // 0x00000001896E9AD4-0x00000001896E9B70
		private static void ValidateArgumentTypes(MethodBase method, ExpressionType nodeKind, ref ReadOnlyCollection<Expression> arguments, string methodParamName) {} // 0x00000001896E9AC4-0x00000001896E9AD4
		private static ParameterInfo[] GetParametersForValidation(MethodBase method, ExpressionType nodeKind) => default; // 0x00000001896DF528-0x00000001896DF530
		private static void ValidateArgumentCount(MethodBase method, ExpressionType nodeKind, int count, ParameterInfo[] pis) {} // 0x00000001896E9AB4-0x00000001896E9AC4
		private static Expression ValidateOneArgument(MethodBase method, ExpressionType nodeKind, Expression arg, ParameterInfo pi, string methodParamName, string argumentParamName) => default; // 0x00000001896EAC34-0x00000001896EAC68
		private static bool TryQuote(System.Type parameterType, ref Expression argument) => default; // 0x00000001896E8D68-0x00000001896E8D70
		private static MethodInfo FindMethod(System.Type type, string methodName, System.Type[] typeArgs, Expression[] args, System.Reflection.BindingFlags flags) => default; // 0x00000001896DD994-0x00000001896DDBC4
		private static bool IsCompatible(MethodBase m, Expression[] arguments) => default; // 0x00000001896E1A7C-0x00000001896E1C98
		private static MethodInfo ApplyTypeArgs(MethodInfo m, System.Type[] typeArgs) => default; // 0x00000001896D7B8C-0x00000001896D7C1C
		public static NewArrayExpression NewArrayInit(System.Type type, params Expression[] initializers) => default; // 0x00000001896E5BA0-0x00000001896E5BFC
		public static NewArrayExpression NewArrayInit(System.Type type, IEnumerable<Expression> initializers) => default; // 0x00000001896E57C0-0x00000001896E5BA0
		public static NewArrayExpression NewArrayBounds(System.Type type, IEnumerable<Expression> bounds) => default; // 0x00000001896E54D0-0x00000001896E57C0
		public static ParameterExpression Parameter(System.Type type) => default; // 0x00000001896E6954-0x00000001896E69A0
		public static ParameterExpression Parameter(System.Type type, string name) => default; // 0x00000001896E69A0-0x00000001896E6A38
		public static ParameterExpression Variable(System.Type type, string name) => default; // 0x00000001896EC030-0x00000001896EC090
		private static void Validate(System.Type type, bool allowByRef) {} // 0x00000001896EBF08-0x00000001896EC030
		public static TryExpression TryFinally(Expression body, Expression @finally) => default; // 0x00000001896E8D08-0x00000001896E8D68
		public static TryExpression MakeTry(System.Type type, Expression body, Expression @finally, Expression fault, IEnumerable<CatchBlock> handlers) => default; // 0x00000001896E3F9C-0x00000001896E41C8
		private static void ValidateTryAndCatchHaveSameType(System.Type type, Expression tryBody, ReadOnlyCollection<CatchBlock> handlers) {} // 0x00000001896EB1A8-0x00000001896EB6DC
		public static TypeBinaryExpression TypeIs(Expression expression, System.Type type) => default; // 0x00000001896E9020-0x00000001896E9150
		public static TypeBinaryExpression TypeEqual(Expression expression, System.Type type) => default; // 0x00000001896E8EF0-0x00000001896E9020
		public static UnaryExpression MakeUnary(ExpressionType unaryType, Expression operand, System.Type type, MethodInfo method) => default; // 0x00000001896E41C8-0x00000001896E4598
		private static UnaryExpression GetUserDefinedUnaryOperatorOrThrow(ExpressionType unaryType, string name, Expression operand) => default; // 0x00000001896E02E8-0x00000001896E0444
		private static UnaryExpression GetUserDefinedUnaryOperator(ExpressionType unaryType, string name, Expression operand) => default; // 0x00000001896E0444-0x00000001896E06A4
		private static UnaryExpression GetMethodBasedUnaryOperator(ExpressionType unaryType, Expression operand, MethodInfo method) => default; // 0x00000001896DEDB4-0x00000001896DF108
		private static UnaryExpression GetUserDefinedCoercionOrThrow(ExpressionType coercionType, Expression expression, System.Type convertToType) => default; // 0x00000001896E0158-0x00000001896E0200
		private static UnaryExpression GetUserDefinedCoercion(ExpressionType coercionType, Expression expression, System.Type convertToType) => default; // 0x00000001896E0200-0x00000001896E02E8
		private static UnaryExpression GetMethodBasedCoercionOperator(ExpressionType unaryType, Expression operand, System.Type convertToType, MethodInfo method) => default; // 0x00000001896DEA64-0x00000001896DEDB4
		public static UnaryExpression Negate(Expression expression, MethodInfo method) => default; // 0x00000001896E5358-0x00000001896E54D0
		public static UnaryExpression UnaryPlus(Expression expression, MethodInfo method) => default; // 0x00000001896E9150-0x00000001896E929C
		public static UnaryExpression NegateChecked(Expression expression, MethodInfo method) => default; // 0x00000001896E51E0-0x00000001896E5358
		public static UnaryExpression Not(Expression expression) => default; // 0x00000001896E5D34-0x00000001896E5D80
		public static UnaryExpression Not(Expression expression, MethodInfo method) => default; // 0x00000001896E5D80-0x00000001896E5F04
		public static UnaryExpression IsFalse(Expression expression, MethodInfo method) => default; // 0x00000001896E1C98-0x00000001896E1DE4
		public static UnaryExpression IsTrue(Expression expression, MethodInfo method) => default; // 0x00000001896E2044-0x00000001896E2190
		public static UnaryExpression OnesComplement(Expression expression, MethodInfo method) => default; // 0x00000001896E5F04-0x00000001896E6050
		public static UnaryExpression TypeAs(Expression expression, System.Type type) => default; // 0x00000001896E8D70-0x00000001896E8EF0
		public static UnaryExpression Unbox(Expression expression, System.Type type) => default; // 0x00000001896E929C-0x00000001896E94B0
		public static UnaryExpression Convert(Expression expression, System.Type type) => default; // 0x00000001896DC5CC-0x00000001896DC620
		public static UnaryExpression Convert(Expression expression, System.Type type, MethodInfo method) => default; // 0x00000001896DC3E0-0x00000001896DC5CC
		public static UnaryExpression ConvertChecked(Expression expression, System.Type type, MethodInfo method) => default; // 0x00000001896DC1D8-0x00000001896DC3E0
		public static UnaryExpression ArrayLength(Expression array) => default; // 0x00000001896D8328-0x00000001896D8508
		public static UnaryExpression Quote(Expression expression) => default; // 0x00000001896E7694-0x00000001896E7790
		public static UnaryExpression Throw(Expression value, System.Type type) => default; // 0x00000001896E8B84-0x00000001896E8D00
		public static UnaryExpression Increment(Expression expression, MethodInfo method) => default; // 0x00000001896E0A04-0x00000001896E0B50
		public static UnaryExpression Decrement(Expression expression, MethodInfo method) => default; // 0x00000001896DC9F0-0x00000001896DCB3C
		public static UnaryExpression PreIncrementAssign(Expression expression) => default; // 0x00000001896E701C-0x00000001896E7070
		public static UnaryExpression PreIncrementAssign(Expression expression, MethodInfo method) => default; // 0x00000001896E6FC8-0x00000001896E701C
		public static UnaryExpression PreDecrementAssign(Expression expression, MethodInfo method) => default; // 0x00000001896E6F74-0x00000001896E6FC8
		public static UnaryExpression PostIncrementAssign(Expression expression, MethodInfo method) => default; // 0x00000001896E6A8C-0x00000001896E6AE0
		public static UnaryExpression PostDecrementAssign(Expression expression, MethodInfo method) => default; // 0x00000001896E6A38-0x00000001896E6A8C
		private static UnaryExpression MakeOpAssignUnary(ExpressionType kind, Expression expression, MethodInfo method) => default; // 0x00000001896E3D58-0x00000001896E3F9C
	}

	[DebuggerTypeProxy(typeof(BlockExpressionProxy))]
	public class BlockExpression : Expression // TypeDefIndex: 50719
	{
		// Properties
		public ReadOnlyCollection<Expression> Expressions { get => default; } // 0x00000001896EFED4-0x00000001896EFF04 
		public ReadOnlyCollection<ParameterExpression> Variables { get => default; } // 0x00000001896EFF48-0x00000001896EFF78 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D56180-0x0000000183D56190 
		public override System.Type Type { get => default; } // 0x00000001896EFF04-0x00000001896EFF48 
		[ExcludeFromCodeCoverage]
		internal virtual int ExpressionCount { get => default; } // 0x00000001896EFEAC-0x00000001896EFED4 
	
		// Constructors
		internal BlockExpression() {} // 0x00000001896EFE6C-0x00000001896EFEAC
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896EFC64-0x00000001896EFCAC
		[ExcludeFromCodeCoverage]
		internal virtual Expression GetExpression(int index) => default; // 0x00000001896EFCAC-0x00000001896EFCD4
		[ExcludeFromCodeCoverage]
		internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EFCD4-0x00000001896EFCFC
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() => default; // 0x00000001896EFCFC-0x00000001896EFD4C
		[ExcludeFromCodeCoverage]
		internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896EFE44-0x00000001896EFE6C
		internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) => default; // 0x00000001896EFD4C-0x00000001896EFE44
	}

	internal sealed class Block2 : BlockExpression // TypeDefIndex: 50720
	{
		// Fields
		private object _arg0; // 0x10
		private readonly Expression _arg1; // 0x18
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public Block2() {} // Dummy constructor
		internal Block2(Expression arg0, Expression arg1) {} // 0x00000001896EF2AC-0x00000001896EF2F4
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001896EF18C-0x00000001896EF214
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EF214-0x00000001896EF220
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896EF220-0x00000001896EF2AC
	}

	internal sealed class Block3 : BlockExpression // TypeDefIndex: 50721
	{
		// Fields
		private object _arg0; // 0x10
		private readonly Expression _arg1; // 0x18
		private readonly Expression _arg2; // 0x20
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public Block3() {} // Dummy constructor
		internal Block3(Expression arg0, Expression arg1, Expression arg2) {} // 0x00000001896EF430-0x00000001896EF494
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001896EF2F4-0x00000001896EF388
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EF214-0x00000001896EF220
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896EF388-0x00000001896EF430
	}

	internal sealed class Block4 : BlockExpression // TypeDefIndex: 50722
	{
		// Fields
		private object _arg0; // 0x10
		private readonly Expression _arg1; // 0x18
		private readonly Expression _arg2; // 0x20
		private readonly Expression _arg3; // 0x28
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public Block4() {} // Dummy constructor
		internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3) {} // 0x00000001896EF5F0-0x00000001896EF664
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001896EF494-0x00000001896EF530
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EF214-0x00000001896EF220
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896EF530-0x00000001896EF5F0
	}

	internal sealed class Block5 : BlockExpression // TypeDefIndex: 50723
	{
		// Fields
		private object _arg0; // 0x10
		private readonly Expression _arg1; // 0x18
		private readonly Expression _arg2; // 0x20
		private readonly Expression _arg3; // 0x28
		private readonly Expression _arg4; // 0x30
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public Block5() {} // Dummy constructor
		internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) {} // 0x00000001896EF7DC-0x00000001896EF864
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001896EF664-0x00000001896EF70C
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EF214-0x00000001896EF220
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896EF70C-0x00000001896EF7DC
	}

	internal class BlockN : BlockExpression // TypeDefIndex: 50724
	{
		// Fields
		private IReadOnlyList<Expression> _expressions; // 0x10
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x00000001896F0098-0x00000001896F00E0 
	
		// Constructors
		public BlockN() {} // Dummy constructor
		internal BlockN(IReadOnlyList<Expression> expressions) {} // 0x00000001896F0068-0x00000001896F0098
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001896EFF78-0x00000001896EFFCC
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x00000001896EFFCC-0x00000001896F0008
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x00000001896F0008-0x00000001896F0068
	}

	internal class ScopeExpression : BlockExpression // TypeDefIndex: 50725
	{
		// Fields
		private IReadOnlyList<ParameterExpression> _variables; // 0x10
	
		// Properties
		protected IReadOnlyList<ParameterExpression> VariablesList { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public ScopeExpression() {} // Dummy constructor
		internal ScopeExpression(IReadOnlyList<ParameterExpression> variables) {} // 0x00000001896F0068-0x00000001896F0098
	
		// Methods
		internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() => default; // 0x0000000189701988-0x00000001897019C4
		internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) => default; // 0x00000001897019C4-0x0000000189701A3C
	}

	internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 50726
	{
		// Fields
		private object _body; // 0x18
	
		// Properties
		internal override int ExpressionCount { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public Scope1() {} // Dummy constructor
		internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body) {} // 0x0000000189701950-0x0000000189701958
		private Scope1(IReadOnlyList<ParameterExpression> variables, object body) {} // 0x0000000189701958-0x0000000189701988
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x00000001897017D8-0x0000000189701854
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x0000000189701854-0x0000000189701860
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x0000000189701860-0x0000000189701950
	}

	internal class ScopeN : ScopeExpression // TypeDefIndex: 50727
	{
		// Fields
		private IReadOnlyList<Expression> _body; // 0x18
	
		// Properties
		protected IReadOnlyList<Expression> Body { get => default; } // 0x0000000181041090-0x00000001810410A0 
		internal override int ExpressionCount { get => default; } // 0x0000000189701BB8-0x0000000189701C00 
	
		// Constructors
		public ScopeN() {} // Dummy constructor
		internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) {} // 0x0000000189701958-0x0000000189701988
	
		// Methods
		internal override Expression GetExpression(int index) => default; // 0x0000000189701A3C-0x0000000189701A90
		internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() => default; // 0x0000000189701A90-0x0000000189701ACC
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x0000000189701ACC-0x0000000189701BB8
	}

	internal sealed class ScopeWithType : ScopeN // TypeDefIndex: 50728
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public ScopeWithType() {} // Dummy constructor
		internal ScopeWithType(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> expressions, System.Type type) {} // 0x0000000189701D24-0x0000000189701D54
	
		// Methods
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) => default; // 0x0000000189701C00-0x0000000189701D24
	}

	internal class BlockExpressionList : IList<Expression> // TypeDefIndex: 50730
	{
		// Fields
		private readonly BlockExpression _block; // 0x10
		private readonly Expression _arg0; // 0x18
	
		// Properties
		public Expression this[int index] { get => default; [ExcludeFromCodeCoverage] set {} } // 0x00000001896EFC0C-0x00000001896EFC3C 0x00000001896EFC3C-0x00000001896EFC64
		public int Count { get => default; } // 0x00000001892EFB48-0x00000001892EFB6C 
		[ExcludeFromCodeCoverage]
		public bool IsReadOnly { get => default; } // 0x00000001896EFBE4-0x00000001896EFC0C 
	
		// Constructors
		public BlockExpressionList() {} // Dummy constructor
		internal BlockExpressionList(BlockExpression provider, Expression arg0) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public int IndexOf(Expression item) => default; // 0x00000001896EFAEC-0x00000001896EFB64
		[ExcludeFromCodeCoverage]
		public void Insert(int index, Expression item) {} // 0x00000001896EFB64-0x00000001896EFB8C
		[ExcludeFromCodeCoverage]
		public void RemoveAt(int index) {} // 0x00000001896EFB8C-0x00000001896EFBB4
		[ExcludeFromCodeCoverage]
		public void Add(Expression item) {} // 0x00000001896EF864-0x00000001896EF88C
		[ExcludeFromCodeCoverage]
		public void Clear() {} // 0x00000001896EF88C-0x00000001896EF8B4
		public bool Contains(Expression item) => default; // 0x00000001896EF8B4-0x00000001896EF8CC
		public void CopyTo(Expression[] array, int index) {} // 0x00000001896EF8CC-0x00000001896EFA90
		[ExcludeFromCodeCoverage]
		public bool Remove(Expression item) => default; // 0x00000001896EFBB4-0x00000001896EFBDC
		[IteratorStateMachine(typeof(_GetEnumerator_d__18))]
		public IEnumerator<Expression> GetEnumerator() => default; // 0x00000001896EFA90-0x00000001896EFAEC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001896EFBDC-0x00000001896EFBE4
	}

	[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
	public sealed class CatchBlock // TypeDefIndex: 50731
	{
		// Properties
		public ParameterExpression Variable { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Type Test { get; } // 0x0000000181041090-0x00000001810410A0 
		public Expression Body { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Expression Filter { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public CatchBlock() {} // Dummy constructor
		internal CatchBlock(System.Type test, ParameterExpression variable, Expression body, Expression filter) {} // 0x00000001896F1600-0x00000001896F1648
	
		// Methods
		public override string ToString() => default; // 0x00000001896F1568-0x00000001896F1570
		public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) => default; // 0x00000001896F1570-0x00000001896F1600
	}

	internal static class ArrayBuilderExtensions // TypeDefIndex: 50732
	{
		// Extension methods
		public static ReadOnlyCollection<T> ToReadOnly<T>(this ArrayBuilder<T> builder) => default;
	}

	internal enum AnalyzeTypeIsResult // TypeDefIndex: 50733
	{
		KnownFalse = 0,
		KnownTrue = 1,
		KnownAssignable = 2,
		Unknown = 3
	}

	internal static class ConstantCheck // TypeDefIndex: 50734
	{
		// Methods
		internal static AnalyzeTypeIsResult AnalyzeTypeIs(TypeBinaryExpression typeIs) => default; // 0x00000001896F1AA4-0x00000001896F1AC8
		private static AnalyzeTypeIsResult AnalyzeTypeIs(Expression operand, System.Type testType) => default; // 0x00000001896F1AC8-0x00000001896F1C48
	}

	[DebuggerTypeProxy(typeof(ConditionalExpressionProxy))]
	public class ConditionalExpression : Expression // TypeDefIndex: 50735
	{
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public override System.Type Type { get => default; } // 0x00000001896D43A4-0x00000001896D43C8 
		public Expression Test { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Expression IfTrue { get; } // 0x0000000181041090-0x00000001810410A0 
		public Expression IfFalse { get => default; } // 0x0000000189489BB0-0x0000000189489BC0 
	
		// Constructors
		public ConditionalExpression() {} // Dummy constructor
		internal ConditionalExpression(Expression test, Expression ifTrue) {} // 0x00000001896F1A38-0x00000001896F1AA4
	
		// Methods
		internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, System.Type type) => default; // 0x00000001896F17D0-0x00000001896F1994
		internal virtual Expression GetFalse() => default; // 0x00000001896F177C-0x00000001896F17D0
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896F1734-0x00000001896F177C
		public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) => default; // 0x00000001896F1994-0x00000001896F1A38
	}

	internal class FullConditionalExpression : ConditionalExpression // TypeDefIndex: 50736
	{
		// Fields
		private readonly Expression _false; // 0x20
	
		// Constructors
		public FullConditionalExpression() {} // Dummy constructor
		internal FullConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse) {} // 0x00000001896FD0D8-0x00000001896FD108
	
		// Methods
		internal override Expression GetFalse() => default; // 0x0000000183D4EB40-0x0000000183D4EB50
	}

	internal sealed class FullConditionalExpressionWithType : FullConditionalExpression // TypeDefIndex: 50737
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public FullConditionalExpressionWithType() {} // Dummy constructor
		internal FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, System.Type type) {} // 0x00000001896FD0A8-0x00000001896FD0D8
	}

	[DebuggerTypeProxy(typeof(ConstantExpressionProxy))]
	public class ConstantExpression : Expression // TypeDefIndex: 50738
	{
		// Properties
		public override System.Type Type { get => default; } // 0x00000001896F1CE8-0x00000001896F1D54 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55810-0x0000000183D55820 
		public object Value { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public ConstantExpression() {} // Dummy constructor
		internal ConstantExpression(object value) {} // 0x00000001896F1C90-0x00000001896F1CE8
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896F1C48-0x00000001896F1C90
	}

	internal class TypedConstantExpression : ConstantExpression // TypeDefIndex: 50739
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public TypedConstantExpression() {} // Dummy constructor
		internal TypedConstantExpression(object value, System.Type type) {} // 0x000000018970426C-0x000000018970429C
	}

	[DebuggerTypeProxy(typeof(DebugInfoExpressionProxy))]
	public class DebugInfoExpression : Expression // TypeDefIndex: 50740
	{
		// Properties
		[ExcludeFromCodeCoverage]
		public virtual int StartLine { get => default; } // 0x00000001896F1E50-0x00000001896F1E78 
		[ExcludeFromCodeCoverage]
		public virtual int EndLine { get => default; } // 0x00000001896F1E00-0x00000001896F1E28 
		public SymbolDocumentInfo Document { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		[ExcludeFromCodeCoverage]
		public virtual bool IsClear { get => default; } // 0x00000001896F1E28-0x00000001896F1E50 
	
		// Constructors
		public DebugInfoExpression() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(DefaultExpressionProxy))]
	public sealed class DefaultExpression : Expression // TypeDefIndex: 50741
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D56190-0x0000000183D561A0 
	
		// Constructors
		public DefaultExpression() {} // Dummy constructor
		internal DefaultExpression(System.Type type) {} // 0x00000001896F275C-0x00000001896F27B4
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896F2714-0x00000001896F275C
	}

	public sealed class ElementInit : IArgumentProvider // TypeDefIndex: 50742
	{
		// Properties
		public MethodInfo AddMethod { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ReadOnlyCollection<Expression> Arguments { get; } // 0x0000000181041090-0x00000001810410A0 
		public int ArgumentCount { get => default; } // 0x00000001896F35AC-0x00000001896F35F4 
	
		// Constructors
		public ElementInit() {} // Dummy constructor
	
		// Methods
		public Expression GetArgument(int index) => default; // 0x00000001896F3558-0x00000001896F35AC
	}

	internal static class Error // TypeDefIndex: 50743
	{
		// Methods
		internal static Exception ReducibleMustOverrideReduce() => default; // 0x00000001896F9340-0x00000001896F93A8
		internal static Exception InvalidMetaObjectCreated(object p0) => default; // 0x00000001896F7FDC-0x00000001896F8048
		internal static Exception AmbiguousMatchInExpandoObject(object p0) => default; // 0x00000001896F63B0-0x00000001896F641C
		internal static Exception SameKeyExistsInExpando(object key) => default; // 0x00000001896F9484-0x00000001896F9504
		internal static Exception KeyDoesNotExistInExpando(object p0) => default; // 0x00000001896F8238-0x00000001896F82A4
		internal static Exception CollectionModifiedWhileEnumerating() => default; // 0x00000001896F6C58-0x00000001896F6CC0
		internal static Exception CollectionReadOnly() => default; // 0x00000001896F6CC0-0x00000001896F6D28
		internal static Exception MustReduceToDifferent() => default; // 0x00000001896F88DC-0x00000001896F8944
		internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2) => default; // 0x00000001896F68CC-0x00000001896F6950
		internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1) => default; // 0x00000001896F7060-0x00000001896F70D4
		internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) => default; // 0x00000001896F70D4-0x00000001896F716C
		internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2) => default; // 0x00000001896F6FDC-0x00000001896F7060
		internal static Exception BindingCannotBeNull() => default; // 0x00000001896F6950-0x00000001896F69B8
		internal static Exception ReducedNotCompatible() => default; // 0x00000001896F92D8-0x00000001896F9340
		internal static Exception SetterHasNoParams(string paramName) => default; // 0x00000001896F9504-0x00000001896F957C
		internal static Exception PropertyCannotHaveRefType(string paramName) => default; // 0x00000001896F8F80-0x00000001896F8FF8
		internal static Exception IndexesOfSetGetMustMatch(string paramName) => default; // 0x00000001896F7CE4-0x00000001896F7D5C
		internal static Exception TypeParameterIsNotDelegate(object p0) => default; // 0x00000001896F990C-0x00000001896F9978
		internal static Exception FirstArgumentMustBeCallSite() => default; // 0x00000001896F78F8-0x00000001896F7960
		internal static Exception AccessorsCannotHaveVarArgs(string paramName) => default; // 0x00000001896F62CC-0x00000001896F6344
		private static Exception AccessorsCannotHaveByRefArgs(string paramName) => default; // 0x00000001896F6254-0x00000001896F62CC
		internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index) => default; // 0x00000001896F6238-0x00000001896F6254
		internal static Exception TypeMustBeDerivedFromSystemDelegate() => default; // 0x00000001896F97B4-0x00000001896F981C
		internal static Exception NoOrInvalidRuleProduced() => default; // 0x00000001896F8AC0-0x00000001896F8B28
		internal static Exception BoundsCannotBeLessThanOne(string paramName) => default; // 0x00000001896F6A98-0x00000001896F6B10
		internal static Exception TypeMustNotBeByRef(string paramName) => default; // 0x00000001896F981C-0x00000001896F9894
		internal static Exception TypeMustNotBePointer(string paramName) => default; // 0x00000001896F9894-0x00000001896F990C
		internal static Exception SetterMustBeVoid(string paramName) => default; // 0x00000001896F957C-0x00000001896F95F4
		internal static Exception PropertyTypeMustMatchGetter(string paramName) => default; // 0x00000001896F9170-0x00000001896F91E8
		internal static Exception PropertyTypeMustMatchSetter(string paramName) => default; // 0x00000001896F91E8-0x00000001896F9260
		internal static Exception BothAccessorsMustBeStatic(string paramName) => default; // 0x00000001896F6A20-0x00000001896F6A98
		internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName) => default; // 0x00000001896F8C4C-0x00000001896F8CC4
		internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName) => default; // 0x00000001896F8D2C-0x00000001896F8DA4
		internal static Exception OnlyStaticMethodsHaveNullInstance() => default; // 0x00000001896F8CC4-0x00000001896F8D2C
		internal static Exception PropertyTypeCannotBeVoid(string paramName) => default; // 0x00000001896F90F8-0x00000001896F9170
		internal static Exception InvalidUnboxType(string paramName) => default; // 0x00000001896F81C0-0x00000001896F8238
		internal static Exception ExpressionMustBeWriteable(string paramName) => default; // 0x00000001896F7268-0x00000001896F72E0
		internal static Exception ArgumentMustNotHaveValueType(string paramName) => default; // 0x00000001896F6708-0x00000001896F6780
		internal static Exception MustBeReducible() => default; // 0x00000001896F8874-0x00000001896F88DC
		internal static Exception LabelMustBeVoidOrHaveExpression(string paramName) => default; // 0x00000001896F82A4-0x00000001896F831C
		internal static Exception LabelTypeMustBeVoid(string paramName) => default; // 0x00000001896F83F4-0x00000001896F846C
		internal static Exception QuotedExpressionMustBeLambda(string paramName) => default; // 0x00000001896F9260-0x00000001896F92D8
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName) => default; // 0x00000001896F9D00-0x00000001896F9D84
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index) => default; // 0x00000001896F9CC4-0x00000001896F9D00
		private static Exception DuplicateVariable(object p0, string paramName) => default; // 0x00000001896F6F30-0x00000001896F6FAC
		internal static Exception DuplicateVariable(object p0, string paramName, int index) => default; // 0x00000001896F6FAC-0x00000001896F6FDC
		internal static Exception FaultCannotHaveCatchOrFinally(string paramName) => default; // 0x00000001896F77FC-0x00000001896F7874
		internal static Exception TryMustHaveCatchFinallyOrFault() => default; // 0x00000001896F95F4-0x00000001896F965C
		internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry() => default; // 0x00000001896F69B8-0x00000001896F6A20
		internal static Exception ExtensionNodeMustOverrideProperty(object p0) => default; // 0x00000001896F7790-0x00000001896F77FC
		internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName) => default; // 0x00000001896F9BCC-0x00000001896F9C48
		internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName) => default; // 0x00000001896F9C48-0x00000001896F9CC4
		internal static Exception CoercionOperatorNotDefined(object p0, object p1) => default; // 0x00000001896F6BE4-0x00000001896F6C58
		internal static Exception UnaryOperatorNotDefined(object p0, object p1) => default; // 0x00000001896F9978-0x00000001896F99EC
		internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2) => default; // 0x00000001896F6848-0x00000001896F68CC
		internal static Exception ReferenceEqualityNotDefined(object p0, object p1) => default; // 0x00000001896F93A8-0x00000001896F941C
		internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1) => default; // 0x00000001896F8DA4-0x00000001896F8E18
		internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) => default; // 0x00000001896F8E98-0x00000001896F8F0C
		internal static Exception ConversionIsNotSupportedForArithmeticTypes() => default; // 0x00000001896F6EC8-0x00000001896F6F30
		internal static Exception ArgumentMustBeArray(string paramName) => default; // 0x00000001896F650C-0x00000001896F6584
		internal static Exception ArgumentMustBeBoolean(string paramName) => default; // 0x00000001896F6584-0x00000001896F65FC
		private static Exception ArgumentMustBeInteger(string paramName) => default; // 0x00000001896F65FC-0x00000001896F6674
		internal static Exception ArgumentMustBeInteger(string paramName, int index) => default; // 0x00000001896F6674-0x00000001896F6690
		internal static Exception ArgumentMustBeArrayIndexType(string paramName) => default; // 0x00000001896F6494-0x00000001896F650C
		internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName) => default; // 0x00000001896F6690-0x00000001896F6708
		internal static Exception ArgumentTypesMustMatch() => default; // 0x00000001896F67E0-0x00000001896F6848
		internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0) => default; // 0x00000001896F6B10-0x00000001896F6B7C
		internal static Exception IncorrectTypeForTypeAs(object p0, string paramName) => default; // 0x00000001896F7C68-0x00000001896F7CE4
		internal static Exception CoalesceUsedOnNonNullType() => default; // 0x00000001896F6B7C-0x00000001896F6BE4
		internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1) => default; // 0x00000001896F72E0-0x00000001896F7354
		internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1) => default; // 0x00000001896F76A0-0x00000001896F7714
		internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1) => default; // 0x00000001896F7354-0x00000001896F73C8
		internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1) => default; // 0x00000001896F7488-0x00000001896F74FC
		internal static Exception ExpressionTypeNotInvocable(object p0, string paramName) => default; // 0x00000001896F7714-0x00000001896F7790
		internal static Exception InstanceFieldNotDefinedForType(object p0, object p1) => default; // 0x00000001896F7DE0-0x00000001896F7E54
		internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2) => default; // 0x00000001896F7874-0x00000001896F78F8
		internal static Exception IncorrectNumberOfIndexes() => default; // 0x00000001896F7AB4-0x00000001896F7B1C
		internal static Exception IncorrectNumberOfLambdaDeclarationParameters() => default; // 0x00000001896F7B84-0x00000001896F7BEC
		internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName) => default; // 0x00000001896F846C-0x00000001896F84E4
		internal static Exception MemberNotFieldOrProperty(object p0, string paramName) => default; // 0x00000001896F8558-0x00000001896F85D4
		internal static Exception MethodContainsGenericParameters(object p0, string paramName) => default; // 0x00000001896F85D4-0x00000001896F8650
		internal static Exception MethodIsGeneric(object p0, string paramName) => default; // 0x00000001896F8650-0x00000001896F86CC
		private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName) => default; // 0x00000001896F86CC-0x00000001896F8750
		internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index) => default; // 0x00000001896F8750-0x00000001896F878C
		internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName) => default; // 0x00000001896F8FF8-0x00000001896F9074
		internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1) => default; // 0x00000001896F8F0C-0x00000001896F8F80
		internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName) => default; // 0x00000001896F9074-0x00000001896F90F8
		internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName) => default; // 0x00000001896F7E54-0x00000001896F7ED8
		internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2) => default; // 0x00000001896F7D5C-0x00000001896F7DE0
		internal static Exception UnhandledBinary(object p0, string paramName) => default; // 0x00000001896F99EC-0x00000001896F9A68
		internal static Exception UnhandledUnary(object p0, string paramName) => default; // 0x00000001896F9A68-0x00000001896F9AE4
		internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1) => default; // 0x00000001896F9AE4-0x00000001896F9B58
		internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1) => default; // 0x00000001896F9B58-0x00000001896F9BCC
		internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1) => default; // 0x00000001896F84E4-0x00000001896F8558
		internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1) => default; // 0x00000001896F878C-0x00000001896F8800
		internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) => default; // 0x00000001896F7960-0x00000001896F79D4
		internal static Exception MethodWithMoreThanOneMatch(object p0, object p1) => default; // 0x00000001896F8800-0x00000001896F8874
		internal static Exception ArgumentCannotBeOfTypeVoid(string paramName) => default; // 0x00000001896F641C-0x00000001896F6494
		internal static Exception OutOfRange(string paramName, object p1) => default; // 0x00000001896F8E18-0x00000001896F8E98
		internal static Exception LabelTargetAlreadyDefined(object p0) => default; // 0x00000001896F831C-0x00000001896F8388
		internal static Exception LabelTargetUndefined(object p0) => default; // 0x00000001896F8388-0x00000001896F83F4
		internal static Exception ControlCannotLeaveFinally() => default; // 0x00000001896F6E60-0x00000001896F6EC8
		internal static Exception ControlCannotLeaveFilterTest() => default; // 0x00000001896F6DF8-0x00000001896F6E60
		internal static Exception AmbiguousJump(object p0) => default; // 0x00000001896F6344-0x00000001896F63B0
		internal static Exception ControlCannotEnterTry() => default; // 0x00000001896F6D90-0x00000001896F6DF8
		internal static Exception ControlCannotEnterExpression() => default; // 0x00000001896F6D28-0x00000001896F6D90
		internal static Exception NonLocalJumpWithValue(object p0) => default; // 0x00000001896F8B90-0x00000001896F8BFC
		internal static Exception InvalidLvalue(ExpressionType p0) => default; // 0x00000001896F7F50-0x00000001896F7FDC
		internal static Exception RethrowRequiresCatch() => default; // 0x00000001896F941C-0x00000001896F9484
		internal static Exception MustRewriteToSameNode(object p0, object p1, object p2) => default; // 0x00000001896F89C8-0x00000001896F8A4C
		internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2) => default; // 0x00000001896F8944-0x00000001896F89C8
		internal static Exception MustRewriteWithoutMethod(object p0, object p1) => default; // 0x00000001896F8A4C-0x00000001896F8AC0
		internal static Exception ArgumentOutOfRange(string paramName) => default; // 0x00000001896F6780-0x00000001896F67E0
		internal static Exception NotSupported() => default; // 0x00000001896F8BFC-0x00000001896F8C4C
		internal static Exception NonAbstractConstructorRequired() => default; // 0x00000001896F8B28-0x00000001896F8B90
		internal static Exception InvalidProgram() => default; // 0x00000001896F80C4-0x00000001896F8114
		internal static Exception EnumerationIsDone() => default; // 0x00000001896F716C-0x00000001896F71D4
		private static Exception TypeContainsGenericParameters(object p0, string paramName) => default; // 0x00000001896F968C-0x00000001896F9708
		internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index) => default; // 0x00000001896F965C-0x00000001896F968C
		internal static Exception TypeIsGeneric(object p0, string paramName) => default; // 0x00000001896F9708-0x00000001896F9784
		internal static Exception TypeIsGeneric(object p0, string paramName, int index) => default; // 0x00000001896F9784-0x00000001896F97B4
		internal static Exception IncorrectNumberOfConstructorArguments() => default; // 0x00000001896F7A4C-0x00000001896F7AB4
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName) => default; // 0x00000001896F74FC-0x00000001896F7590
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index) => default; // 0x00000001896F7590-0x00000001896F75E0
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName) => default; // 0x00000001896F761C-0x00000001896F76A0
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index) => default; // 0x00000001896F75E0-0x00000001896F761C
		internal static Exception IncorrectNumberOfLambdaArguments() => default; // 0x00000001896F7B1C-0x00000001896F7B84
		internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName) => default; // 0x00000001896F7BEC-0x00000001896F7C68
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName) => default; // 0x00000001896F73C8-0x00000001896F744C
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index) => default; // 0x00000001896F744C-0x00000001896F7488
		internal static Exception ExpressionMustBeReadable(string paramName) => default; // 0x00000001896F71D4-0x00000001896F724C
		internal static Exception ExpressionMustBeReadable(string paramName, int index) => default; // 0x00000001896F724C-0x00000001896F7268
		internal static Exception InvalidArgumentValue(string paramName) => default; // 0x00000001896F7ED8-0x00000001896F7F50
		internal static Exception InvalidNullValue(System.Type type, string paramName) => default; // 0x00000001896F8048-0x00000001896F80C4
		internal static Exception InvalidTypeException(object value, System.Type type, string paramName) => default; // 0x00000001896F8114-0x00000001896F81C0
		private static string GetParamName(string paramName, int index) => default; // 0x00000001896F79D4-0x00000001896F7A4C
	}

	internal sealed class ExpressionStringBuilder : ExpressionVisitor // TypeDefIndex: 50744
	{
		// Fields
		private readonly StringBuilder _out; // 0x10
		private Dictionary<object, int> _ids; // 0x18
	
		// Constructors
		private ExpressionStringBuilder() {} // 0x00000001896FC344-0x00000001896FC3A8
	
		// Methods
		public override string ToString() => default; // 0x0000000187ABAEF4-0x0000000187ABAF18
		private int GetLabelId(LabelTarget label) => default; // 0x00000001896FA7A0-0x00000001896FA7A8
		private int GetParamId(ParameterExpression p) => default; // 0x00000001896FA7A0-0x00000001896FA7A8
		private int GetId(object o) => default; // 0x00000001896FA698-0x00000001896FA7A0
		private void Out(string s) {} // 0x00000001896FA904-0x00000001896FA924
		private void Out(char c) {} // 0x00000001896FA924-0x00000001896FA944
		internal static string ExpressionToString(Expression node) => default; // 0x00000001896FA624-0x00000001896FA698
		internal static string CatchBlockToString(CatchBlock node) => default; // 0x00000001896FA510-0x00000001896FA594
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close)
			where T : Expression {}
		private void VisitExpressions<T>(char open, ReadOnlyCollection<T> expressions, char close, string seperator)
			where T : Expression {}
		protected internal override Expression VisitBinary(BinaryExpression node) => default; // 0x00000001896FA944-0x00000001896FAF98
		protected internal override Expression VisitParameter(ParameterExpression node) => default; // 0x00000001896FBDE0-0x00000001896FBEA0
		protected internal override Expression VisitLambda<T>(Expression<T> node) => default;
		protected internal override Expression VisitConditional(ConditionalExpression node) => default; // 0x00000001896FB228-0x00000001896FB2F8
		protected internal override Expression VisitConstant(ConstantExpression node) => default; // 0x00000001896FB2F8-0x00000001896FB440
		private void OutMember(Expression instance, MemberInfo member) {} // 0x00000001896FA874-0x00000001896FA904
		protected internal override Expression VisitMember(MemberExpression node) => default; // 0x00000001896FBB00-0x00000001896FBB54
		protected internal override Expression VisitInvocation(InvocationExpression node) => default; // 0x00000001896FB94C-0x00000001896FBA3C
		protected internal override Expression VisitMethodCall(MethodCallExpression node) => default; // 0x00000001896FBB54-0x00000001896FBCE8
		protected internal override Expression VisitNewArray(NewArrayExpression node) => default; // 0x00000001896FBCE8-0x00000001896FBDE0
		protected internal override Expression VisitTypeBinary(TypeBinaryExpression node) => default; // 0x00000001896FBEEC-0x00000001896FBFC4
		protected internal override Expression VisitUnary(UnaryExpression node) => default; // 0x00000001896FBFC4-0x00000001896FC344
		protected internal override Expression VisitBlock(BlockExpression node) => default; // 0x00000001896FAF98-0x00000001896FB14C
		protected internal override Expression VisitDefault(DefaultExpression node) => default; // 0x00000001896FB440-0x00000001896FB4D4
		protected internal override Expression VisitLabel(LabelExpression node) => default; // 0x00000001896FBA3C-0x00000001896FBAB4
		protected internal override Expression VisitGoto(GotoExpression node) => default; // 0x00000001896FB688-0x00000001896FB7EC
		protected internal override Expression VisitLoop(LoopExpression node) => default; // 0x00000001896FBAB4-0x00000001896FBB00
		protected override CatchBlock VisitCatchBlock(CatchBlock node) => default; // 0x00000001896FB14C-0x00000001896FB228
		protected internal override Expression VisitTry(TryExpression node) => default; // 0x00000001896FBEA0-0x00000001896FBEEC
		protected internal override Expression VisitIndex(IndexExpression node) => default; // 0x00000001896FB7EC-0x00000001896FB94C
		protected internal override Expression VisitExtension(Expression node) => default; // 0x00000001896FB4D4-0x00000001896FB688
		private void DumpLabel(LabelTarget target) {} // 0x00000001896FA594-0x00000001896FA624
		private static bool IsBool(Expression node) => default; // 0x00000001896FA7A8-0x00000001896FA874
	}

	public enum ExpressionType // TypeDefIndex: 50745
	{
		Add = 0,
		AddChecked = 1,
		And = 2,
		AndAlso = 3,
		ArrayLength = 4,
		ArrayIndex = 5,
		Call = 6,
		Coalesce = 7,
		Conditional = 8,
		Constant = 9,
		Convert = 10,
		ConvertChecked = 11,
		Divide = 12,
		Equal = 13,
		ExclusiveOr = 14,
		GreaterThan = 15,
		GreaterThanOrEqual = 16,
		Invoke = 17,
		Lambda = 18,
		LeftShift = 19,
		LessThan = 20,
		LessThanOrEqual = 21,
		ListInit = 22,
		MemberAccess = 23,
		MemberInit = 24,
		Modulo = 25,
		Multiply = 26,
		MultiplyChecked = 27,
		Negate = 28,
		UnaryPlus = 29,
		NegateChecked = 30,
		New = 31,
		NewArrayInit = 32,
		NewArrayBounds = 33,
		Not = 34,
		NotEqual = 35,
		Or = 36,
		OrElse = 37,
		Parameter = 38,
		Power = 39,
		Quote = 40,
		RightShift = 41,
		Subtract = 42,
		SubtractChecked = 43,
		TypeAs = 44,
		TypeIs = 45,
		Assign = 46,
		Block = 47,
		DebugInfo = 48,
		Decrement = 49,
		Dynamic = 50,
		Default = 51,
		Extension = 52,
		Goto = 53,
		Increment = 54,
		Index = 55,
		Label = 56,
		RuntimeVariables = 57,
		Loop = 58,
		Switch = 59,
		Throw = 60,
		Try = 61,
		Unbox = 62,
		AddAssign = 63,
		AndAssign = 64,
		DivideAssign = 65,
		ExclusiveOrAssign = 66,
		LeftShiftAssign = 67,
		ModuloAssign = 68,
		MultiplyAssign = 69,
		OrAssign = 70,
		PowerAssign = 71,
		RightShiftAssign = 72,
		SubtractAssign = 73,
		AddAssignChecked = 74,
		MultiplyAssignChecked = 75,
		SubtractAssignChecked = 76,
		PreIncrementAssign = 77,
		PreDecrementAssign = 78,
		PostIncrementAssign = 79,
		PostDecrementAssign = 80,
		TypeEqual = 81,
		OnesComplement = 82,
		IsTrue = 83,
		IsFalse = 84
	}

	public abstract class ExpressionVisitor // TypeDefIndex: 50746
	{
		// Constructors
		protected ExpressionVisitor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual Expression Visit(Expression node) => default; // 0x00000001896FCE14-0x00000001896FCE5C
		public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes) => default; // 0x00000001896FCE5C-0x00000001896FD054
		private Expression[] VisitArguments(IArgumentProvider nodes) => default; // 0x00000001896FC6B8-0x00000001896FC6C0
		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName) => default; // 0x00000001896FCC84-0x00000001896FCC8C
		public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, System.Func<T, T> elementVisitor) => default;
		public T VisitAndConvert<T>(T node, string callerName)
			where T : Expression => default;
		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName)
			where T : Expression => default;
		protected internal virtual Expression VisitBinary(BinaryExpression node) => default; // 0x00000001896FC6C0-0x00000001896FC78C
		protected internal virtual Expression VisitBlock(BlockExpression node) => default; // 0x00000001896FC78C-0x00000001896FC844
		protected internal virtual Expression VisitConditional(ConditionalExpression node) => default; // 0x00000001896FC8FC-0x00000001896FC988
		protected internal virtual Expression VisitConstant(ConstantExpression node) => default; // 0x0000000183D51810-0x0000000183D51820
		protected internal virtual Expression VisitDefault(DefaultExpression node) => default; // 0x0000000183D51810-0x0000000183D51820
		protected internal virtual Expression VisitExtension(Expression node) => default; // 0x00000001896FC988-0x00000001896FC9AC
		protected internal virtual Expression VisitGoto(GotoExpression node) => default; // 0x00000001896FC9AC-0x00000001896FC9F0
		protected internal virtual Expression VisitInvocation(InvocationExpression node) => default; // 0x00000001896FCA60-0x00000001896FCAE4
		protected virtual LabelTarget VisitLabelTarget(LabelTarget node) => default; // 0x0000000183D51810-0x0000000183D51820
		protected internal virtual Expression VisitLabel(LabelExpression node) => default; // 0x00000001896FCAE4-0x00000001896FCB28
		protected internal virtual Expression VisitLambda<T>(Expression<T> node) => default;
		protected internal virtual Expression VisitLoop(LoopExpression node) => default; // 0x00000001896FCB28-0x00000001896FCB80
		protected internal virtual Expression VisitMember(MemberExpression node) => default; // 0x00000001896FCB80-0x00000001896FCBB4
		protected internal virtual Expression VisitIndex(IndexExpression node) => default; // 0x00000001896FC9F0-0x00000001896FCA60
		protected internal virtual Expression VisitMethodCall(MethodCallExpression node) => default; // 0x00000001896FCBB4-0x00000001896FCC50
		protected internal virtual Expression VisitNewArray(NewArrayExpression node) => default; // 0x00000001896FCC50-0x00000001896FCC84
		protected internal virtual Expression VisitParameter(ParameterExpression node) => default; // 0x0000000183D51810-0x0000000183D51820
		protected virtual CatchBlock VisitCatchBlock(CatchBlock node) => default; // 0x00000001896FC844-0x00000001896FC8FC
		protected internal virtual Expression VisitTry(TryExpression node) => default; // 0x00000001896FCC8C-0x00000001896FCD9C
		protected internal virtual Expression VisitTypeBinary(TypeBinaryExpression node) => default; // 0x00000001896FCD9C-0x00000001896FCDD0
		protected internal virtual Expression VisitUnary(UnaryExpression node) => default; // 0x00000001896FCDD0-0x00000001896FCE14
		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after) => default; // 0x00000001896FC5C8-0x00000001896FC6B8
		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after) => default; // 0x00000001896FC3A8-0x00000001896FC50C
		private static void ValidateChildType(System.Type before, System.Type after, string methodName) {} // 0x00000001896FC50C-0x00000001896FC5C8
	}

	public enum GotoExpressionKind // TypeDefIndex: 50747
	{
		Goto = 0,
		Return = 1,
		Break = 2,
		Continue = 3
	}

	[DebuggerTypeProxy(typeof(GotoExpressionProxy))]
	public sealed class GotoExpression : Expression // TypeDefIndex: 50748
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55C50-0x0000000183D55C60 
		public Expression Value { get; } // 0x0000000181041090-0x00000001810410A0 
		public LabelTarget Target { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public GotoExpressionKind Kind { get; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
		// Constructors
		public GotoExpression() {} // Dummy constructor
		internal GotoExpression(GotoExpressionKind kind, LabelTarget target, Expression value, System.Type type) {} // 0x00000001896FD308-0x00000001896FD394
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FD22C-0x00000001896FD274
		public GotoExpression Update(LabelTarget target, Expression value) => default; // 0x00000001896FD274-0x00000001896FD308
	}

	public interface IArgumentProvider // TypeDefIndex: 50749
	{
		// Properties
		int ArgumentCount { get; }
	
		// Methods
		Expression GetArgument(int index);
	}

	internal interface IParameterProvider // TypeDefIndex: 50750
	{
		// Properties
		int ParameterCount { get; }
	
		// Methods
		ParameterExpression GetParameter(int index);
	}

	[DebuggerTypeProxy(typeof(IndexExpressionProxy))]
	public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 50751
	{
		// Fields
		private IReadOnlyList<Expression> _arguments; // 0x10
	
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55F60-0x0000000183D55F70 
		public sealed override System.Type Type { get => default; } // 0x00000001896FD808-0x00000001896FD864 
		public Expression Object { get; } // 0x0000000181041090-0x00000001810410A0 
		public PropertyInfo Indexer { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public int ArgumentCount { get => default; } // 0x00000001896FD7C0-0x00000001896FD808 
	
		// Constructors
		public IndexExpression() {} // Dummy constructor
		internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) {} // 0x00000001896FD730-0x00000001896FD7C0
	
		// Methods
		public Expression GetArgument(int index) => default; // 0x00000001896FD664-0x00000001896FD6B8
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FD61C-0x00000001896FD664
		internal Expression Rewrite(Expression instance, Expression[] arguments) => default; // 0x00000001896FD6B8-0x00000001896FD730
	}

	[DebuggerTypeProxy(typeof(InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 50752
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55F90-0x0000000183D55FA0 
		public Expression Expression { get; } // 0x0000000181041090-0x00000001810410A0 
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount { get => default; } // 0x00000001896FED78-0x00000001896FEDA0 
	
		// Constructors
		public InvocationExpression() {} // Dummy constructor
		internal InvocationExpression(Expression expression, System.Type returnType) {} // 0x00000001896FED0C-0x00000001896FED78
	
		// Methods
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index) => default; // 0x00000001896FECBC-0x00000001896FECE4
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FEC74-0x00000001896FECBC
		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FECE4-0x00000001896FED0C
	}

	internal sealed class InvocationExpressionN : InvocationExpression // TypeDefIndex: 50753
	{
		// Fields
		private IReadOnlyList<Expression> _arguments; // 0x20
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x00000001896FEC2C-0x00000001896FEC74 
	
		// Constructors
		public InvocationExpressionN() {} // Dummy constructor
		public InvocationExpressionN(Expression lambda, IReadOnlyList<Expression> arguments, System.Type returnType) {} // 0x00000001896FEBF4-0x00000001896FEC2C
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FEB38-0x00000001896FEB8C
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FEB8C-0x00000001896FEBF4
	}

	internal sealed class InvocationExpression0 : InvocationExpression // TypeDefIndex: 50754
	{
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public InvocationExpression0() {} // Dummy constructor
		public InvocationExpression0(Expression lambda, System.Type returnType) {} // 0x00000001896FE1D8-0x00000001896FE1E0
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE130-0x00000001896FE18C
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE18C-0x00000001896FE1D8
	}

	internal sealed class InvocationExpression1 : InvocationExpression // TypeDefIndex: 50755
	{
		// Fields
		private object _arg0; // 0x20
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public InvocationExpression1() {} // Dummy constructor
		public InvocationExpression1(Expression lambda, System.Type returnType, Expression arg0) {} // 0x00000001896FE314-0x00000001896FE344
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE1E0-0x00000001896FE280
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE280-0x00000001896FE314
	}

	internal sealed class InvocationExpression2 : InvocationExpression // TypeDefIndex: 50756
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public InvocationExpression2() {} // Dummy constructor
		public InvocationExpression2(Expression lambda, System.Type returnType, Expression arg0, Expression arg1) {} // 0x00000001896FE4A0-0x00000001896FE4E4
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE344-0x00000001896FE3F0
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE3F0-0x00000001896FE4A0
	}

	internal sealed class InvocationExpression3 : InvocationExpression // TypeDefIndex: 50757
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
		private readonly Expression _arg2; // 0x30
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public InvocationExpression3() {} // Dummy constructor
		public InvocationExpression3(Expression lambda, System.Type returnType, Expression arg0, Expression arg1, Expression arg2) {} // 0x00000001896FE668-0x00000001896FE6BC
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE4E4-0x00000001896FE598
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE598-0x00000001896FE668
	}

	internal sealed class InvocationExpression4 : InvocationExpression // TypeDefIndex: 50758
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
		private readonly Expression _arg2; // 0x30
		private readonly Expression _arg3; // 0x38
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public InvocationExpression4() {} // Dummy constructor
		public InvocationExpression4(Expression lambda, System.Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) {} // 0x00000001896FE86C-0x00000001896FE8D4
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE6BC-0x00000001896FE77C
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE77C-0x00000001896FE86C
	}

	internal sealed class InvocationExpression5 : InvocationExpression // TypeDefIndex: 50759
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
		private readonly Expression _arg2; // 0x30
		private readonly Expression _arg3; // 0x38
		private readonly Expression _arg4; // 0x40
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public InvocationExpression5() {} // Dummy constructor
		public InvocationExpression5(Expression lambda, System.Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) {} // 0x00000001896FEAC0-0x00000001896FEB38
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FE8D4-0x00000001896FE9A4
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) => default; // 0x00000001896FE9A4-0x00000001896FEAC0
	}

	[DebuggerTypeProxy(typeof(LabelExpressionProxy))]
	public sealed class LabelExpression : Expression // TypeDefIndex: 50760
	{
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001856B3E18-0x00000001856B3E34 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D56160-0x0000000183D56170 
		public LabelTarget Target { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Expression DefaultValue { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public LabelExpression() {} // Dummy constructor
		internal LabelExpression(LabelTarget label, Expression defaultValue) {} // 0x00000001896FEE58-0x00000001896FEEC4
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FEDA0-0x00000001896FEDE8
		public LabelExpression Update(LabelTarget target, Expression defaultValue) => default; // 0x00000001896FEDE8-0x00000001896FEE58
	}

	public sealed class LabelTarget // TypeDefIndex: 50761
	{
		// Properties
		public string Name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Type Type { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public LabelTarget() {} // Dummy constructor
		internal LabelTarget(System.Type type, string name) {} // 0x0000000182AEEFA0-0x0000000182AEEFD0
	
		// Methods
		public override string ToString() => default; // 0x00000001896FEEC4-0x00000001896FEF08
	}

	[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
	public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 50762
	{
		// Fields
		private readonly Expression _body; // 0x10
	
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001896FF054-0x00000001896FF064 
		internal abstract System.Type TypeCore { get; }
		internal abstract System.Type PublicType { get; }
		public sealed override ExpressionType NodeType { get; } // 0x0000000183D56100-0x0000000183D56110 
		public string Name { get; } // 0x00000001896FEFA4-0x00000001896FEFB4 
		internal virtual string NameCore { get; } // 0x0000000181002730-0x0000000181002740 
		public Expression Body { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public System.Type ReturnType { get; } // 0x00000001896FEFDC-0x00000001896FF044 
		public bool TailCall { get; } // 0x00000001896FF044-0x00000001896FF054 
		internal virtual bool TailCallCore { get; } // 0x000000018115F4C0-0x000000018115F530 
		[ExcludeFromCodeCoverage]
		int IParameterProvider.ParameterCount { get; } // 0x00000001896FEF3C-0x00000001896FEF4C 
		[ExcludeFromCodeCoverage]
		internal virtual int ParameterCount { get; } // 0x00000001896FEFB4-0x00000001896FEFDC 
	
		// Constructors
		protected LambdaExpression() {} // Dummy constructor
		internal LambdaExpression(Expression body) {} // 0x00000001896FEF4C-0x00000001896FEFA4
	
		// Methods
		[ExcludeFromCodeCoverage]
		ParameterExpression IParameterProvider.GetParameter(int index) => default; // 0x00000001896FEF30-0x00000001896FEF3C
		[ExcludeFromCodeCoverage]
		internal virtual ParameterExpression GetParameter(int index) => default; // 0x00000001896FEF08-0x00000001896FEF30
	}

	public class Expression<TDelegate> : LambdaExpression // TypeDefIndex: 50763
	{
		// Properties
		internal sealed override System.Type TypeCore { get => default; }
		internal override System.Type PublicType { get => default; }
	
		// Constructors
		public Expression() {} // Dummy constructor
		internal Expression(Expression body) {}
	
		// Methods
		public TDelegate Compile() => default;
		public TDelegate Compile(bool preferInterpretation) => default;
		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
		protected internal override Expression Accept(ExpressionVisitor visitor) => default;
	}

	internal static class ExpressionCreator<TDelegate> // TypeDefIndex: 50764
	{
		// Methods
		public static LambdaExpression CreateExpressionFunc(Expression body, string name, bool tailCall, ReadOnlyCollection<ParameterExpression> parameters) => default;
	}

	internal sealed class Expression0<TDelegate> : Expression<TDelegate> // TypeDefIndex: 50765
	{
		// Properties
		internal override int ParameterCount { get => default; }
	
		// Constructors
		public Expression0() {} // Dummy constructor
		public Expression0(Expression body) {}
	
		// Methods
		internal override ParameterExpression GetParameter(int index) => default;
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
	}

	internal sealed class Expression1<TDelegate> : Expression<TDelegate> // TypeDefIndex: 50766
	{
		// Fields
		private object _par0;
	
		// Properties
		internal override int ParameterCount { get => default; }
	
		// Constructors
		public Expression1() {} // Dummy constructor
		public Expression1(Expression body, ParameterExpression par0) {}
	
		// Methods
		internal override ParameterExpression GetParameter(int index) => default;
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
	}

	internal sealed class Expression2<TDelegate> : Expression<TDelegate> // TypeDefIndex: 50767
	{
		// Fields
		private object _par0;
		private readonly ParameterExpression _par1;
	
		// Properties
		internal override int ParameterCount { get => default; }
	
		// Constructors
		public Expression2() {} // Dummy constructor
		public Expression2(Expression body, ParameterExpression par0, ParameterExpression par1) {}
	
		// Methods
		internal override ParameterExpression GetParameter(int index) => default;
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
	}

	internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 50768
	{
		// Fields
		private object _par0;
		private readonly ParameterExpression _par1;
		private readonly ParameterExpression _par2;
	
		// Properties
		internal override int ParameterCount { get => default; }
	
		// Constructors
		public Expression3() {} // Dummy constructor
		public Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) {}
	
		// Methods
		internal override ParameterExpression GetParameter(int index) => default;
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
	}

	internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 50769
	{
		// Fields
		private IReadOnlyList<ParameterExpression> _parameters;
	
		// Properties
		internal override int ParameterCount { get => default; }
	
		// Constructors
		public ExpressionN() {} // Dummy constructor
		public ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters) {}
	
		// Methods
		internal override ParameterExpression GetParameter(int index) => default;
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) => default;
	}

	internal sealed class FullExpression<TDelegate> : ExpressionN<TDelegate> // TypeDefIndex: 50770
	{
		// Properties
		internal override string NameCore { get; }
		internal override bool TailCallCore { get; }
	
		// Constructors
		public FullExpression() {} // Dummy constructor
		public FullExpression(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters) {}
	}

	[DebuggerTypeProxy(typeof(ListInitExpressionProxy))]
	public sealed class ListInitExpression : Expression // TypeDefIndex: 50771
	{
		// Properties
		public NewExpression NewExpression { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ReadOnlyCollection<ElementInit> Initializers { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public ListInitExpression() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(LoopExpressionProxy))]
	public sealed class LoopExpression : Expression // TypeDefIndex: 50772
	{
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001896FF594-0x00000001896FF608 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55AD0-0x0000000183D55AE0 
		public Expression Body { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public LabelTarget BreakLabel { get; } // 0x0000000181041090-0x00000001810410A0 
		public LabelTarget ContinueLabel { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public LoopExpression() {} // Dummy constructor
		internal LoopExpression(Expression body, LabelTarget @break, LabelTarget @continue) {} // 0x00000001896FF510-0x00000001896FF594
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FF440-0x00000001896FF488
		public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) => default; // 0x00000001896FF488-0x00000001896FF510
	}

	public sealed class MemberAssignment : MemberBinding // TypeDefIndex: 50773
	{
		// Fields
		private readonly Expression _expression; // 0x20
	
		// Properties
		public Expression Expression { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public MemberAssignment() {} // Dummy constructor
	}

	public enum MemberBindingType // TypeDefIndex: 50774
	{
		Assignment = 0,
		MemberBinding = 1,
		ListBinding = 2
	}

	public abstract class MemberBinding // TypeDefIndex: 50775
	{
		// Properties
		public MemberBindingType BindingType { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public MemberInfo Member { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		protected MemberBinding() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
	public class MemberExpression : Expression // TypeDefIndex: 50776
	{
		// Properties
		public MemberInfo Member { get => default; } // 0x00000001896FF81C-0x00000001896FF84C 
		public Expression Expression { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D56A00-0x0000000183D56A10 
	
		// Constructors
		public MemberExpression() {} // Dummy constructor
		internal MemberExpression(Expression expression) {} // 0x00000001896FF7C4-0x00000001896FF81C
	
		// Methods
		internal static PropertyExpression Make(Expression expression, PropertyInfo property) => default; // 0x00000001896FF6E8-0x00000001896FF758
		internal static FieldExpression Make(Expression expression, System.Reflection.FieldInfo field) => default; // 0x00000001896FF678-0x00000001896FF6E8
		[ExcludeFromCodeCoverage]
		internal virtual MemberInfo GetMember() => default; // 0x00000001896FF650-0x00000001896FF678
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001896FF608-0x00000001896FF650
		public MemberExpression Update(Expression expression) => default; // 0x00000001896FF758-0x00000001896FF7C4
	}

	internal sealed class FieldExpression : MemberExpression // TypeDefIndex: 50777
	{
		// Fields
		private readonly System.Reflection.FieldInfo _field; // 0x18
	
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001896FD084-0x00000001896FD0A8 
	
		// Constructors
		public FieldExpression() {} // Dummy constructor
		public FieldExpression(Expression expression, System.Reflection.FieldInfo member) {} // 0x00000001896FD054-0x00000001896FD084
	
		// Methods
		internal override MemberInfo GetMember() => default; // 0x0000000181041090-0x00000001810410A0
	}

	internal sealed class PropertyExpression : MemberExpression // TypeDefIndex: 50778
	{
		// Fields
		private readonly PropertyInfo _property; // 0x18
	
		// Properties
		public sealed override System.Type Type { get => default; } // 0x00000001897016CC-0x00000001897016F0 
	
		// Constructors
		public PropertyExpression() {} // Dummy constructor
		public PropertyExpression(Expression expression, PropertyInfo member) {} // 0x00000001896FD054-0x00000001896FD084
	
		// Methods
		internal override MemberInfo GetMember() => default; // 0x0000000181041090-0x00000001810410A0
	}

	[DebuggerTypeProxy(typeof(MemberInitExpressionProxy))]
	public sealed class MemberInitExpression : Expression // TypeDefIndex: 50779
	{
		// Properties
		public NewExpression NewExpression { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ReadOnlyCollection<MemberBinding> Bindings { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public MemberInitExpression() {} // Dummy constructor
	}

	public sealed class MemberListBinding : MemberBinding // TypeDefIndex: 50780
	{
		// Properties
		public ReadOnlyCollection<ElementInit> Initializers { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public MemberListBinding() {} // Dummy constructor
	}

	public sealed class MemberMemberBinding : MemberBinding // TypeDefIndex: 50781
	{
		// Properties
		public ReadOnlyCollection<MemberBinding> Bindings { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public MemberMemberBinding() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(MethodCallExpressionProxy))]
	public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 50782
	{
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D51110-0x0000000183D51120 
		public sealed override System.Type Type { get => default; } // 0x0000000189700528-0x000000018970054C 
		public MethodInfo Method { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Expression Object { get => default; } // 0x0000000189700518-0x0000000189700528 
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount { get => default; } // 0x00000001897004F0-0x0000000189700518 
	
		// Constructors
		public MethodCallExpression() {} // Dummy constructor
		internal MethodCallExpression(MethodInfo method) {} // 0x0000000189700498-0x00000001897004F0
	
		// Methods
		internal virtual Expression GetInstance() => default; // 0x0000000181002730-0x0000000181002740
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x0000000189700400-0x0000000189700448
		[ExcludeFromCodeCoverage]
		internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x0000000189700470-0x0000000189700498
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index) => default; // 0x0000000189700448-0x0000000189700470
	}

	internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50783
	{
		// Fields
		private readonly Expression _instance; // 0x18
	
		// Constructors
		public InstanceMethodCallExpression() {} // Dummy constructor
		public InstanceMethodCallExpression(MethodInfo method, Expression instance) {} // 0x00000001896FE100-0x00000001896FE130
	
		// Methods
		internal override Expression GetInstance() => default; // 0x0000000181041090-0x00000001810410A0
	}

	internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50784
	{
		// Fields
		private IReadOnlyList<Expression> _arguments; // 0x18
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x00000001897003B8-0x0000000189700400 
	
		// Constructors
		public MethodCallExpressionN() {} // Dummy constructor
		public MethodCallExpressionN(MethodInfo method, IReadOnlyList<Expression> args) {} // 0x00000001896FE100-0x00000001896FE130
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001897002FC-0x0000000189700350
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x0000000189700350-0x00000001897003B8
	}

	internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 50785
	{
		// Fields
		private IReadOnlyList<Expression> _arguments; // 0x20
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x00000001896FE0B8-0x00000001896FE100 
	
		// Constructors
		public InstanceMethodCallExpressionN() {} // Dummy constructor
		public InstanceMethodCallExpressionN(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) {} // 0x00000001896FDBDC-0x00000001896FDC0C
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FDFEC-0x00000001896FE040
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FE040-0x00000001896FE0B8
	}

	internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50786
	{
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public MethodCallExpression0() {} // Dummy constructor
		public MethodCallExpression0(MethodInfo method) {} // 0x00000001896FF8F8-0x00000001896FF900
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FF84C-0x00000001896FF8A8
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FF8A8-0x00000001896FF8F8
	}

	internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50787
	{
		// Fields
		private object _arg0; // 0x18
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public MethodCallExpression1() {} // Dummy constructor
		public MethodCallExpression1(MethodInfo method, Expression arg0) {} // 0x00000001896FE100-0x00000001896FE130
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FF900-0x00000001896FF9A0
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FF9A0-0x00000001896FFA44
	}

	internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50788
	{
		// Fields
		private object _arg0; // 0x18
		private readonly Expression _arg1; // 0x20
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public MethodCallExpression2() {} // Dummy constructor
		public MethodCallExpression2(MethodInfo method, Expression arg0, Expression arg1) {} // 0x00000001896FFBC0-0x00000001896FFC0C
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FFA44-0x00000001896FFAF0
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FFAF0-0x00000001896FFBC0
	}

	internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50789
	{
		// Fields
		private object _arg0; // 0x18
		private readonly Expression _arg1; // 0x20
		private readonly Expression _arg2; // 0x28
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public MethodCallExpression3() {} // Dummy constructor
		public MethodCallExpression3(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) {} // 0x00000001896FFDBC-0x00000001896FFE18
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FFC0C-0x00000001896FFCC0
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FFCC0-0x00000001896FFDBC
	}

	internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50790
	{
		// Fields
		private object _arg0; // 0x18
		private readonly Expression _arg1; // 0x20
		private readonly Expression _arg2; // 0x28
		private readonly Expression _arg3; // 0x30
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D50CD0-0x0000000183D50CE0 
	
		// Constructors
		public MethodCallExpression4() {} // Dummy constructor
		public MethodCallExpression4(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) {} // 0x00000001896FFFF4-0x0000000189700064
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FFE18-0x00000001896FFED8
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FFED8-0x00000001896FFFF4
	}

	internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 50791
	{
		// Fields
		private object _arg0; // 0x18
		private readonly Expression _arg1; // 0x20
		private readonly Expression _arg2; // 0x28
		private readonly Expression _arg3; // 0x30
		private readonly Expression _arg4; // 0x38
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D51100-0x0000000183D51110 
	
		// Constructors
		public MethodCallExpression5() {} // Dummy constructor
		public MethodCallExpression5(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) {} // 0x000000018970027C-0x00000001897002FC
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x0000000189700064-0x0000000189700134
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x0000000189700134-0x000000018970027C
	}

	internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 50792
	{
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181002730-0x0000000181002740 
	
		// Constructors
		public InstanceMethodCallExpression0() {} // Dummy constructor
		public InstanceMethodCallExpression0(MethodInfo method, Expression instance) {} // 0x00000001896FDA80-0x00000001896FDA88
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FD9D0-0x00000001896FDA2C
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FDA2C-0x00000001896FDA80
	}

	internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 50793
	{
		// Fields
		private object _arg0; // 0x20
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public InstanceMethodCallExpression1() {} // Dummy constructor
		public InstanceMethodCallExpression1(MethodInfo method, Expression instance, Expression arg0) {} // 0x00000001896FDBDC-0x00000001896FDC0C
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FDA88-0x00000001896FDB28
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FDB28-0x00000001896FDBDC
	}

	internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 50794
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public InstanceMethodCallExpression2() {} // Dummy constructor
		public InstanceMethodCallExpression2(MethodInfo method, Expression instance, Expression arg0, Expression arg1) {} // 0x00000001896FDD9C-0x00000001896FDDE0
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FDC0C-0x00000001896FDCB8
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FDCB8-0x00000001896FDD9C
	}

	internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 50795
	{
		// Fields
		private object _arg0; // 0x20
		private readonly Expression _arg1; // 0x28
		private readonly Expression _arg2; // 0x30
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
	
		// Constructors
		public InstanceMethodCallExpression3() {} // Dummy constructor
		public InstanceMethodCallExpression3(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) {} // 0x00000001896FDF98-0x00000001896FDFEC
	
		// Methods
		public override Expression GetArgument(int index) => default; // 0x00000001896FDDE0-0x00000001896FDE94
		internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) => default; // 0x00000001896FDE94-0x00000001896FDF98
	}

	[DebuggerTypeProxy(typeof(NewArrayExpressionProxy))]
	public class NewArrayExpression : Expression // TypeDefIndex: 50796
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ReadOnlyCollection<Expression> Expressions { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public NewArrayExpression() {} // Dummy constructor
		internal NewArrayExpression(System.Type type, ReadOnlyCollection<Expression> expressions) {} // 0x0000000189700D6C-0x0000000189700DD8
	
		// Methods
		internal static NewArrayExpression Make(ExpressionType nodeType, System.Type type, ReadOnlyCollection<Expression> expressions) => default; // 0x0000000189700B80-0x0000000189700C0C
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x0000000189700B38-0x0000000189700B80
		public NewArrayExpression Update(IEnumerable<Expression> expressions) => default; // 0x0000000189700C0C-0x0000000189700D6C
	}

	internal sealed class NewArrayInitExpression : NewArrayExpression // TypeDefIndex: 50797
	{
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public NewArrayInitExpression() {} // Dummy constructor
		internal NewArrayInitExpression(System.Type type, ReadOnlyCollection<Expression> expressions) {} // 0x00000001897009F8-0x0000000189700A00
	}

	internal sealed class NewArrayBoundsExpression : NewArrayExpression // TypeDefIndex: 50798
	{
		// Properties
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55BB0-0x0000000183D55BC0 
	
		// Constructors
		public NewArrayBoundsExpression() {} // Dummy constructor
		internal NewArrayBoundsExpression(System.Type type, ReadOnlyCollection<Expression> expressions) {} // 0x00000001897009F8-0x0000000189700A00
	}

	[DebuggerTypeProxy(typeof(NewExpressionProxy))]
	public class NewExpression : Expression // TypeDefIndex: 50799
	{
		// Fields
		private IReadOnlyList<Expression> _arguments; // 0x10
	
		// Properties
		public ConstructorInfo Constructor { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public NewExpression() {} // Dummy constructor
	
		// Methods
		public Expression GetArgument(int index) => default; // 0x0000000189700F44-0x0000000189700F98
	}

	[DebuggerTypeProxy(typeof(ParameterExpressionProxy))]
	public class ParameterExpression : Expression // TypeDefIndex: 50800
	{
		// Properties
		public override System.Type Type { get => default; } // 0x000000018970167C-0x00000001897016CC 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D55B90-0x0000000183D55BA0 
		public string Name { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public bool IsByRef { get => default; } // 0x000000018970166C-0x000000018970167C 
	
		// Constructors
		public ParameterExpression() {} // Dummy constructor
		internal ParameterExpression(string name) {} // 0x0000000189701614-0x000000018970166C
	
		// Methods
		internal static ParameterExpression Make(System.Type type, string name, bool isByRef) => default; // 0x00000001897011AC-0x0000000189701614
		internal virtual bool GetIsByRef() => default; // 0x000000018115F4C0-0x000000018115F530
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x0000000189701164-0x00000001897011AC
	}

	internal sealed class ByRefParameterExpression : TypedParameterExpression // TypeDefIndex: 50801
	{
		// Constructors
		public ByRefParameterExpression() {} // Dummy constructor
		internal ByRefParameterExpression(System.Type type, string name) {} // 0x00000001896F0E3C-0x00000001896F0E44
	
		// Methods
		internal override bool GetIsByRef() => default; // 0x000000018232EB60-0x000000018232EB70
	}

	internal class TypedParameterExpression : ParameterExpression // TypeDefIndex: 50802
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public TypedParameterExpression() {} // Dummy constructor
		internal TypedParameterExpression(System.Type type, string name) {} // 0x000000018970429C-0x00000001897042D4
	}

	internal sealed class PrimitiveParameterExpression<T> : ParameterExpression // TypeDefIndex: 50803
	{
		// Properties
		public sealed override System.Type Type { get => default; }
	
		// Constructors
		public PrimitiveParameterExpression() {} // Dummy constructor
		internal PrimitiveParameterExpression(string name) {}
	}

	[DebuggerTypeProxy(typeof(RuntimeVariablesExpressionProxy))]
	public sealed class RuntimeVariablesExpression : Expression // TypeDefIndex: 50804
	{
		// Properties
		public ReadOnlyCollection<ParameterExpression> Variables { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public RuntimeVariablesExpression() {} // Dummy constructor
	}

	internal sealed class StackGuard // TypeDefIndex: 50806
	{
		// Fields
		private int _executionStackCount; // 0x10
	
		// Constructors
		public StackGuard() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool TryEnterOnCurrentStack() => default; // 0x000000018232EB60-0x000000018232EB70
		public void RunOnEmptyStack<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) {}
		private R RunOnEmptyStackCore<R>(System.Func<object, R> action, object state) => default;
	}

	internal static class Strings // TypeDefIndex: 50807
	{
		// Properties
		internal static string ReducibleMustOverrideReduce { get; } // 0x0000000189703A74-0x0000000189703AA0 
		internal static string MustReduceToDifferent { get; } // 0x0000000189703864-0x0000000189703890 
		internal static string ReducedNotCompatible { get; } // 0x0000000189703A48-0x0000000189703A74 
		internal static string SetterHasNoParams { get; } // 0x0000000189703ACC-0x0000000189703AF8 
		internal static string PropertyCannotHaveRefType { get; } // 0x000000018970396C-0x0000000189703998 
		internal static string IndexesOfSetGetMustMatch { get; } // 0x0000000189703730-0x000000018970375C 
		internal static string AccessorsCannotHaveVarArgs { get; } // 0x0000000189703208-0x0000000189703234 
		internal static string AccessorsCannotHaveByRefArgs { get; } // 0x00000001897031DC-0x0000000189703208 
		internal static string BoundsCannotBeLessThanOne { get; } // 0x0000000189703418-0x0000000189703444 
		internal static string TypeMustNotBeByRef { get; } // 0x0000000189703B7C-0x0000000189703BA8 
		internal static string TypeMustNotBePointer { get; } // 0x0000000189703BA8-0x0000000189703BD4 
		internal static string SetterMustBeVoid { get; } // 0x0000000189703AF8-0x0000000189703B24 
		internal static string PropertyTypeMustMatchGetter { get; } // 0x00000001897039C4-0x00000001897039F0 
		internal static string PropertyTypeMustMatchSetter { get; } // 0x00000001897039F0-0x0000000189703A1C 
		internal static string BothAccessorsMustBeStatic { get; } // 0x00000001897033EC-0x0000000189703418 
		internal static string OnlyStaticFieldsHaveNullInstance { get; } // 0x00000001897038E8-0x0000000189703914 
		internal static string OnlyStaticPropertiesHaveNullInstance { get; } // 0x0000000189703940-0x000000018970396C 
		internal static string OnlyStaticMethodsHaveNullInstance { get; } // 0x0000000189703914-0x0000000189703940 
		internal static string PropertyTypeCannotBeVoid { get; } // 0x0000000189703998-0x00000001897039C4 
		internal static string InvalidUnboxType { get; } // 0x0000000189703788-0x00000001897037B4 
		internal static string ExpressionMustBeWriteable { get; } // 0x00000001897035FC-0x0000000189703628 
		internal static string ArgumentMustNotHaveValueType { get; } // 0x000000018970333C-0x0000000189703368 
		internal static string MustBeReducible { get; } // 0x0000000189703838-0x0000000189703864 
		internal static string LabelMustBeVoidOrHaveExpression { get; } // 0x00000001897037B4-0x00000001897037E0 
		internal static string LabelTypeMustBeVoid { get; } // 0x00000001897037E0-0x000000018970380C 
		internal static string QuotedExpressionMustBeLambda { get; } // 0x0000000189703A1C-0x0000000189703A48 
		internal static string CollectionModifiedWhileEnumerating { get; } // 0x0000000189703470-0x000000018970349C 
		internal static string CollectionReadOnly { get; } // 0x000000018970349C-0x00000001897034C8 
		internal static string BindingCannotBeNull { get; } // 0x0000000189703394-0x00000001897033C0 
		internal static string NoOrInvalidRuleProduced { get; } // 0x0000000189703890-0x00000001897038BC 
		internal static string TypeMustBeDerivedFromSystemDelegate { get; } // 0x0000000189703B50-0x0000000189703B7C 
		internal static string FirstArgumentMustBeCallSite { get; } // 0x0000000189703654-0x0000000189703680 
		internal static string FaultCannotHaveCatchOrFinally { get; } // 0x0000000189703628-0x0000000189703654 
		internal static string TryMustHaveCatchFinallyOrFault { get; } // 0x0000000189703B24-0x0000000189703B50 
		internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry { get; } // 0x00000001897033C0-0x00000001897033EC 
		internal static string ConversionIsNotSupportedForArithmeticTypes { get; } // 0x0000000189703578-0x00000001897035A4 
		internal static string ArgumentMustBeArray { get; } // 0x000000018970328C-0x00000001897032B8 
		internal static string ArgumentMustBeBoolean { get; } // 0x00000001897032B8-0x00000001897032E4 
		internal static string ArgumentMustBeInteger { get; } // 0x00000001897032E4-0x0000000189703310 
		internal static string ArgumentMustBeArrayIndexType { get; } // 0x0000000189703260-0x000000018970328C 
		internal static string ArgumentMustBeSingleDimensionalArrayType { get; } // 0x0000000189703310-0x000000018970333C 
		internal static string ArgumentTypesMustMatch { get; } // 0x0000000189703368-0x0000000189703394 
		internal static string CoalesceUsedOnNonNullType { get; } // 0x0000000189703444-0x0000000189703470 
		internal static string IncorrectNumberOfIndexes { get; } // 0x00000001897036AC-0x00000001897036D8 
		internal static string IncorrectNumberOfLambdaDeclarationParameters { get; } // 0x0000000189703704-0x0000000189703730 
		internal static string LambdaTypeMustBeDerivedFromSystemDelegate { get; } // 0x000000018970380C-0x0000000189703838 
		internal static string ArgumentCannotBeOfTypeVoid { get; } // 0x0000000189703234-0x0000000189703260 
		internal static string ControlCannotLeaveFinally { get; } // 0x000000018970354C-0x0000000189703578 
		internal static string ControlCannotLeaveFilterTest { get; } // 0x0000000189703520-0x000000018970354C 
		internal static string ControlCannotEnterTry { get; } // 0x00000001897034F4-0x0000000189703520 
		internal static string ControlCannotEnterExpression { get; } // 0x00000001897034C8-0x00000001897034F4 
		internal static string RethrowRequiresCatch { get; } // 0x0000000189703AA0-0x0000000189703ACC 
		internal static string NonAbstractConstructorRequired { get; } // 0x00000001897038BC-0x00000001897038E8 
		internal static string ExpressionMustBeReadable { get; } // 0x00000001897035D0-0x00000001897035FC 
		internal static string EnumerationIsDone { get; } // 0x00000001897035A4-0x00000001897035D0 
		internal static string InvalidArgumentValue { get; } // 0x000000018970375C-0x0000000189703788 
		internal static string IncorrectNumberOfLambdaArguments { get; } // 0x00000001897036D8-0x0000000189703704 
		internal static string IncorrectNumberOfConstructorArguments { get; } // 0x0000000189703680-0x00000001897036AC 
	
		// Methods
		internal static string VariableMustNotBeByRef(object p0, object p1) => default; // 0x0000000189703190-0x00000001897031DC
		internal static string AmbiguousMatchInExpandoObject(object p0) => default; // 0x0000000189701FBC-0x0000000189701FF8
		internal static string SameKeyExistsInExpando(object p0) => default; // 0x0000000189702ECC-0x0000000189702F08
		internal static string KeyDoesNotExistInExpando(object p0) => default; // 0x00000001897028E8-0x0000000189702924
		internal static string InvalidMetaObjectCreated(object p0) => default; // 0x0000000189702824-0x0000000189702860
		internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2) => default; // 0x0000000189702058-0x00000001897020B8
		internal static string DynamicBindingNeedsRestrictions(object p0, object p1) => default; // 0x00000001897021DC-0x0000000189702228
		internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3) => default; // 0x0000000189702228-0x000000018970232C
		internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2) => default; // 0x000000018970217C-0x00000001897021DC
		internal static string DuplicateVariable(object p0) => default; // 0x0000000189702140-0x000000018970217C
		internal static string TypeParameterIsNotDelegate(object p0) => default; // 0x0000000189702F80-0x0000000189702FBC
		internal static string ExtensionNodeMustOverrideProperty(object p0) => default; // 0x0000000189702590-0x00000001897025CC
		internal static string UserDefinedOperatorMustBeStatic(object p0) => default; // 0x0000000189703118-0x0000000189703154
		internal static string UserDefinedOperatorMustNotBeVoid(object p0) => default; // 0x0000000189703154-0x0000000189703190
		internal static string CoercionOperatorNotDefined(object p0, object p1) => default; // 0x00000001897020F4-0x0000000189702140
		internal static string UnaryOperatorNotDefined(object p0, object p1) => default; // 0x0000000189702FBC-0x0000000189703008
		internal static string BinaryOperatorNotDefined(object p0, object p1, object p2) => default; // 0x0000000189701FF8-0x0000000189702058
		internal static string ReferenceEqualityNotDefined(object p0, object p1) => default; // 0x0000000189702E80-0x0000000189702ECC
		internal static string OperandTypesDoNotMatchParameters(object p0, object p1) => default; // 0x0000000189702CC8-0x0000000189702D14
		internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1) => default; // 0x0000000189702D60-0x0000000189702DAC
		internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0) => default; // 0x00000001897020B8-0x00000001897020F4
		internal static string IncorrectTypeForTypeAs(object p0) => default; // 0x00000001897026B4-0x00000001897026F0
		internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1) => default; // 0x000000018970232C-0x0000000189702378
		internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1) => default; // 0x0000000189702508-0x0000000189702554
		internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1) => default; // 0x0000000189702378-0x00000001897023C4
		internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1) => default; // 0x0000000189702410-0x000000018970245C
		internal static string ExpressionTypeNotInvocable(object p0) => default; // 0x0000000189702554-0x0000000189702590
		internal static string InstanceFieldNotDefinedForType(object p0, object p1) => default; // 0x0000000189702750-0x000000018970279C
		internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2) => default; // 0x00000001897025CC-0x000000018970262C
		internal static string MemberNotFieldOrProperty(object p0) => default; // 0x00000001897029E8-0x0000000189702A24
		internal static string MethodContainsGenericParameters(object p0) => default; // 0x0000000189702A24-0x0000000189702A60
		internal static string MethodIsGeneric(object p0) => default; // 0x0000000189702A60-0x0000000189702A9C
		internal static string MethodNotPropertyAccessor(object p0, object p1) => default; // 0x0000000189702A9C-0x0000000189702AE8
		internal static string PropertyDoesNotHaveAccessor(object p0) => default; // 0x0000000189702DF8-0x0000000189702E34
		internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1) => default; // 0x0000000189702DAC-0x0000000189702DF8
		internal static string PropertyNotDefinedForType(object p0, object p1) => default; // 0x0000000189702E34-0x0000000189702E80
		internal static string InstancePropertyNotDefinedForType(object p0, object p1) => default; // 0x000000018970279C-0x00000001897027E8
		internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2) => default; // 0x00000001897026F0-0x0000000189702750
		internal static string UnhandledBinary(object p0) => default; // 0x0000000189703008-0x0000000189703044
		internal static string UnhandledUnary(object p0) => default; // 0x0000000189703044-0x0000000189703080
		internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1) => default; // 0x0000000189703080-0x00000001897030CC
		internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1) => default; // 0x00000001897030CC-0x0000000189703118
		internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1) => default; // 0x000000018970299C-0x00000001897029E8
		internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1) => default; // 0x0000000189702AE8-0x0000000189702B34
		internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1) => default; // 0x000000018970262C-0x0000000189702678
		internal static string MethodWithMoreThanOneMatch(object p0, object p1) => default; // 0x0000000189702B34-0x0000000189702B80
		internal static string OutOfRange(object p0, object p1) => default; // 0x0000000189702D14-0x0000000189702D60
		internal static string LabelTargetAlreadyDefined(object p0) => default; // 0x0000000189702924-0x0000000189702960
		internal static string LabelTargetUndefined(object p0) => default; // 0x0000000189702960-0x000000018970299C
		internal static string AmbiguousJump(object p0) => default; // 0x0000000189701F80-0x0000000189701FBC
		internal static string NonLocalJumpWithValue(object p0) => default; // 0x0000000189702C8C-0x0000000189702CC8
		internal static string InvalidLvalue(object p0) => default; // 0x00000001897027E8-0x0000000189702824
		internal static string MustRewriteToSameNode(object p0, object p1, object p2) => default; // 0x0000000189702BE0-0x0000000189702C40
		internal static string MustRewriteChildToSameType(object p0, object p1, object p2) => default; // 0x0000000189702B80-0x0000000189702BE0
		internal static string MustRewriteWithoutMethod(object p0, object p1) => default; // 0x0000000189702C40-0x0000000189702C8C
		internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1) => default; // 0x00000001897023C4-0x0000000189702410
		internal static string TypeContainsGenericParameters(object p0) => default; // 0x0000000189702F08-0x0000000189702F44
		internal static string TypeIsGeneric(object p0) => default; // 0x0000000189702F44-0x0000000189702F80
		internal static string InvalidNullValue(object p0) => default; // 0x0000000189702860-0x000000018970289C
		internal static string InvalidObjectType(object p0, object p1) => default; // 0x000000018970289C-0x00000001897028E8
		internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2) => default; // 0x000000018970245C-0x00000001897024BC
		internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1) => default; // 0x00000001897024BC-0x0000000189702508
		internal static string IncorrectNumberOfMethodCallArguments(object p0) => default; // 0x0000000189702678-0x00000001897026B4
	}

	[DebuggerTypeProxy(typeof(Expression.SwitchCaseProxy))]
	public sealed class SwitchCase // TypeDefIndex: 50808
	{
		// Properties
		public ReadOnlyCollection<Expression> TestValues { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Expression Body { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public SwitchCase() {} // Dummy constructor
	}

	[DebuggerTypeProxy(typeof(SwitchExpressionProxy))]
	public sealed class SwitchExpression : Expression // TypeDefIndex: 50809
	{
		// Properties
		public Expression SwitchValue { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public ReadOnlyCollection<SwitchCase> Cases { get; } // 0x0000000181041090-0x00000001810410A0 
		public Expression DefaultBody { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public MethodInfo Comparison { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public SwitchExpression() {} // Dummy constructor
	}

	public class SymbolDocumentInfo // TypeDefIndex: 50810
	{
		// Fields
		internal static readonly Guid DocumentType_Text; // 0x00
	
		// Properties
		public string FileName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public SymbolDocumentInfo() {} // Dummy constructor
		static SymbolDocumentInfo() {} // 0x0000000189703BD4-0x0000000189703C68
	}

	[DebuggerTypeProxy(typeof(TryExpressionProxy))]
	public sealed class TryExpression : Expression // TypeDefIndex: 50811
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get => default; } // 0x0000000183D560B0-0x0000000183D560C0 
		public Expression Body { get; } // 0x0000000181041090-0x00000001810410A0 
		public ReadOnlyCollection<CatchBlock> Handlers { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public Expression Finally { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public Expression Fault { get; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public TryExpression() {} // Dummy constructor
		internal TryExpression(System.Type type, Expression body, Expression @finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) {} // 0x0000000189704028-0x00000001897040D0
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x0000000189703F04-0x0000000189703F4C
		public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression @finally, Expression fault) => default; // 0x0000000189703F4C-0x0000000189704028
	}

	[DebuggerTypeProxy(typeof(TypeBinaryExpressionProxy))]
	public sealed class TypeBinaryExpression : Expression // TypeDefIndex: 50812
	{
		// Properties
		public sealed override System.Type Type { get => default; } // 0x000000018970421C-0x000000018970426C 
		public sealed override ExpressionType NodeType { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public Expression Expression { get; } // 0x0000000181041090-0x00000001810410A0 
		public System.Type TypeOperand { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Constructors
		public TypeBinaryExpression() {} // Dummy constructor
		internal TypeBinaryExpression(Expression expression, System.Type typeOperand, ExpressionType nodeType) {} // 0x00000001897041A0-0x000000018970421C
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001897040D0-0x0000000189704118
		public TypeBinaryExpression Update(Expression expression) => default; // 0x0000000189704118-0x00000001897041A0
	}

	[DebuggerTypeProxy(typeof(UnaryExpressionProxy))]
	public sealed class UnaryExpression : Expression // TypeDefIndex: 50813
	{
		// Properties
		public sealed override System.Type Type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public sealed override ExpressionType NodeType { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public Expression Operand { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public MethodInfo Method { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public bool IsLifted { get => default; } // 0x00000001897051AC-0x0000000189705374 
		public bool IsLiftedToNull { get => default; } // 0x0000000189705148-0x00000001897051AC 
		public override bool CanReduce { get => default; } // 0x0000000189705128-0x0000000189705148 
		private bool IsPrefix { get => default; } // 0x0000000189705374-0x00000001897053AC 
	
		// Constructors
		public UnaryExpression() {} // Dummy constructor
		internal UnaryExpression(ExpressionType nodeType, Expression expression, System.Type type, MethodInfo method) {} // 0x000000018970509C-0x0000000189705128
	
		// Methods
		protected internal override Expression Accept(ExpressionVisitor visitor) => default; // 0x00000001897043E4-0x000000018970442C
		public override Expression Reduce() => default; // 0x0000000189704F94-0x0000000189705000
		private UnaryExpression FunctionalOp(Expression operand) => default; // 0x000000018970442C-0x0000000189704500
		private Expression ReduceVariable() => default; // 0x0000000189704D48-0x0000000189704F94
		private Expression ReduceMember() => default; // 0x000000018970497C-0x0000000189704D48
		private Expression ReduceIndex() => default; // 0x0000000189704500-0x000000018970497C
		public UnaryExpression Update(Expression operand) => default; // 0x0000000189705000-0x000000018970509C
	}

	internal static class Utils // TypeDefIndex: 50814
	{
		// Fields
		public static readonly object BoxedFalse; // 0x00
		public static readonly object BoxedTrue; // 0x08
		public static readonly object BoxedIntM1; // 0x10
		public static readonly object BoxedInt0; // 0x18
		public static readonly object BoxedInt1; // 0x20
		public static readonly object BoxedInt2; // 0x28
		public static readonly object BoxedInt3; // 0x30
		public static readonly object BoxedDefaultSByte; // 0x38
		public static readonly object BoxedDefaultChar; // 0x40
		public static readonly object BoxedDefaultInt16; // 0x48
		public static readonly object BoxedDefaultInt64; // 0x50
		public static readonly object BoxedDefaultByte; // 0x58
		public static readonly object BoxedDefaultUInt16; // 0x60
		public static readonly object BoxedDefaultUInt32; // 0x68
		public static readonly object BoxedDefaultUInt64; // 0x70
		public static readonly object BoxedDefaultSingle; // 0x78
		public static readonly object BoxedDefaultDouble; // 0x80
		public static readonly object BoxedDefaultDecimal; // 0x88
		public static readonly object BoxedDefaultDateTime; // 0x90
		private static readonly ConstantExpression s_true; // 0x98
		private static readonly ConstantExpression s_false; // 0xA0
		private static readonly ConstantExpression s_m1; // 0xA8
		private static readonly ConstantExpression s_0; // 0xB0
		private static readonly ConstantExpression s_1; // 0xB8
		private static readonly ConstantExpression s_2; // 0xC0
		private static readonly ConstantExpression s_3; // 0xC8
		public static readonly DefaultExpression Empty; // 0xD0
		public static readonly ConstantExpression Null; // 0xD8
	
		// Constructors
		static Utils() {} // 0x0000000189705550-0x00000001897061F8
	
		// Methods
		public static ConstantExpression Constant(bool value) => default; // 0x00000001897054F8-0x0000000189705550
		public static ConstantExpression Constant(int value) => default; // 0x00000001897053AC-0x00000001897054F8
	}
}

namespace System.Linq.Expressions.Interpreter
{
	internal abstract class AddInstruction : Instruction // TypeDefIndex: 50823
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896ED098-0x00000001896ED0C4 
	
		// Nested types
		private sealed class AddInt16 : AddInstruction // TypeDefIndex: 50815
		{
			// Constructors
			public AddInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ED0C4-0x00000001896ED1D8
		}
	
		private sealed class AddInt32 : AddInstruction // TypeDefIndex: 50816
		{
			// Constructors
			public AddInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ED1D8-0x00000001896ED2DC
		}
	
		private sealed class AddInt64 : AddInstruction // TypeDefIndex: 50817
		{
			// Constructors
			public AddInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ED2DC-0x00000001896ED3F0
		}
	
		private sealed class AddUInt16 : AddInstruction // TypeDefIndex: 50818
		{
			// Constructors
			public AddUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE1DC-0x00000001896EE2F0
		}
	
		private sealed class AddUInt32 : AddInstruction // TypeDefIndex: 50819
		{
			// Constructors
			public AddUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE2F0-0x00000001896EE400
		}
	
		private sealed class AddUInt64 : AddInstruction // TypeDefIndex: 50820
		{
			// Constructors
			public AddUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE400-0x00000001896EE514
		}
	
		private sealed class AddSingle : AddInstruction // TypeDefIndex: 50821
		{
			// Constructors
			public AddSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE0BC-0x00000001896EE1DC
		}
	
		private sealed class AddDouble : AddInstruction // TypeDefIndex: 50822
		{
			// Constructors
			public AddDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ECB68-0x00000001896ECC88
		}
	
		// Constructors
		private AddInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896ECC88-0x00000001896ED098
	}

	internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 50830
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896ED70C-0x00000001896ED738 
	
		// Nested types
		private sealed class AddOvfInt16 : AddOvfInstruction // TypeDefIndex: 50824
		{
			// Constructors
			public AddOvfInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ED738-0x00000001896ED92C
		}
	
		private sealed class AddOvfInt32 : AddOvfInstruction // TypeDefIndex: 50825
		{
			// Constructors
			public AddOvfInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896ED92C-0x00000001896EDAC4
		}
	
		private sealed class AddOvfInt64 : AddOvfInstruction // TypeDefIndex: 50826
		{
			// Constructors
			public AddOvfInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EDAC4-0x00000001896EDC34
		}
	
		private sealed class AddOvfUInt16 : AddOvfInstruction // TypeDefIndex: 50827
		{
			// Constructors
			public AddOvfUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EDC34-0x00000001896EDDE0
		}
	
		private sealed class AddOvfUInt32 : AddOvfInstruction // TypeDefIndex: 50828
		{
			// Constructors
			public AddOvfUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EDDE0-0x00000001896EDF50
		}
	
		private sealed class AddOvfUInt64 : AddOvfInstruction // TypeDefIndex: 50829
		{
			// Constructors
			public AddOvfUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EDF50-0x00000001896EE0BC
		}
	
		// Constructors
		private AddOvfInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896ED3F0-0x00000001896ED70C
	}

	internal abstract class AndInstruction : Instruction // TypeDefIndex: 50840
	{
		// Fields
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Int32; // 0x10
		private static Instruction s_Int64; // 0x18
		private static Instruction s_Byte; // 0x20
		private static Instruction s_UInt16; // 0x28
		private static Instruction s_UInt32; // 0x30
		private static Instruction s_UInt64; // 0x38
		private static Instruction s_Boolean; // 0x40
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896EEB48-0x00000001896EEB74 
	
		// Nested types
		private sealed class AndSByte : AndInstruction // TypeDefIndex: 50831
		{
			// Constructors
			public AndSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EED94-0x00000001896EEE44
		}
	
		private sealed class AndInt16 : AndInstruction // TypeDefIndex: 50832
		{
			// Constructors
			public AndInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EEB74-0x00000001896EEC24
		}
	
		private sealed class AndInt32 : AndInstruction // TypeDefIndex: 50833
		{
			// Constructors
			public AndInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EEC24-0x00000001896EECD4
		}
	
		private sealed class AndInt64 : AndInstruction // TypeDefIndex: 50834
		{
			// Constructors
			public AndInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EECD4-0x00000001896EED94
		}
	
		private sealed class AndByte : AndInstruction // TypeDefIndex: 50835
		{
			// Constructors
			public AndByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE608-0x00000001896EE6B8
		}
	
		private sealed class AndUInt16 : AndInstruction // TypeDefIndex: 50836
		{
			// Constructors
			public AndUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EEE44-0x00000001896EEEF4
		}
	
		private sealed class AndUInt32 : AndInstruction // TypeDefIndex: 50837
		{
			// Constructors
			public AndUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EEEF4-0x00000001896EEFB0
		}
	
		private sealed class AndUInt64 : AndInstruction // TypeDefIndex: 50838
		{
			// Constructors
			public AndUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EEFB0-0x00000001896EF070
		}
	
		private sealed class AndBoolean : AndInstruction // TypeDefIndex: 50839
		{
			// Constructors
			public AndBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896EE514-0x00000001896EE608
		}
	
		// Constructors
		private AndInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896EE6B8-0x00000001896EEB48
	}

	internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 50841
	{
		// Fields
		private readonly System.Type _elementType; // 0x10
		private readonly int _elementCount; // 0x18
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189700E60-0x0000000189700E8C 
	
		// Constructors
		public NewArrayInitInstruction() {} // Dummy constructor
		internal NewArrayInitInstruction(System.Type elementType, int elementCount) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189700DD8-0x0000000189700E60
	}

	internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 50842
	{
		// Fields
		private readonly System.Type _elementType; // 0x10
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189700F18-0x0000000189700F44 
	
		// Constructors
		public NewArrayInstruction() {} // Dummy constructor
		internal NewArrayInstruction(System.Type elementType) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189700E8C-0x0000000189700F18
	}

	internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 50843
	{
		// Fields
		private readonly System.Type _elementType; // 0x10
		private readonly int _rank; // 0x18
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189700B0C-0x0000000189700B38 
	
		// Constructors
		public NewArrayBoundsInstruction() {} // Dummy constructor
		internal NewArrayBoundsInstruction(System.Type elementType, int rank) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189700A00-0x0000000189700B0C
	}

	internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 50844
	{
		// Fields
		internal static readonly GetArrayItemInstruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001896FD200-0x00000001896FD22C 
	
		// Constructors
		private GetArrayItemInstruction() {} // 0x000000018350B670-0x000000018350B680
		static GetArrayItemInstruction() {} // 0x00000001896FD19C-0x00000001896FD200
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896FD108-0x00000001896FD19C
	}

	internal sealed class SetArrayItemInstruction : Instruction // TypeDefIndex: 50845
	{
		// Fields
		internal static readonly SetArrayItemInstruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000183D555E0-0x0000000183D555F0 
		public override string InstructionName { get => default; } // 0x0000000189701E6C-0x0000000189701E98 
	
		// Constructors
		private SetArrayItemInstruction() {} // 0x000000018350B670-0x000000018350B680
		static SetArrayItemInstruction() {} // 0x0000000189701E08-0x0000000189701E6C
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189701D54-0x0000000189701E08
	}

	internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 50846
	{
		// Fields
		public static readonly ArrayLengthInstruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001896EF160-0x00000001896EF18C 
	
		// Constructors
		private ArrayLengthInstruction() {} // 0x000000018350B670-0x000000018350B680
		static ArrayLengthInstruction() {} // 0x00000001896EF0FC-0x00000001896EF160
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896EF070-0x00000001896EF0FC
	}

	internal static class ConvertHelper // TypeDefIndex: 50847
	{
		// Methods
		public static int ToInt32NoNull(object val) => default; // 0x00000001896F1D54-0x00000001896F1E00
	}

	[IsReadOnly]
	internal struct RuntimeLabel // TypeDefIndex: 50848
	{
		// Fields
		public readonly int Index; // 0x00
		public readonly int StackDepth; // 0x04
		public readonly int ContinuationStackDepth; // 0x08
	
		// Constructors
		public RuntimeLabel(int index, int continuationStackDepth, int stackDepth) {
			Index = default;
			StackDepth = default;
			ContinuationStackDepth = default;
		} // 0x0000000183D75310-0x0000000183D75320
	
		// Methods
		public override string ToString() => default; // 0x00000001897016F0-0x00000001897017D8
	}

	internal sealed class BranchLabel // TypeDefIndex: 50849
	{
		// Fields
		private int _targetIndex; // 0x10
		private int _stackDepth; // 0x14
		private int _continuationStackDepth; // 0x18
		private List<int> _forwardBranchFixups; // 0x20
	
		// Properties
		internal int LabelIndex { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		internal bool HasRuntimeLabel { get => default; } // 0x00000001896F06C8-0x00000001896F06D4 
		internal int TargetIndex { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
	
		// Constructors
		public BranchLabel() {} // 0x0000000183D752C0-0x0000000183D752E0
	
		// Methods
		internal RuntimeLabel ToRuntimeLabel() => default; // 0x0000000183D752A0-0x0000000183D752C0
		internal void Mark(InstructionList instructions) {} // 0x00000001896F0540-0x00000001896F06C8
		internal void AddBranch(InstructionList instructions, int branchIndex) {} // 0x00000001896F0444-0x00000001896F0510
		internal void FixupBranch(InstructionList instructions, int branchIndex) {} // 0x00000001896F0510-0x00000001896F0540
	}

	internal abstract class CallInstruction : Instruction // TypeDefIndex: 50850
	{
		// Properties
		public abstract int ArgumentCount { get; }
		public override string InstructionName { get; } // 0x00000001896F153C-0x00000001896F1568 
		public override int ConsumedStack { get; } // 0x00000001896F152C-0x00000001896F153C 
	
		// Constructors
		protected CallInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static CallInstruction Create(MethodInfo info) => default; // 0x00000001896F0ECC-0x00000001896F0F1C
		public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) => default; // 0x00000001896F0F1C-0x00000001896F1074
		private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) => default; // 0x00000001896F1074-0x00000001896F1410
		public static void ArrayItemSetter1(Array array, int index0, object value) {} // 0x00000001896F0E44-0x00000001896F0E68
		public static void ArrayItemSetter2(Array array, int index0, int index1, object value) {} // 0x00000001896F0E68-0x00000001896F0E98
		public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) {} // 0x00000001896F0E98-0x00000001896F0ECC
		protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) {
			lightLambda = default;
			return default;
		} // 0x00000001896F146C-0x00000001896F152C
		protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) => default; // 0x00000001896F1410-0x00000001896F146C
	}

	internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 50851
	{
		// Fields
		protected readonly MethodInfo _target; // 0x10
		protected readonly int _argumentCount; // 0x18
	
		// Properties
		public override int ArgumentCount { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public override int ProducedStack { get => default; } // 0x0000000189700968-0x00000001897009F8 
	
		// Constructors
		public MethodInfoCallInstruction() {} // Dummy constructor
		internal MethodInfoCallInstruction(MethodInfo target, int argumentCount) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189700640-0x00000001897008F4
		protected object[] GetArgs(InterpretedFrame frame, int first, int skip) => default; // 0x000000018970054C-0x0000000189700640
		public override string ToString() => default; // 0x00000001897008F4-0x0000000189700968
	}

	internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 50852
	{
		// Fields
		private readonly ByRefUpdater[] _byrefArgs; // 0x20
	
		// Properties
		public override int ProducedStack { get => default; } // 0x00000001896F0DAC-0x00000001896F0E3C 
	
		// Constructors
		public ByRefMethodInfoCallInstruction() {} // Dummy constructor
		internal ByRefMethodInfoCallInstruction(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) {} // 0x0000000183020510-0x0000000183020540
	
		// Methods
		public sealed override int Run(InterpretedFrame frame) => default; // 0x00000001896F07F4-0x00000001896F0DAC
	}

	internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 50853
	{
		// Fields
		protected int _offset; // 0x10
	
		// Properties
		public abstract Instruction[] Cache { get; }
	
		// Constructors
		protected OffsetInstruction() {} // 0x0000000183D75270-0x0000000183D75280
	
		// Methods
		public Instruction Fixup(int offset) => default; // 0x0000000189700F98-0x0000000189701020
		public override string ToDebugString(int instructionIndex, object cookie, System.Func<int, int> labelIndexer, IReadOnlyList<object> objects) => default; // 0x0000000189701020-0x00000001897010C4
		public override string ToString() => default; // 0x00000001897010C4-0x0000000189701164
	}

	internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 50854
	{
		// Fields
		private static Instruction[] s_cache; // 0x00
	
		// Properties
		public override Instruction[] Cache { get => default; } // 0x00000001896F0148-0x00000001896F01D4 
		public override string InstructionName { get => default; } // 0x00000001896F01D4-0x00000001896F0200 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public BranchFalseInstruction() {} // 0x0000000183D75270-0x0000000183D75280
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F00E0-0x00000001896F0148
	}

	internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 50855
	{
		// Fields
		private static Instruction[] s_cache; // 0x00
	
		// Properties
		public override Instruction[] Cache { get => default; } // 0x00000001896F073C-0x00000001896F07C8 
		public override string InstructionName { get => default; } // 0x00000001896F07C8-0x00000001896F07F4 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public BranchTrueInstruction() {} // 0x0000000183D75270-0x0000000183D75280
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F06D4-0x00000001896F073C
	}

	internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 50856
	{
		// Fields
		private static Instruction[] s_cache; // 0x00
	
		// Properties
		public override Instruction[] Cache { get => default; } // 0x00000001896F167C-0x00000001896F1708 
		public override string InstructionName { get => default; } // 0x00000001896F1708-0x00000001896F1734 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public CoalescingBranchInstruction() {} // 0x0000000183D75270-0x0000000183D75280
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F1648-0x00000001896F167C
	}

	internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 50857
	{
		// Fields
		private static Instruction[][][] s_caches; // 0x00
		internal readonly bool _hasResult; // 0x18
		internal readonly bool _hasValue; // 0x19
	
		// Properties
		public override Instruction[] Cache { get => default; } // 0x00000001896F0200-0x00000001896F0400 
		public override string InstructionName { get => default; } // 0x00000001896F040C-0x00000001896F0438 
		public override int ConsumedStack { get => default; } // 0x00000001896F0400-0x00000001896F040C 
		public override int ProducedStack { get => default; } // 0x00000001896F0438-0x00000001896F0444 
	
		// Constructors
		internal BranchInstruction() {} // 0x0000000183D75280-0x0000000183D75290
		public BranchInstruction(bool hasResult, bool hasValue) {} // 0x0000000183D75290-0x0000000183D752A0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000183D4E340-0x0000000183D4E350
	}

	internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 50858
	{
		// Fields
		internal readonly int _labelIndex; // 0x10
	
		// Constructors
		protected IndexedBranchInstruction() {} // Dummy constructor
		public IndexedBranchInstruction(int labelIndex) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public RuntimeLabel GetLabel(InterpretedFrame frame) => default; // 0x00000001896FD864-0x00000001896FD8A0
		public override string ToDebugString(int instructionIndex, object cookie, System.Func<int, int> labelIndexer, IReadOnlyList<object> objects) => default; // 0x00000001896FD8A0-0x00000001896FD954
		public override string ToString() => default; // 0x00000001896FD954-0x00000001896FD9D0
	}

	internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 50859
	{
		// Fields
		private static readonly GotoInstruction[] s_cache; // 0x00
		private readonly bool _hasResult; // 0x18
		private readonly bool _hasValue; // 0x19
		private readonly bool _labelTargetGetsValue; // 0x1A
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896FD5F0-0x00000001896FD61C 
		public override int ConsumedStack { get => default; } // 0x00000001896F0400-0x00000001896F040C 
		public override int ProducedStack { get => default; } // 0x00000001896F0438-0x00000001896F0444 
	
		// Constructors
		public GotoInstruction() {} // Dummy constructor
		private GotoInstruction(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) {} // 0x0000000183D752F0-0x0000000183D75310
		static GotoInstruction() {} // 0x00000001896FD588-0x00000001896FD5F0
	
		// Methods
		internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) => default; // 0x00000001896FD394-0x00000001896FD4CC
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896FD4CC-0x00000001896FD588
	}

	internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 50860
	{
		// Fields
		private readonly bool _hasFinally; // 0x18
		private TryCatchFinallyHandler _tryHandler; // 0x20
	
		// Properties
		internal TryCatchFinallyHandler Handler { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public override int ProducedContinuations { get => default; } // 0x00000001896F0438-0x00000001896F0444 
		public override string InstructionName { get => default; } // 0x00000001896F41C4-0x00000001896F4210 
	
		// Constructors
		public EnterTryCatchFinallyInstruction() {} // Dummy constructor
		private EnterTryCatchFinallyInstruction(int targetIndex, bool hasFinally) {} // 0x0000000183D752E0-0x0000000183D752F0
	
		// Methods
		internal void SetTryHandler(TryCatchFinallyHandler tryHandler) {} // 0x0000000184271930-0x0000000184271940
		internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) => default; // 0x00000001896F3B1C-0x00000001896F3B64
		internal static EnterTryCatchFinallyInstruction CreateTryCatch() => default; // 0x00000001896F3AD4-0x00000001896F3B1C
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F3B64-0x00000001896F4148
		public override string ToString() => default; // 0x00000001896F4148-0x00000001896F41C4
	}

	internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 50861
	{
		// Fields
		private TryFaultHandler _tryHandler; // 0x18
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896F44F4-0x00000001896F4520 
		public override int ProducedContinuations { get => default; } // 0x0000000181168950-0x0000000181168960 
		internal TryFaultHandler Handler { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public EnterTryFaultInstruction() {} // Dummy constructor
		internal EnterTryFaultInstruction(int targetIndex) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		internal void SetTryHandler(TryFaultHandler tryHandler) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4210-0x00000001896F44F4
	}

	internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 50862
	{
		// Fields
		private static readonly EnterFinallyInstruction[] s_cache; // 0x00
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896F3AA8-0x00000001896F3AD4 
		public override int ProducedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ConsumedContinuations { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public EnterFinallyInstruction() {} // Dummy constructor
		private EnterFinallyInstruction(int labelIndex) {} // 0x00000001810410F0-0x0000000181041100
		static EnterFinallyInstruction() {} // 0x00000001896F3A40-0x00000001896F3AA8
	
		// Methods
		internal static EnterFinallyInstruction Create(int labelIndex) => default; // 0x00000001896F3918-0x00000001896F39EC
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F39EC-0x00000001896F3A40
	}

	internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 50863
	{
		// Fields
		internal static readonly Instruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override string InstructionName { get => default; } // 0x00000001896FF414-0x00000001896FF440 
	
		// Constructors
		private LeaveFinallyInstruction() {} // 0x000000018350B670-0x000000018350B680
		static LeaveFinallyInstruction() {} // 0x00000001896FF3B0-0x00000001896FF414
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896FF370-0x00000001896FF3B0
	}

	internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 50864
	{
		// Fields
		private static readonly EnterFaultInstruction[] s_cache; // 0x00
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896F38EC-0x00000001896F3918 
		public override int ProducedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public EnterFaultInstruction() {} // Dummy constructor
		private EnterFaultInstruction(int labelIndex) {} // 0x00000001810410F0-0x0000000181041100
		static EnterFaultInstruction() {} // 0x00000001896F3884-0x00000001896F38EC
	
		// Methods
		internal static EnterFaultInstruction Create(int labelIndex) => default; // 0x00000001896F3760-0x00000001896F3834
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F3834-0x00000001896F3884
	}

	internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 50865
	{
		// Fields
		internal static readonly Instruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ConsumedContinuations { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001896FF344-0x00000001896FF370 
	
		// Constructors
		private LeaveFaultInstruction() {} // 0x000000018350B670-0x000000018350B680
		static LeaveFaultInstruction() {} // 0x00000001896FF2E0-0x00000001896FF344
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896FF2B8-0x00000001896FF2E0
	}

	internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 50866
	{
		// Fields
		internal static readonly EnterExceptionFilterInstruction Instance; // 0x00
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896F3658-0x00000001896F3684 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		private EnterExceptionFilterInstruction() {} // 0x000000018350B670-0x000000018350B680
		static EnterExceptionFilterInstruction() {} // 0x00000001896F35F4-0x00000001896F3658
	
		// Methods
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame) => default; // 0x0000000181168950-0x0000000181168960
	}

	internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 50867
	{
		// Fields
		internal static readonly LeaveExceptionFilterInstruction Instance; // 0x00
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896FF0C8-0x00000001896FF0F4 
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		private LeaveExceptionFilterInstruction() {} // 0x000000018350B670-0x000000018350B680
		static LeaveExceptionFilterInstruction() {} // 0x00000001896FF064-0x00000001896FF0C8
	
		// Methods
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame) => default; // 0x0000000181168950-0x0000000181168960
	}

	internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 50868
	{
		// Fields
		internal static readonly EnterExceptionHandlerInstruction Void; // 0x00
		internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x08
		private readonly bool _hasValue; // 0x10
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896F3734-0x00000001896F3760 
		public override int ConsumedStack { get => default; } // 0x00000001896F3728-0x00000001896F3734 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public EnterExceptionHandlerInstruction() {} // Dummy constructor
		private EnterExceptionHandlerInstruction(bool hasValue) {} // 0x0000000183D4E960-0x0000000183D4E970
		static EnterExceptionHandlerInstruction() {} // 0x00000001896F3684-0x00000001896F3728
	
		// Methods
		[ExcludeFromCodeCoverage]
		public override int Run(InterpretedFrame frame) => default; // 0x0000000181168950-0x0000000181168960
	}

	internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 50869
	{
		// Fields
		private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x00
		private readonly bool _hasValue; // 0x18
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001896FF28C-0x00000001896FF2B8 
		public override int ConsumedStack { get => default; } // 0x00000001896F0438-0x00000001896F0444 
		public override int ProducedStack { get => default; } // 0x00000001896F0438-0x00000001896F0444 
	
		// Constructors
		public LeaveExceptionHandlerInstruction() {} // Dummy constructor
		private LeaveExceptionHandlerInstruction(int labelIndex, bool hasValue) {} // 0x0000000183D752E0-0x0000000183D752F0
		static LeaveExceptionHandlerInstruction() {} // 0x00000001896FF224-0x00000001896FF28C
	
		// Methods
		internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) => default; // 0x00000001896FF0F4-0x00000001896FF1F0
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896FF1F0-0x00000001896FF224
	}

	internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 50870
	{
		// Fields
		internal static readonly ThrowInstruction Throw; // 0x00
		internal static readonly ThrowInstruction VoidThrow; // 0x08
		internal static readonly ThrowInstruction Rethrow; // 0x10
		internal static readonly ThrowInstruction VoidRethrow; // 0x18
		private readonly bool _hasResult; // 0x10
		private readonly bool _rethrow; // 0x11
	
		// Properties
		public override string InstructionName { get => default; } // 0x0000000189703ED8-0x0000000189703F04 
		public override int ProducedStack { get => default; } // 0x00000001896F3728-0x00000001896F3734 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public ThrowInstruction() {} // Dummy constructor
		private ThrowInstruction(bool hasResult, bool isRethrow) {} // 0x0000000183D6E830-0x0000000183D6E840
		static ThrowInstruction() {} // 0x0000000189703DAC-0x0000000189703ED8
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189703C68-0x0000000189703D14
		private static Exception WrapThrownObject(object thrown) => default; // 0x0000000189703D14-0x0000000189703DAC
	}

	internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 50871
	{
		// Fields
		private readonly Dictionary<T, int> _cases;
	
		// Properties
		public override string InstructionName { get => default; }
		public override int ConsumedStack { get => default; }
	
		// Constructors
		public IntSwitchInstruction() {} // Dummy constructor
		internal IntSwitchInstruction(Dictionary<T, int> cases) {}
	
		// Methods
		public override int Run(InterpretedFrame frame) => default;
	}

	internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 50872
	{
		// Fields
		private readonly Dictionary<string, int> _cases; // 0x10
		private readonly StrongBox<int> _nullCase; // 0x18
	
		// Properties
		public override string InstructionName { get => default; } // 0x0000000189701F54-0x0000000189701F80 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public StringSwitchInstruction() {} // Dummy constructor
		internal StringSwitchInstruction(Dictionary<string, int> cases, StrongBox<int> nullCase) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189701E98-0x0000000189701F54
	}

	internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 50881
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896F2320-0x00000001896F234C 
	
		// Nested types
		private sealed class DecrementInt16 : DecrementInstruction // TypeDefIndex: 50873
		{
			// Constructors
			public DecrementInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F234C-0x00000001896F23D0
		}
	
		private sealed class DecrementInt32 : DecrementInstruction // TypeDefIndex: 50874
		{
			// Constructors
			public DecrementInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F23D0-0x00000001896F2448
		}
	
		private sealed class DecrementInt64 : DecrementInstruction // TypeDefIndex: 50875
		{
			// Constructors
			public DecrementInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2448-0x00000001896F24D8
		}
	
		private sealed class DecrementUInt16 : DecrementInstruction // TypeDefIndex: 50876
		{
			// Constructors
			public DecrementUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2570-0x00000001896F25F4
		}
	
		private sealed class DecrementUInt32 : DecrementInstruction // TypeDefIndex: 50877
		{
			// Constructors
			public DecrementUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F25F4-0x00000001896F2684
		}
	
		private sealed class DecrementUInt64 : DecrementInstruction // TypeDefIndex: 50878
		{
			// Constructors
			public DecrementUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2684-0x00000001896F2714
		}
	
		private sealed class DecrementSingle : DecrementInstruction // TypeDefIndex: 50879
		{
			// Constructors
			public DecrementSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F24D8-0x00000001896F2570
		}
	
		private sealed class DecrementDouble : DecrementInstruction // TypeDefIndex: 50880
		{
			// Constructors
			public DecrementDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F1E78-0x00000001896F1F10
		}
	
		// Constructors
		private DecrementInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896F1F10-0x00000001896F2320
	}

	internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 50882
	{
		// Fields
		private readonly System.Type _type; // 0x10
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001896F284C-0x00000001896F2878 
	
		// Constructors
		public DefaultValueInstruction() {} // Dummy constructor
		internal DefaultValueInstruction(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001896F27B4-0x00000001896F27EC
		public override string ToString() => default; // 0x00000001896F27EC-0x00000001896F284C
	}

	internal abstract class DivInstruction : Instruction // TypeDefIndex: 50891
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896F2DA0-0x00000001896F2DCC 
	
		// Nested types
		private sealed class DivInt16 : DivInstruction // TypeDefIndex: 50883
		{
			// Constructors
			public DivInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2DCC-0x00000001896F2EE0
		}
	
		private sealed class DivInt32 : DivInstruction // TypeDefIndex: 50884
		{
			// Constructors
			public DivInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2EE0-0x00000001896F2FE8
		}
	
		private sealed class DivInt64 : DivInstruction // TypeDefIndex: 50885
		{
			// Constructors
			public DivInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2FE8-0x00000001896F3100
		}
	
		private sealed class DivUInt16 : DivInstruction // TypeDefIndex: 50886
		{
			// Constructors
			public DivUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F3218-0x00000001896F332C
		}
	
		private sealed class DivUInt32 : DivInstruction // TypeDefIndex: 50887
		{
			// Constructors
			public DivUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F332C-0x00000001896F3440
		}
	
		private sealed class DivUInt64 : DivInstruction // TypeDefIndex: 50888
		{
			// Constructors
			public DivUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F3440-0x00000001896F3558
		}
	
		private sealed class DivSingle : DivInstruction // TypeDefIndex: 50889
		{
			// Constructors
			public DivSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F3100-0x00000001896F3218
		}
	
		private sealed class DivDouble : DivInstruction // TypeDefIndex: 50890
		{
			// Constructors
			public DivDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F2878-0x00000001896F2990
		}
	
		// Constructors
		private DivInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896F2990-0x00000001896F2DA0
	}

	internal abstract class EqualInstruction : Instruction // TypeDefIndex: 50917
	{
		// Fields
		private static Instruction s_reference; // 0x00
		private static Instruction s_Boolean; // 0x08
		private static Instruction s_SByte; // 0x10
		private static Instruction s_Int16; // 0x18
		private static Instruction s_Char; // 0x20
		private static Instruction s_Int32; // 0x28
		private static Instruction s_Int64; // 0x30
		private static Instruction s_Byte; // 0x38
		private static Instruction s_UInt16; // 0x40
		private static Instruction s_UInt32; // 0x48
		private static Instruction s_UInt64; // 0x50
		private static Instruction s_Single; // 0x58
		private static Instruction s_Double; // 0x60
		private static Instruction s_BooleanLiftedToNull; // 0x68
		private static Instruction s_SByteLiftedToNull; // 0x70
		private static Instruction s_Int16LiftedToNull; // 0x78
		private static Instruction s_CharLiftedToNull; // 0x80
		private static Instruction s_Int32LiftedToNull; // 0x88
		private static Instruction s_Int64LiftedToNull; // 0x90
		private static Instruction s_ByteLiftedToNull; // 0x98
		private static Instruction s_UInt16LiftedToNull; // 0xA0
		private static Instruction s_UInt32LiftedToNull; // 0xA8
		private static Instruction s_UInt64LiftedToNull; // 0xB0
		private static Instruction s_SingleLiftedToNull; // 0xB8
		private static Instruction s_DoubleLiftedToNull; // 0xC0
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896F5690-0x00000001896F56BC 
	
		// Nested types
		private sealed class EqualBoolean : EqualInstruction // TypeDefIndex: 50892
		{
			// Constructors
			public EqualBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F45D4-0x00000001896F4680
		}
	
		private sealed class EqualSByte : EqualInstruction // TypeDefIndex: 50893
		{
			// Constructors
			public EqualSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5BE0-0x00000001896F5C8C
		}
	
		private sealed class EqualInt16 : EqualInstruction // TypeDefIndex: 50894
		{
			// Constructors
			public EqualInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5770-0x00000001896F581C
		}
	
		private sealed class EqualChar : EqualInstruction // TypeDefIndex: 50895
		{
			// Constructors
			public EqualChar() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4894-0x00000001896F4940
		}
	
		private sealed class EqualInt32 : EqualInstruction // TypeDefIndex: 50896
		{
			// Constructors
			public EqualInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F58D0-0x00000001896F597C
		}
	
		private sealed class EqualInt64 : EqualInstruction // TypeDefIndex: 50897
		{
			// Constructors
			public EqualInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5A30-0x00000001896F5ADC
		}
	
		private sealed class EqualByte : EqualInstruction // TypeDefIndex: 50898
		{
			// Constructors
			public EqualByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4734-0x00000001896F47E0
		}
	
		private sealed class EqualUInt16 : EqualInstruction // TypeDefIndex: 50899
		{
			// Constructors
			public EqualUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5ECC-0x00000001896F5F78
		}
	
		private sealed class EqualUInt32 : EqualInstruction // TypeDefIndex: 50900
		{
			// Constructors
			public EqualUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F602C-0x00000001896F60D8
		}
	
		private sealed class EqualUInt64 : EqualInstruction // TypeDefIndex: 50901
		{
			// Constructors
			public EqualUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F618C-0x00000001896F6238
		}
	
		private sealed class EqualSingle : EqualInstruction // TypeDefIndex: 50902
		{
			// Constructors
			public EqualSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5D54-0x00000001896F5E18
		}
	
		private sealed class EqualDouble : EqualInstruction // TypeDefIndex: 50903
		{
			// Constructors
			public EqualDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4A08-0x00000001896F4ACC
		}
	
		private sealed class EqualReference : EqualInstruction // TypeDefIndex: 50904
		{
			// Constructors
			public EqualReference() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5ADC-0x00000001896F5B2C
		}
	
		private sealed class EqualBooleanLiftedToNull : EqualInstruction // TypeDefIndex: 50905
		{
			// Constructors
			public EqualBooleanLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4520-0x00000001896F45D4
		}
	
		private sealed class EqualSByteLiftedToNull : EqualInstruction // TypeDefIndex: 50906
		{
			// Constructors
			public EqualSByteLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5B2C-0x00000001896F5BE0
		}
	
		private sealed class EqualInt16LiftedToNull : EqualInstruction // TypeDefIndex: 50907
		{
			// Constructors
			public EqualInt16LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F56BC-0x00000001896F5770
		}
	
		private sealed class EqualCharLiftedToNull : EqualInstruction // TypeDefIndex: 50908
		{
			// Constructors
			public EqualCharLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F47E0-0x00000001896F4894
		}
	
		private sealed class EqualInt32LiftedToNull : EqualInstruction // TypeDefIndex: 50909
		{
			// Constructors
			public EqualInt32LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F581C-0x00000001896F58D0
		}
	
		private sealed class EqualInt64LiftedToNull : EqualInstruction // TypeDefIndex: 50910
		{
			// Constructors
			public EqualInt64LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F597C-0x00000001896F5A30
		}
	
		private sealed class EqualByteLiftedToNull : EqualInstruction // TypeDefIndex: 50911
		{
			// Constructors
			public EqualByteLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4680-0x00000001896F4734
		}
	
		private sealed class EqualUInt16LiftedToNull : EqualInstruction // TypeDefIndex: 50912
		{
			// Constructors
			public EqualUInt16LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5E18-0x00000001896F5ECC
		}
	
		private sealed class EqualUInt32LiftedToNull : EqualInstruction // TypeDefIndex: 50913
		{
			// Constructors
			public EqualUInt32LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5F78-0x00000001896F602C
		}
	
		private sealed class EqualUInt64LiftedToNull : EqualInstruction // TypeDefIndex: 50914
		{
			// Constructors
			public EqualUInt64LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F60D8-0x00000001896F618C
		}
	
		private sealed class EqualSingleLiftedToNull : EqualInstruction // TypeDefIndex: 50915
		{
			// Constructors
			public EqualSingleLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F5C8C-0x00000001896F5D54
		}
	
		private sealed class EqualDoubleLiftedToNull : EqualInstruction // TypeDefIndex: 50916
		{
			// Constructors
			public EqualDoubleLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896F4940-0x00000001896F4A08
		}
	
		// Constructors
		private EqualInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull) => default; // 0x00000001896F4ACC-0x00000001896F5690
	}

	internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 50927
	{
		// Fields
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Int32; // 0x10
		private static Instruction s_Int64; // 0x18
		private static Instruction s_Byte; // 0x20
		private static Instruction s_UInt16; // 0x28
		private static Instruction s_UInt32; // 0x30
		private static Instruction s_UInt64; // 0x38
		private static Instruction s_Boolean; // 0x40
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001896FA214-0x00000001896FA240 
	
		// Nested types
		private sealed class ExclusiveOrSByte : ExclusiveOrInstruction // TypeDefIndex: 50918
		{
			// Constructors
			public ExclusiveOrSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896FA460-0x00000001896FA510
		}
	
		private sealed class ExclusiveOrInt16 : ExclusiveOrInstruction // TypeDefIndex: 50919
		{
			// Constructors
			public ExclusiveOrInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896FA240-0x00000001896FA2F0
		}
	
		private sealed class ExclusiveOrInt32 : ExclusiveOrInstruction // TypeDefIndex: 50920
		{
			// Constructors
			public ExclusiveOrInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896FA2F0-0x00000001896FA3A0
		}
	
		private sealed class ExclusiveOrInt64 : ExclusiveOrInstruction // TypeDefIndex: 50921
		{
			// Constructors
			public ExclusiveOrInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001896FA3A0-0x00000001896FA460
		}
	
		private sealed class ExclusiveOrByte : ExclusiveOrInstruction // TypeDefIndex: 50922
		{
			// Constructors
			public ExclusiveOrByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706BF8-0x0000000189706CA8
		}
	
		private sealed class ExclusiveOrUInt16 : ExclusiveOrInstruction // TypeDefIndex: 50923
		{
			// Constructors
			public ExclusiveOrUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706CA8-0x0000000189706D58
		}
	
		private sealed class ExclusiveOrUInt32 : ExclusiveOrInstruction // TypeDefIndex: 50924
		{
			// Constructors
			public ExclusiveOrUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706D58-0x0000000189706E14
		}
	
		private sealed class ExclusiveOrUInt64 : ExclusiveOrInstruction // TypeDefIndex: 50925
		{
			// Constructors
			public ExclusiveOrUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706E14-0x0000000189706ED4
		}
	
		private sealed class ExclusiveOrBoolean : ExclusiveOrInstruction // TypeDefIndex: 50926
		{
			// Constructors
			public ExclusiveOrBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706B44-0x0000000189706BF8
		}
	
		// Constructors
		private ExclusiveOrInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x00000001896F9D84-0x00000001896FA214
	}

	internal abstract class FieldInstruction : Instruction // TypeDefIndex: 50928
	{
		// Fields
		protected readonly System.Reflection.FieldInfo _field; // 0x10
	
		// Constructors
		protected FieldInstruction() {} // Dummy constructor
		public FieldInstruction(System.Reflection.FieldInfo field) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override string ToString() => default; // 0x0000000189706ED4-0x0000000189706F60
	}

	internal sealed class LoadStaticFieldInstruction : FieldInstruction // TypeDefIndex: 50929
	{
		// Properties
		public override string InstructionName { get => default; } // 0x000000018971EF10-0x000000018971EF3C 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public LoadStaticFieldInstruction() {} // Dummy constructor
		public LoadStaticFieldInstruction(System.Reflection.FieldInfo field) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971EECC-0x000000018971EF10
	}

	internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 50930
	{
		// Properties
		public override string InstructionName { get => default; } // 0x000000018971EEA0-0x000000018971EECC 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public LoadFieldInstruction() {} // Dummy constructor
		public LoadFieldInstruction(System.Reflection.FieldInfo field) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971EE40-0x000000018971EEA0
	}

	internal sealed class StoreFieldInstruction : FieldInstruction // TypeDefIndex: 50931
	{
		// Properties
		public override string InstructionName { get => default; } // 0x000000018971EFF0-0x000000018971F01C 
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
		// Constructors
		public StoreFieldInstruction() {} // Dummy constructor
		public StoreFieldInstruction(System.Reflection.FieldInfo field) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971EF88-0x000000018971EFF0
	}

	internal sealed class StoreStaticFieldInstruction : FieldInstruction // TypeDefIndex: 50932
	{
		// Properties
		public override string InstructionName { get => default; } // 0x000000018971F060-0x000000018971F08C 
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public StoreStaticFieldInstruction() {} // Dummy constructor
		public StoreStaticFieldInstruction(System.Reflection.FieldInfo field) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971F01C-0x000000018971F060
	}

	internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 50944
	{
		// Fields
		private readonly object _nullValue; // 0x10
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Char; // 0x10
		private static Instruction s_Int32; // 0x18
		private static Instruction s_Int64; // 0x20
		private static Instruction s_Byte; // 0x28
		private static Instruction s_UInt16; // 0x30
		private static Instruction s_UInt32; // 0x38
		private static Instruction s_UInt64; // 0x40
		private static Instruction s_Single; // 0x48
		private static Instruction s_Double; // 0x50
		private static Instruction s_liftedToNullSByte; // 0x58
		private static Instruction s_liftedToNullInt16; // 0x60
		private static Instruction s_liftedToNullChar; // 0x68
		private static Instruction s_liftedToNullInt32; // 0x70
		private static Instruction s_liftedToNullInt64; // 0x78
		private static Instruction s_liftedToNullByte; // 0x80
		private static Instruction s_liftedToNullUInt16; // 0x88
		private static Instruction s_liftedToNullUInt32; // 0x90
		private static Instruction s_liftedToNullUInt64; // 0x98
		private static Instruction s_liftedToNullSingle; // 0xA0
		private static Instruction s_liftedToNullDouble; // 0xA8
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189707E3C-0x0000000189707E68 
	
		// Nested types
		private sealed class GreaterThanSByte : GreaterThanInstruction // TypeDefIndex: 50933
		{
			// Constructors
			public GreaterThanSByte() {} // Dummy constructor
			public GreaterThanSByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018970955C-0x0000000189709614
		}
	
		private sealed class GreaterThanInt16 : GreaterThanInstruction // TypeDefIndex: 50934
		{
			// Constructors
			public GreaterThanInt16() {} // Dummy constructor
			public GreaterThanInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189707E68-0x0000000189707F20
		}
	
		private sealed class GreaterThanChar : GreaterThanInstruction // TypeDefIndex: 50935
		{
			// Constructors
			public GreaterThanChar() {} // Dummy constructor
			public GreaterThanChar(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189707018-0x00000001897070D0
		}
	
		private sealed class GreaterThanInt32 : GreaterThanInstruction // TypeDefIndex: 50936
		{
			// Constructors
			public GreaterThanInt32() {} // Dummy constructor
			public GreaterThanInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189707F20-0x0000000189707FD8
		}
	
		private sealed class GreaterThanInt64 : GreaterThanInstruction // TypeDefIndex: 50937
		{
			// Constructors
			public GreaterThanInt64() {} // Dummy constructor
			public GreaterThanInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189707FD8-0x0000000189708090
		}
	
		private sealed class GreaterThanByte : GreaterThanInstruction // TypeDefIndex: 50938
		{
			// Constructors
			public GreaterThanByte() {} // Dummy constructor
			public GreaterThanByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189706F60-0x0000000189707018
		}
	
		private sealed class GreaterThanUInt16 : GreaterThanInstruction // TypeDefIndex: 50939
		{
			// Constructors
			public GreaterThanUInt16() {} // Dummy constructor
			public GreaterThanUInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897096D0-0x0000000189709788
		}
	
		private sealed class GreaterThanUInt32 : GreaterThanInstruction // TypeDefIndex: 50940
		{
			// Constructors
			public GreaterThanUInt32() {} // Dummy constructor
			public GreaterThanUInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709788-0x0000000189709840
		}
	
		private sealed class GreaterThanUInt64 : GreaterThanInstruction // TypeDefIndex: 50941
		{
			// Constructors
			public GreaterThanUInt64() {} // Dummy constructor
			public GreaterThanUInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709840-0x00000001897098F8
		}
	
		private sealed class GreaterThanSingle : GreaterThanInstruction // TypeDefIndex: 50942
		{
			// Constructors
			public GreaterThanSingle() {} // Dummy constructor
			public GreaterThanSingle(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709614-0x00000001897096D0
		}
	
		private sealed class GreaterThanDouble : GreaterThanInstruction // TypeDefIndex: 50943
		{
			// Constructors
			public GreaterThanDouble() {} // Dummy constructor
			public GreaterThanDouble(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897070D0-0x000000018970718C
		}
	
		// Constructors
		protected GreaterThanInstruction() {} // Dummy constructor
		private GreaterThanInstruction(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEABE */) => default; // 0x000000018970718C-0x0000000189707E3C
	}

	internal abstract class GreaterThanOrEqualInstruction : Instruction // TypeDefIndex: 50956
	{
		// Fields
		private readonly object _nullValue; // 0x10
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Char; // 0x10
		private static Instruction s_Int32; // 0x18
		private static Instruction s_Int64; // 0x20
		private static Instruction s_Byte; // 0x28
		private static Instruction s_UInt16; // 0x30
		private static Instruction s_UInt32; // 0x38
		private static Instruction s_UInt64; // 0x40
		private static Instruction s_Single; // 0x48
		private static Instruction s_Double; // 0x50
		private static Instruction s_liftedToNullSByte; // 0x58
		private static Instruction s_liftedToNullInt16; // 0x60
		private static Instruction s_liftedToNullChar; // 0x68
		private static Instruction s_liftedToNullInt32; // 0x70
		private static Instruction s_liftedToNullInt64; // 0x78
		private static Instruction s_liftedToNullByte; // 0x80
		private static Instruction s_liftedToNullUInt16; // 0x88
		private static Instruction s_liftedToNullUInt32; // 0x90
		private static Instruction s_liftedToNullUInt64; // 0x98
		private static Instruction s_liftedToNullSingle; // 0xA0
		private static Instruction s_liftedToNullDouble; // 0xA8
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189708F6C-0x0000000189708F98 
	
		// Nested types
		private sealed class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction // TypeDefIndex: 50945
		{
			// Constructors
			public GreaterThanOrEqualSByte() {} // Dummy constructor
			public GreaterThanOrEqualSByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897091C0-0x0000000189709278
		}
	
		private sealed class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 50946
		{
			// Constructors
			public GreaterThanOrEqualInt16() {} // Dummy constructor
			public GreaterThanOrEqualInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189708F98-0x0000000189709050
		}
	
		private sealed class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction // TypeDefIndex: 50947
		{
			// Constructors
			public GreaterThanOrEqualChar() {} // Dummy constructor
			public GreaterThanOrEqualChar(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189708148-0x0000000189708200
		}
	
		private sealed class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 50948
		{
			// Constructors
			public GreaterThanOrEqualInt32() {} // Dummy constructor
			public GreaterThanOrEqualInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709050-0x0000000189709108
		}
	
		private sealed class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 50949
		{
			// Constructors
			public GreaterThanOrEqualInt64() {} // Dummy constructor
			public GreaterThanOrEqualInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709108-0x00000001897091C0
		}
	
		private sealed class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction // TypeDefIndex: 50950
		{
			// Constructors
			public GreaterThanOrEqualByte() {} // Dummy constructor
			public GreaterThanOrEqualByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189708090-0x0000000189708148
		}
	
		private sealed class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 50951
		{
			// Constructors
			public GreaterThanOrEqualUInt16() {} // Dummy constructor
			public GreaterThanOrEqualUInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709334-0x00000001897093EC
		}
	
		private sealed class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 50952
		{
			// Constructors
			public GreaterThanOrEqualUInt32() {} // Dummy constructor
			public GreaterThanOrEqualUInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897093EC-0x00000001897094A4
		}
	
		private sealed class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 50953
		{
			// Constructors
			public GreaterThanOrEqualUInt64() {} // Dummy constructor
			public GreaterThanOrEqualUInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897094A4-0x000000018970955C
		}
	
		private sealed class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction // TypeDefIndex: 50954
		{
			// Constructors
			public GreaterThanOrEqualSingle() {} // Dummy constructor
			public GreaterThanOrEqualSingle(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709278-0x0000000189709334
		}
	
		private sealed class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction // TypeDefIndex: 50955
		{
			// Constructors
			public GreaterThanOrEqualDouble() {} // Dummy constructor
			public GreaterThanOrEqualDouble(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189708200-0x00000001897082BC
		}
	
		// Constructors
		protected GreaterThanOrEqualInstruction() {} // Dummy constructor
		private GreaterThanOrEqualInstruction(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEABF */) => default; // 0x00000001897082BC-0x0000000189708F6C
	}

	internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 50965
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189709DA0-0x0000000189709DCC 
	
		// Nested types
		private sealed class IncrementInt16 : IncrementInstruction // TypeDefIndex: 50957
		{
			// Constructors
			public IncrementInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709DCC-0x0000000189709E50
		}
	
		private sealed class IncrementInt32 : IncrementInstruction // TypeDefIndex: 50958
		{
			// Constructors
			public IncrementInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709E50-0x0000000189709EC8
		}
	
		private sealed class IncrementInt64 : IncrementInstruction // TypeDefIndex: 50959
		{
			// Constructors
			public IncrementInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709EC8-0x0000000189709F58
		}
	
		private sealed class IncrementUInt16 : IncrementInstruction // TypeDefIndex: 50960
		{
			// Constructors
			public IncrementUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709FF0-0x000000018970A074
		}
	
		private sealed class IncrementUInt32 : IncrementInstruction // TypeDefIndex: 50961
		{
			// Constructors
			public IncrementUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018970A074-0x000000018970A104
		}
	
		private sealed class IncrementUInt64 : IncrementInstruction // TypeDefIndex: 50962
		{
			// Constructors
			public IncrementUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018970A104-0x000000018970A194
		}
	
		private sealed class IncrementSingle : IncrementInstruction // TypeDefIndex: 50963
		{
			// Constructors
			public IncrementSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189709F58-0x0000000189709FF0
		}
	
		private sealed class IncrementDouble : IncrementInstruction // TypeDefIndex: 50964
		{
			// Constructors
			public IncrementDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897098F8-0x0000000189709990
		}
	
		// Constructors
		private IncrementInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189709990-0x0000000189709DA0
	}

	internal abstract class Instruction // TypeDefIndex: 50966
	{
		// Properties
		public virtual int ConsumedStack { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual int ProducedStack { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual int ConsumedContinuations { get; } // 0x0000000181002730-0x0000000181002740 
		public virtual int ProducedContinuations { get; } // 0x0000000181002730-0x0000000181002740 
		public int StackBalance { get; } // 0x000000018970E0B8-0x000000018970E0F0 
		public int ContinuationsBalance { get; } // 0x000000018970E080-0x000000018970E0B8 
		public abstract string InstructionName { get; }
	
		// Constructors
		protected Instruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract int Run(InterpretedFrame frame);
		public override string ToString() => default; // 0x000000018970E034-0x000000018970E080
		public virtual string ToDebugString(int instructionIndex, object cookie, System.Func<int, int> labelIndexer, IReadOnlyList<object> objects) => default; // 0x00000001892147CC-0x00000001892147DC
		protected static void NullCheck(object o) {} // 0x00000001887D836C-0x00000001887D8380
	}

	[DebuggerTypeProxy(typeof(DebugView))]
	[IsReadOnly]
	internal struct InstructionArray // TypeDefIndex: 50968
	{
		// Fields
		internal readonly int MaxStackDepth; // 0x00
		internal readonly int MaxContinuationDepth; // 0x04
		internal readonly Instruction[] Instructions; // 0x08
		internal readonly object[] Objects; // 0x10
		internal readonly RuntimeLabel[] Labels; // 0x18
		internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20
	
		// Nested types
		internal sealed class DebugView // TypeDefIndex: 50967
		{
			// Fields
			private readonly InstructionArray _array; // 0x10
	
			// Constructors
			public DebugView() {} // Dummy constructor
			public DebugView(InstructionArray array) {} // 0x0000000189706910-0x00000001897069F8
	
			// Methods
			public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = false /* Metadata: 0x01FCEAC0 */) => default; // 0x0000000189706824-0x00000001897068E0
		}
	
		// Constructors
		internal InstructionArray(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) {
			MaxStackDepth = default;
			MaxContinuationDepth = default;
			Instructions = default;
			Objects = default;
			Labels = default;
			DebugCookies = default;
		} // 0x000000018970A194-0x000000018970A1E8
	}

	[DebuggerTypeProxy(typeof(DebugView))]
	internal sealed class InstructionList // TypeDefIndex: 50971
	{
		// Fields
		private readonly List<Instruction> _instructions; // 0x10
		private List<object> _objects; // 0x18
		private int _currentStackDepth; // 0x20
		private int _maxStackDepth; // 0x24
		private int _currentContinuationsDepth; // 0x28
		private int _maxContinuationDepth; // 0x2C
		private int _runtimeLabelCount; // 0x30
		private List<BranchLabel> _labels; // 0x38
		private List<KeyValuePair<int, object>> _debugCookies; // 0x40
		private static Instruction s_null; // 0x00
		private static Instruction s_true; // 0x08
		private static Instruction s_false; // 0x10
		private static Instruction[] s_Ints; // 0x18
		private static Instruction[] s_loadObjectCached; // 0x20
		private static Instruction[] s_loadLocal; // 0x28
		private static Instruction[] s_loadLocalBoxed; // 0x30
		private static Instruction[] s_loadLocalFromClosure; // 0x38
		private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
		private static Instruction[] s_assignLocal; // 0x48
		private static Instruction[] s_storeLocal; // 0x50
		private static Instruction[] s_assignLocalBoxed; // 0x58
		private static Instruction[] s_storeLocalBoxed; // 0x60
		private static Instruction[] s_assignLocalToClosure; // 0x68
		private static readonly Dictionary<System.Reflection.FieldInfo, Instruction> s_loadFields; // 0x70
		private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78
	
		// Properties
		public int Count { get => default; } // 0x000000018970DFB8-0x000000018970DFF8 
		public int CurrentStackDepth { get => default; } // 0x0000000181003B50-0x0000000181003B60 
		public int CurrentContinuationsDepth { get => default; } // 0x0000000183D4EB90-0x0000000183D4EBA0 
	
		// Nested types
		internal sealed class DebugView // TypeDefIndex: 50970
		{
			// Nested types
			[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
			[IsReadOnly]
			internal struct InstructionView // TypeDefIndex: 50969
			{
				// Fields
				private readonly int _index; // 0x00
				private readonly int _stackDepth; // 0x04
				private readonly int _continuationsDepth; // 0x08
				private readonly string _name; // 0x10
				private readonly Instruction _instruction; // 0x18
	
				// Constructors
				public InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) {
					_index = default;
					_stackDepth = default;
					_continuationsDepth = default;
					_name = default;
					_instruction = default;
				} // 0x000000018970DFF8-0x000000018970E034
	
				// Methods
				internal string GetValue() => default; // 0x00000001820B7B20-0x00000001820B7B30
			}
	
			// Constructors
			public DebugView() {} // Dummy constructor
	
			// Methods
			internal static InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<object> objects, System.Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, object>> debugCookies) => default; // 0x0000000189706524-0x0000000189706824
		}
	
		// Constructors
		public InstructionList() {} // 0x000000018970DF40-0x000000018970DFB8
		static InstructionList() {} // 0x000000018970DE30-0x000000018970DF40
	
		// Methods
		public void Emit(Instruction instruction) {} // 0x000000018970D1C0-0x000000018970D224
		private void UpdateStackDepth(Instruction instruction) {} // 0x000000018970DDA4-0x000000018970DE30
		public void UnEmit() {} // 0x000000018970DCB0-0x000000018970DDA4
		internal Instruction GetInstruction(int index) => default; // 0x000000018970D31C-0x000000018970D370
		public InstructionArray ToArray() => default; // 0x000000018970DBC8-0x000000018970DCB0
		public void EmitLoad(object value) {} // 0x000000018970C578-0x000000018970C584
		public void EmitLoad(bool value) {} // 0x000000018970C3E0-0x000000018970C578
		public void EmitLoad(object value, System.Type type) {} // 0x000000018970BF1C-0x000000018970C3E0
		public void EmitDup() {} // 0x000000018970B150-0x000000018970B1A4
		public void EmitPop() {} // 0x000000018970CAA8-0x000000018970CAFC
		internal void SwitchToBoxed(int index, int instructionIndex) {} // 0x000000018970DB10-0x000000018970DBC8
		public void EmitLoadLocal(int index) {} // 0x000000018970BD68-0x000000018970BF1C
		public void EmitLoadLocalBoxed(int index) {} // 0x000000018970B9A8-0x000000018970BA00
		internal static Instruction LoadLocalBoxed(int index) => default; // 0x000000018970D624-0x000000018970D7B8
		public void EmitLoadLocalFromClosure(int index) {} // 0x000000018970BBB4-0x000000018970BD68
		public void EmitLoadLocalFromClosureBoxed(int index) {} // 0x000000018970BA00-0x000000018970BBB4
		public void EmitAssignLocal(int index) {} // 0x000000018970A860-0x000000018970AA14
		public void EmitStoreLocal(int index) {} // 0x000000018970CD58-0x000000018970CF0C
		public void EmitAssignLocalBoxed(int index) {} // 0x000000018970A654-0x000000018970A6AC
		internal static Instruction AssignLocalBoxed(int index) => default; // 0x000000018970A1E8-0x000000018970A37C
		public void EmitStoreLocalBoxed(int index) {} // 0x000000018970CCE0-0x000000018970CD38
		internal static Instruction StoreLocalBoxed(int index) => default; // 0x000000018970D97C-0x000000018970DB10
		public void EmitAssignLocalToClosure(int index) {} // 0x000000018970A6AC-0x000000018970A860
		public void EmitStoreLocalToClosure(int index) {} // 0x000000018970CD38-0x000000018970CD58
		public void EmitInitializeLocal(int index, System.Type type) {} // 0x000000018970B628-0x000000018970B720
		internal void EmitInitializeParameter(int index) {} // 0x000000018970B720-0x000000018970B778
		internal static Instruction Parameter(int index) => default; // 0x000000018970D938-0x000000018970D97C
		internal static Instruction ParameterBox(int index) => default; // 0x000000018970D8F4-0x000000018970D938
		internal static Instruction InitReference(int index) => default; // 0x000000018970D5E0-0x000000018970D624
		internal static Instruction InitImmutableRefBox(int index) => default; // 0x000000018970D59C-0x000000018970D5E0
		public void EmitNewRuntimeVariables(int count) {} // 0x000000018970C7D0-0x000000018970C830
		public void EmitGetArrayItem() {} // 0x000000018970B4AC-0x000000018970B500
		public void EmitSetArrayItem() {} // 0x000000018970CBD0-0x000000018970CC24
		public void EmitNewArray(System.Type elementType) {} // 0x000000018970C758-0x000000018970C7D0
		public void EmitNewArrayBounds(System.Type elementType, int rank) {} // 0x000000018970C648-0x000000018970C6D0
		public void EmitNewArrayInit(System.Type elementType, int elementCount) {} // 0x000000018970C6D0-0x000000018970C758
		public void EmitAdd(System.Type type, bool @checked) {} // 0x000000018970A594-0x000000018970A5D4
		public void EmitSub(System.Type type, bool @checked) {} // 0x000000018970CF94-0x000000018970CFD4
		public void EmitMul(System.Type type, bool @checked) {} // 0x000000018970C5B0-0x000000018970C5F0
		public void EmitDiv(System.Type type) {} // 0x000000018970B124-0x000000018970B150
		public void EmitModulo(System.Type type) {} // 0x000000018970C584-0x000000018970C5B0
		public void EmitExclusiveOr(System.Type type) {} // 0x000000018970B480-0x000000018970B4AC
		public void EmitAnd(System.Type type) {} // 0x000000018970A5D4-0x000000018970A600
		public void EmitOr(System.Type type) {} // 0x000000018970CA7C-0x000000018970CAA8
		public void EmitLeftShift(System.Type type) {} // 0x000000018970B8F0-0x000000018970B91C
		public void EmitRightShift(System.Type type) {} // 0x000000018970CBA4-0x000000018970CBD0
		public void EmitEqual(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEAC1 */) {} // 0x000000018970B44C-0x000000018970B480
		public void EmitNotEqual(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEAC2 */) {} // 0x000000018970C8BC-0x000000018970C8F0
		public void EmitLessThan(System.Type type, bool liftedToNull) {} // 0x000000018970B950-0x000000018970B984
		public void EmitLessThanOrEqual(System.Type type, bool liftedToNull) {} // 0x000000018970B91C-0x000000018970B950
		public void EmitGreaterThan(System.Type type, bool liftedToNull) {} // 0x000000018970B5C8-0x000000018970B5FC
		public void EmitGreaterThanOrEqual(System.Type type, bool liftedToNull) {} // 0x000000018970B594-0x000000018970B5C8
		public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) {} // 0x000000018970C97C-0x000000018970C9FC
		public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) {} // 0x000000018970C9FC-0x000000018970CA7C
		public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) {} // 0x000000018970AF94-0x000000018970B008
		public void EmitCast(System.Type toType) {} // 0x000000018970AF00-0x000000018970AF2C
		public void EmitCastToEnum(System.Type toType) {} // 0x000000018970AE88-0x000000018970AF00
		public void EmitCastReferenceToEnum(System.Type toType) {} // 0x000000018970AE10-0x000000018970AE88
		public void EmitNot(System.Type type) {} // 0x000000018970C8F0-0x000000018970C91C
		public void EmitDefaultValue(System.Type type) {} // 0x000000018970B0AC-0x000000018970B124
		public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) {} // 0x000000018970C830-0x000000018970C8BC
		public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) {} // 0x000000018970ACE0-0x000000018970AD80
		internal void EmitCreateDelegate(LightDelegateCreator creator) {} // 0x000000018970B008-0x000000018970B080
		public void EmitTypeEquals() {} // 0x000000018970D0F4-0x000000018970D148
		public void EmitArrayLength() {} // 0x000000018970A600-0x000000018970A654
		public void EmitNegate(System.Type type) {} // 0x000000018970C61C-0x000000018970C648
		public void EmitNegateChecked(System.Type type) {} // 0x000000018970C5F0-0x000000018970C61C
		public void EmitIncrement(System.Type type) {} // 0x000000018970B5FC-0x000000018970B628
		public void EmitDecrement(System.Type type) {} // 0x000000018970B080-0x000000018970B0AC
		public void EmitTypeIs(System.Type type) {} // 0x000000018970D148-0x000000018970D1C0
		public void EmitTypeAs(System.Type type) {} // 0x000000018970D07C-0x000000018970D0F4
		public void EmitLoadField(System.Reflection.FieldInfo field) {} // 0x000000018970B984-0x000000018970B9A8
		private Instruction GetLoadField(System.Reflection.FieldInfo field) => default; // 0x000000018970D370-0x000000018970D59C
		public void EmitStoreField(System.Reflection.FieldInfo field) {} // 0x000000018970CC24-0x000000018970CCE0
		public void EmitCall(MethodInfo method) {} // 0x000000018970ADB0-0x000000018970AE10
		public void EmitCall(MethodInfo method, ParameterInfo[] parameters) {} // 0x000000018970AD80-0x000000018970ADB0
		public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) {} // 0x000000018970AC24-0x000000018970ACE0
		public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) {} // 0x000000018970C91C-0x000000018970C97C
		private RuntimeLabel[] BuildRuntimeLabels() => default; // 0x000000018970A37C-0x000000018970A594
		public BranchLabel MakeLabel() => default; // 0x000000018970D7B8-0x000000018970D890
		internal void FixupBranch(int branchIndex, int offset) {} // 0x000000018970D250-0x000000018970D31C
		private int EnsureLabelIndex(BranchLabel label) => default; // 0x000000018970D224-0x000000018970D250
		public int MarkRuntimeLabel() => default; // 0x000000018970D8B4-0x000000018970D8F4
		public void MarkLabel(BranchLabel label) {} // 0x000000018970D890-0x000000018970D8B4
		public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) {} // 0x000000018970B500-0x000000018970B594
		private void EmitBranch(OffsetInstruction instruction, BranchLabel label) {} // 0x000000018970ABD8-0x000000018970AC24
		public void EmitBranch(BranchLabel label) {} // 0x000000018970AAE4-0x000000018970AB50
		public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) {} // 0x000000018970AB50-0x000000018970ABD8
		public void EmitCoalescingBranch(BranchLabel leftNotNull) {} // 0x000000018970AF2C-0x000000018970AF94
		public void EmitBranchTrue(BranchLabel elseLabel) {} // 0x000000018970AA7C-0x000000018970AAE4
		public void EmitBranchFalse(BranchLabel elseLabel) {} // 0x000000018970AA14-0x000000018970AA7C
		public void EmitThrow() {} // 0x000000018970D028-0x000000018970D07C
		public void EmitThrowVoid() {} // 0x000000018970CFD4-0x000000018970D028
		public void EmitRethrow() {} // 0x000000018970CB50-0x000000018970CBA4
		public void EmitRethrowVoid() {} // 0x000000018970CAFC-0x000000018970CB50
		public void EmitEnterTryFinally(BranchLabel finallyStartLabel) {} // 0x000000018970B41C-0x000000018970B44C
		public void EmitEnterTryCatch() {} // 0x000000018970B378-0x000000018970B39C
		public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) => default; // 0x000000018970B39C-0x000000018970B41C
		public void EmitEnterFinally(BranchLabel finallyStartLabel) {} // 0x000000018970B30C-0x000000018970B378
		public void EmitLeaveFinally() {} // 0x000000018970B89C-0x000000018970B8F0
		public void EmitEnterFault(BranchLabel faultStartLabel) {} // 0x000000018970B2A0-0x000000018970B30C
		public void EmitLeaveFault() {} // 0x000000018970B848-0x000000018970B89C
		public void EmitEnterExceptionFilter() {} // 0x000000018970B1A4-0x000000018970B1F8
		public void EmitLeaveExceptionFilter() {} // 0x000000018970B778-0x000000018970B7CC
		public void EmitEnterExceptionHandlerNonVoid() {} // 0x000000018970B1F8-0x000000018970B24C
		public void EmitEnterExceptionHandlerVoid() {} // 0x000000018970B24C-0x000000018970B2A0
		public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) {} // 0x000000018970B7CC-0x000000018970B848
		public void EmitIntSwitch<T>(Dictionary<T, int> cases) {}
		public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) {} // 0x000000018970CF0C-0x000000018970CF94
	}

	internal sealed class InterpretedFrame // TypeDefIndex: 50973
	{
		// Fields
		[ThreadStatic]
		private static InterpretedFrame s_currentFrame; // 0x80000000
		internal readonly Interpreter Interpreter; // 0x10
		internal InterpretedFrame _parent; // 0x18
		private readonly int[] _continuations; // 0x20
		private int _continuationIndex; // 0x28
		private int _pendingContinuation; // 0x2C
		private object _pendingValue; // 0x30
		public readonly object[] Data; // 0x38
		public readonly IStrongBox[] Closure; // 0x40
		public int StackIndex; // 0x48
		public int InstructionIndex; // 0x4C
	
		// Properties
		public string Name { get => default; } // 0x0000000185CD368C-0x0000000185CD36A8 
		public InterpretedFrame Parent { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public InterpretedFrame() {} // Dummy constructor
		internal InterpretedFrame(Interpreter interpreter, IStrongBox[] closure) {} // 0x000000018970ED40-0x000000018970EE3C
	
		// Methods
		public DebugInfo GetDebugInfo(int instructionIndex) => default; // 0x000000018970E260-0x000000018970E2C4
		public void Push(object value) {} // 0x000000018970E604-0x000000018970E654
		public void Push(bool value) {} // 0x000000018970E87C-0x000000018970E920
		public void Push(int value) {} // 0x000000018970E81C-0x000000018970E87C
		public void Push(byte value) {} // 0x000000018970E6EC-0x000000018970E784
		public void Push(sbyte value) {} // 0x000000018970E784-0x000000018970E81C
		public void Push(short value) {} // 0x000000018970E654-0x000000018970E6EC
		public void Push(ushort value) {} // 0x000000018970E920-0x000000018970E9B8
		public object Pop() => default; // 0x000000018970E520-0x000000018970E558
		internal void SetStackDepth(int depth) {} // 0x000000018970EB14-0x000000018970EB38
		public object Peek() => default; // 0x000000018970E490-0x000000018970E4C0
		public void Dup() {} // 0x000000018970E164-0x000000018970E1D8
		[IteratorStateMachine(typeof(_GetStackTraceDebugInfo_d__29))]
		public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() => default; // 0x000000018970E2C4-0x000000018970E334
		internal void SaveTraceToException(Exception exception) {} // 0x000000018970E9B8-0x000000018970EB14
		internal InterpretedFrame Enter() => default; // 0x000000018970E1D8-0x000000018970E260
		internal void Leave(InterpretedFrame prevFrame) {} // 0x000000018970E434-0x000000018970E490
		internal bool IsJumpHappened() => default; // 0x0000000182F4C630-0x0000000182F4C640
		public void RemoveContinuation() {} // 0x0000000183D69B40-0x0000000183D69B50
		public void PushContinuation(int continuation) {} // 0x000000018970E558-0x000000018970E58C
		public int YieldToCurrentContinuation() => default; // 0x000000018970EB38-0x000000018970EBB4
		public int YieldToPendingContinuation() => default; // 0x000000018970EBB4-0x000000018970ED40
		internal void PushPendingContinuation() {} // 0x000000018970E58C-0x000000018970E604
		internal void PopPendingContinuation() {} // 0x000000018970E4C0-0x000000018970E520
		public int Goto(int labelIndex, object value, bool gotoExceptionHandler) => default; // 0x000000018970E334-0x000000018970E434
	}

	internal sealed class Interpreter // TypeDefIndex: 50974
	{
		// Fields
		internal static readonly object NoValue; // 0x00
		private readonly InstructionArray _instructions; // 0x10
		internal readonly object[] _objects; // 0x38
		internal readonly RuntimeLabel[] _labels; // 0x40
		internal readonly DebugInfo[] _debugInfos; // 0x48
	
		// Properties
		internal string Name { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		internal int LocalCount { get; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		internal int ClosureSize { get => default; } // 0x000000018970EFB4-0x000000018970EFF4 
		internal InstructionArray Instructions { get => default; } // 0x00000001820B6ED0-0x00000001820B6EF0 
		internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Constructors
		public Interpreter() {} // Dummy constructor
		internal Interpreter(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) {} // 0x000000018970EF10-0x000000018970EFB4
		static Interpreter() {} // 0x000000018970EEA0-0x000000018970EF10
	
		// Methods
		public void Run(InterpretedFrame frame) {} // 0x000000018970EE3C-0x000000018970EEA0
	}

	internal sealed class LabelInfo // TypeDefIndex: 50976
	{
		// Fields
		private readonly LabelTarget _node; // 0x10
		private BranchLabel _label; // 0x18
		private object _definitions; // 0x20
		private readonly List<LabelScopeInfo> _references; // 0x28
		private bool _acrossBlockJump; // 0x30
	
		// Properties
		private bool HasDefinitions { get => default; } // 0x0000000188571E40-0x0000000188571E4C 
		private bool HasMultipleDefinitions { get => default; } // 0x000000018970FB4C-0x000000018970FB90 
	
		// Constructors
		public LabelInfo() {} // Dummy constructor
		internal LabelInfo(LabelTarget node) {} // 0x000000018970FABC-0x000000018970FB4C
	
		// Methods
		internal BranchLabel GetLabel(LightCompiler compiler) => default; // 0x000000018970F6D4-0x000000018970F6F0
		internal void Reference(LabelScopeInfo block) {} // 0x000000018970F6F0-0x000000018970F75C
		internal void Define(LabelScopeInfo block) {} // 0x000000018970F110-0x000000018970F390
		private void ValidateJump(LabelScopeInfo reference) {} // 0x000000018970F7D4-0x000000018970FABC
		internal void ValidateFinish() {} // 0x000000018970F75C-0x000000018970F7D4
		private void EnsureLabel(LightCompiler compiler) {} // 0x000000018970F408-0x000000018970F448
		private bool DefinedIn(LabelScopeInfo scope) => default; // 0x000000018970F390-0x000000018970F408
		private LabelScopeInfo FirstDefinition() => default; // 0x000000018970F448-0x000000018970F6D4
		private void AddDefinition(LabelScopeInfo scope) {} // 0x000000018970EFF4-0x000000018970F110
		internal static T CommonNode<T>(T first, T second, System.Func<T, T> parent)
			where T : class => default;
	}

	internal enum LabelScopeKind // TypeDefIndex: 50977
	{
		Statement = 0,
		Block = 1,
		Switch = 2,
		Lambda = 3,
		Try = 4,
		Catch = 5,
		Finally = 6,
		Filter = 7,
		Expression = 8
	}

	internal sealed class LabelScopeInfo // TypeDefIndex: 50978
	{
		// Fields
		private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
		internal readonly LabelScopeKind Kind; // 0x18
		internal readonly LabelScopeInfo Parent; // 0x20
	
		// Properties
		internal bool CanJumpInto { get => default; } // 0x000000018970FD20-0x000000018970FD28 
	
		// Constructors
		public LabelScopeInfo() {} // Dummy constructor
		internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) {} // 0x000000018970FD00-0x000000018970FD20
	
		// Methods
		internal bool ContainsTarget(LabelTarget target) => default; // 0x000000018970FC34-0x000000018970FC8C
		internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) {
			info = default;
			return default;
		} // 0x000000018970FC8C-0x000000018970FD00
		internal void AddLabelInfo(LabelTarget target, LabelInfo info) {} // 0x000000018970FB90-0x000000018970FC34
	}

	internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 50987
	{
		// Fields
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Int32; // 0x10
		private static Instruction s_Int64; // 0x18
		private static Instruction s_Byte; // 0x20
		private static Instruction s_UInt16; // 0x28
		private static Instruction s_UInt32; // 0x30
		private static Instruction s_UInt64; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001897101F8-0x0000000189710224 
	
		// Nested types
		private sealed class LeftShiftSByte : LeftShiftInstruction // TypeDefIndex: 50979
		{
			// Constructors
			public LeftShiftSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189710468-0x0000000189710528
		}
	
		private sealed class LeftShiftInt16 : LeftShiftInstruction // TypeDefIndex: 50980
		{
			// Constructors
			public LeftShiftInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189710224-0x00000001897102E8
		}
	
		private sealed class LeftShiftInt32 : LeftShiftInstruction // TypeDefIndex: 50981
		{
			// Constructors
			public LeftShiftInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897102E8-0x000000018971039C
		}
	
		private sealed class LeftShiftInt64 : LeftShiftInstruction // TypeDefIndex: 50982
		{
			// Constructors
			public LeftShiftInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018971039C-0x0000000189710468
		}
	
		private sealed class LeftShiftByte : LeftShiftInstruction // TypeDefIndex: 50983
		{
			// Constructors
			public LeftShiftByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018970FD28-0x000000018970FDE8
		}
	
		private sealed class LeftShiftUInt16 : LeftShiftInstruction // TypeDefIndex: 50984
		{
			// Constructors
			public LeftShiftUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189710528-0x00000001897105EC
		}
	
		private sealed class LeftShiftUInt32 : LeftShiftInstruction // TypeDefIndex: 50985
		{
			// Constructors
			public LeftShiftUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897105EC-0x00000001897106B8
		}
	
		private sealed class LeftShiftUInt64 : LeftShiftInstruction // TypeDefIndex: 50986
		{
			// Constructors
			public LeftShiftUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897106B8-0x0000000189710784
		}
	
		// Constructors
		private LeftShiftInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018970FDE8-0x00000001897101F8
	}

	internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 50999
	{
		// Fields
		private readonly object _nullValue; // 0x10
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Char; // 0x10
		private static Instruction s_Int32; // 0x18
		private static Instruction s_Int64; // 0x20
		private static Instruction s_Byte; // 0x28
		private static Instruction s_UInt16; // 0x30
		private static Instruction s_UInt32; // 0x38
		private static Instruction s_UInt64; // 0x40
		private static Instruction s_Single; // 0x48
		private static Instruction s_Double; // 0x50
		private static Instruction s_liftedToNullSByte; // 0x58
		private static Instruction s_liftedToNullInt16; // 0x60
		private static Instruction s_liftedToNullChar; // 0x68
		private static Instruction s_liftedToNullInt32; // 0x70
		private static Instruction s_liftedToNullInt64; // 0x78
		private static Instruction s_liftedToNullByte; // 0x80
		private static Instruction s_liftedToNullUInt16; // 0x88
		private static Instruction s_liftedToNullUInt32; // 0x90
		private static Instruction s_liftedToNullUInt64; // 0x98
		private static Instruction s_liftedToNullSingle; // 0xA0
		private static Instruction s_liftedToNullDouble; // 0xA8
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189711660-0x000000018971168C 
	
		// Nested types
		private sealed class LessThanSByte : LessThanInstruction // TypeDefIndex: 50988
		{
			// Constructors
			public LessThanSByte() {} // Dummy constructor
			public LessThanSByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712D80-0x0000000189712E38
		}
	
		private sealed class LessThanInt16 : LessThanInstruction // TypeDefIndex: 50989
		{
			// Constructors
			public LessThanInt16() {} // Dummy constructor
			public LessThanInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018971168C-0x0000000189711744
		}
	
		private sealed class LessThanChar : LessThanInstruction // TypeDefIndex: 50990
		{
			// Constructors
			public LessThanChar() {} // Dummy constructor
			public LessThanChar(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018971083C-0x00000001897108F4
		}
	
		private sealed class LessThanInt32 : LessThanInstruction // TypeDefIndex: 50991
		{
			// Constructors
			public LessThanInt32() {} // Dummy constructor
			public LessThanInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189711744-0x00000001897117FC
		}
	
		private sealed class LessThanInt64 : LessThanInstruction // TypeDefIndex: 50992
		{
			// Constructors
			public LessThanInt64() {} // Dummy constructor
			public LessThanInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897117FC-0x00000001897118B4
		}
	
		private sealed class LessThanByte : LessThanInstruction // TypeDefIndex: 50993
		{
			// Constructors
			public LessThanByte() {} // Dummy constructor
			public LessThanByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189710784-0x000000018971083C
		}
	
		private sealed class LessThanUInt16 : LessThanInstruction // TypeDefIndex: 50994
		{
			// Constructors
			public LessThanUInt16() {} // Dummy constructor
			public LessThanUInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712EF4-0x0000000189712FAC
		}
	
		private sealed class LessThanUInt32 : LessThanInstruction // TypeDefIndex: 50995
		{
			// Constructors
			public LessThanUInt32() {} // Dummy constructor
			public LessThanUInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712FAC-0x0000000189713064
		}
	
		private sealed class LessThanUInt64 : LessThanInstruction // TypeDefIndex: 50996
		{
			// Constructors
			public LessThanUInt64() {} // Dummy constructor
			public LessThanUInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189713064-0x000000018971311C
		}
	
		private sealed class LessThanSingle : LessThanInstruction // TypeDefIndex: 50997
		{
			// Constructors
			public LessThanSingle() {} // Dummy constructor
			public LessThanSingle(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712E38-0x0000000189712EF4
		}
	
		private sealed class LessThanDouble : LessThanInstruction // TypeDefIndex: 50998
		{
			// Constructors
			public LessThanDouble() {} // Dummy constructor
			public LessThanDouble(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897108F4-0x00000001897109B0
		}
	
		// Constructors
		protected LessThanInstruction() {} // Dummy constructor
		private LessThanInstruction(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEACC */) => default; // 0x00000001897109B0-0x0000000189711660
	}

	internal abstract class LessThanOrEqualInstruction : Instruction // TypeDefIndex: 51011
	{
		// Fields
		private readonly object _nullValue; // 0x10
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Char; // 0x10
		private static Instruction s_Int32; // 0x18
		private static Instruction s_Int64; // 0x20
		private static Instruction s_Byte; // 0x28
		private static Instruction s_UInt16; // 0x30
		private static Instruction s_UInt32; // 0x38
		private static Instruction s_UInt64; // 0x40
		private static Instruction s_Single; // 0x48
		private static Instruction s_Double; // 0x50
		private static Instruction s_liftedToNullSByte; // 0x58
		private static Instruction s_liftedToNullInt16; // 0x60
		private static Instruction s_liftedToNullChar; // 0x68
		private static Instruction s_liftedToNullInt32; // 0x70
		private static Instruction s_liftedToNullInt64; // 0x78
		private static Instruction s_liftedToNullByte; // 0x80
		private static Instruction s_liftedToNullUInt16; // 0x88
		private static Instruction s_liftedToNullUInt32; // 0x90
		private static Instruction s_liftedToNullUInt64; // 0x98
		private static Instruction s_liftedToNullSingle; // 0xA0
		private static Instruction s_liftedToNullDouble; // 0xA8
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189712790-0x00000001897127BC 
	
		// Nested types
		private sealed class LessThanOrEqualSByte : LessThanOrEqualInstruction // TypeDefIndex: 51000
		{
			// Constructors
			public LessThanOrEqualSByte() {} // Dummy constructor
			public LessThanOrEqualSByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897129E4-0x0000000189712A9C
		}
	
		private sealed class LessThanOrEqualInt16 : LessThanOrEqualInstruction // TypeDefIndex: 51001
		{
			// Constructors
			public LessThanOrEqualInt16() {} // Dummy constructor
			public LessThanOrEqualInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897127BC-0x0000000189712874
		}
	
		private sealed class LessThanOrEqualChar : LessThanOrEqualInstruction // TypeDefIndex: 51002
		{
			// Constructors
			public LessThanOrEqualChar() {} // Dummy constructor
			public LessThanOrEqualChar(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018971196C-0x0000000189711A24
		}
	
		private sealed class LessThanOrEqualInt32 : LessThanOrEqualInstruction // TypeDefIndex: 51003
		{
			// Constructors
			public LessThanOrEqualInt32() {} // Dummy constructor
			public LessThanOrEqualInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712874-0x000000018971292C
		}
	
		private sealed class LessThanOrEqualInt64 : LessThanOrEqualInstruction // TypeDefIndex: 51004
		{
			// Constructors
			public LessThanOrEqualInt64() {} // Dummy constructor
			public LessThanOrEqualInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018971292C-0x00000001897129E4
		}
	
		private sealed class LessThanOrEqualByte : LessThanOrEqualInstruction // TypeDefIndex: 51005
		{
			// Constructors
			public LessThanOrEqualByte() {} // Dummy constructor
			public LessThanOrEqualByte(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897118B4-0x000000018971196C
		}
	
		private sealed class LessThanOrEqualUInt16 : LessThanOrEqualInstruction // TypeDefIndex: 51006
		{
			// Constructors
			public LessThanOrEqualUInt16() {} // Dummy constructor
			public LessThanOrEqualUInt16(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712B58-0x0000000189712C10
		}
	
		private sealed class LessThanOrEqualUInt32 : LessThanOrEqualInstruction // TypeDefIndex: 51007
		{
			// Constructors
			public LessThanOrEqualUInt32() {} // Dummy constructor
			public LessThanOrEqualUInt32(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712C10-0x0000000189712CC8
		}
	
		private sealed class LessThanOrEqualUInt64 : LessThanOrEqualInstruction // TypeDefIndex: 51008
		{
			// Constructors
			public LessThanOrEqualUInt64() {} // Dummy constructor
			public LessThanOrEqualUInt64(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712CC8-0x0000000189712D80
		}
	
		private sealed class LessThanOrEqualSingle : LessThanOrEqualInstruction // TypeDefIndex: 51009
		{
			// Constructors
			public LessThanOrEqualSingle() {} // Dummy constructor
			public LessThanOrEqualSingle(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189712A9C-0x0000000189712B58
		}
	
		private sealed class LessThanOrEqualDouble : LessThanOrEqualInstruction // TypeDefIndex: 51010
		{
			// Constructors
			public LessThanOrEqualDouble() {} // Dummy constructor
			public LessThanOrEqualDouble(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189711A24-0x0000000189711AE0
		}
	
		// Constructors
		protected LessThanOrEqualInstruction() {} // Dummy constructor
		private LessThanOrEqualInstruction(object nullValue) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull = false /* Metadata: 0x01FCEACD */) => default; // 0x0000000189711AE0-0x0000000189712790
	}

	internal sealed class ExceptionFilter // TypeDefIndex: 51012
	{
		// Fields
		public readonly int LabelIndex; // 0x10
		public readonly int StartIndex; // 0x14
		public readonly int EndIndex; // 0x18
	
		// Constructors
		public ExceptionFilter() {} // Dummy constructor
		internal ExceptionFilter(int labelIndex, int start, int end) {} // 0x0000000183D51130-0x0000000183D51140
	}

	internal sealed class ExceptionHandler // TypeDefIndex: 51013
	{
		// Fields
		private readonly System.Type _exceptionType; // 0x10
		public readonly int LabelIndex; // 0x18
		public readonly int HandlerStartIndex; // 0x1C
		public readonly int HandlerEndIndex; // 0x20
		public readonly ExceptionFilter Filter; // 0x28
	
		// Constructors
		public ExceptionHandler() {} // Dummy constructor
		internal ExceptionHandler(int labelIndex, int handlerStartIndex, int handlerEndIndex, System.Type exceptionType, ExceptionFilter filter) {} // 0x0000000189706B04-0x0000000189706B44
	
		// Methods
		public bool Matches(System.Type exceptionType) => default; // 0x00000001897069F8-0x0000000189706A1C
		public override string ToString() => default; // 0x0000000189706A1C-0x0000000189706B04
	}

	internal sealed class TryCatchFinallyHandler // TypeDefIndex: 51014
	{
		// Fields
		internal readonly int TryStartIndex; // 0x10
		internal readonly int TryEndIndex; // 0x14
		internal readonly int FinallyStartIndex; // 0x18
		internal readonly int FinallyEndIndex; // 0x1C
		internal readonly int GotoEndTargetIndex; // 0x20
		private readonly ExceptionHandler[] _handlers; // 0x28
	
		// Properties
		internal bool IsFinallyBlockExist { get => default; } // 0x000000018971F408-0x000000018971F414 
		internal ExceptionHandler[] Handlers { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		internal bool IsCatchBlockExist { get => default; } // 0x0000000185693D38-0x0000000185693D44 
	
		// Constructors
		public TryCatchFinallyHandler() {} // Dummy constructor
		internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) {} // 0x000000018971F3DC-0x000000018971F408
		internal TryCatchFinallyHandler(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) {} // 0x000000018971F3B0-0x000000018971F3DC
	
		// Methods
		internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) {
			handler = default;
			unwrappedException = default;
			return default;
		} // 0x000000018971F254-0x000000018971F3B0
		private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) => default; // 0x000000018971F08C-0x000000018971F254
	}

	internal sealed class TryFaultHandler // TypeDefIndex: 51015
	{
		// Fields
		internal readonly int TryStartIndex; // 0x10
		internal readonly int TryEndIndex; // 0x14
		internal readonly int FinallyStartIndex; // 0x18
		internal readonly int FinallyEndIndex; // 0x1C
	
		// Constructors
		public TryFaultHandler() {} // Dummy constructor
		internal TryFaultHandler(int tryStart, int tryEnd, int finallyStart, int finallyEnd) {} // 0x0000000183D54260-0x0000000183D54280
	}

	internal sealed class RethrowException : Exception // TypeDefIndex: 51016
	{
		// Constructors
		public RethrowException() {} // 0x000000018971EF3C-0x000000018971EF88
	}

	internal sealed class DebugInfo // TypeDefIndex: 51018
	{
		// Fields
		public int StartLine; // 0x10
		public int EndLine; // 0x14
		public int Index; // 0x18
		public string FileName; // 0x20
		public bool IsClear; // 0x28
		private static readonly DebugInfoComparer s_debugComparer; // 0x00
	
		// Nested types
		private class DebugInfoComparer : IComparer<DebugInfo> // TypeDefIndex: 51017
		{
			// Constructors
			public DebugInfoComparer() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			int IComparer<DebugInfo>.Compare(DebugInfo d1, DebugInfo d2) => default; // 0x00000001897061F8-0x000000018970622C
		}
	
		// Constructors
		public DebugInfo() {} // 0x000000018350B670-0x000000018350B680
		static DebugInfo() {} // 0x00000001897064B4-0x0000000189706524
	
		// Methods
		public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) => default; // 0x000000018970622C-0x00000001897062EC
		public override string ToString() => default; // 0x00000001897062EC-0x00000001897064B4
	}

	[IsReadOnly]
	internal struct InterpretedFrameInfo // TypeDefIndex: 51019
	{
		// Fields
		private readonly string _methodName; // 0x00
		private readonly DebugInfo _debugInfo; // 0x08
	
		// Constructors
		public InterpretedFrameInfo(string methodName, DebugInfo info) {
			_methodName = default;
			_debugInfo = default;
		} // 0x00000001832C7BF0-0x00000001832C7C20
	
		// Methods
		public override string ToString() => default; // 0x000000018970E0F0-0x000000018970E164
	}

	internal sealed class LightCompiler // TypeDefIndex: 51022
	{
		// Fields
		private readonly InstructionList _instructions; // 0x10
		private readonly LocalVariables _locals; // 0x18
		private readonly List<DebugInfo> _debugInfos; // 0x20
		private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
		private LabelScopeInfo _labelBlock; // 0x30
		private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
		private readonly LightCompiler _parent; // 0x40
		private readonly StackGuard _guard; // 0x48
		private static readonly LocalDefinition[] s_emptyLocals; // 0x00
	
		// Properties
		public InstructionList Instructions { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Nested types
		private sealed class QuoteVisitor : ExpressionVisitor // TypeDefIndex: 51020
		{
			// Fields
			private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
			public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18
	
			// Constructors
			public QuoteVisitor() {} // 0x000000018973353C-0x00000001897335FC
	
			// Methods
			protected internal override Expression VisitParameter(ParameterExpression node) => default; // 0x00000001897334BC-0x000000018973353C
			protected internal override Expression VisitBlock(BlockExpression node) => default; // 0x0000000189733340-0x00000001897333A8
			protected override CatchBlock VisitCatchBlock(CatchBlock node) => default; // 0x00000001897333A8-0x00000001897334BC
			protected internal override Expression VisitLambda<T>(Expression<T> node) => default;
			private void PushParameters(IEnumerable<ParameterExpression> parameters) {} // 0x00000001897331A0-0x0000000189733340
			private void PopParameters(IEnumerable<ParameterExpression> parameters) {} // 0x0000000189732FFC-0x00000001897331A0
		}
	
		// Constructors
		public LightCompiler() {} // 0x000000018971EC64-0x000000018971EE40
		private LightCompiler(LightCompiler parent) {} // 0x000000018971EC34-0x000000018971EC64
		static LightCompiler() {} // 0x000000018971EBD4-0x000000018971EC34
	
		// Methods
		public LightDelegateCreator CompileTop(LambdaExpression node) => default; // 0x000000018971BB2C-0x000000018971BCD8
		private Interpreter MakeInterpreter(string lambdaName) => default; // 0x000000018971E170-0x000000018971E530
		private void CompileConstantExpression(Expression expr) {} // 0x0000000189715E78-0x0000000189715EF4
		private void CompileDefaultExpression(Expression expr) {} // 0x0000000189716AEC-0x0000000189716B20
		private void CompileDefaultExpression(System.Type type) {} // 0x0000000189716A0C-0x0000000189716AEC
		private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) => default; // 0x000000018971DDFC-0x000000018971DF40
		private LocalVariable ResolveLocal(ParameterExpression variable) => default; // 0x000000018971E66C-0x000000018971E6C4
		private void CompileGetVariable(ParameterExpression variable) {} // 0x0000000189716BEC-0x0000000189716C34
		private void EmitCopyValueType(System.Type valueType) {} // 0x000000018971D9B4-0x000000018971DA34
		private void LoadLocalNoValueTypeCopy(ParameterExpression variable) {} // 0x000000018971E108-0x000000018971E170
		private bool MaybeMutableValueType(System.Type type) => default; // 0x000000018971E530-0x000000018971E57C
		private void CompileGetBoxedVariable(ParameterExpression variable) {} // 0x0000000189716B9C-0x0000000189716BEC
		private void CompileSetVariable(ParameterExpression variable, bool isVoid) {} // 0x000000018971AC74-0x000000018971AD20
		private void CompileParameterExpression(Expression expr) {} // 0x000000018971A65C-0x000000018971A6B0
		private void CompileBlockExpression(Expression expr, bool asVoid) {} // 0x0000000189714F4C-0x0000000189715064
		private LocalDefinition[] CompileBlockStart(BlockExpression node) => default; // 0x0000000189715064-0x00000001897155A0
		private void CompileBlockEnd(LocalDefinition[] locals) {} // 0x0000000189714EC0-0x0000000189714F4C
		private void CompileIndexExpression(Expression expr) {} // 0x000000018971706C-0x000000018971712C
		private void EmitIndexGet(IndexExpression index) {} // 0x000000018971DA34-0x000000018971DB10
		private void CompileIndexAssignment(BinaryExpression node, bool asVoid) {} // 0x0000000189716DD4-0x000000018971706C
		private void CompileMemberAssignment(BinaryExpression node, bool asVoid) {} // 0x0000000189718884-0x0000000189718930
		private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) {} // 0x000000018971851C-0x0000000189718884
		private void CompileVariableAssignment(BinaryExpression node, bool asVoid) {} // 0x000000018971D724-0x000000018971D7A4
		private void CompileAssignBinaryExpression(Expression expr, bool asVoid) {} // 0x0000000189713FC8-0x00000001897140CC
		private void CompileBinaryExpression(Expression expr) {} // 0x00000001897140CC-0x0000000189714EC0
		private void CompileEqual(Expression left, Expression right, bool liftedToNull) {} // 0x0000000189716B20-0x0000000189716B9C
		private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) {} // 0x000000018971A52C-0x000000018971A5A8
		private void CompileComparison(BinaryExpression node) {} // 0x0000000189715AC0-0x0000000189715C88
		private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) {} // 0x0000000189713A04-0x0000000189713C28
		private void CompileConvertUnaryExpression(Expression expr) {} // 0x0000000189716388-0x0000000189716960
		private void CompileConvertToType(System.Type typeFrom, System.Type typeTo, bool isChecked, bool isLiftedToNull) {} // 0x0000000189715EF4-0x0000000189716388
		private void CompileNotExpression(UnaryExpression node) {} // 0x000000018971A5A8-0x000000018971A604
		private void CompileUnaryExpression(Expression expr) {} // 0x000000018971D214-0x000000018971D4F8
		private void EmitUnaryMethodCall(UnaryExpression node) {} // 0x000000018971DCF8-0x000000018971DDFC
		private void EmitUnaryBoolCheck(UnaryExpression node) {} // 0x000000018971DB20-0x000000018971DCF8
		private void CompileAndAlsoBinaryExpression(Expression expr) {} // 0x00000001897139AC-0x0000000189713A04
		private void CompileOrElseBinaryExpression(Expression expr) {} // 0x000000018971A604-0x000000018971A65C
		private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) {} // 0x0000000189718238-0x0000000189718378
		private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) {} // 0x00000001897194C8-0x000000018971963C
		private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) {} // 0x0000000189717714-0x0000000189717EB8
		private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) {} // 0x000000018971D5FC-0x000000018971D724
		private void CompileConditionalExpression(Expression expr, bool asVoid) {} // 0x0000000189715C88-0x0000000189715E78
		private void CompileLoopExpression(Expression expr) {} // 0x0000000189718378-0x000000018971851C
		private void CompileSwitchExpression(Expression expr) {} // 0x000000018971B2C0-0x000000018971BA2C
		private void CompileIntSwitchExpression<T>(SwitchExpression node) {}
		private void CompileStringSwitchExpression(SwitchExpression node) {} // 0x000000018971AD20-0x000000018971B2C0
		private void CompileLabelExpression(Expression expr) {} // 0x0000000189717320-0x00000001897174C0
		private void CompileGotoExpression(Expression expr) {} // 0x0000000189716C34-0x0000000189716DD4
		private void PushLabelBlock(LabelScopeKind type) {} // 0x000000018971E5A4-0x000000018971E62C
		private void PopLabelBlock(LabelScopeKind kind) {} // 0x000000018971E57C-0x000000018971E5A4
		private LabelInfo EnsureLabel(LabelTarget node) => default; // 0x000000018971DF40-0x000000018971E010
		private LabelInfo ReferenceLabel(LabelTarget node) => default; // 0x000000018971E62C-0x000000018971E66C
		private LabelInfo DefineLabel(LabelTarget node) => default; // 0x000000018971D924-0x000000018971D9B4
		private bool TryPushLabelBlock(Expression node) => default; // 0x000000018971E800-0x000000018971EBD4
		private void DefineBlockLabels(Expression node) {} // 0x000000018971D828-0x000000018971D924
		private void CheckRethrow() {} // 0x000000018971311C-0x0000000189713168
		private void CompileThrowUnaryExpression(Expression expr, bool asVoid) {} // 0x000000018971BA2C-0x000000018971BB2C
		private void CompileTryExpression(Expression expr) {} // 0x000000018971BCD8-0x000000018971CBB4
		private void CompileTryFaultExpression(TryExpression expr) {} // 0x000000018971CBB4-0x000000018971CE10
		private void CompileMethodCallExpression(Expression expr) {} // 0x0000000189719450-0x00000001897194C8
		private void CompileMethodCallExpression(Expression @object, MethodInfo method, IArgumentProvider arguments) {} // 0x0000000189719004-0x0000000189719450
		private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) => default; // 0x0000000189713C28-0x0000000189713E68
		private void EmitThisForMethodCall(Expression node) {} // 0x000000018971DB10-0x000000018971DB20
		private static bool ShouldWritebackNode(Expression node) => default; // 0x000000018971E6C4-0x000000018971E800
		private ByRefUpdater CompileAddress(Expression node, int index) => default; // 0x0000000189713168-0x00000001897139AC
		private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) => default; // 0x000000018971963C-0x000000018971999C
		private void CompileNewExpression(Expression expr) {} // 0x0000000189719BF8-0x0000000189719ECC
		private void CompileMemberExpression(Expression expr) {} // 0x0000000189718930-0x00000001897189A8
		private void CompileMember(Expression from, MemberInfo member, bool forBinding) {} // 0x0000000189718D68-0x0000000189719004
		private void CompileNewArrayExpression(Expression expr) {} // 0x000000018971999C-0x0000000189719BF8
		private void CompileDebugInfoExpression(Expression expr) {} // 0x0000000189716960-0x0000000189716A0C
		private void CompileRuntimeVariablesExpression(Expression expr) {} // 0x000000018971AAAC-0x000000018971AC74
		private void CompileLambdaExpression(Expression expr) {} // 0x00000001897174C0-0x0000000189717714
		private void CompileCoalesceBinaryExpression(Expression expr) {} // 0x00000001897155A0-0x0000000189715AC0
		private void CompileInvocationExpression(Expression expr) {} // 0x000000018971712C-0x0000000189717320
		private void CompileListInitExpression(Expression expr) {} // 0x0000000189717EB8-0x0000000189717F2C
		private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) {} // 0x0000000189717F2C-0x0000000189718238
		private void CompileMemberInitExpression(Expression expr) {} // 0x00000001897189A8-0x0000000189718A1C
		private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) {} // 0x0000000189718A1C-0x0000000189718D68
		private static System.Type GetMemberType(MemberInfo member) => default; // 0x000000018971E010-0x000000018971E108
		private void CompileQuoteUnaryExpression(Expression expr) {} // 0x000000018971A6B0-0x000000018971AAAC
		private void CompileUnboxUnaryExpression(Expression expr) {} // 0x000000018971D4F8-0x000000018971D5FC
		private void CompileTypeEqualExpression(Expression expr) {} // 0x000000018971CE68-0x000000018971D00C
		private void CompileTypeAsExpression(UnaryExpression node) {} // 0x000000018971CE10-0x000000018971CE68
		private void CompileTypeIsExpression(Expression expr) {} // 0x000000018971D00C-0x000000018971D214
		private void Compile(Expression expr, bool asVoid) {} // 0x000000018971D804-0x000000018971D828
		private void CompileAsVoid(Expression expr) {} // 0x0000000189713E68-0x0000000189713FC8
		private void CompileNoLabelPush(Expression expr) {} // 0x0000000189719ECC-0x000000018971A52C
		private void Compile(Expression expr) {} // 0x000000018971D7A4-0x000000018971D804
	}

	internal abstract class ByRefUpdater // TypeDefIndex: 51023
	{
		// Fields
		public readonly int ArgumentIndex; // 0x10
	
		// Constructors
		protected ByRefUpdater() {} // Dummy constructor
		public ByRefUpdater(int argumentIndex) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public abstract void Update(InterpretedFrame frame, object value);
		public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) {} // 0x000000018350B670-0x000000018350B680
	}

	internal sealed class ParameterByRefUpdater : ByRefUpdater // TypeDefIndex: 51024
	{
		// Fields
		private readonly LocalVariable _parameter; // 0x18
	
		// Constructors
		public ParameterByRefUpdater() {} // Dummy constructor
		public ParameterByRefUpdater(LocalVariable parameter, int argumentIndex) {} // 0x0000000189732C24-0x0000000189732C38
	
		// Methods
		public override void Update(InterpretedFrame frame, object value) {} // 0x0000000189732B0C-0x0000000189732C24
	}

	internal sealed class ArrayByRefUpdater : ByRefUpdater // TypeDefIndex: 51025
	{
		// Fields
		private readonly LocalDefinition _array; // 0x18
		private readonly LocalDefinition _index; // 0x28
	
		// Constructors
		public ArrayByRefUpdater() {} // Dummy constructor
		public ArrayByRefUpdater(LocalDefinition array, LocalDefinition index, int argumentIndex) {} // 0x000000018971F7E0-0x000000018971F814
	
		// Methods
		public override void Update(InterpretedFrame frame, object value) {} // 0x000000018971F708-0x000000018971F7E0
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals) {} // 0x000000018971F678-0x000000018971F708
	}

	internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 51026
	{
		// Fields
		private readonly LocalDefinition? _object; // 0x18
		private readonly System.Reflection.FieldInfo _field; // 0x30
	
		// Constructors
		public FieldByRefUpdater() {} // Dummy constructor
		public FieldByRefUpdater(LocalDefinition? obj, System.Reflection.FieldInfo field, int argumentIndex) {} // 0x0000000189727EF0-0x0000000189727F2C
	
		// Methods
		public override void Update(InterpretedFrame frame, object value) {} // 0x0000000189727E54-0x0000000189727EF0
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals) {} // 0x0000000189727DBC-0x0000000189727E54
	}

	internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 51027
	{
		// Fields
		private readonly LocalDefinition? _object; // 0x18
		private readonly PropertyInfo _property; // 0x30
	
		// Constructors
		public PropertyByRefUpdater() {} // Dummy constructor
		public PropertyByRefUpdater(LocalDefinition? obj, PropertyInfo property, int argumentIndex) {} // 0x0000000189727EF0-0x0000000189727F2C
	
		// Methods
		public override void Update(InterpretedFrame frame, object value) {} // 0x0000000189732E08-0x0000000189732F20
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals) {} // 0x0000000189732D70-0x0000000189732E08
	}

	internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 51028
	{
		// Fields
		private readonly MethodInfo _indexer; // 0x18
		private readonly LocalDefinition? _obj; // 0x20
		private readonly LocalDefinition[] _args; // 0x38
	
		// Constructors
		public IndexMethodByRefUpdater() {} // Dummy constructor
		public IndexMethodByRefUpdater(LocalDefinition? obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) {} // 0x0000000189728690-0x00000001897286DC
	
		// Methods
		public override void Update(InterpretedFrame frame, object value) {} // 0x00000001897284A0-0x0000000189728690
		public override void UndefineTemps(InstructionList instructions, LocalVariables locals) {} // 0x00000001897283A8-0x00000001897284A0
	}

	internal sealed class LightDelegateCreator // TypeDefIndex: 51029
	{
		// Fields
		private readonly LambdaExpression _lambda; // 0x10
	
		// Properties
		internal Interpreter Interpreter { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public LightDelegateCreator() {} // Dummy constructor
		internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) {} // 0x0000000182AEEFA0-0x0000000182AEEFD0
	
		// Methods
		public Delegate CreateDelegate() => default; // 0x0000000189729164-0x0000000189729170
		internal Delegate CreateDelegate(IStrongBox[] closure) => default; // 0x0000000189729170-0x00000001897291FC
	}

	internal class LightLambda // TypeDefIndex: 51032
	{
		// Fields
		private readonly IStrongBox[] _closure; // 0x10
		private readonly Interpreter _interpreter; // 0x18
		private static readonly CacheDict<System.Type, System.Func<LightLambda, Delegate>> _runCache; // 0x00
		private readonly LightDelegateCreator _delegateCreator; // 0x20
	
		// Properties
		internal string DebugView { get => default; } // 0x000000018972A804-0x000000018972A870 
	
		// Nested types
		private class DebugViewPrinter // TypeDefIndex: 51030
		{
			// Fields
			private readonly Interpreter _interpreter; // 0x10
			private readonly Dictionary<int, int> _tryStart; // 0x18
			private readonly Dictionary<int, string> _handlerEnter; // 0x20
			private readonly Dictionary<int, int> _handlerExit; // 0x28
			private string _indent; // 0x30
	
			// Constructors
			public DebugViewPrinter() {} // Dummy constructor
			public DebugViewPrinter(Interpreter interpreter) {} // 0x0000000189723164-0x00000001897232A0
	
			// Methods
			private void Analyze() {} // 0x000000018972287C-0x0000000189722B08
			private void AddTryStart(int index) {} // 0x00000001897227C8-0x000000018972287C
			private void AddHandlerExit(int index) {} // 0x0000000189722724-0x00000001897227C8
			private void Indent() {} // 0x0000000189722C08-0x0000000189722C48
			private void Dedent() {} // 0x0000000189722B08-0x0000000189722B48
			public override string ToString() => default; // 0x0000000189722C48-0x0000000189723164
			private void EmitExits(StringBuilder sb, int index) {} // 0x0000000189722B48-0x0000000189722C08
		}
	
		// Constructors
		public LightLambda() {} // Dummy constructor
		internal LightLambda(LightDelegateCreator delegateCreator, IStrongBox[] closure) {} // 0x000000018972A7BC-0x000000018972A804
		static LightLambda() {} // 0x000000018972A728-0x000000018972A7BC
	
		// Methods
		internal TRet Run0<TRet>() => default;
		internal void RunVoid0() {} // 0x000000018972A2A8-0x000000018972A384
		internal static Delegate MakeRun0<TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid0(LightLambda lambda) => default; // 0x000000018972A234-0x000000018972A2A8
		internal TRet Run1<T0, TRet>(T0 arg0) => default;
		internal void RunVoid1<T0>(T0 arg0) {}
		internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) => default;
		internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) => default;
		internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) {}
		internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) => default;
		internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) => default;
		internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) {}
		internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) => default;
		internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) => default;
		internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) => default;
		internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => default;
		internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) => default;
		internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => default;
		internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
		internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) => default;
		internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => default;
		internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) => default;
		internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => default;
		internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {}
		internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) => default;
		internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => default;
		internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {}
		internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) => default;
		internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => default;
		internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {}
		internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) => default;
		internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => default;
		internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {}
		internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) => default;
		internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => default;
		internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {}
		internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) => default;
		internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => default;
		internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {}
		internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) => default;
		internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => default;
		internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {}
		internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) => default;
		internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => default;
		internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {}
		internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) => default;
		internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) => default;
		private static System.Func<LightLambda, Delegate> GetRunDelegateCtor(System.Type delegateType) => default; // 0x0000000189729920-0x0000000189729AA0
		private static System.Func<LightLambda, Delegate> MakeRunDelegateCtor(System.Type delegateType) => default; // 0x0000000189729B84-0x000000018972A234
		private Delegate CreateCustomDelegate(System.Type delegateType) => default; // 0x00000001897291FC-0x0000000189729920
		internal Delegate MakeDelegate(System.Type delegateType) => default; // 0x0000000189729AA0-0x0000000189729B10
		private InterpretedFrame MakeFrame() => default; // 0x0000000189729B10-0x0000000189729B84
		internal void RunVoidRef2<T0, T1>(ref ref T0 arg0, ref ref T1 arg1) {}
		public object Run(params object[] arguments) => default; // 0x000000018972A548-0x000000018972A728
		public object RunVoid(params object[] arguments) => default; // 0x000000018972A384-0x000000018972A548
	}

	internal interface IBoxableInstruction // TypeDefIndex: 51033
	{
		// Methods
		Instruction BoxIfIndexMatches(int index);
	}

	internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 51034
	{
		// Fields
		internal readonly int _index; // 0x10
	
		// Constructors
		protected LocalAccessInstruction() {} // Dummy constructor
		protected LocalAccessInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override string ToDebugString(int instructionIndex, object cookie, System.Func<int, int> labelIndexer, IReadOnlyList<object> objects) => default; // 0x000000018972AE9C-0x000000018972AFFC
	}

	internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 51035
	{
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972AD58-0x000000018972AD84 
	
		// Constructors
		public LoadLocalInstruction() {} // Dummy constructor
		internal LoadLocalInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972ACDC-0x000000018972AD58
		public Instruction BoxIfIndexMatches(int index) => default; // 0x000000018972AC88-0x000000018972ACDC
	}

	internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 51036
	{
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972AB00-0x000000018972AB2C 
	
		// Constructors
		public LoadLocalBoxedInstruction() {} // Dummy constructor
		internal LoadLocalBoxedInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972AA48-0x000000018972AB00
	}

	internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction // TypeDefIndex: 51037
	{
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972AC5C-0x000000018972AC88 
	
		// Constructors
		public LoadLocalFromClosureInstruction() {} // Dummy constructor
		internal LoadLocalFromClosureInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972ABD4-0x000000018972AC5C
	}

	internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 51038
	{
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972ABA8-0x000000018972ABD4 
	
		// Constructors
		public LoadLocalFromClosureBoxedInstruction() {} // Dummy constructor
		internal LoadLocalFromClosureBoxedInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972AB2C-0x000000018972ABA8
	}

	internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 51039
	{
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018971F99C-0x000000018971F9C8 
	
		// Constructors
		public AssignLocalInstruction() {} // Dummy constructor
		internal AssignLocalInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971F934-0x000000018971F99C
		public Instruction BoxIfIndexMatches(int index) => default; // 0x000000018971F8E0-0x000000018971F934
	}

	internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 51040
	{
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001897349A8-0x00000001897349D4 
	
		// Constructors
		public StoreLocalInstruction() {} // Dummy constructor
		internal StoreLocalInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189734940-0x00000001897349A8
		public Instruction BoxIfIndexMatches(int index) => default; // 0x00000001897348EC-0x0000000189734940
	}

	internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 51041
	{
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018971F8B4-0x000000018971F8E0 
	
		// Constructors
		public AssignLocalBoxedInstruction() {} // Dummy constructor
		internal AssignLocalBoxedInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971F814-0x000000018971F8B4
	}

	internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 51042
	{
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001897348C0-0x00000001897348EC 
	
		// Constructors
		public StoreLocalBoxedInstruction() {} // Dummy constructor
		internal StoreLocalBoxedInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189734810-0x00000001897348C0
	}

	internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 51043
	{
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018971FA20-0x000000018971FA4C 
	
		// Constructors
		public AssignLocalToClosureInstruction() {} // Dummy constructor
		internal AssignLocalToClosureInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018971F9C8-0x000000018971FA20
	}

	internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 51044
	{
		// Fields
		public static readonly ValueTypeCopyInstruction Instruction; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189737E80-0x0000000189737EAC 
	
		// Constructors
		public ValueTypeCopyInstruction() {} // 0x000000018350B670-0x000000018350B680
		static ValueTypeCopyInstruction() {} // 0x0000000189737E1C-0x0000000189737E80
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189737DC8-0x0000000189737E1C
	}

	internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 51053
	{
		// Nested types
		internal sealed class Reference : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 51045
		{
			// Properties
			public override string InstructionName { get => default; } // 0x00000001897336A8-0x00000001897336D4 
	
			// Constructors
			public Reference() {} // Dummy constructor
			internal Reference(int index) {} // 0x00000001810410F0-0x0000000181041100
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733674-0x00000001897336A8
			public Instruction BoxIfIndexMatches(int index) => default; // 0x0000000189733620-0x0000000189733674
		}
	
		internal sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 51046
		{
			// Fields
			private readonly object _defaultValue; // 0x18
	
			// Properties
			public override string InstructionName { get => default; } // 0x000000018972837C-0x00000001897283A8 
	
			// Constructors
			public ImmutableValue() {} // Dummy constructor
			internal ImmutableValue(int index, object defaultValue) {} // 0x0000000184270E40-0x0000000184270E50
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189728320-0x000000018972837C
			public Instruction BoxIfIndexMatches(int index) => default; // 0x00000001897282B0-0x0000000189728320
		}
	
		internal sealed class ImmutableBox : InitializeLocalInstruction // TypeDefIndex: 51047
		{
			// Fields
			private readonly object _defaultValue; // 0x18
	
			// Properties
			public override string InstructionName { get => default; } // 0x00000001897281C0-0x00000001897281EC 
	
			// Constructors
			public ImmutableBox() {} // Dummy constructor
			internal ImmutableBox(int index, object defaultValue) {} // 0x0000000184270E40-0x0000000184270E50
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189728108-0x00000001897281C0
		}
	
		internal sealed class ImmutableRefBox : InitializeLocalInstruction // TypeDefIndex: 51048
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189728284-0x00000001897282B0 
	
			// Constructors
			public ImmutableRefBox() {} // Dummy constructor
			internal ImmutableRefBox(int index) {} // 0x00000001810410F0-0x0000000181041100
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897281EC-0x0000000189728284
		}
	
		internal sealed class ParameterBox : InitializeLocalInstruction // TypeDefIndex: 51049
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189732AE0-0x0000000189732B0C 
	
			// Constructors
			public ParameterBox() {} // Dummy constructor
			public ParameterBox(int index) {} // 0x00000001810410F0-0x0000000181041100
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189732A18-0x0000000189732AE0
		}
	
		internal sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 51050
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189732C8C-0x0000000189732CB8 
	
			// Constructors
			public Parameter() {} // Dummy constructor
			internal Parameter(int index) {} // 0x00000001810410F0-0x0000000181041100
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000181168950-0x0000000181168960
			public Instruction BoxIfIndexMatches(int index) => default; // 0x0000000189732C38-0x0000000189732C8C
		}
	
		internal sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 51051
		{
			// Fields
			private readonly System.Type _type; // 0x18
	
			// Properties
			public override string InstructionName { get => default; } // 0x000000018972E350-0x000000018972E37C 
	
			// Constructors
			public MutableValue() {} // Dummy constructor
			internal MutableValue(int index, System.Type type) {} // 0x0000000184270E40-0x0000000184270E50
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E274-0x000000018972E350
			public Instruction BoxIfIndexMatches(int index) => default; // 0x000000018972E204-0x000000018972E274
		}
	
		internal sealed class MutableBox : InitializeLocalInstruction // TypeDefIndex: 51052
		{
			// Fields
			private readonly System.Type _type; // 0x18
	
			// Properties
			public override string InstructionName { get => default; } // 0x000000018972E1D8-0x000000018972E204 
	
			// Constructors
			public MutableBox() {} // Dummy constructor
			internal MutableBox(int index, System.Type type) {} // 0x0000000184270E40-0x0000000184270E50
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E0A0-0x000000018972E1D8
		}
	
		// Constructors
		protected InitializeLocalInstruction() {} // Dummy constructor
		internal InitializeLocalInstruction(int index) {} // 0x00000001810410F0-0x0000000181041100
	}

	internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 51054
	{
		// Fields
		private readonly int _count; // 0x10
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ConsumedStack { get => default; } // 0x0000000183D4E340-0x0000000183D4E350 
		public override string InstructionName { get => default; } // 0x0000000189734374-0x00000001897343A0 
	
		// Constructors
		public RuntimeVariablesInstruction() {} // Dummy constructor
		public RuntimeVariablesInstruction(int count) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189734280-0x0000000189734374
	}

	internal sealed class LocalVariable // TypeDefIndex: 51055
	{
		// Fields
		public readonly int Index; // 0x10
		private int _flags; // 0x14
	
		// Properties
		public bool IsBoxed { get => default; set {} } // 0x000000018972B184-0x000000018972B18C 0x000000018972B18C-0x000000018972B1A8
		public bool InClosure { get => default; } // 0x000000018972B17C-0x000000018972B184 
	
		// Constructors
		public LocalVariable() {} // Dummy constructor
		internal LocalVariable(int index, bool closure) {} // 0x000000018972B16C-0x000000018972B17C
	
		// Methods
		public override string ToString() => default; // 0x000000018972B098-0x000000018972B16C
	}

	[IsReadOnly]
	internal struct LocalDefinition // TypeDefIndex: 51056
	{
		// Properties
		public int Index { get; } // 0x0000000183D4E980-0x0000000183D4E990 
		public ParameterExpression Parameter { get; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Constructors
		internal LocalDefinition(int localIndex, ParameterExpression parameter) : this() {} // 0x00000001871AED58-0x00000001871AED68
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018972AFFC-0x000000018972B06C
		public override int GetHashCode() => default; // 0x000000018972B06C-0x000000018972B098
	}

	internal sealed class LocalVariables // TypeDefIndex: 51058
	{
		// Fields
		private readonly HybridReferenceDictionary<ParameterExpression, VariableScope> _variables; // 0x10
		private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
		private int _localCount; // 0x20
		private int _maxLocalCount; // 0x24
	
		// Properties
		public int LocalCount { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Nested types
		private sealed class VariableScope // TypeDefIndex: 51057
		{
			// Fields
			public readonly int Start; // 0x10
			public int Stop; // 0x14
			public readonly LocalVariable Variable; // 0x18
			public readonly VariableScope Parent; // 0x20
			public List<VariableScope> ChildScopes; // 0x28
	
			// Constructors
			public VariableScope() {} // Dummy constructor
			public VariableScope(LocalVariable variable, int start, VariableScope parent) {} // 0x0000000189737EF8-0x0000000189737FEC
		}
	
		// Constructors
		public LocalVariables() {} // 0x000000018972B7BC-0x000000018972B818
	
		// Methods
		public LocalDefinition DefineLocal(ParameterExpression variable, int start) => default; // 0x000000018972B408-0x000000018972B62C
		public void UndefineLocal(LocalDefinition definition, int end) {} // 0x000000018972B6F8-0x000000018972B7BC
		internal void Box(ParameterExpression variable, InstructionList instructions) {} // 0x000000018972B2BC-0x000000018972B408
		public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) {
			local = default;
			return default;
		} // 0x000000018972B62C-0x000000018972B6F8
		internal LocalVariable AddClosureVariable(ParameterExpression variable) => default; // 0x000000018972B1A8-0x000000018972B2BC
	}

	internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 51067
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018972BEEC-0x000000018972BF18 
	
		// Nested types
		private sealed class ModuloInt16 : ModuloInstruction // TypeDefIndex: 51059
		{
			// Constructors
			public ModuloInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972BF18-0x000000018972C02C
		}
	
		private sealed class ModuloInt32 : ModuloInstruction // TypeDefIndex: 51060
		{
			// Constructors
			public ModuloInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C02C-0x000000018972C134
		}
	
		private sealed class ModuloInt64 : ModuloInstruction // TypeDefIndex: 51061
		{
			// Constructors
			public ModuloInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C134-0x000000018972C24C
		}
	
		private sealed class ModuloUInt16 : ModuloInstruction // TypeDefIndex: 51062
		{
			// Constructors
			public ModuloUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C378-0x000000018972C48C
		}
	
		private sealed class ModuloUInt32 : ModuloInstruction // TypeDefIndex: 51063
		{
			// Constructors
			public ModuloUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C48C-0x000000018972C5A0
		}
	
		private sealed class ModuloUInt64 : ModuloInstruction // TypeDefIndex: 51064
		{
			// Constructors
			public ModuloUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C5A0-0x000000018972C6B8
		}
	
		private sealed class ModuloSingle : ModuloInstruction // TypeDefIndex: 51065
		{
			// Constructors
			public ModuloSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C24C-0x000000018972C378
		}
	
		private sealed class ModuloDouble : ModuloInstruction // TypeDefIndex: 51066
		{
			// Constructors
			public ModuloDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972B9B0-0x000000018972BADC
		}
	
		// Constructors
		private ModuloInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018972BADC-0x000000018972BEEC
	}

	internal abstract class MulInstruction : Instruction // TypeDefIndex: 51076
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018972CBE8-0x000000018972CC14 
	
		// Nested types
		private sealed class MulInt16 : MulInstruction // TypeDefIndex: 51068
		{
			// Constructors
			public MulInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972CC14-0x000000018972CD28
		}
	
		private sealed class MulInt32 : MulInstruction // TypeDefIndex: 51069
		{
			// Constructors
			public MulInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972CD28-0x000000018972CE2C
		}
	
		private sealed class MulInt64 : MulInstruction // TypeDefIndex: 51070
		{
			// Constructors
			public MulInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972CE2C-0x000000018972CF40
		}
	
		private sealed class MulUInt16 : MulInstruction // TypeDefIndex: 51071
		{
			// Constructors
			public MulUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972DD68-0x000000018972DE7C
		}
	
		private sealed class MulUInt32 : MulInstruction // TypeDefIndex: 51072
		{
			// Constructors
			public MulUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972DE7C-0x000000018972DF8C
		}
	
		private sealed class MulUInt64 : MulInstruction // TypeDefIndex: 51073
		{
			// Constructors
			public MulUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972DF8C-0x000000018972E0A0
		}
	
		private sealed class MulSingle : MulInstruction // TypeDefIndex: 51074
		{
			// Constructors
			public MulSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972DC48-0x000000018972DD68
		}
	
		private sealed class MulDouble : MulInstruction // TypeDefIndex: 51075
		{
			// Constructors
			public MulDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972C6B8-0x000000018972C7D8
		}
	
		// Constructors
		private MulInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018972C7D8-0x000000018972CBE8
	}

	internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 51083
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018972D25C-0x000000018972D288 
	
		// Nested types
		private sealed class MulOvfInt16 : MulOvfInstruction // TypeDefIndex: 51077
		{
			// Constructors
			public MulOvfInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972D288-0x000000018972D480
		}
	
		private sealed class MulOvfInt32 : MulOvfInstruction // TypeDefIndex: 51078
		{
			// Constructors
			public MulOvfInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972D480-0x000000018972D618
		}
	
		private sealed class MulOvfInt64 : MulOvfInstruction // TypeDefIndex: 51079
		{
			// Constructors
			public MulOvfInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972D618-0x000000018972D788
		}
	
		private sealed class MulOvfUInt16 : MulOvfInstruction // TypeDefIndex: 51080
		{
			// Constructors
			public MulOvfUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972D788-0x000000018972D968
		}
	
		private sealed class MulOvfUInt32 : MulOvfInstruction // TypeDefIndex: 51081
		{
			// Constructors
			public MulOvfUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972D968-0x000000018972DAD8
		}
	
		private sealed class MulOvfUInt64 : MulOvfInstruction // TypeDefIndex: 51082
		{
			// Constructors
			public MulOvfUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972DAD8-0x000000018972DC48
		}
	
		// Constructors
		private MulOvfInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018972CF40-0x000000018972D25C
	}

	internal abstract class NegateInstruction : Instruction // TypeDefIndex: 51089
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_Single; // 0x18
		private static Instruction s_Double; // 0x20
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018972EBD4-0x000000018972EC00 
	
		// Nested types
		private sealed class NegateInt16 : NegateInstruction // TypeDefIndex: 51084
		{
			// Constructors
			public NegateInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972EC00-0x000000018972EC7C
		}
	
		private sealed class NegateInt32 : NegateInstruction // TypeDefIndex: 51085
		{
			// Constructors
			public NegateInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972EC7C-0x000000018972ECF4
		}
	
		private sealed class NegateInt64 : NegateInstruction // TypeDefIndex: 51086
		{
			// Constructors
			public NegateInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972ECF4-0x000000018972ED84
		}
	
		private sealed class NegateSingle : NegateInstruction // TypeDefIndex: 51087
		{
			// Constructors
			public NegateSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972ED84-0x000000018972EE1C
		}
	
		private sealed class NegateDouble : NegateInstruction // TypeDefIndex: 51088
		{
			// Constructors
			public NegateDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E868-0x000000018972E900
		}
	
		// Constructors
		private NegateInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018972E900-0x000000018972EBD4
	}

	internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 51093
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018972E558-0x000000018972E584 
	
		// Nested types
		private sealed class NegateCheckedInt32 : NegateCheckedInstruction // TypeDefIndex: 51090
		{
			// Constructors
			public NegateCheckedInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E6A4-0x000000018972E788
		}
	
		private sealed class NegateCheckedInt16 : NegateCheckedInstruction // TypeDefIndex: 51091
		{
			// Constructors
			public NegateCheckedInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E584-0x000000018972E6A4
		}
	
		private sealed class NegateCheckedInt64 : NegateCheckedInstruction // TypeDefIndex: 51092
		{
			// Constructors
			public NegateCheckedInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972E788-0x000000018972E868
		}
	
		// Constructors
		private NegateCheckedInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x000000018972E37C-0x000000018972E558
	}

	internal class NewInstruction : Instruction // TypeDefIndex: 51094
	{
		// Fields
		protected readonly ConstructorInfo _constructor; // 0x10
		protected readonly int _argumentCount; // 0x18
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972F140-0x000000018972F16C 
	
		// Constructors
		public NewInstruction() {} // Dummy constructor
		public NewInstruction(ConstructorInfo constructor, int argumentCount) {} // 0x0000000182738A30-0x0000000182738A50
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972EF08-0x000000018972F014
		protected object[] GetArgs(InterpretedFrame frame, int first) => default; // 0x000000018972EE1C-0x000000018972EF08
		public override string ToString() => default; // 0x000000018972F014-0x000000018972F140
	}

	internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 51095
	{
		// Fields
		private readonly ByRefUpdater[] _byrefArgs; // 0x20
	
		// Properties
		public override string InstructionName { get => default; } // 0x00000001897202C0-0x00000001897202EC 
	
		// Constructors
		public ByRefNewInstruction() {} // Dummy constructor
		internal ByRefNewInstruction(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) {} // 0x0000000183020510-0x0000000183020540
	
		// Methods
		public sealed override int Run(InterpretedFrame frame) => default; // 0x000000018972006C-0x00000001897202C0
	}

	internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 51120
	{
		// Fields
		private static Instruction s_reference; // 0x00
		private static Instruction s_Boolean; // 0x08
		private static Instruction s_SByte; // 0x10
		private static Instruction s_Int16; // 0x18
		private static Instruction s_Char; // 0x20
		private static Instruction s_Int32; // 0x28
		private static Instruction s_Int64; // 0x30
		private static Instruction s_Byte; // 0x38
		private static Instruction s_UInt16; // 0x40
		private static Instruction s_UInt32; // 0x48
		private static Instruction s_UInt64; // 0x50
		private static Instruction s_Single; // 0x58
		private static Instruction s_Double; // 0x60
		private static Instruction s_SByteLiftedToNull; // 0x68
		private static Instruction s_Int16LiftedToNull; // 0x70
		private static Instruction s_CharLiftedToNull; // 0x78
		private static Instruction s_Int32LiftedToNull; // 0x80
		private static Instruction s_Int64LiftedToNull; // 0x88
		private static Instruction s_ByteLiftedToNull; // 0x90
		private static Instruction s_UInt16LiftedToNull; // 0x98
		private static Instruction s_UInt32LiftedToNull; // 0xA0
		private static Instruction s_UInt64LiftedToNull; // 0xA8
		private static Instruction s_SingleLiftedToNull; // 0xB0
		private static Instruction s_DoubleLiftedToNull; // 0xB8
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001897302CC-0x00000001897302F8 
	
		// Nested types
		private sealed class NotEqualBoolean : NotEqualInstruction // TypeDefIndex: 51096
		{
			// Constructors
			public NotEqualBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F260-0x000000018972F30C
		}
	
		private sealed class NotEqualSByte : NotEqualInstruction // TypeDefIndex: 51097
		{
			// Constructors
			public NotEqualSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730824-0x00000001897308D0
		}
	
		private sealed class NotEqualInt16 : NotEqualInstruction // TypeDefIndex: 51098
		{
			// Constructors
			public NotEqualInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897303AC-0x000000018973045C
		}
	
		private sealed class NotEqualChar : NotEqualInstruction // TypeDefIndex: 51099
		{
			// Constructors
			public NotEqualChar() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F520-0x000000018972F5D0
		}
	
		private sealed class NotEqualInt32 : NotEqualInstruction // TypeDefIndex: 51100
		{
			// Constructors
			public NotEqualInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730510-0x00000001897305BC
		}
	
		private sealed class NotEqualInt64 : NotEqualInstruction // TypeDefIndex: 51101
		{
			// Constructors
			public NotEqualInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730670-0x0000000189730720
		}
	
		private sealed class NotEqualByte : NotEqualInstruction // TypeDefIndex: 51102
		{
			// Constructors
			public NotEqualByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F3C0-0x000000018972F46C
		}
	
		private sealed class NotEqualUInt16 : NotEqualInstruction // TypeDefIndex: 51103
		{
			// Constructors
			public NotEqualUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730B10-0x0000000189730BC0
		}
	
		private sealed class NotEqualUInt32 : NotEqualInstruction // TypeDefIndex: 51104
		{
			// Constructors
			public NotEqualUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730C74-0x0000000189730D20
		}
	
		private sealed class NotEqualUInt64 : NotEqualInstruction // TypeDefIndex: 51105
		{
			// Constructors
			public NotEqualUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730DD4-0x0000000189730E84
		}
	
		private sealed class NotEqualSingle : NotEqualInstruction // TypeDefIndex: 51106
		{
			// Constructors
			public NotEqualSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730998-0x0000000189730A5C
		}
	
		private sealed class NotEqualDouble : NotEqualInstruction // TypeDefIndex: 51107
		{
			// Constructors
			public NotEqualDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F698-0x000000018972F75C
		}
	
		private sealed class NotEqualReference : NotEqualInstruction // TypeDefIndex: 51108
		{
			// Constructors
			public NotEqualReference() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730720-0x0000000189730770
		}
	
		private sealed class NotEqualSByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 51109
		{
			// Constructors
			public NotEqualSByteLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730770-0x0000000189730824
		}
	
		private sealed class NotEqualInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 51110
		{
			// Constructors
			public NotEqualInt16LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897302F8-0x00000001897303AC
		}
	
		private sealed class NotEqualCharLiftedToNull : NotEqualInstruction // TypeDefIndex: 51111
		{
			// Constructors
			public NotEqualCharLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F46C-0x000000018972F520
		}
	
		private sealed class NotEqualInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 51112
		{
			// Constructors
			public NotEqualInt32LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973045C-0x0000000189730510
		}
	
		private sealed class NotEqualInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 51113
		{
			// Constructors
			public NotEqualInt64LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897305BC-0x0000000189730670
		}
	
		private sealed class NotEqualByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 51114
		{
			// Constructors
			public NotEqualByteLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F30C-0x000000018972F3C0
		}
	
		private sealed class NotEqualUInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 51115
		{
			// Constructors
			public NotEqualUInt16LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730A5C-0x0000000189730B10
		}
	
		private sealed class NotEqualUInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 51116
		{
			// Constructors
			public NotEqualUInt32LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730BC0-0x0000000189730C74
		}
	
		private sealed class NotEqualUInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 51117
		{
			// Constructors
			public NotEqualUInt64LiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189730D20-0x0000000189730DD4
		}
	
		private sealed class NotEqualSingleLiftedToNull : NotEqualInstruction // TypeDefIndex: 51118
		{
			// Constructors
			public NotEqualSingleLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897308D0-0x0000000189730998
		}
	
		private sealed class NotEqualDoubleLiftedToNull : NotEqualInstruction // TypeDefIndex: 51119
		{
			// Constructors
			public NotEqualDoubleLiftedToNull() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F5D0-0x000000018972F698
		}
	
		// Constructors
		private NotEqualInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type, bool liftedToNull) => default; // 0x000000018972F75C-0x00000001897302CC
	}

	internal abstract class NotInstruction : Instruction // TypeDefIndex: 51130
	{
		// Fields
		public static Instruction s_Boolean; // 0x00
		public static Instruction s_Int64; // 0x08
		public static Instruction s_Int32; // 0x10
		public static Instruction s_Int16; // 0x18
		public static Instruction s_UInt64; // 0x20
		public static Instruction s_UInt32; // 0x28
		public static Instruction s_UInt16; // 0x30
		public static Instruction s_Byte; // 0x38
		public static Instruction s_SByte; // 0x40
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189731314-0x0000000189731340 
	
		// Nested types
		private sealed class NotBoolean : NotInstruction // TypeDefIndex: 51121
		{
			// Constructors
			public NotBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F16C-0x000000018972F1E8
		}
	
		private sealed class NotInt64 : NotInstruction // TypeDefIndex: 51122
		{
			// Constructors
			public NotInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189731434-0x00000001897314C4
		}
	
		private sealed class NotInt32 : NotInstruction // TypeDefIndex: 51123
		{
			// Constructors
			public NotInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897313BC-0x0000000189731434
		}
	
		private sealed class NotInt16 : NotInstruction // TypeDefIndex: 51124
		{
			// Constructors
			public NotInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189731340-0x00000001897313BC
		}
	
		private sealed class NotUInt64 : NotInstruction // TypeDefIndex: 51125
		{
			// Constructors
			public NotUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189731648-0x00000001897316D8
		}
	
		private sealed class NotUInt32 : NotInstruction // TypeDefIndex: 51126
		{
			// Constructors
			public NotUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897315B8-0x0000000189731648
		}
	
		private sealed class NotUInt16 : NotInstruction // TypeDefIndex: 51127
		{
			// Constructors
			public NotUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973153C-0x00000001897315B8
		}
	
		private sealed class NotByte : NotInstruction // TypeDefIndex: 51128
		{
			// Constructors
			public NotByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018972F1E8-0x000000018972F260
		}
	
		private sealed class NotSByte : NotInstruction // TypeDefIndex: 51129
		{
			// Constructors
			public NotSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897314C4-0x000000018973153C
		}
	
		// Constructors
		private NotInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189730E84-0x0000000189731314
	}

	internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 51131
	{
		// Fields
		public static readonly Instruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x00000001897317A8-0x00000001897317D4 
	
		// Constructors
		private NullCheckInstruction() {} // 0x000000018350B670-0x000000018350B680
		static NullCheckInstruction() {} // 0x0000000189731744-0x00000001897317A8
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001897316D8-0x0000000189731744
	}

	internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 51135
	{
		// Fields
		internal readonly TypeCode _from; // 0x10
		internal readonly TypeCode _to; // 0x14
		private readonly bool _isLiftedToNull; // 0x18
	
		// Properties
		public override string InstructionName { get; } // 0x0000000189731E8C-0x0000000189731EB8 
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
	
		// Nested types
		internal sealed class Unchecked : NumericConvertInstruction // TypeDefIndex: 51132
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189737D9C-0x0000000189737DC8 
	
			// Constructors
			public Unchecked() {} // Dummy constructor
			public Unchecked(TypeCode from, TypeCode to, bool isLiftedToNull) {} // 0x0000000183D73A90-0x0000000183D73AA0
	
			// Methods
			protected override object Convert(object obj) => default; // 0x0000000189737B3C-0x0000000189737D9C
			private object ConvertInt32(int obj) => default; // 0x00000001897373C4-0x0000000189737654
			private object ConvertInt64(long obj) => default; // 0x0000000189737654-0x00000001897378A4
			private object ConvertUInt64(ulong obj) => default; // 0x00000001897378A4-0x0000000189737B3C
			private object ConvertDouble(double obj) => default; // 0x0000000189737144-0x00000001897373C4
		}
	
		internal sealed class Checked : NumericConvertInstruction // TypeDefIndex: 51133
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189722284-0x00000001897222B0 
	
			// Constructors
			public Checked() {} // Dummy constructor
			public Checked(TypeCode from, TypeCode to, bool isLiftedToNull) {} // 0x0000000183D73A90-0x0000000183D73AA0
	
			// Methods
			protected override object Convert(object obj) => default; // 0x0000000189722024-0x0000000189722284
			private object ConvertInt32(int obj) => default; // 0x00000001897215D8-0x000000018972191C
			private object ConvertInt64(long obj) => default; // 0x000000018972191C-0x0000000189721C68
			private object ConvertUInt64(ulong obj) => default; // 0x0000000189721C68-0x0000000189722024
			private object ConvertDouble(double obj) => default; // 0x00000001897211E8-0x00000001897215D8
		}
	
		internal sealed class ToUnderlying : NumericConvertInstruction // TypeDefIndex: 51134
		{
			// Properties
			public override string InstructionName { get => default; } // 0x0000000189736A18-0x0000000189736A44 
	
			// Constructors
			public ToUnderlying() {} // Dummy constructor
			public ToUnderlying(TypeCode to, bool isLiftedToNull) {} // 0x0000000183D75320-0x0000000183D75330
	
			// Methods
			protected override object Convert(object obj) => default; // 0x0000000189736790-0x0000000189736A18
		}
	
		// Constructors
		protected NumericConvertInstruction() {} // Dummy constructor
		protected NumericConvertInstruction(TypeCode from, TypeCode to, bool isLiftedToNull) {} // 0x0000000183D73A90-0x0000000183D73AA0
	
		// Methods
		public sealed override int Run(InterpretedFrame frame) => default; // 0x0000000189731C6C-0x0000000189731D40
		protected abstract object Convert(object obj);
		public override string ToString() => default; // 0x0000000189731D40-0x0000000189731E8C
	}

	internal abstract class OrInstruction : Instruction // TypeDefIndex: 51145
	{
		// Fields
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Int32; // 0x10
		private static Instruction s_Int64; // 0x18
		private static Instruction s_Byte; // 0x20
		private static Instruction s_UInt16; // 0x28
		private static Instruction s_UInt32; // 0x30
		private static Instruction s_UInt64; // 0x38
		private static Instruction s_Boolean; // 0x40
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x00000001897324F0-0x000000018973251C 
	
		// Nested types
		private sealed class OrSByte : OrInstruction // TypeDefIndex: 51136
		{
			// Constructors
			public OrSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973273C-0x00000001897327EC
		}
	
		private sealed class OrInt16 : OrInstruction // TypeDefIndex: 51137
		{
			// Constructors
			public OrInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973251C-0x00000001897325CC
		}
	
		private sealed class OrInt32 : OrInstruction // TypeDefIndex: 51138
		{
			// Constructors
			public OrInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897325CC-0x000000018973267C
		}
	
		private sealed class OrInt64 : OrInstruction // TypeDefIndex: 51139
		{
			// Constructors
			public OrInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973267C-0x000000018973273C
		}
	
		private sealed class OrByte : OrInstruction // TypeDefIndex: 51140
		{
			// Constructors
			public OrByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189731FB0-0x0000000189732060
		}
	
		private sealed class OrUInt16 : OrInstruction // TypeDefIndex: 51141
		{
			// Constructors
			public OrUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897327EC-0x000000018973289C
		}
	
		private sealed class OrUInt32 : OrInstruction // TypeDefIndex: 51142
		{
			// Constructors
			public OrUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973289C-0x0000000189732958
		}
	
		private sealed class OrUInt64 : OrInstruction // TypeDefIndex: 51143
		{
			// Constructors
			public OrUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189732958-0x0000000189732A18
		}
	
		private sealed class OrBoolean : OrInstruction // TypeDefIndex: 51144
		{
			// Constructors
			public OrBoolean() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189731EB8-0x0000000189731FB0
		}
	
		// Constructors
		private OrInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189732060-0x00000001897324F0
	}

	internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 51154
	{
		// Fields
		private static Instruction s_SByte; // 0x00
		private static Instruction s_Int16; // 0x08
		private static Instruction s_Int32; // 0x10
		private static Instruction s_Int64; // 0x18
		private static Instruction s_Byte; // 0x20
		private static Instruction s_UInt16; // 0x28
		private static Instruction s_UInt32; // 0x30
		private static Instruction s_UInt64; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189733BA4-0x0000000189733BD0 
	
		// Nested types
		private sealed class RightShiftSByte : RightShiftInstruction // TypeDefIndex: 51146
		{
			// Constructors
			public RightShiftSByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733E10-0x0000000189733ED0
		}
	
		private sealed class RightShiftInt16 : RightShiftInstruction // TypeDefIndex: 51147
		{
			// Constructors
			public RightShiftInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733BD0-0x0000000189733C90
		}
	
		private sealed class RightShiftInt32 : RightShiftInstruction // TypeDefIndex: 51148
		{
			// Constructors
			public RightShiftInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733C90-0x0000000189733D44
		}
	
		private sealed class RightShiftInt64 : RightShiftInstruction // TypeDefIndex: 51149
		{
			// Constructors
			public RightShiftInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733D44-0x0000000189733E10
		}
	
		private sealed class RightShiftByte : RightShiftInstruction // TypeDefIndex: 51150
		{
			// Constructors
			public RightShiftByte() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897336D4-0x0000000189733794
		}
	
		private sealed class RightShiftUInt16 : RightShiftInstruction // TypeDefIndex: 51151
		{
			// Constructors
			public RightShiftUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733ED0-0x0000000189733F90
		}
	
		private sealed class RightShiftUInt32 : RightShiftInstruction // TypeDefIndex: 51152
		{
			// Constructors
			public RightShiftUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189733F90-0x000000018973405C
		}
	
		private sealed class RightShiftUInt64 : RightShiftInstruction // TypeDefIndex: 51153
		{
			// Constructors
			public RightShiftUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973405C-0x0000000189734128
		}
	
		// Constructors
		private RightShiftInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189733794-0x0000000189733BA4
	}

	internal sealed class RuntimeVariables : IRuntimeVariables // TypeDefIndex: 51155
	{
		// Fields
		private readonly IStrongBox[] _boxes; // 0x10
	
		// Constructors
		public RuntimeVariables() {} // Dummy constructor
		private RuntimeVariables(IStrongBox[] boxes) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		internal static IRuntimeVariables Create(IStrongBox[] boxes) => default; // 0x00000001897343A0-0x0000000189734400
	}

	internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 51156
	{
		// Fields
		private readonly object _value; // 0x10
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972AE70-0x000000018972AE9C 
	
		// Constructors
		public LoadObjectInstruction() {} // Dummy constructor
		internal LoadObjectInstruction(object value) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972AD84-0x000000018972ADE4
		public override string ToString() => default; // 0x000000018972ADE4-0x000000018972AE70
	}

	internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 51157
	{
		// Fields
		private readonly uint _index; // 0x10
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x000000018972AA1C-0x000000018972AA48 
	
		// Constructors
		public LoadCachedObjectInstruction() {} // Dummy constructor
		internal LoadCachedObjectInstruction(uint index) {} // 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x000000018972A870-0x000000018972A8F0
		public override string ToDebugString(int instructionIndex, object cookie, System.Func<int, int> labelIndexer, IReadOnlyList<object> objects) => default; // 0x000000018972A8F0-0x000000018972A9C0
		public override string ToString() => default; // 0x000000018972A9C0-0x000000018972AA1C
	}

	internal sealed class PopInstruction : Instruction // TypeDefIndex: 51158
	{
		// Fields
		internal static readonly PopInstruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189732D44-0x0000000189732D70 
	
		// Constructors
		private PopInstruction() {} // 0x000000018350B670-0x000000018350B680
		static PopInstruction() {} // 0x0000000189732CE0-0x0000000189732D44
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189732CB8-0x0000000189732CE0
	}

	internal sealed class DupInstruction : Instruction // TypeDefIndex: 51159
	{
		// Fields
		internal static readonly DupInstruction Instance; // 0x00
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189723B64-0x0000000189723B90 
	
		// Constructors
		private DupInstruction() {} // 0x000000018350B670-0x000000018350B680
		static DupInstruction() {} // 0x0000000189723B00-0x0000000189723B64
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189723AD8-0x0000000189723B00
	}

	internal abstract class SubInstruction : Instruction // TypeDefIndex: 51168
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
		private static Instruction s_Single; // 0x30
		private static Instruction s_Double; // 0x38
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189734F08-0x0000000189734F34 
	
		// Nested types
		private sealed class SubInt16 : SubInstruction // TypeDefIndex: 51160
		{
			// Constructors
			public SubInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189734F34-0x0000000189735048
		}
	
		private sealed class SubInt32 : SubInstruction // TypeDefIndex: 51161
		{
			// Constructors
			public SubInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735048-0x000000018973514C
		}
	
		private sealed class SubInt64 : SubInstruction // TypeDefIndex: 51162
		{
			// Constructors
			public SubInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x000000018973514C-0x0000000189735260
		}
	
		private sealed class SubUInt16 : SubInstruction // TypeDefIndex: 51163
		{
			// Constructors
			public SubUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897360A0-0x00000001897361B4
		}
	
		private sealed class SubUInt32 : SubInstruction // TypeDefIndex: 51164
		{
			// Constructors
			public SubUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897361B4-0x00000001897362C4
		}
	
		private sealed class SubUInt64 : SubInstruction // TypeDefIndex: 51165
		{
			// Constructors
			public SubUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897362C4-0x00000001897363D8
		}
	
		private sealed class SubSingle : SubInstruction // TypeDefIndex: 51166
		{
			// Constructors
			public SubSingle() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735F7C-0x00000001897360A0
		}
	
		private sealed class SubDouble : SubInstruction // TypeDefIndex: 51167
		{
			// Constructors
			public SubDouble() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897349D4-0x0000000189734AF8
		}
	
		// Constructors
		private SubInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189734AF8-0x0000000189734F08
	}

	internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 51175
	{
		// Fields
		private static Instruction s_Int16; // 0x00
		private static Instruction s_Int32; // 0x08
		private static Instruction s_Int64; // 0x10
		private static Instruction s_UInt16; // 0x18
		private static Instruction s_UInt32; // 0x20
		private static Instruction s_UInt64; // 0x28
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x000000018973557C-0x00000001897355A8 
	
		// Nested types
		private sealed class SubOvfInt16 : SubOvfInstruction // TypeDefIndex: 51169
		{
			// Constructors
			public SubOvfInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897355A8-0x00000001897357A0
		}
	
		private sealed class SubOvfInt32 : SubOvfInstruction // TypeDefIndex: 51170
		{
			// Constructors
			public SubOvfInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897357A0-0x0000000189735938
		}
	
		private sealed class SubOvfInt64 : SubOvfInstruction // TypeDefIndex: 51171
		{
			// Constructors
			public SubOvfInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735938-0x0000000189735AA8
		}
	
		private sealed class SubOvfUInt16 : SubOvfInstruction // TypeDefIndex: 51172
		{
			// Constructors
			public SubOvfUInt16() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735AA8-0x0000000189735C9C
		}
	
		private sealed class SubOvfUInt32 : SubOvfInstruction // TypeDefIndex: 51173
		{
			// Constructors
			public SubOvfUInt32() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735C9C-0x0000000189735E0C
		}
	
		private sealed class SubOvfUInt64 : SubOvfInstruction // TypeDefIndex: 51174
		{
			// Constructors
			public SubOvfUInt64() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189735E0C-0x0000000189735F7C
		}
	
		// Constructors
		private SubOvfInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type type) => default; // 0x0000000189735260-0x000000018973557C
	}

	internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 51176
	{
		// Fields
		private readonly LightDelegateCreator _creator; // 0x10
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x00000001897224DC-0x0000000189722504 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189722504-0x0000000189722530 
	
		// Constructors
		public CreateDelegateInstruction() {} // Dummy constructor
		internal CreateDelegateInstruction(LightDelegateCreator delegateCreator) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x00000001897223B0-0x00000001897224DC
	}

	internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 51177
	{
		// Fields
		private readonly System.Type _type; // 0x10
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189736CE4-0x0000000189736D10 
	
		// Constructors
		public TypeIsInstruction() {} // Dummy constructor
		internal TypeIsInstruction(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189736C34-0x0000000189736C8C
		public override string ToString() => default; // 0x0000000189736C8C-0x0000000189736CE4
	}

	internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 51178
	{
		// Fields
		private readonly System.Type _type; // 0x10
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189736B08-0x0000000189736B34 
	
		// Constructors
		public TypeAsInstruction() {} // Dummy constructor
		internal TypeAsInstruction(System.Type type) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189736A44-0x0000000189736AB0
		public override string ToString() => default; // 0x0000000189736AB0-0x0000000189736B08
	}

	internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 51179
	{
		// Fields
		public static readonly TypeEqualsInstruction Instance; // 0x00
	
		// Properties
		public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189736C08-0x0000000189736C34 
	
		// Constructors
		private TypeEqualsInstruction() {} // 0x000000018350B670-0x000000018350B680
		static TypeEqualsInstruction() {} // 0x0000000189736BA4-0x0000000189736C08
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189736B34-0x0000000189736BA4
	}

	internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 51187
	{
		// Fields
		private static NullableMethodCallInstruction s_hasValue; // 0x00
		private static NullableMethodCallInstruction s_value; // 0x08
		private static NullableMethodCallInstruction s_equals; // 0x10
		private static NullableMethodCallInstruction s_getHashCode; // 0x18
		private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
		private static NullableMethodCallInstruction s_toString; // 0x28
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189731C40-0x0000000189731C6C 
	
		// Nested types
		private sealed class HasValue : NullableMethodCallInstruction // TypeDefIndex: 51180
		{
			// Constructors
			public HasValue() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897280CC-0x0000000189728108
		}
	
		private sealed class GetValue : NullableMethodCallInstruction // TypeDefIndex: 51181
		{
			// Constructors
			public GetValue() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189728068-0x00000001897280CC
		}
	
		private sealed class GetValueOrDefault : NullableMethodCallInstruction // TypeDefIndex: 51182
		{
			// Fields
			private readonly System.Type _defaultValueType; // 0x10
	
			// Constructors
			public GetValueOrDefault() {} // Dummy constructor
			public GetValueOrDefault(MethodInfo mi) {} // 0x0000000189728038-0x0000000189728068
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189727FD8-0x0000000189728038
		}
	
		private sealed class GetValueOrDefault1 : NullableMethodCallInstruction // TypeDefIndex: 51183
		{
			// Properties
			public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
			// Constructors
			public GetValueOrDefault1() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189727F84-0x0000000189727FD8
		}
	
		private sealed class EqualsClass : NullableMethodCallInstruction // TypeDefIndex: 51184
		{
			// Properties
			public override int ConsumedStack { get => default; } // 0x0000000182102C70-0x0000000182102C80 
	
			// Constructors
			public EqualsClass() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189725124-0x00000001897251D8
		}
	
		private sealed class ToStringClass : NullableMethodCallInstruction // TypeDefIndex: 51185
		{
			// Constructors
			public ToStringClass() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189736720-0x0000000189736790
		}
	
		private sealed class GetHashCodeClass : NullableMethodCallInstruction // TypeDefIndex: 51186
		{
			// Constructors
			public GetHashCodeClass() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override int Run(InterpretedFrame frame) => default; // 0x0000000189727F2C-0x0000000189727F84
		}
	
		// Constructors
		private NullableMethodCallInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(string method, int argCount, MethodInfo mi) => default; // 0x0000000189731864-0x0000000189731C40
		public static Instruction CreateGetValue() => default; // 0x00000001897317D4-0x0000000189731864
	}

	internal abstract class CastInstruction : Instruction // TypeDefIndex: 51192
	{
		// Fields
		private static CastInstruction s_Boolean; // 0x00
		private static CastInstruction s_Byte; // 0x08
		private static CastInstruction s_Char; // 0x10
		private static CastInstruction s_DateTime; // 0x18
		private static CastInstruction s_Decimal; // 0x20
		private static CastInstruction s_Double; // 0x28
		private static CastInstruction s_Int16; // 0x30
		private static CastInstruction s_Int32; // 0x38
		private static CastInstruction s_Int64; // 0x40
		private static CastInstruction s_SByte; // 0x48
		private static CastInstruction s_Single; // 0x50
		private static CastInstruction s_String; // 0x58
		private static CastInstruction s_UInt16; // 0x60
		private static CastInstruction s_UInt32; // 0x68
		private static CastInstruction s_UInt64; // 0x70
	
		// Properties
		public override int ConsumedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override int ProducedStack { get; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get; } // 0x0000000189720DF4-0x0000000189720E20 
	
		// Nested types
		private sealed class CastInstructionT<T> : CastInstruction // TypeDefIndex: 51188
		{
			// Constructors
			public CastInstructionT() {}
	
			// Methods
			public override int Run(InterpretedFrame frame) => default;
		}
	
		private abstract class CastInstructionNoT : CastInstruction // TypeDefIndex: 51191
		{
			// Fields
			private readonly System.Type _t; // 0x10
	
			// Nested types
			private sealed class Ref : CastInstructionNoT // TypeDefIndex: 51189
			{
				// Constructors
				public Ref() {} // Dummy constructor
				public Ref(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	
				// Methods
				protected override void ConvertNull(InterpretedFrame frame) {} // 0x00000001897335FC-0x0000000189733620
			}
	
			private sealed class Value : CastInstructionNoT // TypeDefIndex: 51190
			{
				// Constructors
				public Value() {} // Dummy constructor
				public Value(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	
				// Methods
				protected override void ConvertNull(InterpretedFrame frame) {} // 0x0000000189737EAC-0x0000000189737EF8
			}
	
			// Constructors
			protected CastInstructionNoT() {} // Dummy constructor
			protected CastInstructionNoT(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public static new CastInstruction Create(System.Type t) => default; // 0x00000001897203EC-0x00000001897204B4
			public override int Run(InterpretedFrame frame) => default; // 0x00000001897204B4-0x000000018972064C
			protected abstract void ConvertNull(InterpretedFrame frame);
		}
	
		// Constructors
		protected CastInstruction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static Instruction Create(System.Type t) => default; // 0x000000018972064C-0x0000000189720DF4
	}

	internal sealed class CastToEnumInstruction : CastInstruction // TypeDefIndex: 51193
	{
		// Fields
		private readonly System.Type _t; // 0x10
	
		// Constructors
		public CastToEnumInstruction() {} // Dummy constructor
		public CastToEnumInstruction(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189721148-0x00000001897211E8
	}

	internal sealed class CastReferenceToEnumInstruction : CastInstruction // TypeDefIndex: 51194
	{
		// Fields
		private readonly System.Type _t; // 0x10
	
		// Constructors
		public CastReferenceToEnumInstruction() {} // Dummy constructor
		public CastReferenceToEnumInstruction(System.Type t) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189720E20-0x0000000189721148
	}

	internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 51196
	{
		// Fields
		private readonly Expression _operand; // 0x10
		private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18
	
		// Properties
		public override int ProducedStack { get => default; } // 0x0000000181168950-0x0000000181168960 
		public override string InstructionName { get => default; } // 0x0000000189732FD0-0x0000000189732FFC 
	
		// Nested types
		private sealed class ExpressionQuoter : ExpressionVisitor // TypeDefIndex: 51195
		{
			// Fields
			private readonly Dictionary<ParameterExpression, LocalVariable> _variables; // 0x10
			private readonly InterpretedFrame _frame; // 0x18
			private readonly Stack<HashSet<ParameterExpression>> _shadowedVars; // 0x20
	
			// Constructors
			public ExpressionQuoter() {} // Dummy constructor
			internal ExpressionQuoter(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) {} // 0x0000000189727D10-0x0000000189727DBC
	
			// Methods
			protected internal override Expression VisitLambda<T>(Expression<T> node) => default;
			protected internal override Expression VisitBlock(BlockExpression node) => default; // 0x0000000189727964-0x0000000189727AE0
			protected override CatchBlock VisitCatchBlock(CatchBlock node) => default; // 0x0000000189727AE0-0x0000000189727C60
			protected internal override Expression VisitParameter(ParameterExpression node) => default; // 0x0000000189727C60-0x0000000189727D10
			private IStrongBox GetBox(ParameterExpression variable) => default; // 0x000000018972788C-0x0000000189727964
		}
	
		// Constructors
		public QuoteInstruction() {} // Dummy constructor
		public QuoteInstruction(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public override int Run(InterpretedFrame frame) => default; // 0x0000000189732F20-0x0000000189732FD0
	}

	internal static class DelegateHelpers // TypeDefIndex: 51198
	{
		// Methods
		internal static System.Type MakeDelegate(System.Type[] types) => default; // 0x00000001897232A0-0x00000001897238FC
	}

	internal static class ScriptingRuntimeHelpers // TypeDefIndex: 51199
	{
		// Methods
		public static object Int32ToObject(int i) => default; // 0x00000001897346FC-0x0000000189734810
		internal static object GetPrimitiveDefaultValue(System.Type type) => default; // 0x0000000189734400-0x00000001897346FC
	}

	internal static class ExceptionHelpers // TypeDefIndex: 51200
	{
		// Methods
		public static void UnwrapAndRethrow(TargetInvocationException exception) {} // 0x00000001897251D8-0x00000001897251F4
	}

	internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 51202
		where TKey : class
	{
		// Fields
		private KeyValuePair<TKey, TValue>[] _keysAndValues;
		private Dictionary<TKey, TValue> _dict;
	
		// Properties
		public TValue this[TKey key] { get => default; set {} }
	
		// Constructors
		public HybridReferenceDictionary() {}
	
		// Methods
		public bool TryGetValue(TKey key, out ref TValue value) {
			value = default;
			return default;
		}
		public void Remove(TKey key) {}
		public bool ContainsKey(TKey key) => default;
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => default;
		[IteratorStateMachine(typeof(_GetEnumeratorWorker_d__7))]
		private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() => default;
	}
}

namespace System.Runtime.CompilerServices
{
	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class RuntimeOps // TypeDefIndex: 51203
	{
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) {
			value = default;
			return default;
		} // 0x000000018973420C-0x0000000189734240
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) => default; // 0x0000000189734240-0x0000000189734280
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) => default; // 0x000000018973416C-0x000000018973420C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool ExpandoCheckVersion(ExpandoObject expando, object version) => default; // 0x0000000189734128-0x0000000189734150
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) {} // 0x0000000189734150-0x000000018973416C
	}

	public class CallSite // TypeDefIndex: 51204
	{
		// Fields
		internal readonly CallSiteBinder _binder; // 0x10
		internal bool _match; // 0x18
	
		// Properties
		public CallSiteBinder Binder { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public CallSite() {} // Dummy constructor
		internal CallSite(CallSiteBinder binder) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class CallSite<T> : CallSite // TypeDefIndex: 51206
		where T : class
	{
		// Fields
		public T Target;
		internal T[] Rules;
		private static T s_cachedUpdate;
		private static T s_cachedNoMatch;
	
		// Properties
		public T Update { get => default; }
	
		// Constructors
		private CallSite(CallSiteBinder binder) {}
		private CallSite() {}
	
		// Methods
		internal CallSite<T> CreateMatchMaker() => default;
		public static CallSite<T> Create(CallSiteBinder binder) => default;
		private T GetUpdateDelegate() => default;
		private T GetUpdateDelegate(ref ref T addr) => default;
		internal void AddRule(T newRule) {}
		internal void MoveRule(int i) {}
		internal T MakeUpdateDelegate() => default;
		private T CreateCustomUpdateDelegate(MethodInfo invoke) => default;
		private T CreateCustomNoMatchDelegate(MethodInfo invoke) => default;
		private static Expression Convert(Expression arg, System.Type type) => default;
	}

	public abstract class CallSiteBinder // TypeDefIndex: 51208
	{
		// Fields
		internal Dictionary<System.Type, object> Cache; // 0x10
	
		// Properties
		public static LabelTarget UpdateLabel { get; } // 0x0000000189720368-0x00000001897203B8 
	
		// Nested types
		private sealed class LambdaSignature<T> // TypeDefIndex: 51207
			where T : class
		{
			// Fields
			private static LambdaSignature<T> s_instance;
			internal readonly ReadOnlyCollection<ParameterExpression> Parameters;
			internal readonly LabelTarget ReturnLabel;
	
			// Properties
			internal static LambdaSignature<T> Instance { get => default; }
	
			// Constructors
			private LambdaSignature() {}
		}
	
		// Constructors
		protected CallSiteBinder() {} // 0x000000018350B670-0x000000018350B680
		static CallSiteBinder() {} // 0x00000001897202EC-0x0000000189720368
	
		// Methods
		public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);
		public virtual T BindDelegate<T>(CallSite<T> site, object[] args)
			where T : class => default;
		internal T BindCore<T>(CallSite<T> site, object[] args)
			where T : class => default;
		protected void CacheTarget<T>(T target)
			where T : class {}
		private static Expression<T> Stitch<T>(Expression binding, LambdaSignature<T> signature)
			where T : class => default;
		internal RuleCache<T> GetRuleCache<T>()
			where T : class => default;
	}

	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class CallSiteOps // TypeDefIndex: 51209
	{
		// Methods
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site)
			where T : class => default;
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool SetNotMatched(CallSite site) => default; // 0x00000001897203D0-0x00000001897203EC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static bool GetMatch(CallSite site) => default; // 0x0000000187F81224-0x0000000187F8123C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void ClearMatch(CallSite site) {} // 0x00000001897203B8-0x00000001897203D0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void AddRule<T>(CallSite<T> site, T rule)
			where T : class {}
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void UpdateRules<T>(CallSite<T> @this, int matched)
			where T : class {}
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetRules<T>(CallSite<T> site)
			where T : class => default;
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static RuleCache<T> GetRuleCache<T>(CallSite<T> site)
			where T : class => default;
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static void MoveRule<T>(RuleCache<T> cache, T rule, int i)
			where T : class {}
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T[] GetCachedRules<T>(RuleCache<T> cache)
			where T : class => default;
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("do not use this method", true)]
		public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args)
			where T : class => default;
	}

	[DefaultMember("Item")]
	public interface IRuntimeVariables // TypeDefIndex: 51210
	{
	}

	[Serializable]
	public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, IList // TypeDefIndex: 51212
	{
		// Fields
		private T[] _items;
		private int _size;
		private int _version;
	
		// Properties
		public int Capacity { set {} }
		public int Count { get => default; }
		public T this[int index] { get => default; set {} }
		bool ICollection<T>.IsReadOnly { get => default; }
		bool IList.IsReadOnly { get => default; }
		bool IList.IsFixedSize { get => default; }
		object IList.this[int index] { get => default; set {} }
		bool ICollection.IsSynchronized { get => default; }
		object ICollection.SyncRoot { get => default; }
	
		// Nested types
		[Serializable]
		private class Enumerator : IEnumerator<T> // TypeDefIndex: 51211
		{
			// Fields
			private readonly ReadOnlyCollectionBuilder<T> _builder;
			private readonly int _version;
			private int _index;
			private T _current;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator() {} // Dummy constructor
			internal Enumerator(ReadOnlyCollectionBuilder<T> builder) {}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public ReadOnlyCollectionBuilder() {}
		public ReadOnlyCollectionBuilder(int capacity) {}
	
		// Methods
		public int IndexOf(T item) => default;
		public void Insert(int index, T item) {}
		public void RemoveAt(int index) {}
		public void Add(T item) {}
		public void Clear() {}
		public bool Contains(T item) => default;
		public void CopyTo(T[] array, int arrayIndex) {}
		public bool Remove(T item) => default;
		public IEnumerator<T> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		int IList.Add(object value) => default;
		bool IList.Contains(object value) => default;
		int IList.IndexOf(object value) => default;
		void IList.Insert(int index, object value) {}
		void IList.Remove(object value) {}
		void ICollection.CopyTo(Array array, int index) {}
		public T[] ToArray() => default;
		public ReadOnlyCollection<T> ToReadOnlyCollection() => default;
		private void EnsureCapacity(int min) {}
		private static bool IsCompatibleObject(object value) => default;
		private static void ValidateNullValue(object value, string argument) {}
	}

	[DebuggerStepThrough]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class RuleCache<T> // TypeDefIndex: 51213
		where T : class
	{
		// Fields
		private T[] _rules;
		private readonly object _cacheLock;
	
		// Constructors
		internal RuleCache() {}
	
		// Methods
		internal T[] GetRules() => default;
		internal void MoveRule(T rule, int i) {}
		internal void AddRule(T newRule) {}
		private static T[] AddOrInsert(T[] rules, T item) => default;
	}

	internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T> // TypeDefIndex: 51214
	{
		// Constructors
		public TrueReadOnlyCollection() {} // Dummy constructor
		public TrueReadOnlyCollection(params T[] list) {}
	}

	public class StrongBox<T> : IStrongBox // TypeDefIndex: 51215
	{
		// Fields
		public T Value;
	
		// Properties
		object IStrongBox.Value { get => default; set {} }
	
		// Constructors
		public StrongBox() {}
		public StrongBox(T value) {}
	}

	public interface IStrongBox // TypeDefIndex: 51216
	{
		// Properties
		object Value { get; set; }
	}
}

namespace System.Security.Cryptography
{
	public sealed class AesManaged : Aes // TypeDefIndex: 50634
	{
		// Fields
		private RijndaelManaged m_rijndael; // 0x48
	
		// Properties
		public override int FeedbackSize { get => default; } // 0x00000001896D1798-0x00000001896D17BC 
		public override byte[] IV { get => default; set {} } // 0x00000001896D17BC-0x00000001896D17E0 0x00000001896D1870-0x00000001896D1894
		public override byte[] Key { get => default; set {} } // 0x00000001896D1804-0x00000001896D1828 0x00000001896D18B8-0x00000001896D18DC
		public override int KeySize { get => default; set {} } // 0x00000001896D17E0-0x00000001896D1804 0x00000001896D1894-0x00000001896D18B8
		public override CipherMode Mode { get => default; set {} } // 0x00000001896D1828-0x00000001896D184C 0x00000001896D18DC-0x00000001896D196C
		public override PaddingMode Padding { get => default; set {} } // 0x00000001896D184C-0x00000001896D1870 0x00000001896D196C-0x00000001896D1990
	
		// Constructors
		public AesManaged() {} // 0x00000001896D16C0-0x00000001896D1798
	
		// Methods
		public override ICryptoTransform CreateDecryptor() => default; // 0x00000001896D13D8-0x00000001896D13FC
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) => default; // 0x00000001896D124C-0x00000001896D13D8
		public override ICryptoTransform CreateEncryptor() => default; // 0x00000001896D1588-0x00000001896D15AC
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) => default; // 0x00000001896D13FC-0x00000001896D1588
		protected override void Dispose(bool disposing) {} // 0x00000001896D15AC-0x00000001896D1678
		public override void GenerateIV() {} // 0x00000001896D1678-0x00000001896D169C
		public override void GenerateKey() {} // 0x00000001896D169C-0x00000001896D16C0
	}

	public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 50635
	{
		// Properties
		public override byte[] IV { get => default; set {} } // 0x0000000183B74A00-0x0000000183B74A10 0x00000001839D97F0-0x00000001839D9800
		public override byte[] Key { get => default; set {} } // 0x0000000183B5CD80-0x0000000183B5CD90 0x0000000183363C30-0x0000000183363C40
		public override int KeySize { get => default; set {} } // 0x0000000183D4EC30-0x0000000183D4EC40 0x00000001896D1244-0x00000001896D124C
		public override int FeedbackSize { get => default; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public override CipherMode Mode { get => default; set {} } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183CB2D40-0x0000000183CB2D60
		public override PaddingMode Padding { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183CF53C0-0x0000000183CF53D0
	
		// Constructors
		public AesCryptoServiceProvider() {} // 0x00000001839CF950-0x00000001839CF9B0
	
		// Methods
		public override void GenerateIV() {} // 0x00000001896D11F4-0x00000001896D121C
		public override void GenerateKey() {} // 0x00000001896D121C-0x00000001896D1244
		public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) => default; // 0x00000001832415E0-0x0000000183241690
		public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) => default; // 0x00000001896D10FC-0x00000001896D11F4
		public override ICryptoTransform CreateDecryptor() => default; // 0x0000000182A4A790-0x0000000182A4A7E0
		public override ICryptoTransform CreateEncryptor() => default; // 0x000000018917A318-0x000000018917A360
		protected override void Dispose(bool disposing) {} // 0x0000000183A13AE0-0x0000000183A13AF0
	}

	internal class AesTransform : SymmetricTransform // TypeDefIndex: 50636
	{
		// Fields
		private uint[] expandedKey; // 0x58
		private int Nk; // 0x60
		private int Nr; // 0x64
		private static readonly uint[] Rcon; // 0x00
		private static readonly byte[] SBox; // 0x08
		private static readonly byte[] iSBox; // 0x10
		private static readonly uint[] T0; // 0x18
		private static readonly uint[] T1; // 0x20
		private static readonly uint[] T2; // 0x28
		private static readonly uint[] T3; // 0x30
		private static readonly uint[] iT0; // 0x38
		private static readonly uint[] iT1; // 0x40
		private static readonly uint[] iT2; // 0x48
		private static readonly uint[] iT3; // 0x50
	
		// Constructors
		public AesTransform() {} // Dummy constructor
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv) {} // 0x0000000183241690-0x0000000183241BB0
		static AesTransform() {} // 0x0000000182563A80-0x0000000182563EB0
	
		// Methods
		protected override void ECB(byte[] input, byte[] output) {} // 0x0000000182ECE210-0x0000000182ECE240
		private uint SubByte(uint a) => default; // 0x0000000183241BB0-0x0000000183241CB0
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) {} // 0x00000001896D1990-0x00000001896D439C
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) {} // 0x0000000182ECE240-0x0000000182ED10E0
	}

	public sealed class SHA256CryptoServiceProvider : SHA256 // TypeDefIndex: 50637
	{
		// Fields
		private static byte[] Empty; // 0x00
		private SHA256 hash; // 0x28
	
		// Constructors
		public SHA256CryptoServiceProvider() {} // 0x00000001896EC85C-0x00000001896EC8C8
		static SHA256CryptoServiceProvider() {} // 0x00000001896EC7F8-0x00000001896EC85C
	
		// Methods
		public override void Initialize() {} // 0x00000001896EC7D4-0x00000001896EC7F8
		protected override void HashCore(byte[] array, int ibStart, int cbSize) {} // 0x00000001896EC70C-0x00000001896EC73C
		protected override byte[] HashFinal() => default; // 0x00000001896EC73C-0x00000001896EC7D4
		protected override void Dispose(bool disposing) {} // 0x00000001896EC6AC-0x00000001896EC70C
	}
}

namespace System.Security.Cryptography.X509Certificates
{
	public static class RSACertificateExtensions // TypeDefIndex: 50638
	{
		// Extension methods
		public static RSA GetRSAPublicKey(this X509Certificate2 certificate) => default; // 0x00000001896EC600-0x00000001896EC6AC
	}
}

namespace System.Threading
{
	public enum LockRecursionPolicy // TypeDefIndex: 51278
	{
		NoRecursion = 0,
		SupportsRecursion = 1
	}

	internal class ReaderWriterCount // TypeDefIndex: 51279
	{
		// Fields
		public long lockID; // 0x10
		public int readercount; // 0x18
		public int writercount; // 0x1C
		public int upgradecount; // 0x20
		public ReaderWriterCount next; // 0x28
	
		// Constructors
		public ReaderWriterCount() {} // 0x000000018350B670-0x000000018350B680
	}

	public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 51281
	{
		// Fields
		private bool fIsReentrant; // 0x10
		private int myLock; // 0x14
		private uint numWriteWaiters; // 0x18
		private uint numReadWaiters; // 0x1C
		private uint numWriteUpgradeWaiters; // 0x20
		private uint numUpgradeWaiters; // 0x24
		private bool fNoWaiters; // 0x28
		private int upgradeLockOwnerId; // 0x2C
		private int writeLockOwnerId; // 0x30
		private EventWaitHandle writeEvent; // 0x38
		private EventWaitHandle readEvent; // 0x40
		private EventWaitHandle upgradeEvent; // 0x48
		private EventWaitHandle waitUpgradeEvent; // 0x50
		private static long s_nextLockID; // 0x00
		private long lockID; // 0x58
		[ThreadStatic]
		private static ReaderWriterCount t_rwc; // 0x80000000
		private bool fUpgradeThreadHoldingRead; // 0x60
		private uint owners; // 0x64
		private bool fDisposed; // 0x68
	
		// Properties
		public bool IsReadLockHeld { get => default; } // 0x000000018973B900-0x000000018973B918 
		public bool IsUpgradeableReadLockHeld { get => default; } // 0x000000018973B918-0x000000018973B930 
		public bool IsWriteLockHeld { get => default; } // 0x000000018973B930-0x000000018973B948 
		public int RecursiveReadCount { get => default; } // 0x000000018973B948-0x000000018973B960 
		public int RecursiveUpgradeCount { get => default; } // 0x000000018973B960-0x000000018973B9B4 
		public int RecursiveWriteCount { get => default; } // 0x000000018973B9B4-0x000000018973BA08 
		public int WaitingReadCount { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public int WaitingUpgradeCount { get => default; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		public int WaitingWriteCount { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
	
		// Nested types
		private struct TimeoutTracker // TypeDefIndex: 51280
		{
			// Fields
			private int m_total; // 0x00
			private int m_start; // 0x04
	
			// Properties
			public int RemainingMilliseconds { get => default; } // 0x000000018973BEC8-0x000000018973BF00 
			public bool IsExpired { get => default; } // 0x000000018973BEB0-0x000000018973BEC8 
	
			// Constructors
			public TimeoutTracker(int millisecondsTimeout) : this() {
				m_total = default;
				m_start = default;
			} // 0x00000001830B4B50-0x00000001830B4B80
		}
	
		// Constructors
		public ReaderWriterLockSlim() {} // 0x000000018427694C-0x0000000184276958
		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy) {} // 0x0000000183D02620-0x0000000183D02690
	
		// Methods
		private void InitializeThreadCounts() {} // 0x0000000183D75390-0x0000000183D753A0
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc) => default; // 0x0000000189737FEC-0x000000018973801C
		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) => default; // 0x000000018973B644-0x000000018973B664
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate) => default; // 0x000000018973B518-0x000000018973B644
		public void EnterWriteLock() {} // 0x0000000184276F58-0x0000000184276F68
		public bool TryEnterWriteLock(int millisecondsTimeout) => default; // 0x00000001830B4AD0-0x00000001830B4B10
		private bool TryEnterWriteLock(TimeoutTracker timeout) => default; // 0x0000000184274ED0-0x0000000184274ED8
		private bool TryEnterWriteLockCore(TimeoutTracker timeout) => default; // 0x0000000183C7A3D0-0x0000000183C7A4E0
		public void EnterUpgradeableReadLock() {} // 0x0000000184271004-0x0000000184271014
		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) => default; // 0x00000001830B4B10-0x00000001830B4B50
		private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout) => default; // 0x0000000184274ED8-0x0000000184274EE0
		private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout) => default; // 0x00000001826C2400-0x00000001826C3050
		public void ExitWriteLock() {} // 0x0000000183CFDEB0-0x0000000183CFDF20
		public void ExitUpgradeableReadLock() {} // 0x00000001826C3050-0x00000001826C3550
		private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) {} // 0x000000018973B664-0x000000018973B738
		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter) => default; // 0x000000018973B794-0x000000018973B900
		private void ExitAndWakeUpAppropriateWaiters() {} // 0x00000001826C3550-0x00000001826C3570
		private void ExitAndWakeUpAppropriateWaitersPreferringWriters() {} // 0x000000018973B4AC-0x000000018973B518
		private void ExitAndWakeUpAppropriateReadWaiters() {} // 0x000000018973B42C-0x000000018973B4AC
		private bool IsWriterAcquired() => default; // 0x0000000183C7A4E0-0x0000000183C7A4F0
		private void SetWriterAcquired() {} // 0x0000000183D753B0-0x0000000183D753C0
		private void ClearWriterAcquired() {} // 0x0000000183D75350-0x0000000183D75360
		private void SetWritersWaiting() {} // 0x0000000183D753C0-0x0000000183D753D0
		private void ClearWritersWaiting() {} // 0x0000000183D75360-0x0000000183D75370
		private void SetUpgraderWaiting() {} // 0x0000000183D753A0-0x0000000183D753B0
		private void ClearUpgraderWaiting() {} // 0x0000000183D75340-0x0000000183D75350
		private uint GetNumReaders() => default; // 0x0000000183D75380-0x0000000183D75390
		private void EnterMyLock() {} // 0x00000001826C23E0-0x00000001826C2400
		private void EnterMyLockSpin() {} // 0x000000018973B398-0x000000018973B42C
		private void ExitMyLock() {} // 0x0000000183D75370-0x0000000183D75380
		private static void SpinWait(int SpinCount) {} // 0x000000018973B738-0x000000018973B794
		public void Dispose() {} // 0x000000018973B38C-0x000000018973B398
		private void Dispose(bool disposing) {} // 0x000000018973B1E4-0x000000018973B38C
	}
}
