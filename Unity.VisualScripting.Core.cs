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

// Image 41: Unity.VisualScripting.Core.dll - Assembly: Unity.VisualScripting.Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 86109-86368

namespace Unity.VisualScripting
{
	public abstract class Cloner<T> : ICloner // TypeDefIndex: 86110
	{
		// Constructors
		protected Cloner();
	
		// Methods
		public abstract bool Handles(System.Type type);
		void ICloner.BeforeClone(System.Type type, object original);
		public virtual void BeforeClone(System.Type type, T original);
		object ICloner.ConstructClone(System.Type type, object original);
		public virtual T ConstructClone(System.Type type, T original);
		void ICloner.FillClone(System.Type type, ref object clone, object original, CloningContext context);
		public virtual void FillClone(System.Type type, ref ref T clone, T original, CloningContext context);
		void ICloner.AfterClone(System.Type type, object clone);
		public virtual void AfterClone(System.Type type, T clone);
	}

	public sealed class AnimationCurveCloner : Cloner<AnimationCurve> // TypeDefIndex: 86111
	{
		// Constructors
		public AnimationCurveCloner(); // 0x0000000186AB9970-0x0000000186AB99A0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D479524-0x000000018D479588
		public override AnimationCurve ConstructClone(System.Type type, AnimationCurve original); // 0x000000018D479414-0x000000018D479464
		public override void FillClone(System.Type type, ref AnimationCurve clone, AnimationCurve original, CloningContext context); // 0x000000018D479464-0x000000018D479524
	}

	public sealed class ArrayCloner : Cloner<Array> // TypeDefIndex: 86112
	{
		// Constructors
		public ArrayCloner(); // 0x0000000186AB9940-0x0000000186AB9970
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D479858-0x000000018D479878
		public override Array ConstructClone(System.Type type, Array original); // 0x000000018D47973C-0x000000018D479768
		public override void FillClone(System.Type type, ref Array clone, Array original, CloningContext context); // 0x000000018D479768-0x000000018D479858
	}

	public sealed class DictionaryCloner : Cloner<IDictionary> // TypeDefIndex: 86113
	{
		// Constructors
		public DictionaryCloner(); // 0x0000000186AB9910-0x0000000186AB9940
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D47E07C-0x000000018D47E0F4
		public override void FillClone(System.Type type, ref IDictionary clone, IDictionary original, CloningContext context); // 0x000000018D47DF90-0x000000018D47E07C
	}

	public sealed class EnumerableCloner : Cloner<IEnumerable> // TypeDefIndex: 86114
	{
		// Fields
		private readonly Dictionary<System.Type, IOptimizedInvoker> addMethods; // 0x10
	
		// Constructors
		public EnumerableCloner(); // 0x0000000186AB9A10-0x0000000186AB9AA0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D47E8F8-0x000000018D47E9DC
		public override void FillClone(System.Type type, ref IEnumerable clone, IEnumerable original, CloningContext context); // 0x000000018D47E4E4-0x000000018D47E6FC
		private IOptimizedInvoker GetAddMethod(System.Type type); // 0x000000018D47E6FC-0x000000018D47E8F8
	}

	public sealed class FakeSerializationCloner : ReflectedCloner // TypeDefIndex: 86116
	{
		// Fields
		[CompilerGenerated]
		private fsConfig _config_k__BackingField; // 0x20
	
		// Properties
		public fsConfig config { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86115
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsMetaProperty, MemberInfo> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D492C74-0x000000018D492CD8
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal MemberInfo _GetMembers_b__6_0(fsMetaProperty p); // 0x0000000188E4BE44-0x0000000188E4BE5C
		}
	
		// Constructors
		public FakeSerializationCloner(); // 0x0000000186AB99A0-0x0000000186AB9A10
	
		// Methods
		public override void BeforeClone(System.Type type, object original); // 0x000000018D47F620-0x000000018D47F66C
		public override void AfterClone(System.Type type, object clone); // 0x000000018D47F5D8-0x000000018D47F620
		protected override IEnumerable<MemberInfo> GetMembers(System.Type type); // 0x000000018D47F66C-0x000000018D47F7AC
	}

	public sealed class FieldsCloner : ReflectedCloner // TypeDefIndex: 86117
	{
		// Constructors
		public FieldsCloner(); // 0x000000018783CEC8-0x000000018783CED0
	
		// Methods
		protected override bool IncludeField(System.Reflection.FieldInfo field); // 0x00000001851A4410-0x00000001851A4420
		protected override bool IncludeProperty(PropertyInfo property); // 0x00000001843FFFF0-0x0000000184400000
	}

	internal sealed class GradientCloner : Cloner<Gradient> // TypeDefIndex: 86118
	{
		// Constructors
		public GradientCloner(); // 0x0000000186AB98E0-0x0000000186AB9910
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D47F87C-0x000000018D47F8E0
		public override Gradient ConstructClone(System.Type type, Gradient original); // 0x000000018D47F7AC-0x000000018D47F7FC
		public override void FillClone(System.Type type, ref Gradient clone, Gradient original, CloningContext context); // 0x000000018D47F7FC-0x000000018D47F87C
	}

	public sealed class ListCloner : Cloner<IList> // TypeDefIndex: 86119
	{
		// Constructors
		public ListCloner(); // 0x0000000186AB98B0-0x0000000186AB98E0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D483218-0x000000018D483290
		public override void FillClone(System.Type type, ref IList clone, IList original, CloningContext context); // 0x000000018D483070-0x000000018D483218
	}

	public abstract class ReflectedCloner : Cloner<object> // TypeDefIndex: 86120
	{
		// Fields
		private readonly Dictionary<System.Type, MemberInfo[]> accessors; // 0x10
		private readonly Dictionary<System.Type, IOptimizedAccessor[]> optimizedAccessors; // 0x18
	
		// Constructors
		protected ReflectedCloner(); // 0x0000000186AB9AA0-0x0000000186AB9B70
	
		// Methods
		public override bool Handles(System.Type type); // 0x00000001843FFFF0-0x0000000184400000
		public override void FillClone(System.Type type, ref object clone, object original, CloningContext context); // 0x000000018D488898-0x000000018D488C2C
		private MemberInfo[] GetAccessors(System.Type type); // 0x000000018D488C2C-0x000000018D488D08
		private IOptimizedAccessor[] GetOptimizedAccessors(System.Type type); // 0x000000018D488EBC-0x000000018D4891F4
		protected virtual IEnumerable<MemberInfo> GetMembers(System.Type type); // 0x000000018D488D08-0x000000018D488EBC
		protected virtual bool IncludeField(System.Reflection.FieldInfo field); // 0x00000001843FFFF0-0x0000000184400000
		protected virtual bool IncludeProperty(PropertyInfo property); // 0x00000001843FFFF0-0x0000000184400000
	}

	public static class Cloning // TypeDefIndex: 86122
	{
		// Fields
		private static readonly Dictionary<System.Type, bool> skippable; // 0x00
		[CompilerGenerated]
		private static readonly HashSet<ICloner> _cloners_k__BackingField; // 0x08
		[CompilerGenerated]
		private static readonly ArrayCloner _arrayCloner_k__BackingField; // 0x10
		[CompilerGenerated]
		private static readonly DictionaryCloner _dictionaryCloner_k__BackingField; // 0x18
		[CompilerGenerated]
		private static readonly EnumerableCloner _enumerableCloner_k__BackingField; // 0x20
		[CompilerGenerated]
		private static readonly ListCloner _listCloner_k__BackingField; // 0x28
		[CompilerGenerated]
		private static readonly AnimationCurveCloner _animationCurveCloner_k__BackingField; // 0x30
		[CompilerGenerated]
		private static readonly GradientCloner _gradientCloner_k__BackingField; // 0x38
		[CompilerGenerated]
		private static readonly FieldsCloner _fieldsCloner_k__BackingField; // 0x40
		[CompilerGenerated]
		private static readonly FakeSerializationCloner _fakeSerializationCloner_k__BackingField; // 0x48
	
		// Properties
		public static HashSet<ICloner> cloners { [CompilerGenerated] get; } // 0x000000018D47A2D4-0x000000018D47A324 
		public static ArrayCloner arrayCloner { [CompilerGenerated] get; } // 0x000000018D47A284-0x000000018D47A2D4 
		public static DictionaryCloner dictionaryCloner { [CompilerGenerated] get; } // 0x000000018D47A324-0x000000018D47A374 
		public static EnumerableCloner enumerableCloner { [CompilerGenerated] get; } // 0x000000018D47A374-0x000000018D47A3C4 
		public static ListCloner listCloner { [CompilerGenerated] get; } // 0x000000018D47A464-0x000000018D47A4B4 
		public static AnimationCurveCloner animationCurveCloner { [CompilerGenerated] get; } // 0x000000018D47A234-0x000000018D47A284 
		internal static GradientCloner gradientCloner { [CompilerGenerated] get; } // 0x000000018D47A414-0x000000018D47A464 
		public static FakeSerializationCloner fakeSerializationCloner { [CompilerGenerated] get; } // 0x000000018D47A3C4-0x000000018D47A414 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0 // TypeDefIndex: 86121
		{
			// Fields
			public System.Type type; // 0x10
	
			// Constructors
			public __c__DisplayClass35_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetCloner_b__0(ICloner cloner); // 0x000000018D4928CC-0x000000018D4929B8
		}
	
		// Constructors
		static Cloning(); // 0x0000000186AB9230-0x0000000186AB98B0
	
		// Methods
		internal static object Clone(CloningContext context, object original); // 0x0000000185BEB4C0-0x0000000185BEB530
		internal static void CloneInto(CloningContext context, ref object clone, object original); // 0x0000000185BEB8A0-0x0000000185BEBB10
		[CanBeNull]
		public static ICloner GetCloner(object original, System.Type type); // 0x0000000185BEBBB0-0x0000000185BEBCD0
		private static ICloner GetCloner(object original, System.Type type, ICloner fallbackCloner); // 0x0000000185BEBB10-0x0000000185BEBBB0
		private static bool Skippable(System.Type type); // 0x0000000185BEB6A0-0x0000000185BEB8A0
	
		// Extension methods
		public static object Clone(this object original, ICloner fallbackCloner, bool tryPreserveInstances); // 0x0000000185BEB3C0-0x0000000185BEB4C0
		public static object CloneViaFakeSerialization(this object original); // 0x0000000185BEB330-0x0000000185BEB3C0
		public static T CloneViaFakeSerialization<T>(this T original);
	}

	public sealed class CloningContext : IPoolable, IDisposable // TypeDefIndex: 86124
	{
		// Fields
		[CompilerGenerated]
		private readonly Dictionary<object, object> _clonings_k__BackingField; // 0x10
		[CompilerGenerated]
		private ICloner _fallbackCloner_k__BackingField; // 0x18
		[CompilerGenerated]
		private bool _tryPreserveInstances_k__BackingField; // 0x20
		private bool disposed; // 0x21
	
		// Properties
		public Dictionary<object, object> clonings { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public ICloner fallbackCloner { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool tryPreserveInstances { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182246E50-0x0000000182246E60 0x0000000182246E60-0x0000000182246E70
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86123
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<CloningContext> __9__15_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5B40-0x00000001871E5BA0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal CloningContext _New_b__15_0(); // 0x0000000185BEF290-0x0000000185BEF2E0
		}
	
		// Constructors
		public CloningContext(); // 0x0000000185BEF1D0-0x0000000185BEF290
	
		// Methods
		void IPoolable.New(); // 0x0000000187233040-0x0000000187233050
		void IPoolable.Free(); // 0x0000000185D7F9D0-0x0000000185D7FAD0
		public void Dispose(); // 0x00000001871216C0-0x0000000187121730
		public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances); // 0x0000000185BEB530-0x0000000185BEB6A0
	}

	public interface ICloner // TypeDefIndex: 86125
	{
		// Methods
		bool Handles(System.Type type);
		object ConstructClone(System.Type type, object original);
		void BeforeClone(System.Type type, object original);
		void FillClone(System.Type type, ref object clone, object original, CloningContext context);
		void AfterClone(System.Type type, object clone);
	}

	public interface ISpecifiesCloner // TypeDefIndex: 86126
	{
		// Properties
		ICloner cloner { get; }
	}

	public sealed class AotDictionary : OrderedDictionary // TypeDefIndex: 86127
	{
		// Constructors
		public AotDictionary(); // 0x000000018D18B538-0x000000018D18B54C
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs(); // 0x000000018D479588-0x000000018D479630
	}

	public sealed class AotList : ArrayList // TypeDefIndex: 86128
	{
		// Constructors
		public AotList(); // 0x000000018D13873C-0x000000018D138744
	
		// Methods
		[UnityEngine.Scripting.Preserve]
		public static void AotStubs(); // 0x000000018D479630-0x000000018D4796E8
	}

	public class GuidCollection<T> : KeyedCollection<Guid, T>, ICollection<T> // TypeDefIndex: 86129
		where T : IIdentifiable
	{
		// Methods
		protected override Guid GetKeyForItem(T item);
	}

	public interface IKeyedCollection<TKey, TItem> : ICollection<TItem> // TypeDefIndex: 86130
	{
		// Properties
		TItem this[TKey key] { get => default; }
		TItem this[int index] { get => default; }
	
		// Methods
		bool Contains(TKey key);
	}

	[DefaultMember("Item")]
	public class MergedKeyedCollection<TKey, TItem> : IEnumerable<TItem> // TypeDefIndex: 86132
	{
		// Fields
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collections;
		protected readonly Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsLookup;
	
		// Nested types
		public struct Enumerator : IEnumerator<TItem> // TypeDefIndex: 86131
		{
			// Fields
			private Dictionary<System.Type, IKeyedCollection<TKey, TItem>> collectionsEnumerator;
			private TItem currentItem;
			private IKeyedCollection<TKey, TItem> currentCollection;
			private int indexInCurrentCollection;
			private bool exceeded;
	
			// Properties
			public TItem Current { get; }
			object IEnumerator.Current { get; }
	
			// Constructors
			public Enumerator(MergedKeyedCollection<TKey, TItem> merged);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			void IEnumerator.Reset();
		}
	
		// Methods
		protected IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item);
		protected IKeyedCollection<TKey, TItem> GetCollectionForType(System.Type type, bool throwOnFail = true /* Metadata: 0x02645473 */);
		public virtual void Add(TItem item);
		public void Clear();
		public bool Contains(TItem item);
		IEnumerator IEnumerable.GetEnumerator();
		IEnumerator<TItem> IEnumerable<TItem>.GetEnumerator();
		public Enumerator GetEnumerator();
	}

	public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> // TypeDefIndex: 86133
		where TConnection : IConnection<TSource, TDestination>
	{
		// Constructors
		public ConnectionCollection();
	}

	[DefaultMember("Item")]
	public class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : IConnectionCollection<TConnection, TSource, TDestination> // TypeDefIndex: 86134
		where TConnection : IConnection<TSource, TDestination>
		where TCollection : ICollection<TConnection>
	{
		// Fields
		private readonly Dictionary<TDestination, List<TConnection>> byDestination;
		private readonly Dictionary<TSource, List<TConnection>> bySource;
		protected readonly TCollection collection;
	
		// Properties
		public int Count { get; }
		public bool IsReadOnly { get; }
	
		// Constructors
		public ConnectionCollectionBase(TCollection collection);
	
		// Methods
		public IEnumerator<TConnection> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		public IEnumerable<TConnection> WithSource(TSource source);
		public List<TConnection> WithSourceNoAlloc(TSource source);
		public TConnection SingleOrDefaultWithSource(TSource source);
		public IEnumerable<TConnection> WithDestination(TDestination destination);
		public List<TConnection> WithDestinationNoAlloc(TDestination destination);
		public TConnection SingleOrDefaultWithDestination(TDestination destination);
		public void Add(TConnection item);
		public void Clear();
		public bool Contains(TConnection item);
		public void CopyTo(TConnection[] array, int arrayIndex);
		public bool Remove(TConnection item);
		protected virtual void BeforeAdd(TConnection item);
		protected virtual void AfterAdd(TConnection item);
		protected virtual void BeforeRemove(TConnection item);
		protected virtual void AfterRemove(TConnection item);
		private void AddToDictionaries(TConnection item);
		private void RemoveFromDictionaries(TConnection item);
	}

	public class GraphConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, GraphElementCollection<TConnection>>, ICollection<TConnection> // TypeDefIndex: 86135
		where TConnection : IConnection<TSource, TDestination>, IGraphElement
	{
	}

	public interface IConnection<out TSource, out TDestination> // TypeDefIndex: 86136
	{
		// Properties
		TSource source { get; }
		TDestination destination { get; }
	}

	[DefaultMember("Item")]
	public interface IConnectionCollection<TConnection, TSource, TDestination> : ICollection<TConnection> // TypeDefIndex: 86137
		where TConnection : IConnection<TSource, TDestination>
	{
	}

