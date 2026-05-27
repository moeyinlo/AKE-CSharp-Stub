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
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using JetBrains.Annotations;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using Unity.VisualScripting.FullSerializer.Internal;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Image 39: Unity.VisualScripting.Core.dll - Assembly: Unity.VisualScripting.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 55363-55622

namespace Unity.VisualScripting
{
	public abstract class Cloner<T> : ICloner // TypeDefIndex: 55364
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

	public sealed class AnimationCurveCloner : Cloner<AnimationCurve> // TypeDefIndex: 55365
	{
		// Constructors
		public AnimationCurveCloner() {} // 0x000000018369C000-0x000000018369C030
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D4659C-0x0000000189D46600
		public override AnimationCurve ConstructClone(System.Type type, AnimationCurve original) => default; // 0x0000000189D4648C-0x0000000189D464DC
		public override void FillClone(System.Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context) {} // 0x0000000189D464DC-0x0000000189D4659C
	}

	public sealed class ArrayCloner : Cloner<Array> // TypeDefIndex: 55366
	{
		// Constructors
		public ArrayCloner() {} // 0x000000018369BFD0-0x000000018369C000
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x00000001893BF984-0x00000001893BF9A4
		public override Array ConstructClone(System.Type type, Array original) => default; // 0x0000000189D467B4-0x0000000189D467E0
		public override void FillClone(System.Type type, ref Array clone, Array original, CloningContext context) {} // 0x0000000189D467E0-0x0000000189D468D0
	}

	public sealed class DictionaryCloner : Cloner<IDictionary> // TypeDefIndex: 55367
	{
		// Constructors
		public DictionaryCloner() {} // 0x000000018369BFA0-0x000000018369BFD0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D4B190-0x0000000189D4B208
		public override void FillClone(System.Type type, ref IDictionary clone, IDictionary original, CloningContext context) {} // 0x0000000189D4B0A4-0x0000000189D4B190
	}

	public sealed class EnumerableCloner : Cloner<IEnumerable> // TypeDefIndex: 55368
	{
		// Fields
		private readonly Dictionary<System.Type, IOptimizedInvoker> addMethods; // 0x10
	
		// Constructors
		public EnumerableCloner() {} // 0x000000018369C0A0-0x000000018369C130
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D4BA0C-0x0000000189D4BAF0
		public override void FillClone(System.Type type, ref IEnumerable clone, IEnumerable original, CloningContext context) {} // 0x0000000189D4B5F8-0x0000000189D4B810
		private IOptimizedInvoker GetAddMethod(System.Type type) => default; // 0x0000000189D4B810-0x0000000189D4BA0C
	}

	public sealed class FakeSerializationCloner : ReflectedCloner // TypeDefIndex: 55370
	{
		// Properties
		public fsConfig config { get; } // 0x0000000189D4C77C-0x0000000189D4C8BC 
	
		// Constructors
		public FakeSerializationCloner() {} // 0x00000001859311D0-0x00000001859311E8
	
		// Methods
		public override void BeforeClone(System.Type type, object original) {} // 0x000000018369C030-0x000000018369C0A0
		public override void AfterClone(System.Type type, object clone) {} // 0x0000000189D60060-0x0000000189D600C4
		protected override IEnumerable<MemberInfo> GetMembers(System.Type type) => default; // 0x000000018350B670-0x000000018350B680
	}

	public sealed class FieldsCloner : ReflectedCloner // TypeDefIndex: 55371
	{
		// Constructors
		public FieldsCloner() {} // 0x0000000184276944-0x000000018427694C
	
		// Methods
		protected override bool IncludeField(System.Reflection.FieldInfo field) => default; // 0x000000018232EB60-0x000000018232EB70
		protected override bool IncludeProperty(PropertyInfo property) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	internal sealed class GradientCloner : Cloner<Gradient> // TypeDefIndex: 55372
	{
		// Constructors
		public GradientCloner() {} // 0x000000018369BF70-0x000000018369BFA0
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D4C98C-0x0000000189D4C9F0
		public override Gradient ConstructClone(System.Type type, Gradient original) => default; // 0x0000000189D4C8BC-0x0000000189D4C90C
		public override void FillClone(System.Type type, ref Gradient clone, Gradient original, CloningContext context) {} // 0x0000000189D4C90C-0x0000000189D4C98C
	}

	public sealed class ListCloner : Cloner<IList> // TypeDefIndex: 55373
	{
		// Constructors
		public ListCloner() {} // 0x000000018369BF40-0x000000018369BF70
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D50384-0x0000000189D503FC
		public override void FillClone(System.Type type, ref IList clone, IList original, CloningContext context) {} // 0x0000000189D501E0-0x0000000189D50384
	}

	public abstract class ReflectedCloner : Cloner<object> // TypeDefIndex: 55374
	{
		// Fields
		private readonly Dictionary<System.Type, MemberInfo[]> accessors; // 0x10
		private readonly Dictionary<System.Type, IOptimizedAccessor[]> optimizedAccessors; // 0x18
	
		// Constructors
		protected ReflectedCloner() {} // 0x000000018369C130-0x000000018369C200
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x000000018115F4C0-0x000000018115F530
		public override void FillClone(System.Type type, ref object clone, object original, CloningContext context) {} // 0x0000000189D55C8C-0x0000000189D5600C
		private MemberInfo[] GetAccessors(System.Type type) => default; // 0x0000000189D5600C-0x0000000189D560E8
		private IOptimizedAccessor[] GetOptimizedAccessors(System.Type type) => default; // 0x0000000189D5629C-0x0000000189D565CC
		protected virtual IEnumerable<MemberInfo> GetMembers(System.Type type) => default; // 0x0000000189D560E8-0x0000000189D5629C
		protected virtual bool IncludeField(System.Reflection.FieldInfo field) => default; // 0x000000018115F4C0-0x000000018115F530
		protected virtual bool IncludeProperty(PropertyInfo property) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public static class Cloning // TypeDefIndex: 55376
	{
		// Fields
		private static readonly Dictionary<System.Type, bool> skippable; // 0x00
	
		// Properties
		public static HashSet<ICloner> cloners { get; } // 0x0000000189D47454-0x0000000189D474A4 
		public static ArrayCloner arrayCloner { get; } // 0x0000000189D474A4-0x0000000189D474F4 
		public static DictionaryCloner dictionaryCloner { get; } // 0x0000000189D47594-0x0000000189D475E4 
		public static EnumerableCloner enumerableCloner { get; } // 0x0000000189D47364-0x0000000189D473B4 
		public static ListCloner listCloner { get; } // 0x0000000189D47544-0x0000000189D47594 
		public static AnimationCurveCloner animationCurveCloner { get; } // 0x0000000189D474F4-0x0000000189D47544 
		internal static GradientCloner gradientCloner { get; } // 0x00000001826CC300-0x00000001826CC3F0 
		public static FakeSerializationCloner fakeSerializationCloner { get; } // 0x00000001826CC260-0x00000001826CC300 
	
		// Constructors
		static Cloning() {} // 0x0000000189D473B4-0x0000000189D47404
	
		// Methods
		internal static object Clone(CloningContext context, object original) => default; // 0x00000001826CB440-0x00000001826CB580
		internal static void CloneInto(CloningContext context, ref object clone, object original) {} // 0x00000001826CB3A0-0x00000001826CB440
		[CanBeNull]
		public static ICloner GetCloner(object original, System.Type type) => default; // 0x00000001826CBFD0-0x00000001826CC1E0
		private static ICloner GetCloner(object original, System.Type type, ICloner fallbackCloner) => default; // 0x000000018350B670-0x000000018350B680
		private static bool Skippable(System.Type type) => default; // 0x0000000189D5FD80-0x0000000189D5FDA4
	
		// Extension methods
		public static object Clone(this object original, ICloner fallbackCloner, bool tryPreserveInstances) => default;
		public static object CloneViaFakeSerialization(this object original) => default; // 0x00000001826CC3F0-0x00000001826CC460
		public static T CloneViaFakeSerialization<T>(this T original) => default; // 0x00000001826CB0F0-0x00000001826CB3A0
	}

	public sealed class CloningContext : IPoolable, IDisposable // TypeDefIndex: 55378
	{
		// Fields
		private bool disposed; // 0x21
	
		// Properties
		public Dictionary<object, object> clonings { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
		public ICloner fallbackCloner { get; private set; } // 0x0000000183D4EFC0-0x0000000183D4EFD0 0x0000000183D85820-0x0000000183D85830
		public bool tryPreserveInstances { get; private set; } // 0x0000000182EA6BD0-0x0000000182EA6C20 0x0000000183CC4530-0x0000000183CC45A0
	
		// Constructors
		public CloningContext() {} // 0x00000001826CC6A0-0x00000001826CC6F0
	
		// Methods
		void IPoolable.New() {} // 0x00000001826CC460-0x00000001826CC5E0
		void IPoolable.Free() {} // 0x00000001826CC5E0-0x00000001826CC6A0
		public void Dispose() {} // 0x0000000183D13010-0x0000000183D13070
		public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances) => default; // 0x000000018350B670-0x000000018350B680
	}

	public interface ICloner // TypeDefIndex: 55379
	{
		// Methods
		bool Handles(System.Type type);
		object ConstructClone(System.Type type, object original);
		void BeforeClone(System.Type type, object original);
		void FillClone(System.Type type, ref object clone, object original, CloningContext context);
		void AfterClone(System.Type type, object clone);
	}

	public interface ISpecifiesCloner // TypeDefIndex: 55380
	{
		// Properties
		ICloner cloner { get; }
	}

	public sealed class AotDictionary : OrderedDictionary // TypeDefIndex: 55381
	{
		// Constructors
		public AotDictionary() {} // 0x0000000189A1C394-0x0000000189A1C3A8
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs() {} // 0x0000000189D46600-0x0000000189D466A8
	}

	public sealed class AotList : ArrayList // TypeDefIndex: 55382
	{
		// Constructors
		public AotList() {} // 0x00000001899BB530-0x00000001899BB538
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs() {} // 0x0000000189D466A8-0x0000000189D46760
	}

	public class GuidCollection<T> : KeyedCollection<Guid, T>, ICollection<T> // TypeDefIndex: 55383
		where T : IIdentifiable
	{
		// Constructors
		public GuidCollection() {} // Dummy constructor
	
		// Methods
		protected override Guid GetKeyForItem(T item) => default;
	}

	public interface IKeyedCollection<TKey, TItem> : ICollection<TItem> // TypeDefIndex: 55384
	{
		// Properties
		TItem this[TKey key] { get => default; }
		TItem this[int index] { get => default; }
	
		// Methods
		bool Contains(TKey key);
	}

	[DefaultMember("Item")]
	public class MergedKeyedCollection<TKey, TItem> : IEnumerable<TItem> // TypeDefIndex: 55386
	{
		// Fields
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collections;
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsLookup;
	
		// Nested types
		public struct Enumerator : IEnumerator<TItem> // TypeDefIndex: 55385
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
		protected IKeyedCollection<TKey, TItem> GetCollectionForType(System.Type type, bool throwOnFail = true /* Metadata: 0x01FD6F79 */) => default;
		public virtual void Add(TItem item) {}
		public void Clear() {}
		public bool Contains(TItem item) => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator() => default;
		public Enumerator GetEnumerator() => default;
	}

	public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> // TypeDefIndex: 55387
		where TConnection : IConnection<TSource, TDestination>
	{
		// Constructors
		public ConnectionCollection() {}
	}

	[DefaultMember("Item")]
	public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination> // TypeDefIndex: 55388
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

	public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, ICollection<TConnection> // TypeDefIndex: 55389
		where TConnection : IConnection<TSource, TDestination>, IGraphElement
	{
		// Constructors
		public GraphConnectionCollection() {} // Dummy constructor
	}

	public interface IConnection<out TSource, out TDestination> // TypeDefIndex: 55390
	{
		// Properties
		TSource source { get; }
		TDestination destination { get; }
	}

	[DefaultMember("Item")]
	public interface IConnectionCollection<TConnection, TSource, TDestination> : ICollection<TConnection> // TypeDefIndex: 55391
		where TConnection : IConnection<TSource, TDestination>
	{
	}

