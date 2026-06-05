/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Image 40: Unity.VisualScripting.Core.dll - Assembly: Unity.VisualScripting.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56436-56695

namespace Unity.VisualScripting
{
	public abstract class Cloner<T> : ICloner // TypeDefIndex: 56437
	{
		// Constructors
		protected Cloner() {}
	
		// Methods
		public abstract bool Handles(System.Type type);
		void ICloner.BeforeClone(System.Type type, object original) {}
		public virtual void BeforeClone(System.Type type, T original) {}
		object ICloner.ConstructClone(System.Type type, object original) => default;
		public virtual T ConstructClone(System.Type type, T original) => default;
		void ICloner.FillClone(System.Type type, ref object clone, object original, CloningContext context) {}
		public virtual void FillClone(System.Type type, ref ref T clone, T original, CloningContext context) {}
		void ICloner.AfterClone(System.Type type, object clone) {}
		public virtual void AfterClone(System.Type type, T clone) {}
	}

	public sealed class AnimationCurveCloner : Cloner<AnimationCurve> // TypeDefIndex: 56438
	{
		// Constructors
		public AnimationCurveCloner() {} // 0x000000018577F6A0-0x000000018577F6D0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE5E3C0-0x000000018BE5E424
		public override AnimationCurve ConstructClone(System.Type type, AnimationCurve original) => default; // 0x000000018BE5E2B0-0x000000018BE5E300
		public override void FillClone(System.Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context) {} // 0x000000018BE5E300-0x000000018BE5E3C0
	}

	public sealed class ArrayCloner : Cloner<Array> // TypeDefIndex: 56439
	{
		// Constructors
		public ArrayCloner() {} // 0x000000018577F670-0x000000018577F6A0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018B4E5844-0x000000018B4E5864
		public override Array ConstructClone(System.Type type, Array original) => default; // 0x000000018BE5E5D8-0x000000018BE5E604
		public override void FillClone(System.Type type, ref Array clone, Array original, CloningContext context) {} // 0x000000018BE5E604-0x000000018BE5E6F4
	}

	public sealed class DictionaryCloner : Cloner<IDictionary> // TypeDefIndex: 56440
	{
		// Constructors
		public DictionaryCloner() {} // 0x000000018577F640-0x000000018577F670
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE62FB4-0x000000018BE6302C
		public override void FillClone(System.Type type, ref IDictionary clone, IDictionary original, CloningContext context) {} // 0x000000018BE62EC8-0x000000018BE62FB4
	}

	public sealed class EnumerableCloner : Cloner<IEnumerable> // TypeDefIndex: 56441
	{
		// Fields
		private readonly Dictionary<System.Type, IOptimizedInvoker> addMethods; // 0x10
	
		// Constructors
		public EnumerableCloner() {} // 0x000000018577F740-0x000000018577F7D0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE63830-0x000000018BE63914
		public override void FillClone(System.Type type, ref IEnumerable clone, IEnumerable original, CloningContext context) {} // 0x000000018BE6341C-0x000000018BE63634
		private IOptimizedInvoker GetAddMethod(System.Type type) => default; // 0x000000018BE63634-0x000000018BE63830
	}

	public sealed class FakeSerializationCloner : ReflectedCloner // TypeDefIndex: 56443
	{
		// Fields
		private fsConfig _config_k__BackingField; // 0x20
	
		// Properties
		public fsConfig config { get; } // 0x000000018BE645A0-0x000000018BE646E0 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56442
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsMetaProperty, MemberInfo> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x00000001813B31A0-0x00000001813B31B0
			public __c() {} // 0x000000018BE64558-0x000000018BE645A0
	
			// Methods
			internal MemberInfo _GetMembers_b__6_0(fsMetaProperty p) => default; // 0x000000018BE64510-0x000000018BE64558
		}
	
		// Constructors
		public FakeSerializationCloner() {} // 0x0000000187AD0B8C-0x0000000187AD0BA4
	
		// Methods
		public override void BeforeClone(System.Type type, object original) {} // 0x000000018577F6D0-0x000000018577F740
		public override void AfterClone(System.Type type, object clone) {} // 0x000000018BE77E70-0x000000018BE77ED4
		protected override IEnumerable<MemberInfo> GetMembers(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
	}

	public sealed class FieldsCloner : ReflectedCloner // TypeDefIndex: 56444
	{
		// Constructors
		public FieldsCloner() {} // 0x00000001864744C4-0x00000001864744CC
	
		// Methods
		protected override bool IncludeField(System.Reflection.FieldInfo field) => default; // 0x00000001840A27C0-0x00000001840A27D0
		protected override bool IncludeProperty(PropertyInfo property) => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	internal sealed class GradientCloner : Cloner<Gradient> // TypeDefIndex: 56445
	{
		// Constructors
		public GradientCloner() {} // 0x000000018577F610-0x000000018577F640
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE647B0-0x000000018BE64814
		public override Gradient ConstructClone(System.Type type, Gradient original) => default; // 0x000000018BE646E0-0x000000018BE64730
		public override void FillClone(System.Type type, ref Gradient clone, Gradient original, CloningContext context) {} // 0x000000018BE64730-0x000000018BE647B0
	}

	public sealed class ListCloner : Cloner<IList> // TypeDefIndex: 56446
	{
		// Constructors
		public ListCloner() {} // 0x000000018577F5E0-0x000000018577F610
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE681A8-0x000000018BE68220
		public override void FillClone(System.Type type, ref IList clone, IList original, CloningContext context) {} // 0x000000018BE68004-0x000000018BE681A8
	}

	public abstract class ReflectedCloner : Cloner<object> // TypeDefIndex: 56447
	{
		// Fields
		private readonly Dictionary<System.Type, MemberInfo[]> accessors; // 0x10
		private readonly Dictionary<System.Type, IOptimizedAccessor[]> optimizedAccessors; // 0x18
	
		// Constructors
		protected ReflectedCloner() {} // 0x000000018577F7D0-0x000000018577F8A0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override void FillClone(System.Type type, ref object clone, object original, CloningContext context) {} // 0x000000018BE6DAB0-0x000000018BE6DE30
		private MemberInfo[] GetAccessors(System.Type type) => default; // 0x000000018BE6DE30-0x000000018BE6DF0C
		private IOptimizedAccessor[] GetOptimizedAccessors(System.Type type) => default; // 0x000000018BE6E0C0-0x000000018BE6E3F0
		protected virtual IEnumerable<MemberInfo> GetMembers(System.Type type) => default; // 0x000000018BE6DF0C-0x000000018BE6E0C0
		protected virtual bool IncludeField(System.Reflection.FieldInfo field) => default; // 0x00000001814A81B0-0x00000001814A81C0
		protected virtual bool IncludeProperty(PropertyInfo property) => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public static class Cloning // TypeDefIndex: 56449
	{
		// Fields
		private static readonly Dictionary<System.Type, bool> skippable; // 0x00
		private static readonly HashSet<ICloner> _cloners_k__BackingField; // 0x08
		private static readonly ArrayCloner _arrayCloner_k__BackingField; // 0x10
		private static readonly DictionaryCloner _dictionaryCloner_k__BackingField; // 0x18
		private static readonly EnumerableCloner _enumerableCloner_k__BackingField; // 0x20
		private static readonly ListCloner _listCloner_k__BackingField; // 0x28
		private static readonly AnimationCurveCloner _animationCurveCloner_k__BackingField; // 0x30
		private static readonly GradientCloner _gradientCloner_k__BackingField; // 0x38
		private static readonly FieldsCloner _fieldsCloner_k__BackingField; // 0x40
		private static readonly FakeSerializationCloner _fakeSerializationCloner_k__BackingField; // 0x48
	
		// Properties
		public static HashSet<ICloner> cloners { get; } // 0x000000018BE5F278-0x000000018BE5F2C8 
		public static ArrayCloner arrayCloner { get; } // 0x000000018BE5F2C8-0x000000018BE5F318 
		public static DictionaryCloner dictionaryCloner { get; } // 0x000000018BE5F3B8-0x000000018BE5F408 
		public static EnumerableCloner enumerableCloner { get; } // 0x000000018BE5F188-0x000000018BE5F1D8 
		public static ListCloner listCloner { get; } // 0x000000018BE5F368-0x000000018BE5F3B8 
		public static AnimationCurveCloner animationCurveCloner { get; } // 0x000000018BE5F318-0x000000018BE5F368 
		internal static GradientCloner gradientCloner { get; } // 0x0000000184B89050-0x0000000184B89140 
		public static FakeSerializationCloner fakeSerializationCloner { get; } // 0x0000000184B88FB0-0x0000000184B89050 
	
		// Nested types
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 56448
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0() {} // 0x000000018577EF60-0x000000018577F5E0
	
			// Methods
			internal bool _GetCloner_b__0(ICloner cloner) => default; // 0x000000018BE5F228-0x000000018BE5F278
		}
	
		// Constructors
		static Cloning() {} // 0x000000018BE5F1D8-0x000000018BE5F228
	
		// Methods
		public static object Clone(object original, ICloner fallbackCloner, bool tryPreserveInstances) => default;
		public static object CloneViaFakeSerialization(object original) => default; // 0x0000000184B89140-0x0000000184B891B0
		public static T CloneViaFakeSerialization<T>(T original) => default; // 0x0000000184B89490-0x0000000184B89740
		internal static object Clone(CloningContext context, object original) => default; // 0x0000000184B897E0-0x0000000184B89920
		internal static void CloneInto(CloningContext context, ref object clone, object original) {} // 0x0000000184B89740-0x0000000184B897E0
		public static ICloner GetCloner(object original, System.Type type) => default; // 0x0000000184B8ABA0-0x0000000184B8ADB0
		private static ICloner GetCloner(object original, System.Type type, ICloner fallbackCloner) => default; // 0x0000000185492010-0x0000000185492020
		private static bool Skippable(System.Type type) => default; // 0x000000018BE77B90-0x000000018BE77BB4
	}

	public sealed class CloningContext : IPoolable, IDisposable // TypeDefIndex: 56451
	{
		// Fields
		private readonly Dictionary<object, object> _clonings_k__BackingField; // 0x10
		private ICloner _fallbackCloner_k__BackingField; // 0x18
		private bool _tryPreserveInstances_k__BackingField; // 0x20
		private bool disposed; // 0x21
	
		// Properties
		public Dictionary<object, object> clonings { get; } // 0x00000001813ECBF0-0x00000001813ECC00 
		public ICloner fallbackCloner { get; private set; } // 0x00000001813EE9B0-0x00000001813EE9C0 0x0000000185FE64B0-0x0000000185FE64C0
		public bool tryPreserveInstances { get; private set; } // 0x0000000184C1F8C0-0x0000000184C1F910 0x0000000185F1D0F0-0x0000000185F1D160
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56450
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CloningContext> __9__15_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018346D130-0x000000018346D140
			public __c() {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			internal CloningContext _New_b__15_0() => default; // 0x0000000184088E70-0x0000000184088E80
		}
	
		// Constructors
		public CloningContext() {} // 0x0000000184B88E20-0x0000000184B88E70
	
		// Methods
		void IPoolable.New() {} // 0x0000000184B891B0-0x0000000184B89330
		void IPoolable.Free() {} // 0x0000000184B88E70-0x0000000184B88F30
		public void Dispose() {} // 0x0000000185F71B30-0x0000000185F71B90
		public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances) => default; // 0x0000000185492010-0x0000000185492020
	}

	public interface ICloner // TypeDefIndex: 56452
	{
		// Methods
		bool Handles(System.Type type);
		object ConstructClone(System.Type type, object original);
		void BeforeClone(System.Type type, object original);
		void FillClone(System.Type type, ref object clone, object original, CloningContext context);
		void AfterClone(System.Type type, object clone);
	}

	public interface ISpecifiesCloner // TypeDefIndex: 56453
	{
		// Properties
		ICloner cloner { get; }
	}

	public sealed class AotDictionary : OrderedDictionary // TypeDefIndex: 56454
	{
		// Constructors
		public AotDictionary() {} // 0x000000018BB429C8-0x000000018BB429DC
	
		// Methods
		public static void AotStubs() {} // 0x000000018BE5E424-0x000000018BE5E4CC
	}

	public sealed class AotList : ArrayList // TypeDefIndex: 56455
	{
		// Constructors
		public AotList() {} // 0x000000018BAE18AC-0x000000018BAE18B4
	
		// Methods
		public static void AotStubs() {} // 0x000000018BE5E4CC-0x000000018BE5E584
	}

	public class GuidCollection<T> : KeyedCollection<Guid, T>, ICollection<T> // TypeDefIndex: 56456
		where T : IIdentifiable
	{
		// Constructors
		public GuidCollection() {} // Dummy constructor
	
		// Methods
		protected override Guid GetKeyForItem(T item) => default;
	}

	public interface IKeyedCollection<TKey, TItem> : ICollection<TItem> // TypeDefIndex: 56457
	{
		// Properties
		TItem this[TKey key] { get => default; }
		TItem this[int index] { get => default; }
	
		// Methods
		bool Contains(TKey key);
	}

	public class MergedKeyedCollection<TKey, TItem> : IEnumerable<TItem> // TypeDefIndex: 56459
	{
		// Fields
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collections;
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsLookup;
	
		// Nested types
		public struct Enumerator : IEnumerator<TItem> // TypeDefIndex: 56458
		{
			// Fields
			private Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsEnumerator;
			private TItem currentItem;
			private IKeyedCollection<TKey, TItem> currentCollection;
			private int indexInCurrentCollection;
			private bool exceeded;
	
			// Properties
			public TItem Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public Enumerator(MergedKeyedCollection<TKey, TItem> merged) : this() {
				collectionsEnumerator = default;
				currentItem = default;
				currentCollection = default;
				indexInCurrentCollection = default;
				exceeded = default;
			}
	
			// Methods
			public void Dispose() {}
			public bool MoveNext() => default;
			void IEnumerator.Reset() {}
		}
	
		// Constructors
		public MergedKeyedCollection() {} // Dummy constructor
	