	public class InvalidConnectionException : Exception // TypeDefIndex: 86138
	{
		// Constructors
		public InvalidConnectionException(); // 0x000000018D482B7C-0x000000018D482BD0
		public InvalidConnectionException(string message); // 0x000000018D482BD0-0x000000018D482C2C
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ValueAttribute : Attribute // TypeDefIndex: 86139
	{
		// Constructors
		public ValueAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	public class DisableAnnotationAttribute : Attribute // TypeDefIndex: 86140
	{
		// Fields
		[CompilerGenerated]
		private bool _disableIcon_k__BackingField; // 0x10
	
		// Constructors
		public DisableAnnotationAttribute(); // 0x00000001829D07F0-0x00000001829D0800
	}

	public static class EditorTimeBinding // TypeDefIndex: 86142
	{
		// Fields
		public static Func<int> frameBinding; // 0x00
		public static Func<float> timeBinding; // 0x08
	
		// Properties
		public static int frame { get; } // 0x000000018D47E238-0x000000018D47E2D8 
		public static float time { get; } // 0x000000018D47E2D8-0x000000018D47E378 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86141
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D492CD8-0x000000018D492D3C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal int _.cctor_b__6_0(); // 0x000000018D492540-0x000000018D492548
			internal float _.cctor_b__6_1(); // 0x000000018D492548-0x000000018D492550
		}
	
		// Constructors
		static EditorTimeBinding(); // 0x000000018D47E0F4-0x000000018D47E238
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
	public sealed class IncludeInSettingsAttribute : Attribute // TypeDefIndex: 86143
	{
		// Fields
		[CompilerGenerated]
		private bool _include_k__BackingField; // 0x10
	
		// Properties
		private bool include { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public IncludeInSettingsAttribute(bool include); // 0x0000000182A819C0-0x0000000182A819D0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class InspectableAttribute : Attribute // TypeDefIndex: 86144
	{
		// Constructors
		public InspectableAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorWideAttribute : Attribute // TypeDefIndex: 86145
	{
		// Fields
		[CompilerGenerated]
		private bool _toEdge_k__BackingField; // 0x10
	
		// Properties
		private bool toEdge { [CompilerGenerated] set; } // 0x0000000182A819C0-0x0000000182A819D0
	
		// Constructors
		public InspectorWideAttribute(bool toEdge); // 0x0000000182A819C0-0x0000000182A819D0
	}

	public static class Ensure // TypeDefIndex: 86146
	{
		// Fields
		private static readonly EnsureThat instance; // 0x00
		[CompilerGenerated]
		private static bool _IsActive_k__BackingField; // 0x08
	
		// Properties
		public static bool IsActive { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D47E440-0x000000018D47E490 0x000000018D47E490-0x000000018D47E4E4
	
		// Constructors
		static Ensure(); // 0x00000001871CA690-0x00000001871CA700
	
		// Methods
		public static EnsureThat That(string paramName); // 0x00000001861B1C60-0x00000001861B1CE0
		internal static void OnRuntimeMethodLoad(); // 0x00000001861B3DE0-0x00000001861B3EB0
	}

	public class EnsureThat // TypeDefIndex: 86147
	{
		// Fields
		internal string paramName; // 0x10
	
		// Constructors
		public EnsureThat(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void IsNotNull<T>([NoEnumeration] T value);
		public void IsNotNull(string value); // 0x000000018D47E378-0x000000018D47E440
		public void IsOfType<T>(T param, System.Type expectedType);
	}

	public static class ExceptionMessages // TypeDefIndex: 86148
	{
		// Fields
		[CompilerGenerated]
		private static readonly string _Common_IsNull_Failed_k__BackingField; // 0x00
		[CompilerGenerated]
		private static readonly string _Common_IsNotNull_Failed_k__BackingField; // 0x08
		[CompilerGenerated]
		private static readonly string _Booleans_IsTrueFailed_k__BackingField; // 0x10
		[CompilerGenerated]
		private static readonly string _Booleans_IsFalseFailed_k__BackingField; // 0x18
		[CompilerGenerated]
		private static readonly string _Collections_Any_Failed_k__BackingField; // 0x20
		[CompilerGenerated]
		private static readonly string _Collections_ContainsKey_Failed_k__BackingField; // 0x28
		[CompilerGenerated]
		private static readonly string _Collections_HasItemsFailed_k__BackingField; // 0x30
		[CompilerGenerated]
		private static readonly string _Collections_HasNoNullItemFailed_k__BackingField; // 0x38
		[CompilerGenerated]
		private static readonly string _Collections_SizeIs_Failed_k__BackingField; // 0x40
		[CompilerGenerated]
		private static readonly string _Comp_Is_Failed_k__BackingField; // 0x48
		[CompilerGenerated]
		private static readonly string _Comp_IsNot_Failed_k__BackingField; // 0x50
		[CompilerGenerated]
		private static readonly string _Comp_IsNotLt_k__BackingField; // 0x58
		[CompilerGenerated]
		private static readonly string _Comp_IsNotLte_k__BackingField; // 0x60
		[CompilerGenerated]
		private static readonly string _Comp_IsNotGt_k__BackingField; // 0x68
		[CompilerGenerated]
		private static readonly string _Comp_IsNotGte_k__BackingField; // 0x70
		[CompilerGenerated]
		private static readonly string _Comp_IsNotInRange_ToLow_k__BackingField; // 0x78
		[CompilerGenerated]
		private static readonly string _Comp_IsNotInRange_ToHigh_k__BackingField; // 0x80
		[CompilerGenerated]
		private static readonly string _Guids_IsNotEmpty_Failed_k__BackingField; // 0x88
		[CompilerGenerated]
		private static readonly string _Strings_IsEqualTo_Failed_k__BackingField; // 0x90
		[CompilerGenerated]
		private static readonly string _Strings_IsNotEqualTo_Failed_k__BackingField; // 0x98
		[CompilerGenerated]
		private static readonly string _Strings_SizeIs_Failed_k__BackingField; // 0xA0
		[CompilerGenerated]
		private static readonly string _Strings_IsNotNullOrWhiteSpace_Failed_k__BackingField; // 0xA8
		[CompilerGenerated]
		private static readonly string _Strings_IsNotNullOrEmpty_Failed_k__BackingField; // 0xB0
		[CompilerGenerated]
		private static readonly string _Strings_HasLengthBetween_Failed_ToShort_k__BackingField; // 0xB8
		[CompilerGenerated]
		private static readonly string _Strings_HasLengthBetween_Failed_ToLong_k__BackingField; // 0xC0
		[CompilerGenerated]
		private static readonly string _Strings_Matches_Failed_k__BackingField; // 0xC8
		[CompilerGenerated]
		private static readonly string _Strings_IsNotEmpty_Failed_k__BackingField; // 0xD0
		[CompilerGenerated]
		private static readonly string _Strings_IsGuid_Failed_k__BackingField; // 0xD8
		[CompilerGenerated]
		private static readonly string _Types_IsOfType_Failed_k__BackingField; // 0xE0
		[CompilerGenerated]
		private static readonly string _Reflection_HasAttribute_Failed_k__BackingField; // 0xE8
		[CompilerGenerated]
		private static readonly string _Reflection_HasConstructor_Failed_k__BackingField; // 0xF0
		[CompilerGenerated]
		private static readonly string _Reflection_HasPublicConstructor_Failed_k__BackingField; // 0xF8
		[CompilerGenerated]
		private static readonly string _ValueTypes_IsNotDefault_Failed_k__BackingField; // 0x100
	
		// Properties
		public static string Common_IsNotNull_Failed { [CompilerGenerated] get; } // 0x000000018D47F208-0x000000018D47F258 
		public static string Types_IsOfType_Failed { [CompilerGenerated] get; } // 0x000000018D47F258-0x000000018D47F2AC 
	
		// Constructors
		static ExceptionMessages(); // 0x000000018D47E9DC-0x000000018D47F208
	}

	internal static class XString // TypeDefIndex: 86150
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86149
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, object> __9__1_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D492A1C-0x000000018D492A80
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal object _Inject_b__1_0(string a); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Extension methods
		internal static string Inject(this string format, params string[] formattingArgs); // 0x000000018D4935E4-0x000000018D493720
	}

	public struct EmptyEventArgs // TypeDefIndex: 86151
	{
	}

	public class InvalidConversionException : InvalidCastException // TypeDefIndex: 86152
	{
		// Constructors
		public InvalidConversionException(); // 0x000000018D482C2C-0x000000018D482C34
		public InvalidConversionException(string message); // 0x000000018C9FF378-0x000000018C9FF398
		public InvalidConversionException(string message, Exception innerException); // 0x000000018D482C34-0x000000018D482C3C
	}

	public class InvalidImplementationException : Exception // TypeDefIndex: 86153
	{
		// Constructors
		public InvalidImplementationException(string message); // 0x000000018D482C3C-0x000000018D482C98
	}

	public class UnexpectedEnumValueException<T> : Exception // TypeDefIndex: 86154
	{
		// Fields
		[CompilerGenerated]
		private T _Value_k__BackingField;
	
		// Properties
		private T Value { [CompilerGenerated] set; }
	
		// Constructors
		public UnexpectedEnumValueException(T value);
	}

	public abstract class Graph : IGraph // TypeDefIndex: 86156
	{
		// Fields
		[SerializeAs("elements")]
		private List<IGraphElement> _elements; // 0x10
		[CompilerGenerated]
		private readonly MergedGraphElementCollection _elements_k__BackingField; // 0x18
	
		// Properties
		[DoNotSerialize]
		public MergedGraphElementCollection elements { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public IEnumerable<ISerializationDependency> deserializationDependencies { get; } // 0x000000018D48263C-0x000000018D482744 
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86155
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<IGraphElement, IEnumerable<ISerializationDependency>> __9__27_0; // 0x08
			public static Comparison<IGraphElement> __9__30_0; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D492B48-0x000000018D492BAC
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal IEnumerable<ISerializationDependency> _get_deserializationDependencies_b__27_0(IGraphElement e); // 0x000000018D492658-0x000000018D492674
			internal int _OnAfterDependenciesDeserialized_b__30_0(IGraphElement a, IGraphElement b); // 0x000000018D49236C-0x000000018D4923B0
		}
	
		// Methods
		public virtual void OnBeforeSerialize(); // 0x000000018D4825D0-0x000000018D48263C
		public void OnAfterDeserialize(); // 0x000000018D482584-0x000000018D4825D0
		public virtual void OnAfterDependenciesDeserialized(); // 0x000000018D482088-0x000000018D482584
		public virtual void Dispose(); // 0x000000018D481F28-0x000000018D482088
	}

	public abstract class GraphElement<TGraph> : IGraphElement // TypeDefIndex: 86157
		where TGraph : class, IGraph
	{
		// Fields
		[CompilerGenerated]
		private Guid _guid_k__BackingField;
		[CompilerGenerated]
		private TGraph _graph_k__BackingField;
	
		// Properties
		[Serialize]
		public Guid guid { [CompilerGenerated] get; }
		[DoNotSerialize]
		public virtual int dependencyOrder { get; }
		[DoNotSerialize]
		public TGraph graph { [CompilerGenerated] get; }
		public virtual IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Constructors
		protected GraphElement();
	
		// Methods
		public virtual void Dispose();
		public virtual bool HandleDependencies();
		public override string ToString();
	}

	public sealed class GraphElementCollection<TElement> : GuidCollection<TElement>, IKeyedCollection<Guid, TElement> // TypeDefIndex: 86158
		where TElement : IGraphElement
	{
		// Properties
		TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.this[Guid key] { get => default; }
	
		// Methods
		bool IKeyedCollection<Guid, TElement>.Contains(Guid key);
	}

	public abstract class GraphPointer // TypeDefIndex: 86159
	{
		// Fields
		[CompilerGenerated]
		private IGraphRoot _root_k__BackingField; // 0x10
		[CompilerGenerated]
		private GameObject _gameObject_k__BackingField; // 0x18
		protected readonly List<IGraphParent> parentStack; // 0x20
		protected readonly List<IGraphParentElement> parentElementStack; // 0x28
		protected readonly List<IGraph> graphStack; // 0x30
		protected readonly List<IGraphData> dataStack; // 0x38
		protected readonly List<IGraphDebugData> debugDataStack; // 0x40
	
		// Properties
		public IGraphRoot root { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public UnityEngine.Object rootObject { get; } // 0x000000018D480EEC-0x000000018D480F28 
		public GameObject gameObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public GameObject self { get; } // 0x0000000182234E30-0x0000000182234E40 
		public UnityEngine.Object serializedObject { get; } // 0x000000018D480F28-0x000000018D48102C 
		public int depth { get; } // 0x000000018D480A74-0x000000018D480AB4 
		public bool isRoot { get; } // 0x000000018D480AE4-0x000000018D480AFC 
		public bool isChild { get; } // 0x000000018D480ACC-0x000000018D480AE4 
		public IGraphParent parent { get; } // 0x000000018D480E48-0x000000018D480EA4 
		public IGraphParentElement parentElement { get; } // 0x000000018D480DE4-0x000000018D480E48 
		public IGraph rootGraph { get; } // 0x000000018D480EA4-0x000000018D480EEC 
		public bool hasDebugData { get; } // 0x000000018D480AB4-0x000000018D480ACC 
		protected IGraphDebugData _debugData { get; } // 0x000000018D4809F8-0x000000018D480A54 
		public IGraphDebugData debugData { get; } // 0x000000018D480A54-0x000000018D480A74 
		public bool isValid { get; } // 0x000000018D480AFC-0x000000018D480DE4 
	
		// Constructors
		internal GraphPointer(); // 0x000000018D480854-0x000000018D4809F8
	
		// Methods
		public abstract GraphReference AsReference();
		public virtual void CopyFrom(GraphPointer other); // 0x000000018D47FAFC-0x000000018D480254
		public void EnsureChild(); // 0x000000018D48033C-0x000000018D4803B8
		public void EnsureDebugDataAvailable(); // 0x000000018D4803B8-0x000000018D480434
		public T GetElementDebugData<T>(IGraphElementWithDebugData element);
		protected void ExitParentElement(); // 0x000000018D480434-0x000000018D4805DC
		public bool InstanceEquals(GraphPointer other); // 0x000000018D4805DC-0x000000018D4806DC
		public bool DefinitionEquals(GraphPointer other); // 0x000000018D480254-0x000000018D48033C
		public int ComputeHashCode(); // 0x000000018D47F9A4-0x000000018D47FAFC
		public override string ToString(); // 0x000000018D4806DC-0x000000018D480854
	}

	public sealed class GraphPointerException : Exception // TypeDefIndex: 86160
	{
		// Fields
		[CompilerGenerated]
		private readonly GraphPointer _pointer_k__BackingField; // 0x90
	
		// Constructors
		public GraphPointerException(string message, GraphPointer pointer); // 0x000000018D47F8E0-0x000000018D47F9A4
	}

	public sealed class GraphReference : GraphPointer // TypeDefIndex: 86161
	{
		// Fields
		[DoNotSerialize]
		private int hashCode; // 0x48
		private static readonly Dictionary<int, List<GraphReference>> internPool; // 0x00
	
		// Constructors
		static GraphReference(); // 0x000000018D481B94-0x000000018D481C6C
		private GraphReference(); // 0x000000018D481C6C-0x000000018D481C74
	
		// Methods
		private static GraphReference New(GraphPointer model); // 0x000000018D481A74-0x000000018D481ADC
		public override void CopyFrom(GraphPointer other); // 0x000000018D481078-0x000000018D4810E0
		public GraphReference Clone(); // 0x000000018D48102C-0x000000018D481078
		public override GraphReference AsReference(); // 0x0000000185BD80B0-0x0000000185BD80C0
		public GraphStack ToStackPooled(); // 0x000000018D481B8C-0x000000018D481B94
		public override bool Equals(object obj); // 0x000000018D4810E0-0x000000018D48113C
		private void Hash(); // 0x000000018D481770-0x000000018D48178C
		public override int GetHashCode(); // 0x00000001872330A0-0x00000001872330B0
		public GraphReference ParentReference(bool ensureValid); // 0x000000018D481ADC-0x000000018D481B8C
		public static GraphReference Intern(GraphPointer pointer); // 0x000000018D48178C-0x000000018D481A74
		public static void FreeInvalidInterns(); // 0x000000018D48113C-0x000000018D481770
	}

	public static class GraphsExceptionUtility // TypeDefIndex: 86162
	{
		// Extension methods
		public static void SetException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex); // 0x000000018D482AD4-0x000000018D482B7C
		public static void HandleException(this IGraphElementWithDebugData element, GraphPointer pointer, Exception ex); // 0x000000018D482744-0x000000018D482910
		private static bool HandledIn(this Exception ex, GraphReference reference); // 0x000000018D482910-0x000000018D482AD4
	}

	public sealed class GraphStack : GraphPointer, IPoolable, IDisposable // TypeDefIndex: 86164
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86163
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<GraphStack> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D492AE4-0x000000018D492B48
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal GraphStack _New_b__3_0(); // 0x000000018D49231C-0x000000018D49236C
		}
	
		// Constructors
		private GraphStack(); // 0x000000018D481C6C-0x000000018D481C74
	
		// Methods
		internal static GraphStack New(GraphPointer model); // 0x000000018D481CD0-0x000000018D481E00
		public void Dispose(); // 0x000000018D481C7C-0x000000018D481CD0
		void IPoolable.New(); // 0x0000000186805BA0-0x0000000186805BB0
		void IPoolable.Free(); // 0x000000018D481E4C-0x000000018D481F28
		public override GraphReference AsReference(); // 0x000000018D481C74-0x000000018D481C7C
		public GraphReference ToReference(); // 0x000000018D481E00-0x000000018D481E4C
	}

	public interface IGraph : IDisposable, ISerializationDepender // TypeDefIndex: 86165
	{
		// Properties
		MergedGraphElementCollection elements { get; }
	}

	public interface IGraphData // TypeDefIndex: 86166
	{
	}

	public interface IGraphDebugData // TypeDefIndex: 86167
	{
		// Methods
		IGraphElementDebugData GetOrCreateElementData(IGraphElementWithDebugData element);
	}

	public interface IGraphElement : IDisposable, IIdentifiable // TypeDefIndex: 86168
	{
		// Properties
		int dependencyOrder { get; }
		Guid guid { get; }
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		bool HandleDependencies();
	}

	public interface IGraphElementDebugData // TypeDefIndex: 86169
	{
		// Properties
		Exception runtimeException { set; }
	}

	public interface IGraphElementWithDebugData : IGraphElement // TypeDefIndex: 86170
	{
	}

	public interface IGraphParent // TypeDefIndex: 86171
	{
		// Properties
		IGraph childGraph { get; }
		bool isSerializationRoot { get; }
		UnityEngine.Object serializedObject { get; }
	}

	public interface IGraphParentElement : IGraphElement, IGraphParent // TypeDefIndex: 86172
	{
	}

	public interface IGraphRoot : IGraphParent // TypeDefIndex: 86173
	{
	}

	public sealed class MergedGraphElementCollection : MergedKeyedCollection<Guid, IGraphElement> // TypeDefIndex: 86174
	{
	}

	public static class PlatformUtility // TypeDefIndex: 86175
	{
		// Fields
		public static readonly bool supportsJit; // 0x00
	
		// Constructors
		static PlatformUtility(); // 0x000000018721FDF0-0x000000018721FE30
	
		// Methods
		private static bool CheckJitSupport(); // 0x00000001843FFFF0-0x0000000184400000
	}

	public static class GenericPool<T> // TypeDefIndex: 86176
		where T : class, IPoolable
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<T> free;
		private static readonly HashSet<T> busy;
	
		// Constructors
		static GenericPool();
	
		// Methods
		public static T New(Func<T> constructor);
		public static void Free(T item);
	}

	public interface IPoolable // TypeDefIndex: 86177
	{
		// Methods
		void New();
		void Free();
	}

	public static class ListPool<T> // TypeDefIndex: 86178
	{
		// Fields
		private static readonly object @lock;
		private static readonly Stack<List<T>> free;
		private static readonly HashSet<List<T>> busy;
	
		// Constructors
		static ListPool();
	
		// Methods
		public static List<T> New();
		public static void Free(List<T> list);
	}

	public static class XListPool // TypeDefIndex: 86179
	{
		// Extension methods
		public static void Free<T>(this List<T> list);
	}

	public class ProfiledSegment // TypeDefIndex: 86180
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private Stopwatch _stopwatch_k__BackingField; // 0x18
		[CompilerGenerated]
		private ProfiledSegment _parent_k__BackingField; // 0x20
		[CompilerGenerated]
		private ProfiledSegmentCollection _children_k__BackingField; // 0x28
	
		// Properties
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		private Stopwatch stopwatch { [CompilerGenerated] set; } // 0x0000000187835500-0x0000000187835510
		private ProfiledSegment parent { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
		private ProfiledSegmentCollection children { [CompilerGenerated] set; } // 0x0000000185CA30F0-0x0000000185CA3100
	
		// Constructors
		public ProfiledSegment(ProfiledSegment parent, string name); // 0x000000018D487CD0-0x000000018D487D88
	}

	public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment> // TypeDefIndex: 86181
	{
		// Constructors
		public ProfiledSegmentCollection(); // 0x000000018D487C94-0x000000018D487CD0
	
		// Methods
		protected override string GetKeyForItem(ProfiledSegment item); // 0x0000000188E4BE44-0x0000000188E4BE5C
	}

	public struct ProfilingScope : IDisposable // TypeDefIndex: 86182
	{
		// Constructors
		public ProfilingScope(string name); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class ProfilingUtility // TypeDefIndex: 86183
	{
		// Fields
		private static readonly object @lock; // 0x00
		[CompilerGenerated]
		private static ProfiledSegment _rootSegment_k__BackingField; // 0x08
		[CompilerGenerated]
		private static ProfiledSegment _currentSegment_k__BackingField; // 0x10
	
		// Properties
		private static ProfiledSegment rootSegment { [CompilerGenerated] set; } // 0x000000018D487F40-0x000000018D487FA0
		public static ProfiledSegment currentSegment { [CompilerGenerated] set; } // 0x000000018D487EE0-0x000000018D487F40
	
		// Constructors
		static ProfilingUtility(); // 0x000000018D487D88-0x000000018D487EE0
	
		// Methods
		public static ProfilingScope SampleBlock(string name); // 0x00000001843FFFF0-0x0000000184400000
	}

	public enum ActionDirection // TypeDefIndex: 86184
	{
		Any = 0,
		Get = 1,
		Set = 2
	}

	public static class AttributeUtility // TypeDefIndex: 86186
	{
		// Fields
		private static readonly Dictionary<object, AttributeCache> optimizedCaches; // 0x00
	
		// Nested types
		private class AttributeCache // TypeDefIndex: 86185
		{
			// Fields
			[CompilerGenerated]
			private readonly List<Attribute> _inheritedAttributes_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly List<Attribute> _definedAttributes_k__BackingField; // 0x18
	
			// Properties
			public List<Attribute> inheritedAttributes { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
			public List<Attribute> definedAttributes { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			public AttributeCache(MemberInfo element); // 0x000000018D479A70-0x000000018D479F6C
	
			// Methods
			private void Cache(Attribute[] attributeObjects, List<Attribute> cache); // 0x000000018D479878-0x000000018D479900
			private bool HasAttribute(System.Type attributeType, List<Attribute> cache); // 0x000000018D4799DC-0x000000018D479A70
			private Attribute GetAttribute(System.Type attributeType, List<Attribute> cache); // 0x000000018D47991C-0x000000018D4799C0
			public bool HasAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x02645479 */); // 0x000000018D4799C0-0x000000018D4799DC
			public Attribute GetAttribute(System.Type attributeType, bool inherit = true /* Metadata: 0x0264547A */); // 0x000000018D479900-0x000000018D47991C
			public bool HasAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0264547B */)
				where TAttribute : Attribute;
			public TAttribute GetAttribute<TAttribute>(bool inherit = true /* Metadata: 0x0264547C */)
				where TAttribute : Attribute;
		}
	
		// Constructors
		static AttributeUtility(); // 0x000000018D47A1A8-0x000000018D47A234
	
		// Methods
		private static AttributeCache GetAttributeCache(MemberInfo element); // 0x000000018D479F6C-0x000000018D47A1A8
	
		// Extension methods
		internal static IEnumerable<T> GetAttributeOfEnumMember<T>(this Enum enumVal)
			where T : Attribute;
		public static bool HasAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x02645477 */)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(this MemberInfo element, bool inherit = true /* Metadata: 0x02645478 */)
			where TAttribute : Attribute;
	}

	public static class ConversionUtility // TypeDefIndex: 86193
	{
		// Fields
		private static readonly Dictionary<ConversionQuery, ConversionType> conversionTypesCache; // 0x00
		private static readonly Dictionary<ConversionQuery, MethodInfo[]> userConversionMethodsCache; // 0x08
		private static readonly Dictionary<System.Type, HashSet<System.Type>> implicitNumericConversions; // 0x10
		private static readonly Dictionary<System.Type, HashSet<System.Type>> explicitNumericConversions; // 0x18
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 86187
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
	
		private struct ConversionQuery : IEquatable<ConversionQuery> // TypeDefIndex: 86188
		{
			// Fields
			public readonly System.Type source; // 0x00
			public readonly System.Type destination; // 0x08
	
			// Constructors
			public ConversionQuery(System.Type source, System.Type destination); // 0x0000000185B2C340-0x0000000185B2C370
	
			// Methods
			public bool Equals(ConversionQuery other); // 0x000000018D47A634-0x000000018D47A6A4
			public override bool Equals(object obj); // 0x000000018D47A6A4-0x000000018D47A714
			public override int GetHashCode(); // 0x000000018D47A714-0x000000018D47A754
		}
	
		private struct ConversionQueryComparer : IEqualityComparer<ConversionQuery> // TypeDefIndex: 86189
		{
			// Methods
			public bool Equals(ConversionQuery x, ConversionQuery y); // 0x000000018D47A5FC-0x000000018D47A620
			public int GetHashCode(ConversionQuery obj); // 0x000000018D47A620-0x000000018D47A634
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 86190
		{
			// Fields
			public System.Type source; // 0x10
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__2(MethodInfo m); // 0x000000018D492674-0x000000018D49271C
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86191
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<MethodInfo, bool> __9__11_0; // 0x08
			public static Func<MethodInfo, bool> __9__11_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D492DA0-0x000000018D492E04
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _FindUserDefinedConversionMethods_b__11_0(MethodInfo m); // 0x000000018D4921F4-0x000000018D492240
			internal bool _FindUserDefinedConversionMethods_b__11_1(MethodInfo m); // 0x000000018D492240-0x000000018D49228C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 86192
		{
			// Fields
			public System.Type destination; // 0x10
	
			// Constructors
			public __c__DisplayClass13_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetUserDefinedConversionType_b__0(MethodInfo m); // 0x000000018D49271C-0x000000018D492790
			internal bool _GetUserDefinedConversionType_b__1(MethodInfo m); // 0x000000018D492790-0x000000018D49280C
			internal bool _GetUserDefinedConversionType_b__2(MethodInfo m); // 0x000000018D49280C-0x000000018D492888
		}
	
		// Constructors
		static ConversionUtility(); // 0x000000018D47C584-0x000000018D47DF90
	
		// Methods
		private static bool RespectsIdentity(System.Type source, System.Type destination); // 0x000000018D47C184-0x000000018D47C1D8
		private static bool IsUpcast(System.Type source, System.Type destination); // 0x000000018CEF1798-0x000000018CEF17B8
		private static bool IsDowncast(System.Type source, System.Type destination); // 0x000000018CE6880C-0x000000018CE68830
		public static bool HasImplicitNumericConversion(System.Type source, System.Type destination); // 0x000000018D47BDD8-0x000000018D47BEBC
		public static bool HasExplicitNumericConversion(System.Type source, System.Type destination); // 0x000000018D47BCF4-0x000000018D47BDD8
		public static bool HasNumericConversion(System.Type source, System.Type destination); // 0x000000018D47BEBC-0x000000018D47BF30
		private static IEnumerable<MethodInfo> FindUserDefinedConversionMethods(ConversionQuery query); // 0x000000018D47B194-0x000000018D47B43C
		private static MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination); // 0x000000018D47B634-0x000000018D47B7B4
		private static ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination); // 0x000000018D47B7B4-0x000000018D47BAFC
		private static bool HasEnumerableToArrayConversion(System.Type source, System.Type destination); // 0x000000018D47BAFC-0x000000018D47BBE0
		private static bool HasEnumerableToListConversion(System.Type source, System.Type destination); // 0x000000018D47BBE0-0x000000018D47BCF4
		private static bool HasUnityHierarchyConversion(System.Type source, System.Type destination); // 0x000000018D47BF30-0x000000018D47C054
		private static bool IsValidConversion(ConversionType conversionType, bool guaranteed); // 0x000000018D47C114-0x000000018D47C128
		public static bool CanConvert(object value, System.Type type, bool guaranteed); // 0x000000018D47A7C0-0x000000018D47A82C
		public static bool CanConvert(System.Type source, System.Type destination, bool guaranteed); // 0x000000018D47A754-0x000000018D47A7C0
		public static object Convert(object value, System.Type type); // 0x000000018D47A82C-0x000000018D47A890
		public static ConversionType GetRequiredConversion(System.Type source, System.Type destination); // 0x000000018D47B504-0x000000018D47B634
		private static ConversionType DetermineConversionType(ConversionQuery query); // 0x000000018D47AC8C-0x000000018D47AECC
		public static ConversionType GetRequiredConversion(object value, System.Type type); // 0x000000018D47B43C-0x000000018D47B504
		private static object NumericConversion(object value, System.Type type); // 0x000000018D47C128-0x000000018D47C184
		private static object UserDefinedConversion(ConversionType conversion, object value, System.Type type); // 0x000000018D47C3C8-0x000000018D47C584
		private static object EnumerableToArrayConversion(object value, System.Type arrayType); // 0x000000018D47AECC-0x000000018D47B004
		private static object EnumerableToListConversion(object value, System.Type listType); // 0x000000018D47B004-0x000000018D47B194
		private static object UnityHierarchyConversion(object value, System.Type type); // 0x000000018D47C1D8-0x000000018D47C3C8
		private static object Convert(object value, System.Type type, ConversionType conversionType); // 0x000000018D47A890-0x000000018D47AC8C
	
		// Extension methods
		public static bool IsConvertibleTo(this System.Type source, System.Type destination, bool guaranteed); // 0x000000018D47C0B4-0x000000018D47C114
		public static bool IsConvertibleTo(this object source, System.Type type, bool guaranteed); // 0x000000018D47C054-0x000000018D47C0B4
	}

	public struct LooseAssemblyName // TypeDefIndex: 86194
	{
		// Fields
		public readonly string name; // 0x00
	
		// Constructors
		public LooseAssemblyName(string name); // 0x000000018D4835B8-0x000000018D483624
	
		// Methods
		public override bool Equals(object obj); // 0x000000018D483518-0x000000018D48357C
		public override int GetHashCode(); // 0x000000018D48357C-0x000000018D4835B8
		public override string ToString(); // 0x0000000184431970-0x0000000184431980
	}

	public static class MemberUtility // TypeDefIndex: 86196
	{
		// Fields
		private static readonly Lazy<ExtensionMethodCache> ExtensionMethodsCache; // 0x00
		private static readonly Lazy<Dictionary<System.Type, MethodInfo[]>> InheritedExtensionMethodsCache; // 0x08
		private static readonly Lazy<HashSet<MethodInfo>> GenericExtensionMethods; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86195
		{
			// Fields
			public static readonly __c __9; // 0x00
	
			// Constructors
			static __c(); // 0x000000018D4929B8-0x000000018D492A1C
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ExtensionMethodCache _.cctor_b__0_0(); // 0x000000018D492430-0x000000018D492480
			internal Dictionary<System.Type, MethodInfo[]> _.cctor_b__0_1(); // 0x000000018D492480-0x000000018D4924E0
			internal HashSet<MethodInfo> _.cctor_b__0_2(); // 0x000000018D4924E0-0x000000018D492540
		}
	
		// Constructors
		static MemberUtility(); // 0x000000018D483D94-0x000000018D484028
	
		// Extension methods
		public static bool IsUserDefinedConversion(this MethodInfo method); // 0x000000018D483CF4-0x000000018D483D94
		public static bool IsExtension(this MethodInfo methodInfo); // 0x000000018D483AD8-0x000000018D483B2C
		public static bool IsStatic(this PropertyInfo propertyInfo); // 0x000000018D483B2C-0x000000018D483B94
		public static bool IsStatic(this MemberInfo memberInfo); // 0x000000018D483B94-0x000000018D483CF4
		public static bool CanWrite(this System.Reflection.FieldInfo fieldInfo); // 0x000000018D483AA0-0x000000018D483AD8
	}

	internal class ExtensionMethodCache // TypeDefIndex: 86198
	{
		// Fields
		internal readonly MethodInfo[] Cache; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86197
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__0_0; // 0x08
			public static Func<System.Type, IEnumerable<MethodInfo>> __9__0_1; // 0x10
			public static Func<MethodInfo, bool> __9__0_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018D492BAC-0x000000018D492C10
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _.ctor_b__0_0(System.Type type); // 0x000000018D492550-0x000000018D4925C4
			internal IEnumerable<MethodInfo> _.ctor_b__0_1(System.Type type); // 0x000000018D4925C4-0x000000018D4925E4
			internal bool _.ctor_b__0_2(MethodInfo method); // 0x000000018D4925E4-0x000000018D492630
		}
	
		// Constructors
		internal ExtensionMethodCache(); // 0x000000018D47F2AC-0x000000018D47F5D8
	}

	public sealed class Namespace // TypeDefIndex: 86200
	{
		// Fields
		[CompilerGenerated]
		private readonly Namespace _Root_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly Namespace _Parent_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly string _FullName_k__BackingField; // 0x20
		[CompilerGenerated]
		private readonly string _Name_k__BackingField; // 0x28
		[CompilerGenerated]
		private readonly bool _IsRoot_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly bool _IsGlobal_k__BackingField; // 0x31
		private static readonly Collection collection; // 0x00
		[CompilerGenerated]
		private static readonly Namespace _Global_k__BackingField; // 0x08
	
		// Properties
		public string FullName { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public static Namespace Global { [CompilerGenerated] get; } // 0x000000018D484660-0x000000018D4846B0 
	
		// Nested types
		private class Collection : KeyedCollection<string, Namespace>, IKeyedCollection<string, Namespace> // TypeDefIndex: 86199
		{
			// Properties
			Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.this[string key] { get => default; } // 0x000000018D47A578-0x000000018D47A5C0 
	
			// Constructors
			public Collection(); // 0x000000018D47A5C0-0x000000018D47A5FC
	
			// Methods
			protected override string GetKeyForItem(Namespace item); // 0x000000018C0BBDD8-0x000000018C0BBDF0
			public new bool TryGetValue(string key, out Namespace value); // 0x000000018D47A4B4-0x000000018D47A530
			bool IKeyedCollection<string, Namespace>.Contains(string key); // 0x000000018D47A530-0x000000018D47A578
		}
	
		// Constructors
		private Namespace(string fullName); // 0x000000018D48451C-0x000000018D484660
		static Namespace(); // 0x000000018D484454-0x000000018D48451C
	
		// Methods
		public override int GetHashCode(); // 0x000000018D48442C-0x000000018D484454
		public override string ToString(); // 0x000000018225E800-0x000000018225E810
		public static Namespace FromFullName(string fullName); // 0x000000018D484338-0x000000018D48442C
		public override bool Equals(object obj); // 0x000000018D4842AC-0x000000018D484338
		public static implicit operator Namespace(string fullName); // 0x000000018D4846D8-0x000000018D484724
		public static bool operator ==(Namespace a, Namespace b); // 0x000000018D4846B0-0x000000018D4846D8
	}

	public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 86201; 0x00000000-0x00000000

	public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 86202; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5); // TypeDefIndex: 86203; 0x00000000-0x00000000

	public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6); // TypeDefIndex: 86204; 0x00000000-0x00000000