	public class InvalidConnectionException : Exception // TypeDefIndex: 55392
	{
		// Constructors
		public InvalidConnectionException() {} // 0x0000000189D4FCF8-0x0000000189D4FD4C
		public InvalidConnectionException(string message) {} // 0x0000000189D4FD4C-0x0000000189D4FDA8
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ValueAttribute : Attribute // TypeDefIndex: 55393
	{
		// Constructors
		public ValueAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DisableAnnotationAttribute : Attribute // TypeDefIndex: 55394
	{
		// Constructors
		public DisableAnnotationAttribute() {} // 0x0000000181168960-0x0000000181168970
	}

	public static class EditorTimeBinding // TypeDefIndex: 55396
	{
		// Fields
		public static Func<int> frameBinding; // 0x00
		public static Func<float> timeBinding; // 0x08
	
		// Properties
		public static int frame { get; } // 0x000000018350B670-0x000000018350B680 
		public static float time { get; } // 0x0000000189D5F9F4-0x0000000189D5F9FC 
	
		// Constructors
		static EditorTimeBinding() {} // 0x0000000189D5F9FC-0x0000000189D5FA04
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public sealed class IncludeInSettingsAttribute : Attribute // TypeDefIndex: 55397
	{
		// Properties
		private bool include { get; set; } // 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public IncludeInSettingsAttribute() {} // Dummy constructor
		public IncludeInSettingsAttribute(bool include) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class InspectableAttribute : Attribute // TypeDefIndex: 55398
	{
		// Constructors
		public InspectableAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorWideAttribute : Attribute // TypeDefIndex: 55399
	{
		// Properties
		private bool toEdge { get; set; } // 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public InspectorWideAttribute() {} // Dummy constructor
		public InspectorWideAttribute(bool toEdge) {} // 0x0000000183D4E960-0x0000000183D4E970
	}

	public static class Ensure // TypeDefIndex: 55400
	{
		// Fields
		private static readonly EnsureThat instance; // 0x00
	
		// Properties
		public static bool IsActive { get; set; } // 0x0000000189D4B554-0x0000000189D4B5A4 0x0000000189D4B5A4-0x0000000189D4B5F8
	
		// Constructors
		static Ensure() {} // 0x0000000183D00180-0x0000000183D001F0
	
		// Methods
		public static EnsureThat That(string paramName) => default; // 0x000000018316E450-0x000000018316E4D0
		internal static void OnRuntimeMethodLoad() {} // 0x0000000183170130-0x0000000183170200
	}

	public class EnsureThat // TypeDefIndex: 55401
	{
		// Fields
		internal string paramName; // 0x10
	
		// Constructors
		public EnsureThat() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void IsNotNull<T>([NoEnumeration] T value) {}
		public void IsNotNull(string value) {} // 0x0000000189D4B48C-0x0000000189D4B554
		public void IsOfType<T>(T param, System.Type expectedType) {}
	}

	public static class ExceptionMessages // TypeDefIndex: 55402
	{
		// Properties
		public static string Common_IsNotNull_Failed { get; } // 0x0000000189D4C31C-0x0000000189D4C36C 
		public static string Types_IsOfType_Failed { get; } // 0x0000000189D4C36C-0x0000000189D4C3C0 
	
		// Constructors
		static ExceptionMessages() {} // 0x0000000189D4BAF0-0x0000000189D4C31C
	}

	internal static class XString // TypeDefIndex: 55404
	{
		// Extension methods
		internal static string Inject(this string format, params string[] formattingArgs) => default; // 0x0000000183D51810-0x0000000183D51820
	}

	public struct EmptyEventArgs // TypeDefIndex: 55405
	{
	}

	public class InvalidConversionException : InvalidCastException // TypeDefIndex: 55406
	{
		// Constructors
		public InvalidConversionException() {} // 0x0000000189D4FDA8-0x0000000189D4FDB0
		public InvalidConversionException(string message) {} // 0x000000018924D8A4-0x000000018924D8C4
		public InvalidConversionException(string message, Exception innerException) {} // 0x0000000189D4FDB0-0x0000000189D4FDB8
	}

	public class InvalidImplementationException : Exception // TypeDefIndex: 55407
	{
		// Constructors
		public InvalidImplementationException() {} // Dummy constructor
		public InvalidImplementationException(string message) {} // 0x0000000189D4FDB8-0x0000000189D4FE14
	}

	public class UnexpectedEnumValueException<T> : Exception // TypeDefIndex: 55408
	{
		// Properties
		private T Value { get; set; }
	
		// Constructors
		public UnexpectedEnumValueException() {} // Dummy constructor
		public UnexpectedEnumValueException(T value) {}
	}

	public abstract class Graph : IGraph // TypeDefIndex: 55410
	{
		// Fields
		[SerializeAs("elements")]
		private List<IGraphElement> _elements; // 0x10
	
		// Properties
		[DoNotSerialize]
		public MergedGraphElementCollection elements { get; } // 0x0000000189D4F1F4-0x0000000189D4F6DC 
		public IEnumerable<ISerializationDependency> deserializationDependencies { get; } // 0x0000000189D4F0A8-0x0000000189D4F1F4 
	
		// Constructors
		protected Graph() {} // Dummy constructor
	
		// Methods
		public virtual void OnBeforeSerialize() {} // 0x0000000189D5FF34-0x0000000189D5FF98
		public void OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterDependenciesDeserialized() {} // 0x0000000189D5FB0C-0x0000000189D5FB28
		public virtual void Dispose() {} // 0x0000000189D5F820-0x0000000189D5F864
	}

	public abstract class GraphElement<TGraph> : IGraphElement // TypeDefIndex: 55411
		where TGraph : class, IGraph
	{
		// Properties
		[Serialize]
		public Guid guid { get; }
		[DoNotSerialize]
		public virtual int dependencyOrder { get; }
		[DoNotSerialize]
		public TGraph graph { get; }
		public virtual IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Constructors
		protected GraphElement() {}
	
		// Methods
		public virtual void Dispose() {}
		public virtual bool HandleDependencies() => default;
		public override string ToString() => default;
	}

	public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IKeyedCollection<Guid, TElement> // TypeDefIndex: 55412
		where TElement : IGraphElement
	{
		// Properties
		TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.this[Guid key] { get => default; }
	
		// Constructors
		public GraphElementCollection() {} // Dummy constructor
	
		// Methods
		bool IKeyedCollection<Guid, TElement>.Contains(Guid key) => default;
	}

	public abstract class GraphPointer // TypeDefIndex: 55413
	{
		// Fields
		protected readonly List<IGraphParent> parentStack; // 0x20
		protected readonly List<IGraphParentElement> parentElementStack; // 0x28
		protected readonly List<IGraph> graphStack; // 0x30
		protected readonly List<IGraphData> dataStack; // 0x38
		protected readonly List<IGraphDebugData> debugDataStack; // 0x40
	
		// Properties
		public IGraphRoot root { get; protected set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public UnityEngine.Object rootObject { get; } // 0x0000000189D4DFC8-0x0000000189D4E004 
		public GameObject gameObject { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public GameObject self { get; } // 0x0000000181041090-0x00000001810410A0 
		public UnityEngine.Object serializedObject { get; } // 0x0000000189D4E004-0x0000000189D4E108 
		public int depth { get; } // 0x0000000189D4DB30-0x0000000189D4DB70 
		public bool isRoot { get; } // 0x0000000189D4DBA0-0x0000000189D4DBB8 
		public bool isChild { get; } // 0x0000000189D4DB88-0x0000000189D4DBA0 
		public IGraphParent parent { get; } // 0x0000000189D4DF24-0x0000000189D4DF80 
		public IGraphParentElement parentElement { get; } // 0x0000000189D4DEC0-0x0000000189D4DF24 
		public IGraph rootGraph { get; } // 0x0000000189D4DF80-0x0000000189D4DFC8 
		public bool hasDebugData { get; } // 0x0000000189D4DB70-0x0000000189D4DB88 
		protected IGraphDebugData _debugData { get; } // 0x0000000189D4DAB4-0x0000000189D4DB10 
		public IGraphDebugData debugData { get; } // 0x0000000189D4DB10-0x0000000189D4DB30 
		public bool isValid { get; } // 0x0000000189D4DBB8-0x0000000189D4DEC0 
	
		// Constructors
		internal GraphPointer() {} // 0x0000000189D4D910-0x0000000189D4DAB4
	
		// Methods
		public abstract GraphReference AsReference();
		public virtual void CopyFrom(GraphPointer other) {} // 0x0000000189D4CBD8-0x0000000189D4D310
		public void EnsureChild() {} // 0x0000000189D4D3F8-0x0000000189D4D474
		public void EnsureDebugDataAvailable() {} // 0x0000000189D4D474-0x0000000189D4D4F0
		public T GetElementDebugData<T>(IGraphElementWithDebugData element) => default;
		protected void ExitParentElement() {} // 0x0000000189D4D4F0-0x0000000189D4D698
		public bool InstanceEquals(GraphPointer other) => default; // 0x0000000189D4D698-0x0000000189D4D798
		public bool DefinitionEquals(GraphPointer other) => default; // 0x0000000189D4D310-0x0000000189D4D3F8
		public int ComputeHashCode() => default; // 0x0000000189D4CAB4-0x0000000189D4CBD8
		public override string ToString() => default; // 0x0000000189D4D798-0x0000000189D4D910
	}

	public sealed class GraphPointerException : Exception // TypeDefIndex: 55414
	{
		// Constructors
		public GraphPointerException() {} // Dummy constructor
		public GraphPointerException(string message, GraphPointer pointer) {} // 0x0000000189D4C9F0-0x0000000189D4CAB4
	}

	public sealed class GraphReference : GraphPointer // TypeDefIndex: 55415
	{
		// Fields
		[DoNotSerialize]
		private int hashCode; // 0x48
		private static readonly Dictionary<int, List<GraphReference>> internPool; // 0x00
	
		// Constructors
		static GraphReference() {} // 0x0000000189D4ED18-0x0000000189D4EDF0
		private GraphReference() {} // 0x0000000189D4EDF0-0x0000000189D4EDF8
	
		// Methods
		private static GraphReference New(GraphPointer model) => default; // 0x0000000189D4EBF8-0x0000000189D4EC60
		public override void CopyFrom(GraphPointer other) {} // 0x0000000189D4E154-0x0000000189D4E1BC
		public GraphReference Clone() => default; // 0x0000000189D4E108-0x0000000189D4E154
		public override GraphReference AsReference() => default; // 0x000000018339AE90-0x000000018339AEA0
		public GraphStack ToStackPooled() => default; // 0x0000000189D4ED10-0x0000000189D4ED18
		public override bool Equals(object obj) => default; // 0x0000000189D4E1BC-0x0000000189D4E218
		private void Hash() {} // 0x0000000189D4E828-0x0000000189D4E844
		public override int GetHashCode() => default; // 0x0000000183D4EC50-0x0000000183D4EC60
		public GraphReference ParentReference(bool ensureValid) => default; // 0x0000000189D4EC60-0x0000000189D4ED10
		public static GraphReference Intern(GraphPointer pointer) => default; // 0x0000000189D4E844-0x0000000189D4EBF8
		public static void FreeInvalidInterns() {} // 0x0000000189D4E218-0x0000000189D4E828
	}

	public static class GraphsExceptionUtility // TypeDefIndex: 55416
	{
		// Extension methods
		public static void SetException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) {} // 0x0000000189D4FC2C-0x0000000189D4FCF8
		public static void HandleException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex) {} // 0x0000000189D4F89C-0x0000000189D4FA68
		private static bool HandledIn(this Exception ex, GraphReference reference) => default; // 0x0000000189D4FA68-0x0000000189D4FC2C
	}

	public sealed class GraphStack : GraphPointer, IPoolable, IDisposable // TypeDefIndex: 55418
	{
		// Constructors
		private GraphStack() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal static GraphStack New(GraphPointer model) => default; // 0x0000000189D4EFD0-0x0000000189D4F0A8
		public void Dispose() {} // 0x0000000189D4EDF8-0x0000000189D4EE00
		void IPoolable.New() {} // 0x0000000189D4EF84-0x0000000189D4EFD0
		void IPoolable.Free() {} // 0x0000000189D5FED0-0x0000000189D5FF34
		public override GraphReference AsReference() => default; // 0x000000018350B670-0x000000018350B680
		public GraphReference ToReference() => default; // 0x0000000189D5F7D0-0x0000000189D5F820
	}

	public interface IGraph : IDisposable, ISerializationDepender // TypeDefIndex: 55419
	{
		// Properties
		MergedGraphElementCollection elements { get; }
	}

	public interface IGraphData // TypeDefIndex: 55420
	{
	}

	public interface IGraphDebugData // TypeDefIndex: 55421
	{
		// Methods
		IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element);
	}

	public interface IGraphElement : IDisposable, IIdentifiable // TypeDefIndex: 55422
	{
		// Properties
		int dependencyOrder { get; }
		Guid guid { get; }
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		bool HandleDependencies();
	}

	public interface IGraphElementDebugData // TypeDefIndex: 55423
	{
		// Properties
		Exception runtimeException { get; set; }
	}

	public interface IGraphElementWithDebugData : IGraphElement // TypeDefIndex: 55424
	{
	}

	public interface IGraphParent // TypeDefIndex: 55425
	{
		// Properties
		IGraph childGraph { get; }
		bool isSerializationRoot { get; }
		UnityEngine.Object serializedObject { get; }
	}

	public interface IGraphParentElement : IGraphElement, IGraphParent // TypeDefIndex: 55426
	{
	}

	public interface IGraphRoot : IGraphParent // TypeDefIndex: 55427
	{
	}

	public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement> // TypeDefIndex: 55428
	{
		// Constructors
		public MergedGraphElementCollection() {} // Dummy constructor
	}

	public static class PlatformUtility // TypeDefIndex: 55429
	{
		// Fields
		public static readonly bool supportsJit; // 0x00
	
		// Constructors
		static PlatformUtility() {} // 0x0000000183D43E60-0x0000000183D43EA0
	
		// Methods
		private static bool CheckJitSupport() => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public static class GenericPool<T> // TypeDefIndex: 55430
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

	public interface IPoolable // TypeDefIndex: 55431
	{
		// Methods
		void New();
		void Free();
	}

	public static class ListPool<T> // TypeDefIndex: 55432
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

	public static class XListPool // TypeDefIndex: 55433
	{
		// Extension methods
		public static void Free<T>(this List<T> list) {}
	}

	public class ProfiledSegment // TypeDefIndex: 55434
	{
		// Properties
		public string name { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		private Stopwatch stopwatch { get; set; } // 0x00000001822C3A90-0x00000001822C3AA0
		private ProfiledSegment parent { get; set; } // 0x0000000184271930-0x0000000184271940
		private ProfiledSegmentCollection children { get; set; } // 0x0000000182C92F10-0x0000000182C92F20
	
		// Constructors
		public ProfiledSegment() {} // Dummy constructor
		public ProfiledSegment(ProfiledSegment parent, string name) {} // 0x0000000189D550D4-0x0000000189D5518C
	}

	public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment> // TypeDefIndex: 55435
	{
		// Constructors
		public ProfiledSegmentCollection() {} // 0x0000000189D55098-0x0000000189D550D4
	
		// Methods
		protected override string GetKeyForItem(ProfiledSegment item) => default; // 0x00000001859311D0-0x00000001859311E8
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 55436
	{
		// Constructors
		public ProfilingScope(string name) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class ProfilingUtility // TypeDefIndex: 55437
	{
		// Fields
		private static readonly object @lock; // 0x00
	
		// Properties
		private static ProfiledSegment rootSegment { get; set; } // 0x0000000189D55344-0x0000000189D553A4
		public static ProfiledSegment currentSegment { get; set; } // 0x0000000189D552E4-0x0000000189D55344
	
		// Constructors
		static ProfilingUtility() {} // 0x0000000189D5518C-0x0000000189D552E4
	
		// Methods
		public static ProfilingScope SampleBlock(string name) => default; // 0x000000018115F4C0-0x000000018115F530
	}

	public enum ActionDirection // TypeDefIndex: 55438
	{
		Any = 0,
		Get = 1,
		Set = 2
	}

	public static class AttributeUtility // TypeDefIndex: 55440
	{
		// Fields
		private static readonly Dictionary<object, AttributeCache> optimizedCaches; // 0x00
	
		// Nested types
		private class AttributeCache // TypeDefIndex: 55439
		{
			// Properties
			public List<Attribute> inheritedAttributes { get; } // 0x0000000189D46FB4-0x0000000189D472D8 
			public List<Attribute> definedAttributes { get; }
	
			// Constructors
			public AttributeCache() {} // Dummy constructor
			public AttributeCache(MemberInfo element) {}
	
			// Methods
			private void Cache(Attribute[] attributeObjects, List<Attribute> cache) {}
			private bool HasAttribute(System.Type attributeType, List<Attribute> cache) => default; // 0x0000000189D472D8-0x0000000189D47364
			private Attribute GetAttribute(System.Type attributeType, List<Attribute> cache) => default; // 0x00000001820B7B20-0x00000001820B7B30
			public bool HasAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x01FD6F7F */) => default; // 0x0000000181041090-0x00000001810410A0
			public Attribute GetAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x01FD6F80 */) => default; // 0x0000000189D46ABC-0x0000000189D46FB4
			public bool HasAttribute<TAttribute>(bool inherit = true /* Metadata: 0x01FD6F81 */)
				where TAttribute : Attribute => default; // 0x0000000189D468D0-0x0000000189D4694C
			public TAttribute GetAttribute<TAttribute>(bool inherit = true /* Metadata: 0x01FD6F82 */)
				where TAttribute : Attribute => default; // 0x0000000189D46A28-0x0000000189D46ABC
		}
	
		// Constructors
		static AttributeUtility() {}
	
		// Methods
		private static AttributeCache GetAttributeCache(MemberInfo element) => default; // 0x0000000189D46968-0x0000000189D46A0C
	
		// Extension methods
		internal static IEnumerable<T> GetAttributeOfEnumMember<T>(this Enum enumVal)
			where T : Attribute => default; // 0x0000000189D46A0C-0x0000000189D46A28
		public static bool HasAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x01FD6F7D */)
			where TAttribute : Attribute => default; // 0x0000000189D4694C-0x0000000189D46968
		public static TAttribute GetAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x01FD6F7E */)
			where TAttribute : Attribute => default;
	}

	public static class ConversionUtility // TypeDefIndex: 55447
	{
		// Fields
		private static readonly Dictionary<ConversionQuery, ConversionType> conversionTypesCache; // 0x00
		private static readonly Dictionary<ConversionQuery, MethodInfo[]> userConversionMethodsCache; // 0x08
		private static readonly Dictionary<System.Type, HashSet<System.Type>> implicitNumericConversions; // 0x10
		private static readonly Dictionary<System.Type, HashSet<System.Type>> explicitNumericConversions; // 0x18
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 55441
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
	
		private struct ConversionQuery : IEquatable<ConversionQuery> // TypeDefIndex: 55442
		{
			// Fields
			public readonly System.Type source; // 0x00
			public readonly System.Type destination; // 0x08
	
			// Constructors
			public ConversionQuery(System.Type source, System.Type destination) {
				this.source = default;
				this.destination = default;
			} // 0x0000000189D492A0-0x0000000189D492F4
	
			// Methods
			public bool Equals(ConversionQuery other) => default; // 0x000000018973DA98-0x000000018973DAB8
			public override bool Equals(object obj) => default; // 0x0000000189697CCC-0x0000000189697CF0
			public override int GetHashCode() => default; // 0x0000000189D48EF4-0x0000000189D48FD8
		}
	
		private struct ConversionQueryComparer : IEqualityComparer<ConversionQuery> // TypeDefIndex: 55443
		{
			// Methods
			public bool Equals(ConversionQuery x, ConversionQuery y) => default; // 0x0000000189D48E10-0x0000000189D48EF4
			public int GetHashCode(ConversionQuery obj) => default; // 0x0000000189D48FD8-0x0000000189D4904C
		}
	
		// Constructors
		static ConversionUtility() {} // 0x0000000189D5FCC0-0x0000000189D5FD3C
	
		// Methods
		private static bool RespectsIdentity(System.Type source, System.Type destination) => default; // 0x0000000189D491D0-0x0000000189D49230
		private static bool IsUpcast(System.Type source, System.Type destination) => default; // 0x0000000189D49170-0x0000000189D491D0
		private static bool IsDowncast(System.Type source, System.Type destination) => default; // 0x0000000189D48624-0x0000000189D48750
		public static bool HasImplicitNumericConversion(System.Type source, System.Type destination) => default; // 0x0000000189D47DB0-0x0000000189D47FF0
		public static bool HasExplicitNumericConversion(System.Type source, System.Type destination) => default; // 0x0000000189D4855C-0x0000000189D48624
		public static bool HasNumericConversion(System.Type source, System.Type destination) => default; // 0x0000000189D49244-0x0000000189D492A0
		private static IEnumerable<MethodInfo> FindUserDefinedConversionMethods(ConversionQuery query) => default; // 0x0000000189D494E4-0x0000000189D49698
		private static MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination) => default; // 0x0000000189D47FF0-0x0000000189D48128
		private static ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination) => default; // 0x0000000189D48128-0x0000000189D482B4
		private static bool HasEnumerableToArrayConversion(System.Type source, System.Type destination) => default; // 0x0000000189D492F4-0x0000000189D494E4
		private static bool HasEnumerableToListConversion(System.Type source, System.Type destination) => default; // 0x0000000189D479BC-0x0000000189D47DB0
		private static bool HasUnityHierarchyConversion(System.Type source, System.Type destination) => default; // 0x0000000189D49698-0x0000000189D4B0A4
		private static bool IsValidConversion(ConversionType conversionType, bool guaranteed) => default; // 0x00000001832C7BF0-0x00000001832C7C20
		public static bool CanConvert(object value, System.Type type, bool guaranteed) => default; // 0x0000000189D47760-0x0000000189D477D0
		public static bool CanConvert(System.Type source, System.Type destination, bool guaranteed) => default; // 0x0000000189D477D0-0x0000000189D47840
		public static object Convert(object value, System.Type type) => default; // 0x0000000189D47840-0x0000000189D47880
		public static ConversionType GetRequiredConversion(System.Type source, System.Type destination) => default; // 0x000000018350B670-0x000000018350B680
		private static ConversionType DetermineConversionType(ConversionQuery query) => default; // 0x0000000189D5FB28-0x0000000189D5FBD0
		public static ConversionType GetRequiredConversion(object value, System.Type type) => default; // 0x0000000189D6018C-0x0000000189D601F0
		private static object NumericConversion(object value, System.Type type) => default; // 0x000000018350B670-0x000000018350B680
		private static object UserDefinedConversion(ConversionType conversion, object value, System.Type type) => default; // 0x0000000189D5F6A8-0x0000000189D5F6F4
		private static object EnumerableToArrayConversion(object value, System.Type arrayType) => default; // 0x0000000189D5F6F4-0x0000000189D5F740
		private static object EnumerableToListConversion(object value, System.Type listType) => default; // 0x000000018350B670-0x000000018350B680
		private static object UnityHierarchyConversion(object value, System.Type type) => default; // 0x0000000189D5FBD0-0x0000000189D5FC44
		private static object Convert(object value, System.Type type, ConversionType conversionType) => default; // 0x0000000189D5FC44-0x0000000189D5FCC0
	
		// Extension methods
		public static bool IsConvertibleTo(this System.Type source, System.Type destination, bool guaranteed) => default; // 0x0000000189D47728-0x0000000189D4774C
		public static bool IsConvertibleTo(this object source, System.Type type, bool guaranteed) => default; // 0x0000000189D4774C-0x0000000189D47760
	}

	public struct LooseAssemblyName // TypeDefIndex: 55448
	{
		// Fields
		public readonly string name; // 0x00
	
		// Constructors
		public LooseAssemblyName(string name) {
			this.name = default;
		} // 0x0000000189D50720-0x0000000189D5078C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189D50680-0x0000000189D506E4
		public override int GetHashCode() => default; // 0x0000000189D506E4-0x0000000189D50720
		public override string ToString() => default; // 0x00000001820C61B0-0x00000001820C61C0
	}

	public static class MemberUtility // TypeDefIndex: 55450
	{
		// Fields
		private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache; // 0x00
		private static readonly Lazy<Dictionary<System.Type, MethodInfo[]>> InheritedExtensionMethodsCache; // 0x08
		private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods; // 0x10
	
		// Constructors
		static MemberUtility() {} // 0x0000000189D50C00-0x0000000189D50C38
	
		// Extension methods
		public static bool IsUserDefinedConversion(this MethodInfo method) => default; // 0x0000000189D5FDA4-0x0000000189D5FE08
		public static bool IsExtension(this MethodInfo methodInfo) => default; // 0x000000018350B670-0x000000018350B680
		public static bool IsStatic(this PropertyInfo propertyInfo) => default; // 0x0000000189D5F8E4-0x0000000189D5F934
		public static bool IsStatic(this MemberInfo memberInfo) => default; // 0x0000000189D5F934-0x0000000189D5F994
		public static bool CanWrite(this System.Reflection.FieldInfo fieldInfo) => default; // 0x0000000189D5F994-0x0000000189D5F9F4
	}

	internal class ExtensionMethodCache // TypeDefIndex: 55452
	{
		// Fields
		internal readonly MethodInfo[] Cache; // 0x10
	
		// Constructors
		internal ExtensionMethodCache() {} // 0x0000000189D5FA98-0x0000000189D5FAE4
	}

	public sealed class Namespace // TypeDefIndex: 55454
	{
		// Fields
		private static readonly Collection collection; // 0x00
	
		// Properties
		public string FullName { get; } // 0x0000000189D51498-0x0000000189D5158C 
		public static Namespace Global { get; } // 0x0000000188597150-0x0000000188597168 
	
		// Nested types
		private class Collection : KeyedCollection<string, Namespace>, IKeyedCollection<string, Namespace> // TypeDefIndex: 55453
		{
			// Properties
			Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.this[string key] { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
			// Constructors
			public Collection() {} // 0x0000000189D5158C-0x0000000189D515B4
	
			// Methods
			protected override string GetKeyForItem(Namespace item) => default; // 0x0000000189D5167C-0x0000000189D517C0
			public new bool TryGetValue(string key, out Namespace value) {
				value = default;
				return default;
			} // 0x0000000183D4EB40-0x0000000183D4EB50
			bool IKeyedCollection<string, Namespace>.Contains(string key) => default; // 0x0000000189D515B4-0x0000000189D5167C
		}
	
		// Constructors
		public Namespace() {} // Dummy constructor
		private Namespace(string fullName) {} // 0x0000000189D517C0-0x0000000189D51810
		static Namespace() {} // 0x00000001891C7168-0x00000001891C7190
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189D5140C-0x0000000189D51498
		public override string ToString() => default; // 0x0000000189D51810-0x0000000189D5185C
		public static Namespace FromFullName(string fullName) => default; // 0x0000000189D475E4-0x0000000189D4765C
		public override bool Equals(object obj) => default; // 0x0000000189D476EC-0x0000000189D47728
		public static implicit operator Namespace(string fullName) => default; // 0x0000000189D476A4-0x0000000189D476EC
		public static bool operator ==(Namespace a, Namespace b) => default; // 0x0000000189D4765C-0x0000000189D476A4
	}

	public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 55455; 0x00000000-0x00000000

	public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 55456; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 55457; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 55458; 0x00000000-0x00000000

	public abstract class InstanceActionInvokerBase<TTarget> : InstanceInvokerBase<TTarget> // TypeDefIndex: 55459
	{
		// Constructors
		protected InstanceActionInvokerBase() {} // Dummy constructor
		protected InstanceActionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class InstanceActionInvoker<TTarget> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55460
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

	public sealed class InstanceActionInvoker<TTarget, TParam0> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55461
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

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55462
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

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55463
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

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55464
	{
		// Fields
		private Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 55465
	{
		// Fields
		private Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public InstanceActionInvoker() {} // Dummy constructor
		public InstanceActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor // TypeDefIndex: 55466
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
	}

	public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget> // TypeDefIndex: 55467
	{
		// Constructors
		protected InstanceFunctionInvokerBase() {} // Dummy constructor
		protected InstanceFunctionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55468
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

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55469
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

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55470
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

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55471
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

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55472
	{
		// Fields
		private Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 55473
	{
		// Fields
		private Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker() {} // Dummy constructor
		public InstanceFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public abstract class InstanceInvokerBase<TTarget> : InvokerBase // TypeDefIndex: 55474
	{
		// Constructors
		protected InstanceInvokerBase() {} // Dummy constructor
		protected InstanceInvokerBase(MethodInfo methodInfo) {}
	
		// Methods
		protected sealed override void CompileExpression() {}
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target) {}
	}

	public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor // TypeDefIndex: 55475
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

	public abstract class InvokerBase : IOptimizedInvoker // TypeDefIndex: 55476
	{
		// Fields
		protected readonly System.Type targetType; // 0x10
		protected readonly MethodInfo methodInfo; // 0x18
	
		// Constructors
		protected InvokerBase() {} // Dummy constructor
		protected InvokerBase(MethodInfo methodInfo) {} // 0x0000000189D50110-0x0000000189D501E0
	
		// Methods
		protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg) {}
		public void Compile() {} // 0x0000000189D4FE14-0x0000000189D4FE64
		protected ParameterExpression[] GetParameterExpressions() => default; // 0x0000000189D4FE64-0x0000000189D500C4
		protected abstract System.Type[] GetParameterTypes();
		public virtual object Invoke(object target, object arg0) => default; // 0x0000000189D500C4-0x0000000189D50110
		protected abstract void CompileExpression();
		protected abstract void CreateDelegate();
		protected abstract void VerifyTarget(object target);
	}

	public interface IOptimizedAccessor // TypeDefIndex: 55477
	{
		// Methods
		void Compile();
		object GetValue(object target);
		void SetValue(object target, object value);
	}

	public interface IOptimizedInvoker // TypeDefIndex: 55478
	{
		// Methods
		void Compile();
		object Invoke(object target, object arg0);
	}

	public static class OptimizedReflection // TypeDefIndex: 55480
	{
		// Fields
		private static readonly Dictionary<System.Reflection.FieldInfo, IOptimizedAccessor> fieldAccessors; // 0x00
		private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors; // 0x08
		private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers; // 0x10
		public static readonly bool jitAvailable; // 0x18
		private static bool _useJitIfAvailable; // 0x19
	
		// Properties
		internal static bool useJit { get; } // 0x0000000189D55044-0x0000000189D55098 
		public static bool useJitIfAvailable { get; } // 0x0000000183170200-0x00000001831702D0 
		public static bool safeMode { get; set; } // 0x0000000189D54CB8-0x0000000189D54D0C 
	
		// Constructors
		static OptimizedReflection() {} // 0x0000000189D54F1C-0x0000000189D54F6C
	
		// Methods
		internal static void OnRuntimeMethodLoad() {} // 0x0000000189D54D0C-0x0000000189D54F1C
		internal static void VerifyStaticTarget(System.Type targetType, object target) {} // 0x0000000189D549EC-0x0000000189D54A64
		internal static void VerifyInstanceTarget<TTArget>(object target) {} // 0x0000000189D54820-0x0000000189D5486C
		private static void VerifyTarget(System.Type targetType, object target, bool @static) {} // 0x0000000189D54904-0x0000000189D54978
		private static bool SupportsOptimization(MemberInfo memberInfo) => default; // 0x0000000189D54C70-0x0000000189D54CB8
		private static IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo) => default; // 0x0000000189D54C28-0x0000000189D54C70
		private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo) => default; // 0x0000000189D54A64-0x0000000189D54C28
		private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo) => default; // 0x0000000189D5F8BC-0x0000000189D5F8E4
	
		// Extension methods
		public static IOptimizedAccessor Prewarm(this System.Reflection.FieldInfo fieldInfo) => default; // 0x0000000189D5185C-0x0000000189D51DAC
		public static void SetValueOptimized(this System.Reflection.FieldInfo fieldInfo, object target, object value) {} // 0x0000000189D5486C-0x0000000189D548B8
		public static bool SupportsOptimization(this System.Reflection.FieldInfo fieldInfo) => default; // 0x0000000189D54978-0x0000000189D549EC
		public static IOptimizedAccessor Prewarm(this PropertyInfo propertyInfo) => default; // 0x0000000189D54234-0x0000000189D547AC
		public static void SetValueOptimized(this PropertyInfo propertyInfo, object target, object value) {} // 0x0000000189D548B8-0x0000000189D54904
		public static bool SupportsOptimization(this PropertyInfo propertyInfo) => default; // 0x0000000189D547AC-0x0000000189D54820
		public static IOptimizedInvoker Prewarm(this MethodInfo methodInfo) => default; // 0x0000000189D51DAC-0x0000000189D54234
		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0) => default; // 0x0000000189D60128-0x0000000189D6018C
		public static bool SupportsOptimization(this MethodInfo methodInfo) => default; // 0x000000018350B670-0x000000018350B680
	}

	public sealed class ReflectionFieldAccessor : IOptimizedAccessor // TypeDefIndex: 55481
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo; // 0x10
	
		// Constructors
		public ReflectionFieldAccessor() {} // Dummy constructor
		public ReflectionFieldAccessor(System.Reflection.FieldInfo fieldInfo) {} // 0x0000000189D565CC-0x0000000189D56680
	
		// Methods
		public void Compile() {} // 0x000000018350B670-0x000000018350B680
		public object GetValue(object target) => default; // 0x000000018781FB74-0x000000018781FB98
		public void SetValue(object target, object value) {} // 0x0000000186876BD8-0x0000000186876BF8
	}