		// Methods
		protected IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item) => default;
		protected IKeyedCollection<TKey, TItem> GetCollectionForType(System.Type type, bool throwOnFail = true /* Metadata: 0x0207CDC7 */) => default;
		public virtual void Add(TItem item) {}
		public void Clear() {}
		public bool Contains(TItem item) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator() => default;
		public Enumerator GetEnumerator() => default;
	}

	public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> // TypeDefIndex: 56460
		where TConnection : IConnection<TSource, TDestination>
	{
		// Constructors
		public ConnectionCollection() {}
	}

	public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination> // TypeDefIndex: 56461
		where TConnection : IConnection<TSource, TDestination>
		where TCollection : ICollection<TConnection>
	{
		// Fields
		private readonly Dictionary<TDestination, List<TConnection>> byDestination;
		private readonly Dictionary<TSource, List<TConnection>> bySource;
		protected readonly TCollection collection;
	
		// Properties
		public int Count { get => default; }
		public bool IsReadOnly { get => default; }
	
		// Constructors
		public ConnectionCollectionBase() {} // Dummy constructor
		public ConnectionCollectionBase(TCollection collection) {}
	
		// Methods
		public IEnumerator<TConnection> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public IEnumerable<TConnection> WithSource(TSource source) => default;
		public List<TConnection> WithSourceNoAlloc(TSource source) => default;
		public TConnection SingleOrDefaultWithSource(TSource source) => default;
		public IEnumerable<TConnection> WithDestination(TDestination destination) => default;
		public List<TConnection> WithDestinationNoAlloc(TDestination destination) => default;
		public TConnection SingleOrDefaultWithDestination(TDestination destination) => default;
		public void Add(TConnection item) {}
		public void Clear() {}
		public bool Contains(TConnection item) => default;
		public void CopyTo(TConnection[] array, int arrayIndex) {}
		public bool Remove(TConnection item) => default;
		protected virtual void BeforeAdd(TConnection item) {}
		protected virtual void AfterAdd(TConnection item) {}
		protected virtual void BeforeRemove(TConnection item) {}
		protected virtual void AfterRemove(TConnection item) {}
		private void AddToDictionaries(TConnection item) {}
		private void RemoveFromDictionaries(TConnection item) {}
	}

	public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, ICollection<TConnection> // TypeDefIndex: 56462
		where TConnection : IConnection<TSource, TDestination>, IGraphElement
	{
		// Constructors
		public GraphConnectionCollection() {} // Dummy constructor
	}

	public interface IConnection<out TSource, out TDestination> // TypeDefIndex: 56463
	{
		// Properties
		TSource source { get; }
		TDestination destination { get; }
	}

	public interface IConnectionCollection<TConnection, TSource, TDestination> : ICollection<TConnection> // TypeDefIndex: 56464
		where TConnection : IConnection<TSource, TDestination>
	{
	}

	public class InvalidConnectionException : Exception // TypeDefIndex: 56465
	{
		// Constructors
		public InvalidConnectionException() {} // 0x000000018BE67B1C-0x000000018BE67B70
		public InvalidConnectionException(string message) {} // 0x000000018BE67B70-0x000000018BE67BCC
	}

	public class ValueAttribute : Attribute // TypeDefIndex: 56466
	{
		// Constructors
		public ValueAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class DisableAnnotationAttribute : Attribute // TypeDefIndex: 56467
	{
		// Fields
		private bool _disableIcon_k__BackingField; // 0x10
	
		// Constructors
		public DisableAnnotationAttribute() {} // 0x0000000181B9A230-0x0000000181B9A240
	}

	public static class EditorTimeBinding // TypeDefIndex: 56469
	{
		// Fields
		public static Func<int> frameBinding; // 0x00
		public static Func<float> timeBinding; // 0x08
	
		// Properties
		public static int frame { get; } // 0x0000000185492010-0x0000000185492020 
		public static float time { get; } // 0x000000018BE77804-0x000000018BE7780C 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56468
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BE63170-0x000000018BE63210
			public __c() {} // 0x000000018BE63210-0x000000018BE632B0
	
			// Methods
			internal int _.cctor_b__6_0() => default; // 0x000000018BE6302C-0x000000018BE63170
			internal float _.cctor_b__6_1() => default; // 0x000000018BE77ED4-0x000000018BE77F38
		}
	
		// Constructors
		static EditorTimeBinding() {} // 0x000000018BE7780C-0x000000018BE77814
	}

	public sealed class IncludeInSettingsAttribute : Attribute // TypeDefIndex: 56470
	{
		// Fields
		private bool _include_k__BackingField; // 0x10
	
		// Properties
		private bool include { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public IncludeInSettingsAttribute() {} // Dummy constructor
		public IncludeInSettingsAttribute(bool include) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	public sealed class InspectableAttribute : Attribute // TypeDefIndex: 56471
	{
		// Constructors
		public InspectableAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public sealed class InspectorWideAttribute : Attribute // TypeDefIndex: 56472
	{
		// Fields
		private bool _toEdge_k__BackingField; // 0x10
	
		// Properties
		private bool toEdge { get; set; } // 0x000000018184FBD0-0x000000018184FBE0
	
		// Constructors
		public InspectorWideAttribute() {} // Dummy constructor
		public InspectorWideAttribute(bool toEdge) {} // 0x000000018184FBD0-0x000000018184FBE0
	}

	public static class Ensure // TypeDefIndex: 56473
	{
		// Fields
		private static readonly EnsureThat instance; // 0x00
		private static bool _IsActive_k__BackingField; // 0x08
	
		// Properties
		public static bool IsActive { get; set; } // 0x000000018BE63378-0x000000018BE633C8 0x000000018BE633C8-0x000000018BE6341C
	
		// Constructors
		static Ensure() {} // 0x0000000185F5EC70-0x0000000185F5ECE0
	
		// Methods
		public static EnsureThat That(string paramName) => default; // 0x0000000185700720-0x00000001857007A0
		internal static void OnRuntimeMethodLoad() {} // 0x000000018508FB10-0x000000018508FBE0
	}

	public class EnsureThat // TypeDefIndex: 56474
	{
		// Fields
		internal string paramName; // 0x10
	
		// Constructors
		public EnsureThat() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void IsNotNull<T>(T value) {}
		public void IsNotNull(string value) {} // 0x000000018BE632B0-0x000000018BE63378
		public void IsOfType<T>(T param, System.Type expectedType) {}
	}

	public static class ExceptionMessages // TypeDefIndex: 56475
	{
		// Fields
		private static readonly string _Common_IsNull_Failed_k__BackingField; // 0x00
		private static readonly string _Common_IsNotNull_Failed_k__BackingField; // 0x08
		private static readonly string _Booleans_IsTrueFailed_k__BackingField; // 0x10
		private static readonly string _Booleans_IsFalseFailed_k__BackingField; // 0x18
		private static readonly string _Collections_Any_Failed_k__BackingField; // 0x20
		private static readonly string _Collections_ContainsKey_Failed_k__BackingField; // 0x28
		private static readonly string _Collections_HasItemsFailed_k__BackingField; // 0x30
		private static readonly string _Collections_HasNoNullItemFailed_k__BackingField; // 0x38
		private static readonly string _Collections_SizeIs_Failed_k__BackingField; // 0x40
		private static readonly string _Comp_Is_Failed_k__BackingField; // 0x48
		private static readonly string _Comp_IsNot_Failed_k__BackingField; // 0x50
		private static readonly string _Comp_IsNotLt_k__BackingField; // 0x58
		private static readonly string _Comp_IsNotLte_k__BackingField; // 0x60
		private static readonly string _Comp_IsNotGt_k__BackingField; // 0x68
		private static readonly string _Comp_IsNotGte_k__BackingField; // 0x70
		private static readonly string _Comp_IsNotInRange_ToLow_k__BackingField; // 0x78
		private static readonly string _Comp_IsNotInRange_ToHigh_k__BackingField; // 0x80
		private static readonly string _Guids_IsNotEmpty_Failed_k__BackingField; // 0x88
		private static readonly string _Strings_IsEqualTo_Failed_k__BackingField; // 0x90
		private static readonly string _Strings_IsNotEqualTo_Failed_k__BackingField; // 0x98
		private static readonly string _Strings_SizeIs_Failed_k__BackingField; // 0xA0
		private static readonly string _Strings_IsNotNullOrWhiteSpace_Failed_k__BackingField; // 0xA8
		private static readonly string _Strings_IsNotNullOrEmpty_Failed_k__BackingField; // 0xB0
		private static readonly string _Strings_HasLengthBetween_Failed_ToShort_k__BackingField; // 0xB8
		private static readonly string _Strings_HasLengthBetween_Failed_ToLong_k__BackingField; // 0xC0
		private static readonly string _Strings_Matches_Failed_k__BackingField; // 0xC8
		private static readonly string _Strings_IsNotEmpty_Failed_k__BackingField; // 0xD0
		private static readonly string _Strings_IsGuid_Failed_k__BackingField; // 0xD8
		private static readonly string _Types_IsOfType_Failed_k__BackingField; // 0xE0
		private static readonly string _Reflection_HasAttribute_Failed_k__BackingField; // 0xE8
		private static readonly string _Reflection_HasConstructor_Failed_k__BackingField; // 0xF0
		private static readonly string _Reflection_HasPublicConstructor_Failed_k__BackingField; // 0xF8
		private static readonly string _ValueTypes_IsNotDefault_Failed_k__BackingField; // 0x100
	
		// Properties
		public static string Common_IsNotNull_Failed { get; } // 0x000000018BE64140-0x000000018BE64190 
		public static string Types_IsOfType_Failed { get; } // 0x000000018BE64190-0x000000018BE641E4 
	
		// Constructors
		static ExceptionMessages() {} // 0x000000018BE63914-0x000000018BE64140
	}

	internal static class XString // TypeDefIndex: 56477
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56476
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, object> __9__1_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE787DC-0x000000018BE78918
			public __c() {} // 0x000000018BE77C18-0x000000018BE77C7C
	
			// Methods
			internal object _Inject_b__1_0(string a) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Methods
		internal static string Inject(string format, string[] formattingArgs) => default; // 0x00000001834A4750-0x00000001834A4760
	}

	public struct EmptyEventArgs // TypeDefIndex: 56478
	{
	}

	public class InvalidConversionException : InvalidCastException // TypeDefIndex: 56479
	{
		// Constructors
		public InvalidConversionException() {} // 0x000000018BE67BCC-0x000000018BE67BD4
		public InvalidConversionException(string message) {} // 0x000000018B377BF0-0x000000018B377C10
		public InvalidConversionException(string message, Exception innerException) {} // 0x000000018BE67BD4-0x000000018BE67BDC
	}

	public class InvalidImplementationException : Exception // TypeDefIndex: 56480
	{
		// Constructors
		public InvalidImplementationException() {} // Dummy constructor
		public InvalidImplementationException(string message) {} // 0x000000018BE67BDC-0x000000018BE67C38
	}

	public class UnexpectedEnumValueException<T> : Exception // TypeDefIndex: 56481
	{
		// Fields
		private T _Value_k__BackingField;
	
		// Properties
		private T Value { get; set; }
	
		// Constructors
		public UnexpectedEnumValueException() {} // Dummy constructor
		public UnexpectedEnumValueException(T value) {}
	}

	public abstract class Graph : IGraph // TypeDefIndex: 56483
	{
		// Fields
		private List<IGraphElement> _elements; // 0x10
		private readonly MergedGraphElementCollection _elements_k__BackingField; // 0x18
	
		// Properties
		public MergedGraphElementCollection elements { get; } // 0x000000018BE67018-0x000000018BE67500 
		public IEnumerable<ISerializationDependency> deserializationDependencies { get; } // 0x000000018BE66ECC-0x000000018BE67018 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56482
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IGraphElement, IEnumerable<ISerializationDependency>> __9__27_0; // 0x08
			public static Comparison<IGraphElement> __9__30_0; // 0x10
	
			// Constructors
			static __c() {} // 0x0000000181377E40-0x0000000181377E50
			public __c() {} // 0x000000018BE675B8-0x000000018BE676C0
	
			// Methods
			internal IEnumerable<ISerializationDependency> _get_deserializationDependencies_b__27_0(IGraphElement e) => default; // 0x000000018BE6754C-0x000000018BE675B8
			internal int _OnAfterDependenciesDeserialized_b__30_0(IGraphElement a, IGraphElement b) => default; // 0x000000018BE67500-0x000000018BE6754C
		}
	
		// Constructors
		protected Graph() {} // Dummy constructor
	
		// Methods
		public virtual void OnBeforeSerialize() {} // 0x000000018BE77D44-0x000000018BE77DA8
		public void OnAfterDeserialize() {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterDependenciesDeserialized() {} // 0x000000018BE7791C-0x000000018BE77938
		public virtual void Dispose() {} // 0x000000018BE77630-0x000000018BE77674
	}

	public abstract class GraphElement<TGraph> : IGraphElement // TypeDefIndex: 56484
		where TGraph : class, IGraph
	{
		// Fields
		private Guid _guid_k__BackingField;
		private TGraph _graph_k__BackingField;
	
		// Properties
		public Guid guid { get; }
		public virtual int dependencyOrder { get; }
		public TGraph graph { get; }
		public virtual IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Constructors
		protected GraphElement() {}
	
		// Methods
		public virtual void Dispose() {}
		public virtual bool HandleDependencies() => default;
		public override string ToString() => default;
	}

	public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IKeyedCollection<Guid, TElement> // TypeDefIndex: 56485
		where TElement : IGraphElement
	{
		// Properties
		TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.this[Guid key] { get => default; }
	
		// Constructors
		public GraphElementCollection() {} // Dummy constructor
	
		// Methods
		bool IKeyedCollection<Guid, TElement>.Contains(Guid key) => default;
	}

	public abstract class GraphPointer // TypeDefIndex: 56486
	{
		// Fields
		private IGraphRoot _root_k__BackingField; // 0x10
		private GameObject _gameObject_k__BackingField; // 0x18
		protected readonly List<IGraphParent> parentStack; // 0x20
		protected readonly List<IGraphParentElement> parentElementStack; // 0x28
		protected readonly List<IGraph> graphStack; // 0x30
		protected readonly List<IGraphData> dataStack; // 0x38
		protected readonly List<IGraphDebugData> debugDataStack; // 0x40
	
		// Properties
		public IGraphRoot root { get; protected set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public UnityEngine.Object rootObject { get; } // 0x000000018BE65DEC-0x000000018BE65E28 
		public GameObject gameObject { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public GameObject self { get; } // 0x0000000181377E40-0x0000000181377E50 
		public UnityEngine.Object serializedObject { get; } // 0x000000018BE65E28-0x000000018BE65F2C 
		public int depth { get; } // 0x000000018BE65954-0x000000018BE65994 
		public bool isRoot { get; } // 0x000000018BE659C4-0x000000018BE659DC 
		public bool isChild { get; } // 0x000000018BE659AC-0x000000018BE659C4 
		public IGraphParent parent { get; } // 0x000000018BE65D48-0x000000018BE65DA4 
		public IGraphParentElement parentElement { get; } // 0x000000018BE65CE4-0x000000018BE65D48 
		public IGraph rootGraph { get; } // 0x000000018BE65DA4-0x000000018BE65DEC 
		public bool hasDebugData { get; } // 0x000000018BE65994-0x000000018BE659AC 
		protected IGraphDebugData _debugData { get; } // 0x000000018BE658D8-0x000000018BE65934 
		public IGraphDebugData debugData { get; } // 0x000000018BE65934-0x000000018BE65954 
		public bool isValid { get; } // 0x000000018BE659DC-0x000000018BE65CE4 
	
		// Constructors
		internal GraphPointer() {} // 0x000000018BE65734-0x000000018BE658D8
	
		// Methods
		public abstract GraphReference AsReference();
		public virtual void CopyFrom(GraphPointer other) {} // 0x000000018BE649FC-0x000000018BE65134
		public void EnsureChild() {} // 0x000000018BE6521C-0x000000018BE65298
		public void EnsureDebugDataAvailable() {} // 0x000000018BE65298-0x000000018BE65314
		public T GetElementDebugData<T>(IGraphElementWithDebugData element) => default;
		protected void ExitParentElement() {} // 0x000000018BE65314-0x000000018BE654BC
		public bool InstanceEquals(GraphPointer other) => default; // 0x000000018BE654BC-0x000000018BE655BC
		public bool DefinitionEquals(GraphPointer other) => default; // 0x000000018BE65134-0x000000018BE6521C
		public int ComputeHashCode() => default; // 0x000000018BE648D8-0x000000018BE649FC
		public override string ToString() => default; // 0x000000018BE655BC-0x000000018BE65734
	}

	public sealed class GraphPointerException : Exception // TypeDefIndex: 56487
	{
		// Fields
		private readonly GraphPointer _pointer_k__BackingField; // 0x90
	
		// Constructors
		public GraphPointerException() {} // Dummy constructor
		public GraphPointerException(string message, GraphPointer pointer) {} // 0x000000018BE64814-0x000000018BE648D8
	}

	public sealed class GraphReference : GraphPointer // TypeDefIndex: 56488
	{
		// Fields
		private int hashCode; // 0x48
		private static readonly Dictionary<int, List<GraphReference>> internPool; // 0x00
	
		// Constructors
		static GraphReference() {} // 0x000000018BE66B3C-0x000000018BE66C14
		private GraphReference() {} // 0x000000018BE66C14-0x000000018BE66C1C
	
		// Methods
		private static GraphReference New(GraphPointer model) => default; // 0x000000018BE66A1C-0x000000018BE66A84
		public override void CopyFrom(GraphPointer other) {} // 0x000000018BE65F78-0x000000018BE65FE0
		public GraphReference Clone() => default; // 0x000000018BE65F2C-0x000000018BE65F78
		public override GraphReference AsReference() => default; // 0x0000000185779060-0x0000000185779070
		public GraphStack ToStackPooled() => default; // 0x000000018BE66B34-0x000000018BE66B3C
		public override bool Equals(object obj) => default; // 0x000000018BE65FE0-0x000000018BE6603C
		private void Hash() {} // 0x000000018BE6664C-0x000000018BE66668
		public override int GetHashCode() => default; // 0x0000000185FB0570-0x0000000185FB0580
		public GraphReference ParentReference(bool ensureValid) => default; // 0x000000018BE66A84-0x000000018BE66B34
		public static GraphReference Intern(GraphPointer pointer) => default; // 0x000000018BE66668-0x000000018BE66A1C
		public static void FreeInvalidInterns() {} // 0x000000018BE6603C-0x000000018BE6664C
	}

	public static class GraphsExceptionUtility // TypeDefIndex: 56489
	{
		// Methods
		public static void SetException(IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) {} // 0x000000018BE67A50-0x000000018BE67B1C
		public static void HandleException(IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) {} // 0x000000018BE676C0-0x000000018BE6788C
		private static bool HandledIn(Exception ex, GraphReference reference) => default; // 0x000000018BE6788C-0x000000018BE67A50
	}

	public sealed class GraphStack : GraphPointer, IPoolable, IDisposable // TypeDefIndex: 56491
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56490
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GraphStack> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE66C14-0x000000018BE66C1C
			public __c() {} // 0x000000018BE66C78-0x000000018BE66DA8
	
			// Methods
			internal GraphStack _New_b__3_0() => default; // 0x000000018BE66C24-0x000000018BE66C78
		}
	
		// Constructors
		private GraphStack() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		internal static GraphStack New(GraphPointer model) => default; // 0x000000018BE66DF4-0x000000018BE66ECC
		public void Dispose() {} // 0x000000018BE66C1C-0x000000018BE66C24
		void IPoolable.New() {} // 0x000000018BE66DA8-0x000000018BE66DF4
		void IPoolable.Free() {} // 0x000000018BE77CE0-0x000000018BE77D44
		public override GraphReference AsReference() => default; // 0x0000000185492010-0x0000000185492020
		public GraphReference ToReference() => default; // 0x000000018BE775E0-0x000000018BE77630
	}

	public interface IGraph : IDisposable, ISerializationDepender // TypeDefIndex: 56492
	{
		// Properties
		MergedGraphElementCollection elements { get; }
	}

	public interface IGraphData // TypeDefIndex: 56493
	{
	}

	public interface IGraphDebugData // TypeDefIndex: 56494
	{
		// Methods
		IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element);
	}

	public interface IGraphElement : IDisposable, IIdentifiable // TypeDefIndex: 56495
	{
		// Properties
		int dependencyOrder { get; }
		Guid guid { get; }
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		bool HandleDependencies();
	}

	public interface IGraphElementDebugData // TypeDefIndex: 56496
	{
		// Properties
		Exception runtimeException { get; set; }
	}

	public interface IGraphElementWithDebugData : IGraphElement // TypeDefIndex: 56497
	{
	}

	public interface IGraphParent // TypeDefIndex: 56498
	{
		// Properties
		IGraph childGraph { get; }
		bool isSerializationRoot { get; }
		UnityEngine.Object serializedObject { get; }
	}

	public interface IGraphParentElement : IGraphElement, IGraphParent // TypeDefIndex: 56499
	{
	}

	public interface IGraphRoot : IGraphParent // TypeDefIndex: 56500
	{
	}

	public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement> // TypeDefIndex: 56501
	{
		// Constructors
		public MergedGraphElementCollection() {} // Dummy constructor
	}

	public static class PlatformUtility // TypeDefIndex: 56502
	{
		// Fields
		public static readonly bool supportsJit; // 0x00
	
		// Constructors
		static PlatformUtility() {} // 0x0000000185FA42A0-0x0000000185FA42E0
	
		// Methods
		private static bool CheckJitSupport() => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public static class GenericPool<T> // TypeDefIndex: 56503
		where T : class, IPoolable
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<T> free;
		private static readonly HashSet<T> busy;
	
		// Constructors
		static GenericPool() {}
	
		// Methods
		public static T New(Func<T> constructor) => default;
		public static void Free(T item) {}
	}

	public interface IPoolable // TypeDefIndex: 56504
	{
		// Methods
		void New();
		void Free();
	}

	public static class ListPool<T> // TypeDefIndex: 56505
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<List<T>> free;
		private static readonly HashSet<List<T>> busy;
	
		// Constructors
		static ListPool() {}
	
		// Methods
		public static List<T> New() => default;
		public static void Free(List<T> list) {}
	}

	public static class XListPool // TypeDefIndex: 56506
	{
		// Methods
		public static void Free<T>(List<T> list) {}
	}

	public class ProfiledSegment // TypeDefIndex: 56507
	{
		// Fields
		private string _name_k__BackingField; // 0x10
		private Stopwatch _stopwatch_k__BackingField; // 0x18
		private ProfiledSegment _parent_k__BackingField; // 0x20
		private ProfiledSegmentCollection _children_k__BackingField; // 0x28
	
		// Properties
		public string name { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		private Stopwatch stopwatch { get; set; } // 0x0000000184088E70-0x0000000184088E80
		private ProfiledSegment parent { get; set; } // 0x000000018646EE40-0x000000018646EE50
		private ProfiledSegmentCollection children { get; set; } // 0x0000000184A4EDC0-0x0000000184A4EDD0
	
		// Constructors
		public ProfiledSegment() {} // Dummy constructor
		public ProfiledSegment(ProfiledSegment parent, string name) {} // 0x000000018BE6CEF8-0x000000018BE6CFB0
	}

	public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment> // TypeDefIndex: 56508
	{
		// Constructors
		public ProfiledSegmentCollection() {} // 0x000000018BE6CEBC-0x000000018BE6CEF8
	
		// Methods
		protected override string GetKeyForItem(ProfiledSegment item) => default; // 0x0000000187AD0B8C-0x0000000187AD0BA4
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 56509
	{
		// Constructors
		public ProfilingScope(string name) {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class ProfilingUtility // TypeDefIndex: 56510
	{
		// Fields
		private static readonly object @lock; // 0x00
		private static ProfiledSegment _rootSegment_k__BackingField; // 0x08
		private static ProfiledSegment _currentSegment_k__BackingField; // 0x10
	
		// Properties
		private static ProfiledSegment rootSegment { get; set; } // 0x000000018BE6D168-0x000000018BE6D1C8
		public static ProfiledSegment currentSegment { get; set; } // 0x000000018BE6D108-0x000000018BE6D168
	
		// Constructors
		static ProfilingUtility() {} // 0x000000018BE6CFB0-0x000000018BE6D108
	
		// Methods
		public static ProfilingScope SampleBlock(string name) => default; // 0x00000001814A81B0-0x00000001814A81C0
	}

	public enum ActionDirection // TypeDefIndex: 56511
	{
		Any = 0,
		Get = 1,
		Set = 2
	}

	public static class AttributeUtility // TypeDefIndex: 56513
	{
		// Fields
		private static readonly Dictionary<object, AttributeCache> optimizedCaches; // 0x00
	
		// Nested types
		private class AttributeCache // TypeDefIndex: 56512
		{
			// Fields
			private readonly List<Attribute> _inheritedAttributes_k__BackingField; // 0x10
			private readonly List<Attribute> _definedAttributes_k__BackingField; // 0x18
	
			// Properties
			public List<Attribute> inheritedAttributes { get; } // 0x000000018BE5EDD8-0x000000018BE5F0FC 
			public List<Attribute> definedAttributes { get; }
	
			// Constructors
			public AttributeCache() {} // Dummy constructor
			public AttributeCache(MemberInfo element) {}
	
			// Methods
			private void Cache(Attribute[] attributeObjects, List<Attribute> cache) {}
			private bool HasAttribute(System.Type attributeType, List<Attribute> cache) => default; // 0x000000018BE5F0FC-0x000000018BE5F188
			private Attribute GetAttribute(System.Type attributeType, List<Attribute> cache) => default; // 0x000000018346D130-0x000000018346D140
			public bool HasAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x0207CDCD */) => default; // 0x0000000181377E40-0x0000000181377E50
			public Attribute GetAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x0207CDCE */) => default; // 0x000000018BE5E8E0-0x000000018BE5EDD8
			public bool HasAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0207CDCF */)
				where TAttribute : Attribute => default; // 0x000000018BE5E6F4-0x000000018BE5E770
			public TAttribute GetAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0207CDD0 */)
				where TAttribute : Attribute => default; // 0x000000018BE5E84C-0x000000018BE5E8E0
		}
	
		// Constructors
		static AttributeUtility() {}
	
		// Methods
		private static AttributeCache GetAttributeCache(MemberInfo element) => default; // 0x000000018BE5E78C-0x000000018BE5E830
		internal static IEnumerable<T> GetAttributeOfEnumMember<T>(Enum enumVal)
			where T : Attribute => default; // 0x000000018BE5E830-0x000000018BE5E84C
		public static bool HasAttribute<TAttribute>(MemberInfo element, bool inherit = true /* Metadata: 0x0207CDCB */)
			where TAttribute : Attribute => default; // 0x000000018BE5E770-0x000000018BE5E78C
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool inherit = true /* Metadata: 0x0207CDCC */)
			where TAttribute : Attribute => default;
	}

	public static class ConversionUtility // TypeDefIndex: 56520
	{
		// Fields
		private static readonly Dictionary<ConversionQuery, ConversionType> conversionTypesCache; // 0x00
		private static readonly Dictionary<ConversionQuery, MethodInfo[]> userConversionMethodsCache; // 0x08
		private static readonly Dictionary<System.Type, HashSet<System.Type>> implicitNumericConversions; // 0x10
		private static readonly Dictionary<System.Type, HashSet<System.Type>> explicitNumericConversions; // 0x18
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 56514
		{
			Impossible = 0,
			Identity = 1,
			Upcast = 2,
			Downcast = 3,
			NumericImplicit = 4,
			NumericExplicit = 5,
			UserDefinedImplicit = 6,
			UserDefinedExplicit = 7,
			UserDefinedThenNumericImplicit = 8,
			UserDefinedThenNumericExplicit = 9,
			UnityHierarchy = 10,
			EnumerableToArray = 11,
			EnumerableToList = 12,
			ToString = 13
		}
	
		private struct ConversionQuery : IEquatable<ConversionQuery> // TypeDefIndex: 56515
		{
			// Fields
			public readonly System.Type source; // 0x00
			public readonly System.Type destination; // 0x08
	
			// Constructors
			public ConversionQuery(System.Type source, System.Type destination) {
				this.source = default;
				this.destination = default;
			} // 0x000000018BE610C4-0x000000018BE61118
	
			// Methods
			public bool Equals(ConversionQuery other) => default; // 0x000000018B863BD4-0x000000018B863BF4
			public override bool Equals(object obj) => default; // 0x000000018B7BDDD8-0x000000018B7BDDFC
			public override int GetHashCode() => default; // 0x000000018BE60D18-0x000000018BE60DFC
		}
	
		private struct ConversionQueryComparer : IEqualityComparer<ConversionQuery> // TypeDefIndex: 56516
		{
			// Methods
			public bool Equals(ConversionQuery x, ConversionQuery y) => default; // 0x000000018BE60C34-0x000000018BE60D18
			public int GetHashCode(ConversionQuery obj) => default; // 0x000000018BE60DFC-0x000000018BE60E70
		}
	
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 56517
		{
			// Fields
			public System.Type source; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018BE600D8-0x000000018BE60380
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__2(MethodInfo m) => default; // 0x000000018BE60574-0x000000018BE606F4
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56518
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__11_0; // 0x08
			public static Func<MethodInfo, bool> __9__11_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE606F4-0x000000018BE60A3C
			public __c() {} // 0x000000018BE60A3C-0x000000018BE60B20
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__11_0(MethodInfo m) => default; // 0x000000018BE60B20-0x000000018BE60C34
			internal bool _FindUserDefinedConversionMethods_b__11_1(MethodInfo m) => default; // 0x000000018BE60E70-0x000000018BE60F94
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 56519
		{
			// Fields
			public System.Type destination; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0() {} // 0x000000018BE61054-0x000000018BE61068
	
			// Methods
			internal bool _GetUserDefinedConversionType_b__0(MethodInfo m) => default; // 0x000000018BE5F710-0x000000018BE5F77C
			internal bool _GetUserDefinedConversionType_b__1(MethodInfo m) => default; // 0x000000018BE5F6A4-0x000000018BE5F710
			internal bool _GetUserDefinedConversionType_b__2(MethodInfo m) => default; // 0x000000018BE5F77C-0x000000018BE5F7E0
		}
	
		// Constructors
		static ConversionUtility() {} // 0x000000018BE77AD0-0x000000018BE77B4C
	
		// Methods
		private static bool RespectsIdentity(System.Type source, System.Type destination) => default; // 0x000000018BE60FF4-0x000000018BE61054
		private static bool IsUpcast(System.Type source, System.Type destination) => default; // 0x000000018BE60F94-0x000000018BE60FF4
		private static bool IsDowncast(System.Type source, System.Type destination) => default; // 0x000000018BE60448-0x000000018BE60574
		public static bool HasImplicitNumericConversion(System.Type source, System.Type destination) => default; // 0x000000018BE5FBD4-0x000000018BE5FE14
		public static bool HasExplicitNumericConversion(System.Type source, System.Type destination) => default; // 0x000000018BE60380-0x000000018BE60448
		public static bool HasNumericConversion(System.Type source, System.Type destination) => default; // 0x000000018BE61068-0x000000018BE610C4
		private static IEnumerable<MethodInfo> FindUserDefinedConversionMethods(ConversionQuery query) => default; // 0x000000018BE61308-0x000000018BE614BC
		private static MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination) => default; // 0x000000018BE5FE14-0x000000018BE5FF4C
		private static ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination) => default; // 0x000000018BE5FF4C-0x000000018BE600D8
		private static bool HasEnumerableToArrayConversion(System.Type source, System.Type destination) => default; // 0x000000018BE61118-0x000000018BE61308
		private static bool HasEnumerableToListConversion(System.Type source, System.Type destination) => default; // 0x000000018BE5F7E0-0x000000018BE5FBD4
		private static bool HasUnityHierarchyConversion(System.Type source, System.Type destination) => default; // 0x000000018BE614BC-0x000000018BE62EC8
		private static bool IsValidConversion(ConversionType conversionType, bool guaranteed) => default; // 0x000000018523F5B0-0x000000018523F5E0
		public static bool CanConvert(object value, System.Type type, bool guaranteed) => default; // 0x000000018BE5F584-0x000000018BE5F5F4
		public static bool CanConvert(System.Type source, System.Type destination, bool guaranteed) => default; // 0x000000018BE5F5F4-0x000000018BE5F664
		public static object Convert(object value, System.Type type) => default; // 0x000000018BE5F664-0x000000018BE5F6A4
		public static bool IsConvertibleTo(System.Type source, System.Type destination, bool guaranteed) => default; // 0x000000018BE5F54C-0x000000018BE5F570
		public static bool IsConvertibleTo(object source, System.Type type, bool guaranteed) => default; // 0x000000018BE5F570-0x000000018BE5F584
		public static ConversionType GetRequiredConversion(System.Type source, System.Type destination) => default; // 0x0000000185492010-0x0000000185492020
		private static ConversionType DetermineConversionType(ConversionQuery query) => default; // 0x000000018BE77938-0x000000018BE779E0
		public static ConversionType GetRequiredConversion(object value, System.Type type) => default; // 0x000000018BE77F9C-0x000000018BE78000
		private static object NumericConversion(object value, System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		private static object UserDefinedConversion(ConversionType conversion, object value, System.Type type) => default; // 0x000000018BE774B8-0x000000018BE77504
		private static object EnumerableToArrayConversion(object value, System.Type arrayType) => default; // 0x000000018BE77504-0x000000018BE77550
		private static object EnumerableToListConversion(object value, System.Type listType) => default; // 0x0000000185492010-0x0000000185492020
		private static object UnityHierarchyConversion(object value, System.Type type) => default; // 0x000000018BE779E0-0x000000018BE77A54
		private static object Convert(object value, System.Type type, ConversionType conversionType) => default; // 0x000000018BE77A54-0x000000018BE77AD0
	}

	public struct LooseAssemblyName // TypeDefIndex: 56521
	{
		// Fields
		public readonly string name; // 0x00
	
		// Constructors
		public LooseAssemblyName(string name) {
			this.name = default;
		} // 0x000000018BE68544-0x000000018BE685B0
	
		// Methods
		public override bool Equals(object obj) => default; // 0x000000018BE684A4-0x000000018BE68508
		public override int GetHashCode() => default; // 0x000000018BE68508-0x000000018BE68544
		public override string ToString() => default; // 0x00000001834AFB60-0x00000001834AFB70
	}

	public static class MemberUtility // TypeDefIndex: 56523
	{
		// Fields
		private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache; // 0x00
		private static readonly Lazy<Dictionary<System.Type, MethodInfo[]>> InheritedExtensionMethodsCache; // 0x08
		private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56522
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c() {} // 0x000000018BE68D18-0x000000018BE68FAC
			public __c() {} // 0x000000018BE68C78-0x000000018BE68D18
	
			// Methods
			internal ExtensionMethodCache _.cctor_b__0_0() => default; // 0x000000018BE68A5C-0x000000018BE68AB0
			internal Dictionary<System.Type, MethodInfo[]> _.cctor_b__0_1() => default; // 0x000000018BE68AB0-0x000000018BE68B18
			internal HashSet<MethodInfo> _.cctor_b__0_2() => default; // 0x000000018BE68B18-0x000000018BE68C78
		}
	
		// Constructors
		static MemberUtility() {} // 0x000000018BE68A24-0x000000018BE68A5C
	
		// Methods
		public static bool IsUserDefinedConversion(MethodInfo method) => default; // 0x000000018BE77BB4-0x000000018BE77C18
		public static bool IsExtension(MethodInfo methodInfo) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsStatic(PropertyInfo propertyInfo) => default; // 0x000000018BE776F4-0x000000018BE77744
		public static bool IsStatic(MemberInfo memberInfo) => default; // 0x000000018BE77744-0x000000018BE777A4
		public static bool CanWrite(System.Reflection.FieldInfo fieldInfo) => default; // 0x000000018BE777A4-0x000000018BE77804
	}

	internal class ExtensionMethodCache // TypeDefIndex: 56525
	{
		// Fields
		internal readonly MethodInfo[] Cache; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56524
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__0_0; // 0x08
			public static Func<System.Type, IEnumerable<MethodInfo>> __9__0_1; // 0x10
			public static Func<MethodInfo, bool> __9__0_2; // 0x18
	
			// Constructors
			static __c() {} // 0x000000018BE641E4-0x000000018BE64510
			public __c() {} // 0x000000018BE77DA8-0x000000018BE77E0C
	
			// Methods
			internal bool _.ctor_b__0_0(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
			internal IEnumerable<MethodInfo> _.ctor_b__0_1(System.Type type) => default; // 0x000000018BE77814-0x000000018BE77888
			internal bool _.ctor_b__0_2(MethodInfo method) => default; // 0x000000018BE77888-0x000000018BE778A8
		}
	
		// Constructors
		internal ExtensionMethodCache() {} // 0x000000018BE778A8-0x000000018BE778F4
	}

	public sealed class Namespace // TypeDefIndex: 56527
	{
		// Fields
		private readonly Namespace _Root_k__BackingField; // 0x10
		private readonly Namespace _Parent_k__BackingField; // 0x18
		private readonly string _FullName_k__BackingField; // 0x20
		private readonly string _Name_k__BackingField; // 0x28
		private readonly bool _IsRoot_k__BackingField; // 0x30
		private readonly bool _IsGlobal_k__BackingField; // 0x31
		private static readonly Collection collection; // 0x00
		private static readonly Namespace _Global_k__BackingField; // 0x08
	
		// Properties
		public string FullName { get; } // 0x000000018BE692BC-0x000000018BE693B0 
		public static Namespace Global { get; } // 0x000000018A6C0B5C-0x000000018A6C0B74 
	
		// Nested types
		private class Collection : KeyedCollection<string, Namespace>, IKeyedCollection<string, Namespace> // TypeDefIndex: 56526
		{
			// Properties
			Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.this[string key] { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
	
			// Constructors
			public Collection() {} // 0x000000018BE693B0-0x000000018BE693D8
	
			// Methods
			protected override string GetKeyForItem(Namespace item) => default; // 0x000000018BE694A0-0x000000018BE695E4
			public new bool TryGetValue(string key, out Namespace value) {
				value = default;
				return default;
			} // 0x00000001813B31A0-0x00000001813B31B0
			bool IKeyedCollection<string, Namespace>.Contains(string key) => default; // 0x000000018BE693D8-0x000000018BE694A0
		}
	
		// Constructors
		public Namespace() {} // Dummy constructor
		private Namespace(string fullName) {} // 0x000000018BE695E4-0x000000018BE69634
		static Namespace() {} // 0x000000018B2F1480-0x000000018B2F14A8
	
		// Methods
		public override int GetHashCode() => default; // 0x000000018BE69230-0x000000018BE692BC
		public override string ToString() => default; // 0x000000018BE69634-0x000000018BE69680
		public static Namespace FromFullName(string fullName) => default; // 0x000000018BE5F408-0x000000018BE5F480
		public override bool Equals(object obj) => default; // 0x000000018BE5F510-0x000000018BE5F54C
		public static implicit operator Namespace(string fullName) => default; // 0x000000018BE5F4C8-0x000000018BE5F510
		public static bool operator ==(Namespace a, Namespace b) => default; // 0x000000018BE5F480-0x000000018BE5F4C8
	}

	public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 56528; 0x00000000-0x00000000

	public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 56529; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 56530; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 56531; 0x00000000-0x00000000

	public abstract class InstanceActionInvokerBase<TTarget> : InstanceInvokerBase<TTarget> // TypeDefIndex: 56532
	{
		// Constructors
		protected InstanceActionInvokerBase() {} // Dummy constructor
		protected InstanceActionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class InstanceActionInvoker<TTarget> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56533
	{
		// Fields
		private Action<TTarget> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56534
	{
		// Fields
		private Action<TTarget, TParam0> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		public override object Invoke(object target, object arg0) => default;
		private object InvokeUnsafe(object target, object arg0) => default;
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56535
	{
		// Fields
		private Action<TTarget, TParam0, TParam1> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56536
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56537
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 56538
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor // TypeDefIndex: 56539
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TTarget, TField> getter;
		private Action<TTarget, TField> setter;
	
		// Constructors
		public InstanceFieldAccessor() {} // Dummy constructor
		public InstanceFieldAccessor(System.Reflection.FieldInfo fieldInfo) {}
	
		// Methods
		public void Compile() {}
		public object GetValue(object target) => default;
		private object GetValueUnsafe(object target) => default;
		public void SetValue(object target, object value) {}
		private void SetValueUnsafe(object target, object value) {}
		private TField _Compile_b__4_0(TTarget instance) => default;
		private void _Compile_b__4_1(TTarget instance, TField value) {}
	}

	public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget> // TypeDefIndex: 56540
	{
		// Constructors
		protected InstanceFunctionInvokerBase() {} // Dummy constructor
		protected InstanceFunctionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56541
	{
		// Fields
		private Func<TTarget, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56542
	{
		// Fields
		private Func<TTarget, TParam0, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		public override object Invoke(object target, object arg0) => default;
		public object InvokeUnsafe(object target, object arg0) => default;
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56543
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56544
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56545
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 56546
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public abstract class InstanceInvokerBase<TTarget> : InvokerBase // TypeDefIndex: 56547
	{
		// Constructors
		protected InstanceInvokerBase() {} // Dummy constructor
		protected InstanceInvokerBase(MethodInfo methodInfo) {}
	
		// Methods
		protected sealed override void CompileExpression() {}
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target) {}
	}

	public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor // TypeDefIndex: 56548
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TTarget, TProperty> getter;
		private Action<TTarget, TProperty> setter;
	
		// Constructors
		public InstancePropertyAccessor() {} // Dummy constructor
		public InstancePropertyAccessor(PropertyInfo propertyInfo) {}
	
		// Methods
		public void Compile() {}
		public object GetValue(object target) => default;
		private object GetValueUnsafe(object target) => default;
		public void SetValue(object target, object value) {}
		private void SetValueUnsafe(object target, object value) {}
	}

	public abstract class InvokerBase : IOptimizedInvoker // TypeDefIndex: 56549
	{
		// Fields
		protected readonly System.Type targetType; // 0x10
		protected readonly MethodInfo methodInfo; // 0x18
	
		// Constructors
		protected InvokerBase() {} // Dummy constructor
		protected InvokerBase(MethodInfo methodInfo) {} // 0x000000018BE67F34-0x000000018BE68004
	
		// Methods
		protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg) {}
		public void Compile() {} // 0x000000018BE67C38-0x000000018BE67C88
		protected ParameterExpression[] GetParameterExpressions() => default; // 0x000000018BE67C88-0x000000018BE67EE8
		protected abstract System.Type[] GetParameterTypes();
		public virtual object Invoke(object target, object arg0) => default; // 0x000000018BE67EE8-0x000000018BE67F34
		protected abstract void CompileExpression();
		protected abstract void CreateDelegate();
		protected abstract void VerifyTarget(object target);
	}

	public interface IOptimizedAccessor // TypeDefIndex: 56550
	{
		// Methods
		void Compile();
		object GetValue(object target);
		void SetValue(object target, object value);
	}

	public interface IOptimizedInvoker // TypeDefIndex: 56551
	{
		// Methods
		void Compile();
		object Invoke(object target, object arg0);
	}

	public static class OptimizedReflection // TypeDefIndex: 56553
	{
		// Fields
		private static readonly Dictionary<System.Reflection.FieldInfo, IOptimizedAccessor> fieldAccessors; // 0x00
		private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors; // 0x08
		private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers; // 0x10
		public static readonly bool jitAvailable; // 0x18
		private static bool _useJitIfAvailable; // 0x19
		private static bool _safeMode_k__BackingField; // 0x1A
	
		// Properties
		internal static bool useJit { get; } // 0x000000018BE6CE68-0x000000018BE6CEBC 
		public static bool useJitIfAvailable { get; } // 0x000000018508FBE0-0x000000018508FCB0 
		public static bool safeMode { get; set; } // 0x000000018BE6CADC-0x000000018BE6CB30 
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56552
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, bool> __9__39_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185C386C0-0x0000000185C38880
			public __c() {} // 0x000000018BE6CDE0-0x000000018BE6CE68
	
			// Methods
			internal bool _SupportsOptimization_b__39_0(ParameterInfo parameter) => default; // 0x000000018BE6CD90-0x000000018BE6CDE0
		}
	
		// Constructors
		static OptimizedReflection() {} // 0x000000018BE6CD40-0x000000018BE6CD90
	
		// Methods
		internal static void OnRuntimeMethodLoad() {} // 0x000000018BE6CB30-0x000000018BE6CD40
		internal static void VerifyStaticTarget(System.Type targetType, object target) {} // 0x000000018BE6C810-0x000000018BE6C888
		internal static void VerifyInstanceTarget<TTArget>(object target) {} // 0x000000018BE6C644-0x000000018BE6C690
		private static void VerifyTarget(System.Type targetType, object target, bool @static) {} // 0x000000018BE6C728-0x000000018BE6C79C
		private static bool SupportsOptimization(MemberInfo memberInfo) => default; // 0x000000018BE6CA94-0x000000018BE6CADC
		public static IOptimizedAccessor Prewarm(System.Reflection.FieldInfo fieldInfo) => default; // 0x000000018BE69680-0x000000018BE69BD0
		public static void SetValueOptimized(System.Reflection.FieldInfo fieldInfo, object target, object value) {} // 0x000000018BE6C690-0x000000018BE6C6DC
		public static bool SupportsOptimization(System.Reflection.FieldInfo fieldInfo) => default; // 0x000000018BE6C79C-0x000000018BE6C810
		private static IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo) => default; // 0x000000018BE6CA4C-0x000000018BE6CA94
		public static IOptimizedAccessor Prewarm(PropertyInfo propertyInfo) => default; // 0x000000018BE6C058-0x000000018BE6C5D0
		public static void SetValueOptimized(PropertyInfo propertyInfo, object target, object value) {} // 0x000000018BE6C6DC-0x000000018BE6C728
		public static bool SupportsOptimization(PropertyInfo propertyInfo) => default; // 0x000000018BE6C5D0-0x000000018BE6C644
		private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo) => default; // 0x000000018BE6C888-0x000000018BE6CA4C
		public static IOptimizedInvoker Prewarm(MethodInfo methodInfo) => default; // 0x000000018BE69BD0-0x000000018BE6C058
		public static object InvokeOptimized(MethodInfo methodInfo, object target, object arg0) => default; // 0x000000018BE77F38-0x000000018BE77F9C
		public static bool SupportsOptimization(MethodInfo methodInfo) => default; // 0x0000000185492010-0x0000000185492020
		private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo) => default; // 0x000000018BE776CC-0x000000018BE776F4
	}

	public sealed class ReflectionFieldAccessor : IOptimizedAccessor // TypeDefIndex: 56554
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo; // 0x10
	
		// Constructors
		public ReflectionFieldAccessor() {} // Dummy constructor
		public ReflectionFieldAccessor(System.Reflection.FieldInfo fieldInfo) {} // 0x000000018BE6E3F0-0x000000018BE6E4A4
	
		// Methods
		public void Compile() {} // 0x0000000185492010-0x0000000185492020
		public object GetValue(object target) => default; // 0x00000001898F8348-0x00000001898F836C
		public void SetValue(object target, object value) {} // 0x00000001889B21BC-0x00000001889B21DC
	}

	public class ReflectionInvoker : IOptimizedInvoker // TypeDefIndex: 56555
	{
		// Fields
		private readonly MethodInfo methodInfo; // 0x10
		private static readonly object[] EmptyObjects; // 0x00
	
		// Constructors
		public ReflectionInvoker() {} // Dummy constructor
		public ReflectionInvoker(MethodInfo methodInfo) {} // 0x000000018BE6E5A8-0x000000018BE6E65C
		static ReflectionInvoker() {} // 0x000000018BE6E544-0x000000018BE6E5A8
	
		// Methods
		public void Compile() {} // 0x0000000185492010-0x0000000185492020
		public object Invoke(object target, object arg0) => default; // 0x000000018BE6E4A4-0x000000018BE6E544
	}

	public sealed class ReflectionPropertyAccessor : IOptimizedAccessor // TypeDefIndex: 56556
	{
		// Fields
		private readonly PropertyInfo propertyInfo; // 0x10
	
		// Constructors
		public ReflectionPropertyAccessor() {} // Dummy constructor
		public ReflectionPropertyAccessor(PropertyInfo propertyInfo) {} // 0x000000018BE6E65C-0x000000018BE6E710
	
		// Methods
		public void Compile() {} // 0x0000000185492010-0x0000000185492020
		public object GetValue(object target) => default; // 0x00000001898F58DC-0x00000001898F5900
		public void SetValue(object target, object value) {} // 0x0000000189F2ECC0-0x0000000189F2ECE8
	}

	public abstract class StaticActionInvokerBase : StaticInvokerBase // TypeDefIndex: 56557
	{
		// Constructors
		protected StaticActionInvokerBase() {} // Dummy constructor
		protected StaticActionInvokerBase(MethodInfo methodInfo) {} // 0x0000000189E99090-0x0000000189E99098
	}

	public sealed class StaticActionInvoker : StaticActionInvokerBase // TypeDefIndex: 56558
	{
		// Fields
		private Action invoke; // 0x20
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {} // 0x0000000189E99090-0x0000000189E99098
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default; // 0x000000018BE73C08-0x000000018BE73C58
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {} // 0x000000018BE73AEC-0x000000018BE73B8C
		protected override void CreateDelegate() {} // 0x000000018BE73B8C-0x000000018BE73C08
		private void _CreateDelegate_b__7_0() {} // 0x000000018BE73C58-0x000000018BE73D00
	}

	public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase // TypeDefIndex: 56559
	{
		// Fields
		private Action<TParam0> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		public override object Invoke(object target, object arg0) => default;
		private object InvokeUnsafe(object target, object arg0) => default;
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private void _CreateDelegate_b__7_0(TParam0 param0) {}
	}

	public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase // TypeDefIndex: 56560
	{
		// Fields
		private Action<TParam0, TParam1> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1) {}
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase // TypeDefIndex: 56561
	{
		// Fields
		private Action<TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) {}
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase // TypeDefIndex: 56562
	{
		// Fields
		private Action<TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) {}
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase // TypeDefIndex: 56563
	{
		// Fields
		private Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) {}
	}

	public class StaticFieldAccessor<TField> : IOptimizedAccessor // TypeDefIndex: 56565
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TField> getter;
		private Action<TField> setter;
		private System.Type targetType;
	
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56564
		{
			// Fields
			public TField constant;
	
			// Constructors
			public __c__DisplayClass5_0() {}
	
			// Methods
			internal TField _Compile_b__2() => default;
		}
	
		// Constructors
		public StaticFieldAccessor() {} // Dummy constructor
		public StaticFieldAccessor(System.Reflection.FieldInfo fieldInfo) {}
	
		// Methods
		public void Compile() {}
		public object GetValue(object target) => default;
		private object GetValueUnsafe(object target) => default;
		public void SetValue(object target, object value) {}
		private void SetValueUnsafe(object target, object value) {}
		private TField _Compile_b__5_0() => default;
		private void _Compile_b__5_1(TField value) {}
	}

	public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase // TypeDefIndex: 56566
	{
		// Constructors
		protected StaticFunctionInvokerBase() {} // Dummy constructor
		protected StaticFunctionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class StaticFunctionInvoker<TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56567
	{
		// Fields
		private Func<TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0() => default;
	}

	public sealed class StaticFunctionInvoker<TParam0, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56568
	{
		// Fields
		private Func<TParam0, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		public override object Invoke(object target, object arg0) => default;
		public object InvokeUnsafe(object target, object arg0) => default;
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0(TParam0 param0) => default;
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56569
	{
		// Fields
		private Func<TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1) => default;
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56570
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2) => default;
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56571
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3) => default;
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 56572
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4) => default;
	}

	public abstract class StaticInvokerBase : InvokerBase // TypeDefIndex: 56573
	{
		// Constructors
		protected StaticInvokerBase() {} // Dummy constructor
		protected StaticInvokerBase(MethodInfo methodInfo) {} // 0x000000018BE73DCC-0x000000018BE73EA0
	
		// Methods
		protected sealed override void CompileExpression() {} // 0x000000018BE73D00-0x000000018BE73D78
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target) {} // 0x000000018BE73D78-0x000000018BE73DCC
	}

	public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor // TypeDefIndex: 56574
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TProperty> getter;
		private Action<TProperty> setter;
		private System.Type targetType;
	
		// Constructors
		public StaticPropertyAccessor() {} // Dummy constructor
		public StaticPropertyAccessor(PropertyInfo propertyInfo) {}
	
		// Methods
		public void Compile() {}
		public object GetValue(object target) => default;
		private object GetValueUnsafe(object target) => default;
		public void SetValue(object target, object value) {}
		private void SetValueUnsafe(object target, object value) {}
	}

	public sealed class RenamedAssemblyAttribute : Attribute // TypeDefIndex: 56575
	{
		// Fields
		private readonly string _previousName_k__BackingField; // 0x10
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { get; } // 0x000000018346D130-0x000000018346D140 
		public string newName { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public RenamedAssemblyAttribute() {} // Dummy constructor
	}

	public sealed class RenamedFromAttribute : Attribute // TypeDefIndex: 56576
	{
		// Fields
		private readonly string _previousName_k__BackingField; // 0x10
	
		// Properties
		public string previousName { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public RenamedFromAttribute() {} // Dummy constructor
	}

	public sealed class RenamedNamespaceAttribute : Attribute // TypeDefIndex: 56577
	{
		// Fields
		private readonly string _previousName_k__BackingField; // 0x10
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { get; } // 0x000000018346D130-0x000000018346D140 
		public string newName { get; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public RenamedNamespaceAttribute() {} // Dummy constructor
		public RenamedNamespaceAttribute(string previousName, string newName) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public static class RuntimeCodebase // TypeDefIndex: 56580
	{
		// Fields
		private static readonly object @lock; // 0x00
		private static readonly List<System.Type> _types; // 0x08
		private static readonly List<Assembly> _assemblies; // 0x10
		public static HashSet<string> disallowedAssemblies; // 0x18
		private static readonly Dictionary<string, System.Type> typeSerializations; // 0x20
		private static Dictionary<string, System.Type> _renamedTypes; // 0x28
		private static Dictionary<string, string> _renamedNamespaces; // 0x30
		private static Dictionary<string, string> _renamedAssemblies; // 0x38
		private static readonly Dictionary<System.Type, Dictionary<string, string>> _renamedMembers; // 0x40
	
		// Properties
		public static IEnumerable<System.Type> types { get; } // 0x000000018BE6FADC-0x000000018BE6FFB0 
		public static IEnumerable<Assembly> assemblies { get; } // 0x000000018BE70F34-0x000000018BE70FD0 
		public static Dictionary<string, string> renamedNamespaces { get; } // 0x000000018BE76D5C-0x000000018BE76DA8 
		public static Dictionary<string, string> renamedAssemblies { get; } // 0x0000000181377E40-0x0000000181377E50 
		public static Dictionary<string, System.Type> renamedTypes { get; } // 0x000000018BE76CB0-0x000000018BE76D54 
	
		// Nested types
		private sealed class _GetAssemblyAttributes_d__15 : IEnumerable<Attribute>, IEnumerator<Attribute> // TypeDefIndex: 56578
		{
			// Fields
			private int __1__state; // 0x10
			private Attribute __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private System.Type attributeType; // 0x28
			public System.Type __3__attributeType; // 0x30
			private IEnumerable<Assembly> assemblies; // 0x38
			public IEnumerable<Assembly> __3__assemblies; // 0x40
			private IEnumerator<Assembly> __7__wrap1; // 0x48
			private IEnumerator<Attribute> __7__wrap2; // 0x50
	
			// Properties
			Attribute IEnumerator<System.Attribute>.Current { get => default; }
			object IEnumerator.Current { get => default; } // 0x000000018BE6F900-0x000000018BE6FADC 
	
			// Constructors
			public _GetAssemblyAttributes_d__15() {} // Dummy constructor
			public _GetAssemblyAttributes_d__15(int __1__state) {} // 0x000000018BE7106C-0x000000018BE710BC
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE70E48-0x000000018BE70E98
			private bool MoveNext() => default; // 0x000000018BE70864-0x000000018BE70E48
			private void __m__Finally1() {} // 0x000000018BE6F798-0x000000018BE6F7EC
			private void __m__Finally2() {} // 0x000000018BE6F710-0x000000018BE6F798
			void IEnumerator.Reset() {} // 0x000000018BE6F7EC-0x000000018BE6F880
			IEnumerator<Attribute> IEnumerable<Attribute>.GetEnumerator() => default; // 0x000000018BE6E710-0x000000018BE6E7FC
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE6F880-0x000000018BE6F900
		}
	
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 56579
		{
			// Fields
			public Unity.VisualScripting.TypeName typeName; // 0x10
			public Func<Assembly, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0() {} // 0x000000018BE6FFB0-0x000000018BE703D8
	
			// Methods
			internal bool _TrySystemTypeLookup_b__0(Assembly a) => default; // 0x000000018BE703D8-0x000000018BE70864
		}
	
		// Constructors
		static RuntimeCodebase() {} // 0x000000018BE70E98-0x000000018BE70F34
	
		// Methods
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType) => default; // 0x000000018BE70FD0-0x000000018BE7106C
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType, IEnumerable<Assembly> assemblies) => default; // 0x000000018BE6EB74-0x000000018BE6EEEC
		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>()
			where TAttribute : Attribute => default; // 0x000000018BE6E7FC-0x000000018BE6EB74
		public static string SerializeType(System.Type type) => default; // 0x000000018BE6EEEC-0x000000018BE6F710
		public static bool TryDeserializeType(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000184775050-0x0000000184775070
		public static System.Type DeserializeType(string typeName) => default; // 0x000000018BE76DA8-0x000000018BE76E94
		private static bool TryCachedTypeLookup(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x000000018BE767CC-0x000000018BE76CB0
		private static bool TrySystemTypeLookup(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x000000018BE76E94-0x000000018BE76EDC
		private static bool TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x000000018BE76EDC-0x000000018BE76F28
		private static bool TryRenamedTypeLookup(string previousTypeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		private static Dictionary<string, string> FetchRenamedNamespaces() => default; // 0x000000018BE76D54-0x000000018BE76D5C
		private static Dictionary<string, string> FetchRenamedAssemblies() => default; // 0x0000000185492010-0x0000000185492020
		private static Dictionary<string, System.Type> FetchRenamedTypes() => default; // 0x000000018BE77B4C-0x000000018BE77B90
	}

	public class TypeName // TypeDefIndex: 56583
	{
		// Fields
		private string _AssemblyDescription_k__BackingField; // 0x10
		private string _AssemblyName_k__BackingField; // 0x18
		private string _AssemblyVersion_k__BackingField; // 0x20
		private string _AssemblyCulture_k__BackingField; // 0x28
		private string _AssemblyPublicKeyToken_k__BackingField; // 0x30
		private readonly List<TypeName> _GenericParameters_k__BackingField; // 0x38
		private readonly List<string> names; // 0x40
		private readonly List<int> genericarities; // 0x48
		private string _Name_k__BackingField; // 0x50
	
		// Properties
		public string AssemblyDescription { get; private set; } // 0x0000000184088E70-0x0000000184088E80 0x000000018646EE40-0x000000018646EE50
		public string AssemblyName { get; private set; } // 0x0000000184A4EDC0-0x0000000184A4EDD0 0x00000001864721F0-0x0000000186472200
		private string AssemblyVersion { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0
		private string AssemblyCulture { get; set; } // 0x0000000181460F60-0x0000000181460F70
		private string AssemblyPublicKeyToken { get; set; } // 0x0000000184A4E570-0x0000000184A4E580
		public List<TypeName> GenericParameters { get; } // 0x000000018BE75AE0-0x000000018BE75B2C 
		public string Name { get; private set; } // 0x000000018BE74228-0x000000018BE74294 0x000000018BE75148-0x000000018BE75AE0
		public bool IsArray { get => default; } // 0x000000018BE74140-0x000000018BE74228 
	
		// Nested types
		private enum ParseState // TypeDefIndex: 56581
		{
			Name = 0,
			Array = 1,
			Generics = 2,
			Assembly = 3
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56582
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string> __9__35_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018346D130-0x000000018346D140
			public __c() {} // 0x0000000184096E30-0x0000000184096EF0
	
			// Methods
			internal string _.ctor_b__35_0(string x) => default; // 0x0000000181377E40-0x0000000181377E50
		}
	
		// Constructors
		public TypeName() {} // Dummy constructor
		private TypeName(string s, ref int index) {} // 0x000000018BE74294-0x000000018BE7449C
	
		// Methods
		public static TypeName Parse(string s) => default; // 0x000000018BE7477C-0x000000018BE74A68
		private static string LookForPairThenRemove(List<string> strings, string Name) => default; // 0x000000018BE746F4-0x000000018BE7477C
		public void ReplaceNamespace(string oldNamespace, string newNamespace) {} // 0x000000018BE7449C-0x000000018BE746F4
		public void ReplaceAssembly(string oldAssembly, string newAssembly) {} // 0x000000018BE74BD0-0x000000018BE74C58
		public void ReplaceName(string oldTypeName, System.Type newType) {} // 0x000000018BE74B5C-0x000000018BE74BD0
		public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName = null) {} // 0x000000018BE74A68-0x000000018BE74B5C
		private static string ToElementTypeName(string s) => default; // 0x000000018BE74FF8-0x000000018BE75148
		private static string ToArrayOrType(string oldType, string newType) => default; // 0x000000018BE74C68-0x000000018BE74FE8
		public void SetAssemblyName(AssemblyName newAssemblyName) {} // 0x000000018BE74FE8-0x000000018BE74FF8
		private void UpdateName() {} // 0x000000018BE74C58-0x000000018BE74C68
		public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification) => default; // 0x000000018BE77C7C-0x000000018BE77CE0
		public override string ToString() => default; // 0x0000000185492010-0x0000000185492020
		public string ToLooseString() => default; // 0x000000018BE778F4-0x000000018BE7791C
	}

	public enum TypeNameDetail // TypeDefIndex: 56584
	{
		Name = 0,
		NameAndAssembly = 1,
		Full = 2
	}

	public static class TypeUtility // TypeDefIndex: 56587
	{
		// Fields
		private static readonly HashSet<System.Type> _numericTypes; // 0x00
		private static readonly HashSet<System.Type> _numericConstructTypes; // 0x08
		private static readonly HashSet<System.Type> typesWithShortStrings; // 0x10
		private static readonly Dictionary<System.Type, object> defaultPrimitives; // 0x18
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56585
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__35_0; // 0x08
			public static Func<System.Type, bool> __9__35_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BE75C0C-0x000000018BE75D88
			public __c() {} // 0x000000018BE75E20-0x000000018BE75E58
	
			// Methods
			internal bool _GetTypesSafely_b__35_0(System.Type t) => default; // 0x000000018BE75D88-0x000000018BE75DFC
			internal bool _GetTypesSafely_b__35_1(System.Type t) => default; // 0x000000018BE75DFC-0x000000018BE75E20
		}
	
		private sealed class _GetTypesSafely_d__35 : IEnumerable<System.Type>, IEnumerator<System.Type> // TypeDefIndex: 56586
		{
			// Fields
			private int __1__state; // 0x10
			private System.Type __2__current; // 0x18
			private int __l__initialThreadId; // 0x20
			private Assembly assembly; // 0x28
			public Assembly __3__assembly; // 0x30
			private System.Type[] __7__wrap1; // 0x38
			private int __7__wrap2; // 0x40
	
			// Properties
			System.Type IEnumerator<System.Type>.Current { get => default; } // 0x000000018BE77E0C-0x000000018BE77E70 
			object IEnumerator.Current { get => default; } // 0x000000018BE77550-0x000000018BE77598 
	
			// Constructors
			public _GetTypesSafely_d__35() {} // Dummy constructor
			public _GetTypesSafely_d__35(int __1__state) {} // 0x000000018BE75B9C-0x000000018BE75C0C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BE75B2C-0x000000018BE75B9C
			private bool MoveNext() => default; // 0x000000018BE75E58-0x000000018BE767CC
			void IEnumerator.Reset() {} // 0x0000000185492010-0x0000000185492020
			IEnumerator<System.Type> IEnumerable<Type>.GetEnumerator() => default; // 0x000000018BE77598-0x000000018BE775E0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000184775050-0x0000000184775070
		}
	
		// Constructors
		static TypeUtility() {} // 0x000000018BE77464-0x000000018BE7746C
	
		// Methods
		public static bool IsBasic(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public static bool IsStatic(System.Type type) => default; // 0x000000018BE76F28-0x000000018BE773D0
		public static bool IsNullable(System.Type type) => default; // 0x0000000181377E40-0x0000000181377E50
		public static bool IsReferenceType(System.Type type) => default; // 0x000000018BE7746C-0x000000018BE774B8
		public static bool IsAssignableFrom(System.Type type, object value) => default; // 0x0000000181377E40-0x0000000181377E50
		public static IEnumerable<System.Type> GetTypesSafely(Assembly assembly) => default; // 0x000000018BE773D0-0x000000018BE77464
	}

	public class LooseAssemblyNameConverter : fsDirectConverter // TypeDefIndex: 56588
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x000000018BE68454-0x000000018BE684A4 
	
		// Constructors
		public LooseAssemblyNameConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE68220-0x000000018BE6825C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE68384-0x000000018BE68454
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE6825C-0x000000018BE68384
	}

	public class NamespaceConverter : fsDirectConverter // TypeDefIndex: 56589
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x000000018BE691E0-0x000000018BE69230 
	
		// Constructors
		public NamespaceConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE68FAC-0x000000018BE68FE8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE69104-0x000000018BE691E0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE68FE8-0x000000018BE69104
	}

	public class Ray2DConverter : fsDirectConverter<Ray2D> // TypeDefIndex: 56590
	{
		// Constructors
		public Ray2DConverter() {} // 0x000000018BE6D4CC-0x000000018BE6D4F4
	
		// Methods
		protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized) => default; // 0x000000018BE6D378-0x000000018BE6D4CC
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model) => default; // 0x000000018BE6D208-0x000000018BE6D378
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE6D1C8-0x000000018BE6D208
	}

	public class RayConverter : fsDirectConverter<Ray> // TypeDefIndex: 56591
	{
		// Constructors
		public RayConverter() {} // 0x000000018BE6D844-0x000000018BE6D86C
	
		// Methods
		protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized) => default; // 0x000000018BE6D6DC-0x000000018BE6D844
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model) => default; // 0x000000018BE6D548-0x000000018BE6D6DC
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE6D4F4-0x000000018BE6D548
	}

	public class UnityObjectConverter : fsConverter // TypeDefIndex: 56592
	{
		// Properties
		private List<UnityEngine.Object> objectReferences { get => default; } // 0x000000018BE783B8-0x000000018BE78408 
	
		// Constructors
		public UnityObjectConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE78000-0x000000018BE78078
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7828C-0x000000018BE783B8
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x000000018BE78078-0x000000018BE7828C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
	}

	public sealed class DoNotSerializeAttribute : Attribute // TypeDefIndex: 56593
	{
		// Constructors
		public DoNotSerializeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ISerializationDependency : ISerializationCallbackReceiver // TypeDefIndex: 56594
	{
		// Properties
		bool IsDeserialized { get; }
	}

	public interface ISerializationDepender : ISerializationCallbackReceiver // TypeDefIndex: 56595
	{
		// Properties
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		void OnAfterDependenciesDeserialized();
	}

	public static class Serialization // TypeDefIndex: 56596
	{
		// Fields
		private static readonly HashSet<SerializationOperation> freeOperations; // 0x00
		private static readonly HashSet<SerializationOperation> busyOperations; // 0x08
		private static readonly object @lock; // 0x10
		private static bool _isUnitySerializing_k__BackingField; // 0x18
		private static readonly HashSet<ISerializationDepender> awaitingDependers; // 0x20
	
		// Properties
		public static bool isUnitySerializing { get; set; } // 0x000000018BE73A48-0x000000018BE73A98 0x000000018BE73A98-0x000000018BE73AEC
		public static bool isCustomSerializing { get; } // 0x000000018BE739E4-0x000000018BE73A48 
	
		// Constructors
		static Serialization() {} // 0x000000018BE73854-0x000000018BE739E4
	
		// Methods
		private static SerializationOperation StartOperation() => default; // 0x000000018BE73618-0x000000018BE73854
		private static void EndOperation(SerializationOperation operation) {} // 0x000000018BE72B34-0x000000018BE72D40
		public static SerializationData Serialize(object value, bool forceReflected = false /* Metadata: 0x0207CDE6 */) => default; // 0x000000018BE73290-0x000000018BE73618
		public static void DeserializeInto(SerializationData data, ref object instance, bool forceReflected = false /* Metadata: 0x0207CDE7 */) {} // 0x000000018BE722B0-0x000000018BE72848
		public static object Deserialize(SerializationData data, bool forceReflected = false /* Metadata: 0x0207CDE8 */) => default; // 0x000000018BE72AC8-0x000000018BE72B34
		private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected) => default; // 0x000000018BE73064-0x000000018BE73290
		private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected) => default; // 0x000000018BE72848-0x000000018BE72970
		private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected) {} // 0x000000018BE72970-0x000000018BE72AC8
		private static void HandleResult(string label, fsResult result, UnityEngine.Object context = null) {} // 0x000000018BE72D40-0x000000018BE73048
		public static string PrettyPrint(string json) => default; // 0x000000018BE73048-0x000000018BE73064
		public static void AwaitDependencies(ISerializationDepender depender) {} // 0x000000018BE71DF8-0x000000018BE71E70
		private static void CheckIfDependenciesMet(ISerializationDepender depender) {} // 0x000000018BE71E70-0x000000018BE722B0
	}

	[Serializable]
	public struct SerializationData // TypeDefIndex: 56597
	{
		// Fields
		private string _json; // 0x00
		private UnityEngine.Object[] _objectReferences; // 0x08
	
		// Properties
		public string json { get => default; } // 0x00000001834AFB60-0x00000001834AFB70 
		public UnityEngine.Object[] objectReferences { get => default; } // 0x000000018357A260-0x000000018357A270 
	
		// Constructors
		public SerializationData(string json, IEnumerable<UnityEngine.Object> objectReferences) : this() {
			_json = default;
			_objectReferences = default;
		} // 0x000000018BE71AE4-0x000000018BE71B84
		public SerializationData(string json, UnityEngine.Object[] objectReferences) : this() {
			_json = default;
			_objectReferences = default;
		} // 0x000000018BE71ADC-0x000000018BE71AE4
	
		// Methods
		internal void Clear() {} // 0x000000018A6676CC-0x000000018A6676F0
		public string ToString(string title) => default; // 0x000000018BE71448-0x000000018BE71AD0
		public override string ToString() => default; // 0x000000018BE71AD0-0x000000018BE71ADC
		public void ShowString(string title = null) {} // 0x000000018BE7137C-0x000000018BE71448
	}

	public class SerializationOperation // TypeDefIndex: 56598
	{
		// Fields
		private fsSerializer _serializer_k__BackingField; // 0x10
		private List<UnityEngine.Object> _objectReferences_k__BackingField; // 0x18
	
		// Properties
		public fsSerializer serializer { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public List<UnityEngine.Object> objectReferences { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public SerializationOperation() {} // 0x000000018BE71BCC-0x000000018BE71DF0
	
		// Methods
		public void Reset() {} // 0x000000018BE71B84-0x000000018BE71BCC
	}

	public class SerializationVersionAttribute : fsObjectAttribute // TypeDefIndex: 56599
	{
		// Constructors
		public SerializationVersionAttribute() {} // Dummy constructor
		public SerializationVersionAttribute(string versionString, System.Type[] previousModels) {} // 0x000000018BE71DF0-0x000000018BE71DF8
	}

	public class SerializeAsAttribute : fsPropertyAttribute // TypeDefIndex: 56600
	{
		// Constructors
		public SerializeAsAttribute() {} // Dummy constructor
		public SerializeAsAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class SerializeAttribute : Attribute // TypeDefIndex: 56601
	{
		// Constructors
		public SerializeAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public interface ISingleton // TypeDefIndex: 56602
	{
	}

	public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 56603
	{
		// Fields
		protected SerializationData _data; // 0x18
		private Action OnDestroyActions; // 0x28
	
		// Events
		internal event Action OnDestroyActions;
	
		// Constructors
		protected LudiqScriptableObject() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018BE687B0-0x000000018BE688FC
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x000000018BE6864C-0x000000018BE687B0
		protected virtual void OnBeforeSerialize() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAfterSerialize() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnBeforeDeserialize() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnAfterDeserialize() {} // 0x0000000185492010-0x0000000185492020
		protected virtual void OnPostDeserializeInEditor() {} // 0x0000000185492010-0x0000000185492020
		private void OnDestroy() {} // 0x000000018BE685B0-0x000000018BE685C0
		protected virtual void ShowData() {} // 0x000000018BE685C0-0x000000018BE68644
		public override string ToString() => default; // 0x000000018BE68644-0x000000018BE6864C
	}

	public static class Singleton<T> // TypeDefIndex: 56604
		where T : MonoBehaviour, ISingleton
	{
		// Fields
		private static readonly SingletonAttribute attribute;
		private static readonly object _lock;
		private static readonly HashSet<T> awoken;
		private static T _instance;
	
		// Properties
		private static bool persistent { get; }
		private static bool automatic { get; }
		private static string name { get; }
		private static HideFlags hideFlags { get; }
		public static T instance { get; }
	
		// Constructors
		static Singleton() {}
	
		// Methods
		private static T[] FindObjectsOfType() => default;
		private static T[] FindInstances() => default;
		public static T Instantiate() => default;
		public static void Awake(T instance) {}
		public static void OnDestroy(T instance) {}
	}

	public sealed class SingletonAttribute : Attribute // TypeDefIndex: 56605
	{
		// Fields
		private bool _Persistent_k__BackingField; // 0x10
		private bool _Automatic_k__BackingField; // 0x11
		private HideFlags _HideFlags_k__BackingField; // 0x14
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public bool Persistent { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public bool Automatic { get; set; } // 0x0000000185FB22C0-0x0000000185FB22D0 0x0000000185FB2560-0x0000000185FB2570
		public HideFlags HideFlags { get; set; } // 0x0000000185FB21A0-0x0000000185FB21B0 0x0000000185FBB0B0-0x0000000185FBB0C0
		public string Name { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public SingletonAttribute() {} // 0x0000000185FCA270-0x0000000185FCA280
	}

	public static class UnityThread // TypeDefIndex: 56606
	{
		// Fields
		public static Thread thread; // 0x00
		public static ConcurrentQueue<Action> pendingQueue; // 0x08
	
		// Properties
		public static bool allowsAPI { get; } // 0x000000018BE78730-0x000000018BE787DC 
	
		// Constructors
		static UnityThread() {} // 0x0000000185C1FB80-0x0000000185C1FC40
	
		// Methods
		internal static void RuntimeInitialize() {} // 0x000000018508F800-0x000000018508F870
	}

	public static class Empty<T> // TypeDefIndex: 56607
	{
		// Fields
		public static readonly T[] array;
		public static readonly List<T> list;
		public static readonly HashSet<T> hashSet;
	
		// Constructors
		static Empty() {}
	}

	public static class HashUtility // TypeDefIndex: 56608
	{
		// Methods
		public static int GetHashCode<T>(T a) => default;
		public static int GetHashCode<T1, T2>(T1 a, T2 b) => default;
	}

	public interface IIdentifiable // TypeDefIndex: 56609
	{
		// Properties
		Guid guid { get; }
	}

	public static class LinqUtility // TypeDefIndex: 56612
	{
		// Nested types
		private sealed class _Concat_d__0<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 56610
		{
			// Fields
			private int __1__state;
			private T __2__current;
			private int __l__initialThreadId;
			private IEnumerable[] enumerables;
			public IEnumerable[] __3__enumerables;
			private IEnumerator<IEnumerable> __7__wrap1;
			private IEnumerator<T> __7__wrap2;
	
			// Properties
			T IEnumerator<T>.Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			public _Concat_d__0() {} // Dummy constructor
			public _Concat_d__0(int __1__state) {}
	
			// Methods
			void IDisposable.Dispose() {}
			private bool MoveNext() => default;
			private void __m__Finally1() {}
			private void __m__Finally2() {}
			void IEnumerator.Reset() {}
			IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		[Serializable]
		private sealed class __c__2<T> // TypeDefIndex: 56611
		{
			// Fields
			public static readonly __c__2<T> __9;
			public static Func<T, bool> __9__2_0;
	
			// Constructors
			static __c__2() {}
			public __c__2() {}
	
			// Methods
			internal bool _NotNull_b__2_0(T i) => default;
		}
	
		// Methods
		public static IEnumerable<T> Concat<T>(IEnumerable[] enumerables) => default;
		public static IEnumerable<T> NotNull<T>(IEnumerable<T> enumerable) => default;
	}

	public class Recursion<T> : IPoolable, IDisposable // TypeDefIndex: 56614
	{
		// Fields
		private readonly Stack<T> traversedOrder;
		private readonly Dictionary<T, int> traversedCount;
		private bool disposed;
		protected int maxDepth;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56613
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<Recursion<T>> __9__13_0;
	
			// Constructors
			static __c() {}
			public __c() {}
	
			// Methods
			internal Recursion<T> _New_b__13_0() => default;
		}
	
		// Constructors
		protected Recursion() {}
	
		// Methods
		public void Enter(T o) {}
		public bool TryEnter(T o) => default;
		public void Exit(T o) {}
		public void Dispose() {}
		protected virtual void Free() {}
		void IPoolable.New() {}
		void IPoolable.Free() {}
		public static Recursion<T> New() => default;
		public static Recursion<T> New(int maxDepth) => default;
	}

	public sealed class Recursion : Recursion<object> // TypeDefIndex: 56615
	{
		// Fields
		private static int _defaultMaxDepth_k__BackingField; // 0x00
		private static bool _safeMode_k__BackingField; // 0x04
	
		// Properties
		public static int defaultMaxDepth { get; } // 0x000000018BE6D86C-0x000000018BE6D8BC 
		public static bool safeMode { get; set; } // 0x000000018BE6D8BC-0x000000018BE6D90C 0x000000018BE6D90C-0x000000018BE6D960
	
		// Constructors
		public Recursion() {} // Dummy constructor
		static Recursion() {} // 0x0000000185FA41A0-0x0000000185FA41E0
	
		// Methods
		internal static void OnRuntimeMethodLoad() {} // 0x000000018508FCB0-0x000000018508FD80
	}

	public static class ReferenceCollector // TypeDefIndex: 56617
	{
		// Fields
		private static Action onSceneUnloaded; // 0x00
	
		// Events
		public static event Action onSceneUnloaded;
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56616
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnityAction<Scene> __9__3_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE6D960-0x000000018BE6DA08
			public __c() {} // 0x000000018BE6DA08-0x000000018BE6DAB0
	
			// Methods
			internal void _Initialize_b__3_0(Scene scene) {} // 0x000000018508EAC0-0x000000018508EBE0
		}
	
		// Methods
		internal static void Initialize() {} // 0x0000000185F82000-0x0000000185F82050
	}

	public class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 56618
	{
		// Fields
		public static readonly ReferenceEqualityComparer Instance; // 0x00
	
		// Constructors
		private ReferenceEqualityComparer() {} // 0x0000000185492010-0x0000000185492020
		static ReferenceEqualityComparer() {} // 0x0000000185F79C30-0x0000000185F79C90
	
		// Methods
		bool IEqualityComparer<object>.Equals(object a, object b) => default; // 0x0000000185FA80A0-0x0000000185FA80B0
		int IEqualityComparer<object>.GetHashCode(object a) => default; // 0x0000000185EE03A0-0x0000000185EE03F0
		public static int GetHashCode(object a) => default; // 0x0000000185FB0F10-0x0000000185FB0F20
	}

	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 56619
	{
		// Fields
		public static readonly ReferenceEqualityComparer<T> Instance;
	
		// Constructors
		private ReferenceEqualityComparer() {}
		static ReferenceEqualityComparer() {}
	
		// Methods
		bool IEqualityComparer<T>.Equals(T a, T b) => default;
		int IEqualityComparer<T>.GetHashCode(T a) => default;
		public static int GetHashCode(T a) => default;
	}

	public static class RuntimeVSUsageUtility // TypeDefIndex: 56620
	{
		// Methods
		private static void RuntimeInitializeOnLoadBeforeSceneLoad() {} // 0x000000018508F730-0x000000018508F800
	}

	public static class StringUtility // TypeDefIndex: 56621
	{
		// Fields
		private static readonly Regex guidRegex; // 0x00
	
		// Constructors
		static StringUtility() {} // 0x000000018BE740B0-0x000000018BE74140
	
		// Methods
		public static string TrimStart(string source, string value) => default; // 0x000000018BE74010-0x000000018BE740B0
		public static void PartsAround(string s, char c, out string before, out string after) {
			before = default;
			after = default;
		} // 0x000000018BE73EA0-0x000000018BE73F94
		public static string ToHexString(byte[] bytes) => default; // 0x000000018BE73F94-0x000000018BE74010
	}

	public static class UnityObjectUtility // TypeDefIndex: 56622
	{
		// Methods
		public static bool IsUnityNull(object obj) => default; // 0x000000018BE78408-0x000000018BE78484
		public static string ToSafeString(UnityEngine.Object uo) => default; // 0x000000018BE78484-0x000000018BE786A8
		public static T AsUnityNull<T>(T obj)
			where T : UnityEngine.Object => default;
		public static bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b) => default; // 0x000000018BE786A8-0x000000018BE78730
	}

	public static class ApplicationVariables // TypeDefIndex: 56623
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		private static VariableDeclarations _runtime_k__BackingField; // 0x08
	
		// Properties
		public static VariablesAsset asset { get; } // 0x00000001856FFDB0-0x00000001856FFE40 
		private static VariableDeclarations runtime { get; set; } // 0x000000018BE5E584-0x000000018BE5E5D8
	
		// Methods
		public static void Load() {} // 0x00000001856FFE40-0x00000001856FFED0
		internal static void OnEnterPlayMode() {} // 0x00000001864731DC-0x00000001864731E4
		internal static void OnExitPlayMode() {} // 0x0000000185492010-0x0000000185492020
		private static void CreateRuntimeDeclarations() {} // 0x00000001856FF3C0-0x00000001856FF480
	}

	public sealed class InspectorVariableNameAttribute : Attribute // TypeDefIndex: 56624
	{
		// Fields
		private ActionDirection _direction_k__BackingField; // 0x10
	
		// Properties
		private ActionDirection direction { get; set; } // 0x0000000181378230-0x0000000181378240
	
		// Constructors
		public InspectorVariableNameAttribute() {} // Dummy constructor
		public InspectorVariableNameAttribute(ActionDirection direction) {} // 0x0000000181378230-0x0000000181378240
	}

	public static class SavedVariables // TypeDefIndex: 56626
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		private static VariableDeclarations _saved_k__BackingField; // 0x08
		private static VariableDeclarations _merged_k__BackingField; // 0x10
	
		// Properties
		public static VariablesAsset asset { get; } // 0x00000001856FFC80-0x00000001856FFD20 
		public static VariableDeclarations initial { get; } // 0x000000018BE712D4-0x000000018BE71328 
		public static VariableDeclarations saved { get; private set; } // 0x000000018BE710D4-0x000000018BE71264 0x00000001856FFF60-0x0000000185700060
		public static VariableDeclarations merged { get; private set; } // 0x00000001856FF480-0x00000001856FFC80 0x00000001857001D0-0x0000000185700410
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56625
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__8_0; // 0x08
			public static Func<VariableDeclaration, string> __9__24_0; // 0x10
	
			// Constructors
			static __c() {} // 0x00000001856FFD20-0x00000001856FFDB0
			public __c() {} // 0x00000001856FFED0-0x00000001856FFF60
	
			// Methods
			internal void _OnEnterPlayMode_b__8_0() {} // 0x00000001856FF240-0x00000001856FF3C0
			internal string _MergeInitialAndSavedDeclarations_b__24_0(VariableDeclaration vd) => default; // 0x000000018BE710BC-0x000000018BE710D4
		}
	
		// Methods
		public static void Load() {} // 0x000000018BE7129C-0x000000018BE712D4
		internal static void OnEnterPlayMode() {} // 0x000000018BE71328-0x000000018BE7137C
		internal static void OnExitPlayMode() {} // 0x000000018BE71264-0x000000018BE7129C
		public static void SaveDeclarations(VariableDeclarations declarations) {} // 0x0000000185F77290-0x0000000185F772F0
		public static void FetchSavedDeclarations() {} // 0x0000000185492010-0x0000000185492020
		private static void MergeInitialAndSavedDeclarations() {} // 0x000000018BE77674-0x000000018BE776CC
		private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations) {} // 0x0000000187AD0B8C-0x0000000187AD0BA4
	}

	public sealed class VariableDeclaration // TypeDefIndex: 56627
	{
		// Fields
		private string _name_k__BackingField; // 0x10
		private object _value_k__BackingField; // 0x18
	
		// Properties
		public string name { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
		public object value { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public VariableDeclaration() {} // Dummy constructor
		public VariableDeclaration(string name, object value) {} // 0x00000001841BC230-0x00000001841BC260
	}

	public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration> // TypeDefIndex: 56628
	{
		// Properties
		VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.this[string key] { get => default; } // 0x000000018BE78F2C-0x000000018BE78F74 
	
		// Constructors
		public VariableDeclarationCollection() {} // 0x0000000185700190-0x00000001857001D0
	
		// Methods
		protected override string GetKeyForItem(VariableDeclaration item) => default; // 0x0000000187AD0B8C-0x0000000187AD0BA4
		public new bool TryGetValue(string key, out VariableDeclaration value) {
			value = default;
			return default;
		} // 0x000000018BE78E6C-0x000000018BE78EE4
		bool IKeyedCollection<string, VariableDeclaration>.Contains(string key) => default; // 0x000000018BE78EE4-0x000000018BE78F2C
	}

	public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, ISpecifiesCloner // TypeDefIndex: 56629
	{
		// Fields
		public VariableKind Kind; // 0x10
		private VariableDeclarationCollection collection; // 0x18
		internal Action OnVariableChanged; // 0x20
	
		// Properties
		public object this[string variable] { get => default; set {} } // 0x000000018BE793A8-0x000000018BE793B0 0x000000018BE793B0-0x000000018BE793B8
		ICloner ISpecifiesCloner.cloner { get => default; } // 0x000000018BE79358-0x000000018BE793A8 
	
		// Constructors
		public VariableDeclarations() {} // 0x0000000185700120-0x0000000185700190
	
		// Methods
		public void Set(string variable, object value) {} // 0x000000018BE79214-0x000000018BE79310
		public object Get(string variable) => default; // 0x000000018BE79020-0x000000018BE79154
		public void Clear() {} // 0x000000018BE78FD8-0x000000018BE79020
		public bool IsDefined(string variable) => default; // 0x000000018BE79154-0x000000018BE79214
		public IEnumerator<VariableDeclaration> GetEnumerator() => default; // 0x00000001857006D0-0x0000000185700720
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018BE79310-0x000000018BE79358
	}

	public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations> // TypeDefIndex: 56630
	{
		// Fields
		public static readonly VariableDeclarationsCloner instance; // 0x00
	
		// Constructors
		public VariableDeclarationsCloner() {} // 0x0000000185F41970-0x0000000185F419A0
		static VariableDeclarationsCloner() {} // 0x0000000185F41900-0x0000000185F41970
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018BE78F74-0x000000018BE78FD8
		public override VariableDeclarations ConstructClone(System.Type type, VariableDeclarations original) => default; // 0x0000000185700060-0x00000001857000B0
		public override void FillClone(System.Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context) {} // 0x00000001857004E0-0x00000001857006D0
	}

	public enum VariableKind // TypeDefIndex: 56631
	{
		Flow = 0,
		Graph = 1,
		Object = 2,
		Scene = 3,
		Application = 4,
		Saved = 5
	}

	public sealed class VariablesAsset : LudiqScriptableObject // TypeDefIndex: 56632
	{
		// Fields
		private VariableDeclarations _declarations_k__BackingField; // 0x30
	
		// Properties
		public VariableDeclarations declarations { get; internal set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
	
		// Constructors
		public VariablesAsset() {} // 0x00000001857000B0-0x0000000185700120
	
		// Methods
		protected override void ShowData() {} // 0x000000018BE793B8-0x000000018BE793C0
	}

	public class VariablesSaver : MonoBehaviour, ISingleton // TypeDefIndex: 56633
	{
		// Properties
		public static VariablesSaver instance { get => default; } // 0x000000018BE794D0-0x000000018BE79524 
	
		// Constructors
		public VariablesSaver() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x000000018BE793C0-0x000000018BE79414
		private void OnDestroy() {} // 0x000000018BE7947C-0x000000018BE794D0
		private void OnApplicationQuit() {} // 0x000000018BE79474-0x000000018BE7947C
		private void OnApplicationPause(bool isPaused) {} // 0x000000018BE79468-0x000000018BE79474
		public static void Instantiate() {} // 0x000000018BE79414-0x000000018BE79468
	}
}

namespace Unity.VisualScripting.FullSerializer
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 56634
	{
		// Constructors
		public fsArrayConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018B4E5844-0x000000018B4E5864
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE799C4-0x000000018BE79BA0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE7975C-0x000000018BE799C4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE796E8-0x000000018BE7975C
	}

	public class fsDateConverter : fsConverter // TypeDefIndex: 56635
	{
		// Properties
		private string DateTimeFormatString { get => default; } // 0x000000018BE7C894-0x000000018BE7C8E8 
	
		// Constructors
		public fsDateConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE7C044-0x000000018BE7C108
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7C68C-0x000000018BE7C894
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE7C108-0x000000018BE7C68C
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 56636
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE7CB88-0x000000018BE7CC00
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE7CC00-0x000000018BE7CC74
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x000000018BE7CD90-0x000000018BE7D68C
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7D68C-0x000000018BE7DBC8
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value) => default; // 0x000000018BE7C8E8-0x000000018BE7CB88
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType) {
			keyStorageType = default;
			valueStorageType = default;
		} // 0x000000018BE7CC74-0x000000018BE7CD90
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 56639
	{
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 56637
		{
			// Fields
			public Enum x; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BE7DD2C-0x000000018BE7DD84
	
			// Methods
			internal ValueTuple<Enum, string> _TryDeserialize_b__3(RenamedFromAttribute attr) => default; // 0x00000001814A81B0-0x00000001814A81C0
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 56638
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Enum, IEnumerable<ValueTuple<Enum, string>>> __9__5_0; // 0x08
			public static Func<ValueTuple<Enum, string>, string> __9__5_1; // 0x10
			public static Func<ValueTuple<Enum, string>, Enum> __9__5_2; // 0x18
	
			// Constructors
			static __c() {} // 0x00000001814A81B0-0x00000001814A81C0
			public __c() {} // 0x000000018BE7DD84-0x000000018BE7DDF8
	
			// Methods
			internal IEnumerable<ValueTuple<Enum, string>> _TryDeserialize_b__5_0(Enum x) => default; // 0x000000018BE7E564-0x000000018BE7EC0C
			internal string _TryDeserialize_b__5_1(ValueTuple<Enum, string> x) => default; // 0x000000018BE7DDF8-0x000000018BE7E564
			internal Enum _TryDeserialize_b__5_2(ValueTuple<Enum, string> x) => default;
		}
	
		// Constructors
		public fsEnumConverter() {} // 0x000000018305C9B0-0x000000018305C9C0
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x0000000185492010-0x0000000185492020
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018BE78D34-0x000000018BE78DA4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE78DA4-0x000000018BE78E08
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE78A7C-0x000000018BE78B7C
		private static bool ArrayContains<T>(T[] values, T value) => default; // 0x0000000185FC19A0-0x0000000185FC19B0
	}

	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 56640
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute() {} // Dummy constructor
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 56641
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x000000018B4E7B58-0x000000018B4E7B7C
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE7EC0C-0x000000018BE7EC68
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x000000018BE7ECDC-0x000000018BE7EEA4
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7F028-0x000000018BE7F188
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE7EEA4-0x000000018BE7F028
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE7EC68-0x000000018BE7ECDC
	}

	public class fsGuidConverter : fsConverter // TypeDefIndex: 56642
	{
		// Constructors
		public fsGuidConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE7F208-0x000000018BE7F26C
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7F3B4-0x000000018BE7F4A4
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE7F2AC-0x000000018BE7F3B4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE7F26C-0x000000018BE7F2AC
	}

	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 56643
	{
		// Constructors
		public fsIEnumerableConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE7F4A4-0x000000018BE7F53C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE7F53C-0x000000018BE7F5B0
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE7FC84-0x000000018BE7FFF8
		private bool IsStack(System.Type type) => default; // 0x000000018BE7F854-0x000000018BE7F90C
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x000000018BE7F9A0-0x000000018BE7FC84
		private static int HintSize(IEnumerable collection) => default; // 0x000000018BE7F7DC-0x000000018BE7F854
		private static System.Type GetElementType(System.Type objectType) => default; // 0x000000018BE7F6F0-0x000000018BE7F7DC
		private static void TryClear(System.Type type, object instance) {} // 0x000000018BE7F90C-0x000000018BE7F9A0
		private static MethodInfo GetAddMethod(System.Type type) => default; // 0x000000018BE7F5B0-0x000000018BE7F6F0
	}

	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 56644
	{
		// Constructors
		public fsKeyValuePairConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE8338C-0x000000018BE83438
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE83438-0x000000018BE8382C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE8382C-0x000000018BE83AE4
	}

	public class fsNullableConverter : fsConverter // TypeDefIndex: 56645
	{
		// Constructors
		public fsNullableConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE85BF8-0x000000018BE85CA4
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE85D1C-0x000000018BE85D94
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE85CA4-0x000000018BE85D1C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 56646
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE86620-0x000000018BE866E8
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE86C8C-0x000000018BE87238
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x000000018BE866E8-0x000000018BE86C8C
		private static bool UseBool(System.Type type) => default; // 0x000000018BE87238-0x000000018BE8729C
		private static bool UseInt64(System.Type type) => default; // 0x000000018BE87360-0x000000018BE8751C
		private static bool UseDouble(System.Type type) => default; // 0x000000018BE8729C-0x000000018BE87360
		private static bool UseString(System.Type type) => default; // 0x000000018BE8751C-0x000000018BE875B4
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 56647
	{
		// Constructors
		public fsReflectedConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE875B4-0x000000018BE87660
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE87934-0x000000018BE87B74
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE876D4-0x000000018BE87934
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE87660-0x000000018BE876D4
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 56648
	{
		// Constructors
		public fsTypeConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE8DCAC-0x000000018BE8DD24
		public override bool RequestCycleSupport(System.Type type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE8DEA0-0x000000018BE8DF98
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE8DD24-0x000000018BE8DEA0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000185FB66E0-0x0000000185FB66F0
	}

	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 56649
	{
		// Constructors
		public fsWeakReferenceConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE8F3A8-0x000000018BE8F40C
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x00000001814A81B0-0x00000001814A81C0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018BE8F784-0x000000018BE8FA88
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x000000018BE8F464-0x000000018BE8F784
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x000000018BE8F40C-0x000000018BE8F464
	}

	public class fsConverterRegistrar // TypeDefIndex: 56650
	{
		// Fields
		public static List<System.Type> Converters; // 0x00
	
		// Constructors
		public fsConverterRegistrar() {} // Dummy constructor
		static fsConverterRegistrar() {} // 0x000000018BE7A5DC-0x000000018BE7A8F0
	}

	public class fsAotCompilationManager // TypeDefIndex: 56652
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 56651
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager() {} // Dummy constructor
		static fsAotCompilationManager() {} // 0x000000018BE795F4-0x000000018BE796E8
	
		// Methods
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) {} // 0x000000018BE79524-0x000000018BE795F4
	}

	public abstract class fsBaseConverter // TypeDefIndex: 56654
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56653
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018BE79FCC-0x000000018BE7A120
			public __c() {} // 0x000000018BE7A460-0x000000018BE7A514
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t) => default; // 0x000000018BE7A514-0x000000018BE7A564
		}
	
		// Constructors
		protected fsBaseConverter() {} // 0x000000018BE78A2C-0x000000018BE78A7C
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType) => default;
		public virtual bool RequestCycleSupport(System.Type storageType) => default;
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018BE7A120-0x000000018BE7A460
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018BE79DB4-0x000000018BE79FCC
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018BE79BA0-0x000000018BE79C0C
		protected fsResult FailExpectedType(fsData data, fsDataType[] types) => default; // 0x000000018BE79C0C-0x000000018BE79DB4
		protected fsResult CheckType(fsData data, fsDataType type) => default;
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		}
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value) => default; // 0x000000018BE78E08-0x000000018BE78E6C
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value) {
			value = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
	}

	public static class fsGlobalConfig // TypeDefIndex: 56655
	{
		// Fields
		public static bool IsCaseSensitive; // 0x00
		public static bool AllowInternalExceptions; // 0x01
		public static string InternalFieldPrefix; // 0x08
	
		// Constructors
		static fsGlobalConfig() {} // 0x000000018BE7F188-0x000000018BE7F208
	}

	public class fsConfig // TypeDefIndex: 56657
	{
		// Fields
		public System.Type[] SerializeAttributes; // 0x10
		public System.Type[] IgnoreSerializeAttributes; // 0x18
		public fsMemberSerialization DefaultMemberSerialization; // 0x20
		public Func<string, MemberInfo, string> GetJsonNameFromMemberName; // 0x28
		public bool EnablePropertySerialization; // 0x30
		public bool SerializeNonAutoProperties; // 0x31
		public bool SerializeNonPublicSetProperties; // 0x32
		public string CustomDateTimeFormatString; // 0x38
		public bool Serialize64BitIntegerAsString; // 0x40
		public bool SerializeEnumsAsInteger; // 0x41
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 56656
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, MemberInfo, string> __9__10_0; // 0x08
	
			// Constructors
			static __c() {} // 0x000000018577F8A0-0x000000018577FBD0
			public __c() {} // 0x0000000185F70D50-0x0000000185F70DB0
	
			// Methods
			internal string _.ctor_b__10_0(string name, MemberInfo info) => default; // 0x0000000185492010-0x0000000185492020
		}
	
		// Constructors
		public fsConfig() {} // 0x00000001834A4750-0x00000001834A4760
	}

	public sealed class fsContext // TypeDefIndex: 56658
	{
		// Fields
		private readonly Dictionary<System.Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext() {} // 0x000000018BE7A564-0x000000018BE7A5DC
	
		// Methods
		public void Set<T>(T obj) {}
		public T Get<T>() => default;
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 56659
	{
		// Constructors
		protected fsConverter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public enum fsDataType // TypeDefIndex: 56660
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 56661
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get => default; } // 0x000000018BE7BDC4-0x000000018BE7BF20 
		public bool IsNull { get => default; } // 0x00000001841C04C0-0x00000001841C04D0 
		public bool IsDouble { get => default; } // 0x000000018BE7BC9C-0x000000018BE7BCE8 
		public bool IsInt64 { get => default; } // 0x000000018BE7BCE8-0x000000018BE7BD34 
		public bool IsBool { get => default; } // 0x000000018BE7BC0C-0x000000018BE7BC58 
		public bool IsString { get => default; } // 0x000000018BE7BD78-0x000000018BE7BDC4 
		public bool IsDictionary { get => default; } // 0x000000018BE7BC58-0x000000018BE7BC9C 
		public bool IsList { get => default; } // 0x000000018BE7BD34-0x000000018BE7BD78 
		public double AsDouble { get => default; } // 0x000000018BE7BB1C-0x000000018BE7BB58 
		public long AsInt64 { get => default; } // 0x000000018BE7BB58-0x000000018BE7BB94 
		public bool AsBool { get => default; } // 0x000000018BE7BAA4-0x000000018BE7BAE0 
		public string AsString { get => default; } // 0x000000018BE7BBD0-0x000000018BE7BC0C 
		public Dictionary<string, fsData> AsDictionary { get => default; } // 0x000000018BE7BAE0-0x000000018BE7BB1C 
		public List<fsData> AsList { get => default; } // 0x000000018BE7BB94-0x000000018BE7BBD0 
	
		// Constructors
		public fsData() {} // 0x0000000185633D30-0x0000000185633D50
		public fsData(bool boolean) {} // 0x000000018BE7B990-0x000000018BE7B9EC
		public fsData(double f) {} // 0x000000018BE7B9EC-0x000000018BE7BA48
		public fsData(long i) {} // 0x000000018BE7BA48-0x000000018BE7BAA4
		public fsData(string str) {} // 0x0000000184096E30-0x0000000184096EF0
		public fsData(Dictionary<string, fsData> dict) {} // 0x0000000184096E30-0x0000000184096EF0
		public fsData(List<fsData> list) {} // 0x0000000184096E30-0x0000000184096EF0
		static fsData() {} // 0x000000018BE7B884-0x000000018BE7B990
	
		// Methods
		public override string ToString() => default; // 0x000000018BE7B87C-0x000000018BE7B884
		public static fsData CreateDictionary() => default; // 0x000000018BE7AFE0-0x000000018BE7B0D4
		public static fsData CreateList(int capacity) => default; // 0x000000018BE7B0D4-0x000000018BE7B170
		internal void BecomeDictionary() {} // 0x000000018BE7AEFC-0x000000018BE7AF74
		internal fsData Clone() => default; // 0x000000018BE7AF74-0x000000018BE7AFE0
		private T Cast<T>() => default;
		public override bool Equals(object obj) => default; // 0x000000018BE7B170-0x000000018BE7B1D4
		public bool Equals(fsData other) => default; // 0x000000018BE7B1D4-0x000000018BE7B87C
		public static bool operator ==(fsData a, fsData b) => default; // 0x000000018BE7BF20-0x000000018BE7BFF0
		public static bool operator !=(fsData a, fsData b) => default; // 0x000000018BE7BFF0-0x000000018BE7C044
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 56662
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {} // 0x0000000185492010-0x0000000185492020
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 56663
	{
		// Properties
		public override System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {}
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		}
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default;
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref ref TModel model);
	}

	public sealed class fsMissingVersionConstructorException : Exception // TypeDefIndex: 56664
	{
		// Constructors
		public fsMissingVersionConstructorException() {} // Dummy constructor
		public fsMissingVersionConstructorException(System.Type versionedType, System.Type constructorType) {} // 0x000000018BE85B2C-0x000000018BE85BF8
	}

	public sealed class fsDuplicateVersionNameException : Exception // TypeDefIndex: 56665
	{
		// Constructors
		public fsDuplicateVersionNameException() {} // Dummy constructor
		public fsDuplicateVersionNameException(System.Type typeA, System.Type typeB, string version) {} // 0x000000018BE7DBC8-0x000000018BE7DD2C
	}

	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 56666
	{
		// Constructors
		public fsIgnoreAttribute() {} // Dummy constructor
	}

	public interface fsISerializationCallbacks // TypeDefIndex: 56667
	{
		// Methods
		void OnBeforeSerialize(System.Type storageType);
		void OnAfterSerialize(System.Type storageType, ref fsData data);
		void OnBeforeDeserialize(System.Type storageType, ref fsData data);
		void OnAfterDeserialize(System.Type storageType);
	}

	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 56668
	{
		// Constructors
		public fsSerializationCallbackProcessor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE88524-0x000000018BE8859C
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x000000018BE88824-0x000000018BE888A0
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x000000018BE88618-0x000000018BE886A8
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x000000018BE886A8-0x000000018BE88824
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x000000018BE8859C-0x000000018BE88618
	}

	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 56669
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018BE888A0-0x000000018BE88918
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x000000018BE8899C-0x000000018BE88A20
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x000000018BE88918-0x000000018BE8899C
	}

	public class fsJsonParser // TypeDefIndex: 56670
	{
		// Fields
		private readonly StringBuilder _cachedStringBuilder; // 0x10
		private int _start; // 0x18
		private string _input; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x000000018BE81EC4-0x000000018BE81F50
	
		// Methods
		private fsResult MakeFailure(string message) => default; // 0x000000018BE800CC-0x000000018BE80258
		private bool TryMoveNext() => default; // 0x000000018BE808D4-0x000000018BE80900
		private bool HasValue() => default; // 0x000000018BE80030-0x000000018BE8003C
		private bool HasValue(int offset) => default; // 0x000000018BE8003C-0x000000018BE80070
		private char Character() => default; // 0x000000018BE7FFF8-0x000000018BE80004
		private char Character(int offset) => default; // 0x000000018BE80004-0x000000018BE80030
		private void SkipSpace() {} // 0x000000018BE806F8-0x000000018BE808D4
		private fsResult TryParseExact(string content) => default; // 0x000000018BE80BB8-0x000000018BE80CFC
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE818CC-0x000000018BE819CC
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE80CFC-0x000000018BE80DFC
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE80DFC-0x000000018BE80EF8
		private bool IsSeparator(char c) => default; // 0x000000018BE80070-0x000000018BE800CC
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE80EF8-0x000000018BE8120C
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x000000018BE81614-0x000000018BE818CC
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x000000018BE80900-0x000000018BE80BB8
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x000000018BE8120C-0x000000018BE81614
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE803B4-0x000000018BE806F8
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE802CC-0x000000018BE803B4
		public static fsData Parse(string input) => default; // 0x000000018BE80258-0x000000018BE802CC
		private bool IsHex(char c) => default; // 0x000000018B4D80BC-0x000000018B4D80E4
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x000000018B4D82CC-0x000000018B4D8310
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x000000018B4D8310-0x000000018B4D8394
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x000000018BE819CC-0x000000018BE81EC4
	}

	public static class fsJsonPrinter // TypeDefIndex: 56671
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x000000018BE831C0-0x000000018BE8322C
		private static string EscapeString(string str) => default; // 0x000000018BE82F00-0x000000018BE831C0
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x000000018BE81F50-0x000000018BE82528
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x000000018BE82528-0x000000018BE82C68
		public static string PrettyJson(fsData data) => default; // 0x000000018BE8322C-0x000000018BE8338C
		public static string CompressedJson(fsData data) => default; // 0x000000018BE82C68-0x000000018BE82DC4
		private static string ConvertDoubleToString(double d) => default; // 0x000000018BE82DC4-0x000000018BE82F00
	}

	public enum fsMemberSerialization // TypeDefIndex: 56672
	{
		OptIn = 0,
		OptOut = 1,
		Default = 2
	}

	public class fsObjectAttribute : Attribute // TypeDefIndex: 56673
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute() {} // 0x0000000185FBD740-0x0000000185FBD750
		public fsObjectAttribute(string versionString, System.Type[] previousModels) {} // 0x000000018BE85D94-0x000000018BE85DC4
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 56674
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public virtual bool CanProcess(System.Type type) => default; // 0x000000018BE85DC4-0x000000018BE85E10
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000185492010-0x0000000185492020
	}

	public class fsPropertyAttribute : Attribute // TypeDefIndex: 56675
	{
		// Fields
		public string Name; // 0x10
		public System.Type Converter; // 0x18
	
		// Constructors
		public fsPropertyAttribute() {} // Dummy constructor
		public fsPropertyAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public struct fsResult // TypeDefIndex: 56676
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get => default; } // 0x000000018A1D97C0-0x000000018A1D97C8 
		public bool Succeeded { get => default; } // 0x00000001835E3010-0x00000001835E3020 
		public bool HasWarnings { get => default; } // 0x000000018BE88408-0x000000018BE88454 
		public Exception AsException { get => default; } // 0x000000018BE88210-0x000000018BE88328 
		public IEnumerable<string> RawMessages { get => default; } // 0x000000018BE88454-0x000000018BE884AC 
		public string FormattedMessages { get => default; } // 0x000000018BE88328-0x000000018BE88408 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x000000018BE88170-0x000000018BE88210
	
		// Methods
		public void AddMessage(string message) {} // 0x000000018BE87D3C-0x000000018BE87DEC
		public void AddMessages(fsResult result) {} // 0x000000018BE87DEC-0x000000018BE87EA4
		public fsResult Merge(fsResult other) => default; // 0x000000018BE87FDC-0x000000018BE880C0
		public static fsResult Warn(string warning) => default; // 0x000000018BE880C0-0x000000018BE88170
		public static fsResult Fail(string warning) => default; // 0x000000018BE87F30-0x000000018BE87FDC
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x000000018BE884AC-0x000000018BE88524
		public fsResult AssertSuccess() => default; // 0x000000018BE87EA4-0x000000018BE87F30
	}

	public class fsSerializer // TypeDefIndex: 56678
	{
		// Fields
		private readonly List<fsConverter> _availableConverters; // 0x10
		private readonly Dictionary<System.Type, fsDirectConverter> _availableDirectConverters; // 0x18
		private readonly List<fsObjectProcessor> _processors; // 0x20
		private readonly fsCyclicReferenceManager _references; // 0x28
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x30
		private readonly Dictionary<System.Type, System.Type> _abstractTypeRemap; // 0x38
		private Dictionary<System.Type, fsBaseConverter> _cachedConverterTypeInstances; // 0x40
		private Dictionary<System.Type, fsBaseConverter> _cachedConverters; // 0x48
		private Dictionary<System.Type, List<fsObjectProcessor>> _cachedProcessors; // 0x50
		public fsContext Context; // 0x58
		public fsConfig Config; // 0x60
		private static HashSet<string> _reservedKeywords; // 0x00
		private static readonly string Key_ObjectReference; // 0x08
		private static readonly string Key_ObjectDefinition; // 0x10
		private static readonly string Key_InstanceType; // 0x18
		private static readonly string Key_Version; // 0x20
		private static readonly string Key_Content; // 0x28
		internal static readonly string Key_UnitDefault; // 0x30
		internal static readonly string Key_UnitPosition; // 0x38
		internal static readonly string Key_UnitGuid; // 0x40
		internal static readonly string Key_UnitFormerType; // 0x48
		internal static readonly string Key_UnitFormerValue; // 0x50
		internal static readonly string TypeName_Unit; // 0x58
		private static readonly System.Type Type_Unit; // 0x60
		internal static readonly string TypeName_MissingType; // 0x68
		private static readonly System.Type Type_MissingType; // 0x70
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 56677
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x000000018BE8A268-0x000000018BE8A4C4
	
			// Methods
			public void WriteDefinition(int id, fsData data) {} // 0x000000018BE8D254-0x000000018BE8DCAC
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x000000018BE8C300-0x000000018BE8C490
			public void Clear() {} // 0x000000018BE8C490-0x000000018BE8C58C
		}
	
		// Constructors
		public fsSerializer() {} // 0x000000018BE88A20-0x000000018BE88CA4
		static fsSerializer() {} // 0x000000018BE8BFE0-0x000000018BE8C078
	
		// Methods
		private void RemapAbstractStorageTypeToDefaultType(ref System.Type storageType) {} // 0x000000018BE8907C-0x000000018BE8946C
		public void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType) {}
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default;
		public void AddConverter(fsBaseConverter converter) {} // 0x000000018BE8CCC8-0x000000018BE8CD08
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) => default; // 0x000000018BE8C92C-0x000000018BE8CCC8
		public fsResult TrySerialize<T>(T instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8B194-0x000000018BE8B550
		public fsResult TryDeserialize<T>(fsData data, ref ref T instance) => default; // 0x000000018BE8B550-0x000000018BE8B7E8
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8B7E8-0x000000018BE8B9F8
		public fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8B9F8-0x000000018BE8BAB0
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8C8F0-0x000000018BE8C92C
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8C58C-0x000000018BE8C8F0
		private fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8A4C4-0x000000018BE8A678
		private fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x000000018BE8A678-0x000000018BE8AAEC
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x000000018BE8AAEC-0x000000018BE8AF24
		public fsResult TryDeserialize(fsData data, System.Type storageType, System.Type overrideConverterType, ref object result) => default; // 0x000000018BE8AF24-0x000000018BE8B064
		private fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x000000018BE8B064-0x000000018BE8B194
		private fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x000000018BE8946C-0x000000018BE8A268
		private fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x000000018BE88FC8-0x000000018BE8907C
		private fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x000000018BE8CD08-0x000000018BE8D254
		private fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x000000018BE8BED8-0x000000018BE8BF48
		private static System.Type GetDataType(ref fsData data, System.Type defaultType, ref fsResult deserializeResult) => default; // 0x000000018BE8BE40-0x000000018BE8BED8
		private static void EnsureDictionary(fsData data) {} // 0x000000018BE8BDA8-0x000000018BE8BE40
		public static bool IsReservedKeyword(string key) => default; // 0x000000018BE8BF48-0x000000018BE8BFE0
		private static bool IsObjectReference(fsData data) => default; // 0x000000018BE8C268-0x000000018BE8C300
		private static bool IsObjectDefinition(fsData data) => default; // 0x000000018BE8C078-0x000000018BE8C268
		private static bool IsVersioned(fsData data) => default; // 0x000000018BE88CA4-0x000000018BE88FC8
		private static bool IsTypeSpecified(fsData data) => default; // 0x000000018BE8BD0C-0x000000018BE8BDA8
		private static bool IsWrappedData(fsData data) => default; // 0x000000018BE8BB48-0x000000018BE8BBF4
		private static bool IsVisualScriptingUnit(fsData data) => default; // 0x000000018BE8BCA0-0x000000018BE8BD0C
		private static void ConvertLegacyData(ref fsData data) {} // 0x000000018BE8BBF4-0x000000018BE8BCA0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x000000018BE8BAB0-0x000000018BE8BB48
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x000000018BE83B4C-0x000000018BE83C9C
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x000000018BE83C9C-0x000000018BE83EB0
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x000000018BE83AE4-0x000000018BE83B4C
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x000000018BE83EB0-0x000000018BE83F70
	}

	public class fsMetaProperty // TypeDefIndex: 56679
	{
		// Fields
		internal MemberInfo _memberInfo; // 0x10
		private System.Type _StorageType_k__BackingField; // 0x18
		private System.Type _OverrideConverterType_k__BackingField; // 0x20
		private bool _CanRead_k__BackingField; // 0x28
		private bool _CanWrite_k__BackingField; // 0x29
		private string _JsonName_k__BackingField; // 0x30
		private string _MemberName_k__BackingField; // 0x38
		private bool _IsPublic_k__BackingField; // 0x40
		private bool _IsReadOnly_k__BackingField; // 0x41
	
		// Properties
		public System.Type StorageType { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
		public System.Type OverrideConverterType { get; private set; } // 0x00000001813B31A0-0x00000001813B31B0 0x000000018646EE40-0x000000018646EE50
		public bool CanRead { get; private set; } // 0x00000001813B31B0-0x00000001813B31C0 0x00000001813B4840-0x00000001813B4850
		public bool CanWrite { get; private set; } // 0x00000001813B34D0-0x00000001813B34E0 0x00000001813B4850-0x00000001813B4860
		public string JsonName { get; private set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public string MemberName { get; private set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public bool IsPublic { get; private set; } // 0x0000000185FB0650-0x0000000185FB0660 0x0000000185FB0660-0x0000000185FB0670
		public bool IsReadOnly { get; private set; } // 0x0000000185FB0D70-0x0000000185FB0D80 0x0000000185FB0D90-0x0000000185FB0DA0
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(fsConfig config, System.Reflection.FieldInfo field) {} // 0x000000018BE84428-0x000000018BE844CC
		internal fsMetaProperty(fsConfig config, PropertyInfo property) {} // 0x000000018BE84308-0x000000018BE84428
	
		// Methods
		private void CommonInitialize(fsConfig config) {} // 0x000000018BE83F70-0x000000018BE84048
		public void Write(object context, object value) {} // 0x000000018BE84110-0x000000018BE84308
		public object Read(object context) => default; // 0x000000018BE84048-0x000000018BE84110
	}

	public class fsMetaType // TypeDefIndex: 56683
	{
		// Fields
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x19
		private bool _isDefaultConstructorPublic; // 0x1B
		private fsMetaProperty[] _Properties_k__BackingField; // 0x20
		private static Dictionary<fsConfig, Dictionary<System.Type, fsMetaType>> _configMetaTypes; // 0x00
	
		// Properties
		public fsMetaProperty[] Properties { get; private set; } // 0x000000018BE846AC-0x000000018BE84980 0x000000018BE844CC-0x000000018BE846AC
		public bool HasDefaultConstructor { get => default; } // 0x000000018BE85854-0x000000018BE858E0 
	
		// Nested types
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 56680
		{
			// Fields
			public MemberInfo member; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0() {} // 0x000000018BE858E0-0x000000018BE859C0
	
			// Methods
			internal bool _CollectProperties_b__0(System.Type t) => default; // 0x00000001813B31A0-0x00000001813B31B0
			internal bool _CollectProperties_b__1(System.Type t) => default; // 0x000000018646EE40-0x000000018646EE50
			internal bool _CollectProperties_b__2(System.Type t) => default; // 0x000000018BE859C0-0x000000018BE85B2C
		}
	
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 56681
		{
			// Fields
			public PropertyInfo property; // 0x10
	
			// Constructors
			public __c__DisplayClass18_0() {} // 0x000000018BE85314-0x000000018BE853EC
	
			// Methods
			internal bool _CanSerializeProperty_b__0(System.Type t) => default; // 0x000000018BE84E08-0x000000018BE85314
		}
	
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 56682
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0() {} // 0x000000018BE853EC-0x000000018BE8578C
	
			// Methods
			internal bool _CanSerializeField_b__0(System.Type t) => default; // 0x000000018BE84980-0x000000018BE84E08
		}
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(fsConfig config, System.Type reflectedType) {} // 0x000000018BE8578C-0x000000018BE85854
		static fsMetaType() {} // 0x000000018BE78CCC-0x000000018BE78D20
	
		// Methods
		public bool EmitAotData() => default; // 0x0000000185492010-0x0000000185492020
		public object CreateInstance() => default; // 0x000000018BE78B7C-0x000000018BE78BD0
		public static fsMetaType Get(fsConfig config, System.Type type) => default; // 0x000000018BE78BD0-0x000000018BE78C24
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x000000018BE78C24-0x000000018BE78C78
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members) => default; // 0x0000000185492010-0x0000000185492020
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue) => default; // 0x000000018BE78C78-0x000000018BE78CCC
		private static bool CanSerializeField(fsConfig config, System.Reflection.FieldInfo field, bool annotationFreeValue) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class fsReflectionUtility // TypeDefIndex: 56684
	{
		// Methods
		public static System.Type GetInterface(System.Type type, System.Type interfaceType) => default; // 0x000000018BE87B74-0x000000018BE87D3C
	}
}

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 56686
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 56685
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x000000018BE7AB60-0x000000018BE7AC68
			static ObjectReferenceEqualityComparator() {} // 0x000000018BE7A8F0-0x000000018BE7A954
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000185FCA7D0-0x0000000185FCA7E0
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x000000018BE7A954-0x000000018BE7AAB8
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x000000018BE789C8-0x000000018BE78A2C
	
		// Methods
		public void Enter() {} // 0x000000018BE7AAB8-0x000000018BE7AB60
		public bool Exit() => default; // 0x000000018BE7AC68-0x000000018BE7ACD8
		public object GetReferenceObject(int id) => default; // 0x000000018BE7ACD8-0x000000018BE7AE08
		public void AddReferenceWithId(int id, object reference) {} // 0x000000018BE7AE08-0x000000018BE7AEFC
		public int GetReferenceId(object item) => default; // 0x0000000188F44660-0x0000000188F44668
		public bool IsReference(object item) => default; // 0x0000000185FCF280-0x0000000185FCF290
		public void MarkSerialized(object item) {} // 0x0000000185492010-0x0000000185492020
	}

	public struct fsOption<T> // TypeDefIndex: 56687
	{
		// Fields
		private bool _hasValue;
		private T _value;
	
		// Properties
		public bool HasValue { get => default; }
		public bool IsEmpty { get => default; }
		public T Value { get => default; }
	
		// Constructors
		public fsOption(T value) : this() {
			_hasValue = default;
			_value = default;
		}
	}

	public static class fsOption // TypeDefIndex: 56688
	{
		// Methods
		public static fsOption<T> Just<T>(T value) => default;
	}

	public static class fsPortableReflection // TypeDefIndex: 56691
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static System.Reflection.BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 56689
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 56690
		{
			// Constructors
			public AttributeQueryComparator() {} // 0x000000018BE85E10-0x000000018BE85F78
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y) => default; // 0x000000018BE864B8-0x000000018BE8650C
			public int GetHashCode(AttributeQuery obj) => default; // 0x000000018647217C-0x0000000186472188
		}
	
		// Constructors
		static fsPortableReflection() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static bool HasAttribute(MemberInfo element, System.Type attributeType) => default;
		public static bool HasAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default;
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default; // 0x000000018BE86304-0x000000018BE863B8
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute => default; // 0x000000018BE86198-0x000000018BE8624C
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute => default; // 0x000000018BE85F78-0x000000018BE8607C
		public static PropertyInfo GetDeclaredProperty(System.Type type, string propertyName) => default; // 0x000000018BE8607C-0x000000018BE860E0
		public static MethodInfo GetDeclaredMethod(System.Type type, string methodName) => default; // 0x000000018BE863B8-0x000000018BE864B8
		public static ConstructorInfo GetDeclaredConstructor(System.Type type, System.Type[] parameters) => default; // 0x000000018BE8624C-0x000000018BE862A8
		public static ConstructorInfo[] GetDeclaredConstructors(System.Type type) => default; // 0x000000018BE862A8-0x000000018BE86304
		public static MethodInfo GetFlattenedMethod(System.Type type, string methodName) => default; // 0x000000018BE860E0-0x000000018BE8613C
		public static MethodInfo[] GetDeclaredMethods(System.Type type) => default; // 0x000000018BE8613C-0x000000018BE86198
		public static PropertyInfo[] GetDeclaredProperties(System.Type type) => default; // 0x0000000185779060-0x0000000185779070
		public static System.Reflection.FieldInfo[] GetDeclaredFields(System.Type type) => default; // 0x000000018BE8650C-0x000000018BE86620
		public static MemberInfo[] GetDeclaredMembers(System.Type type) => default; // 0x000000018BE78918-0x000000018BE7897C
		public static System.Type Resolve(System.Type type) => default; // 0x000000018BE7897C-0x000000018BE789C8
	}

	public static class fsTypeExtensions // TypeDefIndex: 56693
	{
		// Nested types
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 56692
		{
			// Fields
			public bool includeNamespace; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0() {} // 0x000000018BE8E4F4-0x000000018BE8E500
	
			// Methods
			internal string _CSharpName_b__0(System.Type t) => default; // 0x000000018BE8DF98-0x000000018BE8E4F4
		}
	
		// Methods
		public static string CSharpName(System.Type type) => default; // 0x0000000185492010-0x0000000185492020
		public static string CSharpName(System.Type type, bool includeNamespace) => default; // 0x000000018BE78D20-0x000000018BE78D34
	}

	public struct fsVersionedType // TypeDefIndex: 56694
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public System.Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance) => default; // 0x000000018BE8F1DC-0x000000018BE8F268
		public override string ToString() => default; // 0x000000018BE8F268-0x000000018BE8F3A8
		public override bool Equals(object obj) => default; // 0x000000018BE8F160-0x000000018BE8F1DC
		public override int GetHashCode() => default; // 0x00000001891011C8-0x00000001891011EC
	}

	public static class fsVersionManager // TypeDefIndex: 56695
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager() {} // 0x000000018BE8F0D4-0x000000018BE8F160
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path) {
			path = default;
			return default;
		} // 0x000000018BE8E628-0x000000018BE8E860
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current) => default; // 0x000000018BE8E500-0x000000018BE8E628
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type) => default; // 0x000000018BE8E860-0x000000018BE8ECE4
		private static void VerifyConstructors(fsVersionedType type) {} // 0x000000018BE8ECE4-0x000000018BE8EE6C
		private static void VerifyUniqueVersionStrings(fsVersionedType type) {} // 0x000000018BE8EE6C-0x000000018BE8F0D4
	}
}