	public abstract class InstanceActionInvokerBase<TTarget> : InstanceInvokerBase<TTarget> // TypeDefIndex: 86205
	{
		// Constructors
		protected InstanceActionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class InstanceActionInvoker<TTarget> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86206
	{
		// Fields
		private Action<TTarget> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86207
	{
		// Fields
		private Action<TTarget, TParam0> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		private object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86208
	{
		// Fields
		private Action<TTarget, TParam0, TParam1> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86209
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86210
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : InstanceActionInvokerBase<TTarget> // TypeDefIndex: 86211
	{
		// Fields
		private Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public InstanceActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor // TypeDefIndex: 86212
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TTarget, TField> getter;
		private Action<TTarget, TField> setter;
	
		// Constructors
		public InstanceFieldAccessor(System.Reflection.FieldInfo fieldInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
		[CompilerGenerated]
		private TField _Compile_b__4_0(TTarget instance);
		[CompilerGenerated]
		private void _Compile_b__4_1(TTarget instance, TField value);
	}

	public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget> // TypeDefIndex: 86213
	{
		// Constructors
		protected InstanceFunctionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class InstanceFunctionInvoker<TTarget, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86214
	{
		// Fields
		private Func<TTarget, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86215
	{
		// Fields
		private Func<TTarget, TParam0, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		public object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86216
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86217
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86218
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public sealed class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : InstanceFunctionInvokerBase<TTarget, TResult> // TypeDefIndex: 86219
	{
		// Fields
		private Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public InstanceFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
	}

	public abstract class InstanceInvokerBase<TTarget> : InvokerBase // TypeDefIndex: 86220
	{
		// Constructors
		protected InstanceInvokerBase(MethodInfo methodInfo);
	
		// Methods
		protected sealed override void CompileExpression();
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target);
	}

	public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor // TypeDefIndex: 86221
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TTarget, TProperty> getter;
		private Action<TTarget, TProperty> setter;
	
		// Constructors
		public InstancePropertyAccessor(PropertyInfo propertyInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
	}

	public abstract class InvokerBase : IOptimizedInvoker // TypeDefIndex: 86222
	{
		// Fields
		protected readonly System.Type targetType; // 0x10
		protected readonly MethodInfo methodInfo; // 0x18
	
		// Constructors
		protected InvokerBase(MethodInfo methodInfo); // 0x000000018D482FA0-0x000000018D483070
	
		// Methods
		protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg);
		public void Compile(); // 0x000000018D482C98-0x000000018D482CE8
		protected ParameterExpression[] GetParameterExpressions(); // 0x000000018D482CE8-0x000000018D482F54
		protected abstract System.Type[] GetParameterTypes();
		public virtual object Invoke(object target, object arg0); // 0x000000018D482F54-0x000000018D482FA0
		protected abstract void CompileExpression();
		protected abstract void CreateDelegate();
		protected abstract void VerifyTarget(object target);
	}

	public interface IOptimizedAccessor // TypeDefIndex: 86223
	{
		// Methods
		void Compile();
		object GetValue(object target);
		void SetValue(object target, object value);
	}

	public interface IOptimizedInvoker // TypeDefIndex: 86224
	{
		// Methods
		void Compile();
		object Invoke(object target, object arg0);
	}

	public static class OptimizedReflection // TypeDefIndex: 86226
	{
		// Fields
		private static readonly Dictionary<System.Reflection.FieldInfo, IOptimizedAccessor> fieldAccessors; // 0x00
		private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors; // 0x08
		private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers; // 0x10
		public static readonly bool jitAvailable; // 0x18
		private static bool _useJitIfAvailable; // 0x19
		[CompilerGenerated]
		private static bool _safeMode_k__BackingField; // 0x1A
	
		// Properties
		internal static bool useJit { get; } // 0x000000018D487BB8-0x000000018D487C40 
		public static bool useJitIfAvailable { get; } // 0x000000018D487B68-0x000000018D487BB8 
		public static bool safeMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D487B18-0x000000018D487B68 0x000000018D487C40-0x000000018D487C94
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86225
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<ParameterInfo, bool> __9__39_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D492D3C-0x000000018D492DA0
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _SupportsOptimization_b__39_0(ParameterInfo parameter); // 0x000000018D492408-0x000000018D492430
		}
	
		// Constructors
		static OptimizedReflection(); // 0x0000000186EC1D10-0x0000000186EC1ED0
	
		// Methods
		internal static void OnRuntimeMethodLoad(); // 0x00000001861B3EB0-0x00000001861B3F80
		internal static void VerifyStaticTarget(System.Type targetType, object target); // 0x000000018D4878B4-0x000000018D487908
		internal static void VerifyInstanceTarget<TTArget>(object target);
		private static void VerifyTarget(System.Type targetType, object target, bool @static); // 0x000000018D487908-0x000000018D487B18
		private static bool SupportsOptimization(MemberInfo memberInfo); // 0x000000018D4875E8-0x000000018D487660
		private static IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo); // 0x000000018D484724-0x000000018D484BE8
		private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo); // 0x000000018D486EB8-0x000000018D4873A8
		private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo); // 0x000000018D484BE8-0x000000018D486EB8
	
		// Extension methods
		public static IOptimizedAccessor Prewarm(this System.Reflection.FieldInfo fieldInfo); // 0x000000018D48741C-0x000000018D487468
		public static void SetValueOptimized(this System.Reflection.FieldInfo fieldInfo, object target, object value); // 0x000000018D487500-0x000000018D487574
		public static bool SupportsOptimization(this System.Reflection.FieldInfo fieldInfo); // 0x000000018D48786C-0x000000018D4878B4
		public static IOptimizedAccessor Prewarm(this PropertyInfo propertyInfo); // 0x000000018D487468-0x000000018D4874B4
		public static void SetValueOptimized(this PropertyInfo propertyInfo, object target, object value); // 0x000000018D487574-0x000000018D4875E8
		public static bool SupportsOptimization(this PropertyInfo propertyInfo); // 0x000000018D487824-0x000000018D48786C
		public static IOptimizedInvoker Prewarm(this MethodInfo methodInfo); // 0x000000018D4874B4-0x000000018D487500
		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0); // 0x000000018D4873A8-0x000000018D48741C
		public static bool SupportsOptimization(this MethodInfo methodInfo); // 0x000000018D487660-0x000000018D487824
	}