	public class ReflectionInvoker : IOptimizedInvoker // TypeDefIndex: 55482
	{
		// Fields
		private readonly MethodInfo methodInfo; // 0x10
		private static readonly object[] EmptyObjects; // 0x00
	
		// Constructors
		public ReflectionInvoker() {} // Dummy constructor
		public ReflectionInvoker(MethodInfo methodInfo) {} // 0x0000000189D56784-0x0000000189D56838
		static ReflectionInvoker() {} // 0x0000000189D56720-0x0000000189D56784
	
		// Methods
		public void Compile() {} // 0x000000018350B670-0x000000018350B680
		public object Invoke(object target, object arg0) => default; // 0x0000000189D56680-0x0000000189D56720
	}

	public sealed class ReflectionPropertyAccessor : IOptimizedAccessor // TypeDefIndex: 55483
	{
		// Fields
		private readonly PropertyInfo propertyInfo; // 0x10
	
		// Constructors
		public ReflectionPropertyAccessor() {} // Dummy constructor
		public ReflectionPropertyAccessor(PropertyInfo propertyInfo) {} // 0x0000000189D56838-0x0000000189D568EC
	
		// Methods
		public void Compile() {} // 0x000000018350B670-0x000000018350B680
		public object GetValue(object target) => default; // 0x000000018781D108-0x000000018781D12C
		public void SetValue(object target, object value) {} // 0x0000000187E47268-0x0000000187E47290
	}