	public sealed class ReflectionFieldAccessor : IOptimizedAccessor // TypeDefIndex: 86227
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo; // 0x10
	
		// Constructors
		public ReflectionFieldAccessor(System.Reflection.FieldInfo fieldInfo); // 0x000000018D4891F4-0x000000018D4892A8
	
		// Methods
		public void Compile(); // 0x0000000186805BA0-0x0000000186805BB0
		public object GetValue(object target); // 0x000000018AF88464-0x000000018AF88488
		public void SetValue(object target, object value); // 0x000000018A081290-0x000000018A0812B0
	}

	public class ReflectionInvoker : IOptimizedInvoker // TypeDefIndex: 86228
	{
		// Fields
		private readonly MethodInfo methodInfo; // 0x10
		private static readonly object[] EmptyObjects; // 0x00
	
		// Constructors
		public ReflectionInvoker(MethodInfo methodInfo); // 0x000000018D4893AC-0x000000018D489460
		static ReflectionInvoker(); // 0x000000018D489348-0x000000018D4893AC
	
		// Methods
		public void Compile(); // 0x0000000186805BA0-0x0000000186805BB0
		public object Invoke(object target, object arg0); // 0x000000018D4892A8-0x000000018D489348
	}

	public sealed class ReflectionPropertyAccessor : IOptimizedAccessor // TypeDefIndex: 86229
	{
		// Fields
		private readonly PropertyInfo propertyInfo; // 0x10
	
		// Constructors
		public ReflectionPropertyAccessor(PropertyInfo propertyInfo); // 0x000000018D489460-0x000000018D489514
	
		// Methods
		public void Compile(); // 0x0000000186805BA0-0x0000000186805BB0
		public object GetValue(object target); // 0x000000018AF85474-0x000000018AF85498
		public void SetValue(object target, object value); // 0x000000018B4B0EB8-0x000000018B4B0EE4
	}

	public abstract class StaticActionInvokerBase : StaticInvokerBase // TypeDefIndex: 86230
	{
		// Constructors
		protected StaticActionInvokerBase(MethodInfo methodInfo); // 0x000000018B849D7C-0x000000018B849D84
	}

	public sealed class StaticActionInvoker : StaticActionInvokerBase // TypeDefIndex: 86231
	{
		// Fields
		private Action invoke; // 0x20
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo); // 0x000000018B849D7C-0x000000018B849D84
	