	public abstract class StaticActionInvokerBase : StaticInvokerBase // TypeDefIndex: 55484
	{
		// Constructors
		protected StaticActionInvokerBase() {} // Dummy constructor
		protected StaticActionInvokerBase(MethodInfo methodInfo) {} // 0x0000000187D28B34-0x0000000187D28B3C
	}

	public sealed class StaticActionInvoker : StaticActionInvokerBase // TypeDefIndex: 55485
	{
		// Fields
		private Action invoke; // 0x20
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {} // 0x0000000187D28B34-0x0000000187D28B3C
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default; // 0x0000000189D5BDF8-0x0000000189D5BE48
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {} // 0x0000000189D5BCDC-0x0000000189D5BD7C
		protected override void CreateDelegate() {} // 0x0000000189D5BD7C-0x0000000189D5BDF8
	}

	public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase // TypeDefIndex: 55486
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
	}

	public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase // TypeDefIndex: 55487
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
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase // TypeDefIndex: 55488
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
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase // TypeDefIndex: 55489
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
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase // TypeDefIndex: 55490
	{
		// Fields
		private Unity.VisualScripting.Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public StaticActionInvoker() {} // Dummy constructor
		public StaticActionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public class StaticFieldAccessor<TField> : IOptimizedAccessor // TypeDefIndex: 55492
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TField> getter;
		private Action<TField> setter;
		private System.Type targetType;
	
		// Constructors
		public StaticFieldAccessor() {} // Dummy constructor
		public StaticFieldAccessor(System.Reflection.FieldInfo fieldInfo) {}
	
		// Methods
		public void Compile() {}
		public object GetValue(object target) => default;
		private object GetValueUnsafe(object target) => default;
		public void SetValue(object target, object value) {}
		private void SetValueUnsafe(object target, object value) {}
	}

	public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase // TypeDefIndex: 55493
	{
		// Constructors
		protected StaticFunctionInvokerBase() {} // Dummy constructor
		protected StaticFunctionInvokerBase(MethodInfo methodInfo) {}
	}

	public sealed class StaticFunctionInvoker<TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55494
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
	}

	public sealed class StaticFunctionInvoker<TParam0, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55495
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
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55496
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
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55497
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
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55498
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
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 55499
	{
		// Fields
		private Unity.VisualScripting.Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker() {} // Dummy constructor
		public StaticFunctionInvoker(MethodInfo methodInfo) {}
	
		// Methods
		protected override System.Type[] GetParameterTypes() => default;
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions) {}
		protected override void CreateDelegate() {}
	}

	public abstract class StaticInvokerBase : InvokerBase // TypeDefIndex: 55500
	{
		// Constructors
		protected StaticInvokerBase() {} // Dummy constructor
		protected StaticInvokerBase(MethodInfo methodInfo) {} // 0x0000000189D5BFBC-0x0000000189D5C090
	
		// Methods
		protected sealed override void CompileExpression() {} // 0x0000000189D5BEF0-0x0000000189D5BF68
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target) {} // 0x0000000189D5BF68-0x0000000189D5BFBC
	}

	public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor // TypeDefIndex: 55501
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

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedAssemblyAttribute : Attribute // TypeDefIndex: 55502
	{
		// Properties
		public string previousName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string newName { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public RenamedAssemblyAttribute() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class RenamedFromAttribute : Attribute // TypeDefIndex: 55503
	{
		// Properties
		public string previousName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public RenamedFromAttribute() {} // Dummy constructor
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedNamespaceAttribute : Attribute // TypeDefIndex: 55504
	{
		// Properties
		public string previousName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public string newName { get; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public RenamedNamespaceAttribute() {} // Dummy constructor
		public RenamedNamespaceAttribute(string previousName, string newName) {} // 0x0000000182676770-0x00000001826767A0
	}

	public static class RuntimeCodebase // TypeDefIndex: 55507
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
		public static IEnumerable<System.Type> types { get; } // 0x0000000189D57CB8-0x0000000189D5818C 
		public static IEnumerable<Assembly> assemblies { get; } // 0x0000000189D59124-0x0000000189D591C0 
		public static Dictionary<string, string> renamedNamespaces { get; } // 0x0000000189D5EF4C-0x0000000189D5EF98 
		public static Dictionary<string, string> renamedAssemblies { get; } // 0x0000000181041090-0x00000001810410A0 
		public static Dictionary<string, System.Type> renamedTypes { get; } // 0x0000000189D5EEA0-0x0000000189D5EF44 
	
		// Constructors
		static RuntimeCodebase() {} // 0x0000000189D59088-0x0000000189D59124
	
		// Methods
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType) => default; // 0x0000000189D591C0-0x0000000189D5925C
		[IteratorStateMachine(typeof(_GetAssemblyAttributes_d__15))]
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType, IEnumerable<Assembly> assemblies) => default; // 0x0000000189D56D50-0x0000000189D570C8
		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>()
			where TAttribute : Attribute => default; // 0x0000000189D569D8-0x0000000189D56D50
		public static string SerializeType(System.Type type) => default; // 0x0000000189D570C8-0x0000000189D578EC
		public static bool TryDeserializeType(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x00000001825D6DC0-0x00000001825D6DE0
		public static System.Type DeserializeType(string typeName) => default; // 0x0000000189D5EF98-0x0000000189D5F084
		private static bool TryCachedTypeLookup(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000189D5E9BC-0x0000000189D5EEA0
		private static bool TrySystemTypeLookup(string typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000189D5F084-0x0000000189D5F0CC
		private static bool TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000189D5F0CC-0x0000000189D5F118
		private static bool TryRenamedTypeLookup(string previousTypeName, out System.Type type) {
			type = default;
			return default;
		} // 0x0000000181041090-0x00000001810410A0
		private static Dictionary<string, string> FetchRenamedNamespaces() => default; // 0x0000000189D5EF44-0x0000000189D5EF4C
		private static Dictionary<string, string> FetchRenamedAssemblies() => default; // 0x000000018350B670-0x000000018350B680
		private static Dictionary<string, System.Type> FetchRenamedTypes() => default; // 0x0000000189D5FD3C-0x0000000189D5FD80
	}

	public class TypeName // TypeDefIndex: 55510
	{
		// Fields
		private readonly List<string> names; // 0x40
		private readonly List<int> genericarities; // 0x48
	
		// Properties
		public string AssemblyDescription { get; private set; } // 0x00000001822C3A90-0x00000001822C3AA0 0x0000000184271930-0x0000000184271940
		public string AssemblyName { get; private set; } // 0x0000000182C92F10-0x0000000182C92F20 0x0000000184270470-0x0000000184270480
		private string AssemblyVersion { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0
		private string AssemblyCulture { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00
		private string AssemblyPublicKeyToken { get; set; } // 0x0000000182C926C0-0x0000000182C926D0
		public List<TypeName> GenericParameters { get; } // 0x0000000189D5DCD0-0x0000000189D5DD1C 
		public string Name { get; private set; } // 0x0000000189D5C418-0x0000000189D5C484 0x0000000189D5D338-0x0000000189D5DCD0
		public bool IsArray { get => default; } // 0x0000000189D5C330-0x0000000189D5C418 
	
		// Nested types
		private enum ParseState // TypeDefIndex: 55508
		{
			Name = 0,
			Array = 1,
			Generics = 2,
			Assembly = 3
		}
	
		// Constructors
		public TypeName() {} // Dummy constructor
		private TypeName(string s, ref int index) {} // 0x0000000189D5C484-0x0000000189D5C68C
	
		// Methods
		public static TypeName Parse(string s) => default; // 0x0000000189D5C96C-0x0000000189D5CC58
		private static string LookForPairThenRemove(List<string> strings, string Name) => default; // 0x0000000189D5C8E4-0x0000000189D5C96C
		public void ReplaceNamespace(string oldNamespace, string newNamespace) {} // 0x0000000189D5C68C-0x0000000189D5C8E4
		public void ReplaceAssembly(string oldAssembly, string newAssembly) {} // 0x0000000189D5CDC0-0x0000000189D5CE48
		public void ReplaceName(string oldTypeName, System.Type newType) {} // 0x0000000189D5CD4C-0x0000000189D5CDC0
		public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName = null) {} // 0x0000000189D5CC58-0x0000000189D5CD4C
		private static string ToElementTypeName(string s) => default; // 0x0000000189D5D1E8-0x0000000189D5D338
		private static string ToArrayOrType(string oldType, string newType) => default; // 0x0000000189D5CE58-0x0000000189D5D1D8
		public void SetAssemblyName(AssemblyName newAssemblyName) {} // 0x0000000189D5D1D8-0x0000000189D5D1E8
		private void UpdateName() {} // 0x0000000189D5CE48-0x0000000189D5CE58
		public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification) => default; // 0x0000000189D5FE6C-0x0000000189D5FED0
		public override string ToString() => default; // 0x000000018350B670-0x000000018350B680
		public string ToLooseString() => default; // 0x0000000189D5FAE4-0x0000000189D5FB0C
	}

	public enum TypeNameDetail // TypeDefIndex: 55511
	{
		Name = 0,
		NameAndAssembly = 1,
		Full = 2
	}

	public static class TypeUtility // TypeDefIndex: 55514
	{
		// Fields
		private static readonly HashSet<System.Type> _numericTypes; // 0x00
		private static readonly HashSet<System.Type> _numericConstructTypes; // 0x08
		private static readonly HashSet<System.Type> typesWithShortStrings; // 0x10
		private static readonly Dictionary<System.Type, object> defaultPrimitives; // 0x18
	
		// Constructors
		static TypeUtility() {} // 0x0000000189D5F654-0x0000000189D5F65C
	
		// Extension methods
		public static bool IsBasic(this System.Type type) => default; // 0x000000018350B670-0x000000018350B680
		public static bool IsStatic(this System.Type type) => default; // 0x0000000189D5F118-0x0000000189D5F5C0
		public static bool IsNullable(this System.Type type) => default; // 0x0000000181041090-0x00000001810410A0
		public static bool IsReferenceType(this System.Type type) => default; // 0x0000000189D5F65C-0x0000000189D5F6A8
		public static bool IsAssignableFrom(this System.Type type, object value) => default; // 0x0000000181041090-0x00000001810410A0
		[IteratorStateMachine(typeof(_GetTypesSafely_d__35))]
		public static IEnumerable<System.Type> GetTypesSafely(this Assembly assembly) => default; // 0x0000000189D5F5C0-0x0000000189D5F654
	}

	public class LooseAssemblyNameConverter : fsDirectConverter // TypeDefIndex: 55515
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x0000000189D50630-0x0000000189D50680 
	
		// Constructors
		public LooseAssemblyNameConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D503FC-0x0000000189D50438
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D50560-0x0000000189D50630
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D50438-0x0000000189D50560
	}

	public class NamespaceConverter : fsDirectConverter // TypeDefIndex: 55516
	{
		// Properties
		public override System.Type ModelType { get => default; } // 0x0000000189D513BC-0x0000000189D5140C 
	
		// Constructors
		public NamespaceConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D51188-0x0000000189D511C4
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D512E0-0x0000000189D513BC
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D511C4-0x0000000189D512E0
	}

	public class Ray2DConverter : fsDirectConverter<Ray2D> // TypeDefIndex: 55517
	{
		// Constructors
		public Ray2DConverter() {} // 0x0000000189D556A8-0x0000000189D556D0
	
		// Methods
		protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized) => default; // 0x0000000189D55554-0x0000000189D556A8
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model) => default; // 0x0000000189D553E4-0x0000000189D55554
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D553A4-0x0000000189D553E4
	}

	public class RayConverter : fsDirectConverter<Ray> // TypeDefIndex: 55518
	{
		// Constructors
		public RayConverter() {} // 0x0000000189D55A20-0x0000000189D55A48
	
		// Methods
		protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized) => default; // 0x0000000189D558B8-0x0000000189D55A20
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model) => default; // 0x0000000189D55724-0x0000000189D558B8
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D556D0-0x0000000189D55724
	}

	public class UnityObjectConverter : fsConverter // TypeDefIndex: 55519
	{
		// Properties
		private List<UnityEngine.Object> objectReferences { get => default; } // 0x0000000189D605A8-0x0000000189D605F8 
	
		// Constructors
		public UnityObjectConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D601F0-0x0000000189D60268
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6047C-0x0000000189D605A8
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x0000000189D60268-0x0000000189D6047C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000183D553C0-0x0000000183D553D0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class DoNotSerializeAttribute : Attribute // TypeDefIndex: 55520
	{
		// Constructors
		public DoNotSerializeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface ISerializationDependency : ISerializationCallbackReceiver // TypeDefIndex: 55521
	{
		// Properties
		bool IsDeserialized { get; }
	}

	public interface ISerializationDepender : ISerializationCallbackReceiver // TypeDefIndex: 55522
	{
		// Properties
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		void OnAfterDependenciesDeserialized();
	}

	public static class Serialization // TypeDefIndex: 55523
	{
		// Fields
		private static readonly HashSet<SerializationOperation> freeOperations; // 0x00
		private static readonly HashSet<SerializationOperation> busyOperations; // 0x08
		private static readonly object @lock; // 0x10
		private static readonly HashSet<ISerializationDepender> awaitingDependers; // 0x20
	
		// Properties
		public static bool isUnitySerializing { get; set; } // 0x0000000189D5BC38-0x0000000189D5BC88 0x0000000189D5BC88-0x0000000189D5BCDC
		public static bool isCustomSerializing { get; } // 0x0000000189D5BBD4-0x0000000189D5BC38 
	
		// Constructors
		static Serialization() {} // 0x0000000189D5BA44-0x0000000189D5BBD4
	
		// Methods
		private static SerializationOperation StartOperation() => default; // 0x0000000189D5B808-0x0000000189D5BA44
		private static void EndOperation(SerializationOperation operation) {} // 0x0000000189D5AD24-0x0000000189D5AF30
		private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected) => default; // 0x0000000189D5B254-0x0000000189D5B480
		private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected) => default; // 0x0000000189D5AA38-0x0000000189D5AB60
		private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected) {} // 0x0000000189D5AB60-0x0000000189D5ACB8
		private static void HandleResult(string label, fsResult result, UnityEngine.Object context = null) {} // 0x0000000189D5AF30-0x0000000189D5B238
		public static string PrettyPrint(string json) => default; // 0x0000000189D5B238-0x0000000189D5B254
		public static void AwaitDependencies(ISerializationDepender depender) {} // 0x0000000189D59FE8-0x0000000189D5A060
		private static void CheckIfDependenciesMet(ISerializationDepender depender) {} // 0x0000000189D5A060-0x0000000189D5A4A0
	
		// Extension methods
		public static Unity.VisualScripting.SerializationData Serialize(this object value, bool forceReflected = false /* Metadata: 0x01FD6F98 */) => default; // 0x0000000189D5B480-0x0000000189D5B808
		public static void DeserializeInto(this Unity.VisualScripting.SerializationData data, ref object instance, bool forceReflected = false /* Metadata: 0x01FD6F99 */) {} // 0x0000000189D5A4A0-0x0000000189D5AA38
		public static object Deserialize(this Unity.VisualScripting.SerializationData data, bool forceReflected = false /* Metadata: 0x01FD6F9A */) => default; // 0x0000000189D5ACB8-0x0000000189D5AD24
	}

	[Serializable]
	public struct SerializationData // TypeDefIndex: 55524
	{
		// Fields
		[SerializeField]
		private string _json; // 0x00
		[SerializeField]
		private UnityEngine.Object[] _objectReferences; // 0x08
	
		// Properties
		public string json { get => default; } // 0x00000001820C61B0-0x00000001820C61C0 
		public UnityEngine.Object[] objectReferences { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Constructors
		public SerializationData(string json, IEnumerable<UnityEngine.Object> objectReferences) : this() {
			_json = default;
			_objectReferences = default;
		} // 0x0000000189D59CD4-0x0000000189D59D74
		public SerializationData(string json, params UnityEngine.Object[] objectReferences) : this() {
			_json = default;
			_objectReferences = default;
		} // 0x0000000189D59CCC-0x0000000189D59CD4
	
		// Methods
		internal void Clear() {} // 0x000000018853DCB8-0x000000018853DCDC
		public string ToString(string title) => default; // 0x0000000189D59638-0x0000000189D59CC0
		public override string ToString() => default; // 0x0000000189D59CC0-0x0000000189D59CCC
		public void ShowString(string title = null) {} // 0x0000000189D5956C-0x0000000189D59638
	}

	public class SerializationOperation // TypeDefIndex: 55525
	{
		// Properties
		public fsSerializer serializer { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public List<UnityEngine.Object> objectReferences { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public SerializationOperation() {} // 0x0000000189D59DBC-0x0000000189D59FE0
	
		// Methods
		public void Reset() {} // 0x0000000189D59D74-0x0000000189D59DBC
	}

	public class SerializationVersionAttribute : fsObjectAttribute // TypeDefIndex: 55526
	{
		// Constructors
		public SerializationVersionAttribute() {} // Dummy constructor
		public SerializationVersionAttribute(string versionString, params System.Type[] previousModels) {} // 0x0000000189D59FE0-0x0000000189D59FE8
	}

	public class SerializeAsAttribute : fsPropertyAttribute // TypeDefIndex: 55527
	{
		// Constructors
		public SerializeAsAttribute() {} // Dummy constructor
		public SerializeAsAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class SerializeAttribute : Attribute // TypeDefIndex: 55528
	{
		// Constructors
		public SerializeAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public interface ISingleton // TypeDefIndex: 55529
	{
	}

	public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 55530
	{
		// Fields
		[DoNotSerialize]
		[SerializeField]
		protected Unity.VisualScripting.SerializationData _data; // 0x18
	
		// Events
		internal event Action OnDestroyActions;
	
		// Constructors
		protected LudiqScriptableObject() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000189D5098C-0x0000000189D50AD8
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189D50828-0x0000000189D5098C
		protected virtual void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterSerialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnBeforeDeserialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAfterDeserialize() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnPostDeserializeInEditor() {} // 0x000000018350B670-0x000000018350B680
		private void OnDestroy() {} // 0x0000000189D5078C-0x0000000189D5079C
		protected virtual void ShowData() {} // 0x0000000189D5079C-0x0000000189D50820
		public override string ToString() => default; // 0x0000000189D50820-0x0000000189D50828
	}

	public static class Singleton<T> // TypeDefIndex: 55531
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

	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public sealed class SingletonAttribute : Attribute // TypeDefIndex: 55532
	{
		// Properties
		public bool Persistent { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool Automatic { get; set; } // 0x0000000183D510E0-0x0000000183D510F0 0x0000000183D510F0-0x0000000183D51100
		public HideFlags HideFlags { get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public string Name { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public SingletonAttribute() {} // 0x0000000183D695B0-0x0000000183D695C0
	}

	public static class UnityThread // TypeDefIndex: 55533
	{
		// Fields
		public static Thread thread; // 0x00
		public static ConcurrentQueue<Action> pendingQueue; // 0x08
	
		// Properties
		public static bool allowsAPI { get; } // 0x0000000189D60920-0x0000000189D609CC 
	
		// Constructors
		static UnityThread() {} // 0x0000000183A1DF90-0x0000000183A1E050
	
		// Methods
		internal static void RuntimeInitialize() {} // 0x000000018316FE20-0x000000018316FE90
	}

	public static class Empty<T> // TypeDefIndex: 55534
	{
		// Fields
		public static readonly T[] array;
		public static readonly List<T> list;
		public static readonly HashSet<T> hashSet;
	
		// Constructors
		static Empty() {}
	}

	public static class HashUtility // TypeDefIndex: 55535
	{
		// Methods
		public static int GetHashCode<T>(T a) => default;
		public static int GetHashCode<T1, T2>(T1 a, T2 b) => default;
	}

	public interface IIdentifiable // TypeDefIndex: 55536
	{
		// Properties
		Guid guid { get; }
	}

	public static class LinqUtility // TypeDefIndex: 55539
	{
		// Methods
		[IteratorStateMachine(typeof(_Concat_d__0<T>))]
		public static IEnumerable<T> Concat<T>(params IEnumerable[] enumerables) => default;
	
		// Extension methods
		public static IEnumerable<T> NotNull<T>(this IEnumerable<T> enumerable) => default;
	}

	public class Recursion<T> : IPoolable, IDisposable // TypeDefIndex: 55541
	{
		// Fields
		private readonly Stack<T> traversedOrder;
		private readonly Dictionary<T, int> traversedCount;
		private bool disposed;
		protected int maxDepth;
	
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

	public sealed class Recursion : Recursion<object> // TypeDefIndex: 55542
	{
		// Properties
		public static int defaultMaxDepth { get; } // 0x0000000189D55A48-0x0000000189D55A98 
		public static bool safeMode { get; set; } // 0x0000000189D55A98-0x0000000189D55AE8 0x0000000189D55AE8-0x0000000189D55B3C
	
		// Constructors
		public Recursion() {} // Dummy constructor
		static Recursion() {} // 0x0000000183D43DA0-0x0000000183D43DE0
	
		// Methods
		internal static void OnRuntimeMethodLoad() {} // 0x00000001831702D0-0x00000001831703A0
	}

	public static class ReferenceCollector // TypeDefIndex: 55544
	{
		// Events
		public static event Action onSceneUnloaded;
	
		// Methods
		internal static void Initialize() {} // 0x0000000183D22C10-0x0000000183D22C60
	}

	public class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 55545
	{
		// Fields
		public static readonly ReferenceEqualityComparer Instance; // 0x00
	
		// Constructors
		private ReferenceEqualityComparer() {} // 0x000000018350B670-0x000000018350B680
		static ReferenceEqualityComparer() {} // 0x0000000183D1B170-0x0000000183D1B1D0
	
		// Methods
		bool IEqualityComparer<object>.Equals(object a, object b) => default; // 0x0000000183D47CB0-0x0000000183D47CC0
		int IEqualityComparer<object>.GetHashCode(object a) => default; // 0x0000000183C946D0-0x0000000183C94720
		public static int GetHashCode(object a) => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 55546
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

	public static class RuntimeVSUsageUtility // TypeDefIndex: 55547
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeInitializeOnLoadBeforeSceneLoad() {} // 0x000000018316FD50-0x000000018316FE20
	}

	public static class StringUtility // TypeDefIndex: 55548
	{
		// Fields
		private static readonly Regex guidRegex; // 0x00
	
		// Constructors
		static StringUtility() {} // 0x0000000189D5C2A0-0x0000000189D5C330
	
		// Extension methods
		public static string TrimStart(this string source, string value) => default; // 0x0000000189D5C200-0x0000000189D5C2A0
		public static void PartsAround(this string s, char c, out string before, out string after) {
			before = default;
			after = default;
		} // 0x0000000189D5C090-0x0000000189D5C184
		public static string ToHexString(this byte[] bytes) => default; // 0x0000000189D5C184-0x0000000189D5C200
	}

	public static class UnityObjectUtility // TypeDefIndex: 55549
	{
		// Methods
		public static bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b) => default; // 0x0000000189D60898-0x0000000189D60920
	
		// Extension methods
		public static bool IsUnityNull(this object obj) => default; // 0x0000000189D605F8-0x0000000189D60674
		public static string ToSafeString(this UnityEngine.Object uo) => default; // 0x0000000189D60674-0x0000000189D60898
		public static T AsUnityNull<T>(this T obj)
			where T : UnityEngine.Object => default;
	}

	public static class ApplicationVariables // TypeDefIndex: 55550
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
	
		// Properties
		public static VariablesAsset asset { get; } // 0x000000018316F930-0x000000018316F9C0 
		private static VariableDeclarations runtime { get; set; } // 0x0000000189D46760-0x0000000189D467B4
	
		// Methods
		public static void Load() {} // 0x000000018316F9C0-0x000000018316FA50
		internal static void OnEnterPlayMode() {} // 0x0000000184275A5C-0x0000000184275A64
		internal static void OnExitPlayMode() {} // 0x000000018350B670-0x000000018350B680
		private static void CreateRuntimeDeclarations() {} // 0x000000018316EF40-0x000000018316F000
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorVariableNameAttribute : Attribute // TypeDefIndex: 55551
	{
		// Properties
		private ActionDirection direction { get; set; } // 0x00000001810410F0-0x0000000181041100
	
		// Constructors
		public InspectorVariableNameAttribute() {} // Dummy constructor
		public InspectorVariableNameAttribute(ActionDirection direction) {} // 0x00000001810410F0-0x0000000181041100
	}

	public static class SavedVariables // TypeDefIndex: 55553
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
	
		// Properties
		public static VariablesAsset asset { get; } // 0x000000018316F800-0x000000018316F8A0 
		public static VariableDeclarations initial { get; } // 0x0000000189D594C4-0x0000000189D59518 
		public static VariableDeclarations saved { get; private set; } // 0x0000000189D592C4-0x0000000189D59454 0x000000018316FAE0-0x000000018316FBE0
		public static VariableDeclarations merged { get; private set; } // 0x000000018316F000-0x000000018316F800 0x000000018316DF00-0x000000018316E140
	
		// Methods
		public static void Load() {} // 0x0000000189D5948C-0x0000000189D594C4
		internal static void OnEnterPlayMode() {} // 0x0000000189D59518-0x0000000189D5956C
		internal static void OnExitPlayMode() {} // 0x0000000189D59454-0x0000000189D5948C
		public static void SaveDeclarations(VariableDeclarations declarations) {} // 0x0000000183D18770-0x0000000183D187D0
		public static void FetchSavedDeclarations() {} // 0x000000018350B670-0x000000018350B680
		private static void MergeInitialAndSavedDeclarations() {} // 0x0000000189D5F864-0x0000000189D5F8BC
		private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations) {} // 0x00000001859311D0-0x00000001859311E8
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclaration // TypeDefIndex: 55554
	{
		// Properties
		[Serialize]
		public string name { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		[Serialize]
		[Value]
		public object value { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public VariableDeclaration() {} // Dummy constructor
		public VariableDeclaration(string name, object value) {} // 0x0000000182676770-0x00000001826767A0
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration> // TypeDefIndex: 55555
	{
		// Properties
		VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.this[string key] { get => default; } // 0x0000000189D6111C-0x0000000189D61164 
	
		// Constructors
		public VariableDeclarationCollection() {} // 0x000000018316FD10-0x000000018316FD50
	
		// Methods
		protected override string GetKeyForItem(VariableDeclaration item) => default; // 0x00000001859311D0-0x00000001859311E8
		public new bool TryGetValue(string key, out VariableDeclaration value) {
			value = default;
			return default;
		} // 0x0000000189D6105C-0x0000000189D610D4
		bool IKeyedCollection<string, VariableDeclaration>.Contains(string key) => default; // 0x0000000189D610D4-0x0000000189D6111C
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, ISpecifiesCloner // TypeDefIndex: 55556
	{
		// Fields
		public VariableKind Kind; // 0x10
		[InspectorWide(true)]
		[Serialize]
		private VariableDeclarationCollection collection; // 0x18
		internal Action OnVariableChanged; // 0x20
	
		// Properties
		public object this[[InspectorVariableName(ActionDirection.Any)] string variable] { get => default; set {} } // 0x0000000189D61598-0x0000000189D615A0 0x0000000189D615A0-0x0000000189D615A8
		ICloner ISpecifiesCloner.cloner { get => default; } // 0x0000000189D61548-0x0000000189D61598 
	
		// Constructors
		public VariableDeclarations() {} // 0x000000018316FCA0-0x000000018316FD10
	
		// Methods
		public void Set([InspectorVariableName(ActionDirection.Set)] string variable, object value) {} // 0x0000000189D61404-0x0000000189D61500
		public object Get([InspectorVariableName(ActionDirection.Get)] string variable) => default; // 0x0000000189D61210-0x0000000189D61344
		public void Clear() {} // 0x0000000189D611C8-0x0000000189D61210
		public bool IsDefined([InspectorVariableName(ActionDirection.Any)] string variable) => default; // 0x0000000189D61344-0x0000000189D61404
		public IEnumerator<VariableDeclaration> GetEnumerator() => default; // 0x000000018316E400-0x000000018316E450
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189D61500-0x0000000189D61548
	}

	public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations> // TypeDefIndex: 55557
	{
		// Fields
		public static readonly VariableDeclarationsCloner instance; // 0x00
	
		// Constructors
		public VariableDeclarationsCloner() {} // 0x0000000183CE5F30-0x0000000183CE5F60
		static VariableDeclarationsCloner() {} // 0x0000000183CE5EC0-0x0000000183CE5F30
	
		// Methods
		public override bool Handles(System.Type type) => default; // 0x0000000189D61164-0x0000000189D611C8
		public override VariableDeclarations ConstructClone(System.Type type, VariableDeclarations original) => default; // 0x000000018316FBE0-0x000000018316FC30
		public override void FillClone(System.Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context) {} // 0x000000018316E210-0x000000018316E400
	}

	public enum VariableKind // TypeDefIndex: 55558
	{
		Flow = 0,
		Graph = 1,
		Object = 2,
		Scene = 3,
		Application = 4,
		Saved = 5
	}

	[IncludeInSettings(false)]
	public sealed class VariablesAsset : LudiqScriptableObject // TypeDefIndex: 55559
	{
		// Properties
		[Inspectable]
		[InspectorWide(true)]
		[Serialize]
		public VariableDeclarations declarations { get; internal set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
	
		// Constructors
		public VariablesAsset() {} // 0x000000018316FC30-0x000000018316FCA0
	
		// Methods
		[ContextMenu("Show Data...")]
		protected override void ShowData() {} // 0x0000000189D615A8-0x0000000189D615B0
	}

	[AddComponentMenu("")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	[Singleton(Name = "VisualScripting SavedVariablesSerializer", Automatic = true, Persistent = true)]
	public class VariablesSaver : MonoBehaviour, ISingleton // TypeDefIndex: 55560
	{
		// Properties
		public static VariablesSaver instance { get => default; } // 0x0000000189D616C0-0x0000000189D61714 
	
		// Constructors
		public VariablesSaver() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x0000000189D615B0-0x0000000189D61604
		private void OnDestroy() {} // 0x0000000189D6166C-0x0000000189D616C0
		private void OnApplicationQuit() {} // 0x0000000189D61664-0x0000000189D6166C
		private void OnApplicationPause(bool isPaused) {} // 0x0000000189D61658-0x0000000189D61664
		public static void Instantiate() {} // 0x0000000189D61604-0x0000000189D61658
	}
}

namespace Unity.VisualScripting.FullSerializer
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 55561
	{
		// Constructors
		public fsArrayConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x00000001893BF984-0x00000001893BF9A4
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D61BB4-0x0000000189D61D90
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D6194C-0x0000000189D61BB4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D618D8-0x0000000189D6194C
	}

	public class fsDateConverter : fsConverter // TypeDefIndex: 55562
	{
		// Properties
		private string DateTimeFormatString { get => default; } // 0x0000000189D64A84-0x0000000189D64AD8 
	
		// Constructors
		public fsDateConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D64234-0x0000000189D642F8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6487C-0x0000000189D64A84
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D642F8-0x0000000189D6487C
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 55563
	{
		// Constructors
		public fsDictionaryConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D64D78-0x0000000189D64DF0
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D64DF0-0x0000000189D64E64
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x0000000189D64F80-0x0000000189D6587C
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6587C-0x0000000189D65DB8
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value) => default; // 0x0000000189D64AD8-0x0000000189D64D78
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType) {
			keyStorageType = default;
			valueStorageType = default;
		} // 0x0000000189D64E64-0x0000000189D64F80
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 55566
	{
		// Constructors
		public fsEnumConverter() {} // 0x0000000183D51A20-0x0000000183D51A30
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x000000018350B670-0x000000018350B680
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018350B670-0x000000018350B680
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000189D60F24-0x0000000189D60F94
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D60F94-0x0000000189D60FF8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x000000018350B670-0x000000018350B680
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D60C6C-0x0000000189D60D6C
		private static bool ArrayContains<T>(T[] values, T value) => default; // 0x0000000183D606D0-0x0000000183D606E0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 55567
	{
		// Fields
		public string MemberName; // 0x10
	
		// Constructors
		public fsForwardAttribute() {} // Dummy constructor
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 55568
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter() {} // Dummy constructor
		public fsForwardConverter(fsForwardAttribute attribute) {} // 0x00000001893C1C98-0x00000001893C1CBC
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D66DFC-0x0000000189D66E58
		private fsResult GetProperty(object instance, out fsMetaProperty property) {
			property = default;
			return default;
		} // 0x0000000189D66ECC-0x0000000189D67094
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D67218-0x0000000189D67378
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D67094-0x0000000189D67218
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D66E58-0x0000000189D66ECC
	}

	public class fsGuidConverter : fsConverter // TypeDefIndex: 55569
	{
		// Constructors
		public fsGuidConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D673F8-0x0000000189D6745C
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D675A4-0x0000000189D67694
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D6749C-0x0000000189D675A4
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D6745C-0x0000000189D6749C
	}

	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 55570
	{
		// Constructors
		public fsIEnumerableConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D67694-0x0000000189D6772C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D6772C-0x0000000189D677A0
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D67E74-0x0000000189D681E8
		private bool IsStack(System.Type type) => default; // 0x0000000189D67A44-0x0000000189D67AFC
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType) => default; // 0x0000000189D67B90-0x0000000189D67E74
		private static int HintSize(IEnumerable collection) => default; // 0x0000000189D679CC-0x0000000189D67A44
		private static System.Type GetElementType(System.Type objectType) => default; // 0x0000000189D678E0-0x0000000189D679CC
		private static void TryClear(System.Type type, object instance) {} // 0x0000000189D67AFC-0x0000000189D67B90
		private static MethodInfo GetAddMethod(System.Type type) => default; // 0x0000000189D677A0-0x0000000189D678E0
	}

	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 55571
	{
		// Constructors
		public fsKeyValuePairConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D6B57C-0x0000000189D6B628
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D6B628-0x0000000189D6BA1C
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6BA1C-0x0000000189D6BCD4
	}

	public class fsNullableConverter : fsConverter // TypeDefIndex: 55572
	{
		// Constructors
		public fsNullableConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D6DDE8-0x0000000189D6DE94
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6DF0C-0x0000000189D6DF84
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D6DE94-0x0000000189D6DF0C
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000183D553C0-0x0000000183D553D0
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 55573
	{
		// Constructors
		public fsPrimitiveConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D6E810-0x0000000189D6E8D8
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6EE7C-0x0000000189D6F428
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType) => default; // 0x0000000189D6E8D8-0x0000000189D6EE7C
		private static bool UseBool(System.Type type) => default; // 0x0000000189D6F428-0x0000000189D6F48C
		private static bool UseInt64(System.Type type) => default; // 0x0000000189D6F550-0x0000000189D6F70C
		private static bool UseDouble(System.Type type) => default; // 0x0000000189D6F48C-0x0000000189D6F550
		private static bool UseString(System.Type type) => default; // 0x0000000189D6F70C-0x0000000189D6F7A4
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 55574
	{
		// Constructors
		public fsReflectedConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D6F7A4-0x0000000189D6F850
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D6FB24-0x0000000189D6FD64
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D6F8C4-0x0000000189D6FB24
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D6F850-0x0000000189D6F8C4
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 55575
	{
		// Constructors
		public fsTypeConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D75E9C-0x0000000189D75F14
		public override bool RequestCycleSupport(System.Type type) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type type) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D76090-0x0000000189D76188
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D75F14-0x0000000189D76090
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000183D553C0-0x0000000183D553D0
	}

	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 55576
	{
		// Constructors
		public fsWeakReferenceConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D77598-0x0000000189D775FC
		public override bool RequestCycleSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override bool RequestInheritanceSupport(System.Type storageType) => default; // 0x000000018115F4C0-0x000000018115F530
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType) {
			serialized = default;
			return default;
		} // 0x0000000189D77974-0x0000000189D77C78
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType) => default; // 0x0000000189D77654-0x0000000189D77974
		public override object CreateInstance(fsData data, System.Type storageType) => default; // 0x0000000189D775FC-0x0000000189D77654
	}

	public class fsConverterRegistrar // TypeDefIndex: 55577
	{
		// Fields
		public static List<System.Type> Converters; // 0x00
	
		// Constructors
		public fsConverterRegistrar() {} // Dummy constructor
		static fsConverterRegistrar() {} // 0x0000000189D627CC-0x0000000189D62AE0
	}

	public class fsAotCompilationManager // TypeDefIndex: 55579
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 55578
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		public fsAotCompilationManager() {} // Dummy constructor
		static fsAotCompilationManager() {} // 0x0000000189D617E4-0x0000000189D618D8
	
		// Methods
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic) {} // 0x0000000189D61714-0x0000000189D617E4
	}

	public abstract class fsBaseConverter // TypeDefIndex: 55581
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Constructors
		protected fsBaseConverter() {} // 0x0000000189D60C1C-0x0000000189D60C6C
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType) => default;
		public virtual bool RequestCycleSupport(System.Type storageType) => default;
		public virtual bool RequestInheritanceSupport(System.Type storageType) => default; // 0x0000000189D62310-0x0000000189D62650
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x0000000189D61FA4-0x0000000189D621BC
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x0000000189D61D90-0x0000000189D61DFC
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types) => default; // 0x0000000189D61DFC-0x0000000189D61FA4
		protected fsResult CheckType(fsData data, fsDataType type) => default;
		protected fsResult CheckKey(fsData data, string key, out fsData subitem) {
			subitem = default;
			return default;
		}
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem) {
			subitem = default;
			return default;
		} // 0x000000018350B670-0x000000018350B680
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value) => default; // 0x0000000189D60FF8-0x0000000189D6105C
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value) {
			value = default;
			return default;
		} // 0x000000018350B670-0x000000018350B680
	}

	public static class fsGlobalConfig // TypeDefIndex: 55582
	{
		// Fields
		public static bool IsCaseSensitive; // 0x00
		public static bool AllowInternalExceptions; // 0x01
		public static string InternalFieldPrefix; // 0x08
	
		// Constructors
		static fsGlobalConfig() {} // 0x0000000189D67378-0x0000000189D673F8
	}

	public class fsConfig // TypeDefIndex: 55584
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
	
		// Constructors
		public fsConfig() {} // 0x0000000183D51810-0x0000000183D51820
	}

	public sealed class fsContext // TypeDefIndex: 55585
	{
		// Fields
		private readonly Dictionary<System.Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext() {} // 0x0000000189D62754-0x0000000189D627CC
	
		// Methods
		public void Set<T>(T obj) {}
		public T Get<T>() => default;
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 55586
	{
		// Constructors
		protected fsConverter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public enum fsDataType // TypeDefIndex: 55587
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 55588
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get => default; } // 0x0000000189D63FB4-0x0000000189D64110 
		public bool IsNull { get => default; } // 0x00000001825EB8A0-0x00000001825EB8B0 
		public bool IsDouble { get => default; } // 0x0000000189D63E8C-0x0000000189D63ED8 
		public bool IsInt64 { get => default; } // 0x0000000189D63ED8-0x0000000189D63F24 
		public bool IsBool { get => default; } // 0x0000000189D63DFC-0x0000000189D63E48 
		public bool IsString { get => default; } // 0x0000000189D63F68-0x0000000189D63FB4 
		public bool IsDictionary { get => default; } // 0x0000000189D63E48-0x0000000189D63E8C 
		public bool IsList { get => default; } // 0x0000000189D63F24-0x0000000189D63F68 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble { get => default; } // 0x0000000189D63D0C-0x0000000189D63D48 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64 { get => default; } // 0x0000000189D63D48-0x0000000189D63D84 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool { get => default; } // 0x0000000189D63C94-0x0000000189D63CD0 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString { get => default; } // 0x0000000189D63DC0-0x0000000189D63DFC 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary { get => default; } // 0x0000000189D63CD0-0x0000000189D63D0C 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList { get => default; } // 0x0000000189D63D84-0x0000000189D63DC0 
	
		// Constructors
		public fsData() {} // 0x00000001835ACAA0-0x00000001835ACAC0
		public fsData(bool boolean) {} // 0x0000000189D63B80-0x0000000189D63BDC
		public fsData(double f) {} // 0x0000000189D63BDC-0x0000000189D63C38
		public fsData(long i) {} // 0x0000000189D63C38-0x0000000189D63C94
		public fsData(string str) {} // 0x000000018426FEE0-0x000000018426FEF0
		public fsData(Dictionary<string, fsData> dict) {} // 0x000000018426FEE0-0x000000018426FEF0
		public fsData(List<fsData> list) {} // 0x000000018426FEE0-0x000000018426FEF0
		static fsData() {} // 0x0000000189D63A74-0x0000000189D63B80
	
		// Methods
		public override string ToString() => default; // 0x0000000189D63A6C-0x0000000189D63A74
		public static fsData CreateDictionary() => default; // 0x0000000189D631D0-0x0000000189D632C4
		public static fsData CreateList(int capacity) => default; // 0x0000000189D632C4-0x0000000189D63360
		internal void BecomeDictionary() {} // 0x0000000189D630EC-0x0000000189D63164
		internal fsData Clone() => default; // 0x0000000189D63164-0x0000000189D631D0
		private T Cast<T>() => default;
		public override bool Equals(object obj) => default; // 0x0000000189D63360-0x0000000189D633C4
		public bool Equals(fsData other) => default; // 0x0000000189D633C4-0x0000000189D63A6C
		public static bool operator ==(fsData a, fsData b) => default; // 0x0000000189D64110-0x0000000189D641E0
		public static bool operator !=(fsData a, fsData b) => default; // 0x0000000189D641E0-0x0000000189D64234
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 55589
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 55590
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

	public sealed class fsMissingVersionConstructorException : Exception // TypeDefIndex: 55591
	{
		// Constructors
		public fsMissingVersionConstructorException() {} // Dummy constructor
		public fsMissingVersionConstructorException(System.Type versionedType, System.Type constructorType) {} // 0x0000000189D6DD1C-0x0000000189D6DDE8
	}

	public sealed class fsDuplicateVersionNameException : Exception // TypeDefIndex: 55592
	{
		// Constructors
		public fsDuplicateVersionNameException() {} // Dummy constructor
		public fsDuplicateVersionNameException(System.Type typeA, System.Type typeB, string version) {} // 0x0000000189D65DB8-0x0000000189D65F1C
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 55593
	{
		// Constructors
		public fsIgnoreAttribute() {} // Dummy constructor
	}

	public interface fsISerializationCallbacks // TypeDefIndex: 55594
	{
		// Methods
		void OnBeforeSerialize(System.Type storageType);
		void OnAfterSerialize(System.Type storageType, ref fsData data);
		void OnBeforeDeserialize(System.Type storageType, ref fsData data);
		void OnAfterDeserialize(System.Type storageType);
	}

	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 55595
	{
		// Constructors
		public fsSerializationCallbackProcessor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D70714-0x0000000189D7078C
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000189D70A14-0x0000000189D70A90
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x0000000189D70808-0x0000000189D70898
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x0000000189D70898-0x0000000189D70A14
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000189D7078C-0x0000000189D70808
	}

	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 55596
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public override bool CanProcess(System.Type type) => default; // 0x0000000189D70A90-0x0000000189D70B08
		public override void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x0000000189D70B8C-0x0000000189D70C10
		public override void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x0000000189D70B08-0x0000000189D70B8C
	}

	public class fsJsonParser // TypeDefIndex: 55597
	{
		// Fields
		private readonly StringBuilder _cachedStringBuilder; // 0x10
		private int _start; // 0x18
		private string _input; // 0x20
	
		// Constructors
		public fsJsonParser() {} // Dummy constructor
		private fsJsonParser(string input) {} // 0x0000000189D6A0B4-0x0000000189D6A140
	
		// Methods
		private fsResult MakeFailure(string message) => default; // 0x0000000189D682BC-0x0000000189D68448
		private bool TryMoveNext() => default; // 0x0000000189D68AC4-0x0000000189D68AF0
		private bool HasValue() => default; // 0x0000000189D68220-0x0000000189D6822C
		private bool HasValue(int offset) => default; // 0x0000000189D6822C-0x0000000189D68260
		private char Character() => default; // 0x0000000189D681E8-0x0000000189D681F4
		private char Character(int offset) => default; // 0x0000000189D681F4-0x0000000189D68220
		private void SkipSpace() {} // 0x0000000189D688E8-0x0000000189D68AC4
		private fsResult TryParseExact(string content) => default; // 0x0000000189D68DA8-0x0000000189D68EEC
		private fsResult TryParseTrue(out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D69ABC-0x0000000189D69BBC
		private fsResult TryParseFalse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D68EEC-0x0000000189D68FEC
		private fsResult TryParseNull(out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D68FEC-0x0000000189D690E8
		private bool IsSeparator(char c) => default; // 0x0000000189D68260-0x0000000189D682BC
		private fsResult TryParseNumber(out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D690E8-0x0000000189D693FC
		private fsResult TryParseString(out string str) {
			str = default;
			return default;
		} // 0x0000000189D69804-0x0000000189D69ABC
		private fsResult TryParseArray(out fsData arr) {
			arr = default;
			return default;
		} // 0x0000000189D68AF0-0x0000000189D68DA8
		private fsResult TryParseObject(out fsData obj) {
			obj = default;
			return default;
		} // 0x0000000189D693FC-0x0000000189D69804
		private fsResult RunParse(out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D685A4-0x0000000189D688E8
		public static fsResult Parse(string input, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D684BC-0x0000000189D685A4
		public static fsData Parse(string input) => default; // 0x0000000189D68448-0x0000000189D684BC
		private bool IsHex(char c) => default; // 0x00000001893B2200-0x00000001893B2228
		private uint ParseSingleChar(char c1, uint multipliyer) => default; // 0x00000001893B2410-0x00000001893B2454
		private uint ParseUnicode(char c1, char c2, char c3, char c4) => default; // 0x00000001893B2454-0x00000001893B24D8
		private fsResult TryUnescapeChar(out char escaped) {
			escaped = default;
			return default;
		} // 0x0000000189D69BBC-0x0000000189D6A0B4
	}

	public static class fsJsonPrinter // TypeDefIndex: 55598
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count) {} // 0x0000000189D6B3B0-0x0000000189D6B41C
		private static string EscapeString(string str) => default; // 0x0000000189D6B0F0-0x0000000189D6B3B0
		private static void BuildCompressedString(fsData data, TextWriter stream) {} // 0x0000000189D6A140-0x0000000189D6A718
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth) {} // 0x0000000189D6A718-0x0000000189D6AE58
		public static string PrettyJson(fsData data) => default; // 0x0000000189D6B41C-0x0000000189D6B57C
		public static string CompressedJson(fsData data) => default; // 0x0000000189D6AE58-0x0000000189D6AFB4
		private static string ConvertDoubleToString(double d) => default; // 0x0000000189D6AFB4-0x0000000189D6B0F0
	}

	public enum fsMemberSerialization // TypeDefIndex: 55599
	{
		OptIn = 0,
		OptOut = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class fsObjectAttribute : Attribute // TypeDefIndex: 55600
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute() {} // 0x0000000183D5C030-0x0000000183D5C040
		public fsObjectAttribute(string versionString, params System.Type[] previousModels) {} // 0x0000000189D6DF84-0x0000000189D6DFB4
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 55601
	{
		// Constructors
		protected fsObjectProcessor() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual bool CanProcess(System.Type type) => default; // 0x0000000189D6DFB4-0x0000000189D6E000
		public virtual void OnBeforeSerialize(System.Type storageType, object instance) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data) {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterDeserialize(System.Type storageType, object instance) {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class fsPropertyAttribute : Attribute // TypeDefIndex: 55602
	{
		// Fields
		public string Name; // 0x10
		public System.Type Converter; // 0x18
	
		// Constructors
		public fsPropertyAttribute() {} // Dummy constructor
		public fsPropertyAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public struct fsResult // TypeDefIndex: 55603
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get => default; } // 0x00000001880712C4-0x00000001880712CC 
		public bool Succeeded { get => default; } // 0x0000000183D51020-0x0000000183D51030 
		public bool HasWarnings { get => default; } // 0x0000000189D705F8-0x0000000189D70644 
		public Exception AsException { get => default; } // 0x0000000189D70400-0x0000000189D70518 
		public IEnumerable<string> RawMessages { get => default; } // 0x0000000189D70644-0x0000000189D7069C 
		public string FormattedMessages { get => default; } // 0x0000000189D70518-0x0000000189D705F8 
	
		// Constructors
		static fsResult() {
			EmptyStringArray = default;
			Success = default;
		} // 0x0000000189D70360-0x0000000189D70400
	
		// Methods
		public void AddMessage(string message) {} // 0x0000000189D6FF2C-0x0000000189D6FFDC
		public void AddMessages(fsResult result) {} // 0x0000000189D6FFDC-0x0000000189D70094
		public fsResult Merge(fsResult other) => default; // 0x0000000189D701CC-0x0000000189D702B0
		public static fsResult Warn(string warning) => default; // 0x0000000189D702B0-0x0000000189D70360
		public static fsResult Fail(string warning) => default; // 0x0000000189D70120-0x0000000189D701CC
		public static fsResult operator +(fsResult a, fsResult b) => default; // 0x0000000189D7069C-0x0000000189D70714
		public fsResult AssertSuccess() => default; // 0x0000000189D70094-0x0000000189D70120
	}

	public class fsSerializer // TypeDefIndex: 55605
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
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 55604
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter() {} // 0x0000000189D72458-0x0000000189D726B4
	
			// Methods
			public void WriteDefinition(int id, fsData data) {} // 0x0000000189D75444-0x0000000189D75E9C
			public void WriteReference(int id, Dictionary<string, fsData> dict) {} // 0x0000000189D744F0-0x0000000189D74680
			public void Clear() {} // 0x0000000189D74680-0x0000000189D7477C
		}
	
		// Constructors
		public fsSerializer() {} // 0x0000000189D70C10-0x0000000189D70E94
		static fsSerializer() {} // 0x0000000189D741D0-0x0000000189D74268
	
		// Methods
		private void RemapAbstractStorageTypeToDefaultType(ref System.Type storageType) {} // 0x0000000189D7126C-0x0000000189D7165C
		public void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType) {}
		private List<fsObjectProcessor> GetProcessors(System.Type type) => default;
		public void AddConverter(fsBaseConverter converter) {} // 0x0000000189D74EB8-0x0000000189D74EF8
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType) => default; // 0x0000000189D74B1C-0x0000000189D74EB8
		public fsResult TrySerialize<T>(T instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D73384-0x0000000189D73740
		public fsResult TryDeserialize<T>(fsData data, ref ref T instance) => default; // 0x0000000189D73740-0x0000000189D739D8
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D739D8-0x0000000189D73BE8
		public fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D73BE8-0x0000000189D73CA0
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D74AE0-0x0000000189D74B1C
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D7477C-0x0000000189D74AE0
		private fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D726B4-0x0000000189D72868
		private fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, out fsData data) {
			data = default;
			return default;
		} // 0x0000000189D72868-0x0000000189D72CDC
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result) => default; // 0x0000000189D72CDC-0x0000000189D73114
		public fsResult TryDeserialize(fsData data, System.Type storageType, System.Type overrideConverterType, ref object result) => default; // 0x0000000189D73114-0x0000000189D73254
		private fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000189D73254-0x0000000189D73384
		private fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000189D7165C-0x0000000189D72458
		private fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors) {
			processors = default;
			return default;
		} // 0x0000000189D711B8-0x0000000189D7126C
		private fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x0000000189D74EF8-0x0000000189D75444
		private fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result) => default; // 0x0000000189D740C8-0x0000000189D74138
		private static System.Type GetDataType(ref fsData data, System.Type defaultType, ref fsResult deserializeResult) => default; // 0x0000000189D74030-0x0000000189D740C8
		private static void EnsureDictionary(fsData data) {} // 0x0000000189D73F98-0x0000000189D74030
		public static bool IsReservedKeyword(string key) => default; // 0x0000000189D74138-0x0000000189D741D0
		private static bool IsObjectReference(fsData data) => default; // 0x0000000189D74458-0x0000000189D744F0
		private static bool IsObjectDefinition(fsData data) => default; // 0x0000000189D74268-0x0000000189D74458
		private static bool IsVersioned(fsData data) => default; // 0x0000000189D70E94-0x0000000189D711B8
		private static bool IsTypeSpecified(fsData data) => default; // 0x0000000189D73EFC-0x0000000189D73F98
		private static bool IsWrappedData(fsData data) => default; // 0x0000000189D73D38-0x0000000189D73DE4
		private static bool IsVisualScriptingUnit(fsData data) => default; // 0x0000000189D73E90-0x0000000189D73EFC
		private static void ConvertLegacyData(ref fsData data) {} // 0x0000000189D73DE4-0x0000000189D73E90
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000189D73CA0-0x0000000189D73D38
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000189D6BD3C-0x0000000189D6BE8C
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data) {} // 0x0000000189D6BE8C-0x0000000189D6C0A0
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data) {} // 0x0000000189D6BCD4-0x0000000189D6BD3C
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance) {} // 0x0000000189D6C0A0-0x0000000189D6C160
	}

	public class fsMetaProperty // TypeDefIndex: 55606
	{
		// Fields
		internal MemberInfo _memberInfo; // 0x10
	
		// Properties
		public System.Type StorageType { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public System.Type OverrideConverterType { get; private set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public bool CanRead { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
		public bool CanWrite { get; private set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000183D4F2B0-0x0000000183D4F2C0
		public string JsonName { get; private set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public string MemberName { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public bool IsPublic { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		public bool IsReadOnly { get; private set; } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000183D4F7D0-0x0000000183D4F7E0
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(fsConfig config, System.Reflection.FieldInfo field) {} // 0x0000000189D6C618-0x0000000189D6C6BC
		internal fsMetaProperty(fsConfig config, PropertyInfo property) {} // 0x0000000189D6C4F8-0x0000000189D6C618
	
		// Methods
		private void CommonInitialize(fsConfig config) {} // 0x0000000189D6C160-0x0000000189D6C238
		public void Write(object context, object value) {} // 0x0000000189D6C300-0x0000000189D6C4F8
		public object Read(object context) => default; // 0x0000000189D6C238-0x0000000189D6C300
	}

	public class fsMetaType // TypeDefIndex: 55610
	{
		// Fields
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x19
		private bool _isDefaultConstructorPublic; // 0x1B
		private static Dictionary<fsConfig, Dictionary<System.Type, fsMetaType>> _configMetaTypes; // 0x00
	
		// Properties
		public fsMetaProperty[] Properties { get; private set; } // 0x0000000189D6C89C-0x0000000189D6CB70 0x0000000189D6C6BC-0x0000000189D6C89C
		public bool HasDefaultConstructor { get => default; } // 0x0000000189D6DA44-0x0000000189D6DAD0 
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(fsConfig config, System.Type reflectedType) {} // 0x0000000189D6D97C-0x0000000189D6DA44
		static fsMetaType() {} // 0x0000000189D60EBC-0x0000000189D60F10
	
		// Methods
		public bool EmitAotData() => default; // 0x000000018350B670-0x000000018350B680
		public object CreateInstance() => default; // 0x0000000189D60D6C-0x0000000189D60DC0
		public static fsMetaType Get(fsConfig config, System.Type type) => default; // 0x0000000189D60DC0-0x0000000189D60E14
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x0000000189D60E14-0x0000000189D60E68
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members) => default; // 0x000000018350B670-0x000000018350B680
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue) => default; // 0x0000000189D60E68-0x0000000189D60EBC
		private static bool CanSerializeField(fsConfig config, System.Reflection.FieldInfo field, bool annotationFreeValue) => default; // 0x000000018350B670-0x000000018350B680
	}

	public static class fsReflectionUtility // TypeDefIndex: 55611
	{
		// Methods
		public static System.Type GetInterface(System.Type type, System.Type interfaceType) => default; // 0x0000000189D6FD64-0x0000000189D6FF2C
	}
}

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 55613
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 55612
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator() {} // 0x0000000189D62D50-0x0000000189D62E58
			static ObjectReferenceEqualityComparator() {} // 0x0000000189D62AE0-0x0000000189D62B44
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y) => default; // 0x0000000183D69B30-0x0000000183D69B40
			int IEqualityComparer<object>.GetHashCode(object obj) => default; // 0x0000000189D62B44-0x0000000189D62CA8
		}
	
		// Constructors
		public fsCyclicReferenceManager() {} // 0x0000000189D60BB8-0x0000000189D60C1C
	
		// Methods
		public void Enter() {} // 0x0000000189D62CA8-0x0000000189D62D50
		public bool Exit() => default; // 0x0000000189D62E58-0x0000000189D62EC8
		public object GetReferenceObject(int id) => default; // 0x0000000189D62EC8-0x0000000189D62FF8
		public void AddReferenceWithId(int id, object reference) {} // 0x0000000189D62FF8-0x0000000189D630EC
		public int GetReferenceId(object item) => default; // 0x0000000186DDEAAC-0x0000000186DDEAB4
		public bool IsReference(object item) => default; // 0x0000000183D6E640-0x0000000183D6E650
		public void MarkSerialized(object item) {} // 0x000000018350B670-0x000000018350B680
	}

	public struct fsOption<T> // TypeDefIndex: 55614
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

	public static class fsOption // TypeDefIndex: 55615
	{
		// Methods
		public static fsOption<T> Just<T>(T value) => default;
	}

	public static class fsPortableReflection // TypeDefIndex: 55618
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static System.Reflection.BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 55616
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 55617
		{
			// Constructors
			public AttributeQueryComparator() {} // 0x0000000189D6E000-0x0000000189D6E168
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y) => default; // 0x0000000189D6E6A8-0x0000000189D6E6FC
			public int GetHashCode(AttributeQuery obj) => default; // 0x0000000184273354-0x0000000184273360
		}
	
		// Constructors
		static fsPortableReflection() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static bool HasAttribute(MemberInfo element, System.Type attributeType) => default;
		public static bool HasAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default;
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache) => default; // 0x0000000189D6E4F4-0x0000000189D6E5A8
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute => default; // 0x0000000189D6E388-0x0000000189D6E43C
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute => default; // 0x0000000189D6E168-0x0000000189D6E26C
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this System.Type type, string propertyName) => default; // 0x0000000189D6E26C-0x0000000189D6E2D0
		public static MethodInfo GetDeclaredMethod(this System.Type type, string methodName) => default; // 0x0000000189D6E5A8-0x0000000189D6E6A8
		public static ConstructorInfo GetDeclaredConstructor(this System.Type type, System.Type[] parameters) => default; // 0x0000000189D6E43C-0x0000000189D6E498
		public static ConstructorInfo[] GetDeclaredConstructors(this System.Type type) => default; // 0x0000000189D6E498-0x0000000189D6E4F4
		public static MethodInfo GetFlattenedMethod(this System.Type type, string methodName) => default; // 0x0000000189D6E2D0-0x0000000189D6E32C
		public static MethodInfo[] GetDeclaredMethods(this System.Type type) => default; // 0x0000000189D6E32C-0x0000000189D6E388
		public static PropertyInfo[] GetDeclaredProperties(this System.Type type) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static System.Reflection.FieldInfo[] GetDeclaredFields(this System.Type type) => default; // 0x0000000189D6E6FC-0x0000000189D6E810
		public static MemberInfo[] GetDeclaredMembers(this System.Type type) => default; // 0x0000000189D60B08-0x0000000189D60B6C
		public static System.Type Resolve(this System.Type type) => default; // 0x0000000189D60B6C-0x0000000189D60BB8
	}

	public static class fsTypeExtensions // TypeDefIndex: 55620
	{
		// Extension methods
		public static string CSharpName(this System.Type type) => default; // 0x000000018350B670-0x000000018350B680
		public static string CSharpName(this System.Type type, bool includeNamespace) => default; // 0x0000000189D60F10-0x0000000189D60F24
	}

	public struct fsVersionedType // TypeDefIndex: 55621
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public System.Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance) => default; // 0x0000000189D773CC-0x0000000189D77458
		public override string ToString() => default; // 0x0000000189D77458-0x0000000189D77598
		public override bool Equals(object obj) => default; // 0x0000000189D77350-0x0000000189D773CC
		public override int GetHashCode() => default; // 0x0000000186FAB9A8-0x0000000186FAB9CC
	}

	public static class fsVersionManager // TypeDefIndex: 55622
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager() {} // 0x0000000189D772C4-0x0000000189D77350
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path) {
			path = default;
			return default;
		} // 0x0000000189D76818-0x0000000189D76A50
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current) => default; // 0x0000000189D766F0-0x0000000189D76818
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type) => default; // 0x0000000189D76A50-0x0000000189D76ED4
		private static void VerifyConstructors(fsVersionedType type) {} // 0x0000000189D76ED4-0x0000000189D7705C
		private static void VerifyUniqueVersionStrings(fsVersionedType type) {} // 0x0000000189D7705C-0x0000000189D772C4
	}
}