		// Methods
		protected override System.Type[] GetParameterTypes(); // 0x000000018D48E904-0x000000018D48E954
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions); // 0x000000018D48E7E8-0x000000018D48E888
		protected override void CreateDelegate(); // 0x000000018D48E888-0x000000018D48E904
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(); // 0x000000018D48E954-0x000000018D48E9FC
	}

	public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase // TypeDefIndex: 86232
	{
		// Fields
		private Action<TParam0> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		private object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase // TypeDefIndex: 86233
	{
		// Fields
		private Action<TParam0, TParam1> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase // TypeDefIndex: 86234
	{
		// Fields
		private Action<TParam0, TParam1, TParam2> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase // TypeDefIndex: 86235
	{
		// Fields
		private Action<TParam0, TParam1, TParam2, TParam3> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
	}

	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase // TypeDefIndex: 86236
	{
		// Fields
		private Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;
	
		// Constructors
		public StaticActionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private void _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}

	public class StaticFieldAccessor<TField> : IOptimizedAccessor // TypeDefIndex: 86238
	{
		// Fields
		private readonly System.Reflection.FieldInfo fieldInfo;
		private Func<TField> getter;
		private Action<TField> setter;
		private System.Type targetType;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 86237
		{
			// Fields
			public TField constant;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal TField _Compile_b__2();
		}
	
		// Constructors
		public StaticFieldAccessor(System.Reflection.FieldInfo fieldInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
		[CompilerGenerated]
		private TField _Compile_b__5_0();
		[CompilerGenerated]
		private void _Compile_b__5_1(TField value);
	}

	public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase // TypeDefIndex: 86239
	{
		// Constructors
		protected StaticFunctionInvokerBase(MethodInfo methodInfo);
	}

	public sealed class StaticFunctionInvoker<TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86240
	{
		// Fields
		private Func<TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0();
	}

	public sealed class StaticFunctionInvoker<TParam0, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86241
	{
		// Fields
		private Func<TParam0, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		public override object Invoke(object target, object arg0);
		public object InvokeUnsafe(object target, object arg0);
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86242
	{
		// Fields
		private Func<TParam0, TParam1, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86243
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86244
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TParam3, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
	}

	public sealed class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : StaticFunctionInvokerBase<TResult> // TypeDefIndex: 86245
	{
		// Fields
		private Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;
	
		// Constructors
		public StaticFunctionInvoker(MethodInfo methodInfo);
	
		// Methods
		protected override System.Type[] GetParameterTypes();
		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void CreateDelegate();
		[CompilerGenerated]
		private TResult _CreateDelegate_b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
	}

	public abstract class StaticInvokerBase : InvokerBase // TypeDefIndex: 86246
	{
		// Constructors
		protected StaticInvokerBase(MethodInfo methodInfo); // 0x000000018D48EAC8-0x000000018D48EB9C
	
		// Methods
		protected sealed override void CompileExpression(); // 0x000000018D48E9FC-0x000000018D48EA74
		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);
		protected override void VerifyTarget(object target); // 0x000000018D48EA74-0x000000018D48EAC8
	}

	public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor // TypeDefIndex: 86247
	{
		// Fields
		private readonly PropertyInfo propertyInfo;
		private Func<TProperty> getter;
		private Action<TProperty> setter;
		private System.Type targetType;
	
		// Constructors
		public StaticPropertyAccessor(PropertyInfo propertyInfo);
	
		// Methods
		public void Compile();
		public object GetValue(object target);
		private object GetValueUnsafe(object target);
		public void SetValue(object target, object value);
		private void SetValueUnsafe(object target, object value);
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedAssemblyAttribute : Attribute // TypeDefIndex: 86248
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public string newName { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	}

	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter | AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class RenamedFromAttribute : Attribute // TypeDefIndex: 86249
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	}

	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RenamedNamespaceAttribute : Attribute // TypeDefIndex: 86250
	{
		// Fields
		[CompilerGenerated]
		private readonly string _previousName_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly string _newName_k__BackingField; // 0x18
	
		// Properties
		public string previousName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
		public string newName { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
	
		// Constructors
		public RenamedNamespaceAttribute(string previousName, string newName); // 0x0000000185381AC0-0x0000000185381AF0
	}

	public static class RuntimeCodebase // TypeDefIndex: 86253
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
		public static IEnumerable<System.Type> types { get; } // 0x000000018D48BEC8-0x000000018D48BF18 
		public static IEnumerable<Assembly> assemblies { get; } // 0x000000018D48BCA4-0x000000018D48BCF4 
		public static Dictionary<string, string> renamedNamespaces { get; } // 0x000000018D48BD90-0x000000018D48BE2C 
		public static Dictionary<string, string> renamedAssemblies { get; } // 0x000000018D48BCF4-0x000000018D48BD90 
		public static Dictionary<string, System.Type> renamedTypes { get; } // 0x000000018D48BE2C-0x000000018D48BEC8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GetAssemblyAttributes_d__15 : IEnumerable<Attribute>, IEnumerator<Attribute> // TypeDefIndex: 86251
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
			Attribute IEnumerator<System.Attribute>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetAssemblyAttributes_d__15(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D491AC4-0x000000018D491BB4
			private bool MoveNext(); // 0x000000018D4914E0-0x000000018D4919C8
			private void __m__Finally1(); // 0x000000018D491BB4-0x000000018D491C00
			private void __m__Finally2(); // 0x000000018D491C00-0x000000018D491C4C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D491A78-0x000000018D491AC4
			[DebuggerHidden]
			IEnumerator<Attribute> IEnumerable<Attribute>.GetEnumerator(); // 0x000000018D4919C8-0x000000018D491A70
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D491A70-0x000000018D491A78
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 86252
		{
			// Fields
			public Unity.VisualScripting.TypeName typeName; // 0x10
			public Func<Assembly, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _TrySystemTypeLookup_b__0(Assembly a); // 0x000000018D492888-0x000000018D4928CC
		}
	
		// Constructors
		static RuntimeCodebase(); // 0x000000018D48B6A8-0x000000018D48BCA4
	
		// Methods
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType); // 0x000000018D48A5B4-0x000000018D48A608
		[IteratorStateMachine(typeof(_GetAssemblyAttributes_d__15))]
		public static IEnumerable<Attribute> GetAssemblyAttributes(System.Type attributeType, IEnumerable<Assembly> assemblies); // 0x000000018D48A52C-0x000000018D48A5B4
		public static IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>()
			where TAttribute : Attribute;
		public static string SerializeType(System.Type type); // 0x000000018D48A608-0x000000018D48A69C
		public static bool TryDeserializeType(string typeName, out System.Type type); // 0x000000018D48A71C-0x000000018D48A8EC
		public static System.Type DeserializeType(string typeName); // 0x000000018D489514-0x000000018D489604
		private static bool TryCachedTypeLookup(string typeName, out System.Type type); // 0x000000018D48A69C-0x000000018D48A71C
		private static bool TrySystemTypeLookup(string typeName, out System.Type type); // 0x000000018D48ADEC-0x000000018D48B214
		private static bool TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, out System.Type type); // 0x000000018D48B214-0x000000018D48B6A8
		private static bool TryRenamedTypeLookup(string previousTypeName, out System.Type type); // 0x000000018D48A8EC-0x000000018D48ADEC
		private static Dictionary<string, string> FetchRenamedNamespaces(); // 0x000000018D489984-0x000000018D489D04
		private static Dictionary<string, string> FetchRenamedAssemblies(); // 0x000000018D489604-0x000000018D489984
		private static Dictionary<string, System.Type> FetchRenamedTypes(); // 0x000000018D489D04-0x000000018D48A52C
	}

	public class TypeName // TypeDefIndex: 86256
	{
		// Fields
		[CompilerGenerated]
		private string _AssemblyDescription_k__BackingField; // 0x10
		[CompilerGenerated]
		private string _AssemblyName_k__BackingField; // 0x18
		[CompilerGenerated]
		private string _AssemblyVersion_k__BackingField; // 0x20
		[CompilerGenerated]
		private string _AssemblyCulture_k__BackingField; // 0x28
		[CompilerGenerated]
		private string _AssemblyPublicKeyToken_k__BackingField; // 0x30
		[CompilerGenerated]
		private readonly List<TypeName> _GenericParameters_k__BackingField; // 0x38
		private readonly List<string> names; // 0x40
		private readonly List<int> genericarities; // 0x48
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x50
	
		// Properties
		public string AssemblyDescription { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public string AssemblyName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		private string AssemblyVersion { [CompilerGenerated] set; } // 0x0000000187835950-0x0000000187835960
		private string AssemblyCulture { [CompilerGenerated] set; } // 0x0000000185CA30F0-0x0000000185CA3100
		private string AssemblyPublicKeyToken { [CompilerGenerated] set; } // 0x000000018783BA80-0x000000018783BA90
		public List<TypeName> GenericParameters { [CompilerGenerated] get; } // 0x0000000182986470-0x0000000182986480 
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public bool IsArray { get; } // 0x000000018D4907F4-0x000000018D490840 
	
		// Nested types
		private enum ParseState // TypeDefIndex: 86254
		{
			Name = 0,
			Array = 1,
			Generics = 2,
			Assembly = 3
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86255
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, string> __9__35_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D492A80-0x000000018D492AE4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _.ctor_b__35_0(string x); // 0x000000018D492630-0x000000018D492658
		}
	
		// Constructors
		private TypeName(string s, ref int index); // 0x000000018D48FE70-0x000000018D4907F4
	
		// Methods
		public static TypeName Parse(string s); // 0x000000018D48EF24-0x000000018D48EF90
		private static string LookForPairThenRemove(List<string> strings, string Name); // 0x000000018D48EE3C-0x000000018D48EF24
		public void ReplaceNamespace(string oldNamespace, string newNamespace); // 0x000000018D48F480-0x000000018D48F770
		public void ReplaceAssembly(string oldAssembly, string newAssembly); // 0x000000018D48EF90-0x000000018D48F19C
		public void ReplaceName(string oldTypeName, System.Type newType); // 0x000000018D48F3F8-0x000000018D48F480
		public void ReplaceName(string oldTypeName, string newTypeName, AssemblyName newAssemblyName = null); // 0x000000018D48F19C-0x000000018D48F3F8
		private static string ToElementTypeName(string s); // 0x000000018D48F8D8-0x000000018D48F960
		private static string ToArrayOrType(string oldType, string newType); // 0x000000018D48F864-0x000000018D48F8D8
		public void SetAssemblyName(AssemblyName newAssemblyName); // 0x000000018D48F770-0x000000018D48F864
		private void UpdateName(); // 0x000000018D48FD20-0x000000018D48FE70
		public string ToString(TypeNameDetail specification, TypeNameDetail genericsSpecification); // 0x000000018D48F970-0x000000018D48FD10
		public override string ToString(); // 0x000000018D48FD10-0x000000018D48FD20
		public string ToLooseString(); // 0x000000018D48F960-0x000000018D48F970
	}

	public enum TypeNameDetail // TypeDefIndex: 86257
	{
		Name = 0,
		NameAndAssembly = 1,
		Full = 2
	}

	public static class TypeUtility // TypeDefIndex: 86260
	{
		// Fields
		private static readonly HashSet<System.Type> _numericTypes; // 0x00
		private static readonly HashSet<System.Type> _numericConstructTypes; // 0x08
		private static readonly HashSet<System.Type> typesWithShortStrings; // 0x10
		private static readonly Dictionary<System.Type, object> defaultPrimitives; // 0x18
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86258
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<System.Type, bool> __9__35_0; // 0x08
			public static Func<System.Type, bool> __9__35_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D492C10-0x000000018D492C74
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetTypesSafely_b__35_0(System.Type t); // 0x000000018D49228C-0x000000018D4922D4
			internal bool _GetTypesSafely_b__35_1(System.Type t); // 0x000000018D4922D4-0x000000018D49231C
		}
	
		[CompilerGenerated]
		private sealed class _GetTypesSafely_d__35 : IEnumerable<System.Type>, IEnumerator<System.Type> // TypeDefIndex: 86259
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
			System.Type IEnumerator<System.Type>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _GetTypesSafely_d__35(int __1__state); // 0x00000001851FD710-0x00000001851FD730
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D491C4C-0x000000018D49210C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D4921A8-0x000000018D4921F4
			[DebuggerHidden]
			IEnumerator<System.Type> IEnumerable<Type>.GetEnumerator(); // 0x000000018D49210C-0x000000018D4921A0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D4921A0-0x000000018D4921A8
		}
	
		// Constructors
		static TypeUtility(); // 0x000000018D490B6C-0x000000018D4914E0
	
		// Extension methods
		public static bool IsBasic(this System.Type type); // 0x000000018D490920-0x000000018D490A9C
		public static bool IsStatic(this System.Type type); // 0x000000018D490B34-0x000000018D490B6C
		public static bool IsNullable(this System.Type type); // 0x000000018D490A9C-0x000000018D490B10
		public static bool IsReferenceType(this System.Type type); // 0x000000018D490B10-0x000000018D490B34
		public static bool IsAssignableFrom(this System.Type type, object value); // 0x000000018D4908B0-0x000000018D490920
		[IteratorStateMachine(typeof(_GetTypesSafely_d__35))]
		public static IEnumerable<System.Type> GetTypesSafely(this Assembly assembly); // 0x000000018D490840-0x000000018D4908B0
	}

	public class LooseAssemblyNameConverter : fsDirectConverter // TypeDefIndex: 86261
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018D4834C8-0x000000018D483518 
	
		// Constructors
		public LooseAssemblyNameConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D483290-0x000000018D4832CC
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4833F8-0x000000018D4834C8
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4832CC-0x000000018D4833F8
	}

	public class NamespaceConverter : fsDirectConverter // TypeDefIndex: 86262
	{
		// Properties
		public override System.Type ModelType { get; } // 0x000000018D48425C-0x000000018D4842AC 
	
		// Constructors
		public NamespaceConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D484028-0x000000018D484064
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D484180-0x000000018D48425C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D484064-0x000000018D484180
	}

	public class Ray2DConverter : fsDirectConverter<Ray2D> // TypeDefIndex: 86263
	{
		// Constructors
		public Ray2DConverter(); // 0x000000018D4882B4-0x000000018D4882DC
	
		// Methods
		protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized); // 0x000000018D488158-0x000000018D4882B4
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model); // 0x000000018D487FE0-0x000000018D488158
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D487FA0-0x000000018D487FE0
	}

	public class RayConverter : fsDirectConverter<Ray> // TypeDefIndex: 86264
	{
		// Constructors
		public RayConverter(); // 0x000000018D48862C-0x000000018D488654
	
		// Methods
		protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized); // 0x000000018D4884C4-0x000000018D48862C
		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model); // 0x000000018D488330-0x000000018D4884C4
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D4882DC-0x000000018D488330
	}

	public class UnityObjectConverter : fsConverter // TypeDefIndex: 86265
	{
		// Properties
		private List<UnityEngine.Object> objectReferences { get; } // 0x000000018D4931C0-0x000000018D493210 
	
		// Constructors
		public UnityObjectConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D492E04-0x000000018D492E7C
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D493094-0x000000018D4931C0
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x000000018D492E7C-0x000000018D493094
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000187239520-0x0000000187239530
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public sealed class DoNotSerializeAttribute : Attribute // TypeDefIndex: 86266
	{
		// Constructors
		public DoNotSerializeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface ISerializationDependency : ISerializationCallbackReceiver // TypeDefIndex: 86267
	{
		// Properties
		bool IsDeserialized { get; }
	}

	public interface ISerializationDepender : ISerializationCallbackReceiver // TypeDefIndex: 86268
	{
		// Properties
		IEnumerable<ISerializationDependency> deserializationDependencies { get; }
	
		// Methods
		void OnAfterDependenciesDeserialized();
	}

	public static class Serialization // TypeDefIndex: 86269
	{
		// Fields
		private static readonly HashSet<SerializationOperation> freeOperations; // 0x00
		private static readonly HashSet<SerializationOperation> busyOperations; // 0x08
		private static readonly object @lock; // 0x10
		[CompilerGenerated]
		private static bool _isUnitySerializing_k__BackingField; // 0x18
		private static readonly HashSet<ISerializationDepender> awaitingDependers; // 0x20
	
		// Properties
		public static bool isUnitySerializing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D48E744-0x000000018D48E794 0x000000018D48E794-0x000000018D48E7E8
		public static bool isCustomSerializing { get; } // 0x000000018D48E6E0-0x000000018D48E744 
	
		// Constructors
		static Serialization(); // 0x000000018D48E550-0x000000018D48E6E0
	
		// Methods
		private static SerializationOperation StartOperation(); // 0x000000018D48E308-0x000000018D48E550
		private static void EndOperation(SerializationOperation operation); // 0x000000018D48D8D0-0x000000018D48DAE0
		private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected); // 0x000000018D48DE08-0x000000018D48E048
		private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected); // 0x000000018D48D5D4-0x000000018D48D6FC
		private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected); // 0x000000018D48D6FC-0x000000018D48D860
		private static void HandleResult(string label, fsResult result, UnityEngine.Object context = null); // 0x000000018D48DAE0-0x000000018D48DDEC
		public static string PrettyPrint(string json); // 0x000000018D48DDEC-0x000000018D48DE08
		public static void AwaitDependencies(ISerializationDepender depender); // 0x000000018D48CCE8-0x000000018D48CD60
		private static void CheckIfDependenciesMet(ISerializationDepender depender); // 0x000000018D48CD60-0x000000018D48D190
	
		// Extension methods
		public static SerializationData Serialize(this object value, bool forceReflected = false /* Metadata: 0x02645492 */); // 0x000000018D48E048-0x000000018D48E308
		public static void DeserializeInto(this SerializationData data, ref object instance, bool forceReflected = false /* Metadata: 0x02645493 */); // 0x000000018D48D190-0x000000018D48D5D4
		public static object Deserialize(this SerializationData data, bool forceReflected = false /* Metadata: 0x02645494 */); // 0x000000018D48D860-0x000000018D48D8D0
	}

	[Serializable]
	public struct SerializationData // TypeDefIndex: 86270
	{
		// Fields
		[SerializeField]
		private string _json; // 0x00
		[SerializeField]
		private UnityEngine.Object[] _objectReferences; // 0x08
	
		// Properties
		public string json { get; } // 0x0000000184431970-0x0000000184431980 
		public UnityEngine.Object[] objectReferences { get; } // 0x00000001844AFA30-0x00000001844AFA40 
	
		// Constructors
		public SerializationData(string json, IEnumerable<UnityEngine.Object> objectReferences); // 0x000000018D48C9D4-0x000000018D48CA74
		public SerializationData(string json, params UnityEngine.Object[] objectReferences); // 0x000000018D48C9CC-0x000000018D48C9D4
	
		// Methods
		internal void Clear(); // 0x000000018D48C1D8-0x000000018D48C1FC
		public string ToString(string title); // 0x000000018D48C2E0-0x000000018D48C9C0
		public override string ToString(); // 0x000000018D48C9C0-0x000000018D48C9CC
		public void ShowString(string title = null); // 0x000000018D48C1FC-0x000000018D48C2E0
	}

	public class SerializationOperation // TypeDefIndex: 86271
	{
		// Fields
		[CompilerGenerated]
		private fsSerializer _serializer_k__BackingField; // 0x10
		[CompilerGenerated]
		private List<UnityEngine.Object> _objectReferences_k__BackingField; // 0x18
	
		// Properties
		public fsSerializer serializer { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public List<UnityEngine.Object> objectReferences { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public SerializationOperation(); // 0x000000018D48CABC-0x000000018D48CCE0
	
		// Methods
		public void Reset(); // 0x000000018D48CA74-0x000000018D48CABC
	}

	public class SerializationVersionAttribute : fsObjectAttribute // TypeDefIndex: 86272
	{
		// Constructors
		public SerializationVersionAttribute(string versionString, params System.Type[] previousModels); // 0x000000018D48CCE0-0x000000018D48CCE8
	}

	public class SerializeAsAttribute : fsPropertyAttribute // TypeDefIndex: 86273
	{
		// Constructors
		public SerializeAsAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class SerializeAttribute : Attribute // TypeDefIndex: 86274
	{
		// Constructors
		public SerializeAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface ISingleton // TypeDefIndex: 86275
	{
	}

	public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 86276
	{
		// Fields
		[DoNotSerialize]
		[SerializeField]
		protected SerializationData _data; // 0x18
		[CompilerGenerated]
		private Action OnDestroyActions; // 0x28
	
		// Events
		internal event Action OnDestroyActions {
			add; // 0x000000018D483978-0x000000018D483A0C
			remove; // 0x000000018D483A0C-0x000000018D483AA0
		}
	
		// Constructors
		protected LudiqScriptableObject(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018D48382C-0x000000018D483978
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018D4836C0-0x000000018D48382C
		protected virtual void OnBeforeSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterSerialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnBeforeDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnAfterDeserialize(); // 0x0000000186805BA0-0x0000000186805BB0
		protected virtual void OnPostDeserializeInEditor(); // 0x0000000186805BA0-0x0000000186805BB0
		private void OnDestroy(); // 0x000000018D483624-0x000000018D483634
		protected virtual void ShowData(); // 0x000000018D483634-0x000000018D4836B8
		public override string ToString(); // 0x000000018D4836B8-0x000000018D4836C0
	}

	public static class Singleton<T> // TypeDefIndex: 86277
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
		static Singleton();
	
		// Methods
		private static T[] FindObjectsOfType();
		private static T[] FindInstances();
		public static T Instantiate();
		public static void Awake(T instance);
		public static void OnDestroy(T instance);
	}

	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public sealed class SingletonAttribute : Attribute // TypeDefIndex: 86278
	{
		// Fields
		[CompilerGenerated]
		private bool _Persistent_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _Automatic_k__BackingField; // 0x11
		[CompilerGenerated]
		private HideFlags _HideFlags_k__BackingField; // 0x14
		[CompilerGenerated]
		private string _Name_k__BackingField; // 0x18
	
		// Properties
		public bool Persistent { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public bool Automatic { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235410-0x0000000187235420 0x0000000187235420-0x0000000187235430
		public HideFlags HideFlags { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182971EE0-0x0000000182971EF0 0x000000018275FD70-0x000000018275FD80
		public string Name { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public SingletonAttribute(); // 0x000000018724BE60-0x000000018724BE70
	}

	public static class UnityThread // TypeDefIndex: 86279
	{
		// Fields
		public static Thread thread; // 0x00
		public static ConcurrentQueue<Action> pendingQueue; // 0x08
	
		// Properties
		public static bool allowsAPI { get; } // 0x000000018D493538-0x000000018D4935E4 
	
		// Constructors
		static UnityThread(); // 0x0000000186EA9920-0x0000000186EA99E0
	
		// Methods
		internal static void RuntimeInitialize(); // 0x00000001861B3880-0x00000001861B38F0
	}

	public static class Empty<T> // TypeDefIndex: 86280
	{
		// Fields
		public static readonly T[] array;
		public static readonly List<T> list;
		public static readonly HashSet<T> hashSet;
	
		// Constructors
		static Empty();
	}

	public static class HashUtility // TypeDefIndex: 86281
	{
		// Methods
		public static int GetHashCode<T>(T a);
		public static int GetHashCode<T1, T2>(T1 a, T2 b);
	}

	public interface IIdentifiable // TypeDefIndex: 86282
	{
		// Properties
		Guid guid { get; }
	}

	public static class LinqUtility // TypeDefIndex: 86285
	{
		// Nested types
		[CompilerGenerated]
		private sealed class _Concat_d__0<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 86283
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
			T IEnumerator<T>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Concat_d__0(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			private void __m__Finally2();
			[DebuggerHidden]
			void IEnumerator.Reset();
			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c__2<T> // TypeDefIndex: 86284
		{
			// Fields
			public static readonly __c__2<T> __9;
			public static Func<T, bool> __9__2_0;
	
			// Constructors
			static __c__2();
			public __c__2();
	
			// Methods
			internal bool _NotNull_b__2_0(T i);
		}
	
		// Methods
		[IteratorStateMachine(typeof(_Concat_d__0<T>))]
		public static IEnumerable<T> Concat<T>(params IEnumerable[] enumerables);
	
		// Extension methods
		public static IEnumerable<T> NotNull<T>(this IEnumerable<T> enumerable);
	}

	public class Recursion<T> : IPoolable, IDisposable // TypeDefIndex: 86287
	{
		// Fields
		private readonly Stack<T> traversedOrder;
		private readonly Dictionary<T, int> traversedCount;
		private bool disposed;
		protected int maxDepth;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86286
		{
			// Fields
			public static readonly __c<T> __9;
			public static Func<Recursion<T>> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal Recursion<T> _New_b__13_0();
		}
	
		// Constructors
		protected Recursion();
	
		// Methods
		public void Enter(T o);
		public bool TryEnter(T o);
		public void Exit(T o);
		public void Dispose();
		protected virtual void Free();
		void IPoolable.New();
		void IPoolable.Free();
		public static Recursion<T> New();
		public static Recursion<T> New(int maxDepth);
	}

	public sealed class Recursion : Recursion<object> // TypeDefIndex: 86288
	{
		// Fields
		[CompilerGenerated]
		private static int _defaultMaxDepth_k__BackingField; // 0x00
		[CompilerGenerated]
		private static bool _safeMode_k__BackingField; // 0x04
	
		// Properties
		public static int defaultMaxDepth { [CompilerGenerated] get; } // 0x000000018D488654-0x000000018D4886A4 
		public static bool safeMode { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D4886A4-0x000000018D4886F4 0x000000018D4886F4-0x000000018D488748
	
		// Constructors
		static Recursion(); // 0x000000018721FD70-0x000000018721FDB0
	
		// Methods
		internal static void OnRuntimeMethodLoad(); // 0x00000001861B3F80-0x00000001861B4050
	}

	public static class ReferenceCollector // TypeDefIndex: 86290
	{
		// Fields
		[CompilerGenerated]
		private static Action onSceneUnloaded; // 0x00
	
		// Events
		public static event Action onSceneUnloaded {
			add; // 0x000000018D488748-0x000000018D4887F0
			remove; // 0x000000018D4887F0-0x000000018D488898
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86289
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static UnityAction<Scene> __9__3_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E4A00-0x00000001871E4A60
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Initialize_b__3_0(Scene scene); // 0x00000001871F21D0-0x00000001871F2220
		}
	
		// Methods
		internal static void Initialize(); // 0x00000001861B2C30-0x00000001861B2D50
	}

	public class ReferenceEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 86291
	{
		// Fields
		public static readonly ReferenceEqualityComparer Instance; // 0x00
	
		// Constructors
		private ReferenceEqualityComparer(); // 0x0000000186805BA0-0x0000000186805BB0
		static ReferenceEqualityComparer(); // 0x00000001871E7B80-0x00000001871E7BE0
	
		// Methods
		bool IEqualityComparer<object>.Equals(object a, object b); // 0x0000000187222F80-0x0000000187222F90
		int IEqualityComparer<object>.GetHashCode(object a); // 0x00000001870C0150-0x00000001870C01A0
		public static int GetHashCode(object a); // 0x0000000187235B50-0x0000000187235B60
	}

	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> // TypeDefIndex: 86292
	{
		// Fields
		public static readonly ReferenceEqualityComparer<T> Instance;
	
		// Constructors
		private ReferenceEqualityComparer();
		static ReferenceEqualityComparer();
	
		// Methods
		bool IEqualityComparer<T>.Equals(T a, T b);
		int IEqualityComparer<T>.GetHashCode(T a);
		public static int GetHashCode(T a);
	}

	public static class RuntimeVSUsageUtility // TypeDefIndex: 86293
	{
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeInitializeOnLoadBeforeSceneLoad(); // 0x00000001861B37B0-0x00000001861B3880
	}

	public static class StringUtility // TypeDefIndex: 86294
	{
		// Fields
		private static readonly Regex guidRegex; // 0x00
	
		// Constructors
		static StringUtility(); // 0x000000018D48EDAC-0x000000018D48EE3C
	
		// Extension methods
		public static string TrimStart(this string source, string value); // 0x000000018D48ED0C-0x000000018D48EDAC
		public static void PartsAround(this string s, char c, out string before, out string after); // 0x000000018D48EB9C-0x000000018D48EC90
		public static string ToHexString(this byte[] bytes); // 0x000000018D48EC90-0x000000018D48ED0C
	}

	public static class UnityObjectUtility // TypeDefIndex: 86295
	{
		// Methods
		public static bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b); // 0x000000018D4934B0-0x000000018D493538
	
		// Extension methods
		public static bool IsUnityNull(this object obj); // 0x000000018D493210-0x000000018D49328C
		public static string ToSafeString(this UnityEngine.Object uo); // 0x000000018D49328C-0x000000018D4934B0
		public static T AsUnityNull<T>(this T obj)
			where T : UnityEngine.Object;
	}

	public static class ApplicationVariables // TypeDefIndex: 86296
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		[CompilerGenerated]
		private static VariableDeclarations _runtime_k__BackingField; // 0x08
	
		// Properties
		public static VariablesAsset asset { get; } // 0x00000001861B2630-0x00000001861B26E0 
		private static VariableDeclarations runtime { [CompilerGenerated] set; } // 0x000000018D4796E8-0x000000018D47973C
	
		// Methods
		public static void Load(); // 0x00000001861B26E0-0x00000001861B2770
		internal static void OnEnterPlayMode(); // 0x000000018783BA9C-0x000000018783BAA4
		internal static void OnExitPlayMode(); // 0x0000000186805BA0-0x0000000186805BB0
		private static void CreateRuntimeDeclarations(); // 0x00000001861B1E50-0x00000001861B1F10
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class InspectorVariableNameAttribute : Attribute // TypeDefIndex: 86297
	{
		// Fields
		[CompilerGenerated]
		private ActionDirection _direction_k__BackingField; // 0x10
	
		// Properties
		private ActionDirection direction { [CompilerGenerated] set; } // 0x0000000182234E90-0x0000000182234EA0
	
		// Constructors
		public InspectorVariableNameAttribute(ActionDirection direction); // 0x0000000182234E90-0x0000000182234EA0
	}

	public static class SavedVariables // TypeDefIndex: 86299
	{
		// Fields
		private static VariablesAsset _asset; // 0x00
		[CompilerGenerated]
		private static VariableDeclarations _saved_k__BackingField; // 0x08
		[CompilerGenerated]
		private static VariableDeclarations _merged_k__BackingField; // 0x10
	
		// Properties
		public static VariablesAsset asset { get; } // 0x00000001861B2580-0x00000001861B2630 
		public static VariableDeclarations initial { get; } // 0x00000001861B24E0-0x00000001861B2580 
		public static VariableDeclarations saved { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D48C0F8-0x000000018D48C130 0x000000018D48C184-0x000000018D48C1D8
		public static VariableDeclarations merged { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018D48C0C0-0x000000018D48C0F8 0x000000018D48C130-0x000000018D48C184
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86298
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action __9__8_0; // 0x08
			public static Func<VariableDeclaration, string> __9__24_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E6FE0-0x00000001871E7040
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _OnEnterPlayMode_b__8_0(); // 0x000000018D4923B0-0x000000018D492408
			internal string _MergeInitialAndSavedDeclarations_b__24_0(VariableDeclaration vd); // 0x0000000188E4BE44-0x0000000188E4BE5C
		}
	
		// Methods
		public static void Load(); // 0x00000001861B2770-0x00000001861B2800
		internal static void OnEnterPlayMode(); // 0x00000001861B1CE0-0x00000001861B1E50
		internal static void OnExitPlayMode(); // 0x000000018D48BF18-0x000000018D48BF30
		public static void SaveDeclarations(VariableDeclarations declarations); // 0x000000018D48BF30-0x000000018D48C0C0
		public static void FetchSavedDeclarations(); // 0x0000000185752FB0-0x0000000185753050
		private static void MergeInitialAndSavedDeclarations(); // 0x00000001861B1F10-0x00000001861B24E0
		private static void WarnAndNullifyUnityObjectReferences(VariableDeclarations declarations); // 0x00000001861B1720-0x00000001861B1940
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclaration // TypeDefIndex: 86300
	{
		// Fields
		[CompilerGenerated]
		private string _name_k__BackingField; // 0x10
		[CompilerGenerated]
		private object _value_k__BackingField; // 0x18
	
		// Properties
		[Serialize]
		public string name { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		[Serialize]
		[Value]
		public object value { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public VariableDeclaration(string name, object value); // 0x0000000185381AC0-0x0000000185381AF0
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration> // TypeDefIndex: 86301
	{
		// Properties
		VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.this[string key] { get => default; } // 0x000000018D493D38-0x000000018D493D80 
	
		// Constructors
		public VariableDeclarationCollection(); // 0x0000000186D12F70-0x0000000186D12FB0
	
		// Methods
		protected override string GetKeyForItem(VariableDeclaration item); // 0x0000000188E4BE44-0x0000000188E4BE5C
		public new bool TryGetValue(string key, out VariableDeclaration value); // 0x000000018D493C74-0x000000018D493CF0
		bool IKeyedCollection<string, VariableDeclaration>.Contains(string key); // 0x000000018D493CF0-0x000000018D493D38
	}

	[SerializationVersion("A", new System.Type[0])]
	public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, ISpecifiesCloner // TypeDefIndex: 86302
	{
		// Fields
		public VariableKind Kind; // 0x10
		[InspectorWide(true)]
		[Serialize]
		private VariableDeclarationCollection collection; // 0x18
		internal Action OnVariableChanged; // 0x20
	
		// Properties
		public object this[[InspectorVariableName(ActionDirection.Any)] string variable] { get => default; set {} } // 0x000000018D4941BC-0x000000018D4941C4 0x000000018D4941C4-0x000000018D4941CC
		ICloner ISpecifiesCloner.cloner { get; } // 0x000000018D49416C-0x000000018D4941BC 
	
		// Constructors
		public VariableDeclarations(); // 0x0000000186D12F00-0x0000000186D12F70
	
		// Methods
		public void Set([InspectorVariableName(ActionDirection.Set)] string variable, object value); // 0x000000018D494024-0x000000018D494124
		public object Get([InspectorVariableName(ActionDirection.Get)] string variable); // 0x000000018D493E2C-0x000000018D493F64
		public void Clear(); // 0x000000018D493DE4-0x000000018D493E2C
		public bool IsDefined([InspectorVariableName(ActionDirection.Any)] string variable); // 0x000000018D493F64-0x000000018D494024
		public IEnumerator<VariableDeclaration> GetEnumerator(); // 0x00000001861B1C10-0x00000001861B1C60
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D494124-0x000000018D49416C
	}

	public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations> // TypeDefIndex: 86303
	{
		// Fields
		public static readonly VariableDeclarationsCloner instance; // 0x00
	
		// Constructors
		public VariableDeclarationsCloner(); // 0x00000001871799B0-0x00000001871799E0
		static VariableDeclarationsCloner(); // 0x0000000187179940-0x00000001871799B0
	
		// Methods
		public override bool Handles(System.Type type); // 0x000000018D493D80-0x000000018D493DE4
		public override VariableDeclarations ConstructClone(System.Type type, VariableDeclarations original); // 0x0000000186D12E40-0x0000000186D12E90
		public override void FillClone(System.Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context); // 0x00000001861B1A20-0x00000001861B1C10
	}

	public enum VariableKind // TypeDefIndex: 86304
	{
		Flow = 0,
		Graph = 1,
		Object = 2,
		Scene = 3,
		Application = 4,
		Saved = 5
	}

	[IncludeInSettings(false)]
	public sealed class VariablesAsset : LudiqScriptableObject // TypeDefIndex: 86305
	{
		// Fields
		[CompilerGenerated]
		private VariableDeclarations _declarations_k__BackingField; // 0x30
	
		// Properties
		[Inspectable]
		[InspectorWide(true)]
		[Serialize]
		public VariableDeclarations declarations { [CompilerGenerated] get; [CompilerGenerated] internal set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
	
		// Constructors
		public VariablesAsset(); // 0x0000000186D12E90-0x0000000186D12F00
	
		// Methods
		[ContextMenu("Show Data...")]
		protected override void ShowData(); // 0x000000018D4941CC-0x000000018D4941D4
	}

	[AddComponentMenu("")]
	[DisableAnnotation]
	[IncludeInSettings(false)]
	[Singleton(Name = "VisualScripting SavedVariablesSerializer", Automatic = true, Persistent = true)]
	public class VariablesSaver : MonoBehaviour, ISingleton // TypeDefIndex: 86306
	{
		// Properties
		public static VariablesSaver instance { get; } // 0x000000018D4942E4-0x000000018D494338 
	
		// Constructors
		public VariablesSaver(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018D4941D4-0x000000018D494228
		private void OnDestroy(); // 0x000000018D494290-0x000000018D4942E4
		private void OnApplicationQuit(); // 0x000000018D494288-0x000000018D494290
		private void OnApplicationPause(bool isPaused); // 0x000000018D49427C-0x000000018D494288
		public static void Instantiate(); // 0x000000018D494228-0x000000018D49427C
	}
}

namespace Unity.VisualScripting.FullSerializer
{
	public class fsArrayConverter : fsConverter // TypeDefIndex: 86307
	{
		// Constructors
		public fsArrayConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D479858-0x000000018D479878
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4947EC-0x000000018D4949D0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D494580-0x000000018D4947EC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D49450C-0x000000018D494580
	}

	public class fsDateConverter : fsConverter // TypeDefIndex: 86308
	{
		// Properties
		private string DateTimeFormatString { get; } // 0x000000018D49758C-0x000000018D4975E0 
	
		// Constructors
		public fsDateConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D496D38-0x000000018D496DFC
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D497384-0x000000018D49758C
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D496DFC-0x000000018D497384
	}

	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 86309
	{
		// Constructors
		public fsDictionaryConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D497880-0x000000018D4978F8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D4978F8-0x000000018D49796C
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x000000018D497A88-0x000000018D49828C
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018D49828C-0x000000018D4987CC
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value); // 0x000000018D4975E0-0x000000018D497880
		private static void GetKeyValueTypes(System.Type dictionaryType, out System.Type keyStorageType, out System.Type valueStorageType); // 0x000000018D49796C-0x000000018D497A88
	}

	public class fsEnumConverter : fsConverter // TypeDefIndex: 86312
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 86310
		{
			// Fields
			public Enum x; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal ValueTuple<Enum, string> _TryDeserialize_b__3(RenamedFromAttribute attr); // 0x000000018D493B3C-0x000000018D493BAC
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86311
		{
			// Fields
			public static readonly __c __9; // 0x00
			[TupleElementNames(new string[2] {"x", "previousName" })]
			public static Func<Enum, IEnumerable<ValueTuple<Enum, string>>> __9__5_0; // 0x08
			[TupleElementNames(new string[2] {"enumMember", "previousName" })]
			public static Func<ValueTuple<Enum, string>, string> __9__5_1; // 0x10
			[TupleElementNames(new string[2] {"enumMember", "previousName" })]
			public static Func<ValueTuple<Enum, string>, Enum> __9__5_2; // 0x18
	
			// Constructors
			static __c(); // 0x000000018D493BAC-0x000000018D493C10
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal IEnumerable<ValueTuple<Enum, string>> _TryDeserialize_b__5_0(Enum x); // 0x000000018D493884-0x000000018D493984
			internal string _TryDeserialize_b__5_1([TupleElementNames(new string[2] {"enumMember", "previousName" })] ValueTuple<Enum, string> x); // 0x0000000187243100-0x0000000187243110
			internal Enum _TryDeserialize_b__5_2([TupleElementNames(new string[2] {"enumMember", "previousName" })] ValueTuple<Enum, string> x); // 0x00000001841B1140-0x00000001841B1150
		}
	
		// Constructors
		public fsEnumConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D498930-0x000000018D498988
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D498988-0x000000018D498A00
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D499194-0x000000018D499668
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D498A00-0x000000018D499194
		private static bool ArrayContains<T>(T[] values, T value);
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class fsForwardAttribute : Attribute // TypeDefIndex: 86313
	{
		// Fields
		public string MemberName; // 0x10
	}

	public class fsForwardConverter : fsConverter // TypeDefIndex: 86314
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018CB574E4-0x000000018CB57508
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D499668-0x000000018D4996C4
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x000000018D499738-0x000000018D499914
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D499AAC-0x000000018D499C18
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D499914-0x000000018D499AAC
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D4996C4-0x000000018D499738
	}

	public class fsGuidConverter : fsConverter // TypeDefIndex: 86315
	{
		// Constructors
		public fsGuidConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D499C98-0x000000018D499CFC
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D499E44-0x000000018D499F40
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D499D3C-0x000000018D499E44
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D499CFC-0x000000018D499D3C
	}

	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 86316
	{
		// Constructors
		public fsIEnumerableConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D499F40-0x000000018D499FD8
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D499FD8-0x000000018D49A04C
		public override fsResult TrySerialize(object instance_, out fsData serialized, System.Type storageType); // 0x000000018D49A724-0x000000018D49AAA8
		private bool IsStack(System.Type type); // 0x000000018D49A2F0-0x000000018D49A3A8
		public override fsResult TryDeserialize(fsData data, ref object instance_, System.Type storageType); // 0x000000018D49A43C-0x000000018D49A724
		private static int HintSize(IEnumerable collection); // 0x000000018D49A278-0x000000018D49A2F0
		private static System.Type GetElementType(System.Type objectType); // 0x000000018D49A18C-0x000000018D49A278
		private static void TryClear(System.Type type, object instance); // 0x000000018D49A3A8-0x000000018D49A43C
		private static MethodInfo GetAddMethod(System.Type type); // 0x000000018D49A04C-0x000000018D49A18C
	}

	public class fsKeyValuePairConverter : fsConverter // TypeDefIndex: 86317
	{
		// Constructors
		public fsKeyValuePairConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D49DF98-0x000000018D49E044
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D49E044-0x000000018D49E440
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D49E440-0x000000018D49E6FC
	}

	public class fsNullableConverter : fsConverter // TypeDefIndex: 86318
	{
		// Constructors
		public fsNullableConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A0744-0x000000018D4A07F0
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4A0868-0x000000018D4A08E0
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4A07F0-0x000000018D4A0868
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000187239520-0x0000000187239530
	}

	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 86319
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A1198-0x000000018D4A1260
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4A1804-0x000000018D4A1DB0
		public override fsResult TryDeserialize(fsData storage, ref object instance, System.Type storageType); // 0x000000018D4A1260-0x000000018D4A1804
		private static bool UseBool(System.Type type); // 0x000000018D4A1DB0-0x000000018D4A1E14
		private static bool UseInt64(System.Type type); // 0x000000018D4A1ED8-0x000000018D4A2094
		private static bool UseDouble(System.Type type); // 0x000000018D4A1E14-0x000000018D4A1ED8
		private static bool UseString(System.Type type); // 0x000000018D4A2094-0x000000018D4A212C
	}

	public class fsReflectedConverter : fsConverter // TypeDefIndex: 86320
	{
		// Constructors
		public fsReflectedConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A212C-0x000000018D4A21D8
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4A24C0-0x000000018D4A2710
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4A224C-0x000000018D4A24C0
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D4A21D8-0x000000018D4A224C
	}

	public class fsTypeConverter : fsConverter // TypeDefIndex: 86321
	{
		// Constructors
		public fsTypeConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A889C-0x000000018D4A8914
		public override bool RequestCycleSupport(System.Type type); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type type); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4A8A90-0x000000018D4A8B88
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4A8914-0x000000018D4A8A90
		public override object CreateInstance(fsData data, System.Type storageType); // 0x0000000187239520-0x0000000187239530
	}

	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 86322
	{
		// Constructors
		public fsWeakReferenceConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A9F98-0x000000018D4A9FFC
		public override bool RequestCycleSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override bool RequestInheritanceSupport(System.Type storageType); // 0x00000001843FFFF0-0x0000000184400000
		public override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType); // 0x000000018D4AA384-0x000000018D4AA634
		public override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType); // 0x000000018D4AA054-0x000000018D4AA384
		public override object CreateInstance(fsData data, System.Type storageType); // 0x000000018D4A9FFC-0x000000018D4AA054
	}

	public class fsConverterRegistrar // TypeDefIndex: 86323
	{
		// Fields
		public static List<System.Type> Converters; // 0x00
	
		// Constructors
		static fsConverterRegistrar(); // 0x000000018D495414-0x000000018D49573C
	}

	public class fsAotCompilationManager // TypeDefIndex: 86325
	{
		// Fields
		private static Dictionary<System.Type, string> _computedAotCompilations; // 0x00
		private static List<AotCompilation> _uncomputedAotCompilations; // 0x08
	
		// Nested types
		private struct AotCompilation // TypeDefIndex: 86324
		{
			// Fields
			public System.Type Type; // 0x00
			public fsMetaProperty[] Members; // 0x08
			public bool IsConstructorPublic; // 0x10
		}
	
		// Constructors
		static fsAotCompilationManager(); // 0x000000018D494418-0x000000018D49450C
	
		// Methods
		public static void AddAotCompilation(System.Type type, fsMetaProperty[] members, bool isConstructorPublic); // 0x000000018D494338-0x000000018D494418
	}

	public abstract class fsBaseConverter // TypeDefIndex: 86327
	{
		// Fields
		public fsSerializer Serializer; // 0x10
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86326
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<fsDataType, string> __9__6_0; // 0x08
	
			// Constructors
			static __c(); // 0x000000018D493C10-0x000000018D493C74
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _FailExpectedType_b__6_0(fsDataType t); // 0x000000018D493834-0x000000018D493884
		}
	
		// Constructors
		protected fsBaseConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual object CreateInstance(fsData data, System.Type storageType); // 0x000000018D494E00-0x000000018D494F54
		public virtual bool RequestCycleSupport(System.Type storageType); // 0x000000018D495298-0x000000018D49534C
		public virtual bool RequestInheritanceSupport(System.Type storageType); // 0x000000018D49534C-0x000000018D49539C
		public abstract fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public abstract fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected fsResult FailExpectedType(fsData data, params fsDataType[] types); // 0x000000018D494F54-0x000000018D495298
		protected fsResult CheckType(fsData data, fsDataType type); // 0x000000018D494BE8-0x000000018D494E00
		protected fsResult CheckKey(fsData data, string key, out fsData subitem); // 0x000000018D4949D0-0x000000018D494A40
		protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem); // 0x000000018D494A40-0x000000018D494BE8
		protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, T value);
		protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, System.Type overrideConverterType, string name, out ref T value);
	}

	public static class fsGlobalConfig // TypeDefIndex: 86328
	{
		// Fields
		public static bool IsCaseSensitive; // 0x00
		public static bool AllowInternalExceptions; // 0x01
		public static string InternalFieldPrefix; // 0x08
	
		// Constructors
		static fsGlobalConfig(); // 0x000000018D499C18-0x000000018D499C98
	}

	public class fsConfig // TypeDefIndex: 86330
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
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 86329
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<string, MemberInfo, string> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E5900-0x00000001871E5960
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _.ctor_b__10_0(string name, MemberInfo info); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Constructors
		public fsConfig(); // 0x0000000186AB9B70-0x0000000186AB9EA0
	}

	public sealed class fsContext // TypeDefIndex: 86331
	{
		// Fields
		private readonly Dictionary<System.Type, object> _contextObjects; // 0x10
	
		// Constructors
		public fsContext(); // 0x000000018D49539C-0x000000018D495414
	
		// Methods
		public void Set<T>(T obj);
		public T Get<T>();
	}

	public abstract class fsConverter : fsBaseConverter // TypeDefIndex: 86332
	{
		// Constructors
		protected fsConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public abstract bool CanProcess(System.Type type);
	}

	public enum fsDataType // TypeDefIndex: 86333
	{
		Array = 0,
		Object = 1,
		Double = 2,
		Int64 = 3,
		Boolean = 4,
		String = 5,
		Null = 6
	}

	public sealed class fsData // TypeDefIndex: 86334
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get; } // 0x000000018D496AB8-0x000000018D496C14 
		public bool IsNull { get; } // 0x0000000185371DA0-0x0000000185371DB0 
		public bool IsDouble { get; } // 0x000000018D496990-0x000000018D4969DC 
		public bool IsInt64 { get; } // 0x000000018D4969DC-0x000000018D496A28 
		public bool IsBool { get; } // 0x000000018D496900-0x000000018D49694C 
		public bool IsString { get; } // 0x000000018D496A6C-0x000000018D496AB8 
		public bool IsDictionary { get; } // 0x000000018D49694C-0x000000018D496990 
		public bool IsList { get; } // 0x000000018D496A28-0x000000018D496A6C 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public double AsDouble { get; } // 0x000000018D496810-0x000000018D49684C 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long AsInt64 { get; } // 0x000000018D49684C-0x000000018D496888 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public bool AsBool { get; } // 0x000000018D496798-0x000000018D4967D4 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string AsString { get; } // 0x000000018D4968C4-0x000000018D496900 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Dictionary<string, fsData> AsDictionary { get; } // 0x000000018D4967D4-0x000000018D496810 
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public List<fsData> AsList { get; } // 0x000000018D496888-0x000000018D4968C4 
	
		// Constructors
		public fsData(); // 0x00000001863017D0-0x00000001863017F0
		public fsData(bool boolean); // 0x000000018D496684-0x000000018D4966E0
		public fsData(double f); // 0x000000018D4966E0-0x000000018D49673C
		public fsData(long i); // 0x000000018D49673C-0x000000018D496798
		public fsData(string str); // 0x0000000184FD2410-0x0000000184FD2420
		public fsData(Dictionary<string, fsData> dict); // 0x0000000184FD2410-0x0000000184FD2420
		public fsData(List<fsData> list); // 0x0000000184FD2410-0x0000000184FD2420
		static fsData(); // 0x000000018D496578-0x000000018D496684
	
		// Methods
		public override string ToString(); // 0x000000018D496570-0x000000018D496578
		public static fsData CreateDictionary(); // 0x000000018D495E30-0x000000018D495F24
		public static fsData CreateList(int capacity); // 0x000000018D495F24-0x000000018D495FC0
		internal void BecomeDictionary(); // 0x000000018D495D4C-0x000000018D495DC4
		internal fsData Clone(); // 0x000000018D495DC4-0x000000018D495E30
		private T Cast<T>();
		public override bool Equals(object obj); // 0x000000018D495FC0-0x000000018D496024
		public bool Equals(fsData other); // 0x000000018D496024-0x000000018D496570
		public static bool operator ==(fsData a, fsData b); // 0x000000018D496C14-0x000000018D496CE4
		public static bool operator !=(fsData a, fsData b); // 0x000000018D496CE4-0x000000018D496D38
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
	}

	public abstract class fsDirectConverter : fsBaseConverter // TypeDefIndex: 86335
	{
		// Properties
		public abstract System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public abstract class fsDirectConverter<TModel> : fsDirectConverter // TypeDefIndex: 86336
	{
		// Properties
		public override System.Type ModelType { get; }
	
		// Constructors
		protected fsDirectConverter();
	
		// Methods
		public sealed override fsResult TrySerialize(object instance, out fsData serialized, System.Type storageType);
		public sealed override fsResult TryDeserialize(fsData data, ref object instance, System.Type storageType);
		protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);
		protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref ref TModel model);
	}

	public sealed class fsMissingVersionConstructorException : Exception // TypeDefIndex: 86337
	{
		// Constructors
		public fsMissingVersionConstructorException(System.Type versionedType, System.Type constructorType); // 0x000000018D4A0678-0x000000018D4A0744
	}

	public sealed class fsDuplicateVersionNameException : Exception // TypeDefIndex: 86338
	{
		// Constructors
		public fsDuplicateVersionNameException(System.Type typeA, System.Type typeB, string version); // 0x000000018D4987CC-0x000000018D498930
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class fsIgnoreAttribute : Attribute // TypeDefIndex: 86339
	{
	}

	public interface fsISerializationCallbacks // TypeDefIndex: 86340
	{
		// Methods
		void OnBeforeSerialize(System.Type storageType);
		void OnAfterSerialize(System.Type storageType, ref fsData data);
		void OnBeforeDeserialize(System.Type storageType, ref fsData data);
		void OnAfterDeserialize(System.Type storageType);
	}

	public class fsSerializationCallbackProcessor : fsObjectProcessor // TypeDefIndex: 86341
	{
		// Constructors
		public fsSerializationCallbackProcessor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A30D0-0x000000018D4A3148
		public override void OnBeforeSerialize(System.Type storageType, object instance); // 0x000000018D4A33D4-0x000000018D4A3450
		public override void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x000000018D4A31C4-0x000000018D4A3254
		public override void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x000000018D4A3254-0x000000018D4A33D4
		public override void OnAfterDeserialize(System.Type storageType, object instance); // 0x000000018D4A3148-0x000000018D4A31C4
	}

	public class fsSerializationCallbackReceiverProcessor : fsObjectProcessor // TypeDefIndex: 86342
	{
		// Constructors
		public fsSerializationCallbackReceiverProcessor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public override bool CanProcess(System.Type type); // 0x000000018D4A3450-0x000000018D4A34C8
		public override void OnBeforeSerialize(System.Type storageType, object instance); // 0x000000018D4A354C-0x000000018D4A35D0
		public override void OnAfterDeserialize(System.Type storageType, object instance); // 0x000000018D4A34C8-0x000000018D4A354C
	}

	public class fsJsonParser // TypeDefIndex: 86343
	{
		// Fields
		private readonly StringBuilder _cachedStringBuilder; // 0x10
		private int _start; // 0x18
		private string _input; // 0x20
	
		// Constructors
		private fsJsonParser(string input); // 0x000000018D49CAA0-0x000000018D49CB2C
	
		// Methods
		private fsResult MakeFailure(string message); // 0x000000018D49ABA4-0x000000018D49AD30
		private bool TryMoveNext(); // 0x000000018D49B494-0x000000018D49B4C0
		private bool HasValue(); // 0x000000018D49AAE0-0x000000018D49AAEC
		private bool HasValue(int offset); // 0x000000018D49AAEC-0x000000018D49AB20
		private char Character(); // 0x000000018D49AAA8-0x000000018D49AAB4
		private char Character(int offset); // 0x000000018D49AAB4-0x000000018D49AAE0
		private void SkipSpace(); // 0x000000018D49B2B8-0x000000018D49B494
		private fsResult TryParseExact(string content); // 0x000000018D49B788-0x000000018D49B8CC
		private fsResult TryParseTrue(out fsData data); // 0x000000018D49C4C0-0x000000018D49C5C0
		private fsResult TryParseFalse(out fsData data); // 0x000000018D49B8CC-0x000000018D49B9CC
		private fsResult TryParseNull(out fsData data); // 0x000000018D49B9CC-0x000000018D49BACC
		private bool IsSeparator(char c); // 0x000000018D49AB48-0x000000018D49ABA4
		private fsResult TryParseNumber(out fsData data); // 0x000000018D49BACC-0x000000018D49BDEC
		private fsResult TryParseString(out string str); // 0x000000018D49C208-0x000000018D49C4C0
		private fsResult TryParseArray(out fsData arr); // 0x000000018D49B4C0-0x000000018D49B788
		private fsResult TryParseObject(out fsData obj); // 0x000000018D49BDEC-0x000000018D49C208
		private fsResult RunParse(out fsData data); // 0x000000018D49AF5C-0x000000018D49B2B8
		public static fsResult Parse(string input, out fsData data); // 0x000000018D49AE70-0x000000018D49AF5C
		public static fsData Parse(string input); // 0x000000018D49ADF8-0x000000018D49AE70
		private bool IsHex(char c); // 0x000000018D49AB20-0x000000018D49AB48
		private uint ParseSingleChar(char c1, uint multipliyer); // 0x000000018D49AD30-0x000000018D49AD74
		private uint ParseUnicode(char c1, char c2, char c3, char c4); // 0x000000018D49AD74-0x000000018D49ADF8
		private fsResult TryUnescapeChar(out char escaped); // 0x000000018D49C5C0-0x000000018D49CAA0
	}

	public static class fsJsonPrinter // TypeDefIndex: 86344
	{
		// Methods
		private static void InsertSpacing(TextWriter stream, int count); // 0x000000018D49DDC0-0x000000018D49DE2C
		private static string EscapeString(string str); // 0x000000018D49DB18-0x000000018D49DDC0
		private static void BuildCompressedString(fsData data, TextWriter stream); // 0x000000018D49CB2C-0x000000018D49D10C
		private static void BuildPrettyString(fsData data, TextWriter stream, int depth); // 0x000000018D49D10C-0x000000018D49D870
		public static string PrettyJson(fsData data); // 0x000000018D49DE2C-0x000000018D49DF98
		public static string CompressedJson(fsData data); // 0x000000018D49D870-0x000000018D49D9DC
		private static string ConvertDoubleToString(double d); // 0x000000018D49D9DC-0x000000018D49DB18
	}

	public enum fsMemberSerialization // TypeDefIndex: 86345
	{
		OptIn = 0,
		OptOut = 1,
		Default = 2
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class fsObjectAttribute : Attribute // TypeDefIndex: 86346
	{
		// Fields
		public System.Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public System.Type Converter; // 0x28
		public System.Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute(); // 0x000000018723F720-0x000000018723F730
		public fsObjectAttribute(string versionString, params System.Type[] previousModels); // 0x000000018D4A08E0-0x000000018D4A0910
	}

	public abstract class fsObjectProcessor // TypeDefIndex: 86347
	{
		// Constructors
		protected fsObjectProcessor(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public virtual bool CanProcess(System.Type type); // 0x000000018D4A0910-0x000000018D4A095C
		public virtual void OnBeforeSerialize(System.Type storageType, object instance); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterSerialize(System.Type storageType, object instance, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBeforeDeserialize(System.Type storageType, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref fsData data); // 0x0000000186805BA0-0x0000000186805BB0
		public virtual void OnAfterDeserialize(System.Type storageType, object instance); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class fsPropertyAttribute : Attribute // TypeDefIndex: 86348
	{
		// Fields
		public string Name; // 0x10
		public System.Type Converter; // 0x18
	
		// Constructors
		public fsPropertyAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public struct fsResult // TypeDefIndex: 86349
	{
		// Fields
		private static readonly string[] EmptyStringArray; // 0x00
		private bool _success; // 0x00
		private List<string> _messages; // 0x08
		public static fsResult Success; // 0x08
	
		// Properties
		public bool Failed { get; } // 0x00000001857A8050-0x00000001857A8060 
		public bool Succeeded { get; } // 0x00000001844AD2A0-0x00000001844AD2B0 
		public bool HasWarnings { get; } // 0x000000018D4A2FB4-0x000000018D4A3000 
		public Exception AsException { get; } // 0x000000018D4A2DBC-0x000000018D4A2ED4 
		public IEnumerable<string> RawMessages { get; } // 0x000000018D4A3000-0x000000018D4A3058 
		public string FormattedMessages { get; } // 0x000000018D4A2ED4-0x000000018D4A2FB4 
	
		// Constructors
		static fsResult(); // 0x000000018D4A2D1C-0x000000018D4A2DBC
	
		// Methods
		public void AddMessage(string message); // 0x000000018D4A28E8-0x000000018D4A2998
		public void AddMessages(fsResult result); // 0x000000018D4A2998-0x000000018D4A2A50
		public fsResult Merge(fsResult other); // 0x000000018D4A2B88-0x000000018D4A2C6C
		public static fsResult Warn(string warning); // 0x000000018D4A2C6C-0x000000018D4A2D1C
		public static fsResult Fail(string warning); // 0x000000018D4A2ADC-0x000000018D4A2B88
		public static fsResult operator +(fsResult a, fsResult b); // 0x000000018D4A3058-0x000000018D4A30D0
		public fsResult AssertSuccess(); // 0x000000018D4A2A50-0x000000018D4A2ADC
	}

	public class fsSerializer // TypeDefIndex: 86351
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
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 86350
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x000000018D49EAC8-0x000000018D49EB88
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x000000018D49E764-0x000000018D49E8B4
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x000000018D49E8B4-0x000000018D49EAC8
			public void Clear(); // 0x000000018D49E6FC-0x000000018D49E764
		}
	
		// Constructors
		public fsSerializer(); // 0x000000018D4A7E40-0x000000018D4A889C
		static fsSerializer(); // 0x000000018D4A78F4-0x000000018D4A7E40
	
		// Methods
		private void RemapAbstractStorageTypeToDefaultType(ref System.Type storageType); // 0x000000018D4A6EE0-0x000000018D4A7074
		public void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType); // 0x000000018D4A7074-0x000000018D4A7170
		private List<fsObjectProcessor> GetProcessors(System.Type type); // 0x000000018D4A4E1C-0x000000018D4A5078
		public void AddConverter(fsBaseConverter converter); // 0x000000018D4A35D0-0x000000018D4A3854
		private fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType); // 0x000000018D4A3C2C-0x000000018D4A4020
		public fsResult TrySerialize<T>(T instance, out fsData data);
		public fsResult TryDeserialize<T>(fsData data, ref ref T instance);
		public fsResult TrySerialize(System.Type storageType, object instance, out fsData data); // 0x000000018D4A78B4-0x000000018D4A78F4
		public fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018D4A7510-0x000000018D4A78B4
		private fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018D4A5D60-0x000000018D4A6128
		private fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, out fsData data); // 0x000000018D4A6128-0x000000018D4A63C4
		private fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, out fsData data); // 0x000000018D4A63C4-0x000000018D4A65D8
		private fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, out fsData data); // 0x000000018D4A65D8-0x000000018D4A6690
		public fsResult TryDeserialize(fsData data, System.Type storageType, ref object result); // 0x000000018D4A74D4-0x000000018D4A7510
		public fsResult TryDeserialize(fsData data, System.Type storageType, System.Type overrideConverterType, ref object result); // 0x000000018D4A7170-0x000000018D4A74D4
		private fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018D4A5078-0x000000018D4A5230
		private fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018D4A5230-0x000000018D4A56A4
		private fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, fsData data, System.Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018D4A56A4-0x000000018D4A5AEC
		private fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result); // 0x000000018D4A5AEC-0x000000018D4A5C30
		private fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, fsData data, System.Type resultType, ref object result); // 0x000000018D4A5C30-0x000000018D4A5D60
		private static System.Type GetDataType(ref fsData data, System.Type defaultType, ref fsResult deserializeResult); // 0x000000018D4A4020-0x000000018D4A4E1C
		private static void EnsureDictionary(fsData data); // 0x000000018D4A3B78-0x000000018D4A3C2C
		public static bool IsReservedKeyword(string key); // 0x000000018D4A6AB8-0x000000018D4A6B28
		private static bool IsObjectReference(fsData data); // 0x000000018D4A6A20-0x000000018D4A6AB8
		private static bool IsObjectDefinition(fsData data); // 0x000000018D4A6988-0x000000018D4A6A20
		private static bool IsVersioned(fsData data); // 0x000000018D4A6BC0-0x000000018D4A6C58
		private static bool IsTypeSpecified(fsData data); // 0x000000018D4A6B28-0x000000018D4A6BC0
		private static bool IsWrappedData(fsData data); // 0x000000018D4A6E48-0x000000018D4A6EE0
		private static bool IsVisualScriptingUnit(fsData data); // 0x000000018D4A6C58-0x000000018D4A6E48
		private static void ConvertLegacyData(ref fsData data); // 0x000000018D4A3854-0x000000018D4A3B78
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018D4A68EC-0x000000018D4A6988
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018D4A6728-0x000000018D4A67D4
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, System.Type storageType, ref fsData data); // 0x000000018D4A6880-0x000000018D4A68EC
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, System.Type storageType, object instance, ref fsData data); // 0x000000018D4A67D4-0x000000018D4A6880
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, System.Type storageType, object instance); // 0x000000018D4A6690-0x000000018D4A6728
	}

	public class fsMetaProperty // TypeDefIndex: 86352
	{
		// Fields
		internal MemberInfo _memberInfo; // 0x10
		[CompilerGenerated]
		private System.Type _StorageType_k__BackingField; // 0x18
		[CompilerGenerated]
		private System.Type _OverrideConverterType_k__BackingField; // 0x20
		[CompilerGenerated]
		private bool _CanRead_k__BackingField; // 0x28
		[CompilerGenerated]
		private bool _CanWrite_k__BackingField; // 0x29
		[CompilerGenerated]
		private string _JsonName_k__BackingField; // 0x30
		[CompilerGenerated]
		private string _MemberName_k__BackingField; // 0x38
		[CompilerGenerated]
		private bool _IsPublic_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _IsReadOnly_k__BackingField; // 0x41
	
		// Properties
		public System.Type StorageType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public System.Type OverrideConverterType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool CanRead { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DF70-0x000000018225DF80 0x000000018225DF80-0x000000018225DF90
		public bool CanWrite { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E0D0-0x000000018225E0E0 0x000000018225E0E0-0x000000018225E0F0
		public string JsonName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public string MemberName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public bool IsPublic { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		public bool IsReadOnly { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE60-0x000000018226EE70 0x000000018226EE70-0x000000018226EE80
	
		// Constructors
		internal fsMetaProperty(fsConfig config, System.Reflection.FieldInfo field); // 0x000000018D49F040-0x000000018D49F0E4
		internal fsMetaProperty(fsConfig config, PropertyInfo property); // 0x000000018D49EF20-0x000000018D49F040
	
		// Methods
		private void CommonInitialize(fsConfig config); // 0x000000018D49EB88-0x000000018D49EC60
		public void Write(object context, object value); // 0x000000018D49ED28-0x000000018D49EF20
		public object Read(object context); // 0x000000018D49EC60-0x000000018D49ED28
	}

	public class fsMetaType // TypeDefIndex: 86356
	{
		// Fields
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x19
		private bool _isDefaultConstructorPublic; // 0x1B
		[CompilerGenerated]
		private fsMetaProperty[] _Properties_k__BackingField; // 0x20
		private static Dictionary<fsConfig, Dictionary<System.Type, fsMetaType>> _configMetaTypes; // 0x00
	
		// Properties
		public fsMetaProperty[] Properties { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
		public bool HasDefaultConstructor { get; } // 0x000000018D4A050C-0x000000018D4A0678 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0 // TypeDefIndex: 86353
		{
			// Fields
			public MemberInfo member; // 0x10
	
			// Constructors
			public __c__DisplayClass16_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CollectProperties_b__0(System.Type t); // 0x000000018D493984-0x000000018D4939D8
			internal bool _CollectProperties_b__1(System.Type t); // 0x000000018D4939D8-0x000000018D493A2C
			internal bool _CollectProperties_b__2(System.Type t); // 0x000000018D493A2C-0x000000018D493A80
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0 // TypeDefIndex: 86354
		{
			// Fields
			public PropertyInfo property; // 0x10
	
			// Constructors
			public __c__DisplayClass18_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CanSerializeProperty_b__0(System.Type t); // 0x000000018D493A80-0x000000018D493AD4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 86355
		{
			// Fields
			public System.Reflection.FieldInfo field; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _CanSerializeField_b__0(System.Type t); // 0x000000018D493AD4-0x000000018D493B28
		}
	
		// Constructors
		private fsMetaType(fsConfig config, System.Type reflectedType); // 0x000000018D4A042C-0x000000018D4A050C
		static fsMetaType(); // 0x000000018D4A03A0-0x000000018D4A042C
	
		// Methods
		public bool EmitAotData(); // 0x000000018D49FF44-0x000000018D4A0024
		public object CreateInstance(); // 0x000000018D49FA38-0x000000018D49FF44
		public static fsMetaType Get(fsConfig config, System.Type type); // 0x000000018D4A0024-0x000000018D4A02D8
		private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, System.Type reflectedType); // 0x000000018D49F598-0x000000018D49FA38
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members); // 0x000000018D4A02D8-0x000000018D4A03A0
		private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue); // 0x000000018D49F2C4-0x000000018D49F598
		private static bool CanSerializeField(fsConfig config, System.Reflection.FieldInfo field, bool annotationFreeValue); // 0x000000018D49F0E4-0x000000018D49F2C4
	}

	public static class fsReflectionUtility // TypeDefIndex: 86357
	{
		// Methods
		public static System.Type GetInterface(System.Type type, System.Type interfaceType); // 0x000000018D4A2710-0x000000018D4A28E8
	}
}

namespace Unity.VisualScripting.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 86359
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 86358
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x0000000186805BA0-0x0000000186805BB0
			static ObjectReferenceEqualityComparator(); // 0x000000018D4937D0-0x000000018D493834
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x000000018A797384-0x000000018A79738C
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000187251670-0x0000000187251680
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x000000018D495C58-0x000000018D495D4C
	
		// Methods
		public void Enter(); // 0x000000018724CCC0-0x000000018724CCD0
		public bool Exit(); // 0x000000018D4957A0-0x000000018D495908
		public object GetReferenceObject(int id); // 0x000000018D4959B0-0x000000018D495AB8
		public void AddReferenceWithId(int id, object reference); // 0x000000018D49573C-0x000000018D4957A0
		public int GetReferenceId(object item); // 0x000000018D495908-0x000000018D4959B0
		public bool IsReference(object item); // 0x000000018D495AB8-0x000000018D495B28
		public void MarkSerialized(object item); // 0x000000018D495B28-0x000000018D495C58
	}

	public struct fsOption<T> // TypeDefIndex: 86360
	{
		// Fields
		private bool _hasValue;
		private T _value;
	
		// Properties
		public bool HasValue { get; }
		public bool IsEmpty { get; }
		public T Value { get; }
	
		// Constructors
		public fsOption(T value);
	}

	public static class fsOption // TypeDefIndex: 86361
	{
		// Methods
		public static fsOption<T> Just<T>(T value);
	}

	public static class fsPortableReflection // TypeDefIndex: 86364
	{
		// Fields
		public static System.Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static System.Reflection.BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 86362
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public System.Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 86363
		{
			// Constructors
			public AttributeQueryComparator(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y); // 0x000000018D493720-0x000000018D493784
			public int GetHashCode(AttributeQuery obj); // 0x000000018D493784-0x000000018D4937D0
		}
	
		// Constructors
		static fsPortableReflection(); // 0x000000018D4A1084-0x000000018D4A1198
	
		// Methods
		public static bool HasAttribute(MemberInfo element, System.Type attributeType); // 0x000000018D4A1030-0x000000018D4A1084
		public static bool HasAttribute(MemberInfo element, System.Type attributeType, bool shouldCache); // 0x0000000187838B98-0x0000000187838BA4
		public static Attribute GetAttribute(MemberInfo element, System.Type attributeType, bool shouldCache); // 0x000000018D4A095C-0x000000018D4A0AC8
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute;
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this System.Type type, string propertyName); // 0x000000018D4A0E64-0x000000018D4A0F24
		public static MethodInfo GetDeclaredMethod(this System.Type type, string methodName); // 0x000000018D4A0CEC-0x000000018D4A0DAC
		public static ConstructorInfo GetDeclaredConstructor(this System.Type type, System.Type[] parameters); // 0x000000018D4A0AC8-0x000000018D4A0BD0
		public static ConstructorInfo[] GetDeclaredConstructors(this System.Type type); // 0x000000018D4A0BD0-0x000000018D4A0C34
		public static MethodInfo GetFlattenedMethod(this System.Type type, string methodName); // 0x000000018D4A0F24-0x000000018D4A1030
		public static MethodInfo[] GetDeclaredMethods(this System.Type type); // 0x000000018D4A0DAC-0x000000018D4A0E08
		public static PropertyInfo[] GetDeclaredProperties(this System.Type type); // 0x000000018D4A0E08-0x000000018D4A0E64
		public static System.Reflection.FieldInfo[] GetDeclaredFields(this System.Type type); // 0x000000018D4A0C34-0x000000018D4A0C90
		public static MemberInfo[] GetDeclaredMembers(this System.Type type); // 0x000000018D4A0C90-0x000000018D4A0CEC
		public static System.Type Resolve(this System.Type type); // 0x0000000185BD80B0-0x0000000185BD80C0
	}

	public static class fsTypeExtensions // TypeDefIndex: 86366
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0 // TypeDefIndex: 86365
		{
			// Fields
			public bool includeNamespace; // 0x10
	
			// Constructors
			public __c__DisplayClass2_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _CSharpName_b__0(System.Type t); // 0x000000018D493B28-0x000000018D493B3C
		}
	
		// Extension methods
		public static string CSharpName(this System.Type type); // 0x000000018D4A90E8-0x000000018D4A90F4
		public static string CSharpName(this System.Type type, bool includeNamespace); // 0x000000018D4A8B88-0x000000018D4A90E8
	}

	public struct fsVersionedType // TypeDefIndex: 86367
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public System.Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance); // 0x000000018D4A9DCC-0x000000018D4A9E58
		public override string ToString(); // 0x000000018D4A9E58-0x000000018D4A9F98
		public override bool Equals(object obj); // 0x000000018D4A9D50-0x000000018D4A9DCC
		public override int GetHashCode(); // 0x000000018A92B598-0x000000018A92B5BC
	}

	public static class fsVersionManager // TypeDefIndex: 86368
	{
		// Fields
		private static readonly Dictionary<System.Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager(); // 0x000000018D4A9CC4-0x000000018D4A9D50
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path); // 0x000000018D4A921C-0x000000018D4A9454
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current); // 0x000000018D4A90F4-0x000000018D4A921C
		public static fsOption<fsVersionedType> GetVersionedType(System.Type type); // 0x000000018D4A9454-0x000000018D4A98C4
		private static void VerifyConstructors(fsVersionedType type); // 0x000000018D4A98C4-0x000000018D4A9A58
		private static void VerifyUniqueVersionStrings(fsVersionedType type); // 0x000000018D4A9A58-0x000000018D4A9CC4
	}
}
